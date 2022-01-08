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
    public partial class FrmBuscarCliente : Form
    {
        public FrmBuscarCliente()
        {
            InitializeComponent();
        }
        Conexiones obconexionesEliminar = new Conexiones();
        FrmClienteIngresar fbiCliente = new FrmClienteIngresar();
        FrmClienteActualizar fbaCliente = new FrmClienteActualizar();
        int condicionVerificarIngresoEliminar;

        public int Id = 0;
        public string cedulaCliente;
        public string rucCliente;
        public string nombreCliente;
        public string apellidoCliente;
        public string telefonoCelularCliente;
        public string telefonoFijoCliente;
        public string mailCliente;
        public string direccionCliente;
        
        

        private void rBtnCedulaEliminar_CheckedChanged(object sender, EventArgs e)
        {
            txtCedulaCliente.Enabled = true;
            txtRucCliente.Enabled = false;
            txtRucCliente.Text = "";
            txtNombreCliente.Enabled = false;
            txtNombreCliente.Text = "";
            condicionVerificarIngresoEliminar = 1;
        }

        private void rBtnRucEliminar_CheckedChanged(object sender, EventArgs e)
        {
            txtCedulaCliente.Enabled = false;
            txtCedulaCliente.Text = "";
            txtRucCliente.Enabled = true;
            txtRucCliente.Text = "";
            txtNombreCliente.Enabled = false;
            txtNombreCliente.Text = "";
            condicionVerificarIngresoEliminar = 2;

        }

        private void rBtnNombreEliminar_CheckedChanged(object sender, EventArgs e)
        {
            txtNombreCliente.Enabled = true;
            txtCedulaCliente.Enabled = false;
            txtCedulaCliente.Text = "";
            txtRucCliente.Enabled = false;
            txtRucCliente.Text = "";
            condicionVerificarIngresoEliminar = 3;
        }

        private void txtCedulaClienteEliminar_TextChanged(object sender, EventArgs e)
        {
            lblAvisoCedulaCliente.Visible = true;
            lblAvisoCedulaCliente.Text = "AVISO: Ingrese solamente HASTA 10 DIGITOS";
            lblAvisoRucCliente.Visible = false;
            lblAvisoRucCliente.Text = "";
        }

        private void txtRucClienteEliminar_TextChanged(object sender, EventArgs e)
        {
            lblAvisoCedulaCliente.Visible = false;
            lblAvisoCedulaCliente.Text = "";
            lblAvisoRucCliente.Visible = true;
            lblAvisoRucCliente.Text = "AVISO: Ingrese solamente HASTA 13 DIGITOS";
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

        public bool verificarIngeso()
        {
            bool resverificarIngeso = true;
            //verifica si la Cedula esta en blanco
            if (txtCedulaCliente.Text == "" && condicionVerificarIngresoEliminar == 1)
            {
                MessageBox.Show("Ingrese Cédula del Cliente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                resverificarIngeso = false;
            }
            //verifica si el RUC esta en blanco
            else if (txtRucCliente.Text == "" && condicionVerificarIngresoEliminar == 2)
            {
                MessageBox.Show("Ingrese Ruc del Cliente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                resverificarIngeso = false;
            }
            //verifica si el nombre esta en blanco
            else if (txtNombreCliente.Text == "" && condicionVerificarIngresoEliminar == 3)
            {
                MessageBox.Show("Ingrese Nombre/Apellido del Cliente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                resverificarIngeso = false;
            }
            //verifica si no se ha elejido ningun radiobutton
            else if (rBtnCedula.Checked == false && rBtnRuc.Checked == false && rBtnNombre.Checked == false)
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

        private void btnCancelarEliminarCliente_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void BuscarEliminar()
        {
            FuncionesComplementarias obFuncionesComplenetariasEliminar = new FuncionesComplementarias(txtCedulaCliente.Text.Trim(), "", txtRucCliente.Text.Trim(), "");
            if (verificarIngeso())
            {
                if (obFuncionesComplenetariasEliminar.comprobarCedula())
                {
                    if (obFuncionesComplenetariasEliminar.comprobarRuc())
                    {
                        if (condicionVerificarIngresoEliminar == 1)
                        {
                            obconexionesEliminar.consultar("Select * from CLIENTE WHERE CEDULA_CLIENTE ='" + txtCedulaCliente.Text.Trim() + "'", "CLIENTE");
                            this.dgvBuscarCliente.DataSource = obconexionesEliminar.dataset.Tables["CLIENTE"];
                            this.dgvBuscarCliente.Refresh();
                        }
                        if (condicionVerificarIngresoEliminar == 2)
                        {
                            obconexionesEliminar.consultar("Select * from CLIENTE WHERE RUC_CLIENTE='" + txtRucCliente.Text.Trim() + "'", "CLIENTE");
                            this.dgvBuscarCliente.DataSource = obconexionesEliminar.dataset.Tables["CLIENTE"];
                            this.dgvBuscarCliente.Refresh();
                        }
                        if (condicionVerificarIngresoEliminar == 3)
                        {
                            obconexionesEliminar.consultar("Select * from CLIENTE WHERE RTRIM(NOMBRE_CLIENTE) +'" + " '" + "+RTRIM(APELLIDO_CLIENTE) like '%" + txtNombreCliente.Text.Trim() + "%'", "CLIENTE"); 
                            this.dgvBuscarCliente.DataSource = obconexionesEliminar.dataset.Tables["CLIENTE"];
                            this.dgvBuscarCliente.Refresh();
                        }
                    }
                    else
                    {
                        MessageBox.Show("El número de RUC debe ser de 13 digitos válidos, Por favor verifique", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        lblAvisoRucCliente.ForeColor = System.Drawing.Color.Red;
                    }
                }
                else
                {
                    MessageBox.Show("La cédula es incorrecta.Debe tener 10 digitos válidos, Por favor verifique", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lblAvisoCedulaCliente.ForeColor = System.Drawing.Color.Red;
                }
            }
        }

        private void dgvBuscarClienteEliminar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Evento para seleccionar el indice de la fila donde se encuentra el cliente a eliminar
            int indiceFiladgv = 0;
            indiceFiladgv = e.RowIndex;
            try
            {
                dgvBuscarCliente.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                Id = Convert.ToInt16(dgvBuscarCliente.Rows[indiceFiladgv].Cells[0].Value);
                cedulaCliente = dgvBuscarCliente.Rows[indiceFiladgv].Cells[1].Value.ToString();
                rucCliente = dgvBuscarCliente.Rows[indiceFiladgv].Cells[2].Value.ToString();
                nombreCliente = dgvBuscarCliente.Rows[indiceFiladgv].Cells[3].Value.ToString();
                apellidoCliente =dgvBuscarCliente.Rows[indiceFiladgv].Cells[4].Value.ToString();
                telefonoCelularCliente = dgvBuscarCliente.Rows[indiceFiladgv].Cells[5].Value.ToString();
                telefonoFijoCliente = dgvBuscarCliente.Rows[indiceFiladgv].Cells[6].Value.ToString();
                direccionCliente =dgvBuscarCliente.Rows[indiceFiladgv].Cells[7].Value.ToString();
                mailCliente = dgvBuscarCliente.Rows[indiceFiladgv].Cells[8].Value.ToString();
                
            }
            catch (ArgumentOutOfRangeException)
            {
                indiceFiladgv = 0;
            }
            btnOK.Enabled = true;
        }

        private void btnBucarCliente_Click(object sender, EventArgs e)
        {
            lblAvisoNuevoIngreso.Visible = false;
            lblAvisoNuevoIngreso.Text = " ";
            BuscarEliminar();
        }
        private void btnBuscarIngresarCliente_Click_1(object sender, EventArgs e)
        {
            //fbiCliente.Dispose();
            //fbiCliente.Show();
            fbiCliente.ShowDialog();
            lblAvisoNuevoIngreso.Visible = true;
            lblAvisoNuevoIngreso.Text = "Busque el nuevo Cliente Ingresado -->";
            BuscarEliminar();
        }
        
        private void btnBuscarActualizarCliente_Click(object sender, EventArgs e)
        {
            //fbaCliente.Dispose();
            //fbaCliente.Show();
            fbaCliente.ShowDialog();
            BuscarEliminar();
            
        }

        private void txtNombreCliente_TextChanged(object sender, EventArgs e)
        {
            lblAvisoRucCliente.Text = "";
            lblAvisoCedulaCliente.Text = "";
        }

        private void btnBuscarTodosCliente_Click(object sender, EventArgs e)
        {
            obconexionesEliminar.consultar("SELECT * FROM CLIENTE", "CLIENTE");
            dgvBuscarCliente.DataSource = obconexionesEliminar.dataset.Tables["CLIENTE"];
        }

    }
}
