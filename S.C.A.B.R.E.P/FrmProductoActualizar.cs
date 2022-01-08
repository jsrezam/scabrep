using System;
using System.Windows.Forms;

namespace S.C.A.B.R.E.P
{
    public partial class FrmProductoActualizar : Form
    {
        int flagSeleccion = 0;
        int radioButtonOpcion;
        int Id;
        int flagSeleccion2 =0;
        Conexiones productoEspecialObjetoEliminar = new Conexiones();
        string codigo;
        string nombre;
        double precio;
        int IdActualizarDataGridView;
        int IdActualizarAyudante;

        public FrmProductoActualizar()
        {
            InitializeComponent();
        }

        private void rBtnCodigoEliminarProducto_CheckedChanged(object sender, EventArgs e)
        {
            txtCodigoProductoEliminar.Enabled = true;
            txtNombreProductoEliminar.Enabled = false;
            txtNombreProductoEliminar.Text = "";
            radioButtonOpcion = 1;
        }

        private void rBtnNombreEliminarProducto_CheckedChanged(object sender, EventArgs e)
        {
            txtNombreProductoEliminar.Enabled = true;
            txtCodigoProductoEliminar.Enabled = false;
            txtCodigoProductoEliminar.Text = "";
            radioButtonOpcion = 2;
        }

        private void dgvBuscarProductoEliminar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Evento para seleccionar el indice de la fila donde se encuentra el producto a actualizar
            int indiceFiladgv = 0;
            indiceFiladgv = e.RowIndex;
            try
            {
                flagSeleccion2 = 1;                 
                codigo = dgvBuscarProductoEliminar.Rows[indiceFiladgv].Cells[1].Value.ToString().Trim();
                nombre = dgvBuscarProductoEliminar.Rows[indiceFiladgv].Cells[2].Value.ToString().Trim();
                precio = Math.Round(Convert.ToDouble( dgvBuscarProductoEliminar.Rows[indiceFiladgv].Cells[3].Value.ToString()),2);

                txtCodigoProducto.Text = dgvBuscarProductoEliminar.Rows[indiceFiladgv].Cells[1].Value.ToString().Trim();
                txtNombreProducto.Text = dgvBuscarProductoEliminar.Rows[indiceFiladgv].Cells[2].Value.ToString().Trim();
                txtCostoProducto.Text = Math.Round(Convert.ToDouble(dgvBuscarProductoEliminar.Rows[indiceFiladgv].Cells[3].Value), 2).ToString().Trim();
                IdActualizarDataGridView = Convert.ToInt16(dgvBuscarProductoEliminar.Rows[indiceFiladgv].Cells[0].Value);
                IdActualizarAyudante = Convert.ToInt16(dgvBuscarProductoEliminar.Rows[indiceFiladgv].Cells[0].Value);
                Id = Convert.ToInt16(dgvBuscarProductoEliminar.Rows[indiceFiladgv].Cells[0].Value);

                dgvBuscarProductoEliminar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                Id = Convert.ToInt16(dgvBuscarProductoEliminar.Rows[indiceFiladgv].Cells[0].Value);
            }
            catch (ArgumentOutOfRangeException)
            {
                indiceFiladgv = 0;
            }
        }

        //RELIZA LA BUSQUEDA DEL PRODUCTO CEGUN CODIGO O NOMBRE(APROXIMACION)
        public void buscar()
        {
            if (verificarIngreso())
            {
                if (radioButtonOpcion == 1)
                {
                    productoEspecialObjetoEliminar.consultar("Select * from PRODUCTO WHERE CODIGO_PRODUCTO LIKE'%" + txtCodigoProductoEliminar.Text.Trim() + "%'", "PRODUCTO");
                    dgvBuscarProductoEliminar.DataSource = productoEspecialObjetoEliminar.dataset.Tables["PRODUCTO"];
                }
                else if (radioButtonOpcion == 2)
                {
                    productoEspecialObjetoEliminar.consultar("Select * from PRODUCTO WHERE NOMBRE_PRODUCTO like'" + txtNombreProductoEliminar.Text.Trim() + "%'", "PRODUCTO");
                    dgvBuscarProductoEliminar.DataSource = productoEspecialObjetoEliminar.dataset.Tables["PRODUCTO"];
                }
            }
        }

