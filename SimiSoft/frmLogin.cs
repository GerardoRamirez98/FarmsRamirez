using DevExpress.XtraEditors;
using FarmsRamirezBML;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimiSoft
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                if (new Usuario
                {
                    username = txtUsuario.Text,
                    password = txtContrasena.Text
                }.Login()!=null)
                {
                    XtraMessageBox.Show("Acceso correcto");
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    XtraMessageBox.Show("Error en las credenciales");
                }
            }
        }

        private bool Validar()
        {
            var ban = false;
            if(string.IsNullOrEmpty(txtUsuario.Text))
            {
                txtUsuario.ErrorText = "Ingrese el usuario";
                txtUsuario.Focus();
                ban = true;
            }
            if(string.IsNullOrEmpty(txtContrasena.Text))
            {
                txtContrasena.ErrorText = "Ingrese la contraseña";
                if(!ban)
                {
                    txtContrasena.Focus();
                    ban = true;
                }
            }
            return !ban;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}