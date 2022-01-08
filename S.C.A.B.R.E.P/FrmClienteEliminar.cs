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
    public partial class FrmClienteEliminar : Form
    {
        public FrmClienteEliminar()
        {
            InitializeComponent();
        }
        int condicionVerificarIngresoEliminar;
        Conexiones obconexionesEliminar = new Conexiones();
        int Id = 0;
        int flagSeleccion=0;
     
        private void btnBucarEliminarCliente_Click(object sender, EventArgs e)
        {
            BuscarEliminar();  

        }
        private void rBtnCedulaEliminar_CheckedChanged_1(object sender, EventArgs e)
        {
            txtCedulaClienteEliminar.Enabled = true;
            txtRucClienteEliminar.Enabled = false;
            txtRucClienteEliminar.Text = "";
            txtNombreClienteEliminar.Enabled = false;
            txtNombreClienteEliminar.Text = "";
            condicionVerificarIngresoEliminar = 1;

        }
        private void rBtnRucEliminar_CheckedChanged(object sender, EventArgs e)
        {
            txtCedulaClienteEliminar.Enabled = false;
            txtCedulaClienteEliminar.Text = "";
            txtRucClienteEliminar.Enabled = true;
            txtRucClienteEliminar.Text = "";
            txtNombreClienteEliminar.Enabled = false;
            txtNombreClienteEliminar.Text = "";
            condicionVerificarIngresoEliminar = 2;
        }
        private void txtCedulaClienteEliminar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
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
        private void txtRucClienteEliminar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
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
        private void txtCedulaClienteEliminar_TextChanged(object sender, EventArgs e)
        {
            lblAvisoCedulaClienteEliminar.Visible = true;
            lblAvisoCedulaClienteEliminar.Text = "AVISO: Ingrese solamente HASTA 10 DIGITOS";
            lblAvisoRucClienteEliminar.Visible = false;
            lblAvisoRucClienteEliminar.Text = "";
        }
        private void txtRucClienteEliminar_TextChanged(object sender, EventArgs e)
        {
            lblAvisoCedulaClienteEliminar.Visible = false;
            lblAvisoCedulaClienteEliminar.Text = "";
            lblAvisoRucClienteEliminar.Visible = true;
            lblAvisoRucClienteEliminar.Text = "AVISO: Ingrese solamente HASTA 13 DIGITOS";

        }

        public bool verificarIngeso()
        {
            bool resverificarIngeso = true;
            //verifica si la Cedula esta en blanco
            if (txtCedulaClienteEliminar.Text == "" && condicionVerificarIngresoEliminar == 1)
            {
                MessageBox.Show("Ingrese Cédula del Cliente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                resverificarIngeso = false;
            }
            //verifica si el RUC esta en blanco
            else if (txtRucClienteEliminar.Text == "" && condicionVerificarIngresoEliminar == 2)
            {
                MessageBox.Show("Ingrese Ruc del Cliente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                resverificarIngeso = false;
            }
            //verifica si el nombre esta en blanco
            else if (txtNombreClienteEliminar.Text == "" && condicionVerificarIngresoEliminar == 3)
            {
                MessageBox.Show("Ingrese Nombre/Apellido del Cliente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                resverificarIngeso = false;
            }
            //verifica si no se ha elejido ningun radiobutton
            else if (rBtnCedulaEliminar.Checked == false && rBtnRucEliminar.Checked == false && rBtnNombreEliminar.Checked == false && flagSeleccion==0)
            {
                MessageBox.Show("Elija ingresar datos según Cédula ,  RUC ó Nombre ", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                resverificarIngeso = false;
            }
            else
            {
                resverificarIngeso = true;
            }
            return resverificarIngeso;
        }

        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            //control para un evento del boton eliminar inicial sin datos
            if (txtCedulaClienteEliminar.Text != "" || txtRucClienteEliminar.Text != "" || txtNombreClienteEliminar.Text != ""|| flagSeleccion!=0)
            {
                if (obconexionesEliminar.eliminar("CLIENTE", "ID_CLIENTE='" + Id + "'"))
                {
                    MessageBox.Show("Cliente Elminado", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    BuscarEliminar();
                    this.dgvBuscarClienteEliminar.Refresh();
                    obconexionesEliminar.consultar("select * from CLIENTE where ID_CLIENTE ='" + Id + "'", "CLIENTE");
                    dgvBuscarClienteEliminar.DataSource = obconexionesEliminar.dataset.Tables["CLIENTE"];
                }
                else
                {
                    MessageBox.Show("Error al eliminar,Por favor Elija un Cliente a Eliminar", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                this.dgvBuscarClienteEliminar.Refresh();
            }
            else
            {
                MessageBox.Show("Por favor Busque un Cliente a Eliminar", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);       
            }
        }

        private void btnCancelarEliminarCliente_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rBtnNombreEliminar_CheckedChanged(object sender, EventArgs e)
        {
            txtNombreClienteEliminar.Enabled = true;
            txtCedulaClienteEliminar.Enabled = false;
            txtCedulaClienteEliminar.Text = "";
            txtRucClienteEliminar.Enabled = false;
            txtRucClienteEliminar.Text = "";
            condicionVerificarIngresoEliminar = 3;
        }

        private void dgvBuscarClienteEliminar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Evento para seleccionar el indice de la fila donde se encuentra el cliente a eliminar
            int indiceFiladgv = 0;
            indiceFiladgv = e.RowIndex;
            try
            {
                dgvBuscarClienteEliminar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                Id = Convert.ToInt16(dgvBuscarClienteEliminar.Rows[indiceFiladgv].Cells[0].Value);
            }
            catch (ArgumentOutOfRangeException)
            {
                indiceFiladgv = 0;
            }
        }

        public void BuscarEliminar()
        {
            FuncionesComplementarias obFuncionesComplenetariasEliminar = new FuncionesComplementarias(txtCedulaClienteEliminar.Text.Trim(), "", txtRucClienteEliminar.Text.Trim(), "");
            if (verificarIngeso())
            {
                if (obFuncionesComplenetariasEliminar.comprobarCedula())
                {
                    if (obFuncionesComplenetariasEliminar.comprobarRuc())
                    {
                        if (condicionVerificarIngresoEliminar == 1)
                        {
                            obconexionesEliminar.consultar("Select * from CLIENTE WHERE CEDULA_CLIENTE ='" + txtCedulaClienteEliminar.Text.Trim() + "'", "CLIENTE");
                            this.dgvBuscarClienteEliminar.DataSource = obconexionesEliminar.dataset.Tables["CLIENTE"];
                            this.dgvBuscarClienteEliminar.Refresh();
                        }
                        if (condicionVerificarIngresoEliminar == 2)
                        {
                            obconexionesEliminar.consultar("Select * from CLIENTE WHERE RUC_CLIENTE='" + txtRucClienteEliminar.Text.Trim() + "'", "CLIENTE");
                            this.dgvBuscarClienteEliminar.DataSource = obconexionesEliminar.dataset.Tables["CLIENTE"];
                            this.dgvBuscarClienteEliminar.Refresh();
                        }
                        if (condicionVerificarIngresoEliminar == 3)
                        {
                            obconexionesEliminar.consultar("Select * from CLIENTE WHERE NOMBRE_CLIENTE + APELLIDO_CLIENTE like '" + txtNombreClienteEliminar.Text.Trim() + "%' or Apellido_CLIENTE + NOMBRE_CLIENTE like'" + txtNombreClienteEliminar.Text.Trim() + "%'", "CLIENTE");
                            this.dgvBuscarClienteEliminar.DataSource = obconexionesEliminar.dataset.Tables["CLIENTE"];
                            this.dgvBuscarClienteEliminar.Refresh();
                        }
                    }
                    else
                    {
                        MessageBox.Show("El número de RUC debe ser de 13 digitos válidos, Por favor verifique", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        lblAvisoRucClienteEliminar.ForeColor = System.Drawing.Color.Red;
                    }
                }
                else
                {
                    MessageBox.Show("La cédula es incorrecta.Debe tener 10 digitos válidos, Por favor verifique", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lblAvisoCedulaClienteEliminar.ForeColor = System.Drawing.Color.Red;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            flagSeleccion = 1;
            obconexionesEliminar.consultar("SELECT * FROM CLIENTE", "CLIENTE");
            dgvBuscarClienteEliminar.DataSource = obconexionesEliminar.dataset.Tables["CLIENTE"];
            
        }

        private void txtNombreClienteEliminar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\'')
            {
                e.Handled = true;
            }

        }
    }
}
