﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Singleton
    {
        public static Singleton _instance;

        protected Singleton()
        {

        }

        public static Singleton Instance()
        {
            if (_instance == null)
            {
                new Singleton();
            }

            return _instance;
        }
    }
}
