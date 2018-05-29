namespace FrbaHotel.AbmHotel
{
    partial class Hotel_Baja
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
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.txb_nombre = new System.Windows.Forms.TextBox();
            this.lbl_inicio = new System.Windows.Forms.Label();
            this.dtp_inicio = new System.Windows.Forms.DateTimePicker();
            this.dtp_fin = new System.Windows.Forms.DateTimePicker();
            this.lbl_fin = new System.Windows.Forms.Label();
            this.cmb_motivo = new System.Windows.Forms.ComboBox();
            this.lbl_motivo = new System.Windows.Forms.Label();
            this.btn_volver = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Location = new System.Drawing.Point(13, 29);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(44, 13);
            this.lbl_nombre.TabIndex = 0;
            this.lbl_nombre.Text = "Nombre";
            // 
            // txb_nombre
            // 
            this.txb_nombre.Location = new System.Drawing.Point(16, 45);
            this.txb_nombre.Name = "txb_nombre";
            this.txb_nombre.ReadOnly = true;
            this.txb_nombre.Size = new System.Drawing.Size(155, 20);
            this.txb_nombre.TabIndex = 1;
            // 
            // lbl_inicio
            // 
            this.lbl_inicio.AutoSize = true;
            this.lbl_inicio.Location = new System.Drawing.Point(18, 82);
            this.lbl_inicio.Name = "lbl_inicio";
            this.lbl_inicio.Size = new System.Drawing.Size(65, 13);
            this.lbl_inicio.TabIndex = 2;
            this.lbl_inicio.Text = "Fecha Inicio";
            // 
            // dtp_inicio
            // 
            this.dtp_inicio.Location = new System.Drawing.Point(90, 81);
            this.dtp_inicio.MinDate = new System.DateTime(2018, 5, 22, 0, 0, 0, 0);
            this.dtp_inicio.Name = "dtp_inicio";
            this.dtp_inicio.Size = new System.Drawing.Size(154, 20);
            this.dtp_inicio.TabIndex = 3;
            // 
            // dtp_fin
            // 
            this.dtp_fin.Location = new System.Drawing.Point(90, 112);
            this.dtp_fin.MinDate = new System.DateTime(2018, 5, 22, 0, 0, 0, 0);
            this.dtp_fin.Name = "dtp_fin";
            this.dtp_fin.Size = new System.Drawing.Size(154, 20);
            this.dtp_fin.TabIndex = 5;
            // 
            // lbl_fin
            // 
            this.lbl_fin.AutoSize = true;
            this.lbl_fin.Location = new System.Drawing.Point(18, 113);
            this.lbl_fin.Name = "lbl_fin";
            this.lbl_fin.Size = new System.Drawing.Size(54, 13);
            this.lbl_fin.TabIndex = 4;
            this.lbl_fin.Text = "Fecha Fin";
            // 
            // cmb_motivo
            // 
            this.cmb_motivo.FormattingEnabled = true;
            this.cmb_motivo.Items.AddRange(new object[] {
            "Reformas",
            "Ampliaciones"});
            this.cmb_motivo.Location = new System.Drawing.Point(21, 175);
            this.cmb_motivo.Name = "cmb_motivo";
            this.cmb_motivo.Size = new System.Drawing.Size(219, 21);
            this.cmb_motivo.TabIndex = 6;
            // 
            // lbl_motivo
            // 
            this.lbl_motivo.AutoSize = true;
            this.lbl_motivo.Location = new System.Drawing.Point(18, 159);
            this.lbl_motivo.Name = "lbl_motivo";
            this.lbl_motivo.Size = new System.Drawing.Size(39, 13);
            this.lbl_motivo.TabIndex = 7;
            this.lbl_motivo.Text = "Motivo";
            // 
            // btn_volver
            // 
            this.btn_volver.Location = new System.Drawing.Point(173, 224);
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.Size = new System.Drawing.Size(99, 25);
            this.btn_volver.TabIndex = 54;
            this.btn_volver.Text = "Volver";
            this.btn_volver.UseVisualStyleBackColor = true;
            this.btn_volver.Click += new System.EventHandler(this.btn_volver_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(62, 224);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(100, 26);
            this.btn_guardar.TabIndex = 53;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // Hotel_Baja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btn_volver);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.lbl_motivo);
            this.Controls.Add(this.cmb_motivo);
            this.Controls.Add(this.dtp_fin);
            this.Controls.Add(this.lbl_fin);
            this.Controls.Add(this.dtp_inicio);
            this.Controls.Add(this.lbl_inicio);
            this.Controls.Add(this.txb_nombre);
            this.Controls.Add(this.lbl_nombre);
            this.Name = "Hotel_Baja";
            this.Text = "Baja Hotel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.TextBox txb_nombre;
        private System.Windows.Forms.Label lbl_inicio;
        private System.Windows.Forms.DateTimePicker dtp_inicio;
        private System.Windows.Forms.DateTimePicker dtp_fin;
        private System.Windows.Forms.Label lbl_fin;
        private System.Windows.Forms.ComboBox cmb_motivo;
        private System.Windows.Forms.Label lbl_motivo;
        private System.Windows.Forms.Button btn_volver;
        private System.Windows.Forms.Button btn_guardar;
    }
}