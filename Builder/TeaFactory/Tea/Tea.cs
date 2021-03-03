using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.TeaFactory.Tea
{
    public class Tea : ITea
    {
        public string DescribeTea()
        {
            string teaMsg = $"Our tea is:\n";

            if (Herb != null)
            {
                teaMsg += "Tea has herb.\n";
            }

            if (Sugar != null)
            {
                teaMsg += "Tea has sugar.\n";
            }

            if (Lemon != null)
            {
                teaMsg += "Tea has lemon.\n";
            }

            return teaMsg;
        }

        public Herb Herb { get; set; }

        public Sugar Sugar { get; set; }

        public Lemon Lemon { get; set; }
    }
}
