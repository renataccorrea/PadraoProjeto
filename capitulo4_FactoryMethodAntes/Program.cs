using capitulo4_FactoryMethodAntes.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace capitulo4_FactoryMethodAntes
{
    class Program
    {
        static void Main(string[] args)
        {
            var login = new AutenticacaoGoogle();
            login.Autenticar();
            Console.ReadLine();
        }
    }
}
