using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c-sharp-apps-hajyahia-yazan.Transportationapp
{
    internal interface IContainable
    {
        bool Load(IPortTable item);
        bool Load(List<IPortTable> items);
        bool Unload(IPortTable item);
        bool Unload(List<IPortTable> items);
        bool IsHaveRoom();
        bool IsOverload();
        int GetMaxVolume();
        int GetMaxWeight();
        int GetCurrentVolume();
        int GetCurrentWeight();
        string GetPricingList();
    }
}
