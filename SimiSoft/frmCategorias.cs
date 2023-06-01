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
    public partial class frmCategorias : DevExpress.XtraEditors.XtraForm
    {
        public frmCategorias()
        {
            InitializeComponent();
        }

        private void frmCategorias_Load(object sender, EventArgs e)
        {
            categoriasBindingSource.DataSource = new Categorias().GetAll();
            gvCategorias.BestFitColumns();
        }

        private void btnNuevoCategoria_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        private void btnModificarCategoria_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnEliminarCategoria_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnActualizarCategorias_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
    }
}