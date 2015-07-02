using capitulo4_FactoryMethodAntes.Classes;
using capitulo4_FactoryMethodDepois.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace capitulo4_FactoryMethodDepois
{
    class Program
    {
        static void Main(string[] args)
        {
            Creator[] creators = new Creator[2];
            creators[0] = new FacebookCreator();
            creators[1] = new GoogleCreator();
            foreach (Creator c in creators)
            {
                Autenticacao auto = c.CreateInstance();
                auto.Autenticar();                
            }
            Console.ReadLine();
        }
    }
}
