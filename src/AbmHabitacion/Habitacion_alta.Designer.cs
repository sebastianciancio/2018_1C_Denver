namespace FrbaHotel.AbmHabitacion
{
    partial class Habitacion_alta
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
            this.btn__volver = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.cmb_tipo = new System.Windows.Forms.ComboBox();
            this.lbl_regimenes = new System.Windows.Forms.Label();
            this.Piso = new System.Windows.Forms.Label();
            this.txb_piso = new System.Windows.Forms.TextBox();
            this.cmb_hotel = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_numero = new System.Windows.Forms.Label();
            this.txb_numero = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_vista = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txb_desc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn__volver
            // 
            this.btn__volver.Location = new System.Drawing.Point(153, 283);
            this.btn__volver.Name = "btn__volver";
            this.btn__volver.Size = new System.Drawing.Size(99, 25);
            this.btn__volver.TabIndex = 156;
            this.btn__volver.Text = "Volver";
            this.btn__volver.UseVisualStyleBackColor = true;
            this.btn__volver.Click += new System.EventHandler(this.btn__volver_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(42, 283);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(100, 26);
            this.btn_guardar.TabIndex = 155;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // cmb_tipo
            // 
            this.cmb_tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_tipo.FormattingEnabled = true;
            this.cmb_tipo.Items.AddRange(new object[] {
            "All inclusive",
            "Pensión completa",
            "Solo desayuno"});
            this.cmb_tipo.Location = new System.Drawing.Point(153, 75);
            this.cmb_tipo.Name = "cmb_tipo";
            this.cmb_tipo.Size = new System.Drawing.Size(141, 21);
            this.cmb_tipo.TabIndex = 154;
            // 
            // lbl_regimenes
            // 
            this.lbl_regimenes.AutoSize = true;
            this.lbl_regimenes.Location = new System.Drawing.Point(163, 55);
            this.lbl_regimenes.Name = "lbl_regimenes";
            this.lbl_regimenes.Size = new System.Drawing.Size(102, 13);
            this.lbl_regimenes.TabIndex = 153;
            this.lbl_regimenes.Text = "Tipos de Habitacion";
            // 
            // Piso
            // 
            this.Piso.AutoSize = true;
            this.Piso.Location = new System.Drawing.Point(15, 55);
            this.Piso.Name = "Piso";
            this.Piso.Size = new System.Drawing.Size(27, 13);
            this.Piso.TabIndex = 165;
            this.Piso.Text = "Piso";
            // 
            // txb_piso
            // 
            this.txb_piso.Location = new System.Drawing.Point(18, 75);
            this.txb_piso.MaxLength = 18;
            this.txb_piso.Name = "txb_piso";
            this.txb_piso.Size = new System.Drawing.Size(41, 20);
            this.txb_piso.TabIndex = 166;
            this.txb_piso.Tag = "";
            // 
            // cmb_hotel
            // 
            this.cmb_hotel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_hotel.FormattingEnabled = true;
            this.cmb_hotel.Location = new System.Drawing.Point(12, 27);
            this.cmb_hotel.Name = "cmb_hotel";
            this.cmb_hotel.Size = new System.Drawing.Size(234, 21);
            this.cmb_hotel.TabIndex = 162;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 161;
            this.label3.Text = "Hotel";
            // 
            // lbl_numero
            // 
            this.lbl_numero.AutoSize = true;
            this.lbl_numero.Location = new System.Drawing.Point(86, 54);
            this.lbl_numero.Name = "lbl_numero";
            this.lbl_numero.Size = new System.Drawing.Size(44, 13);
            this.lbl_numero.TabIndex = 163;
            this.lbl_numero.Text = "Número";
            // 
            // txb_numero
            // 
            this.txb_numero.Location = new System.Drawing.Point(89, 75);
            this.txb_numero.MaxLength = 18;
            this.txb_numero.Name = "txb_numero";
            this.txb_numero.Size = new System.Drawing.Size(41, 20);
            this.txb_numero.TabIndex = 164;
            this.txb_numero.Tag = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(50, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 13);
            this.label1.TabIndex = 167;
            this.label1.Text = "*";
            // 
            // cb_vista
            // 
            this.cb_vista.AutoSize = true;
            this.cb_vista.Location = new System.Drawing.Point(12, 260);
            this.cb_vista.Name = "cb_vista";
            this.cb_vista.Size = new System.Drawing.Size(118, 17);
            this.cb_vista.TabIndex = 168;
            this.cb_vista.Text = "Con vista al exterior";
            this.cb_vista.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(136, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 13);
            this.label2.TabIndex = 169;
            this.label2.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(39, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(11, 13);
            this.label4.TabIndex = 170;
            this.label4.Text = "*";
            // 
            // txb_desc
            // 
            this.txb_desc.Location = new System.Drawing.Point(12, 133);
            this.txb_desc.Multiline = true;
            this.txb_desc.Name = "txb_desc";
            this.txb_desc.Size = new System.Drawing.Size(282, 121);
            this.txb_desc.TabIndex = 171;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 172;
            this.label5.Text = "Descripción";
            // 
            // Habitacion_alta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 320);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txb_desc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_vista);
            this.Controls.Add(this.Piso);
            this.Controls.Add(this.txb_piso);
            this.Controls.Add(this.cmb_hotel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_numero);
            this.Controls.Add(this.txb_numero);
            this.Controls.Add(this.btn__volver);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.cmb_tipo);
            this.Controls.Add(this.lbl_regimenes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Name = "Habitacion_alta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nueva Habitación";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn__volver;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.ComboBox cmb_tipo;
        private System.Windows.Forms.Label lbl_regimenes;
        private System.Windows.Forms.Label Piso;
        private System.Windows.Forms.TextBox txb_piso;
        private System.Windows.Forms.ComboBox cmb_hotel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_numero;
        private System.Windows.Forms.TextBox txb_numero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cb_vista;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txb_desc;
        private System.Windows.Forms.Label label5;
    }
}