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
using static DevExpress.XtraEditors.RoundedSkinPanel;

namespace SimiSoft
{
    public partial class frmNMProveedor : DevExpress.XtraEditors.XtraForm
    {
        private Proveedor proveedor;
        public frmNMProveedor()
        {
            InitializeComponent();
            txtID.Enabled = false;
        }

        public frmNMProveedor(int IdProveedor)
        {
            InitializeComponent();
            proveedor = new Proveedor
            {
                IdProveedor = IdProveedor
            }.GetById();
            txtID.Text = proveedor.IdProveedor.ToString();
            txtNombreEmpresa.Text = proveedor.NombreEmpresa;
            txtCodigoPostal.Text = proveedor.CP.ToString();
            txtEstado.Text = proveedor.Estado;
            txtCiudad.Text = proveedor.Ciudad;
            txtMunicipio.Text = proveedor.Municipio;
            txtColonia.Text = proveedor.Colonia;
            txtCalle.Text = proveedor.Calle;
            txtNInterior.Text = proveedor.NumeroInterior.ToString();
            txtNExterior.Text = proveedor.NumeroExterior.ToString();
            txtCelular.Text = proveedor.Celular;
            txtTelefonoFijo.Text = proveedor.TelefonoFijo;
            txtCorreo.Text = proveedor.Correo;
            txtPaginaWeb.Text = proveedor.PaginaWeb;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bntGuardar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                if (proveedor == null)
                {
                    if (new Proveedor
                    {
                        NombreEmpresa = txtNombreEmpresa.Text,
                        CP = Convert.ToInt32(txtCodigoPostal.Text),
                        Estado = txtEstado.Text,
                        Ciudad = txtCiudad.Text,
                        Municipio = txtMunicipio.Text,
                        Colonia = txtColonia.Text,
                        Calle = txtCalle.Text,
                        NumeroInterior = Convert.ToInt32(txtNInterior.Text),
                        NumeroExterior = Convert.ToInt32(txtNExterior.Text),
                        Celular = txtCelular.Text,
                        TelefonoFijo = txtTelefonoFijo.Text,
                        Correo = txtCorreo.Text,
                        PaginaWeb = txtPaginaWeb.Text,
                    }.Add() > 0)
                    {
                        XtraMessageBox.Show("Proveedor insertado correctamente", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    proveedor.NombreEmpresa = txtNombreEmpresa.Text;
                    proveedor.CP = Convert.ToInt32(txtCodigoPostal.Text);
                    proveedor.Estado = txtEstado.Text;
                    proveedor.Ciudad = txtCiudad.Text;
                    proveedor.Municipio = txtMunicipio.Text;
                    proveedor.Colonia = txtColonia.Text;
                    proveedor.Calle = txtCalle.Text;
                    proveedor.NumeroInterior = Convert.ToInt32(txtNInterior.Text);
                    proveedor.NumeroExterior = Convert.ToInt32(txtNExterior.Text);
                    proveedor.Celular = txtCelular.Text;
                    proveedor.TelefonoFijo = txtTelefonoFijo.Text;
                    proveedor.Correo = txtCorreo.Text;
                    proveedor.PaginaWeb = txtPaginaWeb.Text;

                    if (proveedor.Update() > 0)
                    {
                        XtraMessageBox.Show("Proveedor modificado correctamente", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            //nombre empresa
            if (string.IsNullOrEmpty(txtNombreEmpresa.Text))
            {
                txtNombreEmpresa.ErrorText = "Ingrese el nombre de la empresa";
                if (!ban)
                {
                    txtNombreEmpresa.Focus();
                    ban = true;
                }
            }
            //codigo postal
            if (string.IsNullOrEmpty(txtCodigoPostal.Text))
            {
                txtCodigoPostal.ErrorText = "Ingrese un codigo postal";
                if (!ban)
                {
                    txtCodigoPostal.Focus();
                    ban = true;
                }
            }
            //estado
            if (string.IsNullOrEmpty(txtEstado.Text))
            {
                txtEstado.ErrorText = "Ingrese un estado";
                if (!ban)
                {
                    txtEstado.Focus();
                    ban = true;
                }
            }
            //ciudad
            if (string.IsNullOrEmpty(txtCiudad.Text))
            {
                txtCiudad.ErrorText = "Ingrese una ciudad";
                if (!ban)
                {
                    txtCiudad.Focus();
                    ban = true;
                }
            }
            //municipio
            if (string.IsNullOrEmpty(txtMunicipio.Text))
            {
                txtMunicipio.ErrorText = "Ingrese un municipio";
                if (!ban)
                {
                    txtMunicipio.Focus();
                    ban = true;
                }
            }
            //colonia
            if (string.IsNullOrEmpty(txtColonia.Text))
            {
                txtColonia.ErrorText = "Ingrese una colonia";
                if (!ban)
                {
                    txtColonia.Focus();
                    ban = true;
                }
            }
            //calle
            if (string.IsNullOrEmpty(txtCalle.Text))
            {
                txtCalle.ErrorText = "Ingrese una calle";
                if (!ban)
                {
                    txtCalle.Focus();
                    ban = true;
                }
            }
            return !ban;
        }
    }
}