namespace S.C.A.B.R.E.P
{
    partial class FrmBuscarCliente
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
            this.dgvBuscarCliente = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnBuscarTodosCliente = new System.Windows.Forms.Button();
            this.lblAvisoNuevoIngreso = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnBuscarActualizarCliente = new System.Windows.Forms.Button();
            this.btnBuscarIngresarCliente = new System.Windows.Forms.Button();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rBtnNombre = new System.Windows.Forms.RadioButton();
            this.btnBucarCliente = new System.Windows.Forms.Button();
            this.rBtnRuc = new System.Windows.Forms.RadioButton();
            this.rBtnCedula = new System.Windows.Forms.RadioButton();
            this.lblAvisoCedulaCliente = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblAvisoRucCliente = new System.Windows.Forms.Label();
            this.txtCedulaCliente = new System.Windows.Forms.TextBox();
            this.txtRucCliente = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarCliente)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvBuscarCliente
            // 
            this.dgvBuscarCliente.AllowUserToAddRows = false;
            this.dgvBuscarCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvBuscarCliente.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvBuscarCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuscarCliente.Location = new System.Drawing.Point(12, 172);
            this.dgvBuscarCliente.MultiSelect = false;
            this.dgvBuscarCliente.Name = "dgvBuscarCliente";
            this.dgvBuscarCliente.ReadOnly = true;
            this.dgvBuscarCliente.Size = new System.Drawing.Size(850, 150);
            this.dgvBuscarCliente.TabIndex = 8;
            this.dgvBuscarCliente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBuscarClienteEliminar_CellClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnBuscarTodosCliente);
            this.groupBox3.Controls.Add(this.lblAvisoNuevoIngreso);
            this.groupBox3.Controls.Add(this.btnCancelar);
            this.groupBox3.Controls.Add(this.btnOK);
            this.groupBox3.Controls.Add(this.btnBuscarActualizarCliente);
            this.groupBox3.Controls.Add(this.btnBuscarIngresarCliente);
            this.groupBox3.Controls.Add(this.txtNombreCliente);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.rBtnNombre);
            this.groupBox3.Controls.Add(this.btnBucarCliente);
            this.groupBox3.Controls.Add(this.rBtnRuc);
            this.groupBox3.Controls.Add(this.rBtnCedula);
            this.groupBox3.Controls.Add(this.lblAvisoCedulaCliente);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.lblAvisoRucCliente);
            this.groupBox3.Controls.Add(this.txtCedulaCliente);
            this.groupBox3.Controls.Add(this.txtRucCliente);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(850, 154);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Buscar Cliente Según: Cedula/RUC/Nombre/Apellido";
            // 
            // btnBuscarTodosCliente
            // 
            this.btnBuscarTodosCliente.Location = new System.Drawing.Point(663, 18);
            this.btnBuscarTodosCliente.Name = "btnBuscarTodosCliente";
            this.btnBuscarTodosCliente.Size = new System.Drawing.Size(75, 53);
            this.btnBuscarTodosCliente.TabIndex = 35;
            this.btnBuscarTodosCliente.Text = "Buscar Todos";
            this.btnBuscarTodosCliente.UseVisualStyleBackColor = true;
            this.btnBuscarTodosCliente.Click += new System.EventHandler(this.btnBuscarTodosCliente_Click);
            // 
            // lblAvisoNuevoIngreso
            // 
            this.lblAvisoNuevoIngreso.AutoSize = true;
            this.lblAvisoNuevoIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvisoNuevoIngreso.ForeColor = System.Drawing.Color.Red;
            this.lblAvisoNuevoIngreso.Location = new System.Drawing.Point(414, 135);
            this.lblAvisoNuevoIngreso.Name = "lblAvisoNuevoIngreso";
            this.lblAvisoNuevoIngreso.Size = new System.Drawing.Size(187, 13);
            this.lblAvisoNuevoIngreso.TabIndex = 34;
            this.lblAvisoNuevoIngreso.Text = "Busque el nuevo Cliente Ingresado -->";
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
            // btnBuscarActualizarCliente
            // 
            this.btnBuscarActualizarCliente.Location = new System.Drawing.Point(744, 48);
            this.btnBuscarActualizarCliente.Name = "btnBuscarActualizarCliente";
            this.btnBuscarActualizarCliente.Size = new System.Drawing.Size(97, 23);
            this.btnBuscarActualizarCliente.TabIndex = 30;
            this.btnBuscarActualizarCliente.Text = "Modificar Cliente";
            this.btnBuscarActualizarCliente.UseVisualStyleBackColor = true;
            this.btnBuscarActualizarCliente.Click += new System.EventHandler(this.btnBuscarActualizarCliente_Click);
            // 
            // btnBuscarIngresarCliente
            // 
            this.btnBuscarIngresarCliente.Location = new System.Drawing.Point(744, 19);
            this.btnBuscarIngresarCliente.Name = "btnBuscarIngresarCliente";
            this.btnBuscarIngresarCliente.Size = new System.Drawing.Size(97, 23);
            this.btnBuscarIngresarCliente.TabIndex = 29;
            this.btnBuscarIngresarCliente.Text = "Ingresar Cliente";
            this.btnBuscarIngresarCliente.UseVisualStyleBackColor = true;
            this.btnBuscarIngresarCliente.Click += new System.EventHandler(this.btnBuscarIngresarCliente_Click_1);
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Enabled = false;
            this.txtNombreCliente.Location = new System.Drawing.Point(136, 122);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(190, 20);
            this.txtNombreCliente.TabIndex = 28;
            this.txtNombreCliente.TextChanged += new System.EventHandler(this.txtNombreCliente_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Nombre/Apellido Cliente:";
            // 
            // rBtnNombre
            // 
            this.rBtnNombre.AutoSize = true;
            this.rBtnNombre.Location = new System.Drawing.Point(203, 31);
            this.rBtnNombre.Name = "rBtnNombre";
            this.rBtnNombre.Size = new System.Drawing.Size(104, 17);
            this.rBtnNombre.TabIndex = 26;
            this.rBtnNombre.Text = "Nombre/Apellido";
            this.rBtnNombre.UseVisualStyleBackColor = true;
            this.rBtnNombre.CheckedChanged += new System.EventHandler(this.rBtnNombreEliminar_CheckedChanged);
            // 
            // btnBucarCliente
            // 
            this.btnBucarCliente.Location = new System.Drawing.Point(607, 125);
            this.btnBucarCliente.Name = "btnBucarCliente";
            this.btnBucarCliente.Size = new System.Drawing.Size(75, 23);
            this.btnBucarCliente.TabIndex = 23;
            this.btnBucarCliente.Text = "Buscar";
            this.btnBucarCliente.UseVisualStyleBackColor = true;
            this.btnBucarCliente.Click += new System.EventHandler(this.btnBucarCliente_Click);
            // 
            // rBtnRuc
            // 
            this.rBtnRuc.AutoSize = true;
            this.rBtnRuc.Location = new System.Drawing.Point(100, 31);
            this.rBtnRuc.Name = "rBtnRuc";
            this.rBtnRuc.Size = new System.Drawing.Size(48, 17);
            this.rBtnRuc.TabIndex = 21;
            this.rBtnRuc.Text = "RUC";
            this.rBtnRuc.UseVisualStyleBackColor = true;
            this.rBtnRuc.CheckedChanged += new System.EventHandler(this.rBtnRucEliminar_CheckedChanged);
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
            this.rBtnCedula.CheckedChanged += new System.EventHandler(this.rBtnCedulaEliminar_CheckedChanged);
            // 
            // lblAvisoCedulaCliente
            // 
            this.lblAvisoCedulaCliente.AutoSize = true;
            this.lblAvisoCedulaCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvisoCedulaCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblAvisoCedulaCliente.Location = new System.Drawing.Point(332, 70);
            this.lblAvisoCedulaCliente.Name = "lblAvisoCedulaCliente";
            this.lblAvisoCedulaCliente.Size = new System.Drawing.Size(134, 13);
            this.lblAvisoCedulaCliente.TabIndex = 19;
            this.lblAvisoCedulaCliente.Text = "AvisoCedulaClienteEliminar";
            this.lblAvisoCedulaCliente.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Cédula Cliente:";
            // 
            // lblAvisoRucCliente
            // 
            this.lblAvisoRucCliente.AutoSize = true;
            this.lblAvisoRucCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvisoRucCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblAvisoRucCliente.Location = new System.Drawing.Point(332, 100);
            this.lblAvisoRucCliente.Name = "lblAvisoRucCliente";
            this.lblAvisoRucCliente.Size = new System.Drawing.Size(121, 13);
            this.lblAvisoRucCliente.TabIndex = 18;
            this.lblAvisoRucCliente.Text = "AvisoRucClienteElinimar";
            this.lblAvisoRucCliente.Visible = false;
            // 
            // txtCedulaCliente
            // 
            this.txtCedulaCliente.Enabled = false;
            this.txtCedulaCliente.Location = new System.Drawing.Point(136, 63);
            this.txtCedulaCliente.Name = "txtCedulaCliente";
            this.txtCedulaCliente.Size = new System.Drawing.Size(190, 20);
            this.txtCedulaCliente.TabIndex = 5;
            this.txtCedulaCliente.TextChanged += new System.EventHandler(this.txtCedulaClienteEliminar_TextChanged);
            this.txtCedulaCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCedulaClienteEliminar_KeyPress);
            // 
            // txtRucCliente
            // 
            this.txtRucCliente.Enabled = false;
            this.txtRucCliente.Location = new System.Drawing.Point(136, 93);
            this.txtRucCliente.Name = "txtRucCliente";
            this.txtRucCliente.Size = new System.Drawing.Size(190, 20);
            this.txtRucCliente.TabIndex = 6;
            this.txtRucCliente.TextChanged += new System.EventHandler(this.txtRucClienteEliminar_TextChanged);
            this.txtRucCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRucClienteEliminar_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "RUC Cliente:";
            // 
            // FrmBuscarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 327);
            this.Controls.Add(this.dgvBuscarCliente);
            this.Controls.Add(this.groupBox3);
            this.Name = "FrmBuscarCliente";
            this.Text = "Buscar Cliente";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarCliente)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBuscarCliente;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rBtnNombre;
        private System.Windows.Forms.Button btnBucarCliente;
        private System.Windows.Forms.RadioButton rBtnRuc;
        private System.Windows.Forms.RadioButton rBtnCedula;
        private System.Windows.Forms.Label lblAvisoCedulaCliente;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblAvisoRucCliente;
        private System.Windows.Forms.TextBox txtCedulaCliente;
        private System.Windows.Forms.TextBox txtRucCliente;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnBuscarActualizarCliente;
        private System.Windows.Forms.Button btnBuscarIngresarCliente;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lblAvisoNuevoIngreso;
        private System.Windows.Forms.Button btnBuscarTodosCliente;
    }
}