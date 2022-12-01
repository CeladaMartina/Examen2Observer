using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PropiedadesBE;

namespace Controller
{
    public class SubjectHotel : Cliente, ISubject
    {
        private List<IObserver> _observersVuelos = new List<IObserver>();

        // The subscription management methods.
        public void Attach(IObserver observer)
        {
            Console.WriteLine("Subject: Attached an observer.");
            this._observersVuelos.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            this._observersVuelos.Remove(observer);
            Console.WriteLine("Subject: Detached an observer.");
        }

        // Trigger an update in each subscriber.
        public void Notify()
        {
            MessageBox.Show("Notificancion enviada a los subscriptores! ");

            foreach (var observer in _observersVuelos)
            {
                //observer.Update(this);
            }
        }

        //public Form CrearClienteHotel(ConcreteObserverHotel cliente)
        //{
        //    MessageBox.Show("Nuevo hotel susbscripto");
        //    //return new Form().MdiParent = Form1;
        //    return new Form1(cliente);
        //}

        public List<ConcreteObserverVuelo> Notify(List<ConcreteObserverVuelo> lista)
        {
            throw new NotImplementedException();
        }
    }
}
