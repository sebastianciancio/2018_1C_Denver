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
            this.Container_disponibilidad = new System.Windows.Forms.GroupBox();
            this.Container_pasajero = new System.Windows.Forms.GroupBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.Container_Detalle_Reserva = new System.Windows.Forms.GroupBox();
            this.txt_reserva_total = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_reserva_habitacion = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_reserva_fechas = new System.Windows.Forms.Label();
            this.txt_reserva_pasajero = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_confirmar_reserva = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_disponibilidad)).BeginInit();
            this.Container_disponibilidad.SuspendLayout();
            this.Container_pasajero.SuspendLayout();
            this.Container_Detalle_Reserva.SuspendLayout();
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
            this.fecha_desde.CustomFormat = "dd/MM/yyyy";
            this.fecha_desde.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
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
            this.dg_disponibilidad.Location = new System.Drawing.Point(6, 19);
            this.dg_disponibilidad.Name = "dg_disponibilidad";
            this.dg_disponibilidad.ReadOnly = true;
            this.dg_disponibilidad.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_disponibilidad.Size = new System.Drawing.Size(725, 155);
            this.dg_disponibilidad.TabIndex = 1;
            this.dg_disponibilidad.Visible = false;
            this.dg_disponibilidad.SelectionChanged += new System.EventHandler(this.dg_disponibilidad_SelectionChanged);
            // 
            // Container_disponibilidad
            // 
            this.Container_disponibilidad.Controls.Add(this.dg_disponibilidad);
            this.Container_disponibilidad.Location = new System.Drawing.Point(12, 144);
            this.Container_disponibilidad.Name = "Container_disponibilidad";
            this.Container_disponibilidad.Size = new System.Drawing.Size(737, 185);
            this.Container_disponibilidad.TabIndex = 2;
            this.Container_disponibilidad.TabStop = false;
            this.Container_disponibilidad.Text = "Disponibilidad";
            this.Container_disponibilidad.Visible = false;
            // 
            // Container_pasajero
            // 
            this.Container_pasajero.Controls.Add(this.btn_buscar);
            this.Container_pasajero.Location = new System.Drawing.Point(12, 335);
            this.Container_pasajero.Name = "Container_pasajero";
            this.Container_pasajero.Size = new System.Drawing.Size(737, 60);
            this.Container_pasajero.TabIndex = 3;
            this.Container_pasajero.TabStop = false;
            this.Container_pasajero.Text = "Pasajero";
            this.Container_pasajero.Visible = false;
            // 
            // btn_buscar
            // 
            this.btn_buscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_buscar.Location = new System.Drawing.Point(166, 19);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(377, 25);
            this.btn_buscar.TabIndex = 34;
            this.btn_buscar.Text = "Buscar Pasajero";
            this.btn_buscar.UseVisualStyleBackColor = false;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // Container_Detalle_Reserva
            // 
            this.Container_Detalle_Reserva.Controls.Add(this.btn_confirmar_reserva);
            this.Container_Detalle_Reserva.Controls.Add(this.txt_reserva_total);
            this.Container_Detalle_Reserva.Controls.Add(this.label10);
            this.Container_Detalle_Reserva.Controls.Add(this.txt_reserva_habitacion);
            this.Container_Detalle_Reserva.Controls.Add(this.label8);
            this.Container_Detalle_Reserva.Controls.Add(this.txt_reserva_fechas);
            this.Container_Detalle_Reserva.Controls.Add(this.txt_reserva_pasajero);
            this.Container_Detalle_Reserva.Controls.Add(this.label6);
            this.Container_Detalle_Reserva.Controls.Add(this.label7);
            this.Container_Detalle_Reserva.Location = new System.Drawing.Point(12, 401);
            this.Container_Detalle_Reserva.Name = "Container_Detalle_Reserva";
            this.Container_Detalle_Reserva.Size = new System.Drawing.Size(737, 119);
            this.Container_Detalle_Reserva.TabIndex = 35;
            this.Container_Detalle_Reserva.TabStop = false;
            this.Container_Detalle_Reserva.Text = "Detalle de la Reserva";
            this.Container_Detalle_Reserva.Visible = false;
            // 
            // txt_reserva_total
            // 
            this.txt_reserva_total.AutoSize = true;
            this.txt_reserva_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.txt_reserva_total.Location = new System.Drawing.Point(511, 56);
            this.txt_reserva_total.Name = "txt_reserva_total";
            this.txt_reserva_total.Size = new System.Drawing.Size(53, 20);
            this.txt_reserva_total.TabIndex = 20;
            this.txt_reserva_total.Text = "label9";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(414, 56);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Total Reserva:";
            // 
            // txt_reserva_habitacion
            // 
            this.txt_reserva_habitacion.AutoSize = true;
            this.txt_reserva_habitacion.Location = new System.Drawing.Point(492, 30);
            this.txt_reserva_habitacion.Name = "txt_reserva_habitacion";
            this.txt_reserva_habitacion.Size = new System.Drawing.Size(35, 13);
            this.txt_reserva_habitacion.TabIndex = 18;
            this.txt_reserva_habitacion.Text = "label5";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(414, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Habitacion:";
            // 
            // txt_reserva_fechas
            // 
            this.txt_reserva_fechas.AutoSize = true;
            this.txt_reserva_fechas.Location = new System.Drawing.Point(208, 56);
            this.txt_reserva_fechas.Name = "txt_reserva_fechas";
            this.txt_reserva_fechas.Size = new System.Drawing.Size(97, 13);
            this.txt_reserva_fechas.TabIndex = 16;
            this.txt_reserva_fechas.Text = "txt_reserva_fechas";
            // 
            // txt_reserva_pasajero
            // 
            this.txt_reserva_pasajero.AutoSize = true;
            this.txt_reserva_pasajero.Location = new System.Drawing.Point(84, 30);
            this.txt_reserva_pasajero.Name = "txt_reserva_pasajero";
            this.txt_reserva_pasajero.Size = new System.Drawing.Size(105, 13);
            this.txt_reserva_pasajero.TabIndex = 15;
            this.txt_reserva_pasajero.Text = "txt_reserva_pasajero";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(184, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Fecha Ingreso / Fecha Egreso:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(18, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Pasajero:";
            // 
            // btn_confirmar_reserva
            // 
            this.btn_confirmar_reserva.BackColor = System.Drawing.Color.Lime;
            this.btn_confirmar_reserva.Location = new System.Drawing.Point(252, 85);
            this.btn_confirmar_reserva.Name = "btn_confirmar_reserva";
            this.btn_confirmar_reserva.Size = new System.Drawing.Size(202, 23);
            this.btn_confirmar_reserva.TabIndex = 6;
            this.btn_confirmar_reserva.Text = "Confirmar Reserva";
            this.btn_confirmar_reserva.UseVisualStyleBackColor = false;
            // 
            // Reserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 530);
            this.Controls.Add(this.Container_Detalle_Reserva);
            this.Controls.Add(this.Container_pasajero);
            this.Controls.Add(this.Container_disponibilidad);
            this.Controls.Add(this.groupBox1);
            this.Name = "Reserva";
            this.Text = "Reservas";
            this.Activated += new System.EventHandler(this.Reserva_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Reserva_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_disponibilidad)).EndInit();
            this.Container_disponibilidad.ResumeLayout(false);
            this.Container_pasajero.ResumeLayout(false);
            this.Container_Detalle_Reserva.ResumeLayout(false);
            this.Container_Detalle_Reserva.PerformLayout();
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
        private System.Windows.Forms.GroupBox Container_disponibilidad;
        private System.Windows.Forms.GroupBox Container_pasajero;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.GroupBox Container_Detalle_Reserva;
        private System.Windows.Forms.Label txt_reserva_pasajero;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label txt_reserva_fechas;
        private System.Windows.Forms.Label txt_reserva_total;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label txt_reserva_habitacion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_confirmar_reserva;
    }
}