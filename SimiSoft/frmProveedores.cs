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
    public partial class frmProveedores : DevExpress.XtraEditors.XtraForm
    {
        public frmProveedores()
        {
            InitializeComponent();
        }

        private void gcProveedores_Click(object sender, EventArgs e)
        {

        }

        private void frmProveedores_Load(object sender, EventArgs e)
        {
            proveedorBindingSource1.DataSource = new Proveedor().GetAll();
            gvProveedores.BestFitColumns();
        }

        private void btnActualizarProducto_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        private void btnNuevoProducto_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new frmNMProveedor
            {
                Text = "Nuevo Proveedor"
            }.ShowDialog();
            proveedorBindingSource1.DataSource = new Proveedor().GetAll();
        }

        private void btnModificarProducto_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new frmNMProveedor((int)gvProveedores.GetFocusedRowCellValue("IdProveedor"))
            {
                Text = "Modificar Proveedor (" + (int)gvProveedores.GetFocusedRowCellValue("IdProveedor") + ")"
            }.ShowDialog();
            proveedorBindingSource1.DataSource = new Producto().GetAll();
            gvProveedores.BestFitColumns();
        }

        private void btnEliminarProducto_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new Proveedor
            {
                IdProveedor = (int)gvProveedores.GetFocusedRowCellValue("IdProveedor")
            }.Delete();
            proveedorBindingSource1.DataSource = new Proveedor().GetAll();
            gvProveedores.BestFitColumns();
        }

        
    }
}