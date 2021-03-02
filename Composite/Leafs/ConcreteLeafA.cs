using System;

namespace Composite.Leafs
{
    public class ConcreteLeafA : LeafComponent
    {
        public override void Execute()
        {
            Console.WriteLine("It is a component leaf A!");
        }
    }
}
