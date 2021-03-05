using System;
using System.Collections.Generic;
using System.Text;

namespace Iterator.CustomEnumerator
{
    public interface IIterableCollection<T>
    {
        IIterator<T> CreateIterator();
    }
}
