using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
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
    public partial class frmAsignarPermisosRol : DevExpress.XtraEditors.XtraForm
    {
        public frmAsignarPermisosRol()
        {
            InitializeComponent();
        }

        public class ComboBoxItem
        {
            public string Text { get; set; }
            public object Value { get; set; }
        }

        private void frmAsignarPermisosRol_Load(object sender, EventArgs e)
        {
            List<Roles> roles = new Roles().GetAll();
            cbRoles.Items.Add(new ComboBoxItem() { Value = 0, Text = "Seleccione Rol" });
            foreach (Roles row in roles.Where(x => x.status == true))
            {
                cbRoles.Items.Add(new ComboBoxItem() { Value = row.rolID, Text = row.descripcion });
            }
            cbRoles.DisplayMember = "Text";
            cbRoles.ValueMember = "Value";
            cbRoles.SelectedIndex = 0;

            dgvPermisos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPermisos.MultiSelect = false;
            dgvPermisos.ReadOnly = true;
            dgvPermisos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPermisos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPermisos.AllowUserToAddRows = false;

            DataGridViewCheckBoxColumn checkColumn = new DataGridViewCheckBoxColumn();
            checkColumn.Name = "Activar";
            checkColumn.HeaderText = "Activar";
            checkColumn.Width = 50;
            checkColumn.ReadOnly = false;
            checkColumn.FillWeight = 30;
            dgvPermisos.Columns.Add(checkColumn);

            dgvPermisos.Columns.Add("IdPermisos", "IdPermisos");
            dgvPermisos.Columns.Add("Menu", "Menu");
            dgvPermisos.Columns.Add("Sub Menu", "Sub Menu");
            dgvPermisos.Columns.Add("Activo", "Activo");

            dgvPermisos.Columns["Menu"].FillWeight = 60;
            dgvPermisos.Columns["IdPermisos"].Visible = false;
            dgvPermisos.Columns["Activo"].Visible = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            
        }

        private void CargarDatos(int rolID)
        {
            dgvPermisos.Rows.Clear();
            List<Permisos> permisos = Permisos.GetAll(rolID);
            if (permisos.Count > 0)
            {
                foreach (frmAsignarPermisosRol r in permisos)
                {
                    int rowID = dgvPermisos.Rows.Add();
                    DataGridViewRow row = dgvPermisos.Rows[rowID];
                    row.Cells["permisosID"].Value = r.permisosID;
                    row.Cells["Menu"].Value = r.Menu;
                    row.Cells["Sub Menu"].Value = r.SubMenu;
                    row.Cells["Activar"].Value = r.status;
                    row.Cells["Status"].Value = r.status;
                }
                dgvPermisos.Columns["permisosID"].Visible = false;
                dgvPermisos.Columns["status"].Visible = false;
            }
        }

        
    }
}