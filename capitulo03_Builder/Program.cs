﻿using capitulo03_Builder.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace capitulo03_Builder
{
    class Program
    {
        static void Main(string[] args)
        {
           // AbstractCar car = new Saloon(new StandardEngine(1300));
            VehicleBuilder builder = new CarBuilder(car);
            VehicleDirector director = new CarDirector();
            IVehicle v = director.Build(builder);
            Console.WriteLine(v);
            Console.Read();
            
        }
    }
}
