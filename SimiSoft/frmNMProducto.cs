using DevExpress.Utils.CommonDialogs;
using DevExpress.XtraEditors;
using FarmsRamirezBML;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;// para los archivos en memoria
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;// para la clase imagen
using System.Security.Policy;
using System.Net; // para usar servidor ftp xampp

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

        //variable url para almacenar la direccion de la imagen
        string url = "";

        private int SubirArchivo()
        {
            try
            {
                FtpWebRequest request = (FtpWebRequest)FtpWebRequest.Create("ftp://192.168.100.17/Imagen.jpg");
                request.Method = WebRequestMethods.Ftp.UploadFile;
                request.Credentials = new NetworkCredential("TECNIPRINT", "12345");
                request.UsePassive = true;
                request.UseBinary = true;
                request.KeepAlive = true;
                FileStream stream = File.OpenRead(url);
                byte[] buffer = new byte[stream.Length];
                stream.Read(buffer, 0, buffer.Length);
                stream.Close();
                Stream reqStream = request.GetRequestStream();
                reqStream.Write(buffer, 0, buffer.Length);
                reqStream.Flush();
                reqStream.Close();
                return 1;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        private void btnAbrirImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.InitialDirectory = "'c:\'";
            openFileDialog.Filter = "jpg (*.jpg)|*.jpg|png (*.png)|*.png|gif (*.gif)|*.gif";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                url = openFileDialog.FileName;
                pbImagen.ImageLocation = url;
                pbImagen.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void btnBorrarImg_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardarImg_Click(object sender, EventArgs e)
        {
            int resultado = SubirArchivo();

            if (resultado == 1)
                MessageBox.Show("Archivo subido correctamente");
            else
                MessageBox.Show("Ha ocurrido un problema al subir el archivo");
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                if (producto == null)
                {
                    if (new Producto
                    {
                        codigo = txtCodigo.Text,
                        codigoBarra = txtCodigoBarra.Text,
                        nombre = txtNombre.Text,
                        descripcion = txtDescripcion.Text,
                        marca = txtMarca.Text,
                        unidadMedida = txtUnidadM.Text,
                        precioCompra = Convert.ToDecimal(txtPrecioC.Text),
                        margenGanancia = Convert.ToInt32(txtMargenG.Text),
                        precioVenta = Convert.ToDecimal(txtPrecioV.Text),
                        stock = Convert.ToInt32(txtStock.Text),
                        stockMin = Convert.ToInt32(txtStockMin.Text),
                        stockMax = Convert.ToInt32(txtStockMax.Text),
                        foto = Convert.ToInt32(pbImagen.Image)
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
                    producto.codigo = txtCodigo.Text;
                    producto.codigoBarra = txtCodigoBarra.Text;
                    producto.nombre = txtNombre.Text;
                    producto.descripcion = txtDescripcion.Text;
                    producto.marca = txtMarca.Text;
                    producto.unidadMedida = txtUnidadM.Text;
                    producto.precioCompra = Convert.ToDecimal(txtPrecioC.Text);
                    producto.margenGanancia = Convert.ToInt32(txtMargenG.Text);
                    producto.precioVenta = Convert.ToDecimal(txtPrecioV.Text);
                    producto.stock = Convert.ToInt32(txtStock.Text);
                    producto.stockMin = Convert.ToInt32(txtStockMin.Text);
                    producto.stockMax = Convert.ToInt32(txtStockMax.Text);

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
            if(string.IsNullOrEmpty(txtNombre.Text)) 
            {
                txtNombre.ErrorText = "";
                txtNombre.Focus();
                ban = true;
            }
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

        
    }
}