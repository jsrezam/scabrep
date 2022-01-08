namespace S.C.A.B.R.E.P
{
    partial class FrmConsultasFactura
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.gbFechas = new System.Windows.Forms.GroupBox();
            this.dtpFinal = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpIncial = new System.Windows.Forms.DateTimePicker();
            this.rBtnFechas = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblAvisoNombre = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumFactura = new System.Windows.Forms.TextBox();
            this.rbtnNumeroFactura = new System.Windows.Forms.RadioButton();
            this.lblAvisoNuevoIngreso = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
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
            this.dgvBuscarCliente = new System.Windows.Forms.DataGridView();
            this.groupBox3.SuspendLayout();
            this.gbFechas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.gbFechas);
            this.groupBox3.Controls.Add(this.rBtnFechas);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.lblAvisoNombre);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txtNumFactura);
            this.groupBox3.Controls.Add(this.rbtnNumeroFactura);
            this.groupBox3.Controls.Add(this.lblAvisoNuevoIngreso);
            this.groupBox3.Controls.Add(this.btnCancelar);
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
            this.groupBox3.Size = new System.Drawing.Size(850, 231);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Buscar Factura Según: Nombre/Apellido Cliente /Cedula Cliente/RUC Cliente";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(772, 64);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(72, 43);
            this.button3.TabIndex = 44;
            this.button3.Text = "Anular Factura";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // gbFechas
            // 
            this.gbFechas.Controls.Add(this.dtpFinal);
            this.gbFechas.Controls.Add(this.label5);
            this.gbFechas.Controls.Add(this.label4);
            this.gbFechas.Controls.Add(this.dtpIncial);
            this.gbFechas.Enabled = false;
            this.gbFechas.Location = new System.Drawing.Point(475, 48);
            this.gbFechas.Name = "gbFechas";
            this.gbFechas.Size = new System.Drawing.Size(290, 122);
            this.gbFechas.TabIndex = 43;
            this.gbFechas.TabStop = false;
            // 
            // dtpFinal
            // 
            this.dtpFinal.Location = new System.Drawing.Point(6, 86);
            this.dtpFinal.Name = "dtpFinal";
            this.dtpFinal.Size = new System.Drawing.Size(200, 20);
            this.dtpFinal.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Fecha Final";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Fecha Inicial";
            // 
            // dtpIncial
            // 
            this.dtpIncial.Location = new System.Drawing.Point(6, 32);
            this.dtpIncial.Name = "dtpIncial";
            this.dtpIncial.Size = new System.Drawing.Size(200, 20);
            this.dtpIncial.TabIndex = 0;
            // 
            // rBtnFechas
            // 
            this.rBtnFechas.AutoSize = true;
            this.rBtnFechas.Location = new System.Drawing.Point(450, 25);
            this.rBtnFechas.Name = "rBtnFechas";
            this.rBtnFechas.Size = new System.Drawing.Size(110, 17);
            this.rBtnFechas.TabIndex = 42;
            this.rBtnFechas.Text = "Rango de Fechas";
            this.rBtnFechas.UseVisualStyleBackColor = true;
            this.rBtnFechas.CheckedChanged += new System.EventHandler(this.rBtnFechas_CheckedChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(788, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(56, 43);
            this.button2.TabIndex = 41;
            this.button2.Text = "Buscar Todas";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(772, 169);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 56);
            this.button1.TabIndex = 11;
            this.button1.Text = "Ver detalle factura";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblAvisoNombre
            // 
            this.lblAvisoNombre.AutoSize = true;
            this.lblAvisoNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvisoNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblAvisoNombre.Location = new System.Drawing.Point(335, 173);
            this.lblAvisoNombre.Name = "lblAvisoNombre";
            this.lblAvisoNombre.Size = new System.Drawing.Size(250, 13);
            this.lblAvisoNombre.TabIndex = 40;
            this.lblAvisoNombre.Text = "Si busca Persona natural ingrese Nombre y Apellido";
            this.lblAvisoNombre.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Numero Factura:";
            // 
            // txtNumFactura
            // 
            this.txtNumFactura.Enabled = false;
            this.txtNumFactura.Location = new System.Drawing.Point(139, 65);
            this.txtNumFactura.Name = "txtNumFactura";
            this.txtNumFactura.Size = new System.Drawing.Size(190, 20);
            this.txtNumFactura.TabIndex = 5;
            this.txtNumFactura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumFactura_KeyPress);
            // 
            // rbtnNumeroFactura
            // 
            this.rbtnNumeroFactura.AutoSize = true;
            this.rbtnNumeroFactura.Location = new System.Drawing.Point(9, 25);
            this.rbtnNumeroFactura.Name = "rbtnNumeroFactura";
            this.rbtnNumeroFactura.Size = new System.Drawing.Size(101, 17);
            this.rbtnNumeroFactura.TabIndex = 1;
            this.rbtnNumeroFactura.Text = "Numero Factura";
            this.rbtnNumeroFactura.UseVisualStyleBackColor = true;
            this.rbtnNumeroFactura.CheckedChanged += new System.EventHandler(this.rbtnNumeroFactura_CheckedChanged);
            // 
            // lblAvisoNuevoIngreso
            // 
            this.lblAvisoNuevoIngreso.AutoSize = true;
            this.lblAvisoNuevoIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvisoNuevoIngreso.ForeColor = System.Drawing.Color.Red;
            this.lblAvisoNuevoIngreso.Location = new System.Drawing.Point(416, 212);
            this.lblAvisoNuevoIngreso.Name = "lblAvisoNuevoIngreso";
            this.lblAvisoNuevoIngreso.Size = new System.Drawing.Size(187, 13);
            this.lblAvisoNuevoIngreso.TabIndex = 34;
            this.lblAvisoNuevoIngreso.Text = "Busque el nuevo Cliente Ingresado -->";
            this.lblAvisoNuevoIngreso.Visible = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(690, 202);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Enabled = false;
            this.txtNombreCliente.Location = new System.Drawing.Point(140, 166);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(190, 20);
            this.txtNombreCliente.TabIndex = 8;
            this.txtNombreCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreCliente_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Nombre Cliente:";
            // 
            // rBtnNombre
            // 
            this.rBtnNombre.AutoSize = true;
            this.rBtnNombre.Location = new System.Drawing.Point(316, 25);
            this.rBtnNombre.Name = "rBtnNombre";
            this.rBtnNombre.Size = new System.Drawing.Size(104, 17);
            this.rBtnNombre.TabIndex = 4;
            this.rBtnNombre.Text = "Nombre/Apellido";
            this.rBtnNombre.UseVisualStyleBackColor = true;
            this.rBtnNombre.CheckedChanged += new System.EventHandler(this.rBtnNombre_CheckedChanged);
            // 
            // btnBucarCliente
            // 
            this.btnBucarCliente.Location = new System.Drawing.Point(609, 202);
            this.btnBucarCliente.Name = "btnBucarCliente";
            this.btnBucarCliente.Size = new System.Drawing.Size(75, 23);
            this.btnBucarCliente.TabIndex = 10;
            this.btnBucarCliente.Text = "Buscar";
            this.btnBucarCliente.UseVisualStyleBackColor = true;
            this.btnBucarCliente.Click += new System.EventHandler(this.btnBucarCliente_Click);
            // 
            // rBtnRuc
            // 
            this.rBtnRuc.AutoSize = true;
            this.rBtnRuc.Location = new System.Drawing.Point(233, 25);
            this.rBtnRuc.Name = "rBtnRuc";
            this.rBtnRuc.Size = new System.Drawing.Size(48, 17);
            this.rBtnRuc.TabIndex = 3;
            this.rBtnRuc.Text = "RUC";
            this.rBtnRuc.UseVisualStyleBackColor = true;
            this.rBtnRuc.CheckedChanged += new System.EventHandler(this.rBtnRuc_CheckedChanged);
            // 
            // rBtnCedula
            // 
            this.rBtnCedula.AutoSize = true;
            this.rBtnCedula.Location = new System.Drawing.Point(139, 25);
            this.rBtnCedula.Name = "rBtnCedula";
            this.rBtnCedula.Size = new System.Drawing.Size(58, 17);
            this.rBtnCedula.TabIndex = 2;
            this.rBtnCedula.Text = "Cédula";
            this.rBtnCedula.UseVisualStyleBackColor = true;
            this.rBtnCedula.CheckedChanged += new System.EventHandler(this.rBtnCedula_CheckedChanged);
            // 
            // lblAvisoCedulaCliente
            // 
            this.lblAvisoCedulaCliente.AutoSize = true;
            this.lblAvisoCedulaCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvisoCedulaCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblAvisoCedulaCliente.Location = new System.Drawing.Point(335, 103);
            this.lblAvisoCedulaCliente.Name = "lblAvisoCedulaCliente";
            this.lblAvisoCedulaCliente.Size = new System.Drawing.Size(134, 13);
            this.lblAvisoCedulaCliente.TabIndex = 19;
            this.lblAvisoCedulaCliente.Text = "AvisoCedulaClienteEliminar";
            this.lblAvisoCedulaCliente.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 103);
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
            this.lblAvisoRucCliente.Location = new System.Drawing.Point(335, 140);
            this.lblAvisoRucCliente.Name = "lblAvisoRucCliente";
            this.lblAvisoRucCliente.Size = new System.Drawing.Size(121, 13);
            this.lblAvisoRucCliente.TabIndex = 18;
            this.lblAvisoRucCliente.Text = "AvisoRucClienteElinimar";
            this.lblAvisoRucCliente.Visible = false;
            // 
            // txtCedulaCliente
            // 
            this.txtCedulaCliente.Enabled = false;
            this.txtCedulaCliente.Location = new System.Drawing.Point(139, 96);
            this.txtCedulaCliente.Name = "txtCedulaCliente";
            this.txtCedulaCliente.Size = new System.Drawing.Size(190, 20);
            this.txtCedulaCliente.TabIndex = 6;
            this.txtCedulaCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCedulaCliente_KeyPress);
            // 
            // txtRucCliente
            // 
            this.txtRucCliente.Enabled = false;
            this.txtRucCliente.Location = new System.Drawing.Point(139, 133);
            this.txtRucCliente.Name = "txtRucCliente";
            this.txtRucCliente.Size = new System.Drawing.Size(190, 20);
            this.txtRucCliente.TabIndex = 7;
            this.txtRucCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRucCliente_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 140);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "RUC Cliente:";
            // 
            // dgvBuscarCliente
            // 
            this.dgvBuscarCliente.AllowUserToAddRows = false;
            this.dgvBuscarCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvBuscarCliente.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvBuscarCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuscarCliente.Location = new System.Drawing.Point(12, 249);
            this.dgvBuscarCliente.MultiSelect = false;
            this.dgvBuscarCliente.Name = "dgvBuscarCliente";
            this.dgvBuscarCliente.ReadOnly = true;
            this.dgvBuscarCliente.Size = new System.Drawing.Size(850, 297);
            this.dgvBuscarCliente.TabIndex = 9;
            this.dgvBuscarCliente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBuscarClienteEliminar_CellClick);
            // 
            // FrmConsultasFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 558);
            this.Controls.Add(this.dgvBuscarCliente);
            this.Controls.Add(this.groupBox3);
            this.Name = "FrmConsultasFactura";
            this.Text = "Consulta Factura";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.gbFechas.ResumeLayout(false);
            this.gbFechas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarCliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblAvisoNuevoIngreso;
        private System.Windows.Forms.Button btnCancelar;
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
        private System.Windows.Forms.DataGridView dgvBuscarCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumFactura;
        private System.Windows.Forms.RadioButton rbtnNumeroFactura;
        private System.Windows.Forms.Label lblAvisoNombre;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox gbFechas;
        private System.Windows.Forms.DateTimePicker dtpFinal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpIncial;
        private System.Windows.Forms.RadioButton rBtnFechas;
        private System.Windows.Forms.Button button3;

    }
}