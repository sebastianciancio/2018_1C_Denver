namespace FrbaHotel
{
    partial class Reserva
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
            this.button1 = new System.Windows.Forms.Button();
            this.cmb_regimen = new System.Windows.Forms.ComboBox();
            this.fecha_hasta = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_tipo_hab = new System.Windows.Forms.ComboBox();
            this.fecha_desde = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dg_disponibilidad = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_disponibilidad)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.cmb_regimen);
            this.groupBox1.Controls.Add(this.fecha_hasta);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmb_tipo_hab);
            this.groupBox1.Controls.Add(this.fecha_desde);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(737, 126);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reserva";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.Location = new System.Drawing.Point(166, 89);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(377, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Consultar Disponibilidad";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(353, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Hasta";
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
            this.fecha_desde.CustomFormat = "dd/mm/yyyy";
            this.fecha_desde.Location = new System.Drawing.Point(133, 24);
            this.fecha_desde.Name = "fecha_desde";
            this.fecha_desde.Size = new System.Drawing.Size(200, 20);
            this.fecha_desde.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Desde";
            // 
            // dg_disponibilidad
            // 
            this.dg_disponibilidad.AllowUserToAddRows = false;
            this.dg_disponibilidad.AllowUserToDeleteRows = false;
            this.dg_disponibilidad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_disponibilidad.Location = new System.Drawing.Point(12, 153);
            this.dg_disponibilidad.Name = "dg_disponibilidad";
            this.dg_disponibilidad.ReadOnly = true;
            this.dg_disponibilidad.Size = new System.Drawing.Size(737, 380);
            this.dg_disponibilidad.TabIndex = 1;
            // 
            // Reserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 545);
            this.Controls.Add(this.dg_disponibilidad);
            this.Controls.Add(this.groupBox1);
            this.Name = "Reserva";
            this.Text = "Reservas";
            this.Load += new System.EventHandler(this.Reserva_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_disponibilidad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmb_regimen;
        private System.Windows.Forms.DateTimePicker fecha_hasta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_tipo_hab;
        private System.Windows.Forms.DateTimePicker fecha_desde;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dg_disponibilidad;
    }
}