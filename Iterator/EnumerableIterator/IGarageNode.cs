using System;
using System.Collections.Generic;
using System.Text;

namespace Iterator.EnumerableIterator
{
    public interface IGarageNode
    {
        bool HasChildren();

        int Count { get; }

        IEnumerable<IGarageNode> GetChildren();

        string ToString();
    }
}
