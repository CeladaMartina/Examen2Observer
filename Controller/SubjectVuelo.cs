using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PropiedadesBE;

namespace Controller
{
    public class SubjectVuelo : Cliente, ISubject
    {
        public List<IObserver> _observersVuelos = new List<IObserver>();
        Vuelo vuelo = new Vuelo();

        public void Attach(IObserver observer)
        {
            //Console.WriteLine("Subject: Attached an observer.");
            this._observersVuelos.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            this._observersVuelos.Remove(observer);
            Console.WriteLine("Subject: Detached an observer.");
        }
        public List<ConcreteObserverVuelo> Notify(List<ConcreteObserverVuelo> lista)
        {
            MessageBox.Show("Notificacion enviada a los subscriptores! ");

            List<ConcreteObserverVuelo> listVuelos = new List<ConcreteObserverVuelo>();            
            List<Form> forms = new List<Form>();

            foreach (Form frm in Application.OpenForms)
            {
                forms.Add(frm);
            }                     

            foreach (var form in lista)
            {
                form.Nombre = "Cambio el precio del vuelo.";

                foreach (Form f in forms)
                {
                    if (f.Name.Contains("Form1"))
                    {                        
                        string mensaje = "Cambio el precio del vuelo.";
                        ListBox list = (ListBox)f.Controls["listNotificaciones"];                       
                        list.Items.Add(mensaje);                       
                    }
                }
            }
            return listVuelos;
        }

        //public Form CrearClienteVuelo(ConcreteObserverVuelo cliente)
        //{
        //    MessageBox.Show("Nuevo vuelo subscripto");
        //    return new Examen2Observer.FormVuelos(cliente);
        //}

        public void Notify()
        {
            throw new NotImplementedException();
        }
    }
}
