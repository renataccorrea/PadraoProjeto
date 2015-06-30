using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace capitulo02_AbstractFactory2Depois
{
    //produto concreto
    public class SqlCommand:DbComand
    {
        public override void Execute()
        {
            Console.WriteLine("Execute de SqlCommand foi chamado");
        }
    }
}
