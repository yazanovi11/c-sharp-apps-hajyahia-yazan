﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using c_sharp_apps_hajyahia_yazan.common.system.shared;
using c_sharp_apps_hajyahia_yazan.TransportationApp;

namespace c_sharp_apps_hajyahia_yazan
{
    internal class Program
    {

        static void Main(string[] args)
        {
            ProcessManeger.RunMainProcess();
            RunTests();
        }

        static void RunTests()
        {
            MonitorTransportation.Test1();
        }
    }
}

