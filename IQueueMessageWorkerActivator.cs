using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NerdAmigo.Abstractions
{
	/// <summary>
	/// Provides an activated type ready for processing messages from a queue
	/// </summary>
	public interface IQueueMessageWorkerActivator
	{
		IQueueMessageWorker<TMessage> GetWorker<TMessage>() where TMessage : IQueueMessage;
	}
}
