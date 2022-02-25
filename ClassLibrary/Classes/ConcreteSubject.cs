﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary.Interfaces;

namespace ClassLibrary.Classes
{
    public class ConcreteSubject : ISubject
    {
        List<IObserver> observers = new List<IObserver> { };
        public void NotifyObserver()
        {
            foreach (var observer in observers)
                observer.Update();
        }

        public void RegisterObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        int state;
        public int State
        {
            get { return state; }
            set { state = value; this.NotifyObserver(); }
        }
    }
}
