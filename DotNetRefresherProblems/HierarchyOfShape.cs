using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace DotNetRefresherProblems
{
 

    public abstract class Shape
    {
        public abstract double GetArea();
    }

    public class Circle : Shape
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public override double GetArea()
        {
            return Math.PI * radius * radius;
        }
    }

    public class Rectangle : Shape
    {
        private double width;
        private double height;

        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public override double GetArea()
        {
            return width * height;
        }
    }

    public class Triangle : Shape
    {
        private double baseLength;
        private double height;

        public Triangle(double baseLength, double height)
        {
            this.baseLength = baseLength;
            this.height = height;
        }

        public override double GetArea()
        {
            return 0.5 * baseLength * height;
        }
    }


    public class ShapeCollection<T> where T : Shape
    {
        private readonly List<T> shapes = new List<T>();

        public ReadOnlyCollection<T> ReadOnly => new ReadOnlyCollection<T>(shapes);

        public ReadWriteCollection ReadWrite => new ReadWriteCollection(shapes);

        public void Add(T shape)
        {
            shapes.Add(shape);
        }

        public bool Remove(T shape)
        {
            return shapes.Remove(shape);
        }

        public void Clear()
        {
            shapes.Clear();
        }

        public class ReadWriteCollection
        {
            private readonly List<T> shapes;

            public ReadWriteCollection(List<T> shapes)
            {
                this.shapes = shapes;
            }

            public int Count => shapes.Count;

            public T this[int index]
            {
                get => shapes[index];
                set => shapes[index] = value;
            }

            public void Add(T shape)
            {
                shapes.Add(shape);
            }

            public bool Remove(T shape)
            {
                return shapes.Remove(shape);
            }

            public void Clear()
            {
                shapes.Clear();
            }

            public ReadOnlyCollection<T> ReadOnly => new ReadOnlyCollection<T>(shapes);
        }
    }


}
