using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PropiedadesBE;
using Controller;

namespace Examen2Observer
{
    public partial class Form1 : Form
    {
        List<Cliente> clientes = new List<Cliente>();
        List<ConcreteObserverVuelo> ListaFormulariosVuelos = new List<ConcreteObserverVuelo>();
        List<Form> ListaFormulariosHoteles = new List<Form>();

        SubjectVuelo subjectA = new SubjectVuelo();
        ConcreteObserverVuelo observerA = new ConcreteObserverVuelo();

        int precioVuelo = 100;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ClienteGenerador gen = new ClienteGenerador();
            clientes = gen.clientesGen();

            listUsuarios.DataSource = null;
            listUsuarios.DataSource = clientes;
            listUsuarios.DisplayMember = "Nombre";
        }

        private void btnSuscribir_Click(object sender, EventArgs e)
        {
            //Subscribir Vuelos            
            observerA.Nombre = ((Cliente)listUsuarios.SelectedItem).Nombre;

            subjectA.Attach(observerA);

            ListaFormulariosVuelos.Add(observerA);

            listNotificaciones.Items.Add(ListaFormulariosVuelos);
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (subjectA._observersVuelos.Count > 0)
            {
                subjectA.Notify(ListaFormulariosVuelos);
            }
        }

        private void btnDesuscribir_Click(object sender, EventArgs e)
        {
            //Desuscribir Vuelo
            observerA.Nombre = ((Cliente)listUsuarios.SelectedItem).Nombre;

            List<Form> forms = new List<Form>();            

            subjectA.Detach(observerA);

        }
    }
}
