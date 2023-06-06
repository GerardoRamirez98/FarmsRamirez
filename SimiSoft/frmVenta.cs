using FarmsRamirezBML;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace TECNIPRINT
{
    public partial class frmVenta : DevExpress.XtraEditors.XtraForm
    {
        public frmVenta()
        {
            InitializeComponent();
        }

        public class ComboBoxItem
        {
            public string Text { get; set; }
            public object Value { get; set; }
        }

        private void frmVenta_Load(object sender, EventArgs e)
        {
            //fecha y hora en tiempo real del sistema
            timer1.Enabled = true;

            //enlistar los productos
            List<Producto> productos = new Producto().GetAll();
            {
                cbProducto.Items.Add(new ComboBoxItem() { Value = 0, Text = "Seleccione Producto" });
                foreach (Producto row in productos.Where(x => x.Activo == true))
                {
                    cbProducto.Items.Add(new ComboBoxItem() { Value = row.IdProducto, Text = row.Nombre });
                }
                cbProducto.DisplayMember = "Text";
                cbProducto.ValueMember = "Value";
                cbProducto.SelectedIndex = 0;
            }


        }

        //Fecha y Hora en tiempo real
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHoraActual.Text = DateTime.Now.ToString("hh:mm:ss");
            lblFechaActual.Text = DateTime.Now.ToLongDateString();
        }
    }
}