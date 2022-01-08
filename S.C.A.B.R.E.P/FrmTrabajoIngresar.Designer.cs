namespace S.C.A.B.R.E.P
{
    partial class FrmTrabajoIngresar
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
            this.lblTrabajo = new System.Windows.Forms.Label();
            this.lblAvisoCostoTrabajo = new System.Windows.Forms.Label();
            this.btnSalirTrabajo = new System.Windows.Forms.Button();
            this.txtCostoTrabajo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnIngresarTrabajo = new System.Windows.Forms.Button();
            this.txtNombreTrabajo = new System.Windows.Forms.TextBox();
            this.txtCodigoTrabajo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTrabajo);
            this.groupBox1.Controls.Add(this.lblAvisoCostoTrabajo);
            this.groupBox1.Controls.Add(this.btnSalirTrabajo);
            this.groupBox1.Controls.Add(this.txtCostoTrabajo);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.btnIngresarTrabajo);
            this.groupBox1.Controls.Add(this.txtNombreTrabajo);
            this.groupBox1.Controls.Add(this.txtCodigoTrabajo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(784, 276);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Trabajo:";
            // 
            // lblTrabajo
            // 
            this.lblTrabajo.AutoSize = true;
            this.lblTrabajo.Location = new System.Drawing.Point(114, 35);
            this.lblTrabajo.Name = "lblTrabajo";
            this.lblTrabajo.Size = new System.Drawing.Size(83, 13);
            this.lblTrabajo.TabIndex = 21;
            this.lblTrabajo.Text = "TELECCOMPU-";
            // 
            // lblAvisoCostoTrabajo
            // 
            this.lblAvisoCostoTrabajo.AutoSize = true;
            this.lblAvisoCostoTrabajo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvisoCostoTrabajo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblAvisoCostoTrabajo.Location = new System.Drawing.Point(380, 217);
            this.lblAvisoCostoTrabajo.Name = "lblAvisoCostoTrabajo";
            this.lblAvisoCostoTrabajo.Size = new System.Drawing.Size(96, 13);
            this.lblAvisoCostoTrabajo.TabIndex = 20;
            this.lblAvisoCostoTrabajo.Text = "AvisoCostoTrabajo";
            this.lblAvisoCostoTrabajo.Visible = false;
            // 
            // btnSalirTrabajo
            // 
            this.btnSalirTrabajo.Location = new System.Drawing.Point(678, 247);
            this.btnSalirTrabajo.Name = "btnSalirTrabajo";
            this.btnSalirTrabajo.Size = new System.Drawing.Size(101, 23);
            this.btnSalirTrabajo.TabIndex = 12;
            this.btnSalirTrabajo.Text = "Salir";
            this.btnSalirTrabajo.UseVisualStyleBackColor = true;
            this.btnSalirTrabajo.Click += new System.EventHandler(this.btnSalirTrabajo_Click);
            // 
            // txtCostoTrabajo
            // 
            this.txtCostoTrabajo.Location = new System.Drawing.Point(117, 214);
            this.txtCostoTrabajo.Name = "txtCostoTrabajo";
            this.txtCostoTrabajo.Size = new System.Drawing.Size(257, 20);
            this.txtCostoTrabajo.TabIndex = 8;
            this.txtCostoTrabajo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCostoTrabajo_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 214);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Costo del Trabajo:";
            // 
            // btnIngresarTrabajo
            // 
            this.btnIngresarTrabajo.Location = new System.Drawing.Point(571, 247);
            this.btnIngresarTrabajo.Name = "btnIngresarTrabajo";
            this.btnIngresarTrabajo.Size = new System.Drawing.Size(101, 23);
            this.btnIngresarTrabajo.TabIndex = 11;
            this.btnIngresarTrabajo.Text = "Insertar";
            this.btnIngresarTrabajo.UseVisualStyleBackColor = true;
            this.btnIngresarTrabajo.Click += new System.EventHandler(this.btnIngresarTrabajo_Click);
            // 
            // txtNombreTrabajo
            // 
            this.txtNombreTrabajo.Location = new System.Drawing.Point(117, 61);
            this.txtNombreTrabajo.Multiline = true;
            this.txtNombreTrabajo.Name = "txtNombreTrabajo";
            this.txtNombreTrabajo.Size = new System.Drawing.Size(337, 147);
            this.txtNombreTrabajo.TabIndex = 3;
            this.txtNombreTrabajo.TextChanged += new System.EventHandler(this.txtNombreTrabajo_TextChanged);
            // 
            // txtCodigoTrabajo
            // 
            this.txtCodigoTrabajo.Location = new System.Drawing.Point(203, 32);
            this.txtCodigoTrabajo.Name = "txtCodigoTrabajo";
            this.txtCodigoTrabajo.Size = new System.Drawing.Size(257, 20);
            this.txtCodigoTrabajo.TabIndex = 2;
            this.txtCodigoTrabajo.TextChanged += new System.EventHandler(this.txtCodigoTrabajo_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Nombre del Trabajo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = " Codigo del Trabajo:";
            // 
            // FrmTrabajoIngresar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 297);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmTrabajoIngresar";
            this.Text = "Ingresar Trabajo";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSalirTrabajo;
        private System.Windows.Forms.TextBox txtCostoTrabajo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnIngresarTrabajo;
        private System.Windows.Forms.TextBox txtNombreTrabajo;
        private System.Windows.Forms.TextBox txtCodigoTrabajo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAvisoCostoTrabajo;
        private System.Windows.Forms.Label lblTrabajo;
    }
}