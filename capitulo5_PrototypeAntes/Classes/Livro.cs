using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace capitulo5_PrototypeAntes.Classes
{
    //concrete prototype
    public class Livro : Item
    {
        //construtor
        public Livro ( int id , string descricao, double preco):base(id,descricao, preco)
        {

        }
        public override Item Clone()
        {
            return (Item)this.MemberwiseClone();
        }

    }
}
