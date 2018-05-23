namespace FrbaHotel.AbmHabitacion
{
    partial class Form1
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
            this.txb_ciudad = new System.Windows.Forms.TextBox();
            this.lbl_numero = new System.Windows.Forms.Label();
            this.LBLnombre = new System.Windows.Forms.Label();
            this.txb_nombre = new System.Windows.Forms.TextBox();
            this.btn_baja = new System.Windows.Forms.Button();
            this.btn_modif = new System.Windows.Forms.Button();
            this.dgv_tablaHotel = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tablaHotel)).BeginInit();
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
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(560, 37);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(120, 25);
            this.btn_buscar.TabIndex = 33;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            // 
            // txb_ciudad
            // 
            this.txb_ciudad.Location = new System.Drawing.Point(427, 40);
            this.txb_ciudad.MaxLength = 100;
            this.txb_ciudad.Name = "txb_ciudad";
            this.txb_ciudad.Size = new System.Drawing.Size(113, 20);
            this.txb_ciudad.TabIndex = 30;
            this.txb_ciudad.Tag = "";
            // 
            // lbl_numero
            // 
            this.lbl_numero.AutoSize = true;
            this.lbl_numero.Location = new System.Drawing.Point(317, 43);
            this.lbl_numero.Name = "lbl_numero";
            this.lbl_numero.Size = new System.Drawing.Size(104, 13);
            this.lbl_numero.TabIndex = 29;
            this.lbl_numero.Text = "Número Habitación :";
            // 
            // LBLnombre
            // 
            this.LBLnombre.AutoSize = true;
            this.LBLnombre.Location = new System.Drawing.Point(105, 43);
            this.LBLnombre.Name = "LBLnombre";
            this.LBLnombre.Size = new System.Drawing.Size(75, 13);
            this.LBLnombre.TabIndex = 26;
            this.LBLnombre.Text = "Nombre Hotel:";
            // 
            // txb_nombre
            // 
            this.txb_nombre.Location = new System.Drawing.Point(186, 40);
            this.txb_nombre.MaxLength = 100;
            this.txb_nombre.Name = "txb_nombre";
            this.txb_nombre.Size = new System.Drawing.Size(113, 20);
            this.txb_nombre.TabIndex = 25;
            this.txb_nombre.Tag = "";
            // 
            // btn_baja
            // 
            this.btn_baja.Location = new System.Drawing.Point(594, 183);
            this.btn_baja.Name = "btn_baja";
            this.btn_baja.Size = new System.Drawing.Size(86, 26);
            this.btn_baja.TabIndex = 24;
            this.btn_baja.Text = "Baja";
            this.btn_baja.UseVisualStyleBackColor = true;
            this.btn_baja.UseWaitCursor = true;
            this.btn_baja.Visible = false;
            // 
            // btn_modif
            // 
            this.btn_modif.Location = new System.Drawing.Point(592, 120);
            this.btn_modif.Name = "btn_modif";
            this.btn_modif.Size = new System.Drawing.Size(88, 29);
            this.btn_modif.TabIndex = 23;
            this.btn_modif.Text = "Modificar";
            this.btn_modif.UseVisualStyleBackColor = true;
            this.btn_modif.Visible = false;
            // 
            // dgv_tablaHotel
            // 
            this.dgv_tablaHotel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tablaHotel.Location = new System.Drawing.Point(26, 105);
            this.dgv_tablaHotel.Name = "dgv_tablaHotel";
            this.dgv_tablaHotel.ReadOnly = true;
            this.dgv_tablaHotel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_tablaHotel.Size = new System.Drawing.Size(544, 150);
            this.dgv_tablaHotel.TabIndex = 22;
            this.dgv_tablaHotel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 302);
            this.Controls.Add(this.btn_new_hotel);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.txb_ciudad);
            this.Controls.Add(this.lbl_numero);
            this.Controls.Add(this.LBLnombre);
            this.Controls.Add(this.txb_nombre);
            this.Controls.Add(this.btn_baja);
            this.Controls.Add(this.btn_modif);
            this.Controls.Add(this.dgv_tablaHotel);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tablaHotel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_new_hotel;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.TextBox txb_ciudad;
        private System.Windows.Forms.Label lbl_numero;
        private System.Windows.Forms.Label LBLnombre;
        private System.Windows.Forms.TextBox txb_nombre;
        private System.Windows.Forms.Button btn_baja;
        private System.Windows.Forms.Button btn_modif;
        private System.Windows.Forms.DataGridView dgv_tablaHotel;
    }
}