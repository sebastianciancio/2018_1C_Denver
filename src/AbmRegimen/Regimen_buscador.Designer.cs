﻿namespace FrbaHotel.AbmRegimen
{
    partial class Regimen_buscador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Regimen_buscador));
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_modif = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmb_estado = new System.Windows.Forms.ComboBox();
            this.txb_nombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LBLnombre = new System.Windows.Forms.Label();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.dgv_tablaCliente = new System.Windows.Forms.DataGridView();
            this.btt_add_usuario = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tablaCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(721, 186);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(86, 26);
            this.btn_eliminar.TabIndex = 21;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Visible = false;
            // 
            // btn_modif
            // 
            this.btn_modif.Location = new System.Drawing.Point(719, 129);
            this.btn_modif.Name = "btn_modif";
            this.btn_modif.Size = new System.Drawing.Size(88, 29);
            this.btn_modif.TabIndex = 19;
            this.btn_modif.Text = "Modificar";
            this.btn_modif.UseVisualStyleBackColor = true;
            this.btn_modif.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmb_estado);
            this.groupBox1.Controls.Add(this.txb_nombre);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.LBLnombre);
            this.groupBox1.Controls.Add(this.btn_buscar);
            this.groupBox1.Location = new System.Drawing.Point(104, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(703, 83);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscador";
            // 
            // cmb_estado
            // 
            this.cmb_estado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_estado.FormattingEnabled = true;
            this.cmb_estado.Location = new System.Drawing.Point(408, 41);
            this.cmb_estado.Name = "cmb_estado";
            this.cmb_estado.Size = new System.Drawing.Size(141, 21);
            this.cmb_estado.TabIndex = 12;
            // 
            // txb_nombre
            // 
            this.txb_nombre.Location = new System.Drawing.Point(13, 41);
            this.txb_nombre.MaxLength = 100;
            this.txb_nombre.Name = "txb_nombre";
            this.txb_nombre.Size = new System.Drawing.Size(378, 20);
            this.txb_nombre.TabIndex = 0;
            this.txb_nombre.Tag = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(405, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Estado";
            // 
            // LBLnombre
            // 
            this.LBLnombre.AutoSize = true;
            this.LBLnombre.Location = new System.Drawing.Point(10, 22);
            this.LBLnombre.Name = "LBLnombre";
            this.LBLnombre.Size = new System.Drawing.Size(44, 13);
            this.LBLnombre.TabIndex = 2;
            this.LBLnombre.Text = "Nombre";
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(561, 39);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(120, 25);
            this.btn_buscar.TabIndex = 3;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            // 
            // dgv_tablaCliente
            // 
            this.dgv_tablaCliente.AllowUserToDeleteRows = false;
            this.dgv_tablaCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tablaCliente.Location = new System.Drawing.Point(11, 113);
            this.dgv_tablaCliente.MultiSelect = false;
            this.dgv_tablaCliente.Name = "dgv_tablaCliente";
            this.dgv_tablaCliente.ReadOnly = true;
            this.dgv_tablaCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_tablaCliente.Size = new System.Drawing.Size(694, 287);
            this.dgv_tablaCliente.TabIndex = 18;
            this.dgv_tablaCliente.Visible = false;
            // 
            // btt_add_usuario
            // 
            this.btt_add_usuario.Image = ((System.Drawing.Image)(resources.GetObject("btt_add_usuario.Image")));
            this.btt_add_usuario.Location = new System.Drawing.Point(12, 23);
            this.btt_add_usuario.Name = "btt_add_usuario";
            this.btt_add_usuario.Size = new System.Drawing.Size(82, 64);
            this.btt_add_usuario.TabIndex = 20;
            this.btt_add_usuario.Text = ".";
            this.btt_add_usuario.UseVisualStyleBackColor = true;
            // 
            // Regimen_buscador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 413);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_modif);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btt_add_usuario);
            this.Controls.Add(this.dgv_tablaCliente);
            this.Name = "Regimen_buscador";
            this.Text = "Regimen";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tablaCliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_modif;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmb_estado;
        private System.Windows.Forms.TextBox txb_nombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LBLnombre;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Button btt_add_usuario;
        private System.Windows.Forms.DataGridView dgv_tablaCliente;
    }
}