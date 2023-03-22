using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Management;
using Microsoft.VisualBasic;
using System.Configuration;
using System.Globalization;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;
using uart.Sourses;

namespace uart
{
    public partial class MainForm : Form
    {
        private UInt64 g_counterForRxData = 0;
        private UInt64 g_counterForTxData = 0;
        private ushort g_mulTxNum_Old;
        private ushort g_mulTxNum_New;
        private bool g_clearedThisTime = false;
        private byte[] rxButter = new byte[10000];
        public FormForAscii formForASCII;
        public FormForWave formForDisplay;
        public FormForCheck formForCheck;

        //枚举win32 api
        private enum HardwareEnum
        {
            // 硬件
            Win32_Processor, // CPU 处理器
            Win32_PhysicalMemory, // 物理内存条
            Win32_Keyboard, // 键盘
            Win32_PointingDevice, // 点输入设备，包括鼠标。
            Win32_FloppyDrive, // 软盘驱动器
            Win32_DiskDrive, // 硬盘驱动器
            Win32_CDROMDrive, // 光盘驱动器
            Win32_BaseBoard, // 主板
            Win32_BIOS, // BIOS 芯片
            Win32_ParallelPort, // 并口
            Win32_SerialPort, // 串口
            Win32_SerialPortConfiguration, // 串口配置
            Win32_SoundDevice, // 多媒体设置，一般指声卡。
            Win32_SystemSlot, // 主板插槽 (ISA & PCI & AGP)
            Win32_USBController, // USB 控制器
            Win32_NetworkAdapter, // 网络适配器
            Win32_NetworkAdapterConfiguration, // 网络适配器设置
            Win32_Printer, // 打印机
            Win32_PrinterConfiguration, // 打印机设置
            Win32_PrintJob, // 打印机任务
            Win32_TCPIPPrinterPort, // 打印机端口
            Win32_POTSModem, // MODEM
            Win32_POTSModemToSerialPort, // MODEM 端口
            Win32_DesktopMonitor, // 显示器
            Win32_DisplayConfiguration, // 显卡
            Win32_DisplayControllerConfiguration, // 显卡设置
            Win32_VideoController, // 显卡细节。
            Win32_VideoSettings, // 显卡支持的显示模式。

            // 操作系统
            Win32_TimeZone, // 时区
            Win32_SystemDriver, // 驱动程序
            Win32_DiskPartition, // 磁盘分区
            Win32_LogicalDisk, // 逻辑磁盘
            Win32_LogicalDiskToPartition, // 逻辑磁盘所在分区及始末位置。
            Win32_LogicalMemoryConfiguration, // 逻辑内存配置
            Win32_PageFile, // 系统页文件信息
            Win32_PageFileSetting, // 页文件设置
            Win32_BootConfiguration, // 系统启动配置
            Win32_ComputerSystem, // 计算机信息简要
            Win32_OperatingSystem, // 操作系统信息
            Win32_StartupCommand, // 系统自动启动程序
            Win32_Service, // 系统安装的服务
            Win32_Group, // 系统管理组
            Win32_GroupUser, // 系统组帐号
            Win32_UserAccount, // 用户帐号
            Win32_Process, // 系统进程
            Win32_Thread, // 系统线程
            Win32_Share, // 共享
            Win32_NetworkClient, // 已安装的网络客户端
            Win32_NetworkProtocol, // 已安装的网络协议
            Win32_PnPEntity,//all device
        }
        
        //WMI取硬件信息
        private static string[] MulGetHardwareInfo(HardwareEnum hardType, string propKey)
        {
            List<string> strs = new List<string>();
            try
            {
                using (ManagementObjectSearcher searcher = new ManagementObjectSearcher("select * from " + hardType))
                {
                    var hardInfos = searcher.Get();
                    foreach (var hardInfo in hardInfos)
                    {
                        if (hardInfo.Properties[propKey].Value != null)
                        {
                            if (hardInfo.Properties[propKey].Value.ToString().Contains("(COM"))
                            {
                                strs.Add(hardInfo.Properties[propKey].Value.ToString());
                            }
                        }
                    }
                    searcher.Dispose();
                }
                return strs.ToArray();
            }
            catch
            {
                return null;
            }
            finally
            {
                strs = null;
            }
        }

        private bool GetComsExplain()
        {
            comboBoxForComSelect.Items.Clear();

            string[] tmpComsExplain;
            tmpComsExplain = MulGetHardwareInfo(HardwareEnum.Win32_PnPEntity, "Name");
            comboBoxForComSelect.Items.AddRange(tmpComsExplain);

            return tmpComsExplain.Length != 0;
        }

        private static string FilterCom(string comExplain)
        {
            bool flagForFindCom = false;
            string tmpCom = null;
            byte countForCharInCom = 0;

            foreach (char tmpChar in comExplain)
            {
                if (countForCharInCom > 3 && !(tmpChar >= 0x30 && tmpChar <= 0x39))
                {
                    break;
                }
                if (flagForFindCom)
                {
                    countForCharInCom++;
                    tmpCom += tmpChar;
                }
                if (tmpChar == '(')
                {
                    flagForFindCom = true;
                }
            }
            return tmpCom;
        }

        private static void UpdateAppConfig(string newKey, string newValue)
        {
            string file = Application.ExecutablePath;
            Configuration config = ConfigurationManager.OpenExeConfiguration(file);
            bool exist = false;
            foreach (string key in config.AppSettings.Settings.AllKeys)
            {
                if (key == newKey)
                {
                    exist = true;
                }
            }
            if (exist)
            {
                config.AppSettings.Settings.Remove(newKey);
            }
            config.AppSettings.Settings.Add(newKey, newValue);
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
        }

