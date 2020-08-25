using System;

namespace FactoryAppExample
{
    /// <summary>
    /// This program is a simple example of using factory method pattern.
    /// </summary>
    class Program
    {
        static void Main()
        {
            new ConcreteFactoryA().createProduct().doSomething();
            new ConcreteFactoryB().createProduct().doSomething();

            Console.ReadKey();
        }
    }
}
