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

			int i1 = 0_______1_______0;
			int i2 = 0______121______0;
			int i3 = 0_____12321_____0;
			int i4 = 0____1234321____0;
			int i5 = 0___123454321___0;
			int i6 = 0____1234321____0;
			int i7 = 0_____12321_____0;
			int i8 = 0______121______0;
			int i9 = 0_______1_______0;

			Console.WriteLine(i);
		}
	}
}
