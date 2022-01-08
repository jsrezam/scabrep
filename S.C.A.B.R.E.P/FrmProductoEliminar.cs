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
    public partial class FrmProductoEliminar : Form
    {
        int radioButtonOpcion;
        int Id;
        int flagSeleccion = 0;
        Conexiones productoEspecialObjetoEliminar = new Conexiones();
        public FrmProductoEliminar()
        {
            InitializeComponent();
        }

        private void rBtnCodigoEliminarProducto_CheckedChanged(object sender, EventArgs e)
        {
            lblBusquedaProducto.Visible = true;
            lblBusquedaProducto.Text = "Si busca un producto fuera de los proveedores anticipe su busqueda con PELECCOMPU-";
            txtCodigoProductoEliminar.Enabled = true;
            txtNombreProductoEliminar.Enabled = false;
            txtNombreProductoEliminar.Text = "";
            radioButtonOpcion = 1;
        }

        private void rBtnNombreEliminarProducto_CheckedChanged(object sender, EventArgs e)
        {
            lblBusquedaProducto.Visible = false;
            lblBusquedaProducto.Text = "";
            txtNombreProductoEliminar.Enabled = true;
            txtCodigoProductoEliminar.Enabled = false;
            txtCodigoProductoEliminar.Text = "";
            radioButtonOpcion = 2;
        }

        private void btnBucarEliminarProducto_Click(object sender, EventArgs e)
        {
            buscar();                  
        }
        //CONTROLA EL INGRESO DE DATOS
        bool verificarIngreso()
        {
            bool res;
            if (txtCodigoProductoEliminar.Text == "" && radioButtonOpcion==1)
            {
                MessageBox.Show("Ingrese el codigo del producto", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                res = false;
            }
            else if (txtNombreProductoEliminar.Text == "" && radioButtonOpcion == 2)
            {
                MessageBox.Show("Ingrese el nombre del producto", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                res = false;
            }
            else if (rBtnCodigoEliminarProducto.Checked==false && rBtnNombreEliminarProducto.Checked==false && flagSeleccion==0)
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
        //BUSCA LOS REGISTROS DE LA TABLA PRODUCTOS SEGUN CODIGO O NOMBRE
        public void buscar() 
        {
            if (verificarIngreso())
            {
                if (radioButtonOpcion == 1)
                {
                    productoEspecialObjetoEliminar.consultar("Select * from PRODUCTO WHERE CODIGO_PRODUCTO like'" + txtCodigoProductoEliminar.Text.Trim() + "%'", "PRODUCTO");
                    dgvBuscarProductoEliminar.DataSource = productoEspecialObjetoEliminar.dataset.Tables["PRODUCTO"];
                }
                else if (radioButtonOpcion == 2)
                {
                    productoEspecialObjetoEliminar.consultar("Select * from PRODUCTO WHERE NOMBRE_PRODUCTO like'" + txtNombreProductoEliminar.Text.Trim() + "%'", "PRODUCTO");
                    dgvBuscarProductoEliminar.DataSource = productoEspecialObjetoEliminar.dataset.Tables["PRODUCTO"];
                }
            }
        
        }

        private void dgvBuscarProductoEliminar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Evento para seleccionar el indice de la fila donde se encuentra el producto a eliminar
            int indiceFiladgv = 0;
            indiceFiladgv = e.RowIndex;
            try
            {
                dgvBuscarProductoEliminar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                Id = Convert.ToInt16(dgvBuscarProductoEliminar.Rows[indiceFiladgv].Cells[0].Value);
            }
            catch (ArgumentOutOfRangeException)
            {
                indiceFiladgv = 0;
            }
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            if (txtCodigoProductoEliminar.Text != "" || txtNombreProductoEliminar.Text != "" || flagSeleccion!=0)
            {
                if (productoEspecialObjetoEliminar.eliminar("PRODUCTO", "ID_PRODUCTO='" + Id + "'"))
                {
                    MessageBox.Show("Producto Elminado", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    buscar();
                    this.dgvBuscarProductoEliminar.Refresh();
                    buscarTodos();
                     
                }
                else
                {
                    MessageBox.Show("Por favor Elija un producto a Eliminar", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                this.dgvBuscarProductoEliminar.Refresh();
            }
            else
            {
                MessageBox.Show("Por favor Busque un Producto a Eliminar", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnSalirEliminarProducto_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            buscarTodos();
            
        }

        void buscarTodos()
        {
            flagSeleccion = 1;
            productoEspecialObjetoEliminar.consultar("SELECT * FROM PRODUCTO", "PRODUCTO");
            dgvBuscarProductoEliminar.DataSource = productoEspecialObjetoEliminar.dataset.Tables["PRODUCTO"];      
        }


    }
}
