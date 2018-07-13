namespace FrbaHotel.AbmRol
{
    partial class GestionRoles
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
            this.dgv_roles = new System.Windows.Forms.DataGridView();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.btn_nuevo = new System.Windows.Forms.Button();
            this.btn_volver = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_roles)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_roles
            // 
            this.dgv_roles.AllowUserToAddRows = false;
            this.dgv_roles.AllowUserToDeleteRows = false;
            this.dgv_roles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_roles.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgv_roles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_roles.Location = new System.Drawing.Point(33, 27);
            this.dgv_roles.MultiSelect = false;
            this.dgv_roles.Name = "dgv_roles";
            this.dgv_roles.ReadOnly = true;
            this.dgv_roles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_roles.Size = new System.Drawing.Size(329, 168);
            this.dgv_roles.TabIndex = 0;
            // 
            // btn_modificar
            // 
            this.btn_modificar.Location = new System.Drawing.Point(383, 56);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(103, 45);
            this.btn_modificar.TabIndex = 1;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.UseVisualStyleBackColor = true;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.Location = new System.Drawing.Point(38, 207);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(147, 42);
            this.btn_nuevo.TabIndex = 2;
            this.btn_nuevo.Text = "Nuevo Rol";
            this.btn_nuevo.UseVisualStyleBackColor = true;
            this.btn_nuevo.Click += new System.EventHandler(this.btn_nuevo_Click);
            // 
            // btn_volver
            // 
            this.btn_volver.Image = global::FrbaHotel.Properties.Resources.volver;
            this.btn_volver.Location = new System.Drawing.Point(441, 207);
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.Size = new System.Drawing.Size(45, 42);
            this.btn_volver.TabIndex = 5;
            this.btn_volver.UseVisualStyleBackColor = true;
            this.btn_volver.Click += new System.EventHandler(this.btn_volver_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(383, 117);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(103, 45);
            this.btn_eliminar.TabIndex = 6;
            this.btn_eliminar.Text = "Eliminar/Activar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // GestionRoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 261);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_volver);
            this.Controls.Add(this.dgv_roles);
            this.Controls.Add(this.btn_nuevo);
            this.Controls.Add(this.btn_modificar);
            this.MaximizeBox = false;
            this.Name = "GestionRoles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion De Roles";
            this.Load += new System.EventHandler(this.GestionRoles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_roles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_roles;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Button btn_nuevo;
        private System.Windows.Forms.Button btn_volver;
        private System.Windows.Forms.Button btn_eliminar;
    }
}