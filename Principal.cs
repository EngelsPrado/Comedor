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

        public Principal()
        {
            InitializeComponent();
        }

        public Principal(Conectar con)
        {
            this.con = con;
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }
    }
}
