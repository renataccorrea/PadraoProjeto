using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace capitulo2_AbstractFactory2
{
    public class SqlCommand:DbComand
    {
        public override void Execute()
        {
            Console.WriteLine("Execute de SqlCommand foi chamado");
        }
    }
}
