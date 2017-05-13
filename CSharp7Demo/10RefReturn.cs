using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp7Demo
{
	public static class RefReturn
	{
		public static int x;

		public static ref int Find(int number, int[] numbers)
		{
			for (int i = 0; i < numbers.Length; i++)
			{
				if (numbers[i] == number)
				{
					return ref numbers[i]; // return the storage location, not the value
				}
			}
			throw new IndexOutOfRangeException($"{nameof(number)} not found");
		}

		public static void Demo()
		{
			int i = 0;
			int j = 0;
			int k = 1;

			ref int ri = ref i;
			
			ri = 5;
			Console.WriteLine(i);
			Console.WriteLine(x);
			//int[] array = { 1, 2, 3, 4, 5, 6, 7 };
			//ref int place = ref array[4];//(4, array); // aliases 7's place in the array
			//array[4] = 555;
			//place = 444; // replaces 7 with 9 in the array
			//foreach (int number in array)
			//{
			//	Console.WriteLine(number);
			//}
		}
	}
}
