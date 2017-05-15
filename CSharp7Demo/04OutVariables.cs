using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp7Demo
{
	public static class OutVariables
	{
		public static void Demo()
		{
			string s = "0b100";

			if (int.TryParse(s, out int i))
			{
				Console.WriteLine(i);
			}
			Console.WriteLine(i); // scope

			if (int.TryParse(s, out var j))
			{
				Console.WriteLine(j);
			}
		}
	}
}
