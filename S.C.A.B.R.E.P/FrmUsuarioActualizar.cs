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
    public partial class FrmUsuarioActualizar : Form
    {
        Conexiones UsuarioConexion = new Conexiones();
        int flagSeleccion = 0;
        int flagSeleccion2 = 0;
        int rbtnEleccion;
        int Id;
        int IdActualizarDataGridView;
        int IdActualizarAyudante;
        int flagPassword;
        string cedulaPredeterminado;
        string nombrePredeterminado;
        string apellidoPredeterminado;
        string passwordPredeterminado;

        public FrmUsuarioActualizar()
        {
            InitializeComponent();
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
            if (txtCedulaUsuario.Text == "" && rbtnEleccion == 1)
            {
                MessageBox.Show("Ingrese Cédula del Usuario", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                resVerificarIngeso = false;
            }
            else if (txtNombreUsuario.Text == "" && rbtnEleccion == 2)
            {
                MessageBox.Show("Ingrese Nombre del Usuario", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                resVerificarIngeso = false;
            }
            else if (rbtnCedulaUsuario.Checked==false && rbtnNombreUsuario.Checked == false && flagSeleccion==0)
            {
                MessageBox.Show("Escoja una opcion para iniciar la busqueda", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                resVerificarIngeso = false;
            }
            else
            {
                resVerificarIngeso = true;
            }
            return resVerificarIngeso;
        }

        private void dgvUsuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Evento para seleccionar el indice de la fila donde se encuentra el cliente a eliminar
            int indiceFiladgv = 0;
            indiceFiladgv = e.RowIndex;
            try
            {
                flagSeleccion2 = 1;
                txtCedulaUsuarioAyudante.Text = dgvUsuario.Rows[indiceFiladgv].Cells[1].Value.ToString().Trim();
                txtNombreUsuarioAyudante.Text = dgvUsuario.Rows[indiceFiladgv].Cells[2].Value.ToString().Trim();
                txtApellidoUsuarioAyudante.Text = dgvUsuario.Rows[indiceFiladgv].Cells[3].Value.ToString().Trim();
                txtPasswordUsuarioAyudante.Text = dgvUsuario.Rows[indiceFiladgv].Cells[4].Value.ToString().Trim();

                cedulaPredeterminado = dgvUsuario.Rows[indiceFiladgv].Cells[1].Value.ToString().Trim();
                nombrePredeterminado = dgvUsuario.Rows[indiceFiladgv].Cells[2].Value.ToString().Trim();
                apellidoPredeterminado = dgvUsuario.Rows[indiceFiladgv].Cells[3].Value.ToString().Trim();
                passwordPredeterminado = dgvUsuario.Rows[indiceFiladgv].Cells[4].Value.ToString().Trim();
                
                dgvUsuario.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                IdActualizarDataGridView = Convert.ToInt16(dgvUsuario.Rows[indiceFiladgv].Cells[0].Value);
                IdActualizarAyudante = Convert.ToInt16(dgvUsuario.Rows[indiceFiladgv].Cells[0].Value);
                Id = Convert.ToInt16(dgvUsuario.Rows[indiceFiladgv].Cells[0].Value);
            }
            catch (ArgumentOutOfRangeException)
            {
                indiceFiladgv = 0;
            }


        }

        public bool comprobarSeleccion()
        {
            bool resSeleccion;
            if (flagSeleccion2 != 0)
            {
                resSeleccion = true;
            }
            else {
                resSeleccion = false;
            }
            return resSeleccion;
        }

        private void btnBuscarUsuario_Click(object sender, EventArgs e)
        {
            buscar();
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

        public void buscar()
        {
            FuncionesComplementarias Usuario = new FuncionesComplementarias(txtCedulaUsuario.Text, "", "", "");
            if (verificarIngreso())
            {
                if (Usuario.comprobarCedula())
                {
                    if (rbtnEleccion == 1)
                    {
                        btnPredeterminadoUsuario.Enabled = true;
                        UsuarioConexion.consultar("Select * from USUARIO WHERE CEDULA_USUARIO='" + txtCedulaUsuario.Text + "'", "USUARIO");
                        dgvUsuario.DataSource = UsuarioConexion.dataset.Tables["USUARIO"];
                        if (dgvUsuario.Rows.Count == 0)//'Está vacío
                        {
                            txtCedulaUsuarioAyudante.Text = "";
                            txtNombreUsuarioAyudante.Text = "";
                            txtApellidoUsuarioAyudante.Text = "";
                            txtPasswordUsuarioAyudante.Text = "";
                            rbtnPassword.Enabled = false;
                            rbtnMantenerPassword.Enabled = false;
                            
                        }
                        else 
                        {
                            rbtnPassword.Enabled = true;
                            rbtnMantenerPassword.Enabled = true;
                        }    
                        
                        //MessageBox.Show("Registro Eliminado", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else if (rbtnEleccion == 2)
                    {
                        btnPredeterminadoUsuario.Enabled = true;
                        UsuarioConexion.consultar("Select * from USUARIO WHERE NOMBRE_USUARIO + APELLIDO_USUARIO like '" + txtNombreUsuario.Text + "%' or APELLIDO_USUARIO + NOMBRE_USUARIO  like '" + txtNombreUsuario.Text + "%'", "USUARIO");
                        dgvUsuario.DataSource = UsuarioConexion.dataset.Tables["USUARIO"];
                        if (dgvUsuario.Rows.Count == 0)//'Está vacío
                        {
                            txtCedulaUsuarioAyudante.Text = "";
                            txtNombreUsuarioAyudante.Text = "";
                            txtApellidoUsuarioAyudante.Text = "";
                            txtPasswordUsuarioAyudante.Text = "";
                            rbtnPassword.Enabled = false;
                            rbtnMantenerPassword.Enabled = false;
                            
                        }
                        else 
                        {
                            rbtnPassword.Enabled = true;
                            rbtnMantenerPassword.Enabled = true;
                        } 
                        
                    }
                }
                else
                {
                    MessageBox.Show("Debe ingresar 10 digitos validos para la cedula ,Por favor verifique", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnPredeterminadoUsuario_Click(object sender, EventArgs e)
        {
            txtCedulaUsuarioAyudante.Text = cedulaPredeterminado.Trim();
            txtNombreUsuarioAyudante.Text = nombrePredeterminado.Trim();
            txtApellidoUsuarioAyudante.Text = apellidoPredeterminado.Trim();
            txtPasswordUsuarioAyudante.Text = passwordPredeterminado.Trim();
        }

        private void txtCedulaUsuarioAyudante_TextChanged(object sender, EventArgs e)
        {
            lblAvisoCedulaAyudante.Visible = true;
            lblAvisoCedulaAyudante.Text = "Debe ingresar 10 digitos validos";
            lblAvisoPassword.Visible = false;
            lblAvisoPassword.Text = "";
            lblAvisoREPassword.Visible = false;
            lblAvisoREPassword.Text = "";

        }

        private void txtNombreUsuarioAyudante_TextChanged(object sender, EventArgs e)
        {
            lblAvisoCedulaAyudante.Visible = false;
            lblAvisoCedula.Text = "";
            lblAvisoPassword.Visible = false;
            lblAvisoPassword.Text = "";
            lblAvisoREPassword.Visible = false;
            lblAvisoREPassword.Text = "";
        }

        private void txtApellidoUsuarioAyudante_TextChanged(object sender, EventArgs e)
        {
            lblAvisoCedulaAyudante.Visible = false;
            lblAvisoCedula.Text = "";
            lblAvisoPassword.Visible = false;
            lblAvisoPassword.Text = "";
            lblAvisoREPassword.Visible = false;
            lblAvisoREPassword.Text = "";
        }

        private void txtCedulaUsuarioAyudante_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtNombreUsuarioAyudante_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtApellidoUsuarioAyudante_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnActualizarUsuario_Click(object sender, EventArgs e)
        {
            if (comprobarSeleccion())
            {
                if (verificarIngresoAyudante())
                {
                    if (txtCedulaUsuarioAyudante.Text.Trim() == cedulaPredeterminado.Trim())
                    {
                        string campos = "CEDULA_USUARIO='" + this.txtCedulaUsuarioAyudante.Text.Trim() + "',NOMBRE_USUARIO='" + this.txtNombreUsuarioAyudante.Text.Trim() + "',APELLIDO_USUARIO='" + this.txtApellidoUsuarioAyudante.Text.Trim() + "',PASSWORD_USUARIO='" + this.txtPasswordUsuarioAyudante.Text.Trim() + "'";
                        if (UsuarioConexion.actualizar("USUARIO", campos, "ID_USUARIO='" + Id + "'"))
                        {
                            MessageBox.Show("Registro Actualizado ", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            cedulaPredeterminado = txtCedulaUsuarioAyudante.Text.Trim();
                            nombrePredeterminado = txtNombreUsuarioAyudante.Text.Trim();
                            apellidoPredeterminado = txtApellidoUsuarioAyudante.Text.Trim();
                            passwordPredeterminado = txtPasswordUsuarioAyudante.Text.Trim();
                            actualizarDataGridView();
                        }
                    }
                    else /*if (flagPassword == 1)*/
                    {
                        int resActualizar = UsuarioConexion.verificarCedulaUsuarioActualizar(txtCedulaUsuarioAyudante.Text.Trim(), txtNombreUsuario.Text.Trim(), txtApellidoUsuarioAyudante.Text.Trim(), txtPasswordUsuarioAyudante.Text.Trim(), IdActualizarAyudante);
                        if (resActualizar == 1)
                        {
                            MessageBox.Show("Registro Actualizado ", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            actualizarDataGridView();
                        }
                        else
                        {
                            MessageBox.Show("La cedula ya se encuentra registrada con otro usuario,Por favor verifique ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else 
            {
                MessageBox.Show("Escoja un usuario para actualizar ", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);    
            }
        }

        private void txtPasswordUsuarioAyudante_TextChanged(object sender, EventArgs e)
        {
            lblAvisoCedulaAyudante.Visible = false;
            lblAvisoCedula.Text = "";
            lblAvisoPassword.Visible = true;
            lblAvisoPassword.Text = "El password no debe ser mayor a 5 caractares";
            lblAvisoREPassword.Visible = false;
            lblAvisoREPassword.Text = "";
        }

        private void txtREPasswordUsuarioAyudante_TextChanged(object sender, EventArgs e)
        {
            lblAvisoCedulaAyudante.Visible = false;
            lblAvisoCedula.Text = "";
            lblAvisoPassword.Visible = false;
            lblAvisoPassword.Text = "";
            lblAvisoREPassword.Visible = true;
            lblAvisoREPassword.Text = "Vuelva a ingresar el password";
        }

        public bool verificarIngresoAyudante()
        {
            bool resVerificarIngeso = true;
            if (txtNombreUsuarioAyudante.Text == "")
            {
                MessageBox.Show("Ingrese Nombre del Usuario", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                resVerificarIngeso = false;
            }
            else if (txtApellidoUsuarioAyudante.Text == "")
            {
                MessageBox.Show("Ingrese Apellido del Usuario", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                resVerificarIngeso = false;
            }
            else if (txtCedulaUsuarioAyudante.Text == "")
            {
                MessageBox.Show("Ingrese Cédula del Usuario", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                resVerificarIngeso = false;
            }
            else if (flagPassword == 1)
            { 
                if (txtPasswordUsuarioAyudante.Text == "")
                {
                MessageBox.Show("Ingrese Password del Usuario", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                resVerificarIngeso = false;
                }
                else if (txtREPasswordUsuarioAyudante.Text == "")
                {
                MessageBox.Show("Ingrese REPassword del Usuario", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                resVerificarIngeso = false;
                }
            }
            else
            {
                resVerificarIngeso = true;
            }
            return resVerificarIngeso;
        }
        public bool verificarPassword()
        {
            bool resVerificarPassword = true;
            if (txtPasswordUsuarioAyudante.Text.Length <= 5)
            {
                if (txtREPasswordUsuarioAyudante.Text.Length <= 5)
                {
                    int resParcial = String.Compare(txtPasswordUsuarioAyudante.Text, txtREPasswordUsuarioAyudante.Text);
                    if (resParcial == 0)
                    {
                        resVerificarPassword = true;
                    }
                    else
                    {
                        resVerificarPassword = false;
                    }
                }
                else
                {
                    resVerificarPassword = false;
                }
            }
            else
            {
                resVerificarPassword = false;
            }
            return resVerificarPassword;
        }

        private void btnSalirUsuario_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rbtnPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPasswordUsuarioAyudante.Enabled = true;
            txtREPasswordUsuarioAyudante.Enabled = true;
            txtPasswordUsuarioAyudante.Text = "";
            flagPassword = 1;

        }

        private void rbtnMantenerPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPasswordUsuarioAyudante.Enabled = false;
            txtREPasswordUsuarioAyudante.Enabled = false;
            txtREPasswordUsuarioAyudante.Text = "";
            txtPasswordUsuarioAyudante.Text = passwordPredeterminado;
            flagPassword = 2;

        }
        public void actualizarDataGridView()
        {
            UsuarioConexion.consultar("Select * from USUARIO WHERE ID_USUARIO='" + IdActualizarDataGridView + "'", "USUARIO");
            this.dgvUsuario.DataSource = UsuarioConexion.dataset.Tables["USUARIO"];
            this.dgvUsuario.Refresh();
        }

        private void btnPredeterminadoUsuario_Click_1(object sender, EventArgs e)
        {
            try
            {
                txtCedulaUsuarioAyudante.Text = cedulaPredeterminado.Trim();
                txtNombreUsuarioAyudante.Text = nombrePredeterminado.Trim();
                txtApellidoUsuarioAyudante.Text = apellidoPredeterminado.Trim();
                txtPasswordUsuarioAyudante.Text = passwordPredeterminado.Trim();
            }
            catch {
                MessageBox.Show("No se ha seleccionado ningún usuario para actualizar", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);    
            }
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
