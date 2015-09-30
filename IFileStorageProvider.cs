using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NerdAmigo.Abstractions
{
	public interface IFileStorageProvider<TStorableObject> where TStorableObject : class, IFileStorableObject<TStorableObject>
	{
		//should we return an object wrapping the behaviors (allowing caching of file name, etc)
		IFileStorageItemInfo<TStorableObject> GetStorageItemInfo(TStorableObject aStorageItem);
	}
}
