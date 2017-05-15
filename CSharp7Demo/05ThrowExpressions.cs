using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp7Demo
{
	public class ThrowExpressions
	{
		public string FullName
		{
			set => _fullName = value ?? throw new ArgumentNullException();
			get => _fullName ?? throw new InvalidOperationException();
		}

		private string _fullName;
	}
}
