namespace FrbaHotel
{
    partial class ModificacionReserva
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
            this.label9 = new System.Windows.Forms.Label();
            this.cmb_hotel = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_buscar_reserva = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.nro_reserva = new System.Windows.Forms.TextBox();
            this.Container_reserva = new System.Windows.Forms.GroupBox();
            this.dg_reserva = new System.Windows.Forms.DataGridView();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.Container_modif_reserva = new System.Windows.Forms.GroupBox();
            this.label_hab_precio = new System.Windows.Forms.Label();
            this.label_disponibilidad = new System.Windows.Forms.Label();
            this.btn_check_disponibilidad = new System.Windows.Forms.Button();
            this.cmb_regimen = new System.Windows.Forms.ComboBox();
            this.fecha_hasta = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_tipo_hab = new System.Windows.Forms.ComboBox();
            this.fecha_desde = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dg_disponibilidad = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.Container_reserva.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_reserva)).BeginInit();
            this.Container_modif_reserva.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_disponibilidad)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Hotel";
            // 
            // cmb_hotel
            // 
            this.cmb_hotel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_hotel.FormattingEnabled = true;
            this.cmb_hotel.Location = new System.Drawing.Point(47, 16);
            this.cmb_hotel.Name = "cmb_hotel";
            this.cmb_hotel.Size = new System.Drawing.Size(396, 21);
            this.cmb_hotel.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.btn_buscar_reserva);
            this.groupBox1.Controls.Add(this.cmb_hotel);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.nro_reserva);
            this.groupBox1.Location = new System.Drawing.Point(12, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(737, 44);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reserva";
            // 
            // btn_buscar_reserva
            // 
            this.btn_buscar_reserva.Location = new System.Drawing.Point(646, 14);
            this.btn_buscar_reserva.Name = "btn_buscar_reserva";
            this.btn_buscar_reserva.Size = new System.Drawing.Size(75, 23);
            this.btn_buscar_reserva.TabIndex = 11;
            this.btn_buscar_reserva.Text = "Buscar";
            this.btn_buscar_reserva.UseVisualStyleBackColor = true;
            this.btn_buscar_reserva.Click += new System.EventHandler(this.btn_buscar_reserva_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(455, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nro. Reserva";
            // 
            // nro_reserva
            // 
            this.nro_reserva.Location = new System.Drawing.Point(531, 16);
            this.nro_reserva.Name = "nro_reserva";
            this.nro_reserva.Size = new System.Drawing.Size(93, 20);
            this.nro_reserva.TabIndex = 9;
            // 
            // Container_reserva
            // 
            this.Container_reserva.Controls.Add(this.dg_reserva);
            this.Container_reserva.Location = new System.Drawing.Point(12, 59);
            this.Container_reserva.Name = "Container_reserva";
            this.Container_reserva.Size = new System.Drawing.Size(736, 170);
            this.Container_reserva.TabIndex = 12;
            this.Container_reserva.TabStop = false;
            this.Container_reserva.Text = "Detalle de la Reserva";
            this.Container_reserva.Visible = false;
            // 
            // dg_reserva
            // 
            this.dg_reserva.AllowUserToAddRows = false;
            this.dg_reserva.AllowUserToDeleteRows = false;
            this.dg_reserva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_reserva.Location = new System.Drawing.Point(6, 19);
            this.dg_reserva.Name = "dg_reserva";
            this.dg_reserva.ReadOnly = true;
            this.dg_reserva.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_reserva.Size = new System.Drawing.Size(724, 141);
            this.dg_reserva.TabIndex = 1;
            this.dg_reserva.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_reserva_CellClick);
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.BackColor = System.Drawing.Color.Lime;
            this.btn_Modificar.Location = new System.Drawing.Point(486, 133);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(182, 27);
            this.btn_Modificar.TabIndex = 8;
            this.btn_Modificar.Text = "Modificar Reserva";
            this.btn_Modificar.UseVisualStyleBackColor = false;
            this.btn_Modificar.Visible = false;
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
            // 
            // Container_modif_reserva
            // 
            this.Container_modif_reserva.Controls.Add(this.label_hab_precio);
            this.Container_modif_reserva.Controls.Add(this.label_disponibilidad);
            this.Container_modif_reserva.Controls.Add(this.btn_check_disponibilidad);
            this.Container_modif_reserva.Controls.Add(this.cmb_regimen);
            this.Container_modif_reserva.Controls.Add(this.fecha_hasta);
            this.Container_modif_reserva.Controls.Add(this.btn_Modificar);
            this.Container_modif_reserva.Controls.Add(this.label4);
            this.Container_modif_reserva.Controls.Add(this.label3);
            this.Container_modif_reserva.Controls.Add(this.label1);
            this.Container_modif_reserva.Controls.Add(this.cmb_tipo_hab);
            this.Container_modif_reserva.Controls.Add(this.fecha_desde);
            this.Container_modif_reserva.Controls.Add(this.label5);
            this.Container_modif_reserva.Location = new System.Drawing.Point(12, 235);
            this.Container_modif_reserva.Name = "Container_modif_reserva";
            this.Container_modif_reserva.Size = new System.Drawing.Size(737, 172);
            this.Container_modif_reserva.TabIndex = 13;
            this.Container_modif_reserva.TabStop = false;
            this.Container_modif_reserva.Text = "Modificación de la Reserva";
            this.Container_modif_reserva.Visible = false;
            // 
            // label_hab_precio
            // 
            this.label_hab_precio.BackColor = System.Drawing.Color.Transparent;
            this.label_hab_precio.Location = new System.Drawing.Point(21, 91);
            this.label_hab_precio.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label_hab_precio.Name = "label_hab_precio";
            this.label_hab_precio.Padding = new System.Windows.Forms.Padding(0, 7, 0, 0);
            this.label_hab_precio.Size = new System.Drawing.Size(647, 27);
            this.label_hab_precio.TabIndex = 11;
            this.label_hab_precio.Text = "Habitacion xxx disponible a precio xxx";
            this.label_hab_precio.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label_hab_precio.Visible = false;
            // 
            // label_disponibilidad
            // 
            this.label_disponibilidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label_disponibilidad.Location = new System.Drawing.Point(209, 133);
            this.label_disponibilidad.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label_disponibilidad.Name = "label_disponibilidad";
            this.label_disponibilidad.Padding = new System.Windows.Forms.Padding(0, 7, 0, 0);
            this.label_disponibilidad.Size = new System.Drawing.Size(244, 27);
            this.label_disponibilidad.TabIndex = 10;
            this.label_disponibilidad.Text = "Existe Disponibilidad";
            this.label_disponibilidad.Visible = false;
            // 
            // btn_check_disponibilidad
            // 
            this.btn_check_disponibilidad.BackColor = System.Drawing.Color.Lime;
            this.btn_check_disponibilidad.Location = new System.Drawing.Point(21, 133);
            this.btn_check_disponibilidad.Name = "btn_check_disponibilidad";
            this.btn_check_disponibilidad.Size = new System.Drawing.Size(182, 27);
            this.btn_check_disponibilidad.TabIndex = 9;
            this.btn_check_disponibilidad.Text = "Comprobar Disponibilidad";
            this.btn_check_disponibilidad.UseVisualStyleBackColor = false;
            this.btn_check_disponibilidad.Click += new System.EventHandler(this.btn_check_disponibilidad_Click);
            // 
            // cmb_regimen
            // 
            this.cmb_regimen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_regimen.FormattingEnabled = true;
            this.cmb_regimen.Location = new System.Drawing.Point(468, 62);
            this.cmb_regimen.Name = "cmb_regimen";
            this.cmb_regimen.Size = new System.Drawing.Size(200, 21);
            this.cmb_regimen.TabIndex = 4;
            // 
            // fecha_hasta
            // 
            this.fecha_hasta.CustomFormat = "dd/MM/yyyy";
            this.fecha_hasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fecha_hasta.Location = new System.Drawing.Point(468, 27);
            this.fecha_hasta.Name = "fecha_hasta";
            this.fecha_hasta.Size = new System.Drawing.Size(200, 20);
            this.fecha_hasta.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(353, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tipo de Regimen";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tipo de Habitacion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(353, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hasta";
            // 
            // cmb_tipo_hab
            // 
            this.cmb_tipo_hab.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_tipo_hab.FormattingEnabled = true;
            this.cmb_tipo_hab.Location = new System.Drawing.Point(133, 62);
            this.cmb_tipo_hab.Name = "cmb_tipo_hab";
            this.cmb_tipo_hab.Size = new System.Drawing.Size(200, 21);
            this.cmb_tipo_hab.TabIndex = 3;
            // 
            // fecha_desde
            // 
            this.fecha_desde.CustomFormat = "dd/MM/yyyy";
            this.fecha_desde.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fecha_desde.Location = new System.Drawing.Point(133, 24);
            this.fecha_desde.Name = "fecha_desde";
            this.fecha_desde.Size = new System.Drawing.Size(200, 20);
            this.fecha_desde.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Desde";
            // 
            // dg_disponibilidad
            // 
            this.dg_disponibilidad.AllowUserToAddRows = false;
            this.dg_disponibilidad.AllowUserToDeleteRows = false;
            this.dg_disponibilidad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_disponibilidad.Location = new System.Drawing.Point(33, 94);
            this.dg_disponibilidad.Name = "dg_disponibilidad";
            this.dg_disponibilidad.ReadOnly = true;
            this.dg_disponibilidad.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_disponibilidad.Size = new System.Drawing.Size(736, 98);
            this.dg_disponibilidad.TabIndex = 14;
            this.dg_disponibilidad.Visible = false;
            // 
            // ModificacionReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 419);
            this.Controls.Add(this.Container_modif_reserva);
            this.Controls.Add(this.Container_reserva);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dg_disponibilidad);
            this.Name = "ModificacionReserva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModificacionReserva";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Container_reserva.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_reserva)).EndInit();
            this.Container_modif_reserva.ResumeLayout(false);
            this.Container_modif_reserva.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_disponibilidad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmb_hotel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_buscar_reserva;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nro_reserva;
        private System.Windows.Forms.GroupBox Container_reserva;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.DataGridView dg_reserva;
        private System.Windows.Forms.GroupBox Container_modif_reserva;
        private System.Windows.Forms.ComboBox cmb_regimen;
        private System.Windows.Forms.DateTimePicker fecha_hasta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_tipo_hab;
        private System.Windows.Forms.DateTimePicker fecha_desde;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_check_disponibilidad;
        private System.Windows.Forms.Label label_disponibilidad;
        private System.Windows.Forms.DataGridView dg_disponibilidad;
        private System.Windows.Forms.Label label_hab_precio;
    }
}