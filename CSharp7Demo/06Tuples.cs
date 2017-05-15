using System;
using System.Linq;

namespace CSharp7Demo
{
	public static class Tuples
	{
		// Error CS8137: Cannot define a class or member that utilizes tuples because the compiler required type
		// 'System.Runtime.CompilerServices.TupleElementNamesAttribute' cannot be found.Are you missing a reference?
		// --> Nainstalovat NuGet balíček System.ValueType
		// --> nebo .NET 4.7 !!

		public static (string, string, string) SplitPath(string path)
		{
			return (
				System.IO.Path.GetDirectoryName(path),
				System.IO.Path.GetFileNameWithoutExtension(path),
				System.IO.Path.GetExtension(path)
				);
		}

		public static (string directoryName, string fileName, string extension) SplitPathWithNames(string path)
		{
			return (
				System.IO.Path.GetDirectoryName(path),
				System.IO.Path.GetFileNameWithoutExtension(path),
				System.IO.Path.GetExtension(path)
				);
		}

		public static void Demo()
		{
			var pathData1 = SplitPath(@"D:\Temp\MyFile.txt");
			var pathData2 = SplitPathWithNames(@"D:\Temp\MyFile.txt");
			
			Console.WriteLine(pathData1.Equals(pathData2));							// true

			Console.WriteLine(pathData1.GetType());									// System.ValueTuple<string, string, string>
			Console.WriteLine(pathData1.GetType().GetProperties().Count());			// 0 - jsou to fieldy, ne properties
			pathData1.GetType().GetFields().ToList().ForEach(Console.WriteLine);	// Item1, Item2, Item3

			Console.WriteLine(pathData2.GetType());									// stejné jako pathData1
			Console.WriteLine(pathData2.GetType().GetProperties().Count());			// stejné jako pathData1
			pathData2.GetType().GetFields().ToList().ForEach(Console.WriteLine);	// stejné jako pathData1

			pathData2 = pathData1;

			pathData1 = (@"C:\Wow", "Blah", "txt");

			var pathData3 = (directoryName: @"C:\Hah", fileName: "Daah", extension: "cs");

			pathData1 = pathData3;

			// pozor na přeházení pořadí !!
			(string DirectoryName, string extension, string filename) pathData4 = SplitPath(@"D:\Temp\MyFile.txt");
			Console.WriteLine(pathData4.extension); // "MyFile"
			(string DirectoryName, string extension, string filename) pathData5 = SplitPathWithNames(@"D:\Temp\MyFile.txt");
			Console.WriteLine(pathData4.extension); // "MyFile"

			// deconstruction
			var (directoryName, fileName, extension) = SplitPathWithNames(@"D:\Temp\MyFile.txt");
			Console.WriteLine(directoryName);
		}
	}
}