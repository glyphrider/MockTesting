using System;
using System.Collections.Generic;

namespace Library
{
	public class First
	{
		public First ()
		{
		}

		public virtual string Method ()
		{
			return "base";
		}
		
		public ICollection<string> Collection
		{
			get { return new List<string>() { "test value", "other value" }; }
		}
	}
}

