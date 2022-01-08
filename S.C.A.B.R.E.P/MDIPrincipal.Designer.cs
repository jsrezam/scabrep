namespace S.C.A.B.R.E.P
{
    partial class MDIPrincipal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresarProductosEspecialesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarProductosEspecialesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarProductosEspecialesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trabajosExtraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresarTrabajoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarTrabajoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarTrabajoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaFacturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 672);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1264, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(42, 17);
            this.toolStripStatusLabel.Text = "Estado";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.facturaToolStripMenuItem,
            this.consultasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1264, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.productosToolStripMenuItem,
            this.trabajosExtraToolStripMenuItem,
            this.usuariosToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.archivoToolStripMenuItem.Text = "&Mantenimiento";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresarClienteToolStripMenuItem,
            this.eliminarClienteToolStripMenuItem,
            this.actualizarClienteToolStripMenuItem});
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // ingresarClienteToolStripMenuItem
            // 
            this.ingresarClienteToolStripMenuItem.Name = "ingresarClienteToolStripMenuItem";
            this.ingresarClienteToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.ingresarClienteToolStripMenuItem.Text = "&Ingresar Cliente";
            this.ingresarClienteToolStripMenuItem.Click += new System.EventHandler(this.ingresarClienteToolStripMenuItem_Click);
            // 
            // eliminarClienteToolStripMenuItem
            // 
            this.eliminarClienteToolStripMenuItem.Name = "eliminarClienteToolStripMenuItem";
            this.eliminarClienteToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.eliminarClienteToolStripMenuItem.Text = "&Eliminar Cliente";
            this.eliminarClienteToolStripMenuItem.Click += new System.EventHandler(this.eliminarClienteToolStripMenuItem_Click);
            // 
            // actualizarClienteToolStripMenuItem
            // 
            this.actualizarClienteToolStripMenuItem.Name = "actualizarClienteToolStripMenuItem";
            this.actualizarClienteToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.actualizarClienteToolStripMenuItem.Text = "&Actualizar Cliente";
            this.actualizarClienteToolStripMenuItem.Click += new System.EventHandler(this.actualizarClienteToolStripMenuItem_Click);
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresarProductosEspecialesToolStripMenuItem,
            this.eliminarProductosEspecialesToolStripMenuItem,
            this.actualizarProductosEspecialesToolStripMenuItem});
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.productosToolStripMenuItem.Text = "&Productos";
            // 
            // ingresarProductosEspecialesToolStripMenuItem
            // 
            this.ingresarProductosEspecialesToolStripMenuItem.Name = "ingresarProductosEspecialesToolStripMenuItem";
            this.ingresarProductosEspecialesToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.ingresarProductosEspecialesToolStripMenuItem.Text = "&Ingresar Productos";
            this.ingresarProductosEspecialesToolStripMenuItem.Click += new System.EventHandler(this.ingresarProductosToolStripMenuItem_Click);
            // 
            // eliminarProductosEspecialesToolStripMenuItem
            // 
            this.eliminarProductosEspecialesToolStripMenuItem.Name = "eliminarProductosEspecialesToolStripMenuItem";
            this.eliminarProductosEspecialesToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.eliminarProductosEspecialesToolStripMenuItem.Text = "&Eliminar Productos";
            this.eliminarProductosEspecialesToolStripMenuItem.Click += new System.EventHandler(this.eliminarProductosToolStripMenuItem_Click);
            // 
            // actualizarProductosEspecialesToolStripMenuItem
            // 
            this.actualizarProductosEspecialesToolStripMenuItem.Name = "actualizarProductosEspecialesToolStripMenuItem";
            this.actualizarProductosEspecialesToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.actualizarProductosEspecialesToolStripMenuItem.Text = "&Actualizar Productos";
            this.actualizarProductosEspecialesToolStripMenuItem.Click += new System.EventHandler(this.actualizarProductosToolStripMenuItem_Click);
            // 
            // trabajosExtraToolStripMenuItem
            // 
            this.trabajosExtraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresarTrabajoToolStripMenuItem,
            this.eliminarTrabajoToolStripMenuItem,
            this.actualizarTrabajoToolStripMenuItem});
            this.trabajosExtraToolStripMenuItem.Name = "trabajosExtraToolStripMenuItem";
            this.trabajosExtraToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.trabajosExtraToolStripMenuItem.Text = "&Trabajos";
            // 
            // ingresarTrabajoToolStripMenuItem
            // 
            this.ingresarTrabajoToolStripMenuItem.Name = "ingresarTrabajoToolStripMenuItem";
            this.ingresarTrabajoToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.ingresarTrabajoToolStripMenuItem.Text = "&Ingresar Trabajo";
            this.ingresarTrabajoToolStripMenuItem.Click += new System.EventHandler(this.ingresarTrabajoToolStripMenuItem_Click);
            // 
            // eliminarTrabajoToolStripMenuItem
            // 
            this.eliminarTrabajoToolStripMenuItem.Name = "eliminarTrabajoToolStripMenuItem";
            this.eliminarTrabajoToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.eliminarTrabajoToolStripMenuItem.Text = "&Eliminar Trabajo";
            this.eliminarTrabajoToolStripMenuItem.Click += new System.EventHandler(this.eliminarTrabajoToolStripMenuItem_Click);
            // 
            // actualizarTrabajoToolStripMenuItem
            // 
            this.actualizarTrabajoToolStripMenuItem.Name = "actualizarTrabajoToolStripMenuItem";
            this.actualizarTrabajoToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.actualizarTrabajoToolStripMenuItem.Text = "&Actualizar Trabajo";
            this.actualizarTrabajoToolStripMenuItem.Click += new System.EventHandler(this.actualizarTrabajoToolStripMenuItem_Click);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresarUsuarioToolStripMenuItem,
            this.eliminarUsuarioToolStripMenuItem,
            this.actualizarUsuarioToolStripMenuItem});
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.usuariosToolStripMenuItem.Text = "&Usuarios";
            // 
            // ingresarUsuarioToolStripMenuItem
            // 
            this.ingresarUsuarioToolStripMenuItem.Name = "ingresarUsuarioToolStripMenuItem";
            this.ingresarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.ingresarUsuarioToolStripMenuItem.Text = "&Ingresar Usuario";
            this.ingresarUsuarioToolStripMenuItem.Click += new System.EventHandler(this.ingresarUsuarioToolStripMenuItem_Click);
            // 
            // eliminarUsuarioToolStripMenuItem
            // 
            this.eliminarUsuarioToolStripMenuItem.Name = "eliminarUsuarioToolStripMenuItem";
            this.eliminarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.eliminarUsuarioToolStripMenuItem.Text = "&Eliminar Usuario";
            this.eliminarUsuarioToolStripMenuItem.Click += new System.EventHandler(this.eliminarUsuarioToolStripMenuItem_Click);
            // 
            // actualizarUsuarioToolStripMenuItem
            // 
            this.actualizarUsuarioToolStripMenuItem.Name = "actualizarUsuarioToolStripMenuItem";
            this.actualizarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.actualizarUsuarioToolStripMenuItem.Text = "&Actualizar Usuario";
            this.actualizarUsuarioToolStripMenuItem.Click += new System.EventHandler(this.actualizarUsuarioToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.salirToolStripMenuItem.Text = "&Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // facturaToolStripMenuItem
            // 
            this.facturaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevaFacturaToolStripMenuItem});
            this.facturaToolStripMenuItem.Name = "facturaToolStripMenuItem";
            this.facturaToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.facturaToolStripMenuItem.Text = "&Factura";
            // 
            // nuevaFacturaToolStripMenuItem
            // 
            this.nuevaFacturaToolStripMenuItem.Name = "nuevaFacturaToolStripMenuItem";
            this.nuevaFacturaToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.nuevaFacturaToolStripMenuItem.Text = "&Nueva Factura";
            this.nuevaFacturaToolStripMenuItem.Click += new System.EventHandler(this.nuevaFacturaToolStripMenuItem_Click);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.facturasToolStripMenuItem});
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.consultasToolStripMenuItem.Text = "&Consultas";
            // 
            // facturasToolStripMenuItem
            // 
            this.facturasToolStripMenuItem.Name = "facturasToolStripMenuItem";
            this.facturasToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.facturasToolStripMenuItem.Text = "&Facturas";
            this.facturasToolStripMenuItem.Click += new System.EventHandler(this.facturasToolStripMenuItem_Click);
            // 
            // MDIPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 694);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "MDIPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "S.C.A.B.R.E.P";
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresarProductosEspecialesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarProductosEspecialesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizarProductosEspecialesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trabajosExtraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresarTrabajoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarTrabajoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizarTrabajoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevaFacturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresarUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizarUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturasToolStripMenuItem;
    }
}



