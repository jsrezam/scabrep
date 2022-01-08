namespace S.C.A.B.R.E.P
{
    partial class FrmBuscarUsuario
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
            this.dgvUsuario = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnBuscarTodosUsuario = new System.Windows.Forms.Button();
            this.lblAvisoNuevoIngreso = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnBuscarActualizarUsuario = new System.Windows.Forms.Button();
            this.btnBuscarIngresarUsuario = new System.Windows.Forms.Button();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rBtnNombre = new System.Windows.Forms.RadioButton();
            this.btnBucarusuario = new System.Windows.Forms.Button();
            this.rBtnCedula = new System.Windows.Forms.RadioButton();
            this.lblAvisoCedulaUsuario = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCedulaUsuario = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuario)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvUsuario
            // 
            this.dgvUsuario.AllowUserToAddRows = false;
            this.dgvUsuario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvUsuario.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuario.Location = new System.Drawing.Point(12, 172);
            this.dgvUsuario.MultiSelect = false;
            this.dgvUsuario.Name = "dgvUsuario";
            this.dgvUsuario.ReadOnly = true;
            this.dgvUsuario.Size = new System.Drawing.Size(850, 150);
            this.dgvUsuario.TabIndex = 10;
            this.dgvUsuario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBuscarUsuario_CellClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnBuscarTodosUsuario);
            this.groupBox3.Controls.Add(this.lblAvisoNuevoIngreso);
            this.groupBox3.Controls.Add(this.btnCancelar);
            this.groupBox3.Controls.Add(this.btnOK);
            this.groupBox3.Controls.Add(this.btnBuscarActualizarUsuario);
            this.groupBox3.Controls.Add(this.btnBuscarIngresarUsuario);
            this.groupBox3.Controls.Add(this.txtNombreUsuario);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.rBtnNombre);
            this.groupBox3.Controls.Add(this.btnBucarusuario);
            this.groupBox3.Controls.Add(this.rBtnCedula);
            this.groupBox3.Controls.Add(this.lblAvisoCedulaUsuario);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtCedulaUsuario);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(850, 154);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Buscar Usuario Según: Cedula/Nombre/Apellido";
            // 
            // btnBuscarTodosUsuario
            // 
            this.btnBuscarTodosUsuario.Location = new System.Drawing.Point(663, 19);
            this.btnBuscarTodosUsuario.Name = "btnBuscarTodosUsuario";
            this.btnBuscarTodosUsuario.Size = new System.Drawing.Size(75, 53);
            this.btnBuscarTodosUsuario.TabIndex = 36;
            this.btnBuscarTodosUsuario.Text = "Buscar Todos";
            this.btnBuscarTodosUsuario.UseVisualStyleBackColor = true;
            this.btnBuscarTodosUsuario.Click += new System.EventHandler(this.btnBuscarTodosUsuario_Click);
            // 
            // lblAvisoNuevoIngreso
            // 
            this.lblAvisoNuevoIngreso.AutoSize = true;
            this.lblAvisoNuevoIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvisoNuevoIngreso.ForeColor = System.Drawing.Color.Red;
            this.lblAvisoNuevoIngreso.Location = new System.Drawing.Point(414, 135);
            this.lblAvisoNuevoIngreso.Name = "lblAvisoNuevoIngreso";
            this.lblAvisoNuevoIngreso.Size = new System.Drawing.Size(191, 13);
            this.lblAvisoNuevoIngreso.TabIndex = 34;
            this.lblAvisoNuevoIngreso.Text = "Busque el nuevo Usuario Ingresado -->";
            this.lblAvisoNuevoIngreso.Visible = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(769, 125);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 33;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Enabled = false;
            this.btnOK.Location = new System.Drawing.Point(688, 125);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 32;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnBuscarActualizarUsuario
            // 
            this.btnBuscarActualizarUsuario.Location = new System.Drawing.Point(744, 48);
            this.btnBuscarActualizarUsuario.Name = "btnBuscarActualizarUsuario";
            this.btnBuscarActualizarUsuario.Size = new System.Drawing.Size(97, 23);
            this.btnBuscarActualizarUsuario.TabIndex = 30;
            this.btnBuscarActualizarUsuario.Text = "Modificar Usuario";
            this.btnBuscarActualizarUsuario.UseVisualStyleBackColor = true;
            this.btnBuscarActualizarUsuario.Click += new System.EventHandler(this.btnBuscarActualizarUsuario_Click);
            // 
            // btnBuscarIngresarUsuario
            // 
            this.btnBuscarIngresarUsuario.Location = new System.Drawing.Point(744, 19);
            this.btnBuscarIngresarUsuario.Name = "btnBuscarIngresarUsuario";
            this.btnBuscarIngresarUsuario.Size = new System.Drawing.Size(97, 23);
            this.btnBuscarIngresarUsuario.TabIndex = 29;
            this.btnBuscarIngresarUsuario.Text = "Ingresar Usuario";
            this.btnBuscarIngresarUsuario.UseVisualStyleBackColor = true;
            this.btnBuscarIngresarUsuario.Click += new System.EventHandler(this.btnBuscarIngresarUsuario_Click);
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Enabled = false;
            this.txtNombreUsuario.Location = new System.Drawing.Point(136, 93);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(190, 20);
            this.txtNombreUsuario.TabIndex = 28;
            this.txtNombreUsuario.TextChanged += new System.EventHandler(this.txtNombreCliente_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Nombre/Apellido Usuario:";
            // 
            // rBtnNombre
            // 
            this.rBtnNombre.AutoSize = true;
            this.rBtnNombre.Location = new System.Drawing.Point(70, 31);
            this.rBtnNombre.Name = "rBtnNombre";
            this.rBtnNombre.Size = new System.Drawing.Size(104, 17);
            this.rBtnNombre.TabIndex = 26;
            this.rBtnNombre.Text = "Nombre/Apellido";
            this.rBtnNombre.UseVisualStyleBackColor = true;
            this.rBtnNombre.CheckedChanged += new System.EventHandler(this.rBtnNombre_CheckedChanged);
            // 
            // btnBucarusuario
            // 
            this.btnBucarusuario.Location = new System.Drawing.Point(607, 125);
            this.btnBucarusuario.Name = "btnBucarusuario";
            this.btnBucarusuario.Size = new System.Drawing.Size(75, 23);
            this.btnBucarusuario.TabIndex = 23;
            this.btnBucarusuario.Text = "Buscar";
            this.btnBucarusuario.UseVisualStyleBackColor = true;
            this.btnBucarusuario.Click += new System.EventHandler(this.btnBucarusuario_Click);
            // 
            // rBtnCedula
            // 
            this.rBtnCedula.AutoSize = true;
            this.rBtnCedula.Location = new System.Drawing.Point(6, 31);
            this.rBtnCedula.Name = "rBtnCedula";
            this.rBtnCedula.Size = new System.Drawing.Size(58, 17);
            this.rBtnCedula.TabIndex = 20;
            this.rBtnCedula.Text = "Cédula";
            this.rBtnCedula.UseVisualStyleBackColor = true;
            this.rBtnCedula.CheckedChanged += new System.EventHandler(this.rBtnCedula_CheckedChanged);
            // 
            // lblAvisoCedulaUsuario
            // 
            this.lblAvisoCedulaUsuario.AutoSize = true;
            this.lblAvisoCedulaUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvisoCedulaUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblAvisoCedulaUsuario.Location = new System.Drawing.Point(332, 70);
            this.lblAvisoCedulaUsuario.Name = "lblAvisoCedulaUsuario";
            this.lblAvisoCedulaUsuario.Size = new System.Drawing.Size(138, 13);
            this.lblAvisoCedulaUsuario.TabIndex = 19;
            this.lblAvisoCedulaUsuario.Text = "AvisoCedulaUsuarioEliminar";
            this.lblAvisoCedulaUsuario.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Cédula Usuario:";
            // 
            // txtCedulaUsuario
            // 
            this.txtCedulaUsuario.Enabled = false;
            this.txtCedulaUsuario.Location = new System.Drawing.Point(136, 63);
            this.txtCedulaUsuario.Name = "txtCedulaUsuario";
            this.txtCedulaUsuario.Size = new System.Drawing.Size(190, 20);
            this.txtCedulaUsuario.TabIndex = 5;
            this.txtCedulaUsuario.TextChanged += new System.EventHandler(this.txtCedulaCliente_TextChanged);
            this.txtCedulaUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCedulaCliente_KeyPress);
            // 
            // FrmBuscarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 330);
            this.Controls.Add(this.dgvUsuario);
            this.Controls.Add(this.groupBox3);
            this.Name = "FrmBuscarUsuario";
            this.Text = "Buscar Usuario";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuario)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUsuario;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblAvisoNuevoIngreso;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnBuscarActualizarUsuario;
        private System.Windows.Forms.Button btnBuscarIngresarUsuario;
        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rBtnNombre;
        private System.Windows.Forms.Button btnBucarusuario;
        private System.Windows.Forms.RadioButton rBtnCedula;
        private System.Windows.Forms.Label lblAvisoCedulaUsuario;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCedulaUsuario;
        private System.Windows.Forms.Button btnBuscarTodosUsuario;
    }
}