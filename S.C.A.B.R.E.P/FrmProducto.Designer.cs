namespace S.C.A.B.R.E.P
{
    partial class FrmProducto
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
            this.btnAbrirTrabajoActualizar = new System.Windows.Forms.Button();
            this.btnAbrirProductoActualizar = new System.Windows.Forms.Button();
            this.btnAbrirTrabajoIngresar = new System.Windows.Forms.Button();
            this.btnAbrirProductoIngresar = new System.Windows.Forms.Button();
            this.txtMostrarCodigo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescripcionBusqueda = new System.Windows.Forms.TextBox();
            this.btnBuscarTodos = new System.Windows.Forms.Button();
            this.rbtnCodigoNombre = new System.Windows.Forms.RadioButton();
            this.rbtnNombre = new System.Windows.Forms.RadioButton();
            this.rbtnCodigo = new System.Windows.Forms.RadioButton();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvBusqueda = new System.Windows.Forms.DataGridView();
            this.dgvSeleccion = new System.Windows.Forms.DataGridView();
            this.ID_PRODUCTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio_Unitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GANANCIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusqueda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeleccion)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAbrirTrabajoActualizar);
            this.groupBox1.Controls.Add(this.btnAbrirProductoActualizar);
            this.groupBox1.Controls.Add(this.btnAbrirTrabajoIngresar);
            this.groupBox1.Controls.Add(this.btnAbrirProductoIngresar);
            this.groupBox1.Controls.Add(this.txtMostrarCodigo);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtDescripcionBusqueda);
            this.groupBox1.Controls.Add(this.btnBuscarTodos);
            this.groupBox1.Controls.Add(this.rbtnCodigoNombre);
            this.groupBox1.Controls.Add(this.rbtnNombre);
            this.groupBox1.Controls.Add(this.rbtnCodigo);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.txtCodigo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dgvBusqueda);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(804, 337);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Busqueda Producto:";
            // 
            // btnAbrirTrabajoActualizar
            // 
            this.btnAbrirTrabajoActualizar.Location = new System.Drawing.Point(361, 115);
            this.btnAbrirTrabajoActualizar.Name = "btnAbrirTrabajoActualizar";
            this.btnAbrirTrabajoActualizar.Size = new System.Drawing.Size(108, 23);
            this.btnAbrirTrabajoActualizar.TabIndex = 20;
            this.btnAbrirTrabajoActualizar.Text = "Actualizar Trabajo";
            this.btnAbrirTrabajoActualizar.UseVisualStyleBackColor = true;
            this.btnAbrirTrabajoActualizar.Click += new System.EventHandler(this.btnAbrirTrabajoActualizar_Click);
            // 
            // btnAbrirProductoActualizar
            // 
            this.btnAbrirProductoActualizar.Location = new System.Drawing.Point(361, 62);
            this.btnAbrirProductoActualizar.Name = "btnAbrirProductoActualizar";
            this.btnAbrirProductoActualizar.Size = new System.Drawing.Size(108, 23);
            this.btnAbrirProductoActualizar.TabIndex = 19;
            this.btnAbrirProductoActualizar.Text = "Actualizar Producto";
            this.btnAbrirProductoActualizar.UseVisualStyleBackColor = true;
            this.btnAbrirProductoActualizar.Click += new System.EventHandler(this.btnAbrirProductoActualizar_Click);
            // 
            // btnAbrirTrabajoIngresar
            // 
            this.btnAbrirTrabajoIngresar.Location = new System.Drawing.Point(361, 91);
            this.btnAbrirTrabajoIngresar.Name = "btnAbrirTrabajoIngresar";
            this.btnAbrirTrabajoIngresar.Size = new System.Drawing.Size(108, 23);
            this.btnAbrirTrabajoIngresar.TabIndex = 18;
            this.btnAbrirTrabajoIngresar.Text = "Agregar Trabajo";
            this.btnAbrirTrabajoIngresar.UseVisualStyleBackColor = true;
            this.btnAbrirTrabajoIngresar.Click += new System.EventHandler(this.btnAbrirTrabajoIngresar_Click);
            // 
            // btnAbrirProductoIngresar
            // 
            this.btnAbrirProductoIngresar.Location = new System.Drawing.Point(361, 37);
            this.btnAbrirProductoIngresar.Name = "btnAbrirProductoIngresar";
            this.btnAbrirProductoIngresar.Size = new System.Drawing.Size(108, 23);
            this.btnAbrirProductoIngresar.TabIndex = 17;
            this.btnAbrirProductoIngresar.Text = "Agregar Producto";
            this.btnAbrirProductoIngresar.UseVisualStyleBackColor = true;
            this.btnAbrirProductoIngresar.Click += new System.EventHandler(this.btnAbrirProductoIngresar_Click);
            // 
            // txtMostrarCodigo
            // 
            this.txtMostrarCodigo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtMostrarCodigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtMostrarCodigo.Location = new System.Drawing.Point(477, 39);
            this.txtMostrarCodigo.Name = "txtMostrarCodigo";
            this.txtMostrarCodigo.ReadOnly = true;
            this.txtMostrarCodigo.Size = new System.Drawing.Size(235, 20);
            this.txtMostrarCodigo.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(474, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "CODIGO:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(474, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "DESCRIPCION:";
            // 
            // txtDescripcionBusqueda
            // 
            this.txtDescripcionBusqueda.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtDescripcionBusqueda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtDescripcionBusqueda.Location = new System.Drawing.Point(476, 78);
            this.txtDescripcionBusqueda.Multiline = true;
            this.txtDescripcionBusqueda.Name = "txtDescripcionBusqueda";
            this.txtDescripcionBusqueda.ReadOnly = true;
            this.txtDescripcionBusqueda.Size = new System.Drawing.Size(322, 74);
            this.txtDescripcionBusqueda.TabIndex = 13;
            // 
            // btnBuscarTodos
            // 
            this.btnBuscarTodos.Location = new System.Drawing.Point(276, 101);
            this.btnBuscarTodos.Name = "btnBuscarTodos";
            this.btnBuscarTodos.Size = new System.Drawing.Size(75, 51);
            this.btnBuscarTodos.TabIndex = 12;
            this.btnBuscarTodos.Text = "BUSCAR TODOS";
            this.btnBuscarTodos.UseVisualStyleBackColor = true;
            this.btnBuscarTodos.Click += new System.EventHandler(this.btnBuscarTodos_Click_1);
            // 
            // rbtnCodigoNombre
            // 
            this.rbtnCodigoNombre.AutoSize = true;
            this.rbtnCodigoNombre.Location = new System.Drawing.Point(207, 19);
            this.rbtnCodigoNombre.Name = "rbtnCodigoNombre";
            this.rbtnCodigoNombre.Size = new System.Drawing.Size(100, 17);
            this.rbtnCodigoNombre.TabIndex = 11;
            this.rbtnCodigoNombre.TabStop = true;
            this.rbtnCodigoNombre.Text = "Codigo/Nombre";
            this.rbtnCodigoNombre.UseVisualStyleBackColor = true;
            this.rbtnCodigoNombre.CheckedChanged += new System.EventHandler(this.rbtnCodigoNombre_CheckedChanged);
            // 
            // rbtnNombre
            // 
            this.rbtnNombre.AutoSize = true;
            this.rbtnNombre.Location = new System.Drawing.Point(97, 19);
            this.rbtnNombre.Name = "rbtnNombre";
            this.rbtnNombre.Size = new System.Drawing.Size(62, 17);
            this.rbtnNombre.TabIndex = 10;
            this.rbtnNombre.TabStop = true;
            this.rbtnNombre.Text = "Nombre";
            this.rbtnNombre.UseVisualStyleBackColor = true;
            this.rbtnNombre.CheckedChanged += new System.EventHandler(this.rbtnNombre_CheckedChanged);
            // 
            // rbtnCodigo
            // 
            this.rbtnCodigo.AutoSize = true;
            this.rbtnCodigo.Location = new System.Drawing.Point(6, 19);
            this.rbtnCodigo.Name = "rbtnCodigo";
            this.rbtnCodigo.Size = new System.Drawing.Size(58, 17);
            this.rbtnCodigo.TabIndex = 9;
            this.rbtnCodigo.TabStop = true;
            this.rbtnCodigo.Text = "Codigo";
            this.rbtnCodigo.UseVisualStyleBackColor = true;
            this.rbtnCodigo.CheckedChanged += new System.EventHandler(this.rbtnCodigo_CheckedChanged);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(198, 101);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 51);
            this.btnBuscar.TabIndex = 8;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Productos Especiales Encontrados:";
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(112, 71);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(235, 20);
            this.txtNombre.TabIndex = 5;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(112, 45);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(132, 20);
            this.txtCodigo.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre de Producto:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Codigo de producto:";
            // 
            // dgvBusqueda
            // 
            this.dgvBusqueda.AllowUserToAddRows = false;
            this.dgvBusqueda.AllowUserToDeleteRows = false;
            this.dgvBusqueda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBusqueda.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvBusqueda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBusqueda.Location = new System.Drawing.Point(9, 171);
            this.dgvBusqueda.Name = "dgvBusqueda";
            this.dgvBusqueda.ReadOnly = true;
            this.dgvBusqueda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBusqueda.Size = new System.Drawing.Size(779, 150);
            this.dgvBusqueda.TabIndex = 0;
            this.dgvBusqueda.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvBusqueda_MouseClick);
            this.dgvBusqueda.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvBusqueda_MouseDoubleClick);
            // 
            // dgvSeleccion
            // 
            this.dgvSeleccion.AllowUserToAddRows = false;
            this.dgvSeleccion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvSeleccion.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvSeleccion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSeleccion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_PRODUCTO,
            this.CODIGO,
            this.Cantidad,
            this.Descripcion,
            this.Precio_Unitario,
            this.GANANCIA,
            this.Importe});
            this.dgvSeleccion.Location = new System.Drawing.Point(9, 19);
            this.dgvSeleccion.Name = "dgvSeleccion";
            this.dgvSeleccion.ReadOnly = true;
            this.dgvSeleccion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSeleccion.Size = new System.Drawing.Size(785, 150);
            this.dgvSeleccion.TabIndex = 8;
            this.dgvSeleccion.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvSeleccion_MouseClick);
            this.dgvSeleccion.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvSeleccion_MouseDoubleClick);
            // 
            // ID_PRODUCTO
            // 
            this.ID_PRODUCTO.HeaderText = "ID_PRODUCTO";
            this.ID_PRODUCTO.Name = "ID_PRODUCTO";
            this.ID_PRODUCTO.ReadOnly = true;
            this.ID_PRODUCTO.Width = 110;
            // 
            // CODIGO
            // 
            this.CODIGO.HeaderText = "CODIGO";
            this.CODIGO.Name = "CODIGO";
            this.CODIGO.ReadOnly = true;
            this.CODIGO.Width = 74;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "CANTIDAD";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 87;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "DESCRIPCION";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Width = 105;
            // 
            // Precio_Unitario
            // 
            this.Precio_Unitario.HeaderText = "PRECIO_UNITARIO";
            this.Precio_Unitario.Name = "Precio_Unitario";
            this.Precio_Unitario.ReadOnly = true;
            this.Precio_Unitario.Width = 130;
            // 
            // GANANCIA
            // 
            this.GANANCIA.HeaderText = "GANANCIA_PRODUCTO";
            this.GANANCIA.Name = "GANANCIA";
            this.GANANCIA.ReadOnly = true;
            this.GANANCIA.Width = 154;
            // 
            // Importe
            // 
            this.Importe.HeaderText = "IMPORTE";
            this.Importe.Name = "Importe";
            this.Importe.ReadOnly = true;
            this.Importe.Width = 81;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.btnOK);
            this.groupBox2.Controls.Add(this.dgvSeleccion);
            this.groupBox2.Location = new System.Drawing.Point(12, 355);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(804, 208);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Productos Especiales a Ingresar: ";
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(719, 175);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(611, 175);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(102, 23);
            this.btnOK.TabIndex = 9;
            this.btnOK.Text = "Agregar a Factura";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // FrmProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 573);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmProducto";
            this.Text = "Producto";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusqueda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeleccion)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbtnCodigoNombre;
        private System.Windows.Forms.RadioButton rbtnNombre;
        private System.Windows.Forms.RadioButton rbtnCodigo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnBuscarTodos;
        public System.Windows.Forms.DataGridView dgvBusqueda;
        public System.Windows.Forms.DataGridView dgvSeleccion;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDescripcionBusqueda;
        private System.Windows.Forms.TextBox txtMostrarCodigo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_PRODUCTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio_Unitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn GANANCIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Importe;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAbrirTrabajoIngresar;
        private System.Windows.Forms.Button btnAbrirProductoIngresar;
        private System.Windows.Forms.Button btnAbrirTrabajoActualizar;
        private System.Windows.Forms.Button btnAbrirProductoActualizar;
    }
}