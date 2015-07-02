using capitulo4_FactoryMethodAntes.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace capitulo4_FactoryMethodDepois.Classes
{
    //Creator define o Factory Method abstract
    public abstract class Creator
    {
        public abstract Autenticacao CreateInstance();


    }
}
