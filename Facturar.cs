﻿using System;
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
        private String usuario;
        public Facturar()
        {
            InitializeComponent();

        }

        public Facturar(Conectar con,String usuario)
        {
            this.con = con;
            this.usuario = usuario;
            InitializeComponent();
      
        }


        private void Facturar_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'comedorDataSet3.listarExtras' Puede moverla o quitarla según sea necesario.
            this.listarExtrasTableAdapter.Fill(this.comedorDataSet3.listarExtras);
            // TODO: esta línea de código carga datos en la tabla 'comedorDataSet2.listarBebidas' Puede moverla o quitarla según sea necesario.
            this.listarBebidasTableAdapter.Fill(this.comedorDataSet2.listarBebidas);
            // TODO: esta línea de código carga datos en la tabla 'comedorDataSet1.verPlatos' Puede moverla o quitarla según sea necesario.
            this.verPlatosTableAdapter.Fill(this.comedorDataSet1.verPlatos);

            // TODO: esta línea de código carga datos en la tabla 'comedorDataSet11.mostrarTasas' Puede moverla o quitarla según sea necesario.
            this.mostrarTasasTableAdapter3.Fill(this.comedorDataSet11.mostrarTasas);
          
            this.listarMesasTableAdapter1.Fill(this.comedorDataSet7.listarMesas);
            // TODO: esta línea de código carga datos en la tabla 'comedorDataSet6.listarExtras' Puede moverla o quitarla según sea necesario.
            this.listarExtrasTableAdapter1.Fill(this.comedorDataSet6.listarExtras);
            // TODO: esta línea de código carga datos en la tabla 'comedorDataSet5.listarBebidas' Puede moverla o quitarla según sea necesario.
            this.listarBebidasTableAdapter1.Fill(this.comedorDataSet5.listarBebidas);
       

        }

        private void button2_Click(object sender, EventArgs e)
        {

            con.facturar(usuario);//Creamos la factura
            int counter = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {

               
                    Console.WriteLine("ENTRaaa");
                if(dataGridView1.Rows[counter++].Cells["platillo"].Value
            != null)
                {
                    con.detalleFactura(row.Cells["platillo"].Value.ToString(), Int32.Parse(row.Cells["mesa"].Value.ToString()), 2);

                }





            }

            int counter1 = 0;
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {


                Console.WriteLine("ENTRaaa");
                if (dataGridView2.Rows[counter1++].Cells["Bebida"].Value
            != null)
                {
                      con.detalleBebidas_Extras(row.Cells["Bebida"].Value.ToString(),2, row.Cells["Extra"].Value.ToString(),2);
                       
                }





            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(comboBox1.Text,comboBox4.Text);
            dataGridView2.Rows.Add(comboBox2.Text, comboBox3.Text);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
        }
    }
}
