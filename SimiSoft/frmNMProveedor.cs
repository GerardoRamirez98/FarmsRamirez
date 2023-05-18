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

        public frmNMProveedor(int proveedorID)
        {
            InitializeComponent();
            proveedor = new Proveedor
            {
                proveedorID = proveedorID
            }.GetById();
            txtID.Text = proveedor.proveedorID.ToString();
            txtNombreEmpresa.Text = proveedor.nombreEmpresa;
            txtCodigoPostal.Text = proveedor.codigoPostal.ToString();
            txtEstado.Text = proveedor.estado;
            txtCiudad.Text = proveedor.ciudad;
            txtMunicipio.Text = proveedor.municipio;
            txtColonia.Text = proveedor.colonia;
            txtCalle.Text = proveedor.calle;
            txtNInterior.Text = proveedor.nInterior.ToString();
            txtNExterior.Text = proveedor.nExterior.ToString();
            txtCelular.Text = proveedor.celular;
            txtTelefonoFijo.Text = proveedor.telFijo;
            txtCorreo.Text = proveedor.correo;
            txtPaginaWeb.Text = proveedor.paginaWeb;
            txtNombreRepresentante.Text = proveedor.nombreRepresentante;
            txtCorreoRepresentante.Text = proveedor.correoRepresentante;
            txtCelularRepresentante.Text = proveedor.celularRepresentante;
            txtTelefonoFijoRepresentante.Text = proveedor.telFijoRepresentante;
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
                        nombreEmpresa = txtNombreEmpresa.Text,
                        codigoPostal = Convert.ToInt32(txtCodigoPostal.Text),
                        estado = txtEstado.Text,
                        ciudad = txtCiudad.Text,
                        municipio = txtMunicipio.Text,
                        colonia = txtColonia.Text,
                        calle = txtCalle.Text,
                        nInterior = Convert.ToInt32(txtNInterior.Text),
                        nExterior = Convert.ToInt32(txtNExterior.Text),
                        celular = txtCelular.Text,
                        telFijo = txtTelefonoFijo.Text,
                        correo = txtCorreo.Text,
                        paginaWeb = txtPaginaWeb.Text,
                        nombreRepresentante = txtNombreRepresentante.Text,
                        correoRepresentante = txtCorreoRepresentante.Text,
                        celularRepresentante = txtCelularRepresentante.Text,
                        telFijoRepresentante = txtTelefonoFijoRepresentante.Text
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
                    proveedor.nombreEmpresa = txtNombreEmpresa.Text;
                    proveedor.codigoPostal = Convert.ToInt32(txtCodigoPostal.Text);
                    proveedor.estado = txtEstado.Text;
                    proveedor.ciudad = txtCiudad.Text;
                    proveedor.municipio = txtMunicipio.Text;
                    proveedor.colonia = txtColonia.Text;
                    proveedor.calle = txtCalle.Text;
                    proveedor.nInterior = Convert.ToInt32(txtNInterior.Text);
                    proveedor.nExterior = Convert.ToInt32(txtNExterior.Text);
                    proveedor.celular = txtCelular.Text;
                    proveedor.telFijo = txtTelefonoFijo.Text;
                    proveedor.correo = txtCorreo.Text;
                    proveedor.paginaWeb = txtPaginaWeb.Text;
                    proveedor.nombreRepresentante = txtNombreRepresentante.Text;
                    proveedor.correoRepresentante = txtCorreoRepresentante.Text;
                    proveedor.celularRepresentante = txtCelularRepresentante.Text;
                    proveedor.telFijoRepresentante = txtTelefonoFijoRepresentante.Text;

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