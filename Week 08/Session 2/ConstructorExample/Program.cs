using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorExample
{
    internal class Program
    {
        public class MyClass
        {
            public string Name { get; set; }

            public MyClass(string name)
            {
                Name = name;
            }
        }

        public class MyDerivedClass : MyClass
        {
            public bool bAlive;

            // the "this" keyword will call the constructor that matches the signature within the same class
            public MyDerivedClass() : this(true)
            {

            }

            // "base" will call the parent constructor that matches the signature
            public MyDerivedClass(bool bAlive) : base("David")
            {
                this.bAlive = bAlive;
            }
        }
        static void Main(string[] args)
        {
        }
    }
}
