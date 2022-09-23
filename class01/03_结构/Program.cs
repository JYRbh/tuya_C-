using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_stru
{
	public struct color
	{
		public int _red;
		public int _green;
		public int _blue;
	}

	public struct Person
	{
		public string name;
		public int age;
		public string adress;

	}

	class Program
	{
		static void Main(string[] args)
		{
			color mc;
			mc._blue = 0;
			mc._green = 0;
			mc._red = 255;
		}
	}
}
