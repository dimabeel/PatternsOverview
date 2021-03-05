using System;
using System.Collections.Generic;
using System.Text;

namespace Iterator.EnumerableIterator
{
    public interface IGarageCooperative
    {
        IGarage[] Garages { get; }

        IEnumerable<IGarageNode> GetItems(IGarageNode mainNode);
    }

    public class GarageCooperative : IGarageCooperative, IGarageNode
    {
        public GarageCooperative(IGarage[] garages)
        {
            this.garages = garages;
        }

        public override string ToString()
        {
            return "This is a garage cooperative";
        }

        public IGarage[] Garages
        {
            get
            {
                return garages;
            }
        }

        public bool HasChildren()
        {
            return garages.Length > 0;
        }

        public IEnumerable<IGarageNode> GetChildren()
        {
            for(int gNum = 0; gNum < garages.Length; gNum++)
            {
                yield return garages[gNum] as IGarageNode;
            }
        }

        public int Count
        {
            get
            {
                return garages.Length;
            }
        }

        public IEnumerable<IGarageNode> GetItems(IGarageNode node)
        {
            var nodeList = new List<IGarageNode>();
            nodeList.Add(node);

            if(node.HasChildren())
            {
                foreach(var item in node.GetChildren())
                {
                    nodeList.AddRange(GetItems(item));
                }
            }

            return nodeList;
        }

        IGarage[] garages;
    }
}
