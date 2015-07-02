using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace capitulo4_FactoryMethodAntes.Classes
{
    public class AutenticacaoFacebook: Autenticacao
    {
        public override void Autenticar()
        {
            Console.WriteLine("Autenticado Facebook");
        }
    }
}
