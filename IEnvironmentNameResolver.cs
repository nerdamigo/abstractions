using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NerdAmigo.Abstractions
{
	/// <summary>
	/// Provide the current environment name for the running application
	/// For example: "development", "integration", "staging", "production"
	/// </summary>
	public interface IEnvironmentNameResolver
	{
		string GetEnvironmentName();
	}
}
