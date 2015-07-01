using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace capitulo03_Depois.Classes
{
    public class CarroBuilder :VeiculoBuilder
    {
        public CarroBuilder()
        {
            _veiculo = new Veiculo("Carro de passeio");

        }
        public override void BuilderMotor()
        {
            _veiculo["motor"] = "127c";
        }
        public override void BuilderPortas()
        {
            _veiculo["porta"] = "4";
        }
        public override void BuilderPneus()
        {
            _veiculo["pneus"] = "4";
        }
    }
}
