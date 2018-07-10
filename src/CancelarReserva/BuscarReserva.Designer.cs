namespace FrbaHotel.CancelarReserva
{
    partial class BuscarReserva
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
            this.lbl_numero = new System.Windows.Forms.Label();
            this.txb_reserva = new System.Windows.Forms.TextBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.btn_mod = new System.Windows.Forms.Button();
            this.btn_volver = new System.Windows.Forms.Button();
            this.fecha_desde = new System.Windows.Forms.DateTimePicker();
            this.fecha_hasta = new System.Windows.Forms.DateTimePicker();
            this.lbl_fecha = new System.Windows.Forms.Label();
            this.cmb_regimen = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_tipo_hab = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbl_numero
            // 
            this.lbl_numero.AutoSize = true;
            this.lbl_numero.Location = new System.Drawing.Point(11, 22);
            this.lbl_numero.Name = "lbl_numero";
            this.lbl_numero.Size = new System.Drawing.Size(97, 13);
            this.lbl_numero.TabIndex = 16;
            this.lbl_numero.Text = "Número de reserva";
            // 
            // txb_reserva
            // 
            this.txb_reserva.Location = new System.Drawing.Point(14, 48);
            this.txb_reserva.Name = "txb_reserva";
            this.txb_reserva.Size = new System.Drawing.Size(96, 20);
            this.txb_reserva.TabIndex = 13;
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(137, 43);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(120, 25);
            this.btn_buscar.TabIndex = 12;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // btn_mod
            // 
            this.btn_mod.Location = new System.Drawing.Point(14, 295);
            this.btn_mod.Name = "btn_mod";
            this.btn_mod.Size = new System.Drawing.Size(120, 25);
            this.btn_mod.TabIndex = 19;
            this.btn_mod.Text = "Modificar";
            this.btn_mod.UseVisualStyleBackColor = true;
            this.btn_mod.Visible = false;
            this.btn_mod.Click += new System.EventHandler(this.btn_mod_Click);
            // 
            // btn_volver
            // 
            this.btn_volver.Image = global::FrbaHotel.Properties.Resources.volver;
            this.btn_volver.Location = new System.Drawing.Point(488, 291);
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.Size = new System.Drawing.Size(35, 29);
            this.btn_volver.TabIndex = 20;
            this.btn_volver.UseVisualStyleBackColor = true;
            this.btn_volver.Click += new System.EventHandler(this.btn_volver_Click);
            // 
            // fecha_desde
            // 
            this.fecha_desde.Location = new System.Drawing.Point(68, 87);
            this.fecha_desde.Name = "fecha_desde";
            this.fecha_desde.Size = new System.Drawing.Size(200, 20);
            this.fecha_desde.TabIndex = 21;
            this.fecha_desde.Visible = false;
            // 
            // fecha_hasta
            // 
            this.fecha_hasta.Location = new System.Drawing.Point(295, 87);
            this.fecha_hasta.Name = "fecha_hasta";
            this.fecha_hasta.Size = new System.Drawing.Size(200, 20);
            this.fecha_hasta.TabIndex = 22;
            this.fecha_hasta.Visible = false;
            // 
            // lbl_fecha
            // 
            this.lbl_fecha.AutoSize = true;
            this.lbl_fecha.Location = new System.Drawing.Point(11, 93);
            this.lbl_fecha.Name = "lbl_fecha";
            this.lbl_fecha.Size = new System.Drawing.Size(40, 13);
            this.lbl_fecha.TabIndex = 23;
            this.lbl_fecha.Text = "Fecha:";
            this.lbl_fecha.Visible = false;
            // 
            // cmb_regimen
            // 
            this.cmb_regimen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_regimen.FormattingEnabled = true;
            this.cmb_regimen.Location = new System.Drawing.Point(219, 163);
            this.cmb_regimen.Name = "cmb_regimen";
            this.cmb_regimen.Size = new System.Drawing.Size(200, 21);
            this.cmb_regimen.TabIndex = 25;
            this.cmb_regimen.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(104, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Tipo de Regimen";
            this.label4.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(104, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Tipo de Habitacion";
            this.label3.Visible = false;
            // 
            // cmb_tipo_hab
            // 
            this.cmb_tipo_hab.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_tipo_hab.FormattingEnabled = true;
            this.cmb_tipo_hab.Location = new System.Drawing.Point(219, 127);
            this.cmb_tipo_hab.Name = "cmb_tipo_hab";
            this.cmb_tipo_hab.Size = new System.Drawing.Size(200, 21);
            this.cmb_tipo_hab.TabIndex = 24;
            this.cmb_tipo_hab.Visible = false;
            // 
            // BuscarReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 332);
            this.Controls.Add(this.cmb_regimen);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmb_tipo_hab);
            this.Controls.Add(this.lbl_fecha);
            this.Controls.Add(this.fecha_hasta);
            this.Controls.Add(this.fecha_desde);
            this.Controls.Add(this.btn_volver);
            this.Controls.Add(this.btn_mod);
            this.Controls.Add(this.lbl_numero);
            this.Controls.Add(this.txb_reserva);
            this.Controls.Add(this.btn_buscar);
            this.Name = "BuscarReserva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar Reserva";
            this.Load += new System.EventHandler(this.BuscarReserva_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_numero;
        private System.Windows.Forms.TextBox txb_reserva;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Button btn_mod;
        private System.Windows.Forms.Button btn_volver;
        private System.Windows.Forms.DateTimePicker fecha_desde;
        private System.Windows.Forms.DateTimePicker fecha_hasta;
        private System.Windows.Forms.Label lbl_fecha;
        private System.Windows.Forms.ComboBox cmb_regimen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_tipo_hab;
    }
}