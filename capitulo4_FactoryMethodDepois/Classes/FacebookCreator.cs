using capitulo4_FactoryMethodAntes.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace capitulo4_FactoryMethodDepois.Classes
{
    //Concrete Creator
    public class FacebookCreator: Creator
    {

        public override Autenticacao CreateInstance()
        {
            return new AutenticacaoFacebook();
        }
    }
}
