using System;
using System.Collections.Generic;

namespace Composite
{
    public interface IComponent
    {
        void Execute();

        void Add(IComponent component);

        void Remove(IComponent component);

        bool IsComposite { get; }
    }
}
