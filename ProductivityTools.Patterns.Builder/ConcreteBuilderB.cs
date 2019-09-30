using System;
using System.Collections.Generic;
using System.Text;

namespace ProductivityTools.Patterns.Builder
{
    class ConcreteBuilderB : Builder
    {
        private Product _product = new Product();

        public override void BuildPartA()
        {
            _product.Add("PartB1");
        }

        public override void BuildPartB()
        {
            _product.Add("PartB2");
        }

        public override Product GetResult()
        {
            return _product;
        }
    }
}
