using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NerdAmigo.Abstractions
{
	public abstract class Identifier
	{
		public abstract override bool Equals(object obj);
		public abstract override int GetHashCode();
		public abstract override string ToString();
	}
}
