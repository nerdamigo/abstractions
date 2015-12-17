using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NerdAmigo.Abstractions
{
	public interface IConfigurationProvider<TConfig> where TConfig : ICloneable, new()
	{
		void ConfigurationUpdated(Action<TConfig> ConfigurationUpdatedAction);
		TConfig CurrentConfiguration { get; }
	}
}
