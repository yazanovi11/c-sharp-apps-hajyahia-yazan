using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_apps_hajyahia_yazan.transportation_app
{
    internal interface IPortTable
    {
        int GetArea();
        int[] GetSize();
        int GetVolume();
        int GetWeight();
        void PackageItem();
        bool IsPackaged();
        void UnPackage();
        bool IsFragile();
        StorageStructure GetLocation();
        bool IsLoaded();
    }
}