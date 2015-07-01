using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace capitulo03_Builder.Classes
{
    public class CarDirector : VehicleDirector
    {
        public override IVehicle Build(VehicleBuilder builder)
        {
            builder.BuildChassis();
            builder.BuildBody();
            builder.BuildPassengerArea();
            builder.BuildBoot();
            builder.BuildWindows();
            return builder.Vehicle;
        }
    }
}
