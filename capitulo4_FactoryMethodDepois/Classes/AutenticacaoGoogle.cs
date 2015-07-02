using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace capitulo4_FactoryMethodAntes.Classes
{
    //produto Concreto
    public class AutenticacaoGoogle: Autenticacao
    {
        public override void Autenticar()
        {
            Console.WriteLine("Autenticado Google");
        }
    }
}
