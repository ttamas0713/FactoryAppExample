using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryAppExample
{
    abstract class Factory
    {
        public abstract IProduct createProduct();
    }
}
