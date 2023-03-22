using System;
using System.Text;
using System.IO.Ports;
using System.Windows.Forms;
using System.Threading;
using System.IO;

namespace Serial_conmmunicate
{
	public partial class Form1 : Form
	{
		static readonly string filePath = @"C:\Users\tuya\Desktop\log.txt";//log保存路径
		string time_receive = "[收]<--" + DateTime.Now.ToString() + "  ";//接收时间
		string time_send = "[发]-->" + DateTime.Now.ToString() + "  ";//发送时间
		public Form1()
		{
			InitializeComponent();
			serialPort1.DataReceived += new SerialDataReceivedEventHandler(Serialport1_DataReceived);
			System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false; //此时把所有的控件合法性线程检查全部都给禁止掉了。
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			comboBox1.Text = "";//串口选择框默认显示
			comboBox2.Text = "9600";//波特率选择默认显示

			comboBox2.Items.Add("1200");
			comboBox2.Items.Add("2400");
			comboBox2.Items.Add("4800");
			comboBox2.Items.Add("9600");
			comboBox2.Items.Add("19200");
			comboBox2.Items.Add("38400");
			comboBox2.Items.Add("115200");
		}

		/****
		 * 
		 * 历遍串口
		 * 
		 *****/
		private void GetComListAddtoComboBox(SerialPort Myport, ComboBox MyBox)
		{
			string Buffer;//列表数据缓存
			MyBox.Items.Clear();//清空combobox内容
			for (int i = 1; i < 20; i++)
			{
				try
				{
					Buffer = "COM" + i.ToString();//缓存COM口
					Myport.PortName = Buffer;//
					Myport.Open();          //如果串口打开失败说明串口不可用，后续程序不执行
					MyBox.Items.Add(Buffer);//如果打开成功则添加至下拉列表
					Myport.Close();         //关闭已成功打开的串口
				}
				catch
				{

				}
			}
		}

		/****
		 * 
		 * 点击端口扫描历遍串口
		 * 
		 ****/
		private void button2_Click(object sender, EventArgs e)
		{
			GetComListAddtoComboBox(serialPort1, comboBox1);
		}

		/// <summary>
		/// 发送数据
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void button3_Click(object sender, EventArgs e)
		{
			byte[] Data = new byte[1];
			string text = textBox2.Text.Replace(" ", "");
			if (serialPort1.IsOpen)//串口是否打开
			{
				if (textBox2.Text != "")//是否有数据
				{
					if (radioButton2.Checked)//如果发送模式是字符模式
					{
						try
						{
							serialPort1.WriteLine(text);//将数据框中的字符写给串口
							string str = serialPort1.ReadExisting();//字符串读取方式
						}
						catch (Exception err)
						{
							MessageBox.Show("串口数据写入错误", "错误");//出错提示
							serialPort1.Close();
							button1.Enabled = true;//打开串口按钮可用
							button2.Enabled = false;//关闭串口按钮不可用
						}
					}
					else//如果发送模式是数值模式
					{
						try
						{
							for (int i = 0; i < text.Length / 2; i++)
							{
								Data[0] = Convert.ToByte(text.Substring(i * 2, 2), 16);//Substring(数据，取的位数)   转为16进制
								serialPort1.Write(Data, 0, 1);//循环发送（如果输入字符为0A0BB,则只发送0A，0B）
							}
						}
						catch (Exception err)
						{
							MessageBox.Show("串口数据写入错误", "错误");//出错提示
							serialPort1.Close();
							button1.Enabled = true;//打开串口按钮可用
							button2.Enabled = false;//关闭串口按钮不可用
						}
					}
					textBox1.AppendText(time_send + textBox2.Text + "\r\n");
					WriteString(time_send + textBox2.Text);
				}
			}
			else
			{
				MessageBox.Show("串口未打开");
			}
		}

