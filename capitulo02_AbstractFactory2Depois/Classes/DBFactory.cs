using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace capitulo02_AbstractFactory2Depois.Classes
{
    public abstract class DBFactory
    {
        public abstract DBConnection createConnection();
        public abstract DbComand createCommand();
    }
}
