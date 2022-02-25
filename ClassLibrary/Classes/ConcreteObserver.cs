﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary.Interfaces;

namespace ClassLibrary.Classes
{
    public class ConcreteObserver : IObserver
    {

        int counter = 0;
        public int Counter
        {
            get
            {
                return counter;
            }
        }
        public void Update()
        {
            counter++;
        }
    }
}
