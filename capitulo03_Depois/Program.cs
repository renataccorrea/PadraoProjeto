﻿using capitulo03_Depois.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace capitulo03_Depois
{
    class Program
    {
        static void Main(string[] args)
        {
            VeiculoBuilder builder;
            var director = new Director();
            builder = new CarroBuilder();
            director.Construct(builder);
            builder.Veiculo.Mostrar();

            builder = new MotoBuilder();
            director.Construct(builder);
            builder.Veiculo.Mostrar();

            Console.ReadLine();
        }
    }
}
