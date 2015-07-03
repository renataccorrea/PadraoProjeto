using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace capitulo5_PrototypeAntes.Classes
{
    public class DVD : Item
    {
         //construtor
        public DVD ( int id , string descricao, double preco):base(id,descricao, preco)
        {

        }
        public override Item Clone()
        {
            return (Item)this.MemberwiseClone();
        }
    }
}
