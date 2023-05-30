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
    public partial class frmNMRoles : DevExpress.XtraEditors.XtraForm
    {
        private Roles roles;
        public frmNMRoles()
        {
            InitializeComponent();
            txtID.Enabled = false;
        }

        public frmNMRoles(int IdTipoUsuario)
        {
            InitializeComponent();
            roles = new Roles
            {
                IdTipoUsuario = IdTipoUsuario
            }.GetById();
            txtID.Text = roles.IdTipoUsuario.ToString();
            txtDescripcion.Text = roles.Descripcion;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                if (roles == null)
                {
                    if (new Roles
                    {
                        Descripcion = txtDescripcion.Text
                    }.Add() > 0)
                    {
                        XtraMessageBox.Show("Rol insertado correctamente", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        XtraMessageBox.Show("Ocurrio un error en la insercion", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Close();
                    }
                }
                else
                {
                    roles.Descripcion = txtDescripcion.Text;

                    if (roles.Update() > 0)
                    {
                        XtraMessageBox.Show("Rol modificado correctamente", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        XtraMessageBox.Show("Ocurrio un error en la modificacion", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Close();
                    }
                }
            }
        }

        private bool Validar()
        {
            var ban = false;
            //descripcion
            if (string.IsNullOrEmpty(txtDescripcion.Text))
            {
                txtDescripcion.ErrorText = "Ingrese la descripcion del rol";
                if (!ban)
                {
                    txtDescripcion.Focus();
                    ban = true;
                }
            }
            return !ban;
        }

        private void frmNMRoles_Load(object sender, EventArgs e)
        {

        }
    }
}