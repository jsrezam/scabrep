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
    public partial class FrmTrabajoEliminar : Form
    {
        int flagSeleccion = 0;
        int radioButtonOpcion;
        int Id;
        Conexiones trabajoObjetoEliminar = new Conexiones();
        public FrmTrabajoEliminar()
        {
            InitializeComponent();
        }
        private void btnSalirEliminarTrabajo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void rBtnCodigoEliminarTrabajo_CheckedChanged(object sender, EventArgs e)
        {
            lblBusquedaProducto.Text = "Si busca un producto fuera de los proveedores anticipe su busqueda con TELECCOMPU-";
            txtCodigoTrabajoEliminar.Enabled = true;
            txtNombreTrabajoEliminar.Enabled = false;
            txtNombreTrabajoEliminar.Text = "";
            radioButtonOpcion = 1;
        }
        private void rBtnNombreEliminarTrabajo_CheckedChanged(object sender, EventArgs e)
        {
            txtNombreTrabajoEliminar.Enabled = true;
            txtCodigoTrabajoEliminar.Enabled = false;
            txtCodigoTrabajoEliminar.Text = "";
            radioButtonOpcion = 2;
        }
        private void btnBucarEliminarTrabajo_Click(object sender, EventArgs e)
        {
            buscar();
        }
        //VERIFICAR EL INGRESO DE DATOS
        bool verificarIngreso()
        {
            bool res;
            if (txtCodigoTrabajoEliminar.Text == "" && radioButtonOpcion == 1)
            {
                MessageBox.Show("Ingrese el codigo del producto", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                res = false;
            }
            else if (txtNombreTrabajoEliminar.Text == "" && radioButtonOpcion == 2)
            {
                MessageBox.Show("Ingrese el nombre del producto", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                res = false;
            }
            else if (rBtnCodigoEliminarTrabajo.Checked == false && rBtnNombreEliminarTrabajo.Checked == false&& flagSeleccion==0)
            {
                MessageBox.Show("Escoja una opcion de busqueda", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                res = false;
            }
            else
            {
                res = true;
            }
            return res;
        }
        private void dgvBuscarTrabajoEliminar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Evento para seleccionar el indice de la fila donde se encuentra el producto a eliminar
            int indiceFiladgv = 0;
            indiceFiladgv = e.RowIndex;
            try
            {
                dgvBuscarTrabajoEliminar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                Id = Convert.ToInt16(dgvBuscarTrabajoEliminar.Rows[indiceFiladgv].Cells[0].Value);
            }
            catch (ArgumentOutOfRangeException)
            {
                indiceFiladgv = 0;
            }

        }
        //BUSCA EL TRABAJO A ELIMINAR DE LA TABLA PRODUCTO
        public void buscar()
        {
            if (verificarIngreso())
            {
                if (radioButtonOpcion == 1)
                {
                    trabajoObjetoEliminar.consultar("Select * from PRODUCTO WHERE CODIGO_PRODUCTO like'%" + txtCodigoTrabajoEliminar.Text.Trim() + "%'", "PRODUCTO");
                    dgvBuscarTrabajoEliminar.DataSource = trabajoObjetoEliminar.dataset.Tables["PRODUCTO"];
                }
                else if (radioButtonOpcion == 2)
                {
                    trabajoObjetoEliminar.consultar("Select * from PRODUCTO WHERE NOMBRE_PRODUCTO like'%" + txtNombreTrabajoEliminar.Text.Trim() + "%'", "PRODUCTO");
                    dgvBuscarTrabajoEliminar.DataSource = trabajoObjetoEliminar.dataset.Tables["PRODUCTO"];
                }
            }

        }

        private void btnEliminarTrabajo_Click(object sender, EventArgs e)
        {
            if (txtCodigoTrabajoEliminar.Text != "" || txtNombreTrabajoEliminar.Text != "" || flagSeleccion!=0)
            {
                if (trabajoObjetoEliminar.eliminar("PRODUCTO", "ID_PRODUCTO='" + Id + "'"))
                {
                    MessageBox.Show("Trabajo Elminado", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    buscar();
                    this.dgvBuscarTrabajoEliminar.Refresh();
                    buscarTodos();

                }
                else
                {
                    MessageBox.Show("Error al eliminar,Por favor Elija un trabajo a Eliminar", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                this.dgvBuscarTrabajoEliminar.Refresh();
            }
            else
            {
                MessageBox.Show("Por favor Busque un Trabajo a Eliminar", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            buscarTodos();
        }

        void buscarTodos()
        {
            flagSeleccion = 1;
            trabajoObjetoEliminar.consultar("SELECT * FROM PRODUCTO", "PRODUCTO");
            dgvBuscarTrabajoEliminar.DataSource = trabajoObjetoEliminar.dataset.Tables["PRODUCTO"];
            
        }

        private void txtNombreTrabajoEliminar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\'')
            {
                e.Handled = true;
            }
        }

    }
}
