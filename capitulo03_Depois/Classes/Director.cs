using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace capitulo03_Depois.Classes
{
    public class Director
    {
        public void Construct(VeiculoBuilder builder)
        {
            builder.BuilderMotor();
            builder.BuilderPortas();
            builder.BuilderPneus();
        }
    }
}
