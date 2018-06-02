﻿namespace FrbaHotel.AbmRol
{
    partial class AltaRol
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
            this.clb_funcionalidades = new System.Windows.Forms.CheckedListBox();
            this.lbl_fun = new System.Windows.Forms.Label();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_volver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Location = new System.Drawing.Point(20, 9);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(80, 13);
            this.lbl_nombre.TabIndex = 0;
            this.lbl_nombre.Text = "Nombre del Rol";
            // 
            // txb_nombre
            // 
            this.txb_nombre.Location = new System.Drawing.Point(23, 36);
            this.txb_nombre.Name = "txb_nombre";
            this.txb_nombre.Size = new System.Drawing.Size(209, 20);
            this.txb_nombre.TabIndex = 1;
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
            this.clb_funcionalidades.Location = new System.Drawing.Point(26, 90);
            this.clb_funcionalidades.Name = "clb_funcionalidades";
            this.clb_funcionalidades.Size = new System.Drawing.Size(206, 94);
            this.clb_funcionalidades.TabIndex = 2;
            // 
            // lbl_fun
            // 
            this.lbl_fun.AutoSize = true;
            this.lbl_fun.Location = new System.Drawing.Point(26, 71);
            this.lbl_fun.Name = "lbl_fun";
            this.lbl_fun.Size = new System.Drawing.Size(84, 13);
            this.lbl_fun.TabIndex = 3;
            this.lbl_fun.Text = "Funcionalidades";
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(82, 205);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(111, 32);
            this.btn_guardar.TabIndex = 4;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btn_volver
            // 
            this.btn_volver.Image = global::FrbaHotel.Properties.Resources.volver;
            this.btn_volver.Location = new System.Drawing.Point(237, 220);
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.Size = new System.Drawing.Size(35, 29);
            this.btn_volver.TabIndex = 6;
            this.btn_volver.UseVisualStyleBackColor = true;
            this.btn_volver.Click += new System.EventHandler(this.btn_volver_Click);
            // 
            // AltaRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btn_volver);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.lbl_fun);
            this.Controls.Add(this.clb_funcionalidades);
            this.Controls.Add(this.txb_nombre);
            this.Controls.Add(this.lbl_nombre);
            this.Name = "AltaRol";
            this.Text = "Nuevo Rol";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.TextBox txb_nombre;
        private System.Windows.Forms.CheckedListBox clb_funcionalidades;
        private System.Windows.Forms.Label lbl_fun;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_volver;
    }
}