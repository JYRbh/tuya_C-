using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_login
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("输入用户名");
			string username = Console.ReadLine();

			Console.WriteLine("输入密码");
			string password = Console.ReadLine();

			string msg; 

			Test(username,password,out msg);

			bool b = Test(username,password,out msg);
			Console.WriteLine("登陆结果{0}",b);
			Console.WriteLine("登陆信息{0}",msg);

			Console.ReadKey();
		}

		public static bool Test(string username,string password,out string msg)
		{
			msg = null ;
			if ((username == "admin") && (password == "12345"))
			{
				msg = "登录成功";
				return true;
			}
			else
			{
				if (username != "admin")
				{
					msg = "用户名错误";
				}
				else if (password != "12345")
				{
					msg = "密码错误";
				}
				return false;
			}
		}
	}
}
