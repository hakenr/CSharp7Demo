using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp7Demo
{
	public static class LocalFunctions
	{
		public static void Demo()
		{
			Console.WriteLine(IsPalindrome("abc"));
			Console.WriteLine(IsPalindrome("abcba"));
		}

		private static bool IsPalindrome(string text)
		{
			if (string.IsNullOrWhiteSpace(text))
			{
				return false;				
			}

			bool LocalIsPalindrome(string target)
			{
				string s = text;
				target = target.Trim();
				if (target.Length <= 1)
				{
					return true;
				}
				else
				{
					return char.ToLower(target[0]) ==
					  char.ToLower(target[target.Length - 1]) &&
					  LocalIsPalindrome(
						target.Substring(1, target.Length - 2));
				}
			}
			return LocalIsPalindrome(text);
		}
	}
}

