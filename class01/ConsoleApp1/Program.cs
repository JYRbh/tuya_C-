using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_My_Frist_Demo
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("请输入一个数字");
			int number = 0;

			try
			{
				number = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine(number * 2);
			}
			catch 
			{
				Console.WriteLine("输入的内容不能转换成数字");
			}

			Console.ReadKey();
		}
	}
} 
