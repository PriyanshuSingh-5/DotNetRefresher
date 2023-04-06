using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetRefresherProblems
{
  

    public class LRUCache<K, V>
    {
        private readonly int capacity;
        private readonly Dictionary<K, V> cache;
        private readonly LinkedList<K> queue;

        public LRUCache(int capacity)
        {
            this.capacity = capacity;
            this.cache = new Dictionary<K, V>();
            this.queue = new LinkedList<K>();
        }

        public void Add(K key, V value)
        {
            if (cache.ContainsKey(key))
            {
                queue.Remove(key);
            }
            else if (cache.Count >= capacity)
            {
                K leastRecentlyUsedKey = queue.First.Value;
                queue.RemoveFirst();
                cache.Remove(leastRecentlyUsedKey);
            }
            cache[key] = value;
            queue.AddLast(key);
        }

        public V Get(K key)
        {
            if (cache.TryGetValue(key, out V value))
            {
                queue.Remove(key);
                queue.AddLast(key);
                return value;
            }
            else
            {
                throw new KeyNotFoundException("Key not found in cache");
            }
        }
    }

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        LRUCache<int, string> cache = new LRUCache<int, string>(3);
    //        cache.Add(1, "One");
    //        cache.Add(2, "Two");
    //        cache.Add(3, "Three");
    //        Console.WriteLine(cache.Get(2)); // Output: Two
    //        cache.Add(4, "Four");
    //        Console.WriteLine(cache.Get(1)); // Throws KeyNotFoundException
    //    }
    //}

}
