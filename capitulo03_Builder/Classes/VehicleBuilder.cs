using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace capitulo03_Builder.Classes
{
    public abstract class VehicleBuilder
    {
        public virtual void BuildBody() { }
        public virtual void BuildBoot() { }
        public virtual void BuildChassis() { }
        public virtual void BuildPassengerArea() { }
        public virtual void BuildReinforcedStorageArea() { }
        public virtual void BuildWindows() { }

        // public abstract IVehicle Vehicle {get;}
    }
}
