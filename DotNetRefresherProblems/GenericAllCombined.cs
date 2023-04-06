using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetRefresherProblems
{
    using System;
    using System.Collections.Generic;

    // Define the IFood interface
    interface IFood
    {
        void Eat();
    }

    // Define the Meat class that implements the IFood interface
    class Meat : IFood
    {
        public void Eat()
        {
            Console.WriteLine("Eating meat.");
        }
    }

    // Define the Vegetables class that implements the IFood interface
    class Vegetables : IFood
    {
        public void Eat()
        {
            Console.WriteLine("Eating vegetables.");
        }
    }

    // Define the IAnimal interface
    interface IAnimal<T> where T : IFood
    {
        void Eat(T food);
    }

    // Define the Animal class that implements the IAnimal interface
    class Animal<T> : IAnimal<T> where T : IFood
    {
        public void Eat(T food)
        {
            Console.Write("Animal eating: ");
            food.Eat();
        }
    }

    
       
            // Create a Stack that can hold any type of object
            //Stack<object> objStack = new Stack<object>();
            //objStack.Push(1);
            //objStack.Push("hello");
            //objStack.Push(new Meat());

            //// Create a Stack that can only hold integers
            //Stack<int> intStack = new Stack<int>();
            //intStack.Push(1);
            //intStack.Push(2);
            //intStack.Push(3);

            //// Create an animal that can eat any type of food
            //Animal<IFood> anyFoodAnimal = new Animal<IFood>();
            //anyFoodAnimal.Eat(new Meat());
            //anyFoodAnimal.Eat(new Vegetables());

            //// Create an animal that can only eat meat
            //Animal<Meat> meatEatingAnimal = new Animal<Meat>();
            //meatEatingAnimal.Eat(new Meat());

            // Attempt to create an animal that can only eat vegetables (will not compile)
            // Animal<Vegetables> vegetableEatingAnimal = new Animal<Vegetables>();

            // Attempt to push a string onto the intStack (will not compile)
            // intStack.Push("world");
        
    }


