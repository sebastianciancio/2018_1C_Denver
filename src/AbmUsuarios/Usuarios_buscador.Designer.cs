namespace FrbaHotel.AbmUsuarios
{
    partial class Usuarios_buscador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Usuarios_buscador));
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_modif = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txb_nombre = new System.Windows.Forms.TextBox();
            this.txb_apellido = new System.Windows.Forms.TextBox();
            this.LBLnombre = new System.Windows.Forms.Label();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.lbl_apellido = new System.Windows.Forms.Label();
            this.dgv_tablaCliente = new System.Windows.Forms.DataGridView();
            this.btt_add_usuario = new System.Windows.Forms.Button();
            this.cmb_hotel = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tablaCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(721, 186);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(86, 26);
            this.btn_eliminar.TabIndex = 16;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Visible = false;
            // 
            // btn_modif
            // 
            this.btn_modif.Location = new System.Drawing.Point(719, 129);
            this.btn_modif.Name = "btn_modif";
            this.btn_modif.Size = new System.Drawing.Size(88, 29);
            this.btn_modif.TabIndex = 14;
            this.btn_modif.Text = "Modificar";
            this.btn_modif.UseVisualStyleBackColor = true;
            this.btn_modif.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmb_hotel);
            this.groupBox1.Controls.Add(this.txb_nombre);
            this.groupBox1.Controls.Add(this.txb_apellido);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.LBLnombre);
            this.groupBox1.Controls.Add(this.btn_buscar);
            this.groupBox1.Controls.Add(this.lbl_apellido);
            this.groupBox1.Location = new System.Drawing.Point(104, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(703, 83);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscador";
            // 
            // txb_nombre
            // 
            this.txb_nombre.Location = new System.Drawing.Point(31, 35);
            this.txb_nombre.MaxLength = 100;
            this.txb_nombre.Name = "txb_nombre";
            this.txb_nombre.Size = new System.Drawing.Size(113, 20);
            this.txb_nombre.TabIndex = 0;
            this.txb_nombre.Tag = "";
            // 
            // txb_apellido
            // 
            this.txb_apellido.Location = new System.Drawing.Point(161, 35);
            this.txb_apellido.Name = "txb_apellido";
            this.txb_apellido.Size = new System.Drawing.Size(143, 20);
            this.txb_apellido.TabIndex = 1;
            // 
            // LBLnombre
            // 
            this.LBLnombre.AutoSize = true;
            this.LBLnombre.Location = new System.Drawing.Point(28, 16);
            this.LBLnombre.Name = "LBLnombre";
            this.LBLnombre.Size = new System.Drawing.Size(47, 13);
            this.LBLnombre.TabIndex = 2;
            this.LBLnombre.Text = "Nombre:";
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(568, 32);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(120, 25);
            this.btn_buscar.TabIndex = 3;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            // 
            // lbl_apellido
            // 
            this.lbl_apellido.AutoSize = true;
            this.lbl_apellido.Location = new System.Drawing.Point(158, 16);
            this.lbl_apellido.Name = "lbl_apellido";
            this.lbl_apellido.Size = new System.Drawing.Size(44, 13);
            this.lbl_apellido.TabIndex = 6;
            this.lbl_apellido.Text = "Apellido";
            // 
            // dgv_tablaCliente
            // 
            this.dgv_tablaCliente.AllowUserToDeleteRows = false;
            this.dgv_tablaCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tablaCliente.Location = new System.Drawing.Point(11, 113);
            this.dgv_tablaCliente.MultiSelect = false;
            this.dgv_tablaCliente.Name = "dgv_tablaCliente";
            this.dgv_tablaCliente.ReadOnly = true;
            this.dgv_tablaCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_tablaCliente.Size = new System.Drawing.Size(694, 287);
            this.dgv_tablaCliente.TabIndex = 13;
            this.dgv_tablaCliente.Visible = false;
            // 
            // btt_add_usuario
            // 
            this.btt_add_usuario.Image = ((System.Drawing.Image)(resources.GetObject("btt_add_usuario.Image")));
            this.btt_add_usuario.Location = new System.Drawing.Point(12, 23);
            this.btt_add_usuario.Name = "btt_add_usuario";
            this.btt_add_usuario.Size = new System.Drawing.Size(82, 64);
            this.btt_add_usuario.TabIndex = 15;
            this.btt_add_usuario.Text = ".";
            this.btt_add_usuario.UseVisualStyleBackColor = true;
            // 
            // cmb_hotel
            // 
            this.cmb_hotel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_hotel.FormattingEnabled = true;
            this.cmb_hotel.Location = new System.Drawing.Point(322, 34);
            this.cmb_hotel.Name = "cmb_hotel";
            this.cmb_hotel.Size = new System.Drawing.Size(234, 21);
            this.cmb_hotel.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(319, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Hotel";
            // 
            // Usuarios_buscador
            // 
            this.AcceptButton = this.btn_buscar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 412);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_modif);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btt_add_usuario);
            this.Controls.Add(this.dgv_tablaCliente);
            this.Name = "Usuarios_buscador";
            this.Text = "Usuarios";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tablaCliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_modif;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txb_nombre;
        private System.Windows.Forms.TextBox txb_apellido;
        private System.Windows.Forms.Label LBLnombre;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Label lbl_apellido;
        private System.Windows.Forms.Button btt_add_usuario;
        private System.Windows.Forms.DataGridView dgv_tablaCliente;
        private System.Windows.Forms.ComboBox cmb_hotel;
        private System.Windows.Forms.Label label1;
    }
}