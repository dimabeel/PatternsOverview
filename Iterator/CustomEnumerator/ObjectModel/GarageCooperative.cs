using System;
using System.Collections.Generic;
using System.Text;

namespace Iterator.CustomEnumerator
{
    public interface IGarageCooperative : IIterableCollection<IGarage>
    {
    }

    public class GarageCooperative : IGarageCooperative
    {
        public GarageCooperative(IGarage[] garages)
        {
            this.garages = garages;
        }

        public IIterator<IGarage> CreateIterator()
        {
            return new ObjectIterator<IGarage>(garages);
        }

        IGarage[] garages;
    }
}
