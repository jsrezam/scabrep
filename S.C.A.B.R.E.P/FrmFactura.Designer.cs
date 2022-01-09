using System.Configuration;
namespace S.C.A.B.R.E.P
{
    partial class FrmFactura
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
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.txtRucClienteFactura = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCedulaClienteFactura = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTelefonoClienteFactura = new System.Windows.Forms.TextBox();
            this.txtDireccionClienteFactura = new System.Windows.Forms.TextBox();
            this.txtNombreClienteFactura = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdClienteFactura = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFechaFactura = new System.Windows.Forms.DateTimePicker();
            this.dgvNumeroFactura = new System.Windows.Forms.DataGridView();
            this.txtIdUsuarioFactura = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtNombreUsuarioFactura = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnLimpiarProducto = new System.Windows.Forms.Button();
            this.btnAgregarModificarProductoFactura = new System.Windows.Forms.Button();
            this.txtMostrarDetalle = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMostrarCodigo = new System.Windows.Forms.TextBox();
            this.dgvProductoFactura = new System.Windows.Forms.DataGridView();
            this.ID_PRODUCTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PRODUCTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CANTIDAD_PRODUCTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPCION_PRODUCTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRECIO_PRODUCTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GANANCIA_PRODUCTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IMPORTE_PRODUCTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.txtValorTotal = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtIVA = new System.Windows.Forms.TextBox();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.txtSubTotalCero = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtSubTotalDoce = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btnImprimirFactura = new System.Windows.Forms.Button();
            this.btnNueva = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNumeroFactura)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductoFactura)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBuscarCliente);
            this.groupBox1.Controls.Add(this.txtRucClienteFactura);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtCedulaClienteFactura);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtTelefonoClienteFactura);
            this.groupBox1.Controls.Add(this.txtDireccionClienteFactura);
            this.groupBox1.Controls.Add(this.txtNombreClienteFactura);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtIdClienteFactura);
            this.groupBox1.Location = new System.Drawing.Point(12, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(257, 228);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Cliente";
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Location = new System.Drawing.Point(156, 16);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(49, 23);
            this.btnBuscarCliente.TabIndex = 13;
            this.btnBuscarCliente.Text = "Buscar";
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // txtRucClienteFactura
            // 
            this.txtRucClienteFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRucClienteFactura.ForeColor = System.Drawing.Color.Red;
            this.txtRucClienteFactura.Location = new System.Drawing.Point(90, 193);
            this.txtRucClienteFactura.Name = "txtRucClienteFactura";
            this.txtRucClienteFactura.ReadOnly = true;
            this.txtRucClienteFactura.Size = new System.Drawing.Size(160, 26);
            this.txtRucClienteFactura.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "RUC:";
            // 
            // txtCedulaClienteFactura
            // 
            this.txtCedulaClienteFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCedulaClienteFactura.ForeColor = System.Drawing.Color.Red;
            this.txtCedulaClienteFactura.Location = new System.Drawing.Point(90, 153);
            this.txtCedulaClienteFactura.Name = "txtCedulaClienteFactura";
            this.txtCedulaClienteFactura.ReadOnly = true;
            this.txtCedulaClienteFactura.Size = new System.Drawing.Size(160, 26);
            this.txtCedulaClienteFactura.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Id Cliente:";
            // 
            // txtTelefonoClienteFactura
            // 
            this.txtTelefonoClienteFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefonoClienteFactura.ForeColor = System.Drawing.Color.Red;
            this.txtTelefonoClienteFactura.Location = new System.Drawing.Point(90, 114);
            this.txtTelefonoClienteFactura.Name = "txtTelefonoClienteFactura";
            this.txtTelefonoClienteFactura.ReadOnly = true;
            this.txtTelefonoClienteFactura.Size = new System.Drawing.Size(160, 26);
            this.txtTelefonoClienteFactura.TabIndex = 7;
            // 
            // txtDireccionClienteFactura
            // 
            this.txtDireccionClienteFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccionClienteFactura.ForeColor = System.Drawing.Color.Red;
            this.txtDireccionClienteFactura.Location = new System.Drawing.Point(90, 83);
            this.txtDireccionClienteFactura.Name = "txtDireccionClienteFactura";
            this.txtDireccionClienteFactura.ReadOnly = true;
            this.txtDireccionClienteFactura.Size = new System.Drawing.Size(160, 26);
            this.txtDireccionClienteFactura.TabIndex = 6;
            // 
            // txtNombreClienteFactura
            // 
            this.txtNombreClienteFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreClienteFactura.ForeColor = System.Drawing.Color.Red;
            this.txtNombreClienteFactura.Location = new System.Drawing.Point(90, 49);
            this.txtNombreClienteFactura.Name = "txtNombreClienteFactura";
            this.txtNombreClienteFactura.ReadOnly = true;
            this.txtNombreClienteFactura.Size = new System.Drawing.Size(160, 26);
            this.txtNombreClienteFactura.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cédula:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Teléfono:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dirección:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cliente:";
            // 
            // txtIdClienteFactura
            // 
            this.txtIdClienteFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdClienteFactura.ForeColor = System.Drawing.Color.Red;
            this.txtIdClienteFactura.Location = new System.Drawing.Point(90, 19);
            this.txtIdClienteFactura.Name = "txtIdClienteFactura";
            this.txtIdClienteFactura.ReadOnly = true;
            this.txtIdClienteFactura.Size = new System.Drawing.Size(60, 26);
            this.txtIdClienteFactura.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha Factura:";
            // 
            // dtpFechaFactura
            // 
            this.dtpFechaFactura.Checked = false;
            this.dtpFechaFactura.CustomFormat = "yyyy-dd-MM";
            this.dtpFechaFactura.Location = new System.Drawing.Point(102, 12);
            this.dtpFechaFactura.Name = "dtpFechaFactura";
            this.dtpFechaFactura.Size = new System.Drawing.Size(195, 20);
            this.dtpFechaFactura.TabIndex = 1;
            this.dtpFechaFactura.Value = new System.DateTime(2022, 1, 7, 0, 0, 0, 0);
            this.dtpFechaFactura.ValueChanged += new System.EventHandler(this.dtpFechaFactura_ValueChanged);
            // 
            // dgvNumeroFactura
            // 
            this.dgvNumeroFactura.AllowUserToAddRows = false;
            this.dgvNumeroFactura.AllowUserToDeleteRows = false;
            this.dgvNumeroFactura.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvNumeroFactura.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgvNumeroFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNumeroFactura.Location = new System.Drawing.Point(752, 9);
            this.dgvNumeroFactura.Name = "dgvNumeroFactura";
            this.dgvNumeroFactura.ReadOnly = true;
            this.dgvNumeroFactura.RowHeadersWidth = 40;
            this.dgvNumeroFactura.Size = new System.Drawing.Size(178, 40);
            this.dgvNumeroFactura.TabIndex = 3;
            // 
            // txtIdUsuarioFactura
            // 
            this.txtIdUsuarioFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdUsuarioFactura.ForeColor = System.Drawing.Color.Red;
            this.txtIdUsuarioFactura.Location = new System.Drawing.Point(90, 19);
            this.txtIdUsuarioFactura.Name = "txtIdUsuarioFactura";
            this.txtIdUsuarioFactura.ReadOnly = true;
            this.txtIdUsuarioFactura.Size = new System.Drawing.Size(60, 26);
            this.txtIdUsuarioFactura.TabIndex = 0;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(9, 61);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 13);
            this.label13.TabIndex = 1;
            this.label13.Text = "Usuario:";
            // 
            // txtNombreUsuarioFactura
            // 
            this.txtNombreUsuarioFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreUsuarioFactura.ForeColor = System.Drawing.Color.Red;
            this.txtNombreUsuarioFactura.Location = new System.Drawing.Point(90, 54);
            this.txtNombreUsuarioFactura.Name = "txtNombreUsuarioFactura";
            this.txtNombreUsuarioFactura.ReadOnly = true;
            this.txtNombreUsuarioFactura.Size = new System.Drawing.Size(160, 26);
            this.txtNombreUsuarioFactura.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Id Usuario:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtNombreUsuarioFactura);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.txtIdUsuarioFactura);
            this.groupBox2.Location = new System.Drawing.Point(303, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(257, 98);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos Usuario:";
            // 
            // btnLimpiarProducto
            // 
            this.btnLimpiarProducto.Location = new System.Drawing.Point(445, 121);
            this.btnLimpiarProducto.Name = "btnLimpiarProducto";
            this.btnLimpiarProducto.Size = new System.Drawing.Size(108, 44);
            this.btnLimpiarProducto.TabIndex = 13;
            this.btnLimpiarProducto.Text = "Limpiar Detalle Producto";
            this.btnLimpiarProducto.UseVisualStyleBackColor = true;
            this.btnLimpiarProducto.Click += new System.EventHandler(this.btnLimpiarProducto_Click);
            // 
            // btnAgregarModificarProductoFactura
            // 
            this.btnAgregarModificarProductoFactura.Location = new System.Drawing.Point(303, 121);
            this.btnAgregarModificarProductoFactura.Name = "btnAgregarModificarProductoFactura";
            this.btnAgregarModificarProductoFactura.Size = new System.Drawing.Size(108, 43);
            this.btnAgregarModificarProductoFactura.TabIndex = 12;
            this.btnAgregarModificarProductoFactura.Text = "Agregar / Modificar Producto/Trabajo";
            this.btnAgregarModificarProductoFactura.UseVisualStyleBackColor = true;
            this.btnAgregarModificarProductoFactura.Click += new System.EventHandler(this.btnAgregarModificarProductoFactura_Click);
            // 
            // txtMostrarDetalle
            // 
            this.txtMostrarDetalle.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtMostrarDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMostrarDetalle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtMostrarDetalle.Location = new System.Drawing.Point(569, 77);
            this.txtMostrarDetalle.Multiline = true;
            this.txtMostrarDetalle.Name = "txtMostrarDetalle";
            this.txtMostrarDetalle.ReadOnly = true;
            this.txtMostrarDetalle.Size = new System.Drawing.Size(361, 134);
            this.txtMostrarDetalle.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(566, 15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(140, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "CODIGO DEL PRODUCTO:";
            // 
            // txtMostrarCodigo
            // 
            this.txtMostrarCodigo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtMostrarCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMostrarCodigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtMostrarCodigo.Location = new System.Drawing.Point(569, 31);
            this.txtMostrarCodigo.Name = "txtMostrarCodigo";
            this.txtMostrarCodigo.ReadOnly = true;
            this.txtMostrarCodigo.Size = new System.Drawing.Size(168, 22);
            this.txtMostrarCodigo.TabIndex = 13;
            // 
            // dgvProductoFactura
            // 
            this.dgvProductoFactura.AllowUserToAddRows = false;
            this.dgvProductoFactura.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductoFactura.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvProductoFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductoFactura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_PRODUCTO,
            this.CODIGO_PRODUCTO,
            this.CANTIDAD_PRODUCTO,
            this.DESCRIPCION_PRODUCTO,
            this.PRECIO_PRODUCTO,
            this.GANANCIA_PRODUCTO,
            this.IMPORTE_PRODUCTO});
            this.dgvProductoFactura.Location = new System.Drawing.Point(6, 19);
            this.dgvProductoFactura.Name = "dgvProductoFactura";
            this.dgvProductoFactura.ReadOnly = true;
            this.dgvProductoFactura.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductoFactura.Size = new System.Drawing.Size(647, 246);
            this.dgvProductoFactura.TabIndex = 8;
            this.dgvProductoFactura.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgvProductoFactura_RowsRemoved);
            this.dgvProductoFactura.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvProductoFactura_MouseClick);
            // 
            // ID_PRODUCTO
            // 
            this.ID_PRODUCTO.HeaderText = "ID";
            this.ID_PRODUCTO.Name = "ID_PRODUCTO";
            this.ID_PRODUCTO.ReadOnly = true;
            // 
            // CODIGO_PRODUCTO
            // 
            this.CODIGO_PRODUCTO.HeaderText = "CODIGO";
            this.CODIGO_PRODUCTO.Name = "CODIGO_PRODUCTO";
            this.CODIGO_PRODUCTO.ReadOnly = true;
            // 
            // CANTIDAD_PRODUCTO
            // 
            this.CANTIDAD_PRODUCTO.HeaderText = "CANTIDAD";
            this.CANTIDAD_PRODUCTO.Name = "CANTIDAD_PRODUCTO";
            this.CANTIDAD_PRODUCTO.ReadOnly = true;
            // 
            // DESCRIPCION_PRODUCTO
            // 
            this.DESCRIPCION_PRODUCTO.HeaderText = "DESCRIPCION";
            this.DESCRIPCION_PRODUCTO.Name = "DESCRIPCION_PRODUCTO";
            this.DESCRIPCION_PRODUCTO.ReadOnly = true;
            // 
            // PRECIO_PRODUCTO
            // 
            this.PRECIO_PRODUCTO.HeaderText = "PRECIO";
            this.PRECIO_PRODUCTO.Name = "PRECIO_PRODUCTO";
            this.PRECIO_PRODUCTO.ReadOnly = true;
            // 
            // GANANCIA_PRODUCTO
            // 
            this.GANANCIA_PRODUCTO.HeaderText = "GANANCIA";
            this.GANANCIA_PRODUCTO.Name = "GANANCIA_PRODUCTO";
            this.GANANCIA_PRODUCTO.ReadOnly = true;
            // 
            // IMPORTE_PRODUCTO
            // 
            this.IMPORTE_PRODUCTO.HeaderText = "IMPORTE";
            this.IMPORTE_PRODUCTO.Name = "IMPORTE_PRODUCTO";
            this.IMPORTE_PRODUCTO.ReadOnly = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvProductoFactura);
            this.groupBox3.Location = new System.Drawing.Point(12, 272);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(663, 277);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Detalle Productos";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.txtValorTotal);
            this.groupBox7.Controls.Add(this.label21);
            this.groupBox7.Controls.Add(this.txtIVA);
            this.groupBox7.Controls.Add(this.txtSubTotal);
            this.groupBox7.Controls.Add(this.label19);
            this.groupBox7.Controls.Add(this.label20);
            this.groupBox7.Controls.Add(this.txtDescuento);
            this.groupBox7.Controls.Add(this.txtSubTotalCero);
            this.groupBox7.Controls.Add(this.label16);
            this.groupBox7.Controls.Add(this.label17);
            this.groupBox7.Controls.Add(this.label18);
            this.groupBox7.Controls.Add(this.txtSubTotalDoce);
            this.groupBox7.Location = new System.Drawing.Point(681, 272);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(240, 179);
            this.groupBox7.TabIndex = 20;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Resultado Factura:";
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtValorTotal.Location = new System.Drawing.Point(100, 145);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.ReadOnly = true;
            this.txtValorTotal.Size = new System.Drawing.Size(134, 24);
            this.txtValorTotal.TabIndex = 25;
            this.txtValorTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(6, 152);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(61, 13);
            this.label21.TabIndex = 24;
            this.label21.Text = "Valor Total:";
            // 
            // txtIVA
            // 
            this.txtIVA.BackColor = System.Drawing.Color.Silver;
            this.txtIVA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIVA.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtIVA.Location = new System.Drawing.Point(100, 121);
            this.txtIVA.Name = "txtIVA";
            this.txtIVA.ReadOnly = true;
            this.txtIVA.Size = new System.Drawing.Size(134, 21);
            this.txtIVA.TabIndex = 23;
            this.txtIVA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtIVA.Visible = false;
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.BackColor = System.Drawing.Color.Silver;
            this.txtSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubTotal.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtSubTotal.Location = new System.Drawing.Point(100, 95);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.ReadOnly = true;
            this.txtSubTotal.Size = new System.Drawing.Size(134, 21);
            this.txtSubTotal.TabIndex = 22;
            this.txtSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(6, 128);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(30, 13);
            this.label19.TabIndex = 21;
            this.label19.Text = "IVA :";
            this.label19.Visible = false;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(6, 102);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(56, 13);
            this.label20.TabIndex = 20;
            this.label20.Text = "Sub Total:";
            // 
            // txtDescuento
            // 
            this.txtDescuento.BackColor = System.Drawing.Color.Silver;
            this.txtDescuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescuento.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtDescuento.Location = new System.Drawing.Point(100, 70);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.ReadOnly = true;
            this.txtDescuento.Size = new System.Drawing.Size(134, 21);
            this.txtDescuento.TabIndex = 19;
            this.txtDescuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDescuento.Visible = false;
            // 
            // txtSubTotalCero
            // 
            this.txtSubTotalCero.BackColor = System.Drawing.Color.Silver;
            this.txtSubTotalCero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubTotalCero.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtSubTotalCero.Location = new System.Drawing.Point(100, 44);
            this.txtSubTotalCero.Name = "txtSubTotalCero";
            this.txtSubTotalCero.ReadOnly = true;
            this.txtSubTotalCero.Size = new System.Drawing.Size(134, 21);
            this.txtSubTotalCero.TabIndex = 18;
            this.txtSubTotalCero.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSubTotalCero.Visible = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 77);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(62, 13);
            this.label16.TabIndex = 17;
            this.label16.Text = "Descuento:";
            this.label16.Visible = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 49);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(76, 13);
            this.label17.TabIndex = 16;
            this.label17.Text = "Sub Total 0%::";
            this.label17.Visible = false;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 21);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(59, 13);
            this.label18.TabIndex = 15;
            this.label18.Text = "Sub Total :";
            this.label18.Visible = false;
            // 
            // txtSubTotalDoce
            // 
            this.txtSubTotalDoce.BackColor = System.Drawing.Color.Silver;
            this.txtSubTotalDoce.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubTotalDoce.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtSubTotalDoce.Location = new System.Drawing.Point(100, 17);
            this.txtSubTotalDoce.Name = "txtSubTotalDoce";
            this.txtSubTotalDoce.ReadOnly = true;
            this.txtSubTotalDoce.Size = new System.Drawing.Size(134, 21);
            this.txtSubTotalDoce.TabIndex = 14;
            this.txtSubTotalDoce.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSubTotalDoce.Visible = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(681, 457);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(108, 43);
            this.btnGuardar.TabIndex = 22;
            this.btnGuardar.Text = "Guardar Factura";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(566, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(171, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "DESCRIPCION DEL PRODUCTO:";
            // 
            // btnImprimirFactura
            // 
            this.btnImprimirFactura.Enabled = false;
            this.btnImprimirFactura.Location = new System.Drawing.Point(795, 457);
            this.btnImprimirFactura.Name = "btnImprimirFactura";
            this.btnImprimirFactura.Size = new System.Drawing.Size(108, 43);
            this.btnImprimirFactura.TabIndex = 23;
            this.btnImprimirFactura.Text = "Imprimir Factura";
            this.btnImprimirFactura.UseVisualStyleBackColor = true;
            this.btnImprimirFactura.Visible = false;
            this.btnImprimirFactura.Click += new System.EventHandler(this.btnImprimirFactura_Click);
            // 
            // btnNueva
            // 
            this.btnNueva.Enabled = false;
            this.btnNueva.Location = new System.Drawing.Point(681, 506);
            this.btnNueva.Name = "btnNueva";
            this.btnNueva.Size = new System.Drawing.Size(108, 43);
            this.btnNueva.TabIndex = 24;
            this.btnNueva.Text = "Generar Nueva Factura";
            this.btnNueva.UseVisualStyleBackColor = true;
            this.btnNueva.Click += new System.EventHandler(this.btnNueva_Click);
            // 
            // FrmFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 561);
            this.Controls.Add(this.btnNueva);
            this.Controls.Add(this.btnImprimirFactura);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.btnLimpiarProducto);
            this.Controls.Add(this.txtMostrarCodigo);
            this.Controls.Add(this.btnAgregarModificarProductoFactura);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtMostrarDetalle);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvNumeroFactura);
            this.Controls.Add(this.dtpFechaFactura);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmFactura";
            this.Text = "Factura";
            this.Load += new System.EventHandler(this.FrmFactura_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNumeroFactura)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductoFactura)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFechaFactura;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnBuscarCliente;
        public System.Windows.Forms.TextBox txtCedulaClienteFactura;
        public System.Windows.Forms.TextBox txtTelefonoClienteFactura;
        public System.Windows.Forms.TextBox txtDireccionClienteFactura;
        public System.Windows.Forms.TextBox txtNombreClienteFactura;
        public System.Windows.Forms.TextBox txtIdClienteFactura;
        public System.Windows.Forms.TextBox txtRucClienteFactura;
        private System.Windows.Forms.DataGridView dgvNumeroFactura;
        public System.Windows.Forms.TextBox txtIdUsuarioFactura;
        private System.Windows.Forms.Label label13;
        public System.Windows.Forms.TextBox txtNombreUsuarioFactura;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtMostrarDetalle;
        private System.Windows.Forms.Button btnAgregarModificarProductoFactura;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtMostrarCodigo;
        private System.Windows.Forms.Button btnLimpiarProducto;
        private System.Windows.Forms.DataGridView dgvProductoFactura;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox txtValorTotal;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtIVA;
        private System.Windows.Forms.TextBox txtSubTotal;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.TextBox txtSubTotalCero;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtSubTotalDoce;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnImprimirFactura;
        private System.Windows.Forms.Button btnNueva;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_PRODUCTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PRODUCTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CANTIDAD_PRODUCTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPCION_PRODUCTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRECIO_PRODUCTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn GANANCIA_PRODUCTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn IMPORTE_PRODUCTO;
    }
}