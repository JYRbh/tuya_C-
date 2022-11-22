using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
	public partial class Form1 : Form
	{
		int count;
		int time;
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			int i;
			for (i = 1; i < 100; i++)
			{
				comboBox1.Items.Add(i.ToString()+"秒");
			}
			comboBox1.Text = "1 秒";//清空文字
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			
			//设置进度条进度
			count++;
			label3.Text = (time - count).ToString() + "秒";//显示剩余秒数
			progressBar1.Value = count;
			if (time == count)
			{
				timer1.Stop();//停止计时
				System.Media.SystemSounds.Asterisk.Play();//提示音
				MessageBox.Show("时间到了！！！","提示！！");//跳出提示框
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (comboBox1.Text!="")//不设定倒计时的值不执行
			{
				string str = comboBox1.Text;//将下拉框内容添加到一个变量中
				string data = System.Text.RegularExpressions.Regex.Replace(str, @"[^0-9]+", "");
				time = Convert.ToInt16(data);//得到设定定时值（整形）
				progressBar1.Maximum = time;//进度条最大数值
				timer1.Start();//开始计时
			}
		}
	}
}
