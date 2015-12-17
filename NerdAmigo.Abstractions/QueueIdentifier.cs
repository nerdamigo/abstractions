using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NerdAmigo.Abstractions
{
	public class QueueIdentifier : Identifier
	{
		public string QueueName { get; private set; }

		public QueueIdentifier(string QueueName)
		{
			this.QueueName = QueueName;
		}

		public override bool Equals(object obj)
		{
			throw new NotImplementedException();
		}

		public override int GetHashCode()
		{
			throw new NotImplementedException();
		}

		public override string ToString()
		{
			throw new NotImplementedException();
		}
	}
}
