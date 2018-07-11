namespace FrbaHotel
{
    partial class CancelacionReserva
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
            this.Container_reserva = new System.Windows.Forms.GroupBox();
            this.txb_motivo = new System.Windows.Forms.TextBox();
            this.lbl_canc_res_motivo = new System.Windows.Forms.Label();
            this.btn_cancelar_reserva = new System.Windows.Forms.Button();
            this.dg_reserva = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_buscar_reserva = new System.Windows.Forms.Button();
            this.cmb_hotel = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nro_reserva = new System.Windows.Forms.TextBox();
            this.Container_reserva.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_reserva)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Container_reserva
            // 
            this.Container_reserva.Controls.Add(this.txb_motivo);
            this.Container_reserva.Controls.Add(this.lbl_canc_res_motivo);
            this.Container_reserva.Controls.Add(this.btn_cancelar_reserva);
            this.Container_reserva.Controls.Add(this.dg_reserva);
            this.Container_reserva.Location = new System.Drawing.Point(12, 62);
            this.Container_reserva.Name = "Container_reserva";
            this.Container_reserva.Size = new System.Drawing.Size(737, 273);
            this.Container_reserva.TabIndex = 11;
            this.Container_reserva.TabStop = false;
            this.Container_reserva.Text = "Detalle de la Reserva";
            this.Container_reserva.Visible = false;
            // 
            // txb_motivo
            // 
            this.txb_motivo.Location = new System.Drawing.Point(8, 154);
            this.txb_motivo.Multiline = true;
            this.txb_motivo.Name = "txb_motivo";
            this.txb_motivo.Size = new System.Drawing.Size(722, 72);
            this.txb_motivo.TabIndex = 10;
            // 
            // lbl_canc_res_motivo
            // 
            this.lbl_canc_res_motivo.AutoSize = true;
            this.lbl_canc_res_motivo.Location = new System.Drawing.Point(6, 138);
            this.lbl_canc_res_motivo.Name = "lbl_canc_res_motivo";
            this.lbl_canc_res_motivo.Size = new System.Drawing.Size(118, 13);
            this.lbl_canc_res_motivo.TabIndex = 9;
            this.lbl_canc_res_motivo.Text = "Motivo de cancelación:";
            // 
            // btn_cancelar_reserva
            // 
            this.btn_cancelar_reserva.BackColor = System.Drawing.Color.Lime;
            this.btn_cancelar_reserva.Location = new System.Drawing.Point(276, 236);
            this.btn_cancelar_reserva.Name = "btn_cancelar_reserva";
            this.btn_cancelar_reserva.Size = new System.Drawing.Size(182, 27);
            this.btn_cancelar_reserva.TabIndex = 8;
            this.btn_cancelar_reserva.Text = "Cancelar Reserva";
            this.btn_cancelar_reserva.UseVisualStyleBackColor = false;
            this.btn_cancelar_reserva.Click += new System.EventHandler(this.btn_cancelar_reserva_Click);
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
            this.dg_reserva.Size = new System.Drawing.Size(724, 114);
            this.dg_reserva.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.btn_buscar_reserva);
            this.groupBox1.Controls.Add(this.cmb_hotel);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.nro_reserva);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(737, 44);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reserva";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Hotel";
            // 
            // btn_buscar_reserva
            // 
            this.btn_buscar_reserva.Location = new System.Drawing.Point(646, 11);
            this.btn_buscar_reserva.Name = "btn_buscar_reserva";
            this.btn_buscar_reserva.Size = new System.Drawing.Size(75, 23);
            this.btn_buscar_reserva.TabIndex = 11;
            this.btn_buscar_reserva.Text = "Buscar";
            this.btn_buscar_reserva.UseVisualStyleBackColor = true;
            this.btn_buscar_reserva.Click += new System.EventHandler(this.btn_buscar_reserva_Click);
            // 
            // cmb_hotel
            // 
            this.cmb_hotel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_hotel.FormattingEnabled = true;
            this.cmb_hotel.Location = new System.Drawing.Point(47, 13);
            this.cmb_hotel.Name = "cmb_hotel";
            this.cmb_hotel.Size = new System.Drawing.Size(396, 21);
            this.cmb_hotel.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(455, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nro. Reserva";
            // 
            // nro_reserva
            // 
            this.nro_reserva.Location = new System.Drawing.Point(531, 13);
            this.nro_reserva.Name = "nro_reserva";
            this.nro_reserva.Size = new System.Drawing.Size(93, 20);
            this.nro_reserva.TabIndex = 9;
            // 
            // CancelacionReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 351);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Container_reserva);
            this.Name = "CancelacionReserva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cancelación de Reserva";
            this.Container_reserva.ResumeLayout(false);
            this.Container_reserva.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_reserva)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Container_reserva;
        private System.Windows.Forms.Button btn_cancelar_reserva;
        private System.Windows.Forms.DataGridView dg_reserva;
        private System.Windows.Forms.TextBox txb_motivo;
        private System.Windows.Forms.Label lbl_canc_res_motivo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_buscar_reserva;
        private System.Windows.Forms.ComboBox cmb_hotel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nro_reserva;
    }
}