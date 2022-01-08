namespace S.C.A.B.R.E.P
{
    partial class FrmUsuarioIngresar
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
            this.lblAvisoCedula = new System.Windows.Forms.Label();
            this.lblAvisoREPassword = new System.Windows.Forms.Label();
            this.lblAvisoPassword = new System.Windows.Forms.Label();
            this.btnSalirUsuario = new System.Windows.Forms.Button();
            this.txtREPasswordUsuario = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnIngresarUsuario = new System.Windows.Forms.Button();
            this.txtPasswordUsuario = new System.Windows.Forms.TextBox();
            this.txtApellidoUsuario = new System.Windows.Forms.TextBox();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCedulaUsuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblAvisoCedula);
            this.groupBox1.Controls.Add(this.lblAvisoREPassword);
            this.groupBox1.Controls.Add(this.lblAvisoPassword);
            this.groupBox1.Controls.Add(this.btnSalirUsuario);
            this.groupBox1.Controls.Add(this.txtREPasswordUsuario);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnIngresarUsuario);
            this.groupBox1.Controls.Add(this.txtPasswordUsuario);
            this.groupBox1.Controls.Add(this.txtApellidoUsuario);
            this.groupBox1.Controls.Add(this.txtNombreUsuario);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtCedulaUsuario);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(580, 187);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Usuario:";
            // 
            // lblAvisoCedula
            // 
            this.lblAvisoCedula.AutoSize = true;
            this.lblAvisoCedula.ForeColor = System.Drawing.Color.Red;
            this.lblAvisoCedula.Location = new System.Drawing.Point(292, 31);
            this.lblAvisoCedula.Name = "lblAvisoCedula";
            this.lblAvisoCedula.Size = new System.Drawing.Size(35, 13);
            this.lblAvisoCedula.TabIndex = 11;
            this.lblAvisoCedula.Text = "label7";
            this.lblAvisoCedula.Visible = false;
            // 
            // lblAvisoREPassword
            // 
            this.lblAvisoREPassword.AutoSize = true;
            this.lblAvisoREPassword.ForeColor = System.Drawing.Color.Red;
            this.lblAvisoREPassword.Location = new System.Drawing.Point(292, 137);
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
            this.lblAvisoPassword.Location = new System.Drawing.Point(292, 108);
            this.lblAvisoPassword.Name = "lblAvisoPassword";
            this.lblAvisoPassword.Size = new System.Drawing.Size(35, 13);
            this.lblAvisoPassword.TabIndex = 9;
            this.lblAvisoPassword.Text = "label6";
            this.lblAvisoPassword.Visible = false;
            // 
            // btnSalirUsuario
            // 
            this.btnSalirUsuario.Location = new System.Drawing.Point(91, 158);
            this.btnSalirUsuario.Name = "btnSalirUsuario";
            this.btnSalirUsuario.Size = new System.Drawing.Size(75, 23);
            this.btnSalirUsuario.TabIndex = 7;
            this.btnSalirUsuario.Text = "Salir";
            this.btnSalirUsuario.UseVisualStyleBackColor = true;
            this.btnSalirUsuario.Click += new System.EventHandler(this.btnSalirUsuario_Click);
            // 
            // txtREPasswordUsuario
            // 
            this.txtREPasswordUsuario.Location = new System.Drawing.Point(126, 130);
            this.txtREPasswordUsuario.Name = "txtREPasswordUsuario";
            this.txtREPasswordUsuario.PasswordChar = '*';
            this.txtREPasswordUsuario.Size = new System.Drawing.Size(160, 20);
            this.txtREPasswordUsuario.TabIndex = 5;
            this.txtREPasswordUsuario.TextChanged += new System.EventHandler(this.txtREPasswordUsuario_TextChanged);
            this.txtREPasswordUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtREPasswordUsuario_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "RE-Password Usuario:";
            // 
            // btnIngresarUsuario
            // 
            this.btnIngresarUsuario.Location = new System.Drawing.Point(10, 158);
            this.btnIngresarUsuario.Name = "btnIngresarUsuario";
            this.btnIngresarUsuario.Size = new System.Drawing.Size(75, 23);
            this.btnIngresarUsuario.TabIndex = 6;
            this.btnIngresarUsuario.Text = "Ingresar";
            this.btnIngresarUsuario.UseVisualStyleBackColor = true;
            this.btnIngresarUsuario.Click += new System.EventHandler(this.btnIngresarUsuario_Click);
            // 
            // txtPasswordUsuario
            // 
            this.txtPasswordUsuario.Location = new System.Drawing.Point(126, 101);
            this.txtPasswordUsuario.Name = "txtPasswordUsuario";
            this.txtPasswordUsuario.PasswordChar = '*';
            this.txtPasswordUsuario.Size = new System.Drawing.Size(160, 20);
            this.txtPasswordUsuario.TabIndex = 4;
            this.txtPasswordUsuario.TextChanged += new System.EventHandler(this.txtPasswordUsuario_TextChanged);
            this.txtPasswordUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPasswordUsuario_KeyPress);
            // 
            // txtApellidoUsuario
            // 
            this.txtApellidoUsuario.Location = new System.Drawing.Point(126, 76);
            this.txtApellidoUsuario.Name = "txtApellidoUsuario";
            this.txtApellidoUsuario.Size = new System.Drawing.Size(160, 20);
            this.txtApellidoUsuario.TabIndex = 3;
            this.txtApellidoUsuario.TextChanged += new System.EventHandler(this.txtApellidoUsuario_TextChanged);
            this.txtApellidoUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellidoUsuario_KeyPress);
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Location = new System.Drawing.Point(126, 50);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(160, 20);
            this.txtNombreUsuario.TabIndex = 2;
            this.txtNombreUsuario.TextChanged += new System.EventHandler(this.txtNombreUsuario_TextChanged);
            this.txtNombreUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreUsuario_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cédula Usuario:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Apellido Usuario:";
            // 
            // txtCedulaUsuario
            // 
            this.txtCedulaUsuario.Location = new System.Drawing.Point(126, 24);
            this.txtCedulaUsuario.Name = "txtCedulaUsuario";
            this.txtCedulaUsuario.Size = new System.Drawing.Size(160, 20);
            this.txtCedulaUsuario.TabIndex = 1;
            this.txtCedulaUsuario.TextChanged += new System.EventHandler(this.txtCedulaUsuario_TextChanged);
            this.txtCedulaUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCedulaUsuario_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre Usuario:";
            // 
            // FrmUsuarioIngresar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 214);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmUsuarioIngresar";
            this.Text = "Ingresar Usuario ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblAvisoREPassword;
        private System.Windows.Forms.Label lblAvisoPassword;
        private System.Windows.Forms.Button btnSalirUsuario;
        private System.Windows.Forms.TextBox txtREPasswordUsuario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnIngresarUsuario;
        private System.Windows.Forms.TextBox txtPasswordUsuario;
        private System.Windows.Forms.TextBox txtApellidoUsuario;
        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCedulaUsuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAvisoCedula;
    }
}