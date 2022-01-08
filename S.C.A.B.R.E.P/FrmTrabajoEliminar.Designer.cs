namespace S.C.A.B.R.E.P
{
    partial class FrmTrabajoEliminar
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
            this.dgvBuscarTrabajoEliminar = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblBusquedaProducto = new System.Windows.Forms.Label();
            this.txtNombreTrabajoEliminar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rBtnNombreEliminarTrabajo = new System.Windows.Forms.RadioButton();
            this.btnSalirEliminarTrabajo = new System.Windows.Forms.Button();
            this.btnEliminarTrabajo = new System.Windows.Forms.Button();
            this.btnBucarEliminarTrabajo = new System.Windows.Forms.Button();
            this.rBtnCodigoEliminarTrabajo = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCodigoTrabajoEliminar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarTrabajoEliminar)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvBuscarTrabajoEliminar
            // 
            this.dgvBuscarTrabajoEliminar.AllowUserToAddRows = false;
            this.dgvBuscarTrabajoEliminar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvBuscarTrabajoEliminar.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvBuscarTrabajoEliminar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuscarTrabajoEliminar.Location = new System.Drawing.Point(12, 142);
            this.dgvBuscarTrabajoEliminar.MultiSelect = false;
            this.dgvBuscarTrabajoEliminar.Name = "dgvBuscarTrabajoEliminar";
            this.dgvBuscarTrabajoEliminar.ReadOnly = true;
            this.dgvBuscarTrabajoEliminar.Size = new System.Drawing.Size(950, 150);
            this.dgvBuscarTrabajoEliminar.TabIndex = 10;
            this.dgvBuscarTrabajoEliminar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBuscarTrabajoEliminar_CellClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.lblBusquedaProducto);
            this.groupBox3.Controls.Add(this.txtNombreTrabajoEliminar);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.rBtnNombreEliminarTrabajo);
            this.groupBox3.Controls.Add(this.btnSalirEliminarTrabajo);
            this.groupBox3.Controls.Add(this.btnEliminarTrabajo);
            this.groupBox3.Controls.Add(this.btnBucarEliminarTrabajo);
            this.groupBox3.Controls.Add(this.rBtnCodigoEliminarTrabajo);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtCodigoTrabajoEliminar);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(950, 124);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Buscar Trabajo Según: Codigo/Nombre";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(822, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 64);
            this.button1.TabIndex = 31;
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
            this.lblBusquedaProducto.TabIndex = 30;
            this.lblBusquedaProducto.Text = "label2";
            this.lblBusquedaProducto.Visible = false;
            // 
            // txtNombreTrabajoEliminar
            // 
            this.txtNombreTrabajoEliminar.Enabled = false;
            this.txtNombreTrabajoEliminar.Location = new System.Drawing.Point(118, 89);
            this.txtNombreTrabajoEliminar.Name = "txtNombreTrabajoEliminar";
            this.txtNombreTrabajoEliminar.Size = new System.Drawing.Size(257, 20);
            this.txtNombreTrabajoEliminar.TabIndex = 28;
            this.txtNombreTrabajoEliminar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreTrabajoEliminar_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Nombre del Trabajo:";
            // 
            // rBtnNombreEliminarTrabajo
            // 
            this.rBtnNombreEliminarTrabajo.AutoSize = true;
            this.rBtnNombreEliminarTrabajo.Location = new System.Drawing.Point(136, 31);
            this.rBtnNombreEliminarTrabajo.Name = "rBtnNombreEliminarTrabajo";
            this.rBtnNombreEliminarTrabajo.Size = new System.Drawing.Size(121, 17);
            this.rBtnNombreEliminarTrabajo.TabIndex = 26;
            this.rBtnNombreEliminarTrabajo.Text = "Nombre del Trabajo:";
            this.rBtnNombreEliminarTrabajo.UseVisualStyleBackColor = true;
            this.rBtnNombreEliminarTrabajo.CheckedChanged += new System.EventHandler(this.rBtnNombreEliminarTrabajo_CheckedChanged);
            // 
            // btnSalirEliminarTrabajo
            // 
            this.btnSalirEliminarTrabajo.Location = new System.Drawing.Point(871, 89);
            this.btnSalirEliminarTrabajo.Name = "btnSalirEliminarTrabajo";
            this.btnSalirEliminarTrabajo.Size = new System.Drawing.Size(75, 23);
            this.btnSalirEliminarTrabajo.TabIndex = 25;
            this.btnSalirEliminarTrabajo.Text = "Salir";
            this.btnSalirEliminarTrabajo.UseVisualStyleBackColor = true;
            this.btnSalirEliminarTrabajo.Click += new System.EventHandler(this.btnSalirEliminarTrabajo_Click);
            // 
            // btnEliminarTrabajo
            // 
            this.btnEliminarTrabajo.Location = new System.Drawing.Point(790, 89);
            this.btnEliminarTrabajo.Name = "btnEliminarTrabajo";
            this.btnEliminarTrabajo.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarTrabajo.TabIndex = 24;
            this.btnEliminarTrabajo.Text = "Eliminar";
            this.btnEliminarTrabajo.UseVisualStyleBackColor = true;
            this.btnEliminarTrabajo.Click += new System.EventHandler(this.btnEliminarTrabajo_Click);
            // 
            // btnBucarEliminarTrabajo
            // 
            this.btnBucarEliminarTrabajo.Location = new System.Drawing.Point(709, 89);
            this.btnBucarEliminarTrabajo.Name = "btnBucarEliminarTrabajo";
            this.btnBucarEliminarTrabajo.Size = new System.Drawing.Size(75, 23);
            this.btnBucarEliminarTrabajo.TabIndex = 23;
            this.btnBucarEliminarTrabajo.Text = "Buscar";
            this.btnBucarEliminarTrabajo.UseVisualStyleBackColor = true;
            this.btnBucarEliminarTrabajo.Click += new System.EventHandler(this.btnBucarEliminarTrabajo_Click);
            // 
            // rBtnCodigoEliminarTrabajo
            // 
            this.rBtnCodigoEliminarTrabajo.AutoSize = true;
            this.rBtnCodigoEliminarTrabajo.Location = new System.Drawing.Point(6, 31);
            this.rBtnCodigoEliminarTrabajo.Name = "rBtnCodigoEliminarTrabajo";
            this.rBtnCodigoEliminarTrabajo.Size = new System.Drawing.Size(117, 17);
            this.rBtnCodigoEliminarTrabajo.TabIndex = 20;
            this.rBtnCodigoEliminarTrabajo.Text = "Codigo del Trabajo:";
            this.rBtnCodigoEliminarTrabajo.UseVisualStyleBackColor = true;
            this.rBtnCodigoEliminarTrabajo.CheckedChanged += new System.EventHandler(this.rBtnCodigoEliminarTrabajo_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Codigo del Trabajo:";
            // 
            // txtCodigoTrabajoEliminar
            // 
            this.txtCodigoTrabajoEliminar.Enabled = false;
            this.txtCodigoTrabajoEliminar.Location = new System.Drawing.Point(118, 63);
            this.txtCodigoTrabajoEliminar.Name = "txtCodigoTrabajoEliminar";
            this.txtCodigoTrabajoEliminar.Size = new System.Drawing.Size(257, 20);
            this.txtCodigoTrabajoEliminar.TabIndex = 5;
            // 
            // FrmTrabajoEliminar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 302);
            this.Controls.Add(this.dgvBuscarTrabajoEliminar);
            this.Controls.Add(this.groupBox3);
            this.Name = "FrmTrabajoEliminar";
            this.Text = "EliminarTrabajo";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarTrabajoEliminar)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBuscarTrabajoEliminar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtNombreTrabajoEliminar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rBtnNombreEliminarTrabajo;
        private System.Windows.Forms.Button btnSalirEliminarTrabajo;
        private System.Windows.Forms.Button btnEliminarTrabajo;
        private System.Windows.Forms.Button btnBucarEliminarTrabajo;
        private System.Windows.Forms.RadioButton rBtnCodigoEliminarTrabajo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCodigoTrabajoEliminar;
        private System.Windows.Forms.Label lblBusquedaProducto;
        private System.Windows.Forms.Button button1;
    }
}