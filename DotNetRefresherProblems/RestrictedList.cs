using System;
using System.Collections.Generic;
using System.Text;

using System.Collections.Generic;

namespace DotNetRefresherProblems
{
   

    public class RestrictedList<T>
    {
        private List<T> list = new List<T>();

        public void Add<U>(U item) where U : T
        {
            list.Add(item);
        }

        public T this[int index]
        {
            get { return list[index]; }
            set { list[index] = value; }
        }

        public int Count => list.Count;
    }

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        RestrictedList<Animal> animals = new RestrictedList<Animal>();
    //        animals.Add(new Dog("Fido"));
    //        animals.Add(new Cat("Whiskers"));
    //        // animals.Add("Not an animal");  // This would fail to compile

    //        Console.WriteLine($"Number of animals: {animals.Count}");
    //        Console.WriteLine($"Animal at index 0: {animals[0].Name}");
    //    }
    //}

    class Animal
    {
        public string Name { get; set; }

        public Animal(string name)
        {
            Name = name;
        }
    }

    class Dog : Animal
    {
        public Dog(string name) : base(name) { }
    }

    class Cat : Animal
    {
        public Cat(string name) : base(name) { }
    }

}
