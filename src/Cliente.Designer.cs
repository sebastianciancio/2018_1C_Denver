﻿namespace FrbaHotel
{
    partial class Cliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cliente));
            this.TBXname_client = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.LBLnombre = new System.Windows.Forms.Label();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.dgv_tablaCliente = new System.Windows.Forms.DataGridView();
            this.col_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_modif = new System.Windows.Forms.Button();
            this.lbl_apellido = new System.Windows.Forms.Label();
            this.lbl_dni = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btt_add_client = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.col_dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_dir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_cpt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tablaCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // TBXname_client
            // 
            this.TBXname_client.Location = new System.Drawing.Point(144, 39);
            this.TBXname_client.MaxLength = 100;
            this.TBXname_client.Name = "TBXname_client";
            this.TBXname_client.Size = new System.Drawing.Size(113, 20);
            this.TBXname_client.TabIndex = 0;
            this.TBXname_client.Tag = "";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(334, 39);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(143, 20);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // LBLnombre
            // 
            this.LBLnombre.AutoSize = true;
            this.LBLnombre.Location = new System.Drawing.Point(91, 42);
            this.LBLnombre.Name = "LBLnombre";
            this.LBLnombre.Size = new System.Drawing.Size(47, 13);
            this.LBLnombre.TabIndex = 2;
            this.LBLnombre.Text = "Nombre:";
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(667, 39);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(120, 25);
            this.btn_buscar.TabIndex = 3;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // dgv_tablaCliente
            // 
            this.dgv_tablaCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tablaCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_Nombre,
            this.col_apellido,
            this.col_dni,
            this.col_dir,
            this.Col_cpt});
            this.dgv_tablaCliente.Location = new System.Drawing.Point(91, 127);
            this.dgv_tablaCliente.Name = "dgv_tablaCliente";
            this.dgv_tablaCliente.Size = new System.Drawing.Size(544, 150);
            this.dgv_tablaCliente.TabIndex = 4;
            this.dgv_tablaCliente.Visible = false;
            this.dgv_tablaCliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // col_Nombre
            // 
            this.col_Nombre.HeaderText = "Nombre";
            this.col_Nombre.Name = "col_Nombre";
            this.col_Nombre.ReadOnly = true;
            // 
            // col_apellido
            // 
            this.col_apellido.HeaderText = "Apellido";
            this.col_apellido.Name = "col_apellido";
            this.col_apellido.ReadOnly = true;
            // 
            // btn_modif
            // 
            this.btn_modif.Location = new System.Drawing.Point(712, 127);
            this.btn_modif.Name = "btn_modif";
            this.btn_modif.Size = new System.Drawing.Size(88, 29);
            this.btn_modif.TabIndex = 5;
            this.btn_modif.Text = "Modificar";
            this.btn_modif.UseVisualStyleBackColor = true;
            this.btn_modif.Visible = false;
            this.btn_modif.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_apellido
            // 
            this.lbl_apellido.AutoSize = true;
            this.lbl_apellido.Location = new System.Drawing.Point(274, 42);
            this.lbl_apellido.Name = "lbl_apellido";
            this.lbl_apellido.Size = new System.Drawing.Size(44, 13);
            this.lbl_apellido.TabIndex = 6;
            this.lbl_apellido.Text = "Apellido";
            this.lbl_apellido.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_dni
            // 
            this.lbl_dni.AutoSize = true;
            this.lbl_dni.Location = new System.Drawing.Point(499, 42);
            this.lbl_dni.Name = "lbl_dni";
            this.lbl_dni.Size = new System.Drawing.Size(26, 13);
            this.lbl_dni.TabIndex = 7;
            this.lbl_dni.Text = "DNI";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(550, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(96, 20);
            this.textBox1.TabIndex = 8;
            // 
            // btt_add_client
            // 
            this.btt_add_client.Image = ((System.Drawing.Image)(resources.GetObject("btt_add_client.Image")));
            this.btt_add_client.Location = new System.Drawing.Point(1, 0);
            this.btt_add_client.Name = "btt_add_client";
            this.btt_add_client.Size = new System.Drawing.Size(82, 64);
            this.btt_add_client.TabIndex = 9;
            this.btt_add_client.Text = ".";
            this.btt_add_client.UseVisualStyleBackColor = true;
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(713, 191);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(86, 26);
            this.btn_eliminar.TabIndex = 10;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Visible = false;
            // 
            // col_dni
            // 
            this.col_dni.HeaderText = "DNI";
            this.col_dni.Name = "col_dni";
            this.col_dni.ReadOnly = true;
            // 
            // col_dir
            // 
            this.col_dir.HeaderText = "Dirección";
            this.col_dir.Name = "col_dir";
            this.col_dir.ReadOnly = true;
            // 
            // Col_cpt
            // 
            this.Col_cpt.HeaderText = "Cod. Postal";
            this.Col_cpt.Name = "Col_cpt";
            this.Col_cpt.ReadOnly = true;
            // 
            // Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 338);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btt_add_client);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbl_dni);
            this.Controls.Add(this.lbl_apellido);
            this.Controls.Add(this.btn_modif);
            this.Controls.Add(this.dgv_tablaCliente);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.LBLnombre);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.TBXname_client);
            this.Name = "Cliente";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.Cliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tablaCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBXname_client;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label LBLnombre;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.DataGridView dgv_tablaCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_apellido;
        private System.Windows.Forms.Button btn_modif;
        private System.Windows.Forms.Label lbl_apellido;
        private System.Windows.Forms.Label lbl_dni;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btt_add_client;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_dir;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_cpt;
        private System.Windows.Forms.Button btn_eliminar;
    }
}