namespace S.C.A.B.R.E.P
{
    partial class FrmProductoIngresar
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
            this.lblProducto = new System.Windows.Forms.Label();
            this.btnCancelarIngresarCliente = new System.Windows.Forms.Button();
            this.lblAvisoCostoProductoEspecial = new System.Windows.Forms.Label();
            this.txtCostoProducto = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnIngresarCliente = new System.Windows.Forms.Button();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.txtCodigoProducto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblProducto);
            this.groupBox1.Controls.Add(this.btnCancelarIngresarCliente);
            this.groupBox1.Controls.Add(this.lblAvisoCostoProductoEspecial);
            this.groupBox1.Controls.Add(this.txtCostoProducto);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.btnIngresarCliente);
            this.groupBox1.Controls.Add(this.txtNombreProducto);
            this.groupBox1.Controls.Add(this.txtCodigoProducto);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(750, 276);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Producto:";
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Location = new System.Drawing.Point(128, 26);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(83, 13);
            this.lblProducto.TabIndex = 20;
            this.lblProducto.Text = "PELECCOMPU-";
            // 
            // btnCancelarIngresarCliente
            // 
            this.btnCancelarIngresarCliente.Location = new System.Drawing.Point(642, 247);
            this.btnCancelarIngresarCliente.Name = "btnCancelarIngresarCliente";
            this.btnCancelarIngresarCliente.Size = new System.Drawing.Size(101, 23);
            this.btnCancelarIngresarCliente.TabIndex = 12;
            this.btnCancelarIngresarCliente.Text = "Salir";
            this.btnCancelarIngresarCliente.UseVisualStyleBackColor = true;
            this.btnCancelarIngresarCliente.Click += new System.EventHandler(this.btnCancelarIngresarCliente_Click);
            // 
            // lblAvisoCostoProductoEspecial
            // 
            this.lblAvisoCostoProductoEspecial.AutoSize = true;
            this.lblAvisoCostoProductoEspecial.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvisoCostoProductoEspecial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblAvisoCostoProductoEspecial.Location = new System.Drawing.Point(391, 221);
            this.lblAvisoCostoProductoEspecial.Name = "lblAvisoCostoProductoEspecial";
            this.lblAvisoCostoProductoEspecial.Size = new System.Drawing.Size(143, 13);
            this.lblAvisoCostoProductoEspecial.TabIndex = 19;
            this.lblAvisoCostoProductoEspecial.Text = "AvisoCostoProductoEspecial";
            this.lblAvisoCostoProductoEspecial.Visible = false;
            // 
            // txtCostoProducto
            // 
            this.txtCostoProducto.Location = new System.Drawing.Point(128, 214);
            this.txtCostoProducto.Name = "txtCostoProducto";
            this.txtCostoProducto.Size = new System.Drawing.Size(257, 20);
            this.txtCostoProducto.TabIndex = 8;
            this.txtCostoProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCostoProducto_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 221);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Costo del Producto:";
            // 
            // btnIngresarCliente
            // 
            this.btnIngresarCliente.Location = new System.Drawing.Point(535, 247);
            this.btnIngresarCliente.Name = "btnIngresarCliente";
            this.btnIngresarCliente.Size = new System.Drawing.Size(101, 23);
            this.btnIngresarCliente.TabIndex = 11;
            this.btnIngresarCliente.Text = "Insertar";
            this.btnIngresarCliente.UseVisualStyleBackColor = true;
            this.btnIngresarCliente.Click += new System.EventHandler(this.btnIngresarCliente_Click);
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Location = new System.Drawing.Point(128, 61);
            this.txtNombreProducto.Multiline = true;
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(364, 147);
            this.txtNombreProducto.TabIndex = 3;
            this.txtNombreProducto.TextChanged += new System.EventHandler(this.txtNombreProducto_TextChanged);
            this.txtNombreProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreProducto_KeyPress);
            // 
            // txtCodigoProducto
            // 
            this.txtCodigoProducto.Location = new System.Drawing.Point(217, 23);
            this.txtCodigoProducto.Name = "txtCodigoProducto";
            this.txtCodigoProducto.Size = new System.Drawing.Size(275, 20);
            this.txtCodigoProducto.TabIndex = 2;
            this.txtCodigoProducto.TextChanged += new System.EventHandler(this.txtCodigoProducto_TextChanged);
            this.txtCodigoProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigoProducto_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Nombre del Producto:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = " Codigo del Producto:";
            // 
            // FrmProductoIngresar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 302);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmProductoIngresar";
            this.Text = "Ingresar Productos Especiales";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCancelarIngresarCliente;
        private System.Windows.Forms.Label lblAvisoCostoProductoEspecial;
        private System.Windows.Forms.TextBox txtCostoProducto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnIngresarCliente;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.TextBox txtCodigoProducto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblProducto;

    }
}