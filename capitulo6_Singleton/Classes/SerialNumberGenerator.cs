﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace capitulo6_Singleton.Classes
{
    public class SerialNumberGenerator
    {
        // static members
        private static volatile SerialNumberGenerator instance;
        private static object synchronizationRoot = new Object();

        public static SerialNumberGenerator Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (synchronizationRoot)
                    {
                        if (instance == null)
                        {
                            instance = new SerialNumberGenerator();
                        }
                    }
                }
                return instance;
            }
        }


        // instance variables
        private int count;

        // private constructor
        private SerialNumberGenerator()
        {
        }

        // instance methods
        public virtual int NextSerial
        {
            get
            {
                return ++count;
            }
        }

    }
}
