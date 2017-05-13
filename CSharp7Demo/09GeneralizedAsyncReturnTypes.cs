using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CSharp7Demo
{
	public static class GeneralizedAsyncReturnTypes
	{
		public static void Demo()
		{			
			//Console.WriteLine(typeof(GeneralizedAsyncReturnTypes).GetMethod("GeneralizedAsyncReturnTypes", BindingFlags.Static | BindingFlags.Public).ReturnType);
		}

		public static async /*Value*/Task<long> GetDirectorySize(string path, string searchPattern)
		{
			if (!Directory.EnumerateFileSystemEntries(path, searchPattern).Any())
			{
				return 0;
			}
			else
			{
				return await Task.Run<long>(() => Directory.GetFiles(path, searchPattern,
					SearchOption.AllDirectories).Sum(t => (new FileInfo(t).Length)));
			}
		}
	}
}
