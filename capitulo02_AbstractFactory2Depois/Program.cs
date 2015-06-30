using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using capitulo02_AbstractFactory2Depois.Classes;

namespace capitulo02_AbstractFactory2Depois
{
    class Program
    {
        static void Main(string[] args)
        {
            DBFactory db = new SqlFactory();
            var con = db.createConnection();
            con.Open();
            var cmd = db.createCommand();
            cmd.Execute();
            Console.ReadLine();
        }
    }
}
