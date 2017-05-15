using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp7Demo
{
	public static class BinaryLiterals
	{		
		public static void Demo()
		{
			int[] numbers = { 1, 2, 4, 8, 16, 32 };
			int[] numbers2 = { 0b1, 0b10, 0b100, 0b1000, 0b1_0000, 0b10_0000 };

			int i = 0b100000000;
			Console.WriteLine(i);
		}
	}

	[Flags]
	public enum Option
	{
		None    = 0b00000000,
		Option1 = 0b00000001,
		Option2 = 0b00000010,
		Option3 = 0b00000100,
		Option4 = 0b00001000,
		Option5 = 0b00010000,
		Option6 = 0b00100000,
		Option7 = 0b01000000,
		Option8 = 0b10000000,
		All     = 0b11111111
	}
}
