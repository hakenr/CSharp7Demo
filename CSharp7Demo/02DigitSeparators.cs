using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp7Demo
{
	public static class DigitSeparators
	{
		public static void Demo()
		{
			decimal i = 1_000_000.00_001M;
			Console.WriteLine(i);
		}
	}
}
