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
    public partial class FrmUsuarioEliminar : Form
    {
        Conexiones UsuarioConexion = new Conexiones();
        int flagSeleccion = 0;
        int rbtnEleccion;
        int Id;
        public FrmUsuarioEliminar()
        {
            InitializeComponent();
        }

        private void txtCedulaUsuario_TextChanged(object sender, EventArgs e)
        {
            lblAvisoCedula.Visible = true;
            lblAvisoCedula.Text = "Ingresar 10 digitos validos";

        }

        private void txtNombreUsuario_TextChanged(object sender, EventArgs e)
        {
            lblAvisoCedula.Visible = false;
            lblAvisoCedula.Text = "";

        }

        private void txtCedulaUsuario_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtNombreUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
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
        public bool verificarIngreso()
        {
            bool resVerificarIngeso = true;
            if (txtCedulaUsuario.Text == ""&& rbtnEleccion==1)
            {
                MessageBox.Show("Ingrese Cédula del Usuario", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                resVerificarIngeso = false;
            }
            else if (txtNombreUsuario.Text == "" && rbtnEleccion==2 && flagSeleccion==0)
            {
                MessageBox.Show("Ingrese Nombre del Usuario", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                resVerificarIngeso = false;
            }
            else
            {
                resVerificarIngeso = true;
            }
            return resVerificarIngeso;
        }

        private void btnBuscarUsuario_Click(object sender, EventArgs e)
        {
            buscar();    
        }

        private void rbtnCedulaUsuario_CheckedChanged(object sender, EventArgs e)
        {
            txtCedulaUsuario.Enabled = true;
            txtNombreUsuario.Enabled = false;
            txtNombreUsuario.Text = "";
            rbtnEleccion = 1;
        }

        private void rbtnNombreUsuario_CheckedChanged(object sender, EventArgs e)
        {
            txtCedulaUsuario.Enabled = false;
            txtNombreUsuario.Enabled = true;
            txtCedulaUsuario.Text = "";
            rbtnEleccion = 2;
        }

        private void dgvUsuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Evento para seleccionar el indice de la fila donde se encuentra el cliente a eliminar
            int indiceFiladgv = 0;
            indiceFiladgv = e.RowIndex;
            try
            {
                dgvUsuario.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                Id = Convert.ToInt16(dgvUsuario.Rows[indiceFiladgv].Cells[0].Value);
            }
            catch (ArgumentOutOfRangeException)
            {
                indiceFiladgv = 0;
            }
        }
        public void buscar() 
        {
            FuncionesComplementarias Usuario = new FuncionesComplementarias(txtCedulaUsuario.Text, "", "", "");
            if (verificarIngreso())
            {
                if (Usuario.comprobarCedula())
                {
                    if (rbtnEleccion == 1)
                    {
                        UsuarioConexion.consultar("Select * from USUARIO WHERE CEDULA_USUARIO='" + txtCedulaUsuario.Text + "'", "USUARIO");
                        dgvUsuario.DataSource = UsuarioConexion.dataset.Tables["USUARIO"];
                        //MessageBox.Show("Registro Eliminado", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else if (rbtnEleccion == 2)
                    {
                        UsuarioConexion.consultar("Select * from USUARIO WHERE NOMBRE_USUARIO + APELLIDO_USUARIO like '" + txtNombreUsuario.Text + "%' or APELLIDO_USUARIO + NOMBRE_USUARIO  like '" + txtNombreUsuario.Text + "%'", "USUARIO");
                        dgvUsuario.DataSource = UsuarioConexion.dataset.Tables["USUARIO"];
                    }
                }
                else
                {
                    MessageBox.Show("Debe ingresar 10 digitos validos para la cedula ,Por favor verifique", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }   
        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            //control para un evento del boton eliminar inicial sin datos
            if (txtCedulaUsuario.Text != "" || txtNombreUsuario.Text != "" || flagSeleccion!=0)
            {
                if (UsuarioConexion.eliminar("USUARIO", "ID_USUARIO='" + Id + "'"))
                {
                    MessageBox.Show("Usuario Elminado", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    buscar();
                    this.dgvUsuario.Refresh();
                    buscarTodos();
                }
                else
                {
                    MessageBox.Show("Error al eliminar,Por favor elija un Usuario a eliminar", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                this.dgvUsuario.Refresh();
            }
            else
            {
                MessageBox.Show("Por favor busque un Usuario a eliminar", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnSalirUsuario_Click(object sender, EventArgs e)
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
            UsuarioConexion.consultar("SELECT * FROM USUARIO", "USUARIO");
            dgvUsuario.DataSource = UsuarioConexion.dataset.Tables["USUARIO"];
        }
    }
}
