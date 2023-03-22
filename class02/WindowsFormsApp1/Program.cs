using System;

namespace Filelog
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
		}
	}	
	private void button1_Click(object sender, EventArgs e)
	{
		SaveFileDialog saveFileDialog = new SaveFileDialog();

		//设置默认打开文件目录
		saveFileDialog.InitialDirectory = "d:\\";
		//设置文件类型，这里才使用筛选器进行设置
    	saveFileDialog.Filter = "*.txt";
		//保存对话框是否记录上次打开的目录
		saveFileDialog.RestoreDirectory = true;
		//设置默认的文件名
		saveFileDialog.FileName = "123";
		DialogResult dr = saveFileDialog.ShowDialog();
		if (dr == DialogResult.OK && saveFileDialog.FileName.Length > 0) 
		{
			textBox1.Text = saveFileDialog.FileName;
		}
	}
}
