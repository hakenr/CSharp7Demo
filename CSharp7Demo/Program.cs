using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp7Demo
{
	public static class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("=========================================================================");
			Console.WriteLine("Binary Literals");
			Console.WriteLine("=========================================================================");
			BinaryLiterals.Demo();

			Console.WriteLine();
			Console.WriteLine("=========================================================================");
			Console.WriteLine("Digit Separators");
			Console.WriteLine("=========================================================================");
			DigitSeparators.Demo();

			Console.WriteLine();
			Console.WriteLine("=========================================================================");
			Console.WriteLine("Out Variables");
			Console.WriteLine("=========================================================================");
			OutVariables.Demo();

			Console.WriteLine();
			Console.WriteLine("=========================================================================");
			Console.WriteLine("Local Functions");
			Console.WriteLine("=========================================================================");
			LocalFunctions.Demo();

			Console.WriteLine();
			Console.WriteLine("=========================================================================");
			Console.WriteLine("Tuples");
			Console.WriteLine("=========================================================================");
			Tuples.Demo();

			Console.WriteLine();
			Console.WriteLine("=========================================================================");
			Console.WriteLine("Pattern Matching");
			Console.WriteLine("=========================================================================");
			PatternMatching.Demo();

			Console.WriteLine();
			Console.WriteLine("=========================================================================");
			Console.WriteLine("Ref Return");
			Console.WriteLine("=========================================================================");
			RefReturn.Demo();
		}
	}
}
