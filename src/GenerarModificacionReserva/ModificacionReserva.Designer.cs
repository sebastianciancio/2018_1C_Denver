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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmb_hotel = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_checkin = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.nro_reserva = new System.Windows.Forms.TextBox();
            this.Container_reserva = new System.Windows.Forms.GroupBox();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.dg_estadia = new System.Windows.Forms.DataGridView();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.Container_reserva.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_estadia)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.cmb_hotel);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(737, 44);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hotel";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(130, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Hotel";
            // 
            // cmb_hotel
            // 
            this.cmb_hotel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_hotel.FormattingEnabled = true;
            this.cmb_hotel.Location = new System.Drawing.Point(168, 10);
            this.cmb_hotel.Name = "cmb_hotel";
            this.cmb_hotel.Size = new System.Drawing.Size(396, 21);
            this.cmb_hotel.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_checkin);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.nro_reserva);
            this.groupBox1.Location = new System.Drawing.Point(12, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(737, 44);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reserva";
            // 
            // btn_checkin
            // 
            this.btn_checkin.Location = new System.Drawing.Point(428, 11);
            this.btn_checkin.Name = "btn_checkin";
            this.btn_checkin.Size = new System.Drawing.Size(75, 23);
            this.btn_checkin.TabIndex = 11;
            this.btn_checkin.Text = "Buscar";
            this.btn_checkin.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(237, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nro. Reserva";
            // 
            // nro_reserva
            // 
            this.nro_reserva.Location = new System.Drawing.Point(313, 13);
            this.nro_reserva.Name = "nro_reserva";
            this.nro_reserva.Size = new System.Drawing.Size(93, 20);
            this.nro_reserva.TabIndex = 9;
            // 
            // Container_reserva
            // 
            this.Container_reserva.Controls.Add(this.btn_Modificar);
            this.Container_reserva.Controls.Add(this.dg_estadia);
            this.Container_reserva.Location = new System.Drawing.Point(12, 112);
            this.Container_reserva.Name = "Container_reserva";
            this.Container_reserva.Size = new System.Drawing.Size(736, 273);
            this.Container_reserva.TabIndex = 12;
            this.Container_reserva.TabStop = false;
            this.Container_reserva.Text = "Detalle de la Reserva";
            this.Container_reserva.Visible = false;
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.BackColor = System.Drawing.Color.Lime;
            this.btn_Modificar.Location = new System.Drawing.Point(276, 236);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(182, 27);
            this.btn_Modificar.TabIndex = 8;
            this.btn_Modificar.Text = "Cancelar Reserva";
            this.btn_Modificar.UseVisualStyleBackColor = false;
            this.btn_Modificar.Visible = false;
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
            this.dg_estadia.Size = new System.Drawing.Size(724, 211);
            this.dg_estadia.TabIndex = 1;
            // 
            // ModificacionReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 489);
            this.Controls.Add(this.Container_reserva);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ModificacionReserva";
            this.Text = "ModificacionReserva";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Container_reserva.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_estadia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmb_hotel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_checkin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nro_reserva;
        private System.Windows.Forms.GroupBox Container_reserva;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.DataGridView dg_estadia;
    }
}