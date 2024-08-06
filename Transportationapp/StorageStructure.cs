using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c-sharp-apps-hajyahia-yazan.Transportationapp
{
    internal abstract class StorageStructure : IContainable
    {
        public string Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public int Number { get; set; }
        public int MaxWeight { get; set; }
        public int MaxVolume { get; set; }
        public List<IPortTable> StoredItems { get; set; } = new List<IPortTable>();

        public abstract bool Load(IPortTable item);
        public abstract bool Load(List<IPortTable> items);
        public abstract bool Unload(IPortTable item);
        public abstract bool Unload(List<IPortTable> items);
        public abstract bool IsHaveRoom();
        public abstract bool IsOverload();
        public abstract int GetMaxVolume();
        public abstract int GetMaxWeight();
        public abstract int GetCurrentVolume();
        public abstract int GetCurrentWeight();

        public abstract string GetPricingList();
    }
}