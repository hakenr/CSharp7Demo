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

		//public string Fullname => fullname;
		public string Fullname
		{
			get => fullname;
			set => fullname = value;
		}

		public override string ToString() => fullname;
	}
}
