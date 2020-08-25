using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryAppExample
{
    class ConcreteProductB : IProduct
    {
        public ConcreteProductB()
        {
            Console.WriteLine("ProductB has been created.");
        }
        public void doSomething()
        {
            Console.WriteLine("Something... by ProductB");
        }
    }
}
