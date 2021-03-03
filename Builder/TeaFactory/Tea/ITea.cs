using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.TeaFactory.Tea
{
    public interface ITea
    {
        string DescribeTea();

        Herb Herb { get; set; }

        Sugar Sugar { get; set; }

        Lemon Lemon { get; set; }
    }
}
