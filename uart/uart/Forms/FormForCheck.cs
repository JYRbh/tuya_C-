using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using uart.Sourses;


namespace uart
{
    public partial class FormForCheck : Form
    {
        public FormForCheck()
        {
            InitializeComponent();
        }

        /****************************************进制转换****************************************/

        //回调函数内不可触发其他回调，即互斥
        UInt16 g_EventFlag = 0x0007;
        //回调函数内不可触发回调本身
        UInt16 g_SpaceFlag = 0x0007;
        private void addSpaceInTextBox(TextBox textBox)
        {
            //过滤非法字符（如空格）
            string str = FormatConvert.FiltHexString(textBox.Text);
            //二进制4位对齐
            if (textBox == textBoxForRadixBIN)
            {
                int length = str.Length;
                if (length % 4 != 0)
                {
                    str = str.PadLeft(length - length % 4 + 4, '0');
                }
            }
            //四字节插入一个空格
            int len = str.Length - 1;
            len = len - len % 4;
            for (int i = len; i > 0; i -= 4)
            {
                str = str.Insert(i, " ");
            }
            //更新文本框并使焦点移到文本框末尾
            textBox.Text = str;
            textBox.Select(textBox.TextLength, 0);
            textBox.ScrollToCaret();
        }
        private void textBoxForRadixHEX_TextChanged(object sender, EventArgs e)
        {
            //插入空格
            if ((g_SpaceFlag & 0x0001) != 0)
            {
                g_SpaceFlag = 0x0006;
                addSpaceInTextBox(textBoxForRadixHEX);
                g_SpaceFlag = 0x0007;
            }

            //进制转换
            if ((g_EventFlag & 0x0001) != 0)
            {
                g_EventFlag = 0x0001;

                //过滤非法字符（如空格）
                string HexStr = FormatConvert.FiltHexString(textBoxForRadixHEX.Text);
                //转换
                try
                {
                    if (HexStr == "")
                    {
                        textBoxForRadixDEC.Text = "";
                        textBoxForRadixBIN.Text = "";
                    }
                    else
                    {
                        long Dec = Convert.ToInt64(HexStr, 16);
                        textBoxForRadixDEC.Text = Convert.ToString(Dec, 10);
                        textBoxForRadixBIN.Text = Convert.ToString(Dec, 2);
                    }
                }
                catch (Exception exe)
                {
                    MessageBox.Show(exe.Message);
                }

                g_EventFlag = 0x0007;
            }
        }

        private void textBoxForRadixDEC_TextChanged(object sender, EventArgs e)
        {
            //插入空格
            if ((g_SpaceFlag & 0x0002) != 0)
            {
                g_SpaceFlag = 0x0005;
                addSpaceInTextBox(textBoxForRadixDEC);
                g_SpaceFlag = 0x0007;
            }

            //进制转换
            if ((g_EventFlag & 0x0002) != 0)
            {
                g_EventFlag = 0x0002;

                string HexStr = textBoxForRadixDEC.Text;
                string NewHexStr = "";
                //过滤非法字符（如空格）
                foreach (char Hex in HexStr)
                {
                    if (Hex >= '0' && Hex <= '9')
                    {
                        NewHexStr += Hex;
                    }
                }
                //转换
                try
                {
                    if (NewHexStr == "")
                    {
                        textBoxForRadixHEX.Text = "";
                        textBoxForRadixBIN.Text = "";
                    }
                    else
                    {
                        long Dec = Convert.ToInt64(NewHexStr, 10);
                        textBoxForRadixHEX.Text = Convert.ToString(Dec, 16);
                        textBoxForRadixBIN.Text = Convert.ToString(Dec, 2);
                    }
                }
                catch (Exception exe)
                {
                    MessageBox.Show(exe.Message);
                }

                g_EventFlag = 0x0007;
            }
        }

