using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace capitulo2_AbstractFactory2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Dependencia das classes concretas
            var con = new SqlConnection();
            con.Open();
            var cmd = new SqlCommand();
            cmd.Execute();
            Console.ReadLine();
        }
    }
}