        private static string GetAppConfig(string strKey)
        {
            string file = Application.ExecutablePath;
            Configuration config = ConfigurationManager.OpenExeConfiguration(file);
            foreach (string key in config.AppSettings.Settings.AllKeys)
            {
                if (key == strKey)
                {
                    return config.AppSettings.Settings[strKey].Value.ToString();
                }
            }
            return null;
        }

        private void initTextBoxAndSoon()
        {
            string tmpStr;

            tmpStr = GetAppConfig("textBoxForTxTimer");
            if (tmpStr != null && tmpStr != "") textBoxForTxTimer.Text = tmpStr;
            tmpStr = GetAppConfig("textBoxForTxArea");
            if (tmpStr != null && tmpStr != "") textBoxForTxArea.Text = tmpStr;
            tmpStr = GetAppConfig("textBoxForCrcCheckStartAddress");
            if (tmpStr != null && tmpStr != "") textBoxForCrcCheckStartAddress.Text = tmpStr;
            tmpStr = GetAppConfig("textBoxForCrcCheckLenth");
            if (tmpStr != null && tmpStr != "") textBoxForCrcCheckLenth.Text = tmpStr;
            tmpStr = GetAppConfig("textBoxForSumCheckStartAddress");
            if (tmpStr != null && tmpStr != "") textBoxForSumCheckStartAddress.Text = tmpStr;
            tmpStr = GetAppConfig("textBoxForSumCheckLenth");
            if (tmpStr != null && tmpStr != "") textBoxForSumCheckLenth.Text = tmpStr;

            if (Convert.ToInt16(GetAppConfig("checkBoxForRxNewLine")) == 1) checkBoxForRxNewLine.Checked = true;
            else checkBoxForRxNewLine.Checked = false;
            if (Convert.ToInt16(GetAppConfig("checkBoxForRxTimeDisplay")) == 1) checkBoxForRxTimeDisplay.Checked = true;
            else checkBoxForRxTimeDisplay.Checked = false;
            if (Convert.ToInt16(GetAppConfig("checkBoxForRxHex")) == 1) checkBoxForRxHex.Checked = true;
            else checkBoxForRxHex.Checked = false;
            if (Convert.ToInt16(GetAppConfig("checkBoxForRxAutoClear")) == 1) checkBoxForRxAutoClear.Checked = true;
            else checkBoxForRxAutoClear.Checked = false;
            if (Convert.ToInt16(GetAppConfig("checkBoxForTxHex")) == 1) checkBoxForTxHex.Checked = true;
            else checkBoxForTxHex.Checked = false;
            if (Convert.ToInt16(GetAppConfig("checkBoxForTxNewLine")) == 1) checkBoxForTxNewLine.Checked = true;
            else checkBoxForTxNewLine.Checked = false;
            if (Convert.ToInt16(GetAppConfig("checkBoxForCrcCheck")) == 1) checkBoxForCrcCheck.Checked = true;
            else checkBoxForCrcCheck.Checked = false;
            if (Convert.ToInt16(GetAppConfig("checkBoxForSumCheck")) == 1) checkBoxForSumCheck.Checked = true;
            else checkBoxForSumCheck.Checked = false;

            tmpStr = GetAppConfig("comboBoxForBaudRate");
            if (tmpStr != null && tmpStr != "") comboBoxForBaudRate.Text = tmpStr;
            tmpStr = GetAppConfig("comboBoxForStopBit");
            if (tmpStr != null && tmpStr != "") comboBoxForStopBit.Text = tmpStr;
            tmpStr = GetAppConfig("comboBoxForDataBit");
            if (tmpStr != null && tmpStr != "") comboBoxForCheck.Text = tmpStr;
            tmpStr = GetAppConfig("comboBoxForCheck");
            if (tmpStr != null && tmpStr != "") textBoxForTxArea.Text = tmpStr;

            tmpStr = GetAppConfig("g_mulTxNum_New");
            if (tmpStr != null && tmpStr != "")
            {
                textBoxForMulTxNum.Text = tmpStr;
                g_mulTxNum_New = Convert.ToUInt16(tmpStr);
            }
            else
            {
                g_mulTxNum_New = Convert.ToUInt16(textBoxForMulTxNum.Text);
            }

            //MulTxIsDisplay
            tmpStr = GetAppConfig("menuItemForMulTxView");
            if (tmpStr != null && tmpStr != "")
            {
                if (tmpStr.Equals("true"))
                {
                    splitContainer1.Panel2Collapsed = true;
                }
                else
                {
                    splitContainer1.Panel2Collapsed = false;
                }
            }
        }

        private void Init()
        {
            initTextBoxAndSoon();
            //Com
            comboBoxForComSelect.Text = GetAppConfig("Com");
            string tmpCom = comboBoxForComSelect.Text;
            if (tmpCom != null && SerialPort.GetPortNames().Contains(tmpCom))
            {
                Com.PortName = tmpCom;
            }
            else
            {
                if(GetComsExplain())
                {
                    comboBoxForComSelect.SelectedIndex = 0;
                    comboBoxForComSelect.Text = FilterCom(comboBoxForComSelect.Text);
                    Com.PortName = comboBoxForComSelect.Text;
                    UpdateAppConfig("Com", comboBoxForComSelect.Text);
                }
            }
            if(Com.IsOpen)
            {
                buttonForComSwitch.Text = "关闭串口";
                buttonForComSwitch.Image = Properties.Resources.openCom;
            }
        }

