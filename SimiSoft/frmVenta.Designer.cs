namespace TECNIPRINT
{
    partial class frmVenta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.cbCliente = new System.Windows.Forms.ComboBox();
            this.lblCliente = new DevExpress.XtraEditors.LabelControl();
            this.lblPrecioVenta = new DevExpress.XtraEditors.LabelControl();
            this.lblPrecioProducto = new DevExpress.XtraEditors.LabelControl();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.cbProducto = new System.Windows.Forms.ComboBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lblFecha = new DevExpress.XtraEditors.LabelControl();
            this.lblFechaActual = new DevExpress.XtraEditors.LabelControl();
            this.lblHora = new DevExpress.XtraEditors.LabelControl();
            this.lblHoraActual = new DevExpress.XtraEditors.LabelControl();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.barManager3 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnActualizarProducto = new DevExpress.XtraBars.BarButtonItem();
            this.btnNuevoProducto = new DevExpress.XtraBars.BarButtonItem();
            this.btnModificarProducto = new DevExpress.XtraBars.BarButtonItem();
            this.btnEliminarProducto = new DevExpress.XtraBars.BarButtonItem();
            this.skinBarSubItem2 = new DevExpress.XtraBars.SkinBarSubItem();
            this.barDockControl5 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl6 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl7 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl8 = new DevExpress.XtraBars.BarDockControl();
            this.skinBarSubItem1 = new DevExpress.XtraBars.SkinBarSubItem();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager3)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.cbCliente);
            this.groupControl1.Controls.Add(this.lblCliente);
            this.groupControl1.Controls.Add(this.lblPrecioVenta);
            this.groupControl1.Controls.Add(this.lblPrecioProducto);
            this.groupControl1.Controls.Add(this.textEdit1);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.comboBox2);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.cbProducto);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(24, 116);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1066, 231);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Area de ventas";
            // 
            // cbCliente
            // 
            this.cbCliente.FormattingEnabled = true;
            this.cbCliente.Location = new System.Drawing.Point(95, 66);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new System.Drawing.Size(121, 21);
            this.cbCliente.TabIndex = 9;
            // 
            // lblCliente
            // 
            this.lblCliente.Location = new System.Drawing.Point(14, 69);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(37, 13);
            this.lblCliente.TabIndex = 8;
            this.lblCliente.Text = "Cliente:";
            // 
            // lblPrecioVenta
            // 
            this.lblPrecioVenta.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblPrecioVenta.Appearance.Options.UseFont = true;
            this.lblPrecioVenta.Location = new System.Drawing.Point(515, 97);
            this.lblPrecioVenta.Name = "lblPrecioVenta";
            this.lblPrecioVenta.Size = new System.Drawing.Size(5, 13);
            this.lblPrecioVenta.TabIndex = 7;
            this.lblPrecioVenta.Text = "-";
            // 
            // lblPrecioProducto
            // 
            this.lblPrecioProducto.Location = new System.Drawing.Point(413, 96);
            this.lblPrecioProducto.Name = "lblPrecioProducto";
            this.lblPrecioProducto.Size = new System.Drawing.Size(96, 13);
            this.lblPrecioProducto.TabIndex = 6;
            this.lblPrecioProducto.Text = "Precio del producto:";
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(289, 94);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(100, 20);
            this.textEdit1.TabIndex = 5;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(236, 96);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(47, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Cantidad:";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(95, 120);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(14, 123);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(66, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Tipo de pago:";
            // 
            // cbProducto
            // 
            this.cbProducto.FormattingEnabled = true;
            this.cbProducto.Location = new System.Drawing.Point(95, 93);
            this.cbProducto.Name = "cbProducto";
            this.cbProducto.Size = new System.Drawing.Size(121, 21);
            this.cbProducto.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(14, 96);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(47, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Producto:";
            // 
            // lblFecha
            // 
            this.lblFecha.Location = new System.Drawing.Point(24, 59);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(33, 13);
            this.lblFecha.TabIndex = 6;
            this.lblFecha.Text = "Fecha:";
            // 
            // lblFechaActual
            // 
            this.lblFechaActual.Location = new System.Drawing.Point(63, 59);
            this.lblFechaActual.Name = "lblFechaActual";
            this.lblFechaActual.Size = new System.Drawing.Size(4, 13);
            this.lblFechaActual.TabIndex = 6;
            this.lblFechaActual.Text = "-";
            // 
            // lblHora
            // 
            this.lblHora.Location = new System.Drawing.Point(24, 78);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(27, 13);
            this.lblHora.TabIndex = 7;
            this.lblHora.Text = "Hora:";
            // 
            // lblHoraActual
            // 
            this.lblHoraActual.Location = new System.Drawing.Point(63, 78);
            this.lblHoraActual.Name = "lblHoraActual";
            this.lblHoraActual.Size = new System.Drawing.Size(4, 13);
            this.lblHoraActual.TabIndex = 8;
            this.lblHoraActual.Text = "-";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(24, 393);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1066, 253);
            this.listView1.TabIndex = 9;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "PRODUCTO";
            this.columnHeader1.Width = 101;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "CANTIDAD";
            this.columnHeader2.Width = 126;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "PRECIO";
            this.columnHeader3.Width = 88;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "TIPO DE PAGO";
            this.columnHeader4.Width = 108;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "DESCUENTO";
            this.columnHeader5.Width = 115;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "RECARGO";
            this.columnHeader6.Width = 118;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "PRECIO FINAL";
            this.columnHeader7.Width = 113;
            // 
            // barManager3
            // 
            this.barManager3.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManager3.DockControls.Add(this.barDockControl5);
            this.barManager3.DockControls.Add(this.barDockControl6);
            this.barManager3.DockControls.Add(this.barDockControl7);
            this.barManager3.DockControls.Add(this.barDockControl8);
            this.barManager3.Form = this;
            this.barManager3.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnActualizarProducto,
            this.btnNuevoProducto,
            this.btnModificarProducto,
            this.btnEliminarProducto,
            this.skinBarSubItem1,
            this.skinBarSubItem2});
            this.barManager3.MaxItemId = 11;
            // 
            // bar1
            // 
            this.bar1.BarName = "Herramientas";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnActualizarProducto),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnNuevoProducto),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnModificarProducto),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnEliminarProducto),
            new DevExpress.XtraBars.LinkPersistInfo(this.skinBarSubItem2)});
            this.bar1.Text = "Herramientas";
            // 
            // btnActualizarProducto
            // 
            this.btnActualizarProducto.Caption = "Actualizar";
            this.btnActualizarProducto.Id = 0;
            this.btnActualizarProducto.Name = "btnActualizarProducto";
            // 
            // btnNuevoProducto
            // 
            this.btnNuevoProducto.Caption = "Nuevo";
            this.btnNuevoProducto.Id = 1;
            this.btnNuevoProducto.Name = "btnNuevoProducto";
            // 
            // btnModificarProducto
            // 
            this.btnModificarProducto.Caption = "Modificar";
            this.btnModificarProducto.Id = 2;
            this.btnModificarProducto.Name = "btnModificarProducto";
            // 
            // btnEliminarProducto
            // 
            this.btnEliminarProducto.Caption = "Eliminar";
            this.btnEliminarProducto.Id = 3;
            this.btnEliminarProducto.Name = "btnEliminarProducto";
            // 
            // skinBarSubItem2
            // 
            this.skinBarSubItem2.Caption = "Apariencia";
            this.skinBarSubItem2.Id = 10;
            this.skinBarSubItem2.Name = "skinBarSubItem2";
            // 
            // barDockControl5
            // 
            this.barDockControl5.CausesValidation = false;
            this.barDockControl5.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl5.Location = new System.Drawing.Point(0, 0);
            this.barDockControl5.Manager = this.barManager3;
            this.barDockControl5.Size = new System.Drawing.Size(1113, 20);
            // 
            // barDockControl6
            // 
            this.barDockControl6.CausesValidation = false;
            this.barDockControl6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControl6.Location = new System.Drawing.Point(0, 675);
            this.barDockControl6.Manager = this.barManager3;
            this.barDockControl6.Size = new System.Drawing.Size(1113, 0);
            // 
            // barDockControl7
            // 
            this.barDockControl7.CausesValidation = false;
            this.barDockControl7.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControl7.Location = new System.Drawing.Point(0, 20);
            this.barDockControl7.Manager = this.barManager3;
            this.barDockControl7.Size = new System.Drawing.Size(0, 655);
            // 
            // barDockControl8
            // 
            this.barDockControl8.CausesValidation = false;
            this.barDockControl8.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl8.Location = new System.Drawing.Point(1113, 20);
            this.barDockControl8.Manager = this.barManager3;
            this.barDockControl8.Size = new System.Drawing.Size(0, 655);
            // 
            // skinBarSubItem1
            // 
            this.skinBarSubItem1.Caption = "Apariencia";
            this.skinBarSubItem1.Id = 4;
            this.skinBarSubItem1.Name = "skinBarSubItem1";
            // 
            // frmVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 675);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.lblHoraActual);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.lblFechaActual);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.barDockControl7);
            this.Controls.Add(this.barDockControl8);
            this.Controls.Add(this.barDockControl6);
            this.Controls.Add(this.barDockControl5);
            this.Name = "frmVenta";
            this.Text = "Venta";
            this.Load += new System.EventHandler(this.frmVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.ComboBox cbProducto;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.ComboBox comboBox2;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl lblFecha;
        private DevExpress.XtraEditors.LabelControl lblFechaActual;
        private DevExpress.XtraEditors.LabelControl lblHora;
        private DevExpress.XtraEditors.LabelControl lblHoraActual;
        private System.Windows.Forms.Timer timer1;
        private DevExpress.XtraEditors.LabelControl lblPrecioVenta;
        private DevExpress.XtraEditors.LabelControl lblPrecioProducto;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ComboBox cbCliente;
        private DevExpress.XtraEditors.LabelControl lblCliente;
        private DevExpress.XtraBars.BarManager barManager3;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnActualizarProducto;
        private DevExpress.XtraBars.BarButtonItem btnNuevoProducto;
        private DevExpress.XtraBars.BarButtonItem btnModificarProducto;
        private DevExpress.XtraBars.BarButtonItem btnEliminarProducto;
        private DevExpress.XtraBars.SkinBarSubItem skinBarSubItem2;
        private DevExpress.XtraBars.BarDockControl barDockControl5;
        private DevExpress.XtraBars.BarDockControl barDockControl6;
        private DevExpress.XtraBars.BarDockControl barDockControl7;
        private DevExpress.XtraBars.BarDockControl barDockControl8;
        private DevExpress.XtraBars.SkinBarSubItem skinBarSubItem1;
    }
}