using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetRefresherProblems
{
    using System.Collections.Generic;

    public interface IRepository<T>
    {
        void Add(T item);
        bool Remove(T item);
        T GetById(int id);
        IEnumerable<T> GetAll();
    }

    public class InMemoryRepository<T> : IRepository<T> where T : IEntity
    {
        private readonly Dictionary<int, T> items = new Dictionary<int, T>();
        private int nextId = 1;

        public void Add(T item)
        {
            item.Id = nextId;
            items.Add(nextId, item);
            nextId++;
        }

        public bool Remove(T item)
        {
            return items.Remove(item.Id);
        }

        public T GetById(int id)
        {
            T item;
            items.TryGetValue(id, out item);
            return item;
        }

        public IEnumerable<T> GetAll()
        {
            return items.Values;
        }
    }

    public interface IEntity
    {
        int Id { get; set; }
    }

    public class Persons : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }

}
