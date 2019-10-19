using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comedor
{
    public partial class UsuariosyNominas : Form
    {
        public UsuariosyNominas()
        {
            InitializeComponent();
        }

        private void UsuariosyNominas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'comedorDataSet14.MostrarUsuarios' Puede moverla o quitarla según sea necesario.
            this.mostrarUsuariosTableAdapter.Fill(this.comedorDataSet14.MostrarUsuarios);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
