using System;
using System.Collections.Generic;

namespace DotNetRefresherProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            //convertdays
            // ConvertDate.ConvertDaysToYearsMonths();
            //sqrt
            //SquareRoot.SquareRootWithoutMathSQRT();
            //primenumbers between 1 to 100
            // PrimeNumbers.PrimenumbersBTW1To100();
            //InheritanceDemo
            //ChildClass childObj = new ChildClass(10, 20);

            //// Calling Sum method of ChildClass
            //int sum = childObj.Sum();
            //Console.WriteLine("Sum of {0} and {1} is {2}", childObj.variable1, childObj.variable2, sum);

            // CelsiusConversion.ConversionFromCelsiusToFaren();
            //reverseSentence
            //ReverseASentence.RevereseWordsOfSentence();
            //SumOfarrayElemets
            // SumOfArrayElements.SumOfArraydata();

            ///Filepath
            //Fileproblem.CheckFilepath();
            //Fileproblem.ReadFromFile();
            //nthIteration
            //NthIteration.NthIterationMethod();
            //height category
            //HeightCategory.CheckHeightCategory();
            //linq queries
            //LinqProblems.FindListOfPositive();
            //LinqProblems.SquareOfNumbersInArray();

            //Operators
            // FindOperators.CheckOperator();
            //All points fall into staright line
            //CheckAllLines.CheckLinesFallsintoOneLine();
            //Conversion of hours into minutes and seconds
            // ConversionOfHours.Conversion();
            //Check eneterd value
            //CheckEnterdValue.Check();
            //N1N2
            //N1N2Problem.Multiply();


            ///new problems for SureWave
            ///
            //LRUCache<int, string> cache = new LRUCache<int, string>(3);
            //cache.Add(1, "One");
            //cache.Add(2, "Two");
            //cache.Add(3, "Three");
            //Console.WriteLine(cache.Get(2)); // Output: Two
            //cache.Add(4, "Four");
            // Console.WriteLine(cache.Get(1)); // Throws KeyNotFoundException

            //SortByproperty
            //Person[] people = new Person[]
            //{
            //new Person("Alice", 25),
            //new Person("Bob", 30),
            //new Person("Charlie", 20),
            //};
            //Person[] sortedPeople = people.SortByProperty("Age");
            //foreach (Person person in sortedPeople)
            //{
            //    Console.WriteLine($"{person.Name}, {person.Age}");
            //}

            //Restricted list:
            //RestrictedList<Animal> animals = new RestrictedList<Animal>();
            //animals.Add(new Dog("Fido"));
            //animals.Add(new Cat("Whiskers"));
            //// animals.Add("Not an animal");  // This would fail to compile

            //Console.WriteLine($"Number of animals: {animals.Count}");
            //Console.WriteLine($"Animal at index 0: {animals[0].Name}");

            //Merge Sorting
            //int[] numbers = { 4, 2, 1, 5, 3 };
            //MergeSorter<int>.MergeSort(numbers);

            //foreach (var number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //string[] words = { "apple", "banana", "pear", "orange", "kiwi" };
            //MergeSorter<string>.MergeSort(words);

            //foreach (var word in words)
            //{
            //    Console.WriteLine(word);
            //}


            //Hierarchy of shape
            //ShapeCollection<Shape> shapeCollection = new ShapeCollection<Shape>();

            //// Create some shapes
            //Circle circle = new Circle(3);
            //Rectangle rectangle = new Rectangle(4, 5);
            //Triangle triangle = new Triangle(4, 5);

            //// Add shapes to the collection
            //shapeCollection.Add(circle);
            //shapeCollection.Add(rectangle);
            //shapeCollection.Add(triangle);

            //// Display the shapes in the read-only collection
            //Console.WriteLine("Read-Only Collection:");
            //foreach (Shape shape in shapeCollection.ReadOnly)
            //{
            //    Console.WriteLine(shape);
            //}

            //// Modify a shape in the read-write collection
            //shapeCollection.ReadWrite[0] = new Circle(4);

            //// Add a new shape to the read-write collection
            //shapeCollection.ReadWrite.Add(new Triangle(3, 4));

            //// Remove a shape from the read-write collection
            //shapeCollection.ReadWrite.Remove(rectangle);

            //// Display the shapes in the read-write collection
            //Console.WriteLine("Read-Write Collection:");
            //foreach (Shape shape in shapeCollection.ReadWrite.ReadOnly)
            //{
            //    Console.WriteLine(shape);
            //}


            //Irepository demo

            //var personRepository = new InMemoryRepository<Persons>();

            //// Add some people to the repository
            //personRepository.Add(new Persons { Name = "Alice", Age = 25 });
            //personRepository.Add(new Persons { Name = "Bob", Age = 30 });
            //personRepository.Add(new Persons { Name = "Charlie", Age = 35 });

            //// Get all people from the repository
            //Console.WriteLine("All people:");
            //foreach (var person in personRepository.GetAll())
            //{
            //    Console.WriteLine("{0} (age {1})", person.Name, person.Age);
            //}

            //// Get a person by ID
            //int id = 2;
            //var personById = personRepository.GetById(id);
            //if (personById != null)
            //{
            //    Console.WriteLine("Person with ID {0}: {1} (age {2})", id, personById.Name, personById.Age);
            //}
            //else
            //{
            //    Console.WriteLine("No person found with ID {0}", id);
            //}

            //// Remove a person from the repository
            //var personToRemove = new Persons { Id = 1, Name = "Alice", Age = 25 };
            //bool removed = personRepository.Remove(personToRemove);
            //if (removed)
            //{
            //    Console.WriteLine("Removed {0} (age {1})", personToRemove.Name, personToRemove.Age);
            //}
            //else
            //{
            //    Console.WriteLine("Could not remove {0} (age {1})", personToRemove.Name, personToRemove.Age);
            //}

            //// Get all people from the repository again
            //Console.WriteLine("All people:");
            //foreach (var person in personRepository.GetAll())
            //{
            //    Console.WriteLine("{0} (age {1})", person.Name, person.Age);
            //}


            ///Generic all combined
            ///
            Stack<object> objStack = new Stack<object>();
            objStack.Push(1);
            objStack.Push("hello");
            objStack.Push(new Meat());

            // Create a Stack that can only hold integers
            Stack<int> intStack = new Stack<int>();
            intStack.Push(1);
            intStack.Push(2);
            intStack.Push(3);

            // Create an animal that can eat any type of food
            Animal<IFood> anyFoodAnimal = new Animal<IFood>();
            anyFoodAnimal.Eat(new Meat());
            anyFoodAnimal.Eat(new Vegetables());

            // Create an animal that can only eat meat
            Animal<Meat> meatEatingAnimal = new Animal<Meat>();
            meatEatingAnimal.Eat(new Meat());

        }
    }



    }
    
