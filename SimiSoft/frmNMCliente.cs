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
        public frmNMCliente(int clienteID)
        {
            InitializeComponent();
            cliente = new Cliente
            {
                clienteID = clienteID
            }.GetById();
            txtID.Text = cliente.clienteID.ToString();
            txtNombres.Text = cliente.nombres;
            txtApellidoP.Text = cliente.apellidoP;
            txtApellidoM.Text = cliente.apellidoM;
            txtCelular.Text = cliente.celular;
            txtTelFijo.Text = cliente.telFijo;
            txtCorreo.Text = cliente.correo;
            txtCodigoPostal.Text = cliente.codigoPostal.ToString();
            txtEstado.Text = cliente.estado;
            txtCiudad.Text = cliente.ciudad;
            txtMunicipio.Text = cliente.municipio;
            txtColonia.Text = cliente.colonia;
            txtCalle.Text = cliente.calle;
            txtNInterior.Text = cliente.nInterior;
            txtNExterior.Text = cliente.nExterior;
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
                        nombres = txtNombres.Text,
                        apellidoP = txtApellidoP.Text,
                        apellidoM = txtApellidoM.Text,
                        celular = txtCelular.Text,
                        telFijo = txtTelFijo.Text,
                        correo = txtCorreo.Text,
                        codigoPostal = Convert.ToInt32(txtCodigoPostal.Text),
                        estado = txtEstado.Text,
                        ciudad = txtCiudad.Text,
                        municipio = txtMunicipio.Text,
                        colonia = txtColonia.Text,
                        calle = txtCalle.Text,
                        nInterior = txtNInterior.Text,
                        nExterior = txtNExterior.Text

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
                    cliente.nombres = txtNombres.Text;
                    cliente.apellidoP = txtApellidoP.Text;
                    cliente.apellidoM = txtApellidoM.Text;
                    cliente.celular = txtCelular.Text;
                    cliente.telFijo = txtTelFijo.Text;
                    cliente.correo = txtCorreo.Text;
                    cliente.codigoPostal = Convert.ToInt32(txtCodigoPostal.Text);
                    cliente.estado = txtEstado.Text;
                    cliente.ciudad = txtCiudad.Text;
                    cliente.municipio = txtMunicipio.Text;
                    cliente.colonia = txtColonia.Text;
                    cliente.calle = txtCalle.Text;
                    cliente.nInterior = txtNInterior.Text;
                    cliente.nExterior = txtNExterior.Text;

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