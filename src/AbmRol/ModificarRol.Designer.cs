namespace FrbaHotel.AbmRol
{
    partial class ModificarRol
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
            this.btn_volver = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.lbl_fun = new System.Windows.Forms.Label();
            this.clb_funcionalidades = new System.Windows.Forms.CheckedListBox();
            this.txb_nombre = new System.Windows.Forms.TextBox();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.btn_hab = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_volver
            // 
            this.btn_volver.Image = global::FrbaHotel.Properties.Resources.volver;
            this.btn_volver.Location = new System.Drawing.Point(255, 220);
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.Size = new System.Drawing.Size(35, 29);
            this.btn_volver.TabIndex = 12;
            this.btn_volver.UseVisualStyleBackColor = true;
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(12, 206);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(111, 32);
            this.btn_guardar.TabIndex = 11;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            // 
            // lbl_fun
            // 
            this.lbl_fun.AutoSize = true;
            this.lbl_fun.Location = new System.Drawing.Point(22, 72);
            this.lbl_fun.Name = "lbl_fun";
            this.lbl_fun.Size = new System.Drawing.Size(84, 13);
            this.lbl_fun.TabIndex = 10;
            this.lbl_fun.Text = "Funcionalidades";
            // 
            // clb_funcionalidades
            // 
            this.clb_funcionalidades.FormattingEnabled = true;
            this.clb_funcionalidades.Items.AddRange(new object[] {
            "Administracion Interna",
            "Operaciones",
            "ABM Clientes",
            "ABM Roles",
            "ABM Usuarios",
            "ABM Reservas",
            "ABM Hoteles",
            "ABM Habitacion"});
            this.clb_funcionalidades.Location = new System.Drawing.Point(22, 91);
            this.clb_funcionalidades.Name = "clb_funcionalidades";
            this.clb_funcionalidades.Size = new System.Drawing.Size(206, 94);
            this.clb_funcionalidades.TabIndex = 9;
            // 
            // txb_nombre
            // 
            this.txb_nombre.Location = new System.Drawing.Point(19, 37);
            this.txb_nombre.Name = "txb_nombre";
            this.txb_nombre.Size = new System.Drawing.Size(209, 20);
            this.txb_nombre.TabIndex = 8;
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Location = new System.Drawing.Point(16, 10);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(80, 13);
            this.lbl_nombre.TabIndex = 7;
            this.lbl_nombre.Text = "Nombre del Rol";
            // 
            // btn_hab
            // 
            this.btn_hab.Location = new System.Drawing.Point(146, 207);
            this.btn_hab.Name = "btn_hab";
            this.btn_hab.Size = new System.Drawing.Size(97, 30);
            this.btn_hab.TabIndex = 13;
            this.btn_hab.Text = "Deshabilitar";
            this.btn_hab.UseVisualStyleBackColor = true;
            // 
            // ModificarRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 261);
            this.Controls.Add(this.btn_hab);
            this.Controls.Add(this.btn_volver);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.lbl_fun);
            this.Controls.Add(this.clb_funcionalidades);
            this.Controls.Add(this.txb_nombre);
            this.Controls.Add(this.lbl_nombre);
            this.Name = "ModificarRol";
            this.Text = "ModificarRol";
            this.Load += new System.EventHandler(this.ModificarRol_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_volver;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Label lbl_fun;
        private System.Windows.Forms.CheckedListBox clb_funcionalidades;
        private System.Windows.Forms.TextBox txb_nombre;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Button btn_hab;
    }
}