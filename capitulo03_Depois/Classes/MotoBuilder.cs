using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace capitulo03_Depois.Classes
{
    public class MotoBuilder:VeiculoBuilder
    {
        public MotoBuilder()
        {
            _veiculo = new Veiculo("Carro de passeio");

        }
        public override void BuilderMotor()
        {
            _veiculo["motor"] = "50c";
        }
        public override void BuilderPortas()
        {
            _veiculo["porta"] = "0";
        }
        public override void BuilderPneus()
        {
            _veiculo["pneus"] = "2";
        }
    }
}
