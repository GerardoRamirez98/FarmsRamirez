﻿using DevExpress.XtraEditors;
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
            proveedorBindingSource.DataSource = new Proveedor().GetAll();
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
            proveedorBindingSource.DataSource = new Proveedor().GetAll();
        }

        private void btnModificarProducto_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new frmNMProveedor((int)gvProveedores.GetFocusedRowCellValue("productoID"))
            {
                Text = "Modificar Producto (" + (int)gvProveedores.GetFocusedRowCellValue("productoID") + ")"
            }.ShowDialog();
            proveedorBindingSource.DataSource = new Producto().GetAll();
            gvProveedores.BestFitColumns();
        }

        private void btnEliminarProducto_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new Proveedor
            {
                proveedorID = (int)gvProveedores.GetFocusedRowCellValue("proveedorID")
            }.Delete();
            proveedorBindingSource.DataSource = new Proveedor().GetAll();
            gvProveedores.BestFitColumns();
        }

        
    }
}