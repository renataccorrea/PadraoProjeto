using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace capitulo5_PrototypeAntes.Classes
{
    // Prototype
    public abstract class Item
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public double Preco { get; set; }
        public Item(int id, string descricao, double preco)
        {
            Id = Id;
            Descricao = descricao;
            Preco = preco;

        }
        // CLONAR
        public abstract Item Clone();
    }
}