        private void MulTxBorn()
        {
            Button[] txButton = new Button[g_mulTxNum_New];
            CheckBox[] txCheck = new CheckBox[g_mulTxNum_New];
            TextBox[] txText = new TextBox[g_mulTxNum_New];

            for (int i = 0; i < g_mulTxNum_New; i++)
            {
                txButton[i] = new Button();
                this.splitContainer2.Panel2.Controls.Add(txButton[i]);
                txButton[i].Anchor = ((AnchorStyles)((
                    AnchorStyles.Left |
                    AnchorStyles.Right |
                    AnchorStyles.Top)));
                txButton[i].Name = "txButton[" + i.ToString() + ']';
                txButton[i].Text = GetAppConfig("txButton[" + i.ToString() + ']');
                txButton[i].Location = new Point(3, 3 + (i + 1) * 25);
                txButton[i].Size = buttonForMulTxBorn.Size;
                txButton[i].UseVisualStyleBackColor = true;
                txButton[i].MouseDown += new MouseEventHandler(this.buttonAllForMulTx_MouseDown);
                txButton[i].MouseClick += new MouseEventHandler(this.buttonAllForMulTx_MouseClick);

                txCheck[i] = new CheckBox();
                this.splitContainer2.Panel1.Controls.Add(txCheck[i]);
                txCheck[i].AutoSize = true;
                txCheck[i].Name = "txCheck[" + i.ToString() + ']';
                txCheck[i].Location = new Point(3, 3 + (i + 1) * 25);
                txCheck[i].Size = new Size(15, 14);
                txCheck[i].UseVisualStyleBackColor = true;

                txText[i] = new TextBox();
                this.splitContainer2.Panel1.Controls.Add(txText[i]);
                txText[i].Anchor = ((AnchorStyles)((
                    AnchorStyles.Left |
                    AnchorStyles.Right |
                    AnchorStyles.Top)));
                txText[i].Name = "txText[" + i.ToString() + ']';
                txText[i].Text = GetAppConfig("txText[" + i.ToString() + ']');
                txText[i].Location = new Point(18, 3 + (i + 1) * 25);
                txText[i].Size = textBoxForMulTxNum.Size;
                txText[i].TabIndex = i;
                txText[i].TextChanged += new EventHandler(this.textBoxAllForMulTx_TextChanged);
            }
            UpdateAppConfig("g_mulTxNum_Old", g_mulTxNum_New.ToString());
        }

        private void OpenCom()
        {
            string tmpCom = comboBoxForComSelect.Text;
            if(tmpCom != null && tmpCom != "")
            {
                Com.PortName = tmpCom;
            }

            Com.BaudRate = int.Parse(comboBoxForBaudRate.Text);

            switch (comboBoxForStopBit.Text)
            {
                case "0":
                    Com.StopBits = StopBits.None;
                    break;
                case "1":
                    Com.StopBits = StopBits.One;
                    break;
                case "1.5":
                    Com.StopBits = StopBits.OnePointFive;
                    break;
                case "2":
                    Com.StopBits = StopBits.Two;
                    break;
                default:
                    Com.StopBits = StopBits.One;
                    break;
            }

            Com.DataBits = int.Parse(comboBoxForDataBit.Text);

            switch (comboBoxForCheck.Text)
            {
                case "无":
                    Com.Parity = Parity.None;
                    break;
                case "奇校验":
                    Com.Parity = Parity.Odd;
                    break;
                case "偶校验":
                    Com.Parity = Parity.Even;
                    break;
                case "保留为1":
                    Com.Parity = Parity.Mark;
                    break;
                case "保留为0":
                    Com.Parity = Parity.Space;
                    break;
                default:
                    Com.Parity = Parity.None;
                    break;
            }

            try
            {
                Com.Open();
                if(Com.IsOpen)
                {
                    buttonForComSwitch.Text = "关闭串口";
                    buttonForComSwitch.Image = Properties.Resources.openCom;
                }
            }
            catch
            {
                MessageBox.Show("请选择可用的串口！");
            }
        }

