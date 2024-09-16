using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using c_sharp_apps_hajyahia_yazan.Banckapp;
using c_sharp_apps_hajyahia_yazan.Draftapp;
using c_sharp_apps_hajyahia_yazan.Sportapp;
using c_sharp_apps_hajyahia_yazan.transportation_app;

namespace c_sharp_apps_hajyahia_yazan.common.system.shared
{
    public class ProcessManger
    {
        public static void RunMainProcess()
        {
            int choise;

            Console.WriteLine("choose one option");
            Console.WriteLine("1-BanckApp");
            Console.WriteLine("2-SportApp");
            Console.WriteLine("3-DraftApp");
            Console.WriteLine("4-TransportationApp");
            Console.WriteLine("0-Exit");

            choise = int.Parse(Console.ReadLine());

            if (choise < 0 || choise > 4)
                Console.WriteLine("error");
            if (choise == 1)
                BanckAppMain.MainEntry();
            if (choise == 2)
               SportAppMain.MainEntry();
            if(choise == 3)
                DraftAppMain.MainEntry();
            if (choise == 4)
                TransportationAppMain.MainEntry();
            if (choise == 0)
                Console.WriteLine("exiting....");

        }
    }
}
