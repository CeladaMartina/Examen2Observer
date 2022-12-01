using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controller;
using PropiedadesBE;

namespace Examen2Observer
{
    public partial class FormVuelos : Form
    {
        public static string nombre;
        public FormVuelos(ConcreteObserverVuelo cliente)
        {
            InitializeComponent();
            listBoxUsuariosVuelos.Text = cliente.Nombre;
        }

        private void FormVuelos_Load(object sender, EventArgs e)
        {

        }


    }
}
