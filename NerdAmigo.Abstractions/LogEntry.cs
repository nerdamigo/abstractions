using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NerdAmigo.Abstractions
{
	public class LogEntry
	{
		public LogEventSeverity Severity { get; private set; }
		public Exception Exception { get; private set; }
		public string Source { get; private set; }
		public string Message { get; private set; }
		public int Depth { get; private set; }
		
		public LogEntry(LogEventSeverity Severity, string Message, string Source, Exception Exception)
		{
			if (string.IsNullOrWhiteSpace(Message))
			{
				throw new ArgumentNullException("Message");
			}
			if (Severity < LogEventSeverity.Debug || Severity > LogEventSeverity.Fatal)
			{
				throw new ArgumentOutOfRangeException("Severity");
			}

			this.Severity = Severity;
			this.Message = Message;
			this.Source = Source;
			this.Exception = Exception;
			this.Depth = 0;
		}

		public LogEntry(LogEventSeverity Severity, string Message) :
			this(Severity, Message, null, null)
		{

		}

		public LogEntry(LogEventSeverity Severity, string Message, string Source) :
			this(Severity, Message, Source, null)
		{

		}

		public LogEntry(LogEventSeverity Severity, string Message, Exception Exception) :
			this(Severity, Message, null, Exception)
		{

		}

		public void IncrementDepth()
		{
			this.Depth++;
		}
	}
}
