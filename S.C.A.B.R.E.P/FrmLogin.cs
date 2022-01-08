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
    public partial class FrmLogin : Form
    {
        public string nom_Usuario;
        public string paswd_Usuario;

        public FrmLogin()
        {
            InitializeComponent();
        }
        int intentos = 0;
        private void btnIngresarLogin_Click(object sender, EventArgs e)
        {
            Conexiones ingreso = new Conexiones();
            if (intentos != 3)
            {
                if(ingreso.Login("SELECT ID_USUARIO FROM USUARIO WHERE NOMBRE_USUARIO ='"+txtUsuarioLogin.Text+"' AND PASSWORD_USUARIO ='"+txtPasswordLogin.Text+"'")) 
                {
                    intentos = 0;
                    nom_Usuario = txtUsuarioLogin.Text;
                    paswd_Usuario = txtPasswordLogin.Text;
                    MDIPrincipal principal = new MDIPrincipal(nom_Usuario, paswd_Usuario);
                    principal.Show();
                    this.Hide();
                    
                }
                else
                {
                    MessageBox.Show("Por favor asegurese de que su nombre de Usuario y Password sea el correcto", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtUsuarioLogin.Text = "";
                    txtPasswordLogin.Text = "";
                    intentos++;
                }
            }
            else
            {
                Application.Exit();
            }
        }
    }
}
