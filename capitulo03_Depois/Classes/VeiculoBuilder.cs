using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace capitulo03_Depois.Classes
{
    public abstract class VeiculoBuilder
    {
        protected Veiculo _veiculo;
        public Veiculo Veiculo
        {
            get { return _veiculo; }

        }

        //rpocesso de contrução do veiculo (abstrato)
        public abstract void BuilderMotor();
        public abstract void BuilderPortas();
        public abstract void BuilderPneus();
        
    }
}
