﻿namespace Comedor
{
    partial class Facturar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comedorDataSet = new Comedor.ComedorDataSet();
            this.listarBebidasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listarBebidasTableAdapter = new Comedor.ComedorDataSetTableAdapters.listarBebidasTableAdapter();
            this.comedorDataSet1 = new Comedor.ComedorDataSet1();
            this.listarExtrasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listarExtrasTableAdapter = new Comedor.ComedorDataSet1TableAdapters.listarExtrasTableAdapter();
            this.comedorDataSet2 = new Comedor.ComedorDataSet2();
            this.listarMesasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listarMesasTableAdapter = new Comedor.ComedorDataSet2TableAdapters.listarMesasTableAdapter();
            this.comedorDataSet3 = new Comedor.ComedorDataSet3();
            this.mostrarTasasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mostrarTasasTableAdapter = new Comedor.ComedorDataSet3TableAdapters.mostrarTasasTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comedorDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.platillo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bebida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.extras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mesa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.comedorDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listarBebidasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comedorDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listarExtrasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comedorDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listarMesasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comedorDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mostrarTasasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comedorDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(43, 87);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Platillo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(204, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Bebida";
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.listarBebidasBindingSource;
            this.comboBox2.DisplayMember = "Nombre";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(207, 86);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 3;
            this.comboBox2.ValueMember = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(353, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Extra";
            // 
            // comboBox3
            // 
            this.comboBox3.DataSource = this.listarExtrasBindingSource;
            this.comboBox3.DisplayMember = "nombre";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(356, 86);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 5;
            this.comboBox3.ValueMember = "nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(516, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Mesa";
            // 
            // comboBox4
            // 
            this.comboBox4.DataSource = this.listarMesasBindingSource;
            this.comboBox4.DisplayMember = "idMesa";
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(519, 87);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 21);
            this.comboBox4.TabIndex = 7;
            this.comboBox4.ValueMember = "idMesa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Total";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(46, 222);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 268);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Cambio";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(46, 297);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(174, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Efectivo";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(177, 221);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 13;
            // 
            // comboBox5
            // 
            this.comboBox5.DataSource = this.mostrarTasasBindingSource;
            this.comboBox5.DisplayMember = "tipo";
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(323, 221);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(121, 21);
            this.comboBox5.TabIndex = 14;
            this.comboBox5.ValueMember = "cambio";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(323, 191);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Moneda";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(191, 297);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 46);
            this.button1.TabIndex = 16;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(294, 295);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 48);
            this.button2.TabIndex = 17;
            this.button2.Text = "Facturar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comedorDataSet
            // 
            this.comedorDataSet.DataSetName = "ComedorDataSet";
            this.comedorDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // listarBebidasBindingSource
            // 
            this.listarBebidasBindingSource.DataMember = "listarBebidas";
            this.listarBebidasBindingSource.DataSource = this.comedorDataSet;
            // 
            // listarBebidasTableAdapter
            // 
            this.listarBebidasTableAdapter.ClearBeforeFill = true;
            // 
            // comedorDataSet1
            // 
            this.comedorDataSet1.DataSetName = "ComedorDataSet1";
            this.comedorDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // listarExtrasBindingSource
            // 
            this.listarExtrasBindingSource.DataMember = "listarExtras";
            this.listarExtrasBindingSource.DataSource = this.comedorDataSet1;
            // 
            // listarExtrasTableAdapter
            // 
            this.listarExtrasTableAdapter.ClearBeforeFill = true;
            // 
            // comedorDataSet2
            // 
            this.comedorDataSet2.DataSetName = "ComedorDataSet2";
            this.comedorDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // listarMesasBindingSource
            // 
            this.listarMesasBindingSource.DataMember = "listarMesas";
            this.listarMesasBindingSource.DataSource = this.comedorDataSet2;
            // 
            // listarMesasTableAdapter
            // 
            this.listarMesasTableAdapter.ClearBeforeFill = true;
            // 
            // comedorDataSet3
            // 
            this.comedorDataSet3.DataSetName = "ComedorDataSet3";
            this.comedorDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mostrarTasasBindingSource
            // 
            this.mostrarTasasBindingSource.DataMember = "mostrarTasas";
            this.mostrarTasasBindingSource.DataSource = this.comedorDataSet3;
            // 
            // mostrarTasasTableAdapter
            // 
            this.mostrarTasasTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.platillo,
            this.bebida,
            this.extras,
            this.mesa});
            this.dataGridView1.Location = new System.Drawing.Point(464, 191);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(434, 181);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // comedorDataSetBindingSource
            // 
            this.comedorDataSetBindingSource.DataSource = this.comedorDataSet;
            this.comedorDataSetBindingSource.Position = 0;
            // 
            // platillo
            // 
            this.platillo.HeaderText = "Platillo";
            this.platillo.Name = "platillo";
            // 
            // bebida
            // 
            this.bebida.HeaderText = "Bebida";
            this.bebida.Name = "bebida";
            // 
            // extras
            // 
            this.extras.HeaderText = "Extras";
            this.extras.Name = "extras";
            // 
            // mesa
            // 
            this.mesa.HeaderText = "Mesa";
            this.mesa.Name = "mesa";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(464, 390);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 48);
            this.button3.TabIndex = 19;
            this.button3.Text = "Quitar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Facturar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBox5);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Name = "Facturar";
            this.Text = "Facturar";
            this.Load += new System.EventHandler(this.Facturar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.comedorDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listarBebidasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comedorDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listarExtrasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comedorDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listarMesasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comedorDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mostrarTasasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comedorDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private ComedorDataSet comedorDataSet;
        private System.Windows.Forms.BindingSource listarBebidasBindingSource;
        private ComedorDataSetTableAdapters.listarBebidasTableAdapter listarBebidasTableAdapter;
        private ComedorDataSet1 comedorDataSet1;
        private System.Windows.Forms.BindingSource listarExtrasBindingSource;
        private ComedorDataSet1TableAdapters.listarExtrasTableAdapter listarExtrasTableAdapter;
        private ComedorDataSet2 comedorDataSet2;
        private System.Windows.Forms.BindingSource listarMesasBindingSource;
        private ComedorDataSet2TableAdapters.listarMesasTableAdapter listarMesasTableAdapter;
        private ComedorDataSet3 comedorDataSet3;
        private System.Windows.Forms.BindingSource mostrarTasasBindingSource;
        private ComedorDataSet3TableAdapters.mostrarTasasTableAdapter mostrarTasasTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource comedorDataSetBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn platillo;
        private System.Windows.Forms.DataGridViewTextBoxColumn bebida;
        private System.Windows.Forms.DataGridViewTextBoxColumn extras;
        private System.Windows.Forms.DataGridViewTextBoxColumn mesa;
        private System.Windows.Forms.Button button3;
    }
}