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
            this.lbl_tipo_doc = new System.Windows.Forms.Label();
            this.cmb_tipo_doc = new System.Windows.Forms.ComboBox();
            this.txb_dni = new System.Windows.Forms.TextBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.dgv_reserva = new System.Windows.Forms.DataGridView();
            this.bt_canc = new System.Windows.Forms.Button();
            this.btn_mod = new System.Windows.Forms.Button();
            this.btn_volver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_reserva)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_numero
            // 
            this.lbl_numero.AutoSize = true;
            this.lbl_numero.Location = new System.Drawing.Point(111, 17);
            this.lbl_numero.Name = "lbl_numero";
            this.lbl_numero.Size = new System.Drawing.Size(44, 13);
            this.lbl_numero.TabIndex = 16;
            this.lbl_numero.Text = "Número";
            // 
            // lbl_tipo_doc
            // 
            this.lbl_tipo_doc.AutoSize = true;
            this.lbl_tipo_doc.Location = new System.Drawing.Point(4, 17);
            this.lbl_tipo_doc.Name = "lbl_tipo_doc";
            this.lbl_tipo_doc.Size = new System.Drawing.Size(86, 13);
            this.lbl_tipo_doc.TabIndex = 15;
            this.lbl_tipo_doc.Text = "Tipo Documento";
            // 
            // cmb_tipo_doc
            // 
            this.cmb_tipo_doc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_tipo_doc.FormattingEnabled = true;
            this.cmb_tipo_doc.Location = new System.Drawing.Point(7, 36);
            this.cmb_tipo_doc.Name = "cmb_tipo_doc";
            this.cmb_tipo_doc.Size = new System.Drawing.Size(92, 21);
            this.cmb_tipo_doc.TabIndex = 14;
            // 
            // txb_dni
            // 
            this.txb_dni.Location = new System.Drawing.Point(114, 36);
            this.txb_dni.Name = "txb_dni";
            this.txb_dni.Size = new System.Drawing.Size(96, 20);
            this.txb_dni.TabIndex = 13;
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(232, 33);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(120, 25);
            this.btn_buscar.TabIndex = 12;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // dgv_reserva
            // 
            this.dgv_reserva.AllowUserToAddRows = false;
            this.dgv_reserva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_reserva.Location = new System.Drawing.Point(14, 92);
            this.dgv_reserva.Name = "dgv_reserva";
            this.dgv_reserva.Size = new System.Drawing.Size(325, 136);
            this.dgv_reserva.TabIndex = 17;
            this.dgv_reserva.Visible = false;
            // 
            // bt_canc
            // 
            this.bt_canc.Location = new System.Drawing.Point(177, 260);
            this.bt_canc.Name = "bt_canc";
            this.bt_canc.Size = new System.Drawing.Size(120, 25);
            this.bt_canc.TabIndex = 18;
            this.bt_canc.Text = "Cancelar";
            this.bt_canc.UseVisualStyleBackColor = true;
            this.bt_canc.Visible = false;
            this.bt_canc.Click += new System.EventHandler(this.bt_canc_Click);
            // 
            // btn_mod
            // 
            this.btn_mod.Location = new System.Drawing.Point(14, 260);
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
            this.btn_volver.Location = new System.Drawing.Point(324, 276);
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.Size = new System.Drawing.Size(35, 29);
            this.btn_volver.TabIndex = 20;
            this.btn_volver.UseVisualStyleBackColor = true;
            this.btn_volver.Click += new System.EventHandler(this.btn_volver_Click);
            // 
            // BuscarReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 317);
            this.Controls.Add(this.btn_volver);
            this.Controls.Add(this.btn_mod);
            this.Controls.Add(this.bt_canc);
            this.Controls.Add(this.dgv_reserva);
            this.Controls.Add(this.lbl_numero);
            this.Controls.Add(this.lbl_tipo_doc);
            this.Controls.Add(this.cmb_tipo_doc);
            this.Controls.Add(this.txb_dni);
            this.Controls.Add(this.btn_buscar);
            this.Name = "BuscarReserva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar Reserva";
            this.Load += new System.EventHandler(this.BuscarReserva_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_reserva)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_numero;
        private System.Windows.Forms.Label lbl_tipo_doc;
        private System.Windows.Forms.ComboBox cmb_tipo_doc;
        private System.Windows.Forms.TextBox txb_dni;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.DataGridView dgv_reserva;
        private System.Windows.Forms.Button bt_canc;
        private System.Windows.Forms.Button btn_mod;
        private System.Windows.Forms.Button btn_volver;
    }
}