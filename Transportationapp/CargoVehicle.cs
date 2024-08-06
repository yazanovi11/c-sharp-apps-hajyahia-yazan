using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c-sharp-apps-hajyahia-yazan.Transportationapp
{
    internal abstract class CargoVehicle : IContainable // تحويلها إلى abstract class
    {
        public Driver Driver { get; set; }
        public int MaxWeight { get; set; }
        public int MaxVolume { get; set; }
        public bool CanTravel { get; set; }
        public bool IsOverloaded { get; set; }
        public StorageStructure NextPort { get; set; }
        public StorageStructure CurrentPort { get; set; }
        public int TravelID { get; set; }
        public List<IPortTable> CargoItems { get; set; } = new List<IPortTable>();
        public int ExpectedPayment { get; set; }
        public IShippingPriceCalculator PriceCalculator { get; set; }
        public int DistanceToNextPort { get; set; }

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