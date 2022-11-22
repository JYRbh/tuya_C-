using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsTest
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		private void Form1_Load(object sender, EventArgs e)
		{
			string str;
			for (int i = 0; i < 256; i++)
			{
				str = i.ToString("x").ToUpper();//ToString("x")是将数字转化成16进制字符串，ToUpper是将字符串所有字母变成大写
				//comboBox1.Items.Add("0x" + (str.Length == 1 ? "0" + str : str));
				if (str.Length == 1)
					str = "0" + str;//如果是一位的（0xA），在A前添加一个0
				comboBox1.Items.Add("0x" + str);//统一添加 “0x”
			}
			comboBox1.Text = "0x00";//初始值
		}
		private void label1_Click(object sender, EventArgs e)
		{
			
		}

		private void button1_Click(object sender, EventArgs e)
		{
			string data = comboBox1.Text;//存储当前下拉框的内容
			string result = System.Text.RegularExpressions.Regex.Replace(data, @"[^0-9]+","");//提取出字符串中数字的部分
			byte[] buffer = new byte[1];//数据一个字节就够用了
			buffer[0] = Convert.ToByte(result,16);//将字符串转化为byte型变量（byte = char）
			try
			{
				serialPort1.Open();
				serialPort1.Write(buffer, 0, 1);
				serialPort1.Close();
			}
			catch (Exception err)//如果出错就执行此块代码
			{
				if (serialPort1.IsOpen)
				{
					serialPort1.Close();//如果写数据的时出错，此窗口状态为开，就应该关闭串口，防止下次不能使用，串口是不能
				}
				MessageBox.Show(err.ToString(),"错误");
			}
		}
	}
}
