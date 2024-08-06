using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c-sharp-apps-hajyahia-yazan.Transportationapp
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