        private void CloseCom()
        {
            try
            {
                Com.Close();
                if(!Com.IsOpen)
                {
                    buttonForComSwitch.Text = "打开串口";
                    buttonForComSwitch.Image = Properties.Resources.closCom;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        
        private void TxHandle(string strToSend)
        {
            if (!Com.IsOpen)
            {
                if(checkBoxForTxTimer.Checked)
                {
                    timer1.Stop();
                    checkBoxForTxTimer.Checked = false;
                    MessageBox.Show("请先打开串口！", "Error");
                }
                else
                {
                    MessageBox.Show("请先打开串口！", "Error");
                }
                return;
            }

            if (checkBoxForTxHex.Checked)
            {
                string tmpStrToSend = strToSend.Replace(" ", "");
                if (tmpStrToSend.Length % 2 != 0)
                {
                    strToSend += '0';
                }
                if (checkBoxForTxNewLine.Checked)
                {
                    strToSend += FormatConvert.StringToHexString("\r\n");
                }

                List<byte> tmpListToSend = new List<byte>();
                tmpListToSend.AddRange(FormatConvert.HexStringToBytes(strToSend));

                byte[] bytesForCheckRes = new byte[2];
                if (checkBoxForCrcCheck.Checked)
                {
                    int lenth = -1;
                    int startAddress = -1;
                    try
                    {
                        startAddress = Convert.ToInt32(textBoxForCrcCheckStartAddress.Text);
                        lenth = Convert.ToInt32(textBoxForCrcCheckLenth.Text);
                        if(lenth ==0 )
                        {
                            lenth = tmpListToSend.ToArray().Length - startAddress;
                        }
                    }
                    catch(Exception e)
                    {
                        MessageBox.Show(e.Message);
                    }

                    byte[] tmpbytesToCheck = new byte[ tmpListToSend.ToArray().Length - startAddress];
                    tmpListToSend.CopyTo( startAddress, tmpbytesToCheck, 0, tmpListToSend.ToArray().Length - startAddress);
                    bytesForCheckRes = FormatConvert.HexStringToBytes( MyCheck.CrcCheck(tmpbytesToCheck, lenth).ToString("X4") );
                    tmpListToSend.AddRange(bytesForCheckRes);
                }
                else if (checkBoxForSumCheck.Checked)
                {
                    int lenth = -1;
                    int startAddress = -1;
                    try
                    {
                        startAddress = Convert.ToInt32(textBoxForSumCheckStartAddress.Text);
                        lenth = Convert.ToInt32(textBoxForSumCheckLenth.Text);
                        if (lenth == 0)
                        {
                            lenth = tmpListToSend.ToArray().Length - startAddress;
                        }
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message);
                    }

                    byte[] tmpbytesToCheck = new byte[tmpListToSend.ToArray().Length - startAddress];
                    tmpListToSend.CopyTo(startAddress, tmpbytesToCheck, 0, tmpListToSend.ToArray().Length - startAddress);
                    bytesForCheckRes = FormatConvert.HexStringToBytes(MyCheck.SumCheck(tmpbytesToCheck, lenth).ToString("X4"));
                    tmpListToSend.Add(bytesForCheckRes[1]);
                    tmpListToSend.Add(bytesForCheckRes[0]);
                }
                int tmpLenth = tmpListToSend.ToArray().Length;

                SetToolStripStatusLabel(2, tmpLenth);

                Com.Write(tmpListToSend.ToArray(), 0, tmpLenth);

                if (checkBoxForRxAutoClear.Checked)
                {
                    g_clearedThisTime = true;
                    textBoxForRxArea.Text = '[' + DateTime.Now.TimeOfDay.ToString().Substring(0, 12) + "]T：" 
                        + FormatConvert.BytesToHexString(tmpListToSend.ToArray()) + "\r\n";
                }
                else
                {
                    textBoxForRxArea.AppendText('[' + DateTime.Now.TimeOfDay.ToString().Substring(0, 12) + "]T："
                        + FormatConvert.BytesToHexString(tmpListToSend.ToArray()) + "\r\n");
                    if (textBoxForRxArea.Text.Length > textBoxForRxArea.MaxLength)
                    {
                        textBoxForRxArea.MaxLength += 32767;
                    }
                }

                //显示到最后一行
                if (textBoxForRxArea.Text.Length >= 1)
                {
                    textBoxForRxArea.SelectionStart = textBoxForRxArea.Text.Length - 1;
                }
                textBoxForRxArea.ScrollToCaret();
            }
            else
            {
                if (checkBoxForTxNewLine.Checked)
                {
                    strToSend += "\r\n";
                }
                if(checkBoxForRxTimeDisplay.Checked)
                {
                    textBoxForRxArea.AppendText('[' + DateTime.Now.TimeOfDay.ToString().Substring(0, 12) + "]T："
                        + strToSend + "\r\n");
                    if (textBoxForRxArea.Text.Length > textBoxForRxArea.MaxLength)
                    {
                        textBoxForRxArea.MaxLength += 32767;
                    }
                }
                SetToolStripStatusLabel(2, strToSend.Length);
                Com.Write(strToSend);


                //显示到最后一行
                if (textBoxForRxArea.Text.Length >= 1)
                {
                    textBoxForRxArea.SelectionStart = textBoxForRxArea.Text.Length - 1;
                }
                textBoxForRxArea.ScrollToCaret();
            }
        }

        private void SetToolStripStatusLabel(int index, int length)
        {
            if(index==1)
            {

            }
            else if(index==2)
            {
                g_counterForTxData += (UInt64)length;
                toolStripStatusLabel2.Text = " T：" + g_counterForTxData.ToString();
            }
            else if (index == 20)
            {
                g_counterForTxData = 0;
                toolStripStatusLabel2.Text = " T：" + "0";
            }
            else if(index==3)
            {
                g_counterForRxData += (UInt64)length;
                toolStripStatusLabel3.Text = " R：" + g_counterForRxData.ToString();
            }
            else if (index == 30)
            {
                g_counterForRxData = 0;
                toolStripStatusLabel3.Text = " R：" + "0";
            }
            else
            {
                toolStripStatusLabel4.Text = " Now：" + DateTime.Now.ToLocalTime().ToString();
            }
        }





        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Init();
            OpenCom();
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            MainForm tmpMainForm = (MainForm)sender;
            UpdateAppConfig("MainFormSize.Width", tmpMainForm.Size.Width.ToString());
            UpdateAppConfig("MainFormSize.Height", tmpMainForm.Size.Height.ToString());
        }

        private void comboBoxForComSelect_Click(object sender, EventArgs e)
        {
            GetComsExplain();
        }

        private void comboBoxForComSelect_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (Com.IsOpen)
            {
                CloseCom();
            }

            comboBoxForComSelect.Text = FilterCom(comboBoxForComSelect.SelectedItem.ToString());
            UpdateAppConfig("Com", comboBoxForComSelect.Text);

            int tmpIndex = comboBoxForComSelect.SelectedIndex;
            string tmpSelectedItem = comboBoxForComSelect.Text;
            //comboBoxForComSelect.Items.RemoveAt(comboBoxForComSelect.SelectedIndex);
            comboBoxForComSelect.Items.RemoveAt(tmpIndex);
            comboBoxForComSelect.Items.Insert(tmpIndex, tmpSelectedItem);
            comboBoxForComSelect.SelectedIndex = tmpIndex;

            OpenCom();
        }

