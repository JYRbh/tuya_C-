using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_My_Second_Demo
{
	public enum QQState
	{ 
		OnLine,
		OffLine,
		Leave,
		Busy,
		QMe
	}
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("您选择的在线状态是{0}");
			string input = Console.ReadLine();

			switch (input)
			{
				case "1":
					QQState s1= (QQState)Enum.Parse(typeof(QQState), input);
					Console.WriteLine("您选择的在线状态是{0}",s1);
					break;
				case "2":
					QQState s2 = (QQState)Enum.Parse(typeof(QQState), input);
					Console.WriteLine("您选择的在线状态是{0}", s2);
					break;
				case "3":
					QQState s3 = (QQState)Enum.Parse(typeof(QQState), input);
					break;
				case "4":
					QQState s4 = (QQState)Enum.Parse(typeof(QQState), input);
					break;
				case "5":
					QQState s5 = (QQState)Enum.Parse(typeof(QQState), input);
					break;

			}


			Console.WriteLine();
			Console.ReadKey();


		}
	}
}
