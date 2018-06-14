namespace FrbaHotel.CancelarReserva
{
    partial class Cancelar_reserva
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
            this.label1 = new System.Windows.Forms.Label();
            this.txb_canc_rec_codigo = new System.Windows.Forms.TextBox();
            this.lbl_canc_res_motivo = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_canc_rec_confirm = new System.Windows.Forms.Button();
            this.btn_canc_res_volver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código de reserva:";
            // 
            // txb_canc_rec_codigo
            // 
            this.txb_canc_rec_codigo.Location = new System.Drawing.Point(127, 22);
            this.txb_canc_rec_codigo.Name = "txb_canc_rec_codigo";
            this.txb_canc_rec_codigo.Size = new System.Drawing.Size(119, 20);
            this.txb_canc_rec_codigo.TabIndex = 1;
            // 
            // lbl_canc_res_motivo
            // 
            this.lbl_canc_res_motivo.AutoSize = true;
            this.lbl_canc_res_motivo.Location = new System.Drawing.Point(12, 52);
            this.lbl_canc_res_motivo.Name = "lbl_canc_res_motivo";
            this.lbl_canc_res_motivo.Size = new System.Drawing.Size(118, 13);
            this.lbl_canc_res_motivo.TabIndex = 2;
            this.lbl_canc_res_motivo.Text = "Motivo de cancelación:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 70);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(282, 121);
            this.textBox1.TabIndex = 3;
            // 
            // btn_canc_rec_confirm
            // 
            this.btn_canc_rec_confirm.Location = new System.Drawing.Point(19, 208);
            this.btn_canc_rec_confirm.Name = "btn_canc_rec_confirm";
            this.btn_canc_rec_confirm.Size = new System.Drawing.Size(136, 40);
            this.btn_canc_rec_confirm.TabIndex = 4;
            this.btn_canc_rec_confirm.Text = "Confirmar \r\nCancelacion";
            this.btn_canc_rec_confirm.UseVisualStyleBackColor = true;
            this.btn_canc_rec_confirm.Click += new System.EventHandler(this.btn_canc_rec_confirm_Click);
            // 
            // btn_canc_res_volver
            // 
            this.btn_canc_res_volver.Location = new System.Drawing.Point(163, 208);
            this.btn_canc_res_volver.Name = "btn_canc_res_volver";
            this.btn_canc_res_volver.Size = new System.Drawing.Size(136, 40);
            this.btn_canc_res_volver.TabIndex = 5;
            this.btn_canc_res_volver.Text = "Volver";
            this.btn_canc_res_volver.UseVisualStyleBackColor = true;
            // 
            // Cancelar_reserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 261);
            this.Controls.Add(this.btn_canc_res_volver);
            this.Controls.Add(this.btn_canc_rec_confirm);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbl_canc_res_motivo);
            this.Controls.Add(this.txb_canc_rec_codigo);
            this.Controls.Add(this.label1);
            this.Name = "Cancelar_reserva";
            this.Text = "Cancelar Reserva";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txb_canc_rec_codigo;
        private System.Windows.Forms.Label lbl_canc_res_motivo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_canc_rec_confirm;
        private System.Windows.Forms.Button btn_canc_res_volver;
    }
}