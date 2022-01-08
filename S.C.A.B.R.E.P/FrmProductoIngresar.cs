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
    public partial class FrmProductoIngresar : Form
    {
        public FrmProductoIngresar()
        {
            InitializeComponent();
        }

        private void btnIngresarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                Conexiones productoEspecialObjeto = new Conexiones();
                if (verificarIngreso())
                {
                    int res = productoEspecialObjeto.verificarCodigoRepeticionProductoEspecial((lblProducto.Text+txtCodigoProducto.Text).Trim(), txtNombreProducto.Text.Trim(), Convert.ToDouble(txtCostoProducto.Text));
                    if (res == 1)
                    {
                        MessageBox.Show("Producto registrado", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("El producto ya esta registrado o esta usando un codigo ya registrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch 
            {
                MessageBox.Show("Verifique el formato de ingreso en el campo de costo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        bool verificarIngreso()
        {
            bool res;
            if (txtCodigoProducto.Text == "")
            {
                MessageBox.Show("Ingrese el codigo del producto", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                res = false;
            }
            else if (txtNombreProducto.Text == "")
            {
                MessageBox.Show("Ingrese el nombre del producto", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                res = false;
            }
            else if (txtCostoProducto.Text == "")
            {
                MessageBox.Show("Ingrese el costo del producto", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                res = false;
            }
            else 
            {
                res = true;
            }
            return res;

        }


        private void txtCostoProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            lblAvisoCostoProductoEspecial.Visible = true;
            lblAvisoCostoProductoEspecial.Text = "Ingrese el costo del producto con el formato (.) para decimales"; 
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (e.KeyChar=='.')
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
            lblAvisoCostoProductoEspecial.Text = ""; 
        }

        private void txtNombreProducto_TextChanged(object sender, EventArgs e)
        {
            lblAvisoCostoProductoEspecial.Visible = false;
            lblAvisoCostoProductoEspecial.Text = ""; 
        }

        private void txtDescripcionProducto_TextChanged(object sender, EventArgs e)
        {
            lblAvisoCostoProductoEspecial.Visible = false;
            lblAvisoCostoProductoEspecial.Text = ""; 
        }

        private void btnCancelarIngresarCliente_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCodigoProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\'')
            {
                e.Handled = true;
            }
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
