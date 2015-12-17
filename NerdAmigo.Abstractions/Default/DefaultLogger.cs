using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace NerdAmigo.Abstractions.Default
{
	public class DefaultLogger : ILogger
	{
		public void Log(LogEntry entry)
		{
			StackFrame callerFrame = new StackFrame(entry.Depth + 1, false);
			MethodBase callingMethod = callerFrame.GetMethod();
			string callingMethodName = callingMethod.Name;
			Type methodDeclaringType = callingMethod.DeclaringType; 
			string callingClassName = methodDeclaringType != null ? methodDeclaringType.Name : "(none)";
			Debug.WriteLine(String.Format("{0}.{1}: {2}", callingClassName, callingMethodName, entry.Message));
		}
	}
}
