namespace FrbaHotel
{
    partial class Listados
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
            this.btn_consultar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_tipo_reporte = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_trimestre = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_anio = new System.Windows.Forms.ComboBox();
            this.Container_reporte = new System.Windows.Forms.GroupBox();
            this.dg_reporte = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.Container_reporte.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_reporte)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.btn_consultar);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmb_tipo_reporte);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmb_trimestre);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmb_anio);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(765, 80);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Consulta";
            // 
            // btn_consultar
            // 
            this.btn_consultar.Location = new System.Drawing.Point(667, 38);
            this.btn_consultar.Name = "btn_consultar";
            this.btn_consultar.Size = new System.Drawing.Size(75, 23);
            this.btn_consultar.TabIndex = 6;
            this.btn_consultar.Text = "Consultar";
            this.btn_consultar.UseVisualStyleBackColor = true;
            this.btn_consultar.Click += new System.EventHandler(this.btn_consultar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(299, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tipo de Reporte";
            // 
            // cmb_tipo_reporte
            // 
            this.cmb_tipo_reporte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_tipo_reporte.FormattingEnabled = true;
            this.cmb_tipo_reporte.Location = new System.Drawing.Point(389, 40);
            this.cmb_tipo_reporte.Name = "cmb_tipo_reporte";
            this.cmb_tipo_reporte.Size = new System.Drawing.Size(272, 21);
            this.cmb_tipo_reporte.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(151, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Trimestre";
            // 
            // cmb_trimestre
            // 
            this.cmb_trimestre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_trimestre.FormattingEnabled = true;
            this.cmb_trimestre.Location = new System.Drawing.Point(206, 40);
            this.cmb_trimestre.Name = "cmb_trimestre";
            this.cmb_trimestre.Size = new System.Drawing.Size(81, 21);
            this.cmb_trimestre.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Año";
            // 
            // cmb_anio
            // 
            this.cmb_anio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_anio.FormattingEnabled = true;
            this.cmb_anio.Location = new System.Drawing.Point(59, 40);
            this.cmb_anio.Name = "cmb_anio";
            this.cmb_anio.Size = new System.Drawing.Size(81, 21);
            this.cmb_anio.TabIndex = 0;
            // 
            // Container_reporte
            // 
            this.Container_reporte.Controls.Add(this.dg_reporte);
            this.Container_reporte.Location = new System.Drawing.Point(12, 98);
            this.Container_reporte.Name = "Container_reporte";
            this.Container_reporte.Size = new System.Drawing.Size(765, 422);
            this.Container_reporte.TabIndex = 7;
            this.Container_reporte.TabStop = false;
            this.Container_reporte.Text = "Reporte";
            this.Container_reporte.Visible = false;
            // 
            // dg_reporte
            // 
            this.dg_reporte.AllowUserToAddRows = false;
            this.dg_reporte.AllowUserToDeleteRows = false;
            this.dg_reporte.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_reporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_reporte.Location = new System.Drawing.Point(6, 21);
            this.dg_reporte.Name = "dg_reporte";
            this.dg_reporte.ReadOnly = true;
            this.dg_reporte.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_reporte.Size = new System.Drawing.Size(753, 387);
            this.dg_reporte.TabIndex = 1;
            // 
            // Listados
            // 
            this.AcceptButton = this.btn_consultar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 532);
            this.Controls.Add(this.Container_reporte);
            this.Controls.Add(this.groupBox1);
            this.Name = "Listados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listados";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Container_reporte.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_reporte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_tipo_reporte;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_trimestre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_anio;
        private System.Windows.Forms.Button btn_consultar;
        private System.Windows.Forms.GroupBox Container_reporte;
        private System.Windows.Forms.DataGridView dg_reporte;
    }
}