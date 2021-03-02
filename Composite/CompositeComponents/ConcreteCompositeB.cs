using System;

namespace Composite.Components
{
    public class ConcreteCompositeB : CompositeComponent
    {
        public override void Execute()
        {
            Console.WriteLine("Using concrete composite component B");

            if (IsComposite)
            {
                foreach (var compositeComponent in components)
                {
                    compositeComponent.Execute();
                }
            }
        }
    }
}
