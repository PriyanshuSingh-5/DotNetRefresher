using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace DotNetRefresherProblems
{
    public static class ArrayExtensions
    {
        public static T[] SortByProperty<T>(this T[] array, string propertyName)
        {
            PropertyInfo property = typeof(T).GetProperty(propertyName);
            if (property == null)
            {
                throw new ArgumentException($"Property {propertyName} not found on type {typeof(T).Name}");
            }
            if (!property.CanRead)
            {
                throw new ArgumentException($"Property {propertyName} on type {typeof(T).Name} is write-only");
            }
            if (!typeof(IComparable).IsAssignableFrom(property.PropertyType))
            {
                throw new ArgumentException($"Property {propertyName} on type {typeof(T).Name} does not implement IComparable");
            }
            return array.OrderBy(x => property.GetValue(x)).ToArray();
        }
    }

    

    class Person
    {
        public string Name { get; }
        public int Age { get; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}
