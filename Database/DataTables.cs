/*
 * Created by SharpDevelop.
 * User: HTREMMEL
 * Date: 05/26/2016
 * Time: 10:06
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System.Collections.Generic;

namespace MyManager.Database
{
	/// <summary>
	/// Description of DataTables.
	/// </summary>
	public class DataTable<T>: IList<T> where T: class
	{
		public DataTable(T dataObject)
		{
		}
		
		public static DataTable<T> GetDataTable(T dataObject)
		{
            throw new System.NotImplementedException();
		}

        public int IndexOf(T item)
        {
            throw new System.NotImplementedException();
        }

        public void Insert(int index, T item)
        {
            throw new System.NotImplementedException();
        }

        public void RemoveAt(int index)
        {
            throw new System.NotImplementedException();
        }

        public T this[int index]
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
                throw new System.NotImplementedException();
            }
        }

        public void Add(T item)
        {
            throw new System.NotImplementedException();
        }

        public void Clear()
        {
            throw new System.NotImplementedException();
        }

        public bool Contains(T item)
        {
            throw new System.NotImplementedException();
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new System.NotImplementedException();
        }

        public int Count
        {
            get { throw new System.NotImplementedException(); }
        }

        public bool IsReadOnly
        {
            get { throw new System.NotImplementedException(); }
        }

        public bool Remove(T item)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new System.NotImplementedException();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            throw new System.NotImplementedException();
        }
    }
}
