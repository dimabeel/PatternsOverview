using System;
using System.Collections.Generic;
using System.Threading;

namespace Memento
{
    public interface IMemento
    {
        string GetState();
    }
}
