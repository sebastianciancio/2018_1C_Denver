namespace FrbaHotel.AbmUsuarios
{
    partial class Cambiar_pass
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
            this.lbl_actual = new System.Windows.Forms.Label();
            this.txb_actual = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txb_nueva = new System.Windows.Forms.TextBox();
            this.txb_repetir = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lbl_user = new System.Windows.Forms.Label();
            this.txb_user = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_actual
            // 
            this.lbl_actual.AutoSize = true;
            this.lbl_actual.Location = new System.Drawing.Point(12, 22);
            this.lbl_actual.Name = "lbl_actual";
            this.lbl_actual.Size = new System.Drawing.Size(94, 13);
            this.lbl_actual.TabIndex = 0;
            this.lbl_actual.Text = "Contraseña Actual";
            this.lbl_actual.Visible = false;
            // 
            // txb_actual
            // 
            this.txb_actual.Location = new System.Drawing.Point(13, 48);
            this.txb_actual.Name = "txb_actual";
            this.txb_actual.PasswordChar = '*';
            this.txb_actual.Size = new System.Drawing.Size(174, 20);
            this.txb_actual.TabIndex = 1;
            this.txb_actual.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nueva Contraseña";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Repetir Contraseña";
            // 
            // txb_nueva
            // 
            this.txb_nueva.Location = new System.Drawing.Point(15, 120);
            this.txb_nueva.Name = "txb_nueva";
            this.txb_nueva.PasswordChar = '*';
            this.txb_nueva.Size = new System.Drawing.Size(174, 20);
            this.txb_nueva.TabIndex = 4;
            // 
            // txb_repetir
            // 
            this.txb_repetir.Location = new System.Drawing.Point(12, 187);
            this.txb_repetir.Name = "txb_repetir";
            this.txb_repetir.PasswordChar = '*';
            this.txb_repetir.Size = new System.Drawing.Size(174, 20);
            this.txb_repetir.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(31, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 31);
            this.button1.TabIndex = 6;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(170, 226);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(78, 31);
            this.button2.TabIndex = 7;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbl_user
            // 
            this.lbl_user.AutoSize = true;
            this.lbl_user.Location = new System.Drawing.Point(12, 41);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(43, 13);
            this.lbl_user.TabIndex = 8;
            this.lbl_user.Text = "Usuario";
            this.lbl_user.Visible = false;
            // 
            // txb_user
            // 
            this.txb_user.Enabled = false;
            this.txb_user.Location = new System.Drawing.Point(88, 38);
            this.txb_user.Name = "txb_user";
            this.txb_user.Size = new System.Drawing.Size(101, 20);
            this.txb_user.TabIndex = 9;
            this.txb_user.Visible = false;
            // 
            // Cambiar_pass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 274);
            this.Controls.Add(this.txb_user);
            this.Controls.Add(this.lbl_user);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txb_repetir);
            this.Controls.Add(this.txb_nueva);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txb_actual);
            this.Controls.Add(this.lbl_actual);
            this.Name = "Cambiar_pass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cambiar Contraseña";
            this.Load += new System.EventHandler(this.Cambiar_pass_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_actual;
        private System.Windows.Forms.TextBox txb_actual;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txb_nueva;
        private System.Windows.Forms.TextBox txb_repetir;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lbl_user;
        private System.Windows.Forms.TextBox txb_user;
    }
}