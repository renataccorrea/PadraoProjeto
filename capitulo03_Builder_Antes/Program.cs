using capitulo03_Builder_Antes.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace capitulo03_Builder_Antes
{
    class Program
    {
        static void Main(string[] args)
        {
            var carro = new Veiculo("Carro de passeio");
            carro["motor"] = "127c";
            carro["porta"] = "4";
            carro["pneus"] = "4";
            carro.Mostrar();

            var moto = new Veiculo("Moto");
            moto["motor"] = "50c";
            moto["porta"] = "0";
            moto["pneus"] = "2";
            moto.Mostrar();

            Console.ReadLine();
        }
    }
}
