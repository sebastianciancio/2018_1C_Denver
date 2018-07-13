namespace FrbaHotel
{
    partial class accesoSistema
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(accesoSistema));
            this.btn_nueva = new System.Windows.Forms.Button();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.btn_volver = new System.Windows.Forms.Button();
            this.btn_sistema = new System.Windows.Forms.Button();
            this.btn_reserva = new System.Windows.Forms.Button();
            this.btn_canc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_nueva
            // 
            this.btn_nueva.Enabled = false;
            this.btn_nueva.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_nueva.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nueva.Location = new System.Drawing.Point(171, 12);
            this.btn_nueva.Name = "btn_nueva";
            this.btn_nueva.Size = new System.Drawing.Size(212, 52);
            this.btn_nueva.TabIndex = 2;
            this.btn_nueva.Text = "Reservar";
            this.btn_nueva.UseVisualStyleBackColor = true;
            this.btn_nueva.Visible = false;
            this.btn_nueva.Click += new System.EventHandler(this.btn_nueva_Click);
            // 
            // btn_modificar
            // 
            this.btn_modificar.Enabled = false;
            this.btn_modificar.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modificar.Location = new System.Drawing.Point(171, 89);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(208, 51);
            this.btn_modificar.TabIndex = 3;
            this.btn_modificar.Text = "Modificar Reserva";
            this.btn_modificar.UseVisualStyleBackColor = true;
            this.btn_modificar.Visible = false;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // btn_volver
            // 
            this.btn_volver.Enabled = false;
            this.btn_volver.Image = global::FrbaHotel.Properties.Resources.volver;
            this.btn_volver.Location = new System.Drawing.Point(467, 200);
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.Size = new System.Drawing.Size(63, 56);
            this.btn_volver.TabIndex = 4;
            this.btn_volver.Text = "c";
            this.btn_volver.UseVisualStyleBackColor = true;
            this.btn_volver.Visible = false;
            this.btn_volver.Click += new System.EventHandler(this.btn_volver_Click);
            // 
            // btn_sistema
            // 
            this.btn_sistema.BackColor = System.Drawing.Color.White;
            this.btn_sistema.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sistema.Image = ((System.Drawing.Image)(resources.GetObject("btn_sistema.Image")));
            this.btn_sistema.Location = new System.Drawing.Point(277, 20);
            this.btn_sistema.Name = "btn_sistema";
            this.btn_sistema.Size = new System.Drawing.Size(226, 223);
            this.btn_sistema.TabIndex = 1;
            this.btn_sistema.Text = "Acceder al Sistema";
            this.btn_sistema.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_sistema.UseVisualStyleBackColor = false;
            this.btn_sistema.Click += new System.EventHandler(this.btn_sistema_Click);
            // 
            // btn_reserva
            // 
            this.btn_reserva.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_reserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reserva.Image = ((System.Drawing.Image)(resources.GetObject("btn_reserva.Image")));
            this.btn_reserva.Location = new System.Drawing.Point(22, 22);
            this.btn_reserva.Name = "btn_reserva";
            this.btn_reserva.Size = new System.Drawing.Size(229, 222);
            this.btn_reserva.TabIndex = 0;
            this.btn_reserva.Text = "Gestion de Reservas";
            this.btn_reserva.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_reserva.UseVisualStyleBackColor = false;
            this.btn_reserva.Click += new System.EventHandler(this.btn_reserva_Click);
            // 
            // btn_canc
            // 
            this.btn_canc.Enabled = false;
            this.btn_canc.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_canc.Location = new System.Drawing.Point(171, 169);
            this.btn_canc.Name = "btn_canc";
            this.btn_canc.Size = new System.Drawing.Size(208, 51);
            this.btn_canc.TabIndex = 5;
            this.btn_canc.Text = "Cancelar Reserva";
            this.btn_canc.UseVisualStyleBackColor = true;
            this.btn_canc.Visible = false;
            this.btn_canc.Click += new System.EventHandler(this.btn_canc_Click);
            // 
            // accesoSistema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(531, 257);
            this.Controls.Add(this.btn_sistema);
            this.Controls.Add(this.btn_reserva);
            this.Controls.Add(this.btn_nueva);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.btn_volver);
            this.Controls.Add(this.btn_canc);
            this.Name = "accesoSistema";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bienvenidos a Hoteles Denver";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.accesoSistema_FormClosing);

            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_reserva;
        private System.Windows.Forms.Button btn_sistema;
        private System.Windows.Forms.Button btn_nueva;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Button btn_volver;
        private System.Windows.Forms.Button btn_canc;
    }
}