        //CONTROLA EL INGRESO DE DATOS
        bool verificarIngreso()
        {
            bool res;
            if (txtCodigoProductoEliminar.Text == string.Empty && radioButtonOpcion == 1)
            {
                MessageBox.Show("Ingrese el codigo del producto", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                res = false;
            }
            else if (txtNombreProductoEliminar.Text == string.Empty && radioButtonOpcion == 2)
            {
                MessageBox.Show("Ingrese el nombre del producto", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                res = false;
            }
            else if (rBtnCodigoEliminarProducto.Checked == false && rBtnNombreEliminarProducto.Checked == false && flagSeleccion==0)
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

        private void btnBucarEliminarProducto_Click(object sender, EventArgs e)
        {
            buscar();
        }

        private void btnActualizarPredeterminadoProducto_Click(object sender, EventArgs e)
        {
            try
            {
                txtCodigoProducto.Text = codigo.Trim();
                txtNombreProducto.Text = nombre.Trim();
                txtCostoProducto.Text = precio.ToString().Trim();
            }
            catch {
                MessageBox.Show("No se ha seleccionado ningun producto", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);   
            }
        }

        private void btnCancelarIngresarCliente_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //ACTUALIZA EL PRODUCTO SEGUN LOS CAMPOS QUE EL USARIO DESEE CAMBIAR
        private void btnActualizarProducto_Click(object sender, EventArgs e)
        {
            if (verificarIngreso2())
            {
                if (codigo.Trim() == txtCodigoProducto.Text.Trim())
                {
                    string campos = "CODIGO_PRODUCTO='" + this.txtCodigoProducto.Text.Trim() + "',NOMBRE_PRODUCTO='" + this.txtNombreProducto.Text.Trim() + "',PRECIO_PRODUCTO=" + this.txtCostoProducto.Text.Trim() + "";
                    if (productoEspecialObjetoEliminar.actualizar("PRODUCTO", campos, "ID_PRODUCTO=" + Id ))
                    {
                        MessageBox.Show("Registro Actualizado ", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        codigo = txtCodigoProducto.Text.Trim();
                        nombre = txtNombreProducto.Text.Trim();
                        precio = Math.Round(Convert.ToDouble(txtCostoProducto.Text.Trim()), 2);
                        actualizarDataGridView();
                    }
                    else
                    {
                        MessageBox.Show("Por favor Elija un Producto para actualizar ", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    int resActualizar = productoEspecialObjetoEliminar.verificarCodigoRepeticionProductoEspecialActualizar(txtCodigoProducto.Text.Trim(), txtNombreProducto.Text.Trim(), Math.Round(Convert.ToDouble(txtCostoProducto.Text.Trim())),IdActualizarAyudante);
                    if (resActualizar == 1)
                    {
                        MessageBox.Show("Registro Actualizado ", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        actualizarDataGridView();
                    }
                    else
                    {
                        MessageBox.Show("El Codigo del Producto ya se encuentra registrado, Por favor verifique ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        //VERIFICA EL INGRESO DE DATOS        
        bool verificarIngreso2()
        {
            bool res;
            if (flagSeleccion == 0 && flagSeleccion2==0)
            {
                MessageBox.Show("Escoja un producto para actualizar", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                res = false;
            }            
            else
            {
                res = true;
            }

            return res;
        }

        //VERIFICA EL INGRESO DEL CAMPO COSTO SEGUN SQL-SERVER (.)
        private void txtCostoProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            lblAvisoCostoProductoEspecial.Visible = true;
            lblAvisoCostoProductoEspecial.Text = "Ingrese el costo del producto con el formato (.) para decimales";
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (e.KeyChar == '.')
            {
                e.Handled = false;
            }

            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtCodigoProducto_TextChanged(object sender, EventArgs e)
        {
            lblAvisoCostoProductoEspecial.Visible = false;
            lblAvisoCostoProductoEspecial.Text = string.Empty;
        }

        private void txtNombreProducto_TextChanged(object sender, EventArgs e)
        {
            lblAvisoCostoProductoEspecial.Visible = false;
            lblAvisoCostoProductoEspecial.Text = string.Empty;
        }

        private void txtDescripcionProducto_TextChanged(object sender, EventArgs e)
        {
            lblAvisoCostoProductoEspecial.Visible = false;
            lblAvisoCostoProductoEspecial.Text = string.Empty;
        }

        //REALIZA OTRO CONSULTA CON EL ID PREDETERMIDAO PARA REFRESCAR EL DATAGRIDVIEW
        public void actualizarDataGridView()
        {
            productoEspecialObjetoEliminar.consultar("Select * from PRODUCTO WHERE ID_PRODUCTO='" + IdActualizarDataGridView + "'", "PRODUCTO");
            this.dgvBuscarProductoEliminar.DataSource = productoEspecialObjetoEliminar.dataset.Tables["PRODUCTO"];
            this.dgvBuscarProductoEliminar.Refresh();
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

        private void txtNombreProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\'')
            {
                e.Handled = true;
            }
        }
    }
}
