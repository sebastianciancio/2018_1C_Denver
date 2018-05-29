namespace FrbaHotel
{
    partial class Principal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btn_reserva = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_check = new System.Windows.Forms.Button();
            this.btn_facturar = new System.Windows.Forms.Button();
            this.btn_listados = new System.Windows.Forms.Button();
            this.btn_consumibles = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button11 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(324, 266);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 76);
            this.button1.TabIndex = 0;
            this.button1.Text = "Clientes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(22, 266);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 76);
            this.button2.TabIndex = 1;
            this.button2.Text = "Roles";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(173, 266);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(145, 76);
            this.button3.TabIndex = 2;
            this.button3.Text = "Usuarios";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(470, 266);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(140, 76);
            this.button4.TabIndex = 3;
            this.button4.Text = "Hoteles";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(616, 266);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(140, 76);
            this.button5.TabIndex = 4;
            this.button5.Text = "Habitaciones";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btn_reserva
            // 
            this.btn_reserva.BackColor = System.Drawing.Color.Lime;
            this.btn_reserva.Location = new System.Drawing.Point(22, 61);
            this.btn_reserva.Name = "btn_reserva";
            this.btn_reserva.Size = new System.Drawing.Size(140, 76);
            this.btn_reserva.TabIndex = 5;
            this.btn_reserva.Text = "Reservas";
            this.btn_reserva.UseVisualStyleBackColor = false;
            this.btn_reserva.Click += new System.EventHandler(this.button6_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Administración Interna";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_check
            // 
            this.btn_check.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_check.Location = new System.Drawing.Point(173, 61);
            this.btn_check.Name = "btn_check";
            this.btn_check.Size = new System.Drawing.Size(140, 76);
            this.btn_check.TabIndex = 7;
            this.btn_check.Text = "Check-In / Check-Out";
            this.btn_check.UseVisualStyleBackColor = false;
            // 
            // btn_facturar
            // 
            this.btn_facturar.BackColor = System.Drawing.Color.Lime;
            this.btn_facturar.Location = new System.Drawing.Point(465, 61);
            this.btn_facturar.Name = "btn_facturar";
            this.btn_facturar.Size = new System.Drawing.Size(140, 76);
            this.btn_facturar.TabIndex = 8;
            this.btn_facturar.Text = "Facturar";
            this.btn_facturar.UseVisualStyleBackColor = false;
            // 
            // btn_listados
            // 
            this.btn_listados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_listados.Location = new System.Drawing.Point(611, 61);
            this.btn_listados.Name = "btn_listados";
            this.btn_listados.Size = new System.Drawing.Size(140, 76);
            this.btn_listados.TabIndex = 9;
            this.btn_listados.Text = "Listados";
            this.btn_listados.UseVisualStyleBackColor = false;
            this.btn_listados.Click += new System.EventHandler(this.button9_Click);
            // 
            // btn_consumibles
            // 
            this.btn_consumibles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_consumibles.Location = new System.Drawing.Point(319, 61);
            this.btn_consumibles.Name = "btn_consumibles";
            this.btn_consumibles.Size = new System.Drawing.Size(140, 76);
            this.btn_consumibles.TabIndex = 10;
            this.btn_consumibles.Text = "Registrar Consumibles";
            this.btn_consumibles.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 29);
            this.label2.TabIndex = 11;
            this.label2.Text = "Operación";
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(762, 266);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(140, 76);
            this.button11.TabIndex = 12;
            this.button11.Text = "Régimen Estadía";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 354);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_consumibles);
            this.Controls.Add(this.btn_listados);
            this.Controls.Add(this.btn_facturar);
            this.Controls.Add(this.btn_check);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_reserva);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadena Denver - Sistema de Gestión";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Principal_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btn_reserva;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_check;
        private System.Windows.Forms.Button btn_facturar;
        private System.Windows.Forms.Button btn_listados;
        private System.Windows.Forms.Button btn_consumibles;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button11;
    }
}

