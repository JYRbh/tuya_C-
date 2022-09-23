using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_A
{
	class Program
	{

		public static int[] nums = new int[10];
		static void Main(string[] args)
		{

			//练习1：从一个整数数组中取出最大的整数，最小整数，总和，平均值
			Console.WriteLine("输入数字");
			for (int i = 0; i < nums.Length; i++)
			{
				int numbers=int.Parse(Console.ReadLine());
				nums[i] = numbers;
			}
			Console.WriteLine("数组");
			for (int i = 0; i < nums.Length; i++)
			{
				Console.WriteLine(nums[i]);
			}
			Console.ReadKey();
		}
	}
}
