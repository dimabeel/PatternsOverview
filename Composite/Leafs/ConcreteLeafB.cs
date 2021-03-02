using System;

namespace Composite.Leafs
{
    public class ConcreteLeafB : LeafComponent
    {
        public override void Execute()
        {
            Console.WriteLine("It is a component leaf B!");
        }
    }
}
