namespace FrbaHotel.AbmHabitacion
{
    partial class Habitaciones_buscador
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
            this.btn_new_hotel = new System.Windows.Forms.Button();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.txb_numero = new System.Windows.Forms.TextBox();
            this.lbl_numero = new System.Windows.Forms.Label();
            this.btn_baja = new System.Windows.Forms.Button();
            this.btn_modif = new System.Windows.Forms.Button();
            this.dgv_hab = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Piso = new System.Windows.Forms.Label();
            this.txb_piso = new System.Windows.Forms.TextBox();
            this.cmb_hotel = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hab)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_new_hotel
            // 
            this.btn_new_hotel.ImageKey = "(none)";
            this.btn_new_hotel.Location = new System.Drawing.Point(12, 22);
            this.btn_new_hotel.Name = "btn_new_hotel";
            this.btn_new_hotel.Size = new System.Drawing.Size(82, 62);
            this.btn_new_hotel.TabIndex = 34;
            this.btn_new_hotel.Text = "Nuevo";
            this.btn_new_hotel.UseVisualStyleBackColor = true;
            this.btn_new_hotel.Click += new System.EventHandler(this.btn_new_hotel_Click);
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(471, 39);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(120, 25);
            this.btn_buscar.TabIndex = 33;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // txb_numero
            // 
            this.txb_numero.Location = new System.Drawing.Point(340, 42);
            this.txb_numero.MaxLength = 100;
            this.txb_numero.Name = "txb_numero";
            this.txb_numero.Size = new System.Drawing.Size(41, 20);
            this.txb_numero.TabIndex = 30;
            this.txb_numero.Tag = "";
            // 
            // lbl_numero
            // 
            this.lbl_numero.AutoSize = true;
            this.lbl_numero.Location = new System.Drawing.Point(337, 21);
            this.lbl_numero.Name = "lbl_numero";
            this.lbl_numero.Size = new System.Drawing.Size(78, 13);
            this.lbl_numero.TabIndex = 29;
            this.lbl_numero.Text = "Nro Habitación";
            // 
            // btn_baja
            // 
            this.btn_baja.Location = new System.Drawing.Point(605, 186);
            this.btn_baja.Name = "btn_baja";
            this.btn_baja.Size = new System.Drawing.Size(102, 39);
            this.btn_baja.TabIndex = 24;
            this.btn_baja.Text = "Baja/Habilitacion";
            this.btn_baja.UseVisualStyleBackColor = true;
            this.btn_baja.Visible = false;
            this.btn_baja.Click += new System.EventHandler(this.btn_baja_Click);
            // 
            // btn_modif
            // 
            this.btn_modif.Location = new System.Drawing.Point(603, 123);
            this.btn_modif.Name = "btn_modif";
            this.btn_modif.Size = new System.Drawing.Size(104, 39);
            this.btn_modif.TabIndex = 23;
            this.btn_modif.Text = "Modificar";
            this.btn_modif.UseVisualStyleBackColor = true;
            this.btn_modif.Visible = false;
            this.btn_modif.Click += new System.EventHandler(this.btn_modif_Click);
            // 
            // dgv_hab
            // 
            this.dgv_hab.AllowUserToAddRows = false;
            this.dgv_hab.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_hab.Location = new System.Drawing.Point(11, 101);
            this.dgv_hab.Name = "dgv_hab";
            this.dgv_hab.ReadOnly = true;
            this.dgv_hab.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_hab.Size = new System.Drawing.Size(564, 189);
            this.dgv_hab.TabIndex = 22;
            this.dgv_hab.Visible = false;
            
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Piso);
            this.groupBox1.Controls.Add(this.txb_piso);
            this.groupBox1.Controls.Add(this.cmb_hotel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_buscar);
            this.groupBox1.Controls.Add(this.lbl_numero);
            this.groupBox1.Controls.Add(this.txb_numero);
            this.groupBox1.Location = new System.Drawing.Point(100, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(607, 83);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscador";
            // 
            // Piso
            // 
            this.Piso.AutoSize = true;
            this.Piso.Location = new System.Drawing.Point(266, 22);
            this.Piso.Name = "Piso";
            this.Piso.Size = new System.Drawing.Size(27, 13);
            this.Piso.TabIndex = 34;
            this.Piso.Text = "Piso";
            // 
            // txb_piso
            // 
            this.txb_piso.Location = new System.Drawing.Point(269, 42);
            this.txb_piso.MaxLength = 100;
            this.txb_piso.Name = "txb_piso";
            this.txb_piso.Size = new System.Drawing.Size(41, 20);
            this.txb_piso.TabIndex = 35;
            this.txb_piso.Tag = "";
            // 
            // cmb_hotel
            // 
            this.cmb_hotel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_hotel.FormattingEnabled = true;
            this.cmb_hotel.Location = new System.Drawing.Point(13, 42);
            this.cmb_hotel.Name = "cmb_hotel";
            this.cmb_hotel.Size = new System.Drawing.Size(234, 21);
            this.cmb_hotel.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Hotel";
            // 
            // Habitaciones_buscador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 302);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_new_hotel);
            this.Controls.Add(this.btn_baja);
            this.Controls.Add(this.btn_modif);
            this.Controls.Add(this.dgv_hab);
            this.Name = "Habitaciones_buscador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Habitación ";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hab)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_new_hotel;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.TextBox txb_numero;
        private System.Windows.Forms.Label lbl_numero;
        private System.Windows.Forms.Button btn_baja;
        private System.Windows.Forms.Button btn_modif;
        private System.Windows.Forms.DataGridView dgv_hab;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmb_hotel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Piso;
        private System.Windows.Forms.TextBox txb_piso;
    }
}