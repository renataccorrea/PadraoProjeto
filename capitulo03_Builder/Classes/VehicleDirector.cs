﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace capitulo03_Builder.Classes
{
    public abstract class VehicleDirector
    {
        public abstract IVehicle Build(VehicleBuilder builder);
    }
}
