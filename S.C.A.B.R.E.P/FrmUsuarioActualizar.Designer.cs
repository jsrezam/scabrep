namespace S.C.A.B.R.E.P
{
    partial class FrmUsuarioActualizar
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.rbtnNombreUsuario = new System.Windows.Forms.RadioButton();
            this.rbtnCedulaUsuario = new System.Windows.Forms.RadioButton();
            this.lblAvisoCedula = new System.Windows.Forms.Label();
            this.btnBuscarUsuario = new System.Windows.Forms.Button();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCedulaUsuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbtnMantenerPassword = new System.Windows.Forms.RadioButton();
            this.rbtnPassword = new System.Windows.Forms.RadioButton();
            this.btnPredeterminadoUsuario = new System.Windows.Forms.Button();
            this.lblAvisoCedulaAyudante = new System.Windows.Forms.Label();
            this.lblAvisoREPassword = new System.Windows.Forms.Label();
            this.lblAvisoPassword = new System.Windows.Forms.Label();
            this.btnSalirUsuario = new System.Windows.Forms.Button();
            this.txtREPasswordUsuarioAyudante = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnActualizarUsuario = new System.Windows.Forms.Button();
            this.txtPasswordUsuarioAyudante = new System.Windows.Forms.TextBox();
            this.txtApellidoUsuarioAyudante = new System.Windows.Forms.TextBox();
            this.txtNombreUsuarioAyudante = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCedulaUsuarioAyudante = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuario)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvUsuario
            // 
            this.dgvUsuario.AllowUserToAddRows = false;
            this.dgvUsuario.AllowUserToDeleteRows = false;
            this.dgvUsuario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvUsuario.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuario.Location = new System.Drawing.Point(6, 114);
            this.dgvUsuario.Name = "dgvUsuario";
            this.dgvUsuario.ReadOnly = true;
            this.dgvUsuario.Size = new System.Drawing.Size(695, 150);
            this.dgvUsuario.TabIndex = 5;
            this.dgvUsuario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuario_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.rbtnNombreUsuario);
            this.groupBox1.Controls.Add(this.rbtnCedulaUsuario);
            this.groupBox1.Controls.Add(this.lblAvisoCedula);
            this.groupBox1.Controls.Add(this.btnBuscarUsuario);
            this.groupBox1.Controls.Add(this.txtNombreUsuario);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtCedulaUsuario);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(6, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(695, 105);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar Usuario :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(591, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 52);
            this.button1.TabIndex = 15;
            this.button1.Text = "Observar Todos los Usuarios";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            // btnBuscarUsuario
            // 
            this.btnBuscarUsuario.Location = new System.Drawing.Point(614, 79);
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbtnMantenerPassword);
            this.groupBox2.Controls.Add(this.rbtnPassword);
            this.groupBox2.Controls.Add(this.btnPredeterminadoUsuario);
            this.groupBox2.Controls.Add(this.lblAvisoCedulaAyudante);
            this.groupBox2.Controls.Add(this.lblAvisoREPassword);
            this.groupBox2.Controls.Add(this.lblAvisoPassword);
            this.groupBox2.Controls.Add(this.btnSalirUsuario);
            this.groupBox2.Controls.Add(this.txtREPasswordUsuarioAyudante);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btnActualizarUsuario);
            this.groupBox2.Controls.Add(this.txtPasswordUsuarioAyudante);
            this.groupBox2.Controls.Add(this.txtApellidoUsuarioAyudante);
            this.groupBox2.Controls.Add(this.txtNombreUsuarioAyudante);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtCedulaUsuarioAyudante);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(6, 270);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(580, 223);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos Usuario:";
            // 
            // rbtnMantenerPassword
            // 
            this.rbtnMantenerPassword.AutoSize = true;
            this.rbtnMantenerPassword.Enabled = false;
            this.rbtnMantenerPassword.Location = new System.Drawing.Point(126, 103);
            this.rbtnMantenerPassword.Name = "rbtnMantenerPassword";
            this.rbtnMantenerPassword.Size = new System.Drawing.Size(119, 17);
            this.rbtnMantenerPassword.TabIndex = 14;
            this.rbtnMantenerPassword.TabStop = true;
            this.rbtnMantenerPassword.Text = "Mantener Password";
            this.rbtnMantenerPassword.UseVisualStyleBackColor = true;
            this.rbtnMantenerPassword.CheckedChanged += new System.EventHandler(this.rbtnMantenerPassword_CheckedChanged);
            // 
            // rbtnPassword
            // 
            this.rbtnPassword.AutoSize = true;
            this.rbtnPassword.Enabled = false;
            this.rbtnPassword.Location = new System.Drawing.Point(11, 103);
            this.rbtnPassword.Name = "rbtnPassword";
            this.rbtnPassword.Size = new System.Drawing.Size(112, 17);
            this.rbtnPassword.TabIndex = 13;
            this.rbtnPassword.TabStop = true;
            this.rbtnPassword.Text = "Cambiar Password";
            this.rbtnPassword.UseVisualStyleBackColor = true;
            this.rbtnPassword.CheckedChanged += new System.EventHandler(this.rbtnPassword_CheckedChanged);
            // 
            // btnPredeterminadoUsuario
            // 
            this.btnPredeterminadoUsuario.Enabled = false;
            this.btnPredeterminadoUsuario.Location = new System.Drawing.Point(87, 194);
            this.btnPredeterminadoUsuario.Name = "btnPredeterminadoUsuario";
            this.btnPredeterminadoUsuario.Size = new System.Drawing.Size(103, 23);
            this.btnPredeterminadoUsuario.TabIndex = 12;
            this.btnPredeterminadoUsuario.Text = "Predeterminado";
            this.btnPredeterminadoUsuario.UseVisualStyleBackColor = true;
            this.btnPredeterminadoUsuario.Click += new System.EventHandler(this.btnPredeterminadoUsuario_Click_1);
            // 
            // lblAvisoCedulaAyudante
            // 
            this.lblAvisoCedulaAyudante.AutoSize = true;
            this.lblAvisoCedulaAyudante.ForeColor = System.Drawing.Color.Red;
            this.lblAvisoCedulaAyudante.Location = new System.Drawing.Point(292, 31);
            this.lblAvisoCedulaAyudante.Name = "lblAvisoCedulaAyudante";
            this.lblAvisoCedulaAyudante.Size = new System.Drawing.Size(35, 13);
            this.lblAvisoCedulaAyudante.TabIndex = 11;
            this.lblAvisoCedulaAyudante.Text = "label7";
            this.lblAvisoCedulaAyudante.Visible = false;
            // 
            // lblAvisoREPassword
            // 
            this.lblAvisoREPassword.AutoSize = true;
            this.lblAvisoREPassword.ForeColor = System.Drawing.Color.Red;
            this.lblAvisoREPassword.Location = new System.Drawing.Point(293, 162);
            this.lblAvisoREPassword.Name = "lblAvisoREPassword";
            this.lblAvisoREPassword.Size = new System.Drawing.Size(35, 13);
            this.lblAvisoREPassword.TabIndex = 10;
            this.lblAvisoREPassword.Text = "label7";
            this.lblAvisoREPassword.Visible = false;
            // 
            // lblAvisoPassword
            // 
            this.lblAvisoPassword.AutoSize = true;
            this.lblAvisoPassword.ForeColor = System.Drawing.Color.Blue;
            this.lblAvisoPassword.Location = new System.Drawing.Point(293, 133);
            this.lblAvisoPassword.Name = "lblAvisoPassword";
            this.lblAvisoPassword.Size = new System.Drawing.Size(35, 13);
            this.lblAvisoPassword.TabIndex = 9;
            this.lblAvisoPassword.Text = "label6";
            this.lblAvisoPassword.Visible = false;
            // 
            // btnSalirUsuario
            // 
            this.btnSalirUsuario.Location = new System.Drawing.Point(196, 194);
            this.btnSalirUsuario.Name = "btnSalirUsuario";
            this.btnSalirUsuario.Size = new System.Drawing.Size(75, 23);
            this.btnSalirUsuario.TabIndex = 7;
            this.btnSalirUsuario.Text = "Salir";
            this.btnSalirUsuario.UseVisualStyleBackColor = true;
            this.btnSalirUsuario.Click += new System.EventHandler(this.btnSalirUsuario_Click_1);
            // 
            // txtREPasswordUsuarioAyudante
            // 
            this.txtREPasswordUsuarioAyudante.Enabled = false;
            this.txtREPasswordUsuarioAyudante.Location = new System.Drawing.Point(127, 155);
            this.txtREPasswordUsuarioAyudante.Name = "txtREPasswordUsuarioAyudante";
            this.txtREPasswordUsuarioAyudante.PasswordChar = '*';
            this.txtREPasswordUsuarioAyudante.Size = new System.Drawing.Size(160, 20);
            this.txtREPasswordUsuarioAyudante.TabIndex = 5;
            this.txtREPasswordUsuarioAyudante.TextChanged += new System.EventHandler(this.txtREPasswordUsuarioAyudante_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "RE-Password Usuario:";
            // 
            // btnActualizarUsuario
            // 
            this.btnActualizarUsuario.Location = new System.Drawing.Point(6, 194);
            this.btnActualizarUsuario.Name = "btnActualizarUsuario";
            this.btnActualizarUsuario.Size = new System.Drawing.Size(75, 23);
            this.btnActualizarUsuario.TabIndex = 6;
            this.btnActualizarUsuario.Text = "Actualizar";
            this.btnActualizarUsuario.UseVisualStyleBackColor = true;
            this.btnActualizarUsuario.Click += new System.EventHandler(this.btnActualizarUsuario_Click);
            // 
            // txtPasswordUsuarioAyudante
            // 
            this.txtPasswordUsuarioAyudante.Enabled = false;
            this.txtPasswordUsuarioAyudante.Location = new System.Drawing.Point(127, 126);
            this.txtPasswordUsuarioAyudante.Name = "txtPasswordUsuarioAyudante";
            this.txtPasswordUsuarioAyudante.PasswordChar = '*';
            this.txtPasswordUsuarioAyudante.Size = new System.Drawing.Size(160, 20);
            this.txtPasswordUsuarioAyudante.TabIndex = 4;
            this.txtPasswordUsuarioAyudante.TextChanged += new System.EventHandler(this.txtPasswordUsuarioAyudante_TextChanged);
            // 
            // txtApellidoUsuarioAyudante
            // 
            this.txtApellidoUsuarioAyudante.Location = new System.Drawing.Point(126, 76);
            this.txtApellidoUsuarioAyudante.Name = "txtApellidoUsuarioAyudante";
            this.txtApellidoUsuarioAyudante.Size = new System.Drawing.Size(160, 20);
            this.txtApellidoUsuarioAyudante.TabIndex = 3;
            this.txtApellidoUsuarioAyudante.TextChanged += new System.EventHandler(this.txtApellidoUsuarioAyudante_TextChanged);
            this.txtApellidoUsuarioAyudante.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellidoUsuarioAyudante_KeyPress);
            // 
            // txtNombreUsuarioAyudante
            // 
            this.txtNombreUsuarioAyudante.Location = new System.Drawing.Point(126, 50);
            this.txtNombreUsuarioAyudante.Name = "txtNombreUsuarioAyudante";
            this.txtNombreUsuarioAyudante.Size = new System.Drawing.Size(160, 20);
            this.txtNombreUsuarioAyudante.TabIndex = 2;
            this.txtNombreUsuarioAyudante.TextChanged += new System.EventHandler(this.txtNombreUsuarioAyudante_TextChanged);
            this.txtNombreUsuarioAyudante.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreUsuarioAyudante_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Cédula Usuario:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Apellido Usuario:";
            // 
            // txtCedulaUsuarioAyudante
            // 
            this.txtCedulaUsuarioAyudante.Location = new System.Drawing.Point(126, 24);
            this.txtCedulaUsuarioAyudante.Name = "txtCedulaUsuarioAyudante";
            this.txtCedulaUsuarioAyudante.Size = new System.Drawing.Size(160, 20);
            this.txtCedulaUsuarioAyudante.TabIndex = 1;
            this.txtCedulaUsuarioAyudante.TextChanged += new System.EventHandler(this.txtCedulaUsuarioAyudante_TextChanged);
            this.txtCedulaUsuarioAyudante.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCedulaUsuarioAyudante_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Password Usuario:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Nombre Usuario:";
            // 
            // FrmUsuarioActualizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 503);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvUsuario);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmUsuarioActualizar";
            this.Text = "Actualizar Usuario";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuario)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUsuario;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnNombreUsuario;
        private System.Windows.Forms.RadioButton rbtnCedulaUsuario;
        private System.Windows.Forms.Label lblAvisoCedula;
        private System.Windows.Forms.Button btnBuscarUsuario;
        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCedulaUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblAvisoCedulaAyudante;
        private System.Windows.Forms.Label lblAvisoREPassword;
        private System.Windows.Forms.Label lblAvisoPassword;
        private System.Windows.Forms.Button btnSalirUsuario;
        private System.Windows.Forms.TextBox txtREPasswordUsuarioAyudante;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnActualizarUsuario;
        private System.Windows.Forms.TextBox txtPasswordUsuarioAyudante;
        private System.Windows.Forms.TextBox txtApellidoUsuarioAyudante;
        private System.Windows.Forms.TextBox txtNombreUsuarioAyudante;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCedulaUsuarioAyudante;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnPredeterminadoUsuario;
        private System.Windows.Forms.RadioButton rbtnPassword;
        private System.Windows.Forms.RadioButton rbtnMantenerPassword;
        private System.Windows.Forms.Button button1;


    }
}