using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NerdAmigo.Abstractions
{
	public interface IFileStorableObject<TStorable> where TStorable : class
	{
		string FileName { get; }
	}
}
