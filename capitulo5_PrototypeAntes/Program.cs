using capitulo5_PrototypeAntes.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace capitulo5_PrototypeAntes
{
    class Program
    {
        static void Main(string[] args)
        {
            Livro p1 = new Livro(1, "Design Patt", 20);
            Livro c1 = (Livro)p1.Clone();
            Console.WriteLine("Clonado:" + c1.Descricao);

            DVD p2 = new DVD(1, "POOt", 20);
            DVD c2 = (DVD)p1.Clone();
            Console.WriteLine("Clonado:" + c2.Descricao);

        }
    }
}
