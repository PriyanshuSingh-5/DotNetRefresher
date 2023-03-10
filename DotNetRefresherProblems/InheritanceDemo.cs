using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetRefresherProblems
{
    public class InheritanceDemo
    {
        //Write a C# program to demonstarte working of inheritance.

       
    }
    public class ParentClass
    {
        public int variable1;
        public int variable2;

        public ParentClass(int var1, int var2)
        {
            variable1 = var1;
            variable2 = var2;
        }
    }

    // Child class inheriting from ParentClass
    public class ChildClass : ParentClass
    {
        public ChildClass(int var1, int var2) : base(var1, var2)
        {
        }

        public int Sum()
        {
            return variable1 + variable2;
        }
    }
}
