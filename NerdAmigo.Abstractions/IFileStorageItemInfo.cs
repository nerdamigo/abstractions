using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NerdAmigo.Abstractions
{
	/// <summary>
	/// Interaction Behaviours associated with a blob of data stored on some form of persistant storage
	/// </summary>
	/// <typeparam name="TStorableObject"></typeparam>
	public interface IFileStorageItemInfo<TStorableObject> : IDisposable where TStorableObject : class
	{
		/// <summary>
		/// action to be performed when the storable object in question is altered in storage
		/// </summary>
		/// <param name="updateAction"></param>
		void OnUpdate(Action updateAction);

		/// <summary>
		/// action to be performed when the storable object in question is removed from storage
		/// </summary>
		/// <param name="deleteAction"></param>
		void OnDelete(Action deleteAction);

		/// <summary>
		/// Provide a stream for access to read the stored data
		/// </summary>
		/// <returns></returns>
		Stream Open();

		/// <summary>
		/// Store supplied data
		/// </summary>
		/// <param name="data">Stream providing the data to be saved</param>
		void Save(Stream data);
		
		void Delete();
		
		bool Exists();
	}
}
