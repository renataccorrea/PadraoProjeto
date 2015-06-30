using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace capitulo02_AbstractFactory2Depois.Classes
{
    public class SqlFactory:DBFactory
    {
        public override DBConnection createConnection()
        {
            return new SqlConnection();
        }
        public override DbComand createCommand()
        {
            return new SqlCommand();
        }

    }
}
