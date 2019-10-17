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
    public partial class Facturar : Form
    {
        private Conectar con;

        public Facturar()
        {
            InitializeComponent();

        }

        public Facturar(Conectar con)
        {
            this.con = con;
            InitializeComponent();
            cargarPlatos();
        }

        private void cargarPlatos()
        {
            con.listarPlatos(comboBox1);

        }

        private void Facturar_Load(object sender, EventArgs e)
        {

        }
    }
}
