using Chapter02;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace capitulo02
{
    class Program
    {
        static void Main(string[] args)
        {
            string whatToMake = "car"; // or "van"

            AbstractVehicleFactory factory = null;

            // Create the correct 'factory'...
            if (whatToMake.Equals("car"))
            {
                factory = new CarFactory();
            }
            else
            {
                factory = new VanFactory();
            }

            // Create the vehicle's component parts...
            // These will either be all car parts or all van parts
            IBody vehicleBody = factory.CreateBody();
            IChassis vehicleChassis = factory.CreateChassis();
            IWindows vehicleWindows = factory.CreateWindows();

            // Show what we've created...
            Console.WriteLine(vehicleBody.BodyParts);
            Console.WriteLine(vehicleChassis.ChassisParts);
            Console.WriteLine(vehicleWindows.WindowParts);
            Console.Read();
        }
    }
}
