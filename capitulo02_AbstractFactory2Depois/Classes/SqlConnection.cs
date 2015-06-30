using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace capitulo02_AbstractFactory2Depois
{
    public class SqlConnection:DBConnection
    {
        public override void Open()
        {
            Console.WriteLine("Método Open de SqlConnection foi chamado");
 
        }
    }
}
