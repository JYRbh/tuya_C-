using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_方法
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] number = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
			/*			for (int i = 0; i < 4; i++)
						{
							Console.WriteLine(GetMaxMinSumAvg(number)[i]);
						}*/
						
		
			int max = 0;
			int min = 0;
			int sum = 0;
			int avg = 0;
			bool b;
			string s;
			double d;

			Test(number,out max,out min,out sum,out avg);
			Console.WriteLine(max);
			Console.WriteLine(min);
			Console.WriteLine(sum);
			Console.WriteLine(avg);
			Console.ReadKey();
		}

		public static int GetNumber() 
		{
			while (true)
			{
				try
				{
					int number = Convert.ToInt32(Console.ReadLine());
					return number;
				}
				catch
				{
					Console.WriteLine("输入有误！！！");
				}
			}
		}

		public static int GetSum(int[] nums)
		{
			int sum = 0;
			for (int i = 0; i < nums.Length; i++)
			{
				sum = sum + nums[i];
			}
			return sum;
		}



		//获取最大值，最小值，总和，平均值
		public static void Test(int[] nums,out int max,out int min,out int sum,out int avg)
		{
			int[] res = new int[4];
			max = nums[0];
			min = nums[0];
			sum = 0;
			avg = 0;

			for (int i = 0; i < nums.Length; i++)
			{
				if (nums[i] > max)
				{
					max = nums[i];
				}
				if (nums[i] < min)
				{
					min = nums[i];
				}
				sum = sum + nums[i];
			}
			avg = sum / (nums.Length);

		}

		//获取最大值，最小值，总和，平均值
		public static int[] GetMaxMinSumAvg(int[] nums)
		{
			int[] res = new int[4];
			res[0] = nums[0];
			res[1] = nums[0];
			res[2] = 0;
			res[3] = 0;

			for (int i = 0; i < nums.Length; i++)
			{
				if (nums[i] > res[0])
				{
					res[0] = nums[i];
				}
				if (nums[i] < res[1])
				{
					res[1] = nums[i];
				}
				res[2] = res[2] + nums[i];
			}
			res[3] = res[2] / (nums.Length);

			return res;

		}

	}
}
