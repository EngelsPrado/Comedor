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
            // TODO: esta línea de código carga datos en la tabla 'comedorDataSet3.mostrarTasas' Puede moverla o quitarla según sea necesario.
            this.mostrarTasasTableAdapter.Fill(this.comedorDataSet3.mostrarTasas);
            // TODO: esta línea de código carga datos en la tabla 'comedorDataSet2.listarMesas' Puede moverla o quitarla según sea necesario.
            this.listarMesasTableAdapter.Fill(this.comedorDataSet2.listarMesas);
            // TODO: esta línea de código carga datos en la tabla 'comedorDataSet1.listarExtras' Puede moverla o quitarla según sea necesario.
            this.listarExtrasTableAdapter.Fill(this.comedorDataSet1.listarExtras);
            // TODO: esta línea de código carga datos en la tabla 'comedorDataSet.listarBebidas' Puede moverla o quitarla según sea necesario.
            this.listarBebidasTableAdapter.Fill(this.comedorDataSet.listarBebidas);

        }

        private void button2_Click(object sender, EventArgs e)
        {

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                MessageBox.Show(row.Cells["platillo"].Value.ToString());
                MessageBox.Show(row.Cells["bebida"].Value.ToString());
                MessageBox.Show(row.Cells["extras"].Value.ToString());
                MessageBox.Show(row.Cells["mesa"].Value.ToString());




            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(comboBox1.Text, comboBox2.Text, comboBox3.Text, comboBox4.Text);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
        }
    }
}
