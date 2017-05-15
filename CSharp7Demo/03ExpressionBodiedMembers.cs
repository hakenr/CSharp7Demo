using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp7Demo
{
	public class ExpressionBodiedMembers
	{
		private string fullname;

		// C# 6.0 - Expression-bodied Methods and Properties
		public override string ToString() => fullname;
		public string FullnameX => fullname;  // getter-only

		//
		// 
		// C# 7.0 - More expression-bodied members
		
		// Expression-bodied constructor
		public ExpressionBodiedMembers(string fullname) => this.fullname = fullname;

		// Expression-bodied destructor (finalizer)
		~ExpressionBodiedMembers() => Console.Error.WriteLine("Finalized!");

		// Expression-bodied get/set accessors
		public string Fullname
		{
			get => fullname;
			set => fullname = value;
		}

	}
}
