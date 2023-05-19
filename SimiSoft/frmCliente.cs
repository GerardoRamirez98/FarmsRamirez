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
    public partial class frmCliente : DevExpress.XtraEditors.XtraForm
    {
        public frmCliente()
        {
            InitializeComponent();
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            clientebindingSource.DataSource = new Cliente().GetAll();
            gvClientes.BestFitColumns();
        }

        private void btnActualizarProducto_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnNuevoProducto_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new frmNMCliente
            {
                Text = "Nuevo Cliente"
            }.ShowDialog();
            clientebindingSource.DataSource = new Cliente().GetAll();
            gvClientes.BestFitColumns();
        }

        private void btnModificarProducto_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new frmNMCliente((int)gvClientes.GetFocusedRowCellValue("clienteID"))
            {
                Text = "Modificar Cliente (" + (int)gvClientes.GetFocusedRowCellValue("clienteID") + ")"
            }.ShowDialog();
            clientebindingSource.DataSource = new Producto().GetAll();
            gvClientes.BestFitColumns();
        }

        private void btnEliminarProducto_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new Cliente
            {
                clienteID = (int)gvClientes.GetFocusedRowCellValue("clienteID")
            }.Delete();
            clientebindingSource.DataSource = new Producto().GetAll();
            gvClientes.BestFitColumns();
        }

        
    }
}