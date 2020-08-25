using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryAppExample
{
    class ConcreteProductA : IProduct
    {
        public ConcreteProductA()
        {
            Console.WriteLine("ProductA has been created.");
        }
        public void doSomething()
        {
            Console.WriteLine("Something... by ProductA");
        }
    }
}
