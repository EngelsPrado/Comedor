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
    public partial class Principal : Form
    {
        private Conectar con;
        private String usuario;
        public Principal()
        {
            InitializeComponent();
        }

        public Principal(Conectar con,String usuario)
        {
            this.con = con;
            this.usuario = usuario;
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void facturarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Facturar f = new Facturar(con , usuario);
            f.MdiParent = this;
            f.Show();
       

        }

        private void platosIngredientesRefrescosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionarPRI p = new GestionarPRI();
            p.MdiParent = this;
            p.Show();


        }

        private void usuariosYNominasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UsuariosyNominas un = new UsuariosyNominas();
            un.MdiParent = this;
            un.Show();
        }
    }
}
