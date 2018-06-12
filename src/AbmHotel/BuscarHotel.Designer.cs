namespace FrbaHotel.AbmHotel
{
    partial class BuscarHotel
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
            this.dgv_tablaHotel = new System.Windows.Forms.DataGridView();
            this.btn_modif = new System.Windows.Forms.Button();
            this.btn_baja = new System.Windows.Forms.Button();
            this.LBLnombre = new System.Windows.Forms.Label();
            this.lbl_estrellas = new System.Windows.Forms.Label();
            this.cmb_estrellas = new System.Windows.Forms.ComboBox();
            this.lbl_ciudad = new System.Windows.Forms.Label();
            this.txb_ciudad = new System.Windows.Forms.TextBox();
            this.lbl_pais = new System.Windows.Forms.Label();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.btn_new_hotel = new System.Windows.Forms.Button();
            this.combo_pais = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmb_hotel = new System.Windows.Forms.ComboBox();
            this.btn_eliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tablaHotel)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_tablaHotel
            // 
            this.dgv_tablaHotel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tablaHotel.Location = new System.Drawing.Point(12, 101);
            this.dgv_tablaHotel.MultiSelect = false;
            this.dgv_tablaHotel.Name = "dgv_tablaHotel";
            this.dgv_tablaHotel.ReadOnly = true;
            this.dgv_tablaHotel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_tablaHotel.Size = new System.Drawing.Size(574, 198);
            this.dgv_tablaHotel.TabIndex = 5;
            this.dgv_tablaHotel.Visible = false;
            // 
            // btn_modif
            // 
            this.btn_modif.Location = new System.Drawing.Point(592, 103);
            this.btn_modif.Name = "btn_modif";
            this.btn_modif.Size = new System.Drawing.Size(88, 29);
            this.btn_modif.TabIndex = 6;
            this.btn_modif.Text = "Modificar";
            this.btn_modif.UseVisualStyleBackColor = true;
            this.btn_modif.Visible = false;
            this.btn_modif.Click += new System.EventHandler(this.btn_modif_Click);
            // 
            // btn_baja
            // 
            this.btn_baja.Location = new System.Drawing.Point(592, 152);
            this.btn_baja.Name = "btn_baja";
            this.btn_baja.Size = new System.Drawing.Size(88, 26);
            this.btn_baja.TabIndex = 11;
            this.btn_baja.Text = "Baja";
            this.btn_baja.UseVisualStyleBackColor = true;
            this.btn_baja.UseWaitCursor = true;
            this.btn_baja.Visible = false;
            this.btn_baja.Click += new System.EventHandler(this.btn_baja_Click);
            // 
            // LBLnombre
            // 
            this.LBLnombre.AutoSize = true;
            this.LBLnombre.Location = new System.Drawing.Point(15, 23);
            this.LBLnombre.Name = "LBLnombre";
            this.LBLnombre.Size = new System.Drawing.Size(32, 13);
            this.LBLnombre.TabIndex = 13;
            this.LBLnombre.Text = "Hotel";
            // 
            // lbl_estrellas
            // 
            this.lbl_estrellas.AutoSize = true;
            this.lbl_estrellas.Location = new System.Drawing.Point(15, 51);
            this.lbl_estrellas.Name = "lbl_estrellas";
            this.lbl_estrellas.Size = new System.Drawing.Size(73, 13);
            this.lbl_estrellas.TabIndex = 14;
            this.lbl_estrellas.Text = "Cant estrellas:";
            // 
            // cmb_estrellas
            // 
            this.cmb_estrellas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_estrellas.FormattingEnabled = true;
            this.cmb_estrellas.Location = new System.Drawing.Point(94, 48);
            this.cmb_estrellas.Name = "cmb_estrellas";
            this.cmb_estrellas.Size = new System.Drawing.Size(62, 21);
            this.cmb_estrellas.TabIndex = 15;
            // 
            // lbl_ciudad
            // 
            this.lbl_ciudad.AutoSize = true;
            this.lbl_ciudad.Location = new System.Drawing.Point(293, 23);
            this.lbl_ciudad.Name = "lbl_ciudad";
            this.lbl_ciudad.Size = new System.Drawing.Size(40, 13);
            this.lbl_ciudad.TabIndex = 16;
            this.lbl_ciudad.Text = "Ciudad";
            // 
            // txb_ciudad
            // 
            this.txb_ciudad.Location = new System.Drawing.Point(339, 19);
            this.txb_ciudad.MaxLength = 100;
            this.txb_ciudad.Name = "txb_ciudad";
            this.txb_ciudad.Size = new System.Drawing.Size(113, 20);
            this.txb_ciudad.TabIndex = 17;
            this.txb_ciudad.Tag = "";
            // 
            // lbl_pais
            // 
            this.lbl_pais.AutoSize = true;
            this.lbl_pais.Location = new System.Drawing.Point(245, 51);
            this.lbl_pais.Name = "lbl_pais";
            this.lbl_pais.Size = new System.Drawing.Size(27, 13);
            this.lbl_pais.TabIndex = 18;
            this.lbl_pais.Text = "Pais";
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(465, 31);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(120, 25);
            this.btn_buscar.TabIndex = 20;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // btn_new_hotel
            // 
            this.btn_new_hotel.ImageKey = "(none)";
            this.btn_new_hotel.Location = new System.Drawing.Point(12, 24);
            this.btn_new_hotel.Name = "btn_new_hotel";
            this.btn_new_hotel.Size = new System.Drawing.Size(82, 62);
            this.btn_new_hotel.TabIndex = 21;
            this.btn_new_hotel.Text = "Nuevo";
            this.btn_new_hotel.UseVisualStyleBackColor = true;
            this.btn_new_hotel.Click += new System.EventHandler(this.btn_new_hotel_Click);
            // 
            // combo_pais
            // 
            this.combo_pais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_pais.FormattingEnabled = true;
            this.combo_pais.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.combo_pais.Location = new System.Drawing.Point(278, 48);
            this.combo_pais.Name = "combo_pais";
            this.combo_pais.Size = new System.Drawing.Size(172, 21);
            this.combo_pais.TabIndex = 133;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmb_hotel);
            this.groupBox1.Controls.Add(this.btn_buscar);
            this.groupBox1.Controls.Add(this.combo_pais);
            this.groupBox1.Controls.Add(this.LBLnombre);
            this.groupBox1.Controls.Add(this.lbl_estrellas);
            this.groupBox1.Controls.Add(this.lbl_pais);
            this.groupBox1.Controls.Add(this.cmb_estrellas);
            this.groupBox1.Controls.Add(this.txb_ciudad);
            this.groupBox1.Controls.Add(this.lbl_ciudad);
            this.groupBox1.Location = new System.Drawing.Point(100, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(596, 83);
            this.groupBox1.TabIndex = 134;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscador";
            // 
            // cmb_hotel
            // 
            this.cmb_hotel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_hotel.FormattingEnabled = true;
            this.cmb_hotel.Location = new System.Drawing.Point(52, 19);
            this.cmb_hotel.Name = "cmb_hotel";
            this.cmb_hotel.Size = new System.Drawing.Size(234, 21);
            this.cmb_hotel.TabIndex = 134;
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(592, 199);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(88, 29);
            this.btn_eliminar.TabIndex = 135;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Visible = false;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // BuscarHotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 313);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_new_hotel);
            this.Controls.Add(this.btn_baja);
            this.Controls.Add(this.btn_modif);
            this.Controls.Add(this.dgv_tablaHotel);
            this.Name = "BuscarHotel";
            this.Text = "buscarHotel";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tablaHotel)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_tablaHotel;
        private System.Windows.Forms.Button btn_modif;
        private System.Windows.Forms.Button btn_baja;
        private System.Windows.Forms.Label LBLnombre;
        private System.Windows.Forms.Label lbl_estrellas;
        private System.Windows.Forms.ComboBox cmb_estrellas;
        private System.Windows.Forms.Label lbl_ciudad;
        private System.Windows.Forms.TextBox txb_ciudad;
        private System.Windows.Forms.Label lbl_pais;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Button btn_new_hotel;
        private System.Windows.Forms.ComboBox combo_pais;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.ComboBox cmb_hotel;
    }
}