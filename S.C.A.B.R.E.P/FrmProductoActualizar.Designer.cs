namespace S.C.A.B.R.E.P
{
    partial class FrmProductoActualizar
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
            this.dgvBuscarProductoEliminar = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtNombreProductoEliminar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rBtnNombreEliminarProducto = new System.Windows.Forms.RadioButton();
            this.btnBucarEliminarProducto = new System.Windows.Forms.Button();
            this.rBtnCodigoEliminarProducto = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCodigoProductoEliminar = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnActualizarPredeterminadoProducto = new System.Windows.Forms.Button();
            this.btnCancelarIngresarCliente = new System.Windows.Forms.Button();
            this.lblAvisoCostoProductoEspecial = new System.Windows.Forms.Label();
            this.txtCostoProducto = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnActualizarProducto = new System.Windows.Forms.Button();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.txtCodigoProducto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarProductoEliminar)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvBuscarProductoEliminar
            // 
            this.dgvBuscarProductoEliminar.AllowUserToAddRows = false;
            this.dgvBuscarProductoEliminar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvBuscarProductoEliminar.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvBuscarProductoEliminar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuscarProductoEliminar.Location = new System.Drawing.Point(6, 142);
            this.dgvBuscarProductoEliminar.MultiSelect = false;
            this.dgvBuscarProductoEliminar.Name = "dgvBuscarProductoEliminar";
            this.dgvBuscarProductoEliminar.ReadOnly = true;
            this.dgvBuscarProductoEliminar.Size = new System.Drawing.Size(850, 150);
            this.dgvBuscarProductoEliminar.TabIndex = 22;
            this.dgvBuscarProductoEliminar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBuscarProductoEliminar_CellClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.txtNombreProductoEliminar);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.rBtnNombreEliminarProducto);
            this.groupBox3.Controls.Add(this.btnBucarEliminarProducto);
            this.groupBox3.Controls.Add(this.rBtnCodigoEliminarProducto);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtCodigoProductoEliminar);
            this.groupBox3.Location = new System.Drawing.Point(6, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(850, 124);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Buscar Producto Según: Codigo/Nombre";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(730, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 67);
            this.button1.TabIndex = 29;
            this.button1.Text = "Buscar Todos Productos/Trabajos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtNombreProductoEliminar
            // 
            this.txtNombreProductoEliminar.Enabled = false;
            this.txtNombreProductoEliminar.Location = new System.Drawing.Point(118, 89);
            this.txtNombreProductoEliminar.Name = "txtNombreProductoEliminar";
            this.txtNombreProductoEliminar.Size = new System.Drawing.Size(257, 20);
            this.txtNombreProductoEliminar.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Nombre del Producto:";
            // 
            // rBtnNombreEliminarProducto
            // 
            this.rBtnNombreEliminarProducto.AutoSize = true;
            this.rBtnNombreEliminarProducto.Location = new System.Drawing.Point(136, 31);
            this.rBtnNombreEliminarProducto.Name = "rBtnNombreEliminarProducto";
            this.rBtnNombreEliminarProducto.Size = new System.Drawing.Size(125, 17);
            this.rBtnNombreEliminarProducto.TabIndex = 26;
            this.rBtnNombreEliminarProducto.Text = "Nombre del Producto";
            this.rBtnNombreEliminarProducto.UseVisualStyleBackColor = true;
            this.rBtnNombreEliminarProducto.CheckedChanged += new System.EventHandler(this.rBtnNombreEliminarProducto_CheckedChanged);
            // 
            // btnBucarEliminarProducto
            // 
            this.btnBucarEliminarProducto.Location = new System.Drawing.Point(766, 95);
            this.btnBucarEliminarProducto.Name = "btnBucarEliminarProducto";
            this.btnBucarEliminarProducto.Size = new System.Drawing.Size(75, 23);
            this.btnBucarEliminarProducto.TabIndex = 23;
            this.btnBucarEliminarProducto.Text = "Buscar";
            this.btnBucarEliminarProducto.UseVisualStyleBackColor = true;
            this.btnBucarEliminarProducto.Click += new System.EventHandler(this.btnBucarEliminarProducto_Click);
            // 
            // rBtnCodigoEliminarProducto
            // 
            this.rBtnCodigoEliminarProducto.AutoSize = true;
            this.rBtnCodigoEliminarProducto.Location = new System.Drawing.Point(6, 31);
            this.rBtnCodigoEliminarProducto.Name = "rBtnCodigoEliminarProducto";
            this.rBtnCodigoEliminarProducto.Size = new System.Drawing.Size(121, 17);
            this.rBtnCodigoEliminarProducto.TabIndex = 20;
            this.rBtnCodigoEliminarProducto.Text = "Codigo del Producto";
            this.rBtnCodigoEliminarProducto.UseVisualStyleBackColor = true;
            this.rBtnCodigoEliminarProducto.CheckedChanged += new System.EventHandler(this.rBtnCodigoEliminarProducto_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Codigo del Producto:";
            // 
            // txtCodigoProductoEliminar
            // 
            this.txtCodigoProductoEliminar.Enabled = false;
            this.txtCodigoProductoEliminar.Location = new System.Drawing.Point(118, 63);
            this.txtCodigoProductoEliminar.Name = "txtCodigoProductoEliminar";
            this.txtCodigoProductoEliminar.Size = new System.Drawing.Size(257, 20);
            this.txtCodigoProductoEliminar.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnActualizarPredeterminadoProducto);
            this.groupBox1.Controls.Add(this.btnCancelarIngresarCliente);
            this.groupBox1.Controls.Add(this.lblAvisoCostoProductoEspecial);
            this.groupBox1.Controls.Add(this.txtCostoProducto);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.btnActualizarProducto);
            this.groupBox1.Controls.Add(this.txtNombreProducto);
            this.groupBox1.Controls.Add(this.txtCodigoProducto);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(6, 298);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(850, 283);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Producto:";
            // 
            // btnActualizarPredeterminadoProducto
            // 
            this.btnActualizarPredeterminadoProducto.Location = new System.Drawing.Point(633, 254);
            this.btnActualizarPredeterminadoProducto.Name = "btnActualizarPredeterminadoProducto";
            this.btnActualizarPredeterminadoProducto.Size = new System.Drawing.Size(101, 23);
            this.btnActualizarPredeterminadoProducto.TabIndex = 20;
            this.btnActualizarPredeterminadoProducto.Text = "Predeterminado";
            this.btnActualizarPredeterminadoProducto.UseVisualStyleBackColor = true;
            this.btnActualizarPredeterminadoProducto.Click += new System.EventHandler(this.btnActualizarPredeterminadoProducto_Click);
            // 
            // btnCancelarIngresarCliente
            // 
            this.btnCancelarIngresarCliente.Location = new System.Drawing.Point(740, 254);
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
            this.lblAvisoCostoProductoEspecial.Location = new System.Drawing.Point(381, 221);
            this.lblAvisoCostoProductoEspecial.Name = "lblAvisoCostoProductoEspecial";
            this.lblAvisoCostoProductoEspecial.Size = new System.Drawing.Size(143, 13);
            this.lblAvisoCostoProductoEspecial.TabIndex = 19;
            this.lblAvisoCostoProductoEspecial.Text = "AvisoCostoProductoEspecial";
            this.lblAvisoCostoProductoEspecial.Visible = false;
            // 
            // txtCostoProducto
            // 
            this.txtCostoProducto.Location = new System.Drawing.Point(118, 214);
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
            // btnActualizarProducto
            // 
            this.btnActualizarProducto.Location = new System.Drawing.Point(526, 254);
            this.btnActualizarProducto.Name = "btnActualizarProducto";
            this.btnActualizarProducto.Size = new System.Drawing.Size(101, 23);
            this.btnActualizarProducto.TabIndex = 11;
            this.btnActualizarProducto.Text = "Actualizar";
            this.btnActualizarProducto.UseVisualStyleBackColor = true;
            this.btnActualizarProducto.Click += new System.EventHandler(this.btnActualizarProducto_Click);
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Location = new System.Drawing.Point(118, 61);
            this.txtNombreProducto.Multiline = true;
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(406, 147);
            this.txtNombreProducto.TabIndex = 3;
            this.txtNombreProducto.TextChanged += new System.EventHandler(this.txtNombreProducto_TextChanged);
            this.txtNombreProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreProducto_KeyPress);
            // 
            // txtCodigoProducto
            // 
            this.txtCodigoProducto.Location = new System.Drawing.Point(118, 28);
            this.txtCodigoProducto.Name = "txtCodigoProducto";
            this.txtCodigoProducto.Size = new System.Drawing.Size(257, 20);
            this.txtCodigoProducto.TabIndex = 2;
            this.txtCodigoProducto.TextChanged += new System.EventHandler(this.txtCodigoProducto_TextChanged);
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = " Codigo del Producto:";
            // 
            // FrmProductoActualizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 593);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvBuscarProductoEliminar);
            this.Controls.Add(this.groupBox3);
            this.Name = "FrmProductoActualizar";
            this.Text = "Actualizar Productos ";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarProductoEliminar)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBuscarProductoEliminar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtNombreProductoEliminar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rBtnNombreEliminarProducto;
        private System.Windows.Forms.Button btnBucarEliminarProducto;
        private System.Windows.Forms.RadioButton rBtnCodigoEliminarProducto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCodigoProductoEliminar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnActualizarPredeterminadoProducto;
        private System.Windows.Forms.Button btnCancelarIngresarCliente;
        private System.Windows.Forms.Label lblAvisoCostoProductoEspecial;
        private System.Windows.Forms.TextBox txtCostoProducto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnActualizarProducto;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.TextBox txtCodigoProducto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;

    }
}