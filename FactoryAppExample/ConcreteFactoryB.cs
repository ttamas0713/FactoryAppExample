using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryAppExample
{
    class ConcreteFactoryB : Factory
    {
        public override IProduct createProduct()
        {
            IProduct productB = new ConcreteProductB();
            return productB;
        }
    }
}
