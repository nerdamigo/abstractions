using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NerdAmigo.Abstractions
{
	public class QueueMessageIdentifier : Identifier
	{
		public string MessageID { get; private set; }

		public QueueMessageIdentifier(string MessageID)
		{
			this.MessageID = MessageID;
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
