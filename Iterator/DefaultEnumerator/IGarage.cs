using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Iterator.DefaultEnumerator
{
    public interface IGarage
    {
        ICar[] Cars { get; }

        IEnumerator GetEnumerator();
    }
}
