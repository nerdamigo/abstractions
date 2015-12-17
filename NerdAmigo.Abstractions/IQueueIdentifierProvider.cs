using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NerdAmigo.Abstractions
{
	/// <summary>
	/// Resolve a QueueIdentifier from a given Message
	/// </summary>
	public interface IQueueIdentifierProvider
	{
		QueueIdentifier GetIdentifier(IQueueMessage Message);
		QueueIdentifier GetIdentifier<TMessage>() where TMessage : IQueueMessage;
	}
}
