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
using TECNIPRINT;

namespace SimiSoft
{
    public partial class frmUsuarios : DevExpress.XtraEditors.XtraForm
    {
        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            usuarioBindingSource.DataSource = new Usuario().GetAll();
            gvUsuarios.BestFitColumns();
        }

        private void btnNuevoUsuario_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new frmNMUsuario
            {
                Text = "Nuevo Usuario"
            }.ShowDialog();
            usuarioBindingSource.DataSource = new Usuario().GetAll();
        }

        private void btnModificarUsuario_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new frmNMUsuario((int)gvUsuarios.GetFocusedRowCellValue("IdUsuarios"))
            {
                Text = "Modificar Usuario (" + (int)gvUsuarios.GetFocusedRowCellValue("IdUsuarios") + ")"
            }.ShowDialog();
            usuarioBindingSource.DataSource = new Usuario().GetAll();
            gvUsuarios.BestFitColumns();
        }

        private void btnEliminarUsuario_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new Usuario
            {
                IdUsuarios = (int)gvUsuarios.GetFocusedRowCellValue("IdUsuarios")
            }.Delete();
            usuarioBindingSource.DataSource = new Usuario().GetAll();
            gvUsuarios.BestFitColumns();
        }
    }
}