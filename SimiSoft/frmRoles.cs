﻿using FarmsRamirezBML;
using System;

namespace SimiSoft
{
    public partial class frmRoles : DevExpress.XtraEditors.XtraForm
    {
        public frmRoles()
        {
            InitializeComponent();
        }

        private void frmRoles_Load(object sender, EventArgs e)
        {
            //rolesBindingSource.DataSource = new TipoUsuario().GetAll();
            gvRoles.BestFitColumns();
        }

        private void btnNuevoRol_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new frmNMRoles
            {
                Text = "Nuevo Rol"
            }.ShowDialog();
            //rolesBindingSource.DataSource = new TipoUsuario().GetAll();
            gvRoles.BestFitColumns();
        }

        private void btnModificarRol_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new frmNMRoles((int)gvRoles.GetFocusedRowCellValue("IdTipoUsuario"))
            {
                Text = "Modificar Rol (" + (int)gvRoles.GetFocusedRowCellValue("IdTipoUsuario") + ")"
            }.ShowDialog();
            //rolesBindingSource.DataSource = new TipoUsuario().GetAll();
            gvRoles.BestFitColumns();
        }

        private void btnEliminarRol_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //new TipoUsuario
            //{
            //IdTipoUsuario = (int)gvRoles.GetFocusedRowCellValue("IdTipoUsuario")
            //}.Delete();
            //rolesBindingSource.DataSource = new TipoUsuario().GetAll();
            gvRoles.BestFitColumns();
        }
    }
}