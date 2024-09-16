using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_apps_hajyahia_yazan.transportation_app
{
    internal interface IShippingPriceCalculator
    {
        decimal CalculatePrice(IPortTable item, int travelDistance);
        decimal CalculatePrice(List<IPortTable> items, int travelDistance);
    }
}