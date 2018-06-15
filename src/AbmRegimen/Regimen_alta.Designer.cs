namespace FrbaHotel.AbmRegimen
{
    partial class Regimen_alta
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
            this.components = new System.ComponentModel.Container();
            this.lbl_fun = new System.Windows.Forms.Label();
            this.txb_nombre = new System.Windows.Forms.TextBox();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.txb_precio = new System.Windows.Forms.TextBox();
            this.cb_activar = new System.Windows.Forms.CheckBox();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_fun
            // 
            this.lbl_fun.AutoSize = true;
            this.lbl_fun.Location = new System.Drawing.Point(12, 82);
            this.lbl_fun.Name = "lbl_fun";
            this.lbl_fun.Size = new System.Drawing.Size(120, 13);
            this.lbl_fun.TabIndex = 6;
            this.lbl_fun.Text = "Precio base en  Dólares";
            // 
            // txb_nombre
            // 
            this.txb_nombre.Location = new System.Drawing.Point(12, 47);
            this.txb_nombre.MaxLength = 255;
            this.txb_nombre.Name = "txb_nombre";
            this.txb_nombre.Size = new System.Drawing.Size(209, 20);
            this.txb_nombre.TabIndex = 5;
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Location = new System.Drawing.Point(9, 20);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(106, 13);
            this.lbl_nombre.TabIndex = 4;
            this.lbl_nombre.Text = "Nombre del Regimen";
            // 
            // txb_precio
            // 
            this.txb_precio.Location = new System.Drawing.Point(15, 110);
            this.txb_precio.MaxLength = 21;
            this.txb_precio.Name = "txb_precio";
            this.txb_precio.Size = new System.Drawing.Size(78, 20);
            this.txb_precio.TabIndex = 7;
            // 
            // cb_activar
            // 
            this.cb_activar.AutoSize = true;
            this.cb_activar.Location = new System.Drawing.Point(16, 149);
            this.cb_activar.Name = "cb_activar";
            this.cb_activar.Size = new System.Drawing.Size(72, 17);
            this.cb_activar.TabIndex = 8;
            this.cb_activar.Text = "ACTIVAR";
            this.cb_activar.UseVisualStyleBackColor = true;
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(25, 194);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(89, 30);
            this.btn_guardar.TabIndex = 9;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(149, 194);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(89, 30);
            this.btn_cancelar.TabIndex = 10;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // Regimen_alta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 232);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.cb_activar);
            this.Controls.Add(this.txb_precio);
            this.Controls.Add(this.lbl_fun);
            this.Controls.Add(this.txb_nombre);
            this.Controls.Add(this.lbl_nombre);
            this.Name = "Regimen_alta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Regimen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_fun;
        public System.Windows.Forms.TextBox txb_nombre;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.ToolTip toolTip1;
        public System.Windows.Forms.TextBox txb_precio;
        private System.Windows.Forms.CheckBox cb_activar;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_cancelar;
    }
}