        private void com_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            if (e.EventType == SerialData.Eof)
            {/* 防止将0x1A当做EOF处理而触发的两次串口事件 .Net串口通信中将0x1A当作EOF处理 */
                return;
            }
            
            string rxStr = "";
            SetToolStripStatusLabel(3, Com.BytesToRead);
            
            if (checkBoxForRxHex.Checked)
            {
                if (radioButtonForFrameOvertime.Checked)
                {
                    int tmpOvertime = 1;
                    try
                    {
                        tmpOvertime = Convert.ToInt32(textBoxForFrameOvertime.Text);
                    }
                    catch
                    {
                        MessageBox.Show("请正确输入分帧的超时时间！");
                    }

                    System.Threading.Thread.Sleep(tmpOvertime);
                    int rxBytesLenth = Com.BytesToRead;
                    //Array.Clear(rxButter, 0, 100);
                    Com.Read(rxButter, 0, rxBytesLenth);
                    rxStr = FormatConvert.BytesToHexString(rxButter, 0, rxBytesLenth);

                    if (checkBoxForRxTimeDisplay.Checked)
                    {
                        rxStr = '[' + DateTime.Now.TimeOfDay.ToString().Substring(0, 12) + "]R：" + rxStr;
                        rxStr += "\r\n";
                    }
                    if (checkBoxForRxNewLine.Checked)
                    {
                        rxStr += "\r\n";
                    }
                    //自动清除
                    if (checkBoxForRxAutoClear.Checked && (!g_clearedThisTime))
                    {
                        textBoxForRxArea.Text = rxStr;
                    }
                    else
                    {
                        textBoxForRxArea.AppendText(rxStr);
                        if (textBoxForRxArea.Text.Length > textBoxForRxArea.MaxLength)
                        {
                            textBoxForRxArea.MaxLength += 32767;
                        }
                    }
                }
                else if (radioButtonForFrameHead.Checked)
                {
                    while(Com.BytesToRead!=0)
                    {
                        if (Com.ReadByte() == 1)
                        {
                            if (Com.ReadByte() == 252)
                            {
                                int tmpID = Com.ReadByte();
                                int tmpLenthLowByte = Com.ReadByte();
                                int tmpLenthHighByte = Com.ReadByte();
                                int tmpLenth = tmpLenthHighByte * 256 + tmpLenthLowByte;

                                Com.Read(rxButter, 0, tmpLenth);
                                rxStr = "01 FC " + tmpID.ToString("X2") + " "
                                    + tmpLenthLowByte.ToString("X2") + " "
                                    + tmpLenthHighByte.ToString("X2") + " "
                                    + FormatConvert.BytesToHexString(rxButter, 0, tmpLenth);
                                if (checkBoxForRxTimeDisplay.Checked)
                                {
                                    rxStr = '[' + DateTime.Now.TimeOfDay.ToString().Substring(0, 12) + "]R：" + rxStr;
                                    rxStr += "\r\n";
                                }
                                if (checkBoxForRxNewLine.Checked)
                                {
                                    rxStr += "\r\n";
                                }
                                //自动清除
                                if (checkBoxForRxAutoClear.Checked && (!g_clearedThisTime))
                                {
                                    textBoxForRxArea.Text = rxStr;
                                }
                                else
                                {
                                    textBoxForRxArea.AppendText(rxStr);
                                    if (textBoxForRxArea.Text.Length > textBoxForRxArea.MaxLength)
                                    {
                                        textBoxForRxArea.MaxLength += 32767;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                int tmpOvertime = 1;
                try
                {
                    tmpOvertime = Convert.ToInt32(textBoxForFrameOvertime.Text);
                }
                catch
                {
                    MessageBox.Show("请正确输入分帧的超时时间！");
                }

                System.Threading.Thread.Sleep(tmpOvertime);
                rxStr = Com.ReadExisting();
                if ( formForDisplay != null && !formForDisplay.IsDisposed )
                {
                    byte[] byteArray = Encoding.Default.GetBytes(rxStr);
                    for ( int i=0; i< byteArray.Length; i++)
                    {
                        Series tmpSeries = formForDisplay.chart1.Series[0];
                        tmpSeries.Points.AddXY
                            ((g_counterForRxData - (UInt64)byteArray.Length + (UInt64)i), -byteArray[i]);
                        formForDisplay.chart1.ChartAreas[0].AxisX.ScaleView.Position
                            = tmpSeries.Points.Count - formForDisplay.trackBar1.Value;
                        double tmpSize = formForDisplay.chart1.ChartAreas[0].AxisY.ScaleView.Size;
                        if(tmpSize>5&&tmpSize<10000)
                        {
                            formForDisplay.trackBar2.Value
                                = Convert.ToInt32(Math.Ceiling(tmpSize));
                        }
                    }
                }
                if (checkBoxForRxTimeDisplay.Checked)
                {
                    rxStr = '[' + DateTime.Now.TimeOfDay.ToString().Substring(0, 12) + "]R：" + rxStr;
                    rxStr += "\r\n";
                }
                if (checkBoxForRxNewLine.Checked)
                {
                    rxStr += "\r\n";
                }
                //自动清除
                if (checkBoxForRxAutoClear.Checked && (!g_clearedThisTime))
                {
                    textBoxForRxArea.Text = rxStr;
                }
                else
                {
                    textBoxForRxArea.AppendText(rxStr);
                    if (textBoxForRxArea.Text.Length > textBoxForRxArea.MaxLength)
                    {
                        textBoxForRxArea.MaxLength += 32767;
                    }
                }
            }

            g_clearedThisTime = false;
            //Com.DiscardInBuffer();

            //显示到最后一行
            if (textBoxForRxArea.Text.Length >= 1)
            {
                textBoxForRxArea.SelectionStart = textBoxForRxArea.Text.Length - 1;
            }
            textBoxForRxArea.ScrollToCaret();
        }


        private void buttonForComSwitch_Click(object sender, EventArgs e)
        {
            if (!Com.IsOpen)
            {
                OpenCom();
            }
            else
            {
                CloseCom();
            }
        }

        private void buttonForRxAreaClear_Click(object sender, EventArgs e)
        {
            textBoxForRxArea.Text = "";
            SetToolStripStatusLabel(30, 0);
        }
        private void buttonForTxAreaClear_Click(object sender, EventArgs e)
        {
            textBoxForTxArea.Text = "";
            SetToolStripStatusLabel(20, 0);
        }

        private void buttonForTxSend_Click(object sender, EventArgs e)
        {
            string strSend = textBoxForTxArea.Text;
            TxHandle(strSend);
        }

        private void buttonForMulTxBorn_Click(object sender, EventArgs e)
        {
            g_mulTxNum_Old = Convert.ToUInt16(GetAppConfig("g_mulTxNum_Old"));
            for (int i = 0; i < g_mulTxNum_Old; i++)
            {
                Button buttonTmp = (Button)splitContainer2.Panel2.Controls["txButton[" + i + "]"];
                CheckBox checkTmp = (CheckBox)splitContainer2.Panel1.Controls["txCheck[" + i + "]"];
                TextBox textTmp = (TextBox)splitContainer2.Panel1.Controls["txText[" + i + "]"];
                buttonTmp.Dispose();
                checkTmp.Dispose();
                textTmp.Dispose();
            }

            MulTxBorn();
        }

        private void buttonAllForMulTx_MouseClick(object sender, MouseEventArgs e)
        {
            string indexStr = Regex.Replace(((Button)sender).Name, @"[^0-9]+", "");

            if (e.Button == MouseButtons.Left && e.Clicks == 1)
            {
                string strSend = ((TextBox)splitContainer2.Panel1.Controls["txText[" + indexStr + "]"]).Text;
                TxHandle(strSend);
            }
        }

        private void buttonAllForMulTx_MouseDown(object sender, MouseEventArgs mouseEvent)
        {
            if (mouseEvent.Button == MouseButtons.Right && mouseEvent.Clicks == 1)
            {
                string buttonIndex = Regex.Replace(((Button)sender).Name, @"[^0-9]+", "");
                Button buttonTmp = (Button)splitContainer2.Panel2.Controls["txButton[" + buttonIndex + "]"];

                string str = Interaction.InputBox("请输入您的注释", "修改注释", "");
                if(str != null && str != "")
                {
                    buttonTmp.Text = str;
                    UpdateAppConfig(buttonTmp.Name, str);
                }
            }
        }

        
        private void textBoxForMulTxCount_MouseHover(object sender, EventArgs e)
        {
            ToolTip p = new ToolTip();
            p.ShowAlways = true;
            p.SetToolTip(this.textBoxForMulTxNum, "多条发送的数量");
        }
        string g_textBoxForMulTxNumString;
        private void textBoxForMulTxNum_Enter(object sender, EventArgs e)
        {
            TextBox tmpTextBox = (TextBox)sender;
            g_textBoxForMulTxNumString = tmpTextBox.Text;
        }

        private void textBoxForMulTxNum_Leave(object sender, EventArgs e)
        {
            TextBox tmpTextBox = (TextBox)sender;
            if (tmpTextBox.Text != "" && tmpTextBox.Text != null)
            {
                try
                {
                    g_mulTxNum_New = Convert.ToUInt16(tmpTextBox.Text);
                    UpdateAppConfig("g_mulTxNum_New", g_mulTxNum_New.ToString());
                    if (g_mulTxNum_New == 0)
                    {
                        MessageBox.Show("请输入大于0的数字！");
                    }
                }
                catch (Exception eve)
                {
                    tmpTextBox.Text = g_textBoxForMulTxNumString;
                    MessageBox.Show(eve.Message);
                }
            }
        }

        
        private void splitContainer2_Panel1_MouseWheel(object sender, MouseEventArgs e)
        {
            Point p = splitContainer2.Panel2.AutoScrollPosition;
            p.Y = -splitContainer2.Panel1.AutoScrollPosition.Y;
            splitContainer2.Panel2.AutoScrollPosition = p;
        }
        private void splitContainer2_Panel2_MouseWheel(object sender, MouseEventArgs e)
        {
            Point p = splitContainer2.Panel1.AutoScrollPosition;
            p.Y = -splitContainer2.Panel2.AutoScrollPosition.Y;
            splitContainer2.Panel1.AutoScrollPosition = p;
        }
        private void textBoxForTxArea_TextChanged(object sender, EventArgs e)
        {
            TextBox tmpTextBox = (TextBox)sender;
            UpdateAppConfig("textBoxForTxArea", tmpTextBox.Text);
        }
        private void textBoxForTxTimer_TextChanged(object sender, EventArgs e)
        {
            TextBox tmpTextBox = (TextBox)sender;
            UpdateAppConfig("textBoxForTxTimer", tmpTextBox.Text);
        }
        private void textBoxForCrcCheckStartAddress_TextChanged(object sender, EventArgs e)
        {
            TextBox tmpTextBox = (TextBox)sender;
            UpdateAppConfig("textBoxForCrcCheckStartAddress", tmpTextBox.Text);
        }
        private void textBoxForCrcCheckLenth_TextChanged(object sender, EventArgs e)
        {
            TextBox tmpTextBox = (TextBox)sender;
            UpdateAppConfig("textBoxForCrcCheckLenth", tmpTextBox.Text);
        }
        private void textBoxForSumCheckStartAddress_TextChanged(object sender, EventArgs e)
        {
            TextBox tmpTextBox = (TextBox)sender;
            UpdateAppConfig("textBoxForSumCheckStartAddress", tmpTextBox.Text);
        }
        private void textBoxForSumCheckLenth_TextChanged(object sender, EventArgs e)
        {
            TextBox tmpTextBox = (TextBox)sender;
            UpdateAppConfig("textBoxForSumCheckLenth", tmpTextBox.Text);
        }
        private void textBoxAllForMulTx_TextChanged(object sender, EventArgs e)
        {
            TextBox tmpTextBox = (TextBox)sender;
            UpdateAppConfig(tmpTextBox.Name, tmpTextBox.Text);
        }
        private void checkBoxForRxNewLine_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox tmpCheckBox = (CheckBox)sender;
            if (tmpCheckBox.Checked) UpdateAppConfig("checkBoxForRxNewLine", "1");
            else UpdateAppConfig("checkBoxForRxNewLine", "0");
        }
        private void checkBoxForRxTimeDisplay_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox tmpCheckBox = (CheckBox)sender;
            if (tmpCheckBox.Checked) UpdateAppConfig("checkBoxForRxTimeDisplay", "1");
            else UpdateAppConfig("checkBoxForRxTimeDisplay", "0");
        }
        private void checkBoxForRxHex_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox tmpCheckBox = (CheckBox)sender;
            if (tmpCheckBox.Checked) UpdateAppConfig("checkBoxForRxHex", "1");
            else UpdateAppConfig("checkBoxForRxHex", "0");

            if (tmpCheckBox.Checked)
            {
                textBoxForRxArea.Text = FormatConvert.StringToHexString(textBoxForRxArea.Text);
            }
            else
            {
                textBoxForRxArea.Text = FormatConvert.HexStringToString(textBoxForRxArea.Text);
            }
        }
        private void checkBoxForRxAutoClear_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox tmpCheckBox = (CheckBox)sender;
            if (tmpCheckBox.Checked) UpdateAppConfig("checkBoxForRxAutoClear", "1");
            else UpdateAppConfig("checkBoxForRxAutoClear", "0");
        }
        private void checkBoxForTxHex_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox tmpCheckBox = (CheckBox)sender;
            if (tmpCheckBox.Checked) UpdateAppConfig("checkBoxForTxHex", "1");
            else UpdateAppConfig("checkBoxForTxHex", "0");
        }
        private void checkBoxForTxNewLine_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox tmpCheckBox = (CheckBox)sender;
            if (tmpCheckBox.Checked) UpdateAppConfig("checkBoxForTxNewLine", "1");
            else UpdateAppConfig("checkBoxForTxNewLine", "0");
        }
        private void checkBoxForCrcCheck_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox tmpCheckBox = (CheckBox)sender;
            if (tmpCheckBox.Checked) UpdateAppConfig("checkBoxForCrcCheck", "1");
            else UpdateAppConfig("checkBoxForCrcCheck", "0");
        }
        private void checkBoxForSumCheck_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox tmpCheckBox = (CheckBox)sender;
            if (tmpCheckBox.Checked) UpdateAppConfig("checkBoxForSumCheck", "1");
            else UpdateAppConfig("checkBoxForSumCheck", "0");
        }
        private void checkBoxForTxTimer_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxForTxTimer.Checked)
            {
                if (textBoxForTxTimer.Text == "")
                {
                    MessageBox.Show("请您输入要定时的时间！");
                }
                else
                {
                    try
                    {
                        timer1.Interval = Convert.ToInt32(textBoxForTxTimer.Text);
                        timer1.Start();
                    }
                    catch (Exception exe)
                    {
                        MessageBox.Show(exe.Message);
                    }
                }
            }
            else
            {
                try
                {
                    timer1.Stop();
                }
                catch(Exception exe)
                {
                    MessageBox.Show(exe.Message);
                }
            }
        }
        private void comboBoxForBaudRate_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Com.IsOpen)
            {
                CloseCom();
            }

            ComboBox tmpComboBox = (ComboBox)sender;
            UpdateAppConfig("comboBoxForBaudRate", tmpComboBox.Text);

            OpenCom();
        }
        private void comboBoxForStopBit_Click(object sender, EventArgs e)
        {
            ToolStripComboBox tmpComboBox = (ToolStripComboBox)sender;
            UpdateAppConfig("comboBoxForStopBit", tmpComboBox.Text);
        }
        private void comboBoxForDataBit_Click(object sender, EventArgs e)
        {
            ToolStripComboBox tmpComboBox = (ToolStripComboBox)sender;
            UpdateAppConfig("comboBoxForDataBit", tmpComboBox.Text);
        }
        private void comboBoxForCheck_Click(object sender, EventArgs e)
        {
            ToolStripComboBox tmpComboBox = (ToolStripComboBox)sender;
            UpdateAppConfig("comboBoxForCheck", tmpComboBox.Text);
        }


        private void menuItemForMulTxView_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2Collapsed = !splitContainer1.Panel2Collapsed;

            ToolStripMenuItem tmpMenuItem = (ToolStripMenuItem)sender;
            if (splitContainer1.Panel2Collapsed == true) UpdateAppConfig("menuItemForMulTxView", "true");
            else UpdateAppConfig("menuItemForMulTxView", "false");
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(checkBoxForTxTimer.Checked)
            {
                string strSend = textBoxForTxArea.Text;
                TxHandle(strSend);
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            SetToolStripStatusLabel(4, 0);
            if(Com.IsOpen)
            {
                buttonForComSwitch.Text = "关闭串口";
                buttonForComSwitch.Image = Properties.Resources.openCom;
            }
            else
            {
                buttonForComSwitch.Text = "打开串口";
                buttonForComSwitch.Image = Properties.Resources.closCom;
                Com.Dispose();
            }
        }

        private void toolStripMenuItemForCalculator_Click(object sender, EventArgs e)
        {
            System.Diagnostics.ProcessStartInfo Info = new System.Diagnostics.ProcessStartInfo();
            Info.FileName = "calc.exe ";//"calc.exe"为计算器，"notepad.exe"为记事本
            System.Diagnostics.Process Proc = System.Diagnostics.Process.Start(Info);
        }

        private void toolStripMenuItemForNotepad_Click(object sender, EventArgs e)
        {
            System.Diagnostics.ProcessStartInfo Info = new System.Diagnostics.ProcessStartInfo();
            Info.FileName = "notepad.exe ";//"calc.exe"为计算器，"notepad.exe"为记事本
            System.Diagnostics.Process Proc = System.Diagnostics.Process.Start(Info);
        }

        private void 使用说明ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxForRxArea.Text =
                "1. 多条发送的数量可以自定义，使用方法参考“更多帮助…”；\r\n\r\n" +
                "2. 更多使用说明和功能尽情期待！";
        }

        private void 更多帮助ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://blog.csdn.net/weixin_40108380/article/details/78825049");
        }

        private void 恢复默认ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult tmpDialogResult = MessageBox.Show(
                "你确定要删除之前的所有个性化配置并恢复默认吗！？", "",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (tmpDialogResult == DialogResult.Yes)
            {
                string file = Application.ExecutablePath;
                File.Delete(file + ".config");
            }
        }

        private void sonOfmenuItemForSaveFile_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog tmpSaveFileDialog = new SaveFileDialog();
                tmpSaveFileDialog.Filter = "文本文件|*.txt";
                if (tmpSaveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string fileName = tmpSaveFileDialog.FileName;
                    FileStream fs = File.Open(fileName, FileMode.Create, FileAccess.Write);
                    StreamWriter wr = new StreamWriter(fs);

                    foreach (string line in textBoxForRxArea.Lines)
                    {
                        wr.WriteLine(line);
                    }

                    wr.Flush();
                    wr.Close();
                    fs.Close();
                }
            }
            catch(Exception exe)
            {
                MessageBox.Show(exe.Message);
            }
        }

        private void sonOfmenuItemForOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog tmpOpenFileDialog = new OpenFileDialog();
            tmpOpenFileDialog.Filter = "文本文件|*.txt";
            tmpOpenFileDialog.RestoreDirectory = true;
            tmpOpenFileDialog.FilterIndex = 1;
            if(tmpOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = tmpOpenFileDialog.FileName;
                FileStream fs = File.OpenRead(fileName);
                StreamReader rd = new StreamReader(fs);

                textBoxForRxArea.Text = "";
                textBoxForRxArea.Text = rd.ReadToEnd();

                rd.Dispose();
                rd.Close();
                fs.Close();
            }
        }

        private void checkBoxForCrcCheck_MouseHover(object sender, EventArgs e)
        {
            ToolTip p = new ToolTip();
            p.ShowAlways = true;
            p.SetToolTip(this.checkBoxForCrcCheck, "CRC参数模型为CRC-16/XMODEM（16+x12+x5+1），校验位数16位");
        }

        private void textBoxForCrcCheckLenth_MouseHover(object sender, EventArgs e)
        {
            ToolTip p = new ToolTip();
            p.ShowAlways = true;
            p.SetToolTip(this.textBoxForCrcCheckLenth, "如果参数为“0”，则表示长度一直到数据的结尾");
        }

        private void textBoxForSumCheckLenth_MouseHover(object sender, EventArgs e)
        {
            ToolTip p = new ToolTip();
            p.ShowAlways = true;
            p.SetToolTip(this.textBoxForSumCheckLenth, "如果参数为“0”，则表示长度一直到数据的结尾");
        }

        private void aSCIIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formForASCII = new FormForAscii();
            formForASCII.Show();
        }

        private void ToolStripMenuItemForCheck_Click(object sender, EventArgs e)
        {
            formForCheck = new FormForCheck();
            formForCheck.Show();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            MulTxBorn();
            timer3.Stop();
        }

        private void 示波器ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetToolStripStatusLabel(30, 0);
            formForDisplay = new FormForWave();
            formForDisplay.Show();
            formForDisplay.chart1.Series[0].Points.AddY(10);
            formForDisplay.chart1.ChartAreas[0].AxisX.ScaleView.Size
                             = formForDisplay.trackBar1.Value;
            formForDisplay.chart1.ChartAreas[0].AxisX.ScaleView.Position = 0;
        }

        private void textBoxForFrameOvertime_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxForRxArea_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.Modifiers == Keys.Control) && (e.KeyCode == Keys.A))
            {
                ((TextBox)sender).SelectAll();
            }
        }


	}
}
