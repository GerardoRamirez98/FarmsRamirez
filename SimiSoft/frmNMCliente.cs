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
    public partial class frmNMCliente : DevExpress.XtraEditors.XtraForm
    {
        private Cliente cliente;
        public frmNMCliente()
        {
            InitializeComponent();
            txtID.Enabled = false;
        }

        //modificar cliente
        public frmNMCliente(int IdCliente)
        {
            InitializeComponent();
            cliente = new Cliente
            {
                IdCliente = IdCliente
            }.GetById();
            txtID.Text = cliente.IdCliente.ToString();
            txtNombres.Text = cliente.Nombres;
            txtApellidoP.Text = cliente.ApellidoPaterno;
            txtApellidoM.Text = cliente.ApellidoMaterno;
            txtCelular.Text = cliente.Celular;
            txtTelFijo.Text = cliente.TelefonoFijo;
            txtCorreo.Text = cliente.Correo;
            txtCodigoPostal.Text = cliente.CP.ToString();
            txtEstado.Text = cliente.Estado;
            txtCiudad.Text = cliente.Ciudad;
            txtMunicipio.Text = cliente.Municipio;
            txtColonia.Text = cliente.Colonia;
            txtCalle.Text = cliente.Calle;
            txtNInterior.Text = cliente.NumeroInterior;
            txtNExterior.Text = cliente.NumeroExterior;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                if (cliente == null)
                {
                    if(new Cliente
                    {
                        Nombres = txtNombres.Text,
                        ApellidoPaterno = txtApellidoP.Text,
                        ApellidoMaterno = txtApellidoM.Text,
                        Celular = txtCelular.Text,
                        TelefonoFijo = txtTelFijo.Text,
                        Correo = txtCorreo.Text,
                        CP = Convert.ToInt32(txtCodigoPostal.Text),
                        Estado = txtEstado.Text,
                        Ciudad = txtCiudad.Text,
                        Municipio = txtMunicipio.Text,
                        Colonia = txtColonia.Text,
                        Calle = txtCalle.Text,
                        NumeroInterior = txtNInterior.Text,
                        NumeroExterior = txtNExterior.Text

                    }.Add() > 0)
                    {
                        XtraMessageBox.Show("Cliente insertado correctamente", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        XtraMessageBox.Show("Ocurrio un error en la insercion de nuevo cliente", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Close();
                    }
                }
                else
                {
                    cliente.Nombres = txtNombres.Text;
                    cliente.ApellidoPaterno = txtApellidoP.Text;
                    cliente.ApellidoMaterno = txtApellidoM.Text;
                    cliente.Celular = txtCelular.Text;
                    cliente.TelefonoFijo = txtTelFijo.Text;
                    cliente.Correo = txtCorreo.Text;
                    cliente.CP = Convert.ToInt32(txtCodigoPostal.Text);
                    cliente.Estado = txtEstado.Text;
                    cliente.Ciudad = txtCiudad.Text;
                    cliente.Municipio = txtMunicipio.Text;
                    cliente.Colonia = txtColonia.Text;
                    cliente.Calle = txtCalle.Text;
                    cliente.NumeroInterior = txtNInterior.Text;
                    cliente.NumeroExterior = txtNExterior.Text;

                    if (cliente.Update() > 0)
                    {
                        XtraMessageBox.Show("Producto modificado correctamente", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        XtraMessageBox.Show("Ocurrio un error en la modificacion ciente", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Close();
                    }
                }
            }
        }

        private bool Validar()
        {
            var ban = false;
            //Nombres
            if (string.IsNullOrEmpty(txtNombres.Text))
            {
                txtNombres.ErrorText = "Ingrese un nombre";
                if (!ban)
                {
                    txtNombres.Focus();
                    ban = true;
                }
            }
            
            //Apellido Paterno
            if (string.IsNullOrEmpty(txtApellidoP.Text))
            {
                txtApellidoP.ErrorText = "Ingrese un apellido paterno";
                if (!ban)
                {
                    txtApellidoP.Focus();
                    ban = true;
                }
            }
            //Apellido Materno
            if (string.IsNullOrEmpty(txtApellidoM.Text))
            {
                txtApellidoM.ErrorText = "Ingrese un apellido materno";
                if (!ban)
                {
                    txtApellidoM.Focus();
                    ban = true;
                }
            }
            //Celular
            if (string.IsNullOrEmpty(txtCelular.Text))
            {
                txtCelular.ErrorText = "Ingrese un numero de celular";
                if (!ban)
                {
                    txtCelular.Focus();
                    ban = true;
                }
            }
            //Telefono Fijo
            if (string.IsNullOrEmpty(txtTelFijo.Text))
            {
                txtTelFijo.ErrorText = "Ingrese un numero de telefono fijo";
                if (!ban)
                {
                    txtTelFijo.Focus();
                    ban = true;
                }
            }
            //Correo
            if (string.IsNullOrEmpty(txtCorreo.Text))
            {
                txtCorreo.ErrorText = "Ingrese un correo";
                if (!ban)
                {
                    txtCorreo.Focus();
                    ban = true;
                }
            }
            //CodigoPostal
            if (string.IsNullOrEmpty(txtCodigoPostal.Text))
            {
                txtCodigoPostal.ErrorText = "Ingrese un codigo postal";
                if (!ban)
                {
                    txtCodigoPostal.Focus();
                    ban = true;
                }
            }
            //Estado
            if (string.IsNullOrEmpty(txtEstado.Text))
            {
                txtEstado.ErrorText = "Ingrese un estado";
                if (!ban)
                {
                    txtEstado.Focus();
                    ban = true;
                }
            }
            //Ciudad
            if (string.IsNullOrEmpty(txtCiudad.Text))
            {
                txtCiudad.ErrorText = "Ingrese una ciudad";
                if (!ban)
                {
                    txtCiudad.Focus();
                    ban = true;
                }
            }
            //Municipio
            if (string.IsNullOrEmpty(txtMunicipio.Text))
            {
                txtMunicipio.ErrorText = "Ingrese un municipio";
                if (!ban)
                {
                    txtMunicipio.Focus();
                    ban = true;
                }
            }
            //Colonia
            if (string.IsNullOrEmpty(txtColonia.Text))
            {
                txtColonia.ErrorText = "Ingrese una colonia";
                if (!ban)
                {
                    txtColonia.Focus();
                    ban = true;
                }
            }
            
            //Calle
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