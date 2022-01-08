namespace S.C.A.B.R.E.P
{
    partial class FrmProductoEliminar
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
            this.lblBusquedaProducto = new System.Windows.Forms.Label();
            this.txtNombreProductoEliminar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBucarEliminarProducto = new System.Windows.Forms.Button();
            this.btnSalirEliminarProducto = new System.Windows.Forms.Button();
            this.rBtnNombreEliminarProducto = new System.Windows.Forms.RadioButton();
            this.btnEliminarProducto = new System.Windows.Forms.Button();
            this.rBtnCodigoEliminarProducto = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCodigoProductoEliminar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarProductoEliminar)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvBuscarProductoEliminar
            // 
            this.dgvBuscarProductoEliminar.AllowUserToAddRows = false;
            this.dgvBuscarProductoEliminar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvBuscarProductoEliminar.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvBuscarProductoEliminar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuscarProductoEliminar.Location = new System.Drawing.Point(12, 142);
            this.dgvBuscarProductoEliminar.MultiSelect = false;
            this.dgvBuscarProductoEliminar.Name = "dgvBuscarProductoEliminar";
            this.dgvBuscarProductoEliminar.ReadOnly = true;
            this.dgvBuscarProductoEliminar.Size = new System.Drawing.Size(959, 150);
            this.dgvBuscarProductoEliminar.TabIndex = 8;
            this.dgvBuscarProductoEliminar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBuscarProductoEliminar_CellClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.lblBusquedaProducto);
            this.groupBox3.Controls.Add(this.txtNombreProductoEliminar);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.btnBucarEliminarProducto);
            this.groupBox3.Controls.Add(this.btnSalirEliminarProducto);
            this.groupBox3.Controls.Add(this.rBtnNombreEliminarProducto);
            this.groupBox3.Controls.Add(this.btnEliminarProducto);
            this.groupBox3.Controls.Add(this.rBtnCodigoEliminarProducto);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtCodigoProductoEliminar);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(959, 124);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Buscar Producto Según: Codigo/Nombre";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(831, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 64);
            this.button1.TabIndex = 30;
            this.button1.Text = "Buscar Todos Productos/Trabajos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblBusquedaProducto
            // 
            this.lblBusquedaProducto.AutoSize = true;
            this.lblBusquedaProducto.ForeColor = System.Drawing.Color.Red;
            this.lblBusquedaProducto.Location = new System.Drawing.Point(381, 70);
            this.lblBusquedaProducto.Name = "lblBusquedaProducto";
            this.lblBusquedaProducto.Size = new System.Drawing.Size(35, 13);
            this.lblBusquedaProducto.TabIndex = 29;
            this.lblBusquedaProducto.Text = "label2";
            this.lblBusquedaProducto.Visible = false;
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
            // btnBucarEliminarProducto
            // 
            this.btnBucarEliminarProducto.Location = new System.Drawing.Point(716, 95);
            this.btnBucarEliminarProducto.Name = "btnBucarEliminarProducto";
            this.btnBucarEliminarProducto.Size = new System.Drawing.Size(75, 23);
            this.btnBucarEliminarProducto.TabIndex = 23;
            this.btnBucarEliminarProducto.Text = "Buscar";
            this.btnBucarEliminarProducto.UseVisualStyleBackColor = true;
            this.btnBucarEliminarProducto.Click += new System.EventHandler(this.btnBucarEliminarProducto_Click);
            // 
            // btnSalirEliminarProducto
            // 
            this.btnSalirEliminarProducto.Location = new System.Drawing.Point(878, 95);
            this.btnSalirEliminarProducto.Name = "btnSalirEliminarProducto";
            this.btnSalirEliminarProducto.Size = new System.Drawing.Size(75, 23);
            this.btnSalirEliminarProducto.TabIndex = 25;
            this.btnSalirEliminarProducto.Text = "Salir";
            this.btnSalirEliminarProducto.UseVisualStyleBackColor = true;
            this.btnSalirEliminarProducto.Click += new System.EventHandler(this.btnSalirEliminarProducto_Click);
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
            // btnEliminarProducto
            // 
            this.btnEliminarProducto.Location = new System.Drawing.Point(797, 95);
            this.btnEliminarProducto.Name = "btnEliminarProducto";
            this.btnEliminarProducto.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarProducto.TabIndex = 24;
            this.btnEliminarProducto.Text = "Eliminar";
            this.btnEliminarProducto.UseVisualStyleBackColor = true;
            this.btnEliminarProducto.Click += new System.EventHandler(this.btnEliminarProducto_Click);
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
            // FrmProductoEliminar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 324);
            this.Controls.Add(this.dgvBuscarProductoEliminar);
            this.Controls.Add(this.groupBox3);
            this.Name = "FrmProductoEliminar";
            this.Text = "Eliminar Productos Especiales";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarProductoEliminar)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBuscarProductoEliminar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtNombreProductoEliminar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rBtnNombreEliminarProducto;
        private System.Windows.Forms.Button btnSalirEliminarProducto;
        private System.Windows.Forms.Button btnEliminarProducto;
        private System.Windows.Forms.Button btnBucarEliminarProducto;
        private System.Windows.Forms.RadioButton rBtnCodigoEliminarProducto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCodigoProductoEliminar;
        private System.Windows.Forms.Label lblBusquedaProducto;
        private System.Windows.Forms.Button button1;
    }
}