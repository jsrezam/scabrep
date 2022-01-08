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
    public partial class FrmClienteIngresar : Form
    {
        public FrmClienteIngresar()
        {
            InitializeComponent();
        }
        Conexiones obconexionesIngresar = new Conexiones();
        int condicionVerificarIngreso;

        private void btnIngresarCliente_Click(object sender, EventArgs e)
        {
            FuncionesComplementarias obFuncionesComplenetariasIngresar = new FuncionesComplementarias(txtCedulaCliente.Text.Trim (),txtTelefonoCelularCliente.Text.Trim(),txtRucCliente.Text.Trim(),txtMailCliente.Text);
            if (verificarIngeso())
            {
                if (obFuncionesComplenetariasIngresar.comprobarCedula())
                {
                    if (obFuncionesComplenetariasIngresar.comprobarRuc())
                    {
                        if (obFuncionesComplenetariasIngresar.comprobarTelefonoCelular())
                        {
                            if (obFuncionesComplenetariasIngresar.comprobarMail())
                            {
                                int resVerificarRepeticionCedula = obconexionesIngresar.verificarCedulaRepeticion(txtCedulaCliente.Text.Trim(), txtRucCliente.Text.Trim(), txtNombreCliente.Text.Trim(), txtApellidoCliente.Text.Trim(), txtTelefonoCelularCliente.Text.Trim(), txtTelefonoFijoCliente.Text.Trim(), txtDireccionCliente.Text.Trim(), txtMailCliente.Text.Trim());
                                if(resVerificarRepeticionCedula== 1 )
                                {

                                        MessageBox.Show("Registro Insertado");
                                        this.txtApellidoCliente.Clear();
                                        this.txtNombreCliente.Clear();
                                        this.txtTelefonoCelularCliente.Clear();
                                        this.txtTelefonoFijoCliente.Clear();
                                        this.txtDireccionCliente.Clear();
                                        this.txtCedulaCliente.Clear();
                                        this.txtNombreCliente.Focus();
                                        this.txtRucCliente.Clear();
                                        this.txtMailCliente.Clear();
                                }
                                else
                                {
                                    MessageBox.Show("El cliente ya esta registrado ó esta ingresando un numero de cedula/RUC ya registrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                                }
                            }
                            else
                            {
                                MessageBox.Show("El E-Mail ingresado no cumple con en formato (texto@domino), Por favor verifique", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                lblAvisoTelefonoCelularCliente.ForeColor = System.Drawing.Color.Red;      
                            }
                        }
                        else
                        {
                            MessageBox.Show("El número telefónico no debe ser MAYOR a 10 digitos, Por favor verifique", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            lblAvisoTelefonoCelularCliente.ForeColor = System.Drawing.Color.Red;
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
                //Application.Restart();
                txtNombreCliente.Focus();
        }

        private void txtNombreCliente_TextChanged(object sender, EventArgs e)
        {
            lblAvisoCedulaCliente.Visible = false;
            lblAvisoCedulaCliente.Text = "";
            lblAvisoRucCliente.Visible = false;
            lblAvisoRucCliente.Text = "";
            lblAvisoTelefonoCelularCliente.Visible = false;
            lblAvisoTelefonoCelularCliente.Text = "";

        }

        private void txtApellidoCliente_TextChanged(object sender, EventArgs e)
        {
            lblAvisoCedulaCliente.Visible = false;
            lblAvisoCedulaCliente.Text = "";
            lblAvisoRucCliente.Visible = false;
            lblAvisoRucCliente.Text = "";
            lblAvisoTelefonoCelularCliente.Visible = false;
            lblAvisoTelefonoCelularCliente.Text = "";
        }

        private void txtCedulaCliente_TextChanged(object sender, EventArgs e)
        {
            lblAvisoCedulaCliente.Visible = true;
            lblAvisoCedulaCliente.Text = "AVISO: Ingrese solamente HASTA 10 DIGITOS";

            lblAvisoRucCliente.Visible = false;
            lblAvisoRucCliente.Text = "";
            lblAvisoTelefonoCelularCliente.Visible = false;
            lblAvisoTelefonoCelularCliente.Text = "";
        }
        private void txtRucCliente_TextChanged(object sender, EventArgs e)
        {
            lblAvisoCedulaCliente.Visible = false;
            lblAvisoCedulaCliente.Text = "";
            lblAvisoRucCliente.Visible = true;
            lblAvisoRucCliente.Text = "AVISO: Ingrese solamente HASTA 13 DIGITOS";
            lblAvisoTelefonoCelularCliente.Visible = false;
            lblAvisoTelefonoCelularCliente.Text = "";
        }
        private void txtTelefonoCliente_TextChanged(object sender, EventArgs e)
        {
            lblAvisoRucCliente.Visible = false;
            lblAvisoRucCliente.Text = "";
            lblAvisoTelefonoCelularCliente.Visible = true;
            lblAvisoTelefonoCelularCliente.Text = "AVISO: Ingrese solamente HASTA 10 DIGITOS";
            lblAvisoCedulaCliente.Visible = false;
            lblAvisoCedulaCliente.Text = "";
        }
        private void txtDireccionCliente_TextChanged(object sender, EventArgs e)
        {
            lblAvisoTelefonoCelularCliente.Visible = false;
            lblAvisoTelefonoCelularCliente.Text = "";
            lblAvisoCedulaCliente.Visible = false;
            lblAvisoCedulaCliente.Text = "";
            lblAvisoRucCliente.Visible = false;
            lblAvisoRucCliente.Text = "";
        }
        private void txtMailCliente_TextChanged(object sender, EventArgs e)
        {
            lblAvisoCedulaCliente.Visible = false;
            lblAvisoCedulaCliente.Text = "";
            lblAvisoRucCliente.Visible = false;
            lblAvisoRucCliente.Text = "";
            lblAvisoTelefonoCelularCliente.Visible = false;
            lblAvisoTelefonoCelularCliente.Text = "";
        }
        private void txtTelefonoFijoCliente_TextChanged(object sender, EventArgs e)
        {
            lblAvisoCedulaCliente.Visible = false;
            lblAvisoCedulaCliente.Text = "";
            lblAvisoRucCliente.Visible = false;
            lblAvisoRucCliente.Text = "";
            lblAvisoTelefonoCelularCliente.Visible = false;
            lblAvisoTelefonoCelularCliente.Text = "";
        }
        public bool verificarIngeso()
        {
            bool resverificarIngeso = true; 
            if (txtNombreCliente.Text == "")
            {
                MessageBox.Show("Ingrese Nombre del Cliente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                resverificarIngeso = false;
            }
            else if (txtApellidoCliente.Text == "")
            {
                MessageBox.Show("Ingrese Apellido del Cliente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                resverificarIngeso = false;
            }
            else if (txtCedulaCliente.Text == "" && condicionVerificarIngreso==1)
            {
                MessageBox.Show("Ingrese Cédula del Cliente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                resverificarIngeso = false;
            }
            else if (txtRucCliente.Text == "" && condicionVerificarIngreso==2)
            {
                MessageBox.Show("Ingrese Ruc del Cliente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                resverificarIngeso = false;
            }
            else if (txtCedulaCliente.Text == "" && txtRucCliente.Text == "" && condicionVerificarIngreso == 3)
            {
                MessageBox.Show("Ingrese Cédula y Ruc del Cliente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                resverificarIngeso = false;            
            }
            else if (txtCedulaCliente.Text == "" && txtRucCliente.Text != "" && condicionVerificarIngreso == 3)
            {
                MessageBox.Show("Ingrese Cédula del Cliente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                resverificarIngeso = false;
            }
            else if (txtCedulaCliente.Text != "" && txtRucCliente.Text == "" && condicionVerificarIngreso == 3)
            {
                MessageBox.Show("Ingrese Ruc del Cliente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                resverificarIngeso = false;
            }
            else if (rBtnCedula .Checked ==false && rBtnRuc.Checked==false )
            {
                MessageBox.Show("Elija ingresar datos según Cédula ó RUC ", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation );
                resverificarIngeso = false;
            }
            else 
            {
                resverificarIngeso = true;
            }
            return resverificarIngeso;
        }

        private void rBtnCedula_CheckedChanged(object sender, EventArgs e)
        {
            txtCedulaCliente.Enabled = true;
            txtRucCliente.Enabled = false;
            condicionVerificarIngreso = 1;
            txtRucCliente.Text = "";
        }

        private void rBtnRuc_CheckedChanged(object sender, EventArgs e)
        {
            txtCedulaCliente.Enabled = false;
            txtRucCliente.Enabled = true;
            condicionVerificarIngreso = 2;
            txtCedulaCliente.Text = "";
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

        private void txtRucCliente_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtTelefonoCelularCliente_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtTelefonoFijoCliente_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtNombreCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
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

        private void txtApellidoCliente_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnCancelarIngresarCliente_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtDireccionCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\'')
            {
                e.Handled = true;
            }

        }
     }
}
