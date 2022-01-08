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
    public partial class FrmUsuarioIngresar : Form
    {
        public FrmUsuarioIngresar()
        {
            InitializeComponent();
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
            else if (e.KeyChar == ' ')
            {
                e.Handled = false;
            }
            else if (e.KeyChar == '.')
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
            else if (e.KeyChar == ' ')
            {
                e.Handled = false;
            }
            else if (e.KeyChar == '.')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtApellidoUsuario_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtCedulaUsuario_TextChanged(object sender, EventArgs e)
        {
            lblAvisoCedula.Visible = true;
            lblAvisoCedula.Text = "Ingresar 10 digitos validos";
            lblAvisoPassword.Text = "";
            lblAvisoPassword.Visible = false;
            lblAvisoREPassword.Text = "";
            lblAvisoREPassword.Visible = false;
        }

        private void txtNombreUsuario_TextChanged(object sender, EventArgs e)
        {
            lblAvisoPassword.Text = "";
            lblAvisoPassword.Visible = false;
            lblAvisoREPassword.Text = "";
            lblAvisoREPassword.Visible = false;
            lblAvisoCedula.Visible = false;
            lblAvisoCedula.Text = "";
        }

        private void txtApellidoUsuario_TextChanged(object sender, EventArgs e)
        {
            lblAvisoPassword.Text = "";
            lblAvisoPassword.Visible = false;
            lblAvisoREPassword.Text = "";
            lblAvisoREPassword.Visible = false;
            lblAvisoCedula.Visible = false;
            lblAvisoCedula.Text = "";
        }

        private void txtPasswordUsuario_TextChanged(object sender, EventArgs e)
        {
            lblAvisoPassword.Visible = true;
            lblAvisoPassword.Text = "El password no debe ser mayor a 5 caracteres";
            lblAvisoREPassword.Visible = false;
            lblAvisoREPassword.Text = "";
            lblAvisoCedula.Visible = false;
            lblAvisoCedula.Text = "";
        }

        private void txtREPasswordUsuario_TextChanged(object sender, EventArgs e)
        {
            lblAvisoPassword.Visible = false;
            lblAvisoPassword.Text = "";
            lblAvisoREPassword.Visible = true;
            lblAvisoREPassword.Text = "Volver a escribir el password";
            lblAvisoCedula.Visible = false;
            lblAvisoCedula.Text = "";
        }
        public bool verificarIngreso() 
        {
            bool resVerificarIngeso = true;
            if (txtNombreUsuario.Text == "")
            {
                MessageBox.Show("Ingrese Nombre del Usuario", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                resVerificarIngeso = false;
            }
            else if (txtApellidoUsuario.Text == "")
            {
                MessageBox.Show("Ingrese Apellido del Usuario", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                resVerificarIngeso = false;
            }
            else if (txtCedulaUsuario.Text == "" )
            {
                MessageBox.Show("Ingrese Cédula del Usuario", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                resVerificarIngeso = false;
            }
            else if (txtPasswordUsuario.Text == "")
            {
                MessageBox.Show("Ingrese Password del Usuario", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                resVerificarIngeso = false;
            }
            else if (txtREPasswordUsuario.Text == "")
            {
                MessageBox.Show("Ingrese REPassword del Usuario", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                resVerificarIngeso = false;
            }
            else
            {
                resVerificarIngeso = true;
            }
            return resVerificarIngeso;
        }
        public bool verificarPassword() 
        {
            bool resVerificarPassword=true;
            if (txtPasswordUsuario.Text.Length <= 5) 
            {
                if (txtREPasswordUsuario.Text.Length <= 5)
                {
                    int resParcial = String.Compare(txtPasswordUsuario.Text, txtREPasswordUsuario.Text);
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

        private void btnIngresarUsuario_Click(object sender, EventArgs e)
        {
            FuncionesComplementarias Usuario = new FuncionesComplementarias(txtCedulaUsuario.Text, "", "", "");
            Conexiones UsuarioConexion = new Conexiones();
            if (verificarIngreso()) 
            {
                if (Usuario.comprobarCedula())
                {
                    if (verificarPassword())
                    {
                        int resSt = UsuarioConexion.verificarCedulaUsuario(txtCedulaUsuario.Text, txtNombreUsuario.Text, txtApellidoUsuario.Text, txtPasswordUsuario.Text);
                        if(resSt==1)
                        {
                            txtCedulaUsuario.Text = "";
                            txtNombreUsuario.Text = "";
                            txtApellidoUsuario.Text = "";
                            txtPasswordUsuario.Text = "";
                            txtREPasswordUsuario.Text = "";
                            MessageBox.Show("Usuario Registrado", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                        {
                            MessageBox.Show("El usuario ya esta registrado ó esta ingresando un numero de cedula ya registrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                        }
                        
                    }
                    else 
                    {
                        MessageBox.Show("Mal Ingreso de Password,Por favor verifique", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Debe ingresar 10 digitos validos para la cedula ,Por favor verifique", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSalirUsuario_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPasswordUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\'')
            {
                e.Handled = true;
            }
        }

        private void txtREPasswordUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\'')
            {
                e.Handled = true;
            }
        }
    }
}
