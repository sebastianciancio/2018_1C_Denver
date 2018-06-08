namespace FrbaHotel
{
    partial class Estadia
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_checkin = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.nro_reserva = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_checkout = new System.Windows.Forms.Button();
            this.cmb_habitacion = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Container_estadia = new System.Windows.Forms.GroupBox();
            this.dg_estadia = new System.Windows.Forms.DataGridView();
            this.Container_pasajero = new System.Windows.Forms.GroupBox();
            this.btn_confirmar_checkin = new System.Windows.Forms.Button();
            this.dg_pasajeros = new System.Windows.Forms.DataGridView();
            this.btn_agregar_pax = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.Container_estadia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_estadia)).BeginInit();
            this.Container_pasajero.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_pasajeros)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_checkin);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.nro_reserva);
            this.groupBox1.Location = new System.Drawing.Point(12, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(311, 68);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Check-in";
            // 
            // btn_checkin
            // 
            this.btn_checkin.Location = new System.Drawing.Point(199, 28);
            this.btn_checkin.Name = "btn_checkin";
            this.btn_checkin.Size = new System.Drawing.Size(75, 23);
            this.btn_checkin.TabIndex = 8;
            this.btn_checkin.Text = "Buscar";
            this.btn_checkin.UseVisualStyleBackColor = true;
            this.btn_checkin.Click += new System.EventHandler(this.btn_checkin_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nro. Reserva";
            // 
            // nro_reserva
            // 
            this.nro_reserva.Location = new System.Drawing.Point(84, 30);
            this.nro_reserva.Name = "nro_reserva";
            this.nro_reserva.Size = new System.Drawing.Size(93, 20);
            this.nro_reserva.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_checkout);
            this.groupBox2.Controls.Add(this.cmb_habitacion);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(329, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(374, 68);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Check-out";
            // 
            // btn_checkout
            // 
            this.btn_checkout.Location = new System.Drawing.Point(289, 28);
            this.btn_checkout.Name = "btn_checkout";
            this.btn_checkout.Size = new System.Drawing.Size(75, 23);
            this.btn_checkout.TabIndex = 7;
            this.btn_checkout.Text = "Buscar";
            this.btn_checkout.UseVisualStyleBackColor = true;
            // 
            // cmb_habitacion
            // 
            this.cmb_habitacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_habitacion.FormattingEnabled = true;
            this.cmb_habitacion.Location = new System.Drawing.Point(77, 30);
            this.cmb_habitacion.Name = "cmb_habitacion";
            this.cmb_habitacion.Size = new System.Drawing.Size(197, 21);
            this.cmb_habitacion.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Habitación";
            // 
            // Container_estadia
            // 
            this.Container_estadia.Controls.Add(this.dg_estadia);
            this.Container_estadia.Location = new System.Drawing.Point(12, 82);
            this.Container_estadia.Name = "Container_estadia";
            this.Container_estadia.Size = new System.Drawing.Size(691, 185);
            this.Container_estadia.TabIndex = 5;
            this.Container_estadia.TabStop = false;
            this.Container_estadia.Text = "Detalle de la Reserva";
            this.Container_estadia.Visible = false;
            // 
            // dg_estadia
            // 
            this.dg_estadia.AllowUserToAddRows = false;
            this.dg_estadia.AllowUserToDeleteRows = false;
            this.dg_estadia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_estadia.Location = new System.Drawing.Point(6, 19);
            this.dg_estadia.Name = "dg_estadia";
            this.dg_estadia.ReadOnly = true;
            this.dg_estadia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_estadia.Size = new System.Drawing.Size(679, 155);
            this.dg_estadia.TabIndex = 1;
            // 
            // Container_pasajero
            // 
            this.Container_pasajero.Controls.Add(this.btn_confirmar_checkin);
            this.Container_pasajero.Controls.Add(this.dg_pasajeros);
            this.Container_pasajero.Controls.Add(this.btn_agregar_pax);
            this.Container_pasajero.Location = new System.Drawing.Point(12, 273);
            this.Container_pasajero.Name = "Container_pasajero";
            this.Container_pasajero.Size = new System.Drawing.Size(691, 269);
            this.Container_pasajero.TabIndex = 4;
            this.Container_pasajero.TabStop = false;
            this.Container_pasajero.Text = "Pasajero";
            this.Container_pasajero.Visible = false;
            // 
            // btn_confirmar_checkin
            // 
            this.btn_confirmar_checkin.BackColor = System.Drawing.Color.Lime;
            this.btn_confirmar_checkin.Location = new System.Drawing.Point(259, 236);
            this.btn_confirmar_checkin.Name = "btn_confirmar_checkin";
            this.btn_confirmar_checkin.Size = new System.Drawing.Size(182, 25);
            this.btn_confirmar_checkin.TabIndex = 7;
            this.btn_confirmar_checkin.Text = "Confirmar Check/In";
            this.btn_confirmar_checkin.UseVisualStyleBackColor = false;
            this.btn_confirmar_checkin.Click += new System.EventHandler(this.btn_confirmar_checkin_Click);
            // 
            // dg_pasajeros
            // 
            this.dg_pasajeros.AllowUserToAddRows = false;
            this.dg_pasajeros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_pasajeros.Location = new System.Drawing.Point(6, 41);
            this.dg_pasajeros.Name = "dg_pasajeros";
            this.dg_pasajeros.ReadOnly = true;
            this.dg_pasajeros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_pasajeros.Size = new System.Drawing.Size(679, 189);
            this.dg_pasajeros.TabIndex = 2;
            this.dg_pasajeros.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dg_pasajeros_UserDeletingRow);
            // 
            // btn_agregar_pax
            // 
            this.btn_agregar_pax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_agregar_pax.Location = new System.Drawing.Point(503, 10);
            this.btn_agregar_pax.Name = "btn_agregar_pax";
            this.btn_agregar_pax.Size = new System.Drawing.Size(182, 25);
            this.btn_agregar_pax.TabIndex = 6;
            this.btn_agregar_pax.Text = "Agregar Pasajeros";
            this.btn_agregar_pax.UseVisualStyleBackColor = false;
            this.btn_agregar_pax.Click += new System.EventHandler(this.btn_agregar_pax_Click);
            // 
            // Estadia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 554);
            this.Controls.Add(this.Container_pasajero);
            this.Controls.Add(this.Container_estadia);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Estadia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Check-in / Check-out";
            this.Activated += new System.EventHandler(this.Estadia_Activated);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.Container_estadia.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_estadia)).EndInit();
            this.Container_pasajero.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_pasajeros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nro_reserva;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmb_habitacion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_checkin;
        private System.Windows.Forms.Button btn_checkout;
        private System.Windows.Forms.GroupBox Container_estadia;
        private System.Windows.Forms.DataGridView dg_estadia;
        private System.Windows.Forms.GroupBox Container_pasajero;
        private System.Windows.Forms.DataGridView dg_pasajeros;
        private System.Windows.Forms.Button btn_agregar_pax;
        private System.Windows.Forms.Button btn_confirmar_checkin;
    }
}