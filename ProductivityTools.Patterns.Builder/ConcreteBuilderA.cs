using System;
using System.Collections.Generic;
using System.Text;

namespace ProductivityTools.Patterns.Builder
{
    class ConcreteBuilderA : Builder
    {
        private Product _product = new Product();

        public override void BuildPartA()
        {
            _product.Add("PartA1");
        }

        public override void BuildPartB()
        {
            _product.Add("PartA2");
        }

        public override Product GetResult()
        {
            return _product;
        }
    }
}
