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
    public partial class frmRoles : DevExpress.XtraEditors.XtraForm
    {
        public frmRoles()
        {
            InitializeComponent();
        }

        private void frmRoles_Load(object sender, EventArgs e)
        {
            rolesBindingSource.DataSource = new Roles().GetAll();
            gvRoles.BestFitColumns();
        }

        private void btnNuevoRol_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new frmNMRoles
            {
                Text = "Nuevo Rol"
            }.ShowDialog();
            rolesBindingSource.DataSource = new Roles().GetAll();
            gvRoles.BestFitColumns();
        }

        private void btnModificarRol_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new frmNMRoles((int)gvRoles.GetFocusedRowCellValue("rolID"))
            {
                Text = "Modificar Rol (" + (int)gvRoles.GetFocusedRowCellValue("rolID") + ")"
            }.ShowDialog();
            rolesBindingSource.DataSource = new Roles().GetAll();
            gvRoles.BestFitColumns();
        }

        private void btnEliminarRol_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new Roles
            {
                rolID = (int)gvRoles.GetFocusedRowCellValue("rolID")
            }.Delete();
            rolesBindingSource.DataSource = new Roles().GetAll();
            gvRoles.BestFitColumns();
        }
    }
}