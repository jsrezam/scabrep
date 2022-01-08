using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace S.C.A.B.R.E.P
{
    public partial class MDIPrincipal : Form
    {
        public string nombre;
        public string pass;

        private int childFormNumber = 0;

        public MDIPrincipal(string nombre, string pass)
        {
            InitializeComponent();
            this.nombre = nombre;
            this.pass = pass;
        }
        /*FrmClienteIngresar fClienteIngresar = new FrmClienteIngresar();
        FrmClienteEliminar fClienteElminar = new FrmClienteEliminar();
        */
        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ingresarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmClienteIngresar fClienteIngresar = new FrmClienteIngresar();
            fClienteIngresar.MdiParent = this;
            fClienteIngresar.StartPosition = 0;
            fClienteIngresar.Show();
        }

        private void eliminarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmClienteEliminar fClienteElminar = new FrmClienteEliminar();
            //fClienteIngresar.Close();
            fClienteElminar.MdiParent = this;
            fClienteElminar.StartPosition = 0;
            fClienteElminar.Show();
        }

        private void actualizarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmClienteActualizar fClienteActualizar = new FrmClienteActualizar();
            fClienteActualizar.MdiParent = this;
            fClienteActualizar.StartPosition = 0;
            fClienteActualizar.Show();
        }

        private void ingresarProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProductoIngresar fProductosIngresar = new FrmProductoIngresar();
            fProductosIngresar.MdiParent = this;
            fProductosIngresar.StartPosition = 0;
            fProductosIngresar.Show();
        }

        private void eliminarProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProductoEliminar fProductosEliminar = new FrmProductoEliminar();
            fProductosEliminar.MdiParent = this; 
            fProductosEliminar.StartPosition = 0;
            fProductosEliminar.Show();
        }

        private void actualizarProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProductoActualizar fProductosActualizar = new FrmProductoActualizar();
            fProductosActualizar.MdiParent = this;
            fProductosActualizar.StartPosition = 0;
            fProductosActualizar.Show();
        }

        private void ingresarTrabajoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTrabajoIngresar fTrabajoIngresar = new FrmTrabajoIngresar();
            fTrabajoIngresar.MdiParent = this;
            fTrabajoIngresar.StartPosition = 0;
            fTrabajoIngresar.Show();
        }

        private void eliminarTrabajoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTrabajoEliminar fTrabajoEliminar = new FrmTrabajoEliminar();
            fTrabajoEliminar.MdiParent = this;
            fTrabajoEliminar.StartPosition = 0;
            fTrabajoEliminar.Show();
        }

        private void actualizarTrabajoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTrabajoActualizar fTrabajoActualizar = new FrmTrabajoActualizar();
            fTrabajoActualizar.MdiParent = this;
            fTrabajoActualizar.StartPosition = 0;
            fTrabajoActualizar.Show();
        }

        private void nuevaFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //FrmFactura fFactura = new FrmFactura("","","","","","","","","");
       
            FrmFactura fFactura = new FrmFactura(nombre,pass);
            fFactura.MdiParent = this;
            fFactura.StartPosition = 0;
            fFactura.Show();
        }

        private void ingresarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUsuarioIngresar fUsuarioIngresar = new FrmUsuarioIngresar();
            fUsuarioIngresar.MdiParent = this;
            fUsuarioIngresar.StartPosition = 0;
            fUsuarioIngresar.Show();
        }

        private void eliminarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUsuarioEliminar fUsuarioEliminar = new FrmUsuarioEliminar();
            fUsuarioEliminar.MdiParent = this;
            fUsuarioEliminar.StartPosition = 0;
            fUsuarioEliminar.Show();
        }

        private void actualizarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUsuarioActualizar fUsuarioActualizar = new FrmUsuarioActualizar();
            fUsuarioActualizar.MdiParent = this;
            fUsuarioActualizar.StartPosition = 0;
            fUsuarioActualizar.Show();
        }

        private void facturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultasFactura fConsultasFacturas = new FrmConsultasFactura();
            fConsultasFacturas.MdiParent = this;
            fConsultasFacturas.StartPosition = 0;
            fConsultasFacturas.Show();
        }

    }
}