		//// <summary>
		/// 串口打开/关闭
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				if (button1.Text == "打开串口") //在串口为关闭的情况下
				{
					button1.Text = "关闭串口"; //点击后显示为关闭串口（可以关闭）
					serialPort1.Close();//关闭串口

					serialPort1.PortName = comboBox1.Text;//获取端口号
					serialPort1.BaudRate = Convert.ToInt32(comboBox2.Text);//获取比特率
					serialPort1.DataBits = 8;
					serialPort1.StopBits = StopBits.One;
					serialPort1.Parity = Parity.None;

					serialPort1.Open();
					textBox1.AppendText("打开串口成功\r\n");
				}
				else   //在串口为打开的情况下
				{
					button1.Text = "打开串口";//显示打开串口
					textBox1.AppendText("串口已关闭\r\n");
					if (serialPort1.IsOpen == false)
						return;
					else
						serialPort1.Close();
				}
			}
			catch
			{
				button1.Text = "打开串口";
				MessageBox.Show("串口打开失败");
			}
		}

		/// <summary>
		/// 串口数据接收事件
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Serialport1_DataReceived(object sender, EventArgs e)
		{
			System.Threading.Thread.Sleep(100);//延时100ms等待接收完数据
			if (!radioButton3.Checked)//如果接收字符串
			{
				string str = serialPort1.ReadExisting();//字符串读取方式
				textBox1.AppendText(time_receive + str + "\r\n");//在textBox1内显示字符串
				WriteString(str);
			}
			else//如果接收数值
			{
				Byte[] data = new Byte[serialPort1.BytesToRead];//创建接收字节数组
																//serialPort1.BytesToRead获取的数值是缓冲区中数据的长度
				serialPort1.Read(data, 0, data.Length);//读取
				textBox1.AppendText(time_receive);//打印时间戳
				for (int i = 0; i < data.Length; i++)
				{
					textBox1.AppendText(data[i].ToString("x2").ToUpper() + " "); //给只有一位的数值填补“0”
				}
				WriteByte(data);
				textBox1.AppendText("\r\n");
			}
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
		{
			comboBox1.Items.ToString();
		}

		/// <summary>
		/// 清空发送区
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void button4_Click(object sender, EventArgs e)
		{
			textBox1.Text = null;
		}

		/// <summary>
		/// 清空接收区
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void button5_Click(object sender, EventArgs e)
		{
			textBox2.Text = null;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			MessageBox.Show("数据将存储在 C:\\Users\\tuya\\Desktop");
		}

		/// <summary>
		/// 写入文件（byte类型）
		/// </summary>
		/// <param name="buffer"></param>
		/// <param name="time"></param>
		private void WriteByte(byte[] buffer)
		{
			try//将缓存区的数据存入txt中
			{
				byte[] bufferGet = buffer; //读取缓冲区
				using (StreamWriter wt = new StreamWriter(filePath, true))
				{
					wt.Write(time_receive); //写入时间戳
					for (int i = 0; i < bufferGet.Length; i++) //循环写入缓冲区的数据
					{
						wt.Write(bufferGet[i].ToString("x2").ToUpper() + " ");
					}
					wt.WriteLine("");//分行
				}
			}
			catch
			{
				MessageBox.Show("写入有问题");
			}
		}

		/// <summary>
		/// 写入文件字符类型
		/// </summary>
		/// <param name="buffer"></param>
		private void WriteString(string buffer)
		{
			try//将缓存区的数据存入txt中
			{
				using (StreamWriter wt = new StreamWriter(filePath, true))
				{
					wt.WriteLine(time_receive + buffer);
				}
			}
			catch
			{
				MessageBox.Show("写入有问题");
			}
		}


		/// <summary>
		/// 文件另存为
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				SaveFileDialog saveFileDialogv = new SaveFileDialog();

				//设置默认打开文件目录
				saveFileDialogv.InitialDirectory = "d:\\";
				//设置文件类型，这里才使用筛选器进行设置
				saveFileDialogv.Filter = "文本文件(*.txt)|*.txt";
				//保存对话框是否记录上次打开的目录
				saveFileDialogv.RestoreDirectory = true;
				//设置默认的文件名
				saveFileDialogv.FileName = "123";
				//记忆之前打开的目录
				saveFileDialogv.RestoreDirectory = true;

				DialogResult dr = saveFileDialogv.ShowDialog();
				if (dr == DialogResult.OK && saveFileDialogv.FileName.Length > 0)
				{
					MessageBox.Show("保存在" + saveFileDialogv.FileName);
				}
			}
			catch (Exception f)
			{
				MessageBox.Show(f.Message);
			}
		}



		/// <summary>
		/// 文件打开
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ToolStripMenuItemOpen_Click(object sender, EventArgs e)
		{
			try
			{
				OpenFileDialog openFileDialog = new OpenFileDialog();

				//设置默认打开文件目录
				openFileDialog.InitialDirectory = "d:\\";
				//设定默认文件名
				openFileDialog.FileName = "";
				//设置文件过滤类型
				openFileDialog.Filter = "文本文件(*.txt)|*.txt";

				DialogResult dr = openFileDialog.ShowDialog();

				if (dr == DialogResult.OK && openFileDialog.FileName.Length > 0)
				{
					string filePath = openFileDialog.FileName;
					string fileName = openFileDialog.SafeFileName;
					OutLog("用户选择的文件目录为：" + filePath);
					OutLog("用户选择的文件名称为：" + fileName);

					using (FileStream fsRead = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Read))
					{
						byte[] buffer = new byte[1024 * 1024 * 5];
						int r = fsRead.Read(buffer, 0, buffer.Length);
						OutLog(Encoding.Default.GetString(buffer, 0, r));
					}
				}
			}
			catch (Exception f)
			{
				MessageBox.Show(f.Message);
			}
		}

		/// <summary>
		/// 输出日志
		/// </summary>
		/// <param name="strLog"></param>
		private void OutLog(string strLog)
		{
			if (textBox1.GetLineFromCharIndex(textBox1.Text.Length) > 1000)
			{
				textBox1.Clear();
			}
			textBox1.AppendText(DateTime.Now.ToString("HH:mm:ss")+strLog+"\r\n");
		}

	}
}
