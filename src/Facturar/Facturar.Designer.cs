namespace FrbaHotel
{
    partial class Facturar
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
            this.btn_buscar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Container_facturacion = new System.Windows.Forms.GroupBox();
            this.dg_consumos_facturar = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.fecha_hasta = new System.Windows.Forms.DateTimePicker();
            this.cmb_tipo_doc = new System.Windows.Forms.ComboBox();
            this.nro_documento = new System.Windows.Forms.TextBox();
            this.btn_facturar = new System.Windows.Forms.Button();
            this.cmb_forma_pago = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_detalle_pago = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Container_total = new System.Windows.Forms.GroupBox();
            this.label_total_facturar = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.Container_facturacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_consumos_facturar)).BeginInit();
            this.panel1.SuspendLayout();
            this.Container_total.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.fecha_hasta);
            this.groupBox1.Controls.Add(this.cmb_tipo_doc);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.nro_documento);
            this.groupBox1.Controls.Add(this.btn_buscar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(691, 86);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Pasajero";
            // 
            // btn_buscar
            // 
            this.btn_buscar.BackColor = System.Drawing.Color.Lime;
            this.btn_buscar.Location = new System.Drawing.Point(193, 57);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(303, 23);
            this.btn_buscar.TabIndex = 2;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = false;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(225, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nro";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo Documento";
            // 
            // Container_facturacion
            // 
            this.Container_facturacion.Controls.Add(this.Container_total);
            this.Container_facturacion.Controls.Add(this.panel1);
            this.Container_facturacion.Controls.Add(this.cmb_forma_pago);
            this.Container_facturacion.Controls.Add(this.btn_facturar);
            this.Container_facturacion.Controls.Add(this.label3);
            this.Container_facturacion.Controls.Add(this.dg_consumos_facturar);
            this.Container_facturacion.Location = new System.Drawing.Point(12, 104);
            this.Container_facturacion.Name = "Container_facturacion";
            this.Container_facturacion.Size = new System.Drawing.Size(691, 407);
            this.Container_facturacion.TabIndex = 5;
            this.Container_facturacion.TabStop = false;
            this.Container_facturacion.Text = "Detalle a Facturar";
            this.Container_facturacion.Visible = false;
            // 
            // dg_consumos_facturar
            // 
            this.dg_consumos_facturar.AllowUserToAddRows = false;
            this.dg_consumos_facturar.AllowUserToDeleteRows = false;
            this.dg_consumos_facturar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_consumos_facturar.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dg_consumos_facturar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_consumos_facturar.Location = new System.Drawing.Point(6, 19);
            this.dg_consumos_facturar.MultiSelect = false;
            this.dg_consumos_facturar.Name = "dg_consumos_facturar";
            this.dg_consumos_facturar.ReadOnly = true;
            this.dg_consumos_facturar.Size = new System.Drawing.Size(676, 228);
            this.dg_consumos_facturar.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(388, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Fecha Egreso";
            // 
            // fecha_hasta
            // 
            this.fecha_hasta.CustomFormat = "dd/MM/yyyy";
            this.fecha_hasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fecha_hasta.Location = new System.Drawing.Point(467, 23);
            this.fecha_hasta.Name = "fecha_hasta";
            this.fecha_hasta.Size = new System.Drawing.Size(200, 20);
            this.fecha_hasta.TabIndex = 9;
            // 
            // cmb_tipo_doc
            // 
            this.cmb_tipo_doc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_tipo_doc.FormattingEnabled = true;
            this.cmb_tipo_doc.Location = new System.Drawing.Point(98, 23);
            this.cmb_tipo_doc.Name = "cmb_tipo_doc";
            this.cmb_tipo_doc.Size = new System.Drawing.Size(121, 21);
            this.cmb_tipo_doc.TabIndex = 11;
            // 
            // nro_documento
            // 
            this.nro_documento.Location = new System.Drawing.Point(255, 23);
            this.nro_documento.Name = "nro_documento";
            this.nro_documento.Size = new System.Drawing.Size(111, 20);
            this.nro_documento.TabIndex = 10;
            // 
            // btn_facturar
            // 
            this.btn_facturar.BackColor = System.Drawing.Color.Lime;
            this.btn_facturar.Location = new System.Drawing.Point(193, 367);
            this.btn_facturar.Name = "btn_facturar";
            this.btn_facturar.Size = new System.Drawing.Size(303, 23);
            this.btn_facturar.TabIndex = 12;
            this.btn_facturar.Text = "Facturar";
            this.btn_facturar.UseVisualStyleBackColor = false;
            this.btn_facturar.Click += new System.EventHandler(this.btn_facturar_Click);
            // 
            // cmb_forma_pago
            // 
            this.cmb_forma_pago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_forma_pago.FormattingEnabled = true;
            this.cmb_forma_pago.Location = new System.Drawing.Point(98, 320);
            this.cmb_forma_pago.Name = "cmb_forma_pago";
            this.cmb_forma_pago.Size = new System.Drawing.Size(179, 21);
            this.cmb_forma_pago.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 325);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Forma de Pago";
            // 
            // txt_detalle_pago
            // 
            this.txt_detalle_pago.Location = new System.Drawing.Point(49, 3);
            this.txt_detalle_pago.Name = "txt_detalle_pago";
            this.txt_detalle_pago.Size = new System.Drawing.Size(334, 20);
            this.txt_detalle_pago.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Detalle";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_detalle_pago);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(295, 318);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(386, 30);
            this.panel1.TabIndex = 14;
            // 
            // Container_total
            // 
            this.Container_total.Controls.Add(this.label_total_facturar);
            this.Container_total.Location = new System.Drawing.Point(6, 253);
            this.Container_total.Name = "Container_total";
            this.Container_total.Size = new System.Drawing.Size(675, 45);
            this.Container_total.TabIndex = 15;
            this.Container_total.TabStop = false;
            this.Container_total.Text = "Total a Facturar";
            // 
            // label_total_facturar
            // 
            this.label_total_facturar.AutoSize = true;
            this.label_total_facturar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_total_facturar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label_total_facturar.Location = new System.Drawing.Point(3, 16);
            this.label_total_facturar.Name = "label_total_facturar";
            this.label_total_facturar.Size = new System.Drawing.Size(163, 22);
            this.label_total_facturar.TabIndex = 14;
            this.label_total_facturar.Text = "label_total_facturar";
            // 
            // Facturar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 523);
            this.Controls.Add(this.Container_facturacion);
            this.Controls.Add(this.groupBox1);
            this.Name = "Facturar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facturar";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Container_facturacion.ResumeLayout(false);
            this.Container_facturacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_consumos_facturar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Container_total.ResumeLayout(false);
            this.Container_total.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.GroupBox Container_facturacion;
        private System.Windows.Forms.DataGridView dg_consumos_facturar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker fecha_hasta;
        private System.Windows.Forms.ComboBox cmb_tipo_doc;
        private System.Windows.Forms.TextBox nro_documento;
        private System.Windows.Forms.Button btn_facturar;
        private System.Windows.Forms.GroupBox Container_total;
        private System.Windows.Forms.Label label_total_facturar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_detalle_pago;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmb_forma_pago;
        private System.Windows.Forms.Label label3;
    }
}