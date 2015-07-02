using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace capitulo4_FactoryMethod.Classes
{
    public abstract class VehicleFactory
    {
        public enum DrivingStyle
        {
            Economical, Midrange, PowerFul
        }

        public virtual IVehicle Build( DrivingStyle style, VehicleColour colour)
        {
            IVehicle v = SelectVehicle(style);
            v.Paint(colour);
            return v;
        }
        // Esse é o factory method
        protected internal abstract IVehicle SelectVehicle(DrivingStyle style);
    }
}
