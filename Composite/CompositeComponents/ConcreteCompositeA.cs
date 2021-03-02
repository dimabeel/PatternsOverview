using System;

namespace Composite.Components
{
    public class ConcreteCompositeA : CompositeComponent
    {
        public override void Execute()
        {
            Console.WriteLine("Using concrete composite component A");

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
