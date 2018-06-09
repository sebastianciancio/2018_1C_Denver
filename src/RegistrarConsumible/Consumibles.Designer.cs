namespace FrbaHotel
{
    partial class Consumibles
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
            this.cmb_cantidad = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_productos = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_habitaciones = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.btn_confirmar = new System.Windows.Forms.Button();
            this.Container_consumos = new System.Windows.Forms.GroupBox();
            this.dg_consumos = new System.Windows.Forms.DataGridView();
            this.Container_consumos_nuevos = new System.Windows.Forms.GroupBox();
            this.dg_consumos_nuevos = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.Container_consumos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_consumos)).BeginInit();
            this.Container_consumos_nuevos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_consumos_nuevos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmb_cantidad);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmb_productos);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmb_habitaciones);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_agregar);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Size = new System.Drawing.Size(812, 69);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nuevos Consumos";
            // 
            // cmb_cantidad
            // 
            this.cmb_cantidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_cantidad.FormattingEnabled = true;
            this.cmb_cantidad.Location = new System.Drawing.Point(587, 28);
            this.cmb_cantidad.Name = "cmb_cantidad";
            this.cmb_cantidad.Size = new System.Drawing.Size(68, 21);
            this.cmb_cantidad.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(532, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Cantidad";
            // 
            // cmb_productos
            // 
            this.cmb_productos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_productos.FormattingEnabled = true;
            this.cmb_productos.Location = new System.Drawing.Point(392, 28);
            this.cmb_productos.Name = "cmb_productos";
            this.cmb_productos.Size = new System.Drawing.Size(121, 21);
            this.cmb_productos.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Habitación";
            // 
            // cmb_habitaciones
            // 
            this.cmb_habitaciones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_habitaciones.FormattingEnabled = true;
            this.cmb_habitaciones.Location = new System.Drawing.Point(131, 28);
            this.cmb_habitaciones.Name = "cmb_habitaciones";
            this.cmb_habitaciones.Size = new System.Drawing.Size(121, 21);
            this.cmb_habitaciones.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(276, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Producto y/o Servicio";
            // 
            // btn_agregar
            // 
            this.btn_agregar.Location = new System.Drawing.Point(689, 28);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(75, 23);
            this.btn_agregar.TabIndex = 0;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // btn_confirmar
            // 
            this.btn_confirmar.BackColor = System.Drawing.Color.Lime;
            this.btn_confirmar.Location = new System.Drawing.Point(442, 459);
            this.btn_confirmar.Name = "btn_confirmar";
            this.btn_confirmar.Size = new System.Drawing.Size(355, 29);
            this.btn_confirmar.TabIndex = 9;
            this.btn_confirmar.Text = "Confirmar Consumos Nuevos";
            this.btn_confirmar.UseVisualStyleBackColor = false;
            // 
            // Container_consumos
            // 
            this.Container_consumos.Controls.Add(this.dg_consumos);
            this.Container_consumos.Location = new System.Drawing.Point(12, 87);
            this.Container_consumos.Name = "Container_consumos";
            this.Container_consumos.Size = new System.Drawing.Size(386, 366);
            this.Container_consumos.TabIndex = 9;
            this.Container_consumos.TabStop = false;
            this.Container_consumos.Text = "Consumos registrados";
            this.Container_consumos.Visible = false;
            // 
            // dg_consumos
            // 
            this.dg_consumos.AllowUserToAddRows = false;
            this.dg_consumos.AllowUserToDeleteRows = false;
            this.dg_consumos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_consumos.Location = new System.Drawing.Point(6, 19);
            this.dg_consumos.Name = "dg_consumos";
            this.dg_consumos.ReadOnly = true;
            this.dg_consumos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_consumos.Size = new System.Drawing.Size(374, 341);
            this.dg_consumos.TabIndex = 1;
            this.dg_consumos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_consumos_CellContentClick);
            // 
            // Container_consumos_nuevos
            // 
            this.Container_consumos_nuevos.Controls.Add(this.dg_consumos_nuevos);
            this.Container_consumos_nuevos.Location = new System.Drawing.Point(404, 87);
            this.Container_consumos_nuevos.Name = "Container_consumos_nuevos";
            this.Container_consumos_nuevos.Size = new System.Drawing.Size(420, 366);
            this.Container_consumos_nuevos.TabIndex = 10;
            this.Container_consumos_nuevos.TabStop = false;
            this.Container_consumos_nuevos.Text = "Consumos nuevos";
            this.Container_consumos_nuevos.Visible = false;
            // 
            // dg_consumos_nuevos
            // 
            this.dg_consumos_nuevos.AllowUserToAddRows = false;
            this.dg_consumos_nuevos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_consumos_nuevos.Location = new System.Drawing.Point(7, 19);
            this.dg_consumos_nuevos.Name = "dg_consumos_nuevos";
            this.dg_consumos_nuevos.ReadOnly = true;
            this.dg_consumos_nuevos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_consumos_nuevos.Size = new System.Drawing.Size(407, 341);
            this.dg_consumos_nuevos.TabIndex = 1;
            // 
            // Consumibles
            // 
            this.AcceptButton = this.btn_agregar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 492);
            this.Controls.Add(this.Container_consumos_nuevos);
            this.Controls.Add(this.Container_consumos);
            this.Controls.Add(this.btn_confirmar);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Consumibles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consumos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Container_consumos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_consumos)).EndInit();
            this.Container_consumos_nuevos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_consumos_nuevos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.ComboBox cmb_cantidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_productos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_habitaciones;
        private System.Windows.Forms.Button btn_confirmar;
        private System.Windows.Forms.GroupBox Container_consumos;
        private System.Windows.Forms.DataGridView dg_consumos;
        private System.Windows.Forms.GroupBox Container_consumos_nuevos;
        private System.Windows.Forms.DataGridView dg_consumos_nuevos;
    }
}