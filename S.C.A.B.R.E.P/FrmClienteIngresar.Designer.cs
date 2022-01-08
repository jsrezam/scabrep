namespace S.C.A.B.R.E.P
{
    partial class FrmClienteIngresar
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCancelarIngresarCliente = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rBtnRuc = new System.Windows.Forms.RadioButton();
            this.rBtnCedula = new System.Windows.Forms.RadioButton();
            this.lblAvisoCedulaCliente = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblAvisoRucCliente = new System.Windows.Forms.Label();
            this.txtCedulaCliente = new System.Windows.Forms.TextBox();
            this.txtRucCliente = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTelefonoFijoCliente = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMailCliente = new System.Windows.Forms.TextBox();
            this.lblAvisoTelefonoCelularCliente = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDireccionCliente = new System.Windows.Forms.TextBox();
            this.txtTelefonoCelularCliente = new System.Windows.Forms.TextBox();
            this.btnIngresarCliente = new System.Windows.Forms.Button();
            this.txtApellidoCliente = new System.Windows.Forms.TextBox();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCancelarIngresarCliente);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.txtTelefonoFijoCliente);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtMailCliente);
            this.groupBox1.Controls.Add(this.lblAvisoTelefonoCelularCliente);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtDireccionCliente);
            this.groupBox1.Controls.Add(this.txtTelefonoCelularCliente);
            this.groupBox1.Controls.Add(this.btnIngresarCliente);
            this.groupBox1.Controls.Add(this.txtApellidoCliente);
            this.groupBox1.Controls.Add(this.txtNombreCliente);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(651, 313);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Cliente:";
            // 
            // btnCancelarIngresarCliente
            // 
            this.btnCancelarIngresarCliente.Location = new System.Drawing.Point(538, 278);
            this.btnCancelarIngresarCliente.Name = "btnCancelarIngresarCliente";
            this.btnCancelarIngresarCliente.Size = new System.Drawing.Size(101, 23);
            this.btnCancelarIngresarCliente.TabIndex = 12;
            this.btnCancelarIngresarCliente.Text = "Salir";
            this.btnCancelarIngresarCliente.UseVisualStyleBackColor = true;
            this.btnCancelarIngresarCliente.Click += new System.EventHandler(this.btnCancelarIngresarCliente_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rBtnRuc);
            this.groupBox2.Controls.Add(this.rBtnCedula);
            this.groupBox2.Controls.Add(this.lblAvisoCedulaCliente);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.lblAvisoRucCliente);
            this.groupBox2.Controls.Add(this.txtCedulaCliente);
            this.groupBox2.Controls.Add(this.txtRucCliente);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(9, 80);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(636, 102);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cedula/RUC/Cedula-RUC";
            // 
            // rBtnRuc
            // 
            this.rBtnRuc.AutoSize = true;
            this.rBtnRuc.Location = new System.Drawing.Point(100, 19);
            this.rBtnRuc.Name = "rBtnRuc";
            this.rBtnRuc.Size = new System.Drawing.Size(48, 17);
            this.rBtnRuc.TabIndex = 21;
            this.rBtnRuc.Text = "RUC";
            this.rBtnRuc.UseVisualStyleBackColor = true;
            this.rBtnRuc.CheckedChanged += new System.EventHandler(this.rBtnRuc_CheckedChanged);
            // 
            // rBtnCedula
            // 
            this.rBtnCedula.AutoSize = true;
            this.rBtnCedula.Location = new System.Drawing.Point(6, 19);
            this.rBtnCedula.Name = "rBtnCedula";
            this.rBtnCedula.Size = new System.Drawing.Size(58, 17);
            this.rBtnCedula.TabIndex = 20;
            this.rBtnCedula.Text = "Cédula";
            this.rBtnCedula.UseVisualStyleBackColor = true;
            this.rBtnCedula.CheckedChanged += new System.EventHandler(this.rBtnCedula_CheckedChanged);
            // 
            // lblAvisoCedulaCliente
            // 
            this.lblAvisoCedulaCliente.AutoSize = true;
            this.lblAvisoCedulaCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvisoCedulaCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblAvisoCedulaCliente.Location = new System.Drawing.Point(390, 50);
            this.lblAvisoCedulaCliente.Name = "lblAvisoCedulaCliente";
            this.lblAvisoCedulaCliente.Size = new System.Drawing.Size(98, 13);
            this.lblAvisoCedulaCliente.TabIndex = 19;
            this.lblAvisoCedulaCliente.Text = "AvisoCedulaCliente";
            this.lblAvisoCedulaCliente.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Cédula Cliente:";
            // 
            // lblAvisoRucCliente
            // 
            this.lblAvisoRucCliente.AutoSize = true;
            this.lblAvisoRucCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvisoRucCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblAvisoRucCliente.Location = new System.Drawing.Point(390, 80);
            this.lblAvisoRucCliente.Name = "lblAvisoRucCliente";
            this.lblAvisoRucCliente.Size = new System.Drawing.Size(85, 13);
            this.lblAvisoRucCliente.TabIndex = 18;
            this.lblAvisoRucCliente.Text = "AvisoRucCliente";
            this.lblAvisoRucCliente.Visible = false;
            // 
            // txtCedulaCliente
            // 
            this.txtCedulaCliente.Enabled = false;
            this.txtCedulaCliente.Location = new System.Drawing.Point(121, 43);
            this.txtCedulaCliente.Name = "txtCedulaCliente";
            this.txtCedulaCliente.Size = new System.Drawing.Size(257, 20);
            this.txtCedulaCliente.TabIndex = 5;
            this.txtCedulaCliente.TextChanged += new System.EventHandler(this.txtCedulaCliente_TextChanged);
            this.txtCedulaCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCedulaCliente_KeyPress);
            // 
            // txtRucCliente
            // 
            this.txtRucCliente.Enabled = false;
            this.txtRucCliente.Location = new System.Drawing.Point(121, 73);
            this.txtRucCliente.Name = "txtRucCliente";
            this.txtRucCliente.Size = new System.Drawing.Size(257, 20);
            this.txtRucCliente.TabIndex = 6;
            this.txtRucCliente.TextChanged += new System.EventHandler(this.txtRucCliente_TextChanged);
            this.txtRucCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRucCliente_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "RUC Cliente:";
            // 
            // txtTelefonoFijoCliente
            // 
            this.txtTelefonoFijoCliente.Location = new System.Drawing.Point(130, 219);
            this.txtTelefonoFijoCliente.Name = "txtTelefonoFijoCliente";
            this.txtTelefonoFijoCliente.Size = new System.Drawing.Size(257, 20);
            this.txtTelefonoFijoCliente.TabIndex = 8;
            this.txtTelefonoFijoCliente.TextChanged += new System.EventHandler(this.txtTelefonoFijoCliente_TextChanged);
            this.txtTelefonoFijoCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefonoFijoCliente_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 226);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Teléfono Fijo Cliente:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 278);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "E-Mail Cliente:";
            // 
            // txtMailCliente
            // 
            this.txtMailCliente.Location = new System.Drawing.Point(130, 275);
            this.txtMailCliente.Name = "txtMailCliente";
            this.txtMailCliente.Size = new System.Drawing.Size(257, 20);
            this.txtMailCliente.TabIndex = 10;
            this.txtMailCliente.TextChanged += new System.EventHandler(this.txtMailCliente_TextChanged);
            // 
            // lblAvisoTelefonoCelularCliente
            // 
            this.lblAvisoTelefonoCelularCliente.AutoSize = true;
            this.lblAvisoTelefonoCelularCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvisoTelefonoCelularCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblAvisoTelefonoCelularCliente.Location = new System.Drawing.Point(393, 199);
            this.lblAvisoTelefonoCelularCliente.Name = "lblAvisoTelefonoCelularCliente";
            this.lblAvisoTelefonoCelularCliente.Size = new System.Drawing.Size(139, 13);
            this.lblAvisoTelefonoCelularCliente.TabIndex = 13;
            this.lblAvisoTelefonoCelularCliente.Text = "AvisoTelefonoCelularCliente";
            this.lblAvisoTelefonoCelularCliente.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Dirección Cliente:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Teléfono Celular Cliente:";
            // 
            // txtDireccionCliente
            // 
            this.txtDireccionCliente.Location = new System.Drawing.Point(130, 243);
            this.txtDireccionCliente.Name = "txtDireccionCliente";
            this.txtDireccionCliente.Size = new System.Drawing.Size(257, 20);
            this.txtDireccionCliente.TabIndex = 9;
            this.txtDireccionCliente.TextChanged += new System.EventHandler(this.txtDireccionCliente_TextChanged);
            this.txtDireccionCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDireccionCliente_KeyPress);
            // 
            // txtTelefonoCelularCliente
            // 
            this.txtTelefonoCelularCliente.Location = new System.Drawing.Point(130, 192);
            this.txtTelefonoCelularCliente.Name = "txtTelefonoCelularCliente";
            this.txtTelefonoCelularCliente.Size = new System.Drawing.Size(257, 20);
            this.txtTelefonoCelularCliente.TabIndex = 7;
            this.txtTelefonoCelularCliente.TextChanged += new System.EventHandler(this.txtTelefonoCliente_TextChanged);
            this.txtTelefonoCelularCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefonoCelularCliente_KeyPress);
            // 
            // btnIngresarCliente
            // 
            this.btnIngresarCliente.Location = new System.Drawing.Point(431, 278);
            this.btnIngresarCliente.Name = "btnIngresarCliente";
            this.btnIngresarCliente.Size = new System.Drawing.Size(101, 23);
            this.btnIngresarCliente.TabIndex = 11;
            this.btnIngresarCliente.Text = "Insertar";
            this.btnIngresarCliente.UseVisualStyleBackColor = true;
            this.btnIngresarCliente.Click += new System.EventHandler(this.btnIngresarCliente_Click);
            // 
            // txtApellidoCliente
            // 
            this.txtApellidoCliente.Location = new System.Drawing.Point(130, 54);
            this.txtApellidoCliente.Name = "txtApellidoCliente";
            this.txtApellidoCliente.Size = new System.Drawing.Size(257, 20);
            this.txtApellidoCliente.TabIndex = 3;
            this.txtApellidoCliente.TextChanged += new System.EventHandler(this.txtApellidoCliente_TextChanged);
            this.txtApellidoCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellidoCliente_KeyPress);
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(130, 28);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(257, 20);
            this.txtNombreCliente.TabIndex = 2;
            this.txtNombreCliente.TextChanged += new System.EventHandler(this.txtNombreCliente_TextChanged);
            this.txtNombreCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreCliente_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Apellido Cliente:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nombre Cliente:";
            // 
            // FrmClienteIngresar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 336);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmClienteIngresar";
            this.Text = "Ingreso Datos Cliente";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIngresarCliente;
        private System.Windows.Forms.TextBox txtApellidoCliente;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDireccionCliente;
        private System.Windows.Forms.TextBox txtTelefonoCelularCliente;
        private System.Windows.Forms.TextBox txtCedulaCliente;
        private System.Windows.Forms.Label lblAvisoTelefonoCelularCliente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtRucCliente;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblAvisoCedulaCliente;
        private System.Windows.Forms.Label lblAvisoRucCliente;
        private System.Windows.Forms.TextBox txtTelefonoFijoCliente;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMailCliente;
        private System.Windows.Forms.RadioButton rBtnRuc;
        private System.Windows.Forms.RadioButton rBtnCedula;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCancelarIngresarCliente;
    }
}

