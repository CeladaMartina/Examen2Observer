﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PropiedadesBE;

namespace Controller
{
    public class ConcreteObserverHotel : Cliente, IObserver
    {
        public void Update(ISubject subject)
        {
            //if ((subject as SubjectVuelo).State == 0 || (subject as SubjectVuelo).State >= 2)
            //{
            //    Console.WriteLine("ConcreteObserverB: Reacted to the event.");
            //}
        }

        public float Update(Vuelo vuelo)
        {
            throw new NotImplementedException();
        }

        public float Update(Hotel hotel)
        {
            throw new NotImplementedException();
        }
    }
}
