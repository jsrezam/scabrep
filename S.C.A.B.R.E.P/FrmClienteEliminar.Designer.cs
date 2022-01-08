namespace S.C.A.B.R.E.P
{
    partial class FrmClienteEliminar
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtNombreClienteEliminar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rBtnNombreEliminar = new System.Windows.Forms.RadioButton();
            this.btnCancelarEliminarCliente = new System.Windows.Forms.Button();
            this.btnEliminarCliente = new System.Windows.Forms.Button();
            this.btnBucarEliminarCliente = new System.Windows.Forms.Button();
            this.rBtnRucEliminar = new System.Windows.Forms.RadioButton();
            this.rBtnCedulaEliminar = new System.Windows.Forms.RadioButton();
            this.lblAvisoCedulaClienteEliminar = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblAvisoRucClienteEliminar = new System.Windows.Forms.Label();
            this.txtCedulaClienteEliminar = new System.Windows.Forms.TextBox();
            this.txtRucClienteEliminar = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvBuscarClienteEliminar = new System.Windows.Forms.DataGridView();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarClienteEliminar)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.txtNombreClienteEliminar);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.rBtnNombreEliminar);
            this.groupBox3.Controls.Add(this.btnCancelarEliminarCliente);
            this.groupBox3.Controls.Add(this.btnEliminarCliente);
            this.groupBox3.Controls.Add(this.btnBucarEliminarCliente);
            this.groupBox3.Controls.Add(this.rBtnRucEliminar);
            this.groupBox3.Controls.Add(this.rBtnCedulaEliminar);
            this.groupBox3.Controls.Add(this.lblAvisoCedulaClienteEliminar);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.lblAvisoRucClienteEliminar);
            this.groupBox3.Controls.Add(this.txtCedulaClienteEliminar);
            this.groupBox3.Controls.Add(this.txtRucClienteEliminar);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(850, 154);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Buscar Cliente Según: Cedula/RUC/Cedula-RUC";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(767, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 51);
            this.button1.TabIndex = 29;
            this.button1.Text = "Buscar Todos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtNombreClienteEliminar
            // 
            this.txtNombreClienteEliminar.Enabled = false;
            this.txtNombreClienteEliminar.Location = new System.Drawing.Point(136, 122);
            this.txtNombreClienteEliminar.Name = "txtNombreClienteEliminar";
            this.txtNombreClienteEliminar.Size = new System.Drawing.Size(257, 20);
            this.txtNombreClienteEliminar.TabIndex = 28;
            this.txtNombreClienteEliminar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreClienteEliminar_KeyPress);
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
            // rBtnNombreEliminar
            // 
            this.rBtnNombreEliminar.AutoSize = true;
            this.rBtnNombreEliminar.Location = new System.Drawing.Point(203, 31);
            this.rBtnNombreEliminar.Name = "rBtnNombreEliminar";
            this.rBtnNombreEliminar.Size = new System.Drawing.Size(104, 17);
            this.rBtnNombreEliminar.TabIndex = 26;
            this.rBtnNombreEliminar.Text = "Nombre/Apellido";
            this.rBtnNombreEliminar.UseVisualStyleBackColor = true;
            this.rBtnNombreEliminar.CheckedChanged += new System.EventHandler(this.rBtnNombreEliminar_CheckedChanged);
            // 
            // btnCancelarEliminarCliente
            // 
            this.btnCancelarEliminarCliente.Location = new System.Drawing.Point(767, 125);
            this.btnCancelarEliminarCliente.Name = "btnCancelarEliminarCliente";
            this.btnCancelarEliminarCliente.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarEliminarCliente.TabIndex = 25;
            this.btnCancelarEliminarCliente.Text = "Salir";
            this.btnCancelarEliminarCliente.UseVisualStyleBackColor = true;
            this.btnCancelarEliminarCliente.Click += new System.EventHandler(this.btnCancelarEliminarCliente_Click);
            // 
            // btnEliminarCliente
            // 
            this.btnEliminarCliente.Location = new System.Drawing.Point(686, 125);
            this.btnEliminarCliente.Name = "btnEliminarCliente";
            this.btnEliminarCliente.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarCliente.TabIndex = 24;
            this.btnEliminarCliente.Text = "Eliminar";
            this.btnEliminarCliente.UseVisualStyleBackColor = true;
            this.btnEliminarCliente.Click += new System.EventHandler(this.btnEliminarCliente_Click);
            // 
            // btnBucarEliminarCliente
            // 
            this.btnBucarEliminarCliente.Location = new System.Drawing.Point(605, 125);
            this.btnBucarEliminarCliente.Name = "btnBucarEliminarCliente";
            this.btnBucarEliminarCliente.Size = new System.Drawing.Size(75, 23);
            this.btnBucarEliminarCliente.TabIndex = 23;
            this.btnBucarEliminarCliente.Text = "Buscar";
            this.btnBucarEliminarCliente.UseVisualStyleBackColor = true;
            this.btnBucarEliminarCliente.Click += new System.EventHandler(this.btnBucarEliminarCliente_Click);
            // 
            // rBtnRucEliminar
            // 
            this.rBtnRucEliminar.AutoSize = true;
            this.rBtnRucEliminar.Location = new System.Drawing.Point(100, 31);
            this.rBtnRucEliminar.Name = "rBtnRucEliminar";
            this.rBtnRucEliminar.Size = new System.Drawing.Size(48, 17);
            this.rBtnRucEliminar.TabIndex = 21;
            this.rBtnRucEliminar.Text = "RUC";
            this.rBtnRucEliminar.UseVisualStyleBackColor = true;
            this.rBtnRucEliminar.CheckedChanged += new System.EventHandler(this.rBtnRucEliminar_CheckedChanged);
            // 
            // rBtnCedulaEliminar
            // 
            this.rBtnCedulaEliminar.AutoSize = true;
            this.rBtnCedulaEliminar.Location = new System.Drawing.Point(6, 31);
            this.rBtnCedulaEliminar.Name = "rBtnCedulaEliminar";
            this.rBtnCedulaEliminar.Size = new System.Drawing.Size(58, 17);
            this.rBtnCedulaEliminar.TabIndex = 20;
            this.rBtnCedulaEliminar.Text = "Cédula";
            this.rBtnCedulaEliminar.UseVisualStyleBackColor = true;
            this.rBtnCedulaEliminar.CheckedChanged += new System.EventHandler(this.rBtnCedulaEliminar_CheckedChanged_1);
            // 
            // lblAvisoCedulaClienteEliminar
            // 
            this.lblAvisoCedulaClienteEliminar.AutoSize = true;
            this.lblAvisoCedulaClienteEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvisoCedulaClienteEliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblAvisoCedulaClienteEliminar.Location = new System.Drawing.Point(405, 70);
            this.lblAvisoCedulaClienteEliminar.Name = "lblAvisoCedulaClienteEliminar";
            this.lblAvisoCedulaClienteEliminar.Size = new System.Drawing.Size(134, 13);
            this.lblAvisoCedulaClienteEliminar.TabIndex = 19;
            this.lblAvisoCedulaClienteEliminar.Text = "AvisoCedulaClienteEliminar";
            this.lblAvisoCedulaClienteEliminar.Visible = false;
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
            // lblAvisoRucClienteEliminar
            // 
            this.lblAvisoRucClienteEliminar.AutoSize = true;
            this.lblAvisoRucClienteEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvisoRucClienteEliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblAvisoRucClienteEliminar.Location = new System.Drawing.Point(405, 100);
            this.lblAvisoRucClienteEliminar.Name = "lblAvisoRucClienteEliminar";
            this.lblAvisoRucClienteEliminar.Size = new System.Drawing.Size(121, 13);
            this.lblAvisoRucClienteEliminar.TabIndex = 18;
            this.lblAvisoRucClienteEliminar.Text = "AvisoRucClienteElinimar";
            this.lblAvisoRucClienteEliminar.Visible = false;
            // 
            // txtCedulaClienteEliminar
            // 
            this.txtCedulaClienteEliminar.Enabled = false;
            this.txtCedulaClienteEliminar.Location = new System.Drawing.Point(136, 63);
            this.txtCedulaClienteEliminar.Name = "txtCedulaClienteEliminar";
            this.txtCedulaClienteEliminar.Size = new System.Drawing.Size(257, 20);
            this.txtCedulaClienteEliminar.TabIndex = 5;
            this.txtCedulaClienteEliminar.TextChanged += new System.EventHandler(this.txtCedulaClienteEliminar_TextChanged);
            this.txtCedulaClienteEliminar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCedulaClienteEliminar_KeyPress);
            // 
            // txtRucClienteEliminar
            // 
            this.txtRucClienteEliminar.Enabled = false;
            this.txtRucClienteEliminar.Location = new System.Drawing.Point(136, 93);
            this.txtRucClienteEliminar.Name = "txtRucClienteEliminar";
            this.txtRucClienteEliminar.Size = new System.Drawing.Size(257, 20);
            this.txtRucClienteEliminar.TabIndex = 6;
            this.txtRucClienteEliminar.TextChanged += new System.EventHandler(this.txtRucClienteEliminar_TextChanged);
            this.txtRucClienteEliminar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRucClienteEliminar_KeyPress);
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
            // dgvBuscarClienteEliminar
            // 
            this.dgvBuscarClienteEliminar.AllowUserToAddRows = false;
            this.dgvBuscarClienteEliminar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvBuscarClienteEliminar.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvBuscarClienteEliminar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuscarClienteEliminar.Location = new System.Drawing.Point(12, 172);
            this.dgvBuscarClienteEliminar.MultiSelect = false;
            this.dgvBuscarClienteEliminar.Name = "dgvBuscarClienteEliminar";
            this.dgvBuscarClienteEliminar.ReadOnly = true;
            this.dgvBuscarClienteEliminar.Size = new System.Drawing.Size(850, 150);
            this.dgvBuscarClienteEliminar.TabIndex = 6;
            this.dgvBuscarClienteEliminar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBuscarClienteEliminar_CellClick);
            // 
            // FrmClienteEliminar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 337);
            this.Controls.Add(this.dgvBuscarClienteEliminar);
            this.Controls.Add(this.groupBox3);
            this.Name = "FrmClienteEliminar";
            this.Text = "Eliminar Cliente";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarClienteEliminar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rBtnRucEliminar;
        private System.Windows.Forms.RadioButton rBtnCedulaEliminar;
        private System.Windows.Forms.Label lblAvisoCedulaClienteEliminar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblAvisoRucClienteEliminar;
        private System.Windows.Forms.TextBox txtCedulaClienteEliminar;
        private System.Windows.Forms.TextBox txtRucClienteEliminar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvBuscarClienteEliminar;
        private System.Windows.Forms.Button btnBucarEliminarCliente;
        private System.Windows.Forms.Button btnEliminarCliente;
        private System.Windows.Forms.Button btnCancelarEliminarCliente;
        private System.Windows.Forms.RadioButton rBtnNombreEliminar;
        private System.Windows.Forms.TextBox txtNombreClienteEliminar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}