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
    public partial class GestionarPRI : Form
    {
        public GestionarPRI()
        {
            InitializeComponent();
        }

        private void GestionarPRI_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'comedorDataSet13.listarBebidas' Puede moverla o quitarla según sea necesario.
            this.listarBebidasTableAdapter2.Fill(this.comedorDataSet13.listarBebidas);
            // TODO: esta línea de código carga datos en la tabla 'comedorDataSet12.listarExtras' Puede moverla o quitarla según sea necesario.
            this.listarExtrasTableAdapter1.Fill(this.comedorDataSet12.listarExtras);
            // TODO: esta línea de código carga datos en la tabla 'comedorDataSet10.listarExtras' Puede moverla o quitarla según sea necesario.
            this.listarExtrasTableAdapter.Fill(this.comedorDataSet10.listarExtras);
            // TODO: esta línea de código carga datos en la tabla 'comedorDataSet9.listarBebidas' Puede moverla o quitarla según sea necesario.
            this.listarBebidasTableAdapter1.Fill(this.comedorDataSet9.listarBebidas);
            // TODO: esta línea de código carga datos en la tabla 'comedorDataSet8.listarBebidas' Puede moverla o quitarla según sea necesario.
            this.listarBebidasTableAdapter.Fill(this.comedorDataSet8.listarBebidas);
            // TODO: esta línea de código carga datos en la tabla 'comedorDataSet4.mostrarPlatos' Puede moverla o quitarla según sea necesario.
            this.mostrarPlatosTableAdapter.Fill(this.comedorDataSet4.mostrarPlatos);

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
