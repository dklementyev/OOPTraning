using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTraning
{
    interface ILibraryRepository<T>: IDisposable
        where T : class
    {
        IEnumerable<T> GetItems();
        T GetItem(int id);
        void Create(T item);
        void Update(T item);
        void Delete(int id);
        void Save();
    }
}
