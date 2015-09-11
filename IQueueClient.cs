using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NerdAmigo.Abstractions
{
	public interface IQueueClient<TMessage> where TMessage : IQueueMessage
	{
		/// <summary>
		/// Add a message to a given queue
		/// </summary>
		/// <param name="Queue">Identifier for the Queue</param>
		/// <param name="Message"></param>
		/// <returns>Message object</returns>
		Task<TMessage> Enqueue(TMessage Message, CancellationToken cancellationToken);

		/// <summary>
		/// Get the next message from the queue
		/// </summary>
		/// <param name="Queue">Identifier for the Queue</param>
		Task<TMessage> Receive(CancellationToken cancellationToken);

		/// <summary>
		/// Remove a received message from the queue
		/// </summary>
		/// <typeparam name="TMessage"></typeparam>
		/// <param name="Message">Message to be removed</param>
		Task Delete(TMessage Message, CancellationToken cancellationToken);
	}
}
