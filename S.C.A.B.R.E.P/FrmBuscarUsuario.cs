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
    public partial class FrmBuscarUsuario : Form
    {
        public FrmBuscarUsuario()
        {
            InitializeComponent();
        }
        Conexiones obconexionesEliminar = new Conexiones();
        FrmUsuarioIngresar fbiUsuario = new FrmUsuarioIngresar();
        FrmUsuarioActualizar fbaUsuario = new FrmUsuarioActualizar();
        int condicionVerificarIngresoEliminar;

        public int Id = 0;
        public string cedulaUsuario;
        public string nombreUsuario;
        public string apellidoUsuario;
        public string passwordUsuario;
        
        private void txtCedulaCliente_TextChanged(object sender, EventArgs e)
        {
            lblAvisoCedulaUsuario.Visible = true;
            lblAvisoCedulaUsuario.Text = "AVISO: Ingrese solamente HASTA 10 DIGITOS";

        }

        private void txtNombreCliente_TextChanged(object sender, EventArgs e)
        {
            lblAvisoCedulaUsuario.Visible = false;
            lblAvisoCedulaUsuario.Text = " ";
            
        }

        private void txtCedulaCliente_KeyPress(object sender, KeyPressEventArgs e)
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

        private void rBtnCedula_CheckedChanged(object sender, EventArgs e)
        {
            txtCedulaUsuario.Enabled = true;
            txtNombreUsuario.Enabled = false;
            txtNombreUsuario.Text = "";
            condicionVerificarIngresoEliminar = 1;

        }

        private void rBtnNombre_CheckedChanged(object sender, EventArgs e)
        {
            txtNombreUsuario.Enabled = true;
            txtCedulaUsuario.Enabled = false;
            txtCedulaUsuario.Text = "";
            condicionVerificarIngresoEliminar = 3;

        }
        public bool verificarIngeso()
        {
            bool resverificarIngeso = true;
            //verifica si la Cedula esta en blanco
            if (txtCedulaUsuario.Text == "" && condicionVerificarIngresoEliminar == 1)
            {
                MessageBox.Show("Ingrese Cédula del Cliente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                resverificarIngeso = false;
            }
            //verifica si el nombre esta en blanco
            else if (txtNombreUsuario.Text == "" && condicionVerificarIngresoEliminar == 3)
            {
                MessageBox.Show("Ingrese Nombre/Apellido del Cliente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                resverificarIngeso = false;
            }
            //verifica si no se ha elejido ningun radiobutton
            else if (rBtnCedula.Checked == false && rBtnNombre.Checked == false)
            {
                MessageBox.Show("Elija ingresar datos según Cédula ó Nombre ", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                resverificarIngeso = false;
            }
            else
            {
                resverificarIngeso = true;
            }
            return resverificarIngeso;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        public void BuscarEliminar()
        {
            FuncionesComplementarias obFuncionesComplenetariasEliminar = new FuncionesComplementarias(txtCedulaUsuario.Text.Trim(), "", "", "");
            if (verificarIngeso())
            {
                if (obFuncionesComplenetariasEliminar.comprobarCedula())
                {
                        if (condicionVerificarIngresoEliminar == 1)
                        {
                            obconexionesEliminar.consultar("Select * from USUARIO WHERE CEDULA_USUARIO ='" + txtCedulaUsuario.Text.Trim() + "'", "USUARIO");
                            this.dgvUsuario.DataSource = obconexionesEliminar.dataset.Tables["USUARIO"];
                            this.dgvUsuario.Refresh();
                        }
                        if (condicionVerificarIngresoEliminar == 3)
                        {
                            obconexionesEliminar.consultar("Select * from USUARIO WHERE NOMBRE_USUARIO + APELLIDO_USUARIO like '" + txtNombreUsuario.Text.Trim() + "%' or Apellido_USUARIO + NOMBRE_USUARIO like'" + txtNombreUsuario.Text + "%'", "USUARIO");
                            this.dgvUsuario.DataSource = obconexionesEliminar.dataset.Tables["USUARIO"];
                            this.dgvUsuario.Refresh();
                        }

                }
                else
                {
                    MessageBox.Show("La cédula es incorrecta.Debe tener 10 digitos válidos, Por favor verifique", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lblAvisoCedulaUsuario.ForeColor = System.Drawing.Color.Red;
                }
            }
        }

        private void dgvBuscarUsuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Evento para seleccionar el indice de la fila donde se encuentra el cliente a eliminar
            int indiceFiladgv = 0;
            indiceFiladgv = e.RowIndex;
            try
            {
                dgvUsuario.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                Id = Convert.ToInt16(dgvUsuario.Rows[indiceFiladgv].Cells[0].Value);
                cedulaUsuario = dgvUsuario.Rows[indiceFiladgv].Cells[1].Value.ToString();
                nombreUsuario = dgvUsuario.Rows[indiceFiladgv].Cells[2].Value.ToString();
                apellidoUsuario = dgvUsuario.Rows[indiceFiladgv].Cells[3].Value.ToString();
                passwordUsuario = dgvUsuario.Rows[indiceFiladgv].Cells[4].Value.ToString();
                

            }
            catch (ArgumentOutOfRangeException)
            {
                indiceFiladgv = 0;
            }
            btnOK.Enabled = true;

        }

        private void btnBucarusuario_Click(object sender, EventArgs e)
        {
            lblAvisoNuevoIngreso.Visible = false;
            lblAvisoNuevoIngreso.Text = " ";
            BuscarEliminar();
        }

        private void btnBuscarIngresarUsuario_Click(object sender, EventArgs e)
        {
            //fbiCliente.Dispose();
            //fbiCliente.Show();
            fbiUsuario.ShowDialog();
            lblAvisoNuevoIngreso.Visible = true;
            lblAvisoNuevoIngreso.Text = "Busque el nuevo Cliente Ingresado -->";
            BuscarEliminar();
        }

        private void btnBuscarActualizarUsuario_Click(object sender, EventArgs e)
        {
            //fbaCliente.Dispose();
            //fbaCliente.Show();
            fbaUsuario.ShowDialog();
            BuscarEliminar();
        }

        private void btnBuscarTodosUsuario_Click(object sender, EventArgs e)
        {
            obconexionesEliminar.consultar("SELECT * FROM USUARIO", "USUARIO");
            dgvUsuario.DataSource = obconexionesEliminar.dataset.Tables["USUARIO"];
        }
    }
}
