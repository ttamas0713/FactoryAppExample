using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryAppExample
{
    class ConcreteFactoryA : Factory
    {
        public override IProduct createProduct()
        {
            IProduct productA = new ConcreteProductA();
            return productA;
        }
    }
}
