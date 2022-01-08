namespace S.C.A.B.R.E.P
{
    partial class FrmUsuarioEliminar
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnNombreUsuario = new System.Windows.Forms.RadioButton();
            this.rbtnCedulaUsuario = new System.Windows.Forms.RadioButton();
            this.btnEliminarUsuario = new System.Windows.Forms.Button();
            this.lblAvisoCedula = new System.Windows.Forms.Label();
            this.btnSalirUsuario = new System.Windows.Forms.Button();
            this.btnBuscarUsuario = new System.Windows.Forms.Button();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCedulaUsuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvUsuario = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.rbtnNombreUsuario);
            this.groupBox1.Controls.Add(this.rbtnCedulaUsuario);
            this.groupBox1.Controls.Add(this.btnEliminarUsuario);
            this.groupBox1.Controls.Add(this.lblAvisoCedula);
            this.groupBox1.Controls.Add(this.btnSalirUsuario);
            this.groupBox1.Controls.Add(this.btnBuscarUsuario);
            this.groupBox1.Controls.Add(this.txtNombreUsuario);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtCedulaUsuario);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(695, 105);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar Usuario :";
            // 
            // rbtnNombreUsuario
            // 
            this.rbtnNombreUsuario.AutoSize = true;
            this.rbtnNombreUsuario.Location = new System.Drawing.Point(100, 19);
            this.rbtnNombreUsuario.Name = "rbtnNombreUsuario";
            this.rbtnNombreUsuario.Size = new System.Drawing.Size(104, 17);
            this.rbtnNombreUsuario.TabIndex = 14;
            this.rbtnNombreUsuario.TabStop = true;
            this.rbtnNombreUsuario.Text = "Nombre/Apellido";
            this.rbtnNombreUsuario.UseVisualStyleBackColor = true;
            this.rbtnNombreUsuario.CheckedChanged += new System.EventHandler(this.rbtnNombreUsuario_CheckedChanged);
            // 
            // rbtnCedulaUsuario
            // 
            this.rbtnCedulaUsuario.AutoSize = true;
            this.rbtnCedulaUsuario.Location = new System.Drawing.Point(9, 19);
            this.rbtnCedulaUsuario.Name = "rbtnCedulaUsuario";
            this.rbtnCedulaUsuario.Size = new System.Drawing.Size(58, 17);
            this.rbtnCedulaUsuario.TabIndex = 13;
            this.rbtnCedulaUsuario.TabStop = true;
            this.rbtnCedulaUsuario.Text = "Cedula";
            this.rbtnCedulaUsuario.UseVisualStyleBackColor = true;
            this.rbtnCedulaUsuario.CheckedChanged += new System.EventHandler(this.rbtnCedulaUsuario_CheckedChanged);
            // 
            // btnEliminarUsuario
            // 
            this.btnEliminarUsuario.Location = new System.Drawing.Point(535, 75);
            this.btnEliminarUsuario.Name = "btnEliminarUsuario";
            this.btnEliminarUsuario.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarUsuario.TabIndex = 12;
            this.btnEliminarUsuario.Text = "Eliminar";
            this.btnEliminarUsuario.UseVisualStyleBackColor = true;
            this.btnEliminarUsuario.Click += new System.EventHandler(this.btnEliminarUsuario_Click);
            // 
            // lblAvisoCedula
            // 
            this.lblAvisoCedula.AutoSize = true;
            this.lblAvisoCedula.ForeColor = System.Drawing.Color.Red;
            this.lblAvisoCedula.Location = new System.Drawing.Point(306, 58);
            this.lblAvisoCedula.Name = "lblAvisoCedula";
            this.lblAvisoCedula.Size = new System.Drawing.Size(35, 13);
            this.lblAvisoCedula.TabIndex = 11;
            this.lblAvisoCedula.Text = "label7";
            this.lblAvisoCedula.Visible = false;
            // 
            // btnSalirUsuario
            // 
            this.btnSalirUsuario.Location = new System.Drawing.Point(616, 75);
            this.btnSalirUsuario.Name = "btnSalirUsuario";
            this.btnSalirUsuario.Size = new System.Drawing.Size(75, 23);
            this.btnSalirUsuario.TabIndex = 7;
            this.btnSalirUsuario.Text = "Salir";
            this.btnSalirUsuario.UseVisualStyleBackColor = true;
            this.btnSalirUsuario.Click += new System.EventHandler(this.btnSalirUsuario_Click);
            // 
            // btnBuscarUsuario
            // 
            this.btnBuscarUsuario.Location = new System.Drawing.Point(454, 75);
            this.btnBuscarUsuario.Name = "btnBuscarUsuario";
            this.btnBuscarUsuario.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarUsuario.TabIndex = 6;
            this.btnBuscarUsuario.Text = "Buscar";
            this.btnBuscarUsuario.UseVisualStyleBackColor = true;
            this.btnBuscarUsuario.Click += new System.EventHandler(this.btnBuscarUsuario_Click);
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Enabled = false;
            this.txtNombreUsuario.Location = new System.Drawing.Point(139, 77);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(160, 20);
            this.txtNombreUsuario.TabIndex = 2;
            this.txtNombreUsuario.TextChanged += new System.EventHandler(this.txtNombreUsuario_TextChanged);
            this.txtNombreUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreUsuario_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cédula Usuario:";
            // 
            // txtCedulaUsuario
            // 
            this.txtCedulaUsuario.Enabled = false;
            this.txtCedulaUsuario.Location = new System.Drawing.Point(139, 51);
            this.txtCedulaUsuario.Name = "txtCedulaUsuario";
            this.txtCedulaUsuario.Size = new System.Drawing.Size(160, 20);
            this.txtCedulaUsuario.TabIndex = 1;
            this.txtCedulaUsuario.TextChanged += new System.EventHandler(this.txtCedulaUsuario_TextChanged);
            this.txtCedulaUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCedulaUsuario_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre/Apellido Usuario:";
            // 
            // dgvUsuario
            // 
            this.dgvUsuario.AllowUserToAddRows = false;
            this.dgvUsuario.AllowUserToDeleteRows = false;
            this.dgvUsuario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvUsuario.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuario.Location = new System.Drawing.Point(12, 123);
            this.dgvUsuario.Name = "dgvUsuario";
            this.dgvUsuario.ReadOnly = true;
            this.dgvUsuario.Size = new System.Drawing.Size(695, 150);
            this.dgvUsuario.TabIndex = 3;
            this.dgvUsuario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuario_CellClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(614, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 56);
            this.button1.TabIndex = 15;
            this.button1.Text = "Buscar Todos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmUsuarioEliminar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 289);
            this.Controls.Add(this.dgvUsuario);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmUsuarioEliminar";
            this.Text = "Eliminar Usuario ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEliminarUsuario;
        private System.Windows.Forms.Label lblAvisoCedula;
        private System.Windows.Forms.Button btnSalirUsuario;
        private System.Windows.Forms.Button btnBuscarUsuario;
        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCedulaUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvUsuario;
        private System.Windows.Forms.RadioButton rbtnNombreUsuario;
        private System.Windows.Forms.RadioButton rbtnCedulaUsuario;
        private System.Windows.Forms.Button button1;
    }
}