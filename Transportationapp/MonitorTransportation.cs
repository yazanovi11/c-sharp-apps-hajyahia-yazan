using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace c_sharp_apps_hajyahia_yazan.Transportationapp
{
    class MonitorTransportation
    {
        public static void Test1()
        {
            // بعض الاختبارات:
            // public PublicVehicle(int line, int id, int maxSpeed, int seats)
            PublicVehicle p1 = new PublicVehicle(18, 8099065, 50, 80);
            Buss bus = new Buss(1, 2033355, 110, 50, 3); // int line, int id, int maxSpeed, int seats, int doors
            // int line, int id, int enginesNum, int wingLength, int rows, int columns
            PassengersAirplain passengersAirplain1 = new PassengersAirplain(605, 987653, 4, 10, 60, 6);

            Crone crone1 = new Crone(20, 5);
            PassengersTrain passengersTrain1 = new PassengersTrain(65, 9998774, 250, 30, crone1, 5);
            bool allPassed = true;

            // اختبار السرعة القصوى
            if (p1.MaxSpeed != 0)
            {
                Console.WriteLine("Test 1 Error - Max Speed should be 0 but actual is {0}", p1.MaxSpeed);
                allPassed = false;
            }
            else
            {
                Console.WriteLine("Test 1 Passed ");
            }

            if (bus.MaxSpeed != 110)
            {
                Console.WriteLine("Test 2 Error - Max Speed should be 110 but actual is {0}", bus.MaxSpeed);
                allPassed = false;
            }
            else
            {
                Console.WriteLine("Test 2 Passed ");
            }
            bus.MaxSpeed = 200;

            if (bus.MaxSpeed != 110)
            {
                Console.WriteLine("Test 3 Error - Max Speed should be 110 but actual is {0}", bus.MaxSpeed);
                allPassed = false;
            }
            else
            {
                Console.WriteLine("Test 3 Passed ");
            }

            // اختبار تحميل بعض الركاب والتأكد من العدد الحالي للركاب
            passengersAirplain1.CurrentPassengers = 300;
            passengersAirplain1.UploadPassengers(100);

            if (passengersAirplain1.CurrentPassengers == 353 && passengersAirplain1.RejectedPassengers == 47)
            {
                Console.WriteLine("Test 4 Passed ");
            }
            else
            {
                Console.WriteLine("Test 4 Error - CurrentPassengers should be 353 but actual is {0} \n" +
                    "And rejected should be 47 but actual is {1} ", passengersAirplain1.CurrentPassengers,
                    passengersAirplain1.RejectedPassengers);
                allPassed = false;
            }

            bus.UploadPassengers(40);
            bus.UploadPassengers(20);

            if (bus.CurrentPassengers == 55 && bus.RejectedPassengers == 5)
            {
                Console.WriteLine("Test 5 Passed ");
            }
            else
            {
                Console.WriteLine("Test 5 Error - CurrentPassengers should be 55 but actual is {0} \n" +
                  "And rejected should be 5 but actual is {1} ", bus.CurrentPassengers,
                  bus.RejectedPassengers);
                allPassed = false;
            }

            if (passengersTrain1.Id == 9998774)
            {
                Console.WriteLine("Test 6 Passed ");
            }
            else
            {
                Console.WriteLine("Test 6 Error - id should be 9998774 but actual is {0} ", passengersTrain1.Id);
                allPassed = false;
            }

            passengersTrain1.UploadPassengers(300);
            passengersTrain1.UploadPassengers(134);

            if (passengersTrain1.CurrentPassengers == 434 && passengersTrain1.RejectedPassengers == 0)
            {
                Console.WriteLine("Test 7 Passed ");
            }
            else
            {
                Console.WriteLine("Test 7 Error - CurrentPassengers should be 434 but actual is {0} \n" +
                  "And rejected should be 0 but actual is {1} ", passengersTrain1.CurrentPassengers,
                  passengersTrain1.RejectedPassengers);
                allPassed = false;
            }

            passengersTrain1.UploadPassengers(405);

            if (passengersTrain1.CurrentPassengers == 700 && passengersTrain1.RejectedPassengers == 139
                && !passengersTrain1.HasRoom)
            {
                Console.WriteLine("Test 8 Passed ");
            }
            else
            {
                Console.WriteLine("Test 8 Error - CurrentPassengers should be 700 but actual is {0} \n" +
                  "And rejected should be 139 but actual is {1} and HasRoom should be False, but actual is {2}",
                  passengersTrain1.CurrentPassengers, passengersTrain1.RejectedPassengers, passengersTrain1.HasRoom);
                allPassed = false;
            }

            // التحقق من أن كل عربة في القطار هي كائن مختلف
            if (passengersTrain1.Crones[0].Equals(passengersTrain1.Crones[1]))
            {
                Console.WriteLine("Test 9 Error - each crone of the train should be different instance. ");
                allPassed = false;
            }
            else
            {
                Console.WriteLine("Test 9 Passed");
            }

            if (passengersTrain1.Crones[0].Equals(passengersTrain1.Crones[1]))
            {
                Console.WriteLine("Test 10 Error - each crone of the train should be different instance. ");
                allPassed = false;
            }
            else
            {
                Console.WriteLine("Test 10 Passed");
            }

            Console.WriteLine("\n*********************************\n");

            if (allPassed)
            {
                Console.WriteLine("All TEST PASSED - WELL DONE!! \n" +
                    "Yet it's not saying that everything work well. You should test yourself a little bit, also.");
            }
            else
            {
                Console.WriteLine("YOU HAVE FAILURES AT THE TESTS :( - SEE ABOVE");
            }
            Console.WriteLine("\n*********************************\n");
            Console.WriteLine("Self Tasts");
            Console.WriteLine("\n*********************************\n");
            Console.WriteLine("Check ToString() Methods\n");
            Console.WriteLine(bus);
            Console.WriteLine(passengersAirplain1);
            Console.WriteLine(passengersTrain1);
            Console.WriteLine("\n*********************************\n");
            Console.WriteLine("Check Get Off the vehicle");

            bool passNewCheck = true;
            bus.UploadPassengers(-60);
            bus.UploadPassengers(20);
            if (bus.CurrentPassengers == 20 && bus.HasRoom)
            {
                Console.WriteLine("Test 11 Passed ");
            }
            else
            {
                Console.WriteLine("Test 11 Error - CurrentPassengers should be 20 but actual is {0} \n" +
                  "And HasRoom should be true but actual is {1} ", bus.CurrentPassengers, bus.HasRoom);
                passNewCheck = false;
            }

            passengersAirplain1.UploadPassengers(-400);
            if (passengersAirplain1.CurrentPassengers == 0 && passengersAirplain1.HasRoom)
            {
                Console.WriteLine("Test 12 Passed ");
            }
            else
            {
                Console.WriteLine("Test 12 Error - CurrentPassengers should be 0 but actual is {0} \n" +
                  "And HasRoom should be true but actual is {1} ", passengersAirplain1.CurrentPassengers,
                  passengersAirplain1.HasRoom);
                passNewCheck = false;
            }

            passengersTrain1.UploadPassengers(-250);
            if (passengersTrain1.CurrentPassengers == 450 && passengersTrain1.HasRoom)
            {
                Console.WriteLine("Test 13 Passed ");
            }
            else
            {
                Console.WriteLine("Test 13 Error - CurrentPassengers should be 450 but actual is {0} \n" +
                  "And HasRoom should be true but actual is {1} ", passengersTrain1.CurrentPassengers,
                  passengersTrain1.HasRoom);
                passNewCheck = false;
            }

            Console.WriteLine("\n*********************************");
            if (passNewCheck)
            {
                Console.WriteLine("All NEW TESTS PASSED!!");
            }
            else
            {
                Console.WriteLine("YOU HAVE FAILURES AT THE TESTS :( - SEE ABOVE");
            }
            Console.WriteLine("*********************************\n");

            // اختبارات جديدة لفئة TrainCargo
            TrainCargo trainCargo = new TrainCargo { MaxVolume = 5000, MaxWeight = 10000 };
            IPortTable cargoItem1 = new CargoItem { Volume = 100, Weight = 200 };
            IPortTable cargoItem2 = new CargoItem { Volume = 200, Weight = 300 };

            // تحميل العنصر الأول
            if (trainCargo.Load(cargoItem1) && trainCargo.CargoItems.Contains(cargoItem1))
            {
                Console.WriteLine("Test 14 Passed - Item 1 loaded successfully.");
            }
            else
            {
                Console.WriteLine("Test 14 Failed - Item 1 not loaded.");
                passNewCheck = false;
            }

            // تحميل العنصر الثاني
            if (trainCargo.Load(cargoItem2) && trainCargo.CargoItems.Contains(cargoItem2))
            {
                Console.WriteLine("Test 15 Passed - Item 2 loaded successfully.");
            }
            else
            {
                Console.WriteLine("Test 15 Failed - Item 2 not loaded.");
                passNewCheck = false;
            }

            // اختبار سعة الحمولة
            if (trainCargo.GetCurrentVolume() == 300 && trainCargo.GetCurrentWeight() == 500)
            {
                Console.WriteLine("Test 16 Passed - Correct cargo volume and weight.");
            }
            else
            {
                Console.WriteLine("Test 16 Failed - Incorrect cargo volume or weight.");
                passNewCheck = false;
            }

            // تفريغ العنصر الأول
            if (trainCargo.Unload(cargoItem1) && !trainCargo.CargoItems.Contains(cargoItem1))
            {
                Console.WriteLine("Test 17 Passed - Item 1 unloaded successfully.");
            }
            else
            {
                Console.WriteLine("Test 17 Failed - Item 1 not unloaded.");
                passNewCheck = false;
            }

            Console.WriteLine("\n*********************************");
            if (passNewCheck)
            {
                Console.WriteLine("All NEW TESTS PASSED!!");
            }
            else
            {
                Console.WriteLine("YOU HAVE FAILURES AT THE TESTS :( - SEE ABOVE");
            }
            Console.WriteLine("*********************************\n");
        }
    }


    class CargoItem : IPortTable
    {
        public int Volume { get; set; }
        public int Weight { get; set; }

        public int GetArea() => throw new NotImplementedException();
        public int[] GetSize() => throw new NotImplementedException();
        public int GetVolume() => Volume;
        public int GetWeight() => Weight;
        public void PackageItem() => throw new NotImplementedException();
        public bool IsPackaged() => throw new NotImplementedException();
        public void UnPackage() => throw new NotImplementedException();
        public bool IsFragile() => throw new NotImplementedException();
        public StorageStructure GetLocation() => throw new NotImplementedException();
        public bool IsLoaded() => throw new NotImplementedException();
    }
}