        private void textBoxForRadixBIN_TextChanged(object sender, EventArgs e)
        {
            //插入空格并4位对齐
            if ((g_SpaceFlag & 0x0004) != 0)
            {
                g_SpaceFlag = 0x0003;
                addSpaceInTextBox(textBoxForRadixBIN);
                g_SpaceFlag = 0x0007;
            }

            //进制转换
            if ((g_EventFlag & 0x0004) != 0)
            {
                g_EventFlag = 0x0004;

                string HexStr = textBoxForRadixBIN.Text;
                string NewHexStr = "";
                //过滤非法字符（如空格）
                foreach (char Hex in HexStr)
                {
                    if (Hex >= '0' && Hex <= '1')
                    {
                        NewHexStr += Hex;
                    }
                }
                //转换
                try
                {
                    if (NewHexStr == "")
                    {
                        textBoxForRadixHEX.Text = "";
                        textBoxForRadixDEC.Text = "";
                    }
                    else
                    {
                        long Dec = Convert.ToInt64(NewHexStr, 2);
                        textBoxForRadixHEX.Text = Convert.ToString(Dec, 16);
                        textBoxForRadixDEC.Text = Convert.ToString(Dec, 10);
                    }
                }
                catch (Exception exe)
                {
                    MessageBox.Show(exe.Message);
                }

                g_EventFlag = 0x0007;
            }
        }



        /****************************************字符转换****************************************/
        private void buttonForTransStart_Click(object sender, EventArgs e)
        {
            if (comboBoxForTransSelect.Text == "StringToHex")
            {
                textBoxForTransRes.Text = FormatConvert.StringToHexString(textBoxForTransData.Text);
            }
            else if (comboBoxForTransSelect.Text == "HexToString")
            {
                textBoxForTransRes.Text = FormatConvert.HexStringToString(textBoxForTransData.Text);
            }
        }



        /****************************************AES加密****************************************/
        private void buttonForAesEcb_Click(object sender, EventArgs e)
        {
            //读取密钥
            string strForKey = FormatConvert.FiltHexString(textBoxForAesKey.Text);
            byte[] bytesForKey = FormatConvert.HexStringToBytes(strForKey);
            //读取原始数据
            string strForData = FormatConvert.FiltHexString(textBoxForAesData.Text);
            byte[] bytesForData = FormatConvert.HexStringToBytes( strForData );

            //加密
            byte[] bytesForRes = MyCheck.AesEncrypt( bytesForData, bytesForKey );

            //输出加密数据
            string strForRes = FormatConvert.BytesToHexString( bytesForRes );
            textBoxForAesRes.Text = strForRes;
        }

        private void buttonForAesDecry_Click(object sender, EventArgs e)
        {
            //读取密钥
            string strForKey = FormatConvert.FiltHexString(textBoxForAesKey.Text);
            byte[] bytesForKey = FormatConvert.HexStringToBytes(strForKey);
            //读取原始数据
            string strForData = FormatConvert.FiltHexString(textBoxForAesData.Text);
            byte[] bytesForData = FormatConvert.HexStringToBytes(strForData);

            //解密
            byte[] bytesForRes = MyCheck.AesDecrypt(bytesForData, bytesForKey);

            //输出解密数据
            string strForRes = FormatConvert.BytesToHexString(bytesForRes);
            textBoxForAesRes.Text = strForRes;
        }



        /****************************************全选****************************************/
        private void textBoxForRadixHEX_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.Modifiers == Keys.Control) && (e.KeyCode == Keys.A))
            {
                ((TextBox)sender).SelectAll();
            }
        }

        private void textBoxForRadixDEC_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.Modifiers == Keys.Control) && (e.KeyCode == Keys.A))
            {
                ((TextBox)sender).SelectAll();
            }
        }

        private void textBoxForRadixBIN_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.Modifiers == Keys.Control) && (e.KeyCode == Keys.A))
            {
                ((TextBox)sender).SelectAll();
            }
        }

        private void textBoxForTransData_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.Modifiers == Keys.Control) && (e.KeyCode == Keys.A))
            {
                ((TextBox)sender).SelectAll();
            }
        }

        private void textBoxForTransRes_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.Modifiers == Keys.Control) && (e.KeyCode == Keys.A))
            {
                ((TextBox)sender).SelectAll();
            }
        }

        private void textBoxForAesData_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.Modifiers == Keys.Control) && (e.KeyCode == Keys.A))
            {
                ((TextBox)sender).SelectAll();
            }
        }

        private void textBoxForAesRes_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.Modifiers == Keys.Control) && (e.KeyCode == Keys.A))
            {
                ((TextBox)sender).SelectAll();
            }
        }

    }
}
