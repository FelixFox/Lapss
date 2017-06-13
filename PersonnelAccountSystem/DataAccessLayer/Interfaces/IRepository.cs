using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonnelAccountSystem.DataAccessLayer.Interfaces
{
    
        public interface IRepository<T> where T : class
        {
            IEnumerable<T> GetList();
            T Get(int id);
            IEnumerable<T> Find(Func<T, Boolean> predicate);
            void Add(T item);
            void Update(T item, T newItem);
            void Remove(int id);
        }
    
}
