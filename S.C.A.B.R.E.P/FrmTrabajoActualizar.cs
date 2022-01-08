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
    public partial class FrmTrabajoActualizar : Form
    {
        int flagSeleccion = 0;
        int flagSeleccion2 = 0; 
        int radioButtonOpcion;
        int Id;
        Conexiones trabajoObjetoEliminar = new Conexiones();
        string codigo;
        string nombre;
        double precio;
        int IdActualizarDataGridView;
        int IdActualizarAyudante;
        public FrmTrabajoActualizar()
        {
            InitializeComponent();
        }
        private void btnSalirTrabajo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void rBtnCodigoEliminarTrabajo_CheckedChanged(object sender, EventArgs e)
        {
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
        private void dgvBuscarTrabajoEliminar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Evento para seleccionar el indice de la fila donde se encuentra el producto a actualizar
            int indiceFiladgv = 0;
            indiceFiladgv = e.RowIndex;
            try
            {
                flagSeleccion2 = 1;
                codigo = dgvBuscarTrabajoEliminar.Rows[indiceFiladgv].Cells[1].Value.ToString().Trim();
                nombre = dgvBuscarTrabajoEliminar.Rows[indiceFiladgv].Cells[2].Value.ToString().Trim();
                precio = Math.Round(Convert.ToDouble(dgvBuscarTrabajoEliminar.Rows[indiceFiladgv].Cells[3].Value.ToString()), 2);

                txtCodigoTrabajo.Text = dgvBuscarTrabajoEliminar.Rows[indiceFiladgv].Cells[1].Value.ToString().Trim();
                txtNombreTrabajo.Text = dgvBuscarTrabajoEliminar.Rows[indiceFiladgv].Cells[2].Value.ToString().Trim();
                txtCostoTrabajo.Text = Math.Round(Convert.ToDouble(dgvBuscarTrabajoEliminar.Rows[indiceFiladgv].Cells[3].Value), 2).ToString().Trim();
                IdActualizarDataGridView = Convert.ToInt16(dgvBuscarTrabajoEliminar.Rows[indiceFiladgv].Cells[0].Value);
                IdActualizarAyudante = Convert.ToInt16(dgvBuscarTrabajoEliminar.Rows[indiceFiladgv].Cells[0].Value);
                Id = Convert.ToInt16(dgvBuscarTrabajoEliminar.Rows[indiceFiladgv].Cells[0].Value);

                dgvBuscarTrabajoEliminar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                Id = Convert.ToInt16(dgvBuscarTrabajoEliminar.Rows[indiceFiladgv].Cells[0].Value);
            }
            catch (ArgumentOutOfRangeException)
            {
                indiceFiladgv = 0;
            }
        }
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
            else if (rBtnCodigoEliminarTrabajo.Checked == false && rBtnNombreEliminarTrabajo.Checked == false)
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
        //REESTABLECE LOS BALORES PREESTABLECIDOS ANTES DE ACTUALIZAR EL REGISTRO
        private void btnActualizatPredeterminadoTrabajo_Click(object sender, EventArgs e)
        {
            try
            {

                txtCodigoTrabajo.Text = codigo.Trim();
                txtNombreTrabajo.Text = nombre.Trim();
                txtCostoTrabajo.Text = precio.ToString().Trim();
            }
            catch {
                MessageBox.Show("No se ha seleccionado ningun trabajo para actualizar", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);   
            }
        }
        //VERIFICA EL INGRESO DE DATOS
        bool verificarIngreso2()
        {
            bool res;
            if (flagSeleccion == 0 || flagSeleccion2 == 0)
            {
                MessageBox.Show("Escoja un producto para actualizar", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                res = false;
            }
            /*if (txtCodigoTrabajo.Text == "")
            {
                MessageBox.Show("Ingrese el codigo del producto", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                res = false;
            }
            else if (txtNombreTrabajo.Text == "")
            {
                MessageBox.Show("Ingrese el nombre del producto", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                res = false;
            }
            else if (txtCostoTrabajo.Text == "")
            {
                MessageBox.Show("Ingrese el costo del producto", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                res = false;
            }*/
            else
            {
                res = true;
            }
            return res;

        }
        //VERIFICA EL INGRESO DE CAMPO COSTO SEGUN SQL SERVER(.)
        private void txtCostoTrabajo_KeyPress(object sender, KeyPressEventArgs e)
        {
            lblAvisoCostoTrabajo.Visible = true;
            lblAvisoCostoTrabajo.Text = "Ingrese el costo del producto con el formato (.) para decimales";
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
        private void txtCodigoTrabajo_TextChanged(object sender, EventArgs e)
        {
            lblAvisoCostoTrabajo.Visible = false;
            lblAvisoCostoTrabajo.Text = "";
        }

        private void txtNombreTrabajo_TextChanged(object sender, EventArgs e)
        {
            lblAvisoCostoTrabajo.Visible = false;
            lblAvisoCostoTrabajo.Text = "";
        }

        private void txtDescripcionTrabajo_TextChanged(object sender, EventArgs e)
        {
            lblAvisoCostoTrabajo.Visible = false;
            lblAvisoCostoTrabajo.Text = "";
        }
        //REALIZA UNA CONSULTA AL MOMENTO DE ACTUALIZAR PARA REFRESCAR EL DATA GRIDVIEW SEGUN EL ID DEL TRABAJO EN LA TABLA PRODUCTO
        public void actualizarDataGridView()
        {
            trabajoObjetoEliminar.consultar("Select * from PRODUCTO WHERE ID_PRODUCTO='" + IdActualizarDataGridView + "'", "PRODUCTO");
            this.dgvBuscarTrabajoEliminar.DataSource = trabajoObjetoEliminar.dataset.Tables["PRODUCTO"];
            this.dgvBuscarTrabajoEliminar.Refresh();
        }
        //BUSCA EL TRABAJO EN LA TABLA PRODUCTO 
        public void buscar()
        {
            if (verificarIngreso())
            {
                if (radioButtonOpcion == 1)
                {
                    trabajoObjetoEliminar.consultar("Select * from PRODUCTO WHERE CODIGO_PRODUCTO like'%TELECCOMPU-" + txtCodigoTrabajoEliminar.Text.Trim() + "%'", "PRODUCTO");
                    dgvBuscarTrabajoEliminar.DataSource = trabajoObjetoEliminar.dataset.Tables["PRODUCTO"];
                }
                else if (radioButtonOpcion == 2)
                {
                    trabajoObjetoEliminar.consultar("Select * from PRODUCTO WHERE CODIGO_PRODUCTO like '%TELECCOMPU'% AND NOMBRE_PRODUCTO like'%" + txtNombreTrabajoEliminar.Text.Trim() + "%'", "PRODUCTO");
                    dgvBuscarTrabajoEliminar.DataSource = trabajoObjetoEliminar.dataset.Tables["PRODUCTO"];
                }
            }

        }
        //ACTUALIZA EL PRODUCTO SELECCIONADO
        private void btnActualizarTrabajo_Click(object sender, EventArgs e)
        {
            if (verificarIngreso2())
            {
                if (codigo.Trim() == txtCodigoTrabajo.Text.Trim())
                {
                    string campos = "CODIGO_PRODUCTO='" + this.txtCodigoTrabajo.Text.Trim() + "',NOMBRE_PRODUCTO='" + this.txtNombreTrabajo.Text.Trim() + "',PRECIO_PRODUCTO='" + this.txtCostoTrabajo.Text.Trim() + "'";
                    if (trabajoObjetoEliminar.actualizar("PRODUCTO", campos, "ID_PRODUCTO='" + Id + "'"))
                    {
                        MessageBox.Show("Registro Actualizado ", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        codigo = txtCodigoTrabajo.Text.Trim();
                        nombre = txtNombreTrabajo.Text.Trim();
                        precio = Math.Round(Convert.ToDouble(txtCostoTrabajo.Text.Trim()), 2);
                        actualizarDataGridView();
                    }
                    else
                    {
                        MessageBox.Show("Por favor Elija un trabajo para actualizar ", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    int resActualizar = trabajoObjetoEliminar.verificarCodigoTrabajoActualizar(txtCodigoTrabajo.Text.Trim(), txtNombreTrabajo.Text.Trim(),Math.Round(Convert.ToDouble(txtCostoTrabajo.Text.Trim())), IdActualizarAyudante);
                    if (resActualizar == 1)
                    {
                        MessageBox.Show("Registro Actualizado ", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        actualizarDataGridView();
                    }
                    else
                    {
                        MessageBox.Show("El Codigo del Trabajo ya se encuentra registrado,Por favor verifique ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
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

        private void txtNombreTrabajo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\'')
            {
                e.Handled = true;
            }
        }
   }
}
