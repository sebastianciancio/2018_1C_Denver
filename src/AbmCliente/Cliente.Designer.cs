namespace FrbaHotel
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
            this.txb_cliente_nombre = new System.Windows.Forms.TextBox();
            this.txb_cliente_apellido = new System.Windows.Forms.TextBox();
            this.LBLnombre = new System.Windows.Forms.Label();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.dgv_tablaCliente = new System.Windows.Forms.DataGridView();
            this.btn_modif = new System.Windows.Forms.Button();
            this.lbl_apellido = new System.Windows.Forms.Label();
            this.lbl_dni = new System.Windows.Forms.Label();
            this.txb_cliente_dni = new System.Windows.Forms.TextBox();
            this.btt_add_client = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tablaCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // txb_cliente_nombre
            // 
            this.txb_cliente_nombre.Location = new System.Drawing.Point(144, 39);
            this.txb_cliente_nombre.MaxLength = 100;
            this.txb_cliente_nombre.Name = "txb_cliente_nombre";
            this.txb_cliente_nombre.Size = new System.Drawing.Size(113, 20);
            this.txb_cliente_nombre.TabIndex = 0;
            this.txb_cliente_nombre.Tag = "";
            // 
            // txb_cliente_apellido
            // 
            this.txb_cliente_apellido.Location = new System.Drawing.Point(334, 39);
            this.txb_cliente_apellido.Name = "txb_cliente_apellido";
            this.txb_cliente_apellido.Size = new System.Drawing.Size(143, 20);
            this.txb_cliente_apellido.TabIndex = 1;
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
            this.dgv_tablaCliente.Location = new System.Drawing.Point(91, 127);
            this.dgv_tablaCliente.Name = "dgv_tablaCliente";
            this.dgv_tablaCliente.ReadOnly = true;
            this.dgv_tablaCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_tablaCliente.Size = new System.Drawing.Size(544, 150);
            this.dgv_tablaCliente.TabIndex = 4;
            this.dgv_tablaCliente.Visible = false;
            
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
            // txb_cliente_dni
            // 
            this.txb_cliente_dni.Location = new System.Drawing.Point(550, 39);
            this.txb_cliente_dni.Name = "txb_cliente_dni";
            this.txb_cliente_dni.Size = new System.Drawing.Size(96, 20);
            this.txb_cliente_dni.TabIndex = 8;
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
            this.btt_add_client.Click += new System.EventHandler(this.btt_add_client_Click);
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
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 338);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btt_add_client);
            this.Controls.Add(this.txb_cliente_dni);
            this.Controls.Add(this.lbl_dni);
            this.Controls.Add(this.lbl_apellido);
            this.Controls.Add(this.btn_modif);
            this.Controls.Add(this.dgv_tablaCliente);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.LBLnombre);
            this.Controls.Add(this.txb_cliente_apellido);
            this.Controls.Add(this.txb_cliente_nombre);
            this.Name = "Cliente";
            this.Text = "Clientes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txb_cliente_nombre;
        private System.Windows.Forms.TextBox txb_cliente_apellido;
        private System.Windows.Forms.Label LBLnombre;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.DataGridView dgv_tablaCliente;
        private System.Windows.Forms.Button btn_modif;
        private System.Windows.Forms.Label lbl_apellido;
        private System.Windows.Forms.Label lbl_dni;
        private System.Windows.Forms.TextBox txb_cliente_dni;
        private System.Windows.Forms.Button btt_add_client;
        private System.Windows.Forms.Button btn_eliminar;
    }
}