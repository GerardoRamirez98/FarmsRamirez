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
    public partial class frmNMProducto : DevExpress.XtraEditors.XtraForm
    {        
        private Producto producto;
        //cuando es nuevo producto
        public frmNMProducto()
        {
            InitializeComponent();
            txtID.Enabled = false;
        }
        //cuando es modificar producto
        public frmNMProducto(int productoID)
        {
            InitializeComponent();
            producto = new Producto
            {
                productoID = productoID
            }.GetById();
            txtID.Text = producto.productoID.ToString();
            txtCodigo.Text = producto.codigo;
            txtCodigoBarra.Text = producto.codigoBarra;
            txtNombre.Text = producto.nombre;
            txtDescripcion.Text = producto.descripcion;
            txtMarca.Text = producto.marca;
            txtUnidadM.Text = producto.unidadMedida;
            txtPrecioC.Text = producto.precioCompra.ToString();
            txtMargenG.Text = producto.margenGanancia.ToString();
            txtPrecioV.Text = producto.precioVenta.ToString();
            txtStock.Text = producto.stock.ToString();
            txtStockMin.Text = producto.stockMin.ToString();
            txtStockMax.Text = producto.stockMax.ToString();
            
        }

        private void frmNMProducto_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                if (producto == null)
                {
                    if (new Producto
                    {
                        descripcion = txtDescripcion.Text,
                        unidadMedida = txtUnidadM.Text,
                        codigo = txtCodigo.Text,
                        precioVenta = Convert.ToDecimal(txtPrecioV.Text),
                        stock = Convert.ToInt32(txtStock.Text),
                        marca = txtMarca.Text
                    }.Add() > 0)
                    {
                        XtraMessageBox.Show("Producto insertado correctamente", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    producto.descripcion = txtDescripcion.Text;
                    producto.unidadMedida = txtUnidadM.Text;
                    producto.codigo = txtCodigo.Text;
                    producto.precioCompra = Convert.ToDecimal(txtPrecioC.Text);
                    producto.precioVenta = Convert.ToDecimal(txtPrecioV.Text);
                    producto.stock = Convert.ToInt32(txtStock.Text);
                    producto.marca = txtMarca.Text;
                    if (producto.Update() > 0)
                    {
                        XtraMessageBox.Show("Producto modificado correctamente", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (string.IsNullOrEmpty(txtDescripcion.Text))
            {
                txtDescripcion.ErrorText = "Ingrese la descripcion";
                txtDescripcion.Focus();
                ban = true;
            }
            if (string.IsNullOrEmpty(txtUnidadM.Text))
            {
                txtUnidadM.ErrorText = "Ingrese una unidad de medida";
                if (!ban)
                {
                    txtUnidadM.Focus();
                    ban = true;
                }
            }
            if (string.IsNullOrEmpty(txtCodigo.Text))
            {
                txtCodigo.ErrorText = "Ingrese un codigo";
                if (!ban)
                {
                    txtCodigo.Focus();
                    ban = true;
                }
            }
            if (string.IsNullOrEmpty(txtPrecioV.Text))
            {
                txtPrecioV.ErrorText = "Ingrese un precio";
                if (!ban)
                {
                    txtPrecioV.Focus();
                    ban = true;
                }
            }
            if (string.IsNullOrEmpty(txtStock.Text))
            {
                txtStock.ErrorText = "Ingrese un stock";
                if (!ban)
                {
                    txtStock.Focus();
                    ban = true;
                }
            }
            if (string.IsNullOrEmpty(txtMarca.Text))
            {
                txtMarca.ErrorText = "Ingrese una marca";
                if (!ban)
                {
                    txtMarca.Focus();
                    ban = true;
                }
            }
            return !ban;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "JPG Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png|All Files(*.*)|*.*";
            dlg.Title = "Seleccione una imagen";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string picLoc1 = dlg.FileName.ToString();
                pictureBox1.ImageLocation = picLoc1;
            }
        }
    }
}