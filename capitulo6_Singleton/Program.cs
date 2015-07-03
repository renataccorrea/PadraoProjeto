using capitulo6_Singleton.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace capitulo6_Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            SerialNumberGenerator generator = SerialNumberGenerator.Instance;

            Console.WriteLine("next serial: " +
                                        SerialNumberGenerator.Instance.NextSerial);
            Console.WriteLine("next serial: " +
                                        SerialNumberGenerator.Instance.NextSerial);
            Console.WriteLine("next serial: " +
                                        SerialNumberGenerator.Instance.NextSerial);

            Console.Read();
        }
    }
}
