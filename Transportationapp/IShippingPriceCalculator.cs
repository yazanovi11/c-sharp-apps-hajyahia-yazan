using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c-sharp-apps-hajyahia-yazan.Transportationapp
{
    internal interface IShippingPriceCalculator
    {
        decimal CalculatePrice(IPortTable item, int travelDistance);
        decimal CalculatePrice(List<IPortTable> items, int travelDistance);
    }
}