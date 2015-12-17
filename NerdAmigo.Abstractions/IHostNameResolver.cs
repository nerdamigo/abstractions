using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NerdAmigo.Abstractions
{
	/// <summary>
	/// Resolve the host name for the currently running application
	/// Use caution with relying on HttpContext.Current.Request - async / background processes do not have a HttpContext
	/// For Example: "prod01.appname.com", "mattlt01.localhost"
	/// </summary>
	public interface IHostNameResolver
	{
		string GetHostName();
	}
}
