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
			string s = "aaa";
			bool b;
			if (b = int.TryParse(s, out int i))
			{
				Console.WriteLine(i);
			}
			Console.WriteLine(i);

			//if (int.TryParse(s, out var i))
			//{
			//	Console.WriteLine(i);
			//}
		}
	}
}
