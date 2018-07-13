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
            this.btn_clientes = new System.Windows.Forms.Button();
            this.btn_roles = new System.Windows.Forms.Button();
            this.btn_usurios = new System.Windows.Forms.Button();
            this.btn_hoteles = new System.Windows.Forms.Button();
            this.btn_habitaciones = new System.Windows.Forms.Button();
            this.btn_reserva = new System.Windows.Forms.Button();
            this.btn_check = new System.Windows.Forms.Button();
            this.btn_facturar = new System.Windows.Forms.Button();
            this.btn_listados = new System.Windows.Forms.Button();
            this.btn_consumibles = new System.Windows.Forms.Button();
            this.btn_estadia = new System.Windows.Forms.Button();
            this.label_usuario_logueado = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmb_reservas_acciones = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label_rol_usuario_logueado = new System.Windows.Forms.Label();
            this.label_fecha_sistema = new System.Windows.Forms.Label();
            this.btn_off = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_clientes
            // 
            this.btn_clientes.BackColor = System.Drawing.Color.Silver;
            this.btn_clientes.Location = new System.Drawing.Point(337, 37);
            this.btn_clientes.Name = "btn_clientes";
            this.btn_clientes.Size = new System.Drawing.Size(140, 76);
            this.btn_clientes.TabIndex = 0;
            this.btn_clientes.Text = "Clientes";
            this.btn_clientes.UseVisualStyleBackColor = false;
            this.btn_clientes.Visible = false;
            this.btn_clientes.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_roles
            // 
            this.btn_roles.BackColor = System.Drawing.Color.Silver;
            this.btn_roles.Location = new System.Drawing.Point(35, 37);
            this.btn_roles.Name = "btn_roles";
            this.btn_roles.Size = new System.Drawing.Size(145, 76);
            this.btn_roles.TabIndex = 1;
            this.btn_roles.Text = "Roles";
            this.btn_roles.UseVisualStyleBackColor = false;
            this.btn_roles.Visible = false;
            this.btn_roles.Click += new System.EventHandler(this.roles_Click);
            // 
            // btn_usurios
            // 
            this.btn_usurios.BackColor = System.Drawing.Color.Silver;
            this.btn_usurios.Location = new System.Drawing.Point(186, 38);
            this.btn_usurios.Name = "btn_usurios";
            this.btn_usurios.Size = new System.Drawing.Size(145, 76);
            this.btn_usurios.TabIndex = 2;
            this.btn_usurios.Text = "Usuarios";
            this.btn_usurios.UseVisualStyleBackColor = false;
            this.btn_usurios.Visible = false;
            this.btn_usurios.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_hoteles
            // 
            this.btn_hoteles.BackColor = System.Drawing.Color.Silver;
            this.btn_hoteles.Location = new System.Drawing.Point(483, 37);
            this.btn_hoteles.Name = "btn_hoteles";
            this.btn_hoteles.Size = new System.Drawing.Size(140, 76);
            this.btn_hoteles.TabIndex = 3;
            this.btn_hoteles.Text = "Hoteles";
            this.btn_hoteles.UseVisualStyleBackColor = false;
            this.btn_hoteles.Visible = false;
            this.btn_hoteles.Click += new System.EventHandler(this.button4_Click);
            // 
            // btn_habitaciones
            // 
            this.btn_habitaciones.BackColor = System.Drawing.Color.Silver;
            this.btn_habitaciones.Location = new System.Drawing.Point(629, 37);
            this.btn_habitaciones.Name = "btn_habitaciones";
            this.btn_habitaciones.Size = new System.Drawing.Size(140, 76);
            this.btn_habitaciones.TabIndex = 4;
            this.btn_habitaciones.Text = "Habitaciones";
            this.btn_habitaciones.UseVisualStyleBackColor = false;
            this.btn_habitaciones.Visible = false;
            this.btn_habitaciones.Click += new System.EventHandler(this.button5_Click);
            // 
            // btn_reserva
            // 
            this.btn_reserva.BackColor = System.Drawing.Color.Lime;
            this.btn_reserva.Location = new System.Drawing.Point(30, 23);
            this.btn_reserva.Name = "btn_reserva";
            this.btn_reserva.Size = new System.Drawing.Size(142, 76);
            this.btn_reserva.TabIndex = 5;
            this.btn_reserva.Text = "Reservas";
            this.btn_reserva.UseVisualStyleBackColor = false;
            this.btn_reserva.Visible = false;
            this.btn_reserva.Click += new System.EventHandler(this.button6_Click);
            // 
            // btn_check
            // 
            this.btn_check.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_check.Location = new System.Drawing.Point(181, 23);
            this.btn_check.Name = "btn_check";
            this.btn_check.Size = new System.Drawing.Size(142, 76);
            this.btn_check.TabIndex = 7;
            this.btn_check.Text = "Check-In / Check-Out";
            this.btn_check.UseVisualStyleBackColor = false;
            this.btn_check.Visible = false;
            this.btn_check.Click += new System.EventHandler(this.btn_check_Click);
            // 
            // btn_facturar
            // 
            this.btn_facturar.BackColor = System.Drawing.Color.Lime;
            this.btn_facturar.Location = new System.Drawing.Point(473, 23);
            this.btn_facturar.Name = "btn_facturar";
            this.btn_facturar.Size = new System.Drawing.Size(142, 76);
            this.btn_facturar.TabIndex = 8;
            this.btn_facturar.Text = "Facturar";
            this.btn_facturar.UseVisualStyleBackColor = false;
            this.btn_facturar.Visible = false;
            this.btn_facturar.Click += new System.EventHandler(this.btn_facturar_Click);
            // 
            // btn_listados
            // 
            this.btn_listados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_listados.Location = new System.Drawing.Point(793, 23);
            this.btn_listados.Name = "btn_listados";
            this.btn_listados.Size = new System.Drawing.Size(142, 76);
            this.btn_listados.TabIndex = 9;
            this.btn_listados.Text = "Listados";
            this.btn_listados.UseVisualStyleBackColor = false;
            this.btn_listados.Visible = false;
            this.btn_listados.Click += new System.EventHandler(this.button9_Click);
            // 
            // btn_consumibles
            // 
            this.btn_consumibles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_consumibles.Location = new System.Drawing.Point(327, 23);
            this.btn_consumibles.Name = "btn_consumibles";
            this.btn_consumibles.Size = new System.Drawing.Size(142, 76);
            this.btn_consumibles.TabIndex = 10;
            this.btn_consumibles.Text = "Registrar Consumibles";
            this.btn_consumibles.UseVisualStyleBackColor = false;
            this.btn_consumibles.Visible = false;
            this.btn_consumibles.Click += new System.EventHandler(this.btn_consumibles_Click);
            // 
            // btn_estadia
            // 
            this.btn_estadia.BackColor = System.Drawing.Color.Silver;
            this.btn_estadia.Location = new System.Drawing.Point(775, 37);
            this.btn_estadia.Name = "btn_estadia";
            this.btn_estadia.Size = new System.Drawing.Size(140, 76);
            this.btn_estadia.TabIndex = 12;
            this.btn_estadia.Text = "Régimen Estadía";
            this.btn_estadia.UseVisualStyleBackColor = false;
            this.btn_estadia.Visible = false;
            this.btn_estadia.Click += new System.EventHandler(this.button11_Click);
            // 
            // label_usuario_logueado
            // 
            this.label_usuario_logueado.AutoSize = true;
            this.label_usuario_logueado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label_usuario_logueado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_usuario_logueado.Dock = System.Windows.Forms.DockStyle.Right;
            this.label_usuario_logueado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_usuario_logueado.Location = new System.Drawing.Point(839, 0);
            this.label_usuario_logueado.Name = "label_usuario_logueado";
            this.label_usuario_logueado.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label_usuario_logueado.Size = new System.Drawing.Size(128, 20);
            this.label_usuario_logueado.TabIndex = 2;
            this.label_usuario_logueado.Text = "usuario_logueado";
            this.label_usuario_logueado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label_usuario_logueado.Click += new System.EventHandler(this.label_usuario_logueado_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.cmb_reservas_acciones);
            this.groupBox1.Controls.Add(this.btn_listados);
            this.groupBox1.Controls.Add(this.btn_reserva);
            this.groupBox1.Controls.Add(this.btn_check);
            this.groupBox1.Controls.Add(this.btn_facturar);
            this.groupBox1.Controls.Add(this.btn_consumibles);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(943, 113);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operaciones";
            // 
            // cmb_reservas_acciones
            // 
            this.cmb_reservas_acciones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_reservas_acciones.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmb_reservas_acciones.FormattingEnabled = true;
            this.cmb_reservas_acciones.Items.AddRange(new object[] {
            "Opciones",
            "Crear",
            "Modificar",
            "Cancelar"});
            this.cmb_reservas_acciones.Location = new System.Drawing.Point(30, 78);
            this.cmb_reservas_acciones.Name = "cmb_reservas_acciones";
            this.cmb_reservas_acciones.Size = new System.Drawing.Size(142, 26);
            this.cmb_reservas_acciones.TabIndex = 17;
            this.cmb_reservas_acciones.Visible = false;
            this.cmb_reservas_acciones.SelectedIndexChanged += new System.EventHandler(this.cmb_reservas_acciones_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox2.Controls.Add(this.btn_usurios);
            this.groupBox2.Controls.Add(this.btn_clientes);
            this.groupBox2.Controls.Add(this.btn_roles);
            this.groupBox2.Controls.Add(this.btn_estadia);
            this.groupBox2.Controls.Add(this.btn_hoteles);
            this.groupBox2.Controls.Add(this.btn_habitaciones);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 210);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(943, 132);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Administración Interna";
            // 
            // label_rol_usuario_logueado
            // 
            this.label_rol_usuario_logueado.AutoSize = true;
            this.label_rol_usuario_logueado.BackColor = System.Drawing.Color.Silver;
            this.label_rol_usuario_logueado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_rol_usuario_logueado.Dock = System.Windows.Forms.DockStyle.Right;
            this.label_rol_usuario_logueado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_rol_usuario_logueado.Location = new System.Drawing.Point(686, 0);
            this.label_rol_usuario_logueado.Name = "label_rol_usuario_logueado";
            this.label_rol_usuario_logueado.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label_rol_usuario_logueado.Size = new System.Drawing.Size(153, 20);
            this.label_rol_usuario_logueado.TabIndex = 1;
            this.label_rol_usuario_logueado.Text = "rol_usuario_logueado";
            this.label_rol_usuario_logueado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_fecha_sistema
            // 
            this.label_fecha_sistema.AutoSize = true;
            this.label_fecha_sistema.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label_fecha_sistema.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_fecha_sistema.Dock = System.Windows.Forms.DockStyle.Left;
            this.label_fecha_sistema.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_fecha_sistema.Location = new System.Drawing.Point(0, 0);
            this.label_fecha_sistema.Name = "label_fecha_sistema";
            this.label_fecha_sistema.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label_fecha_sistema.Size = new System.Drawing.Size(46, 20);
            this.label_fecha_sistema.TabIndex = 16;
            this.label_fecha_sistema.Text = "fecha";
            this.label_fecha_sistema.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_off
            // 
            this.btn_off.BackColor = System.Drawing.Color.Cyan;
            this.btn_off.Location = new System.Drawing.Point(139, -1);
            this.btn_off.Name = "btn_off";
            this.btn_off.Size = new System.Drawing.Size(110, 23);
            this.btn_off.TabIndex = 171;
            this.btn_off.Text = "Cerrar Sesión";
            this.btn_off.UseVisualStyleBackColor = false;
            this.btn_off.Click += new System.EventHandler(this.btn_off_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(967, 354);
            this.Controls.Add(this.btn_off);
            this.Controls.Add(this.label_fecha_sistema);
            this.Controls.Add(this.label_rol_usuario_logueado);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label_usuario_logueado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadena Denver - Sistema de Gestión";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Principal_FormClosing);
            this.Load += new System.EventHandler(this.Principal_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_clientes;
        private System.Windows.Forms.Button btn_roles;
        private System.Windows.Forms.Button btn_usurios;
        private System.Windows.Forms.Button btn_hoteles;
        private System.Windows.Forms.Button btn_habitaciones;
        private System.Windows.Forms.Button btn_reserva;
        private System.Windows.Forms.Button btn_check;
        private System.Windows.Forms.Button btn_facturar;
        private System.Windows.Forms.Button btn_listados;
        private System.Windows.Forms.Button btn_consumibles;
        private System.Windows.Forms.Button btn_estadia;
        private System.Windows.Forms.Label label_usuario_logueado;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label_rol_usuario_logueado;
        private System.Windows.Forms.Label label_fecha_sistema;
        private System.Windows.Forms.ComboBox cmb_reservas_acciones;
        private System.Windows.Forms.Button btn_off;
    }
}

