using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_MyTryParse
{
	class Program
	{
		static void Main(string[] args)
		{
			int num;
			bool b = MyTryParse(Console.ReadLine(),out num);
			Console.WriteLine(num);
			Console.WriteLine(b);
			Console.ReadKey();
		}

		public static bool MyTryParse(string s, out int num)
		{
			num = 0;
			try
			{
				num = Convert.ToInt32(s);
				return true;
			}
			catch 
			{
				return false;
			}
		}
	}
}
