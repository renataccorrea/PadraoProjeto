﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace capitulo5_Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            VehicleManager manager = new VehicleManager();

            IVehicle saloon1 = manager.CreateSaloon();
            IVehicle saloon2 = manager.CreateSaloon();
            IVehicle pickup1 = manager.CreatePickup();

            Console.WriteLine(saloon1);
            Console.WriteLine(saloon2);
            Console.WriteLine(pickup1);

            Console.Read();
        }
    }
}
