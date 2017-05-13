using System;
using System.Linq;

namespace CSharp7Demo
{
	public static class Tuples
	{
		public static void Demo()
		{
			Demo1();
			Demo2();
			Demo3();
		}

		// Error CS8137: Cannot define a class or member that utilizes tuples because the compiler required type 'System.Runtime.CompilerServices.TupleElementNamesAttribute' cannot be found.Are you missing a reference?
		// --> Nainstalovat NuGet balíček System.ValueType

		// Warning SA1008: Opening parenthesis must not be preceded by a space.

		public static (string, string, string) SplitPath(string path)
		{
			return (
				System.IO.Path.GetDirectoryName(path),
				System.IO.Path.GetFileNameWithoutExtension(path),
				System.IO.Path.GetExtension(path)
				);
		}

		public static (string DirectoryName, string FileName, string Extension) SplitPath2(string path)
		{
			return (
				System.IO.Path.GetDirectoryName(path),
				System.IO.Path.GetFileNameWithoutExtension(path),
				System.IO.Path.GetExtension(path)
				);
		}

		public static void Demo1()
		{
			var pathData1 = SplitPath(@"D:\Temp\MyFile.txt");
			var pathData2 = SplitPath2(@"D:\Temp\MyFile.txt");
			
			Console.WriteLine(pathData1.Equals(pathData2));

			Console.WriteLine(pathData1.GetType());
			//Console.WriteLine(pathData1.GetType().GetProperties().Count());
			//pathData1.GetType().GetFields().ToList().ForEach(Console.WriteLine);

			//Console.WriteLine(pathData2.GetType());
			//Console.WriteLine(pathData2.GetType().GetProperties().Count());
			//pathData2.GetType().GetFields().ToList().ForEach(Console.WriteLine);

			pathData2 = pathData1;			
		}

		public static void Demo2()
		{
			(string DirectoryName, string extension, string filename) pathData2 = SplitPath(@"D:\Temp\MyFile.txt");
			Console.WriteLine(pathData2);
		}

		public static void Demo3()
		{
			var (directoryName, fileName, extension) = SplitPath2(@"D:\Temp\MyFile.txt");
			Console.WriteLine(directoryName);
		}
	}
}