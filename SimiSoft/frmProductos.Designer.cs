
namespace SimiSoft
{
    partial class frmProductos
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
            this.bar6 = new DevExpress.XtraBars.Bar();
            this.bar5 = new DevExpress.XtraBars.Bar();
            this.bar4 = new DevExpress.XtraBars.Bar();
            this.gcProductos = new DevExpress.XtraGrid.GridControl();
            this.productoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvProductos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ColIdProducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColCodigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColCodigoBarras = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColDescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColMarca = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColUnidadMedida = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColPrecioCompra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColMargenGanancia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColPrecioVenta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColStock = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColStockMin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColStockMax = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColActivo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColIdCategoria = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColFechaRegistro = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.bar8 = new DevExpress.XtraBars.Bar();
            this.ColImagen = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gcProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager3)).BeginInit();
            this.SuspendLayout();
            // 
            // bar6
            // 
            this.bar6.BarName = "Barra de estado";
            this.bar6.DockCol = 0;
            this.bar6.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar6.Text = "Barra de estado";
            // 
            // bar5
            // 
            this.bar5.BarName = "Menú principal";
            this.bar5.DockCol = 0;
            this.bar5.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar5.Text = "Menú principal";
            // 
            // bar4
            // 
            this.bar4.BarName = "Herramientas";
            this.bar4.DockCol = 0;
            this.bar4.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar4.Text = "Herramientas";
            // 
            // gcProductos
            // 
            this.gcProductos.DataSource = this.productoBindingSource;
            this.gcProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcProductos.Location = new System.Drawing.Point(0, 20);
            this.gcProductos.MainView = this.gvProductos;
            this.gcProductos.Name = "gcProductos";
            this.gcProductos.Size = new System.Drawing.Size(1236, 548);
            this.gcProductos.TabIndex = 8;
            this.gcProductos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvProductos});
            this.gcProductos.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // productoBindingSource
            // 
            this.productoBindingSource.DataSource = typeof(FarmsRamirezBML.Producto);
            // 
            // gvProductos
            // 
            this.gvProductos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ColIdProducto,
            this.ColCodigo,
            this.ColCodigoBarras,
            this.ColNombre,
            this.ColDescripcion,
            this.ColMarca,
            this.ColUnidadMedida,
            this.ColPrecioCompra,
            this.ColMargenGanancia,
            this.ColPrecioVenta,
            this.ColStock,
            this.ColStockMin,
            this.ColStockMax,
            this.ColActivo,
            this.ColIdCategoria,
            this.ColFechaRegistro,
            this.ColImagen});
            this.gvProductos.GridControl = this.gcProductos;
            this.gvProductos.Name = "gvProductos";
            this.gvProductos.OptionsBehavior.Editable = false;
            this.gvProductos.OptionsView.ColumnAutoWidth = false;
            this.gvProductos.OptionsView.EnableAppearanceEvenRow = true;
            this.gvProductos.OptionsView.ShowAutoFilterRow = true;
            this.gvProductos.OptionsView.ShowGroupPanel = false;
            // 
            // ColIdProducto
            // 
            this.ColIdProducto.Caption = "IdProducto";
            this.ColIdProducto.FieldName = "IdProducto";
            this.ColIdProducto.Name = "ColIdProducto";
            this.ColIdProducto.OptionsColumn.AllowEdit = false;
            this.ColIdProducto.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.ColIdProducto.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.ColIdProducto.OptionsColumn.AllowMove = false;
            this.ColIdProducto.OptionsColumn.AllowSize = false;
            this.ColIdProducto.OptionsColumn.FixedWidth = true;
            this.ColIdProducto.Visible = true;
            this.ColIdProducto.VisibleIndex = 0;
            // 
            // ColCodigo
            // 
            this.ColCodigo.Caption = "Codigo";
            this.ColCodigo.FieldName = "Codigo";
            this.ColCodigo.Name = "ColCodigo";
            this.ColCodigo.OptionsColumn.AllowEdit = false;
            this.ColCodigo.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.ColCodigo.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.ColCodigo.OptionsColumn.AllowMove = false;
            this.ColCodigo.OptionsColumn.AllowSize = false;
            this.ColCodigo.OptionsColumn.FixedWidth = true;
            this.ColCodigo.Visible = true;
            this.ColCodigo.VisibleIndex = 1;
            // 
            // ColCodigoBarras
            // 
            this.ColCodigoBarras.Caption = "CodigoBarras";
            this.ColCodigoBarras.FieldName = "CodigoBarras";
            this.ColCodigoBarras.Name = "ColCodigoBarras";
            this.ColCodigoBarras.OptionsColumn.AllowEdit = false;
            this.ColCodigoBarras.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.ColCodigoBarras.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.ColCodigoBarras.OptionsColumn.AllowMove = false;
            this.ColCodigoBarras.OptionsColumn.AllowSize = false;
            this.ColCodigoBarras.OptionsColumn.FixedWidth = true;
            this.ColCodigoBarras.Visible = true;
            this.ColCodigoBarras.VisibleIndex = 2;
            // 
            // ColNombre
            // 
            this.ColNombre.Caption = "Nombre";
            this.ColNombre.FieldName = "Nombre";
            this.ColNombre.Name = "ColNombre";
            this.ColNombre.OptionsColumn.AllowEdit = false;
            this.ColNombre.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.ColNombre.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.ColNombre.OptionsColumn.AllowMove = false;
            this.ColNombre.OptionsColumn.AllowSize = false;
            this.ColNombre.OptionsColumn.FixedWidth = true;
            this.ColNombre.Visible = true;
            this.ColNombre.VisibleIndex = 3;
            // 
            // ColDescripcion
            // 
            this.ColDescripcion.Caption = "Descripcion";
            this.ColDescripcion.FieldName = "Descripcion";
            this.ColDescripcion.Name = "ColDescripcion";
            this.ColDescripcion.OptionsColumn.AllowEdit = false;
            this.ColDescripcion.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.ColDescripcion.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.ColDescripcion.OptionsColumn.AllowMove = false;
            this.ColDescripcion.OptionsColumn.AllowSize = false;
            this.ColDescripcion.OptionsColumn.FixedWidth = true;
            this.ColDescripcion.Visible = true;
            this.ColDescripcion.VisibleIndex = 4;
            // 
            // ColMarca
            // 
            this.ColMarca.Caption = "Marca";
            this.ColMarca.FieldName = "Marca";
            this.ColMarca.Name = "ColMarca";
            this.ColMarca.OptionsColumn.AllowEdit = false;
            this.ColMarca.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.ColMarca.OptionsColumn.AllowMove = false;
            this.ColMarca.OptionsColumn.AllowSize = false;
            this.ColMarca.OptionsColumn.FixedWidth = true;
            this.ColMarca.Visible = true;
            this.ColMarca.VisibleIndex = 5;
            // 
            // ColUnidadMedida
            // 
            this.ColUnidadMedida.Caption = "UnidadMedida";
            this.ColUnidadMedida.FieldName = "UnidadMedida";
            this.ColUnidadMedida.Name = "ColUnidadMedida";
            this.ColUnidadMedida.OptionsColumn.AllowEdit = false;
            this.ColUnidadMedida.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.ColUnidadMedida.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.ColUnidadMedida.OptionsColumn.AllowMove = false;
            this.ColUnidadMedida.OptionsColumn.AllowSize = false;
            this.ColUnidadMedida.OptionsColumn.FixedWidth = true;
            this.ColUnidadMedida.Visible = true;
            this.ColUnidadMedida.VisibleIndex = 6;
            // 
            // ColPrecioCompra
            // 
            this.ColPrecioCompra.Caption = "PrecioCompra";
            this.ColPrecioCompra.FieldName = "PrecioCompra";
            this.ColPrecioCompra.Name = "ColPrecioCompra";
            this.ColPrecioCompra.OptionsColumn.AllowEdit = false;
            this.ColPrecioCompra.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.ColPrecioCompra.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.ColPrecioCompra.OptionsColumn.AllowMove = false;
            this.ColPrecioCompra.OptionsColumn.AllowSize = false;
            this.ColPrecioCompra.OptionsColumn.FixedWidth = true;
            this.ColPrecioCompra.Visible = true;
            this.ColPrecioCompra.VisibleIndex = 7;
            // 
            // ColMargenGanancia
            // 
            this.ColMargenGanancia.Caption = "MargenGanancia";
            this.ColMargenGanancia.FieldName = "MargenGanancia";
            this.ColMargenGanancia.Name = "ColMargenGanancia";
            this.ColMargenGanancia.OptionsColumn.AllowEdit = false;
            this.ColMargenGanancia.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.ColMargenGanancia.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.ColMargenGanancia.OptionsColumn.AllowMove = false;
            this.ColMargenGanancia.OptionsColumn.AllowSize = false;
            this.ColMargenGanancia.OptionsColumn.FixedWidth = true;
            this.ColMargenGanancia.Visible = true;
            this.ColMargenGanancia.VisibleIndex = 8;
            // 
            // ColPrecioVenta
            // 
            this.ColPrecioVenta.Caption = "PrecioVenta";
            this.ColPrecioVenta.FieldName = "PrecioVenta";
            this.ColPrecioVenta.Name = "ColPrecioVenta";
            this.ColPrecioVenta.OptionsColumn.AllowEdit = false;
            this.ColPrecioVenta.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.ColPrecioVenta.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.ColPrecioVenta.OptionsColumn.AllowMove = false;
            this.ColPrecioVenta.OptionsColumn.AllowSize = false;
            this.ColPrecioVenta.OptionsColumn.FixedWidth = true;
            this.ColPrecioVenta.Visible = true;
            this.ColPrecioVenta.VisibleIndex = 9;
            // 
            // ColStock
            // 
            this.ColStock.Caption = "Stock";
            this.ColStock.FieldName = "Stock";
            this.ColStock.Name = "ColStock";
            this.ColStock.OptionsColumn.AllowEdit = false;
            this.ColStock.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.ColStock.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.ColStock.OptionsColumn.AllowMove = false;
            this.ColStock.OptionsColumn.AllowSize = false;
            this.ColStock.OptionsColumn.FixedWidth = true;
            this.ColStock.Visible = true;
            this.ColStock.VisibleIndex = 10;
            // 
            // ColStockMin
            // 
            this.ColStockMin.Caption = "StockMin";
            this.ColStockMin.FieldName = "StockMin";
            this.ColStockMin.Name = "ColStockMin";
            this.ColStockMin.OptionsColumn.AllowEdit = false;
            this.ColStockMin.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.ColStockMin.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.ColStockMin.OptionsColumn.AllowMove = false;
            this.ColStockMin.OptionsColumn.AllowSize = false;
            this.ColStockMin.OptionsColumn.FixedWidth = true;
            this.ColStockMin.Visible = true;
            this.ColStockMin.VisibleIndex = 11;
            // 
            // ColStockMax
            // 
            this.ColStockMax.Caption = "StockMax";
            this.ColStockMax.FieldName = "StockMax";
            this.ColStockMax.Name = "ColStockMax";
            this.ColStockMax.OptionsColumn.AllowEdit = false;
            this.ColStockMax.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.ColStockMax.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.ColStockMax.OptionsColumn.AllowMove = false;
            this.ColStockMax.OptionsColumn.AllowSize = false;
            this.ColStockMax.OptionsColumn.FixedWidth = true;
            this.ColStockMax.Visible = true;
            this.ColStockMax.VisibleIndex = 12;
            // 
            // ColActivo
            // 
            this.ColActivo.Caption = "Activo";
            this.ColActivo.FieldName = "Activo";
            this.ColActivo.Name = "ColActivo";
            // 
            // ColIdCategoria
            // 
            this.ColIdCategoria.Caption = "IdCategoria";
            this.ColIdCategoria.FieldName = "IdCategoria";
            this.ColIdCategoria.Name = "ColIdCategoria";
            // 
            // ColFechaRegistro
            // 
            this.ColFechaRegistro.Caption = "FechaRegistro";
            this.ColFechaRegistro.FieldName = "FechaRegistro";
            this.ColFechaRegistro.Name = "ColFechaRegistro";
            this.ColFechaRegistro.Visible = true;
            this.ColFechaRegistro.VisibleIndex = 13;
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
            this.btnActualizarProducto.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnActualizarProducto_ItemClick);
            // 
            // btnNuevoProducto
            // 
            this.btnNuevoProducto.Caption = "Nuevo";
            this.btnNuevoProducto.Id = 1;
            this.btnNuevoProducto.Name = "btnNuevoProducto";
            this.btnNuevoProducto.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNuevoProducto_ItemClick);
            // 
            // btnModificarProducto
            // 
            this.btnModificarProducto.Caption = "Modificar";
            this.btnModificarProducto.Id = 2;
            this.btnModificarProducto.Name = "btnModificarProducto";
            this.btnModificarProducto.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnModificarProducto_ItemClick);
            // 
            // btnEliminarProducto
            // 
            this.btnEliminarProducto.Caption = "Eliminar";
            this.btnEliminarProducto.Id = 3;
            this.btnEliminarProducto.Name = "btnEliminarProducto";
            this.btnEliminarProducto.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEliminarProducto_ItemClick);
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
            this.barDockControl5.Size = new System.Drawing.Size(1236, 20);
            // 
            // barDockControl6
            // 
            this.barDockControl6.CausesValidation = false;
            this.barDockControl6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControl6.Location = new System.Drawing.Point(0, 568);
            this.barDockControl6.Manager = this.barManager3;
            this.barDockControl6.Size = new System.Drawing.Size(1236, 0);
            // 
            // barDockControl7
            // 
            this.barDockControl7.CausesValidation = false;
            this.barDockControl7.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControl7.Location = new System.Drawing.Point(0, 20);
            this.barDockControl7.Manager = this.barManager3;
            this.barDockControl7.Size = new System.Drawing.Size(0, 548);
            // 
            // barDockControl8
            // 
            this.barDockControl8.CausesValidation = false;
            this.barDockControl8.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl8.Location = new System.Drawing.Point(1236, 20);
            this.barDockControl8.Manager = this.barManager3;
            this.barDockControl8.Size = new System.Drawing.Size(0, 548);
            // 
            // skinBarSubItem1
            // 
            this.skinBarSubItem1.Caption = "Apariencia";
            this.skinBarSubItem1.Id = 4;
            this.skinBarSubItem1.Name = "skinBarSubItem1";
            // 
            // bar8
            // 
            this.bar8.BarName = "Barra de estado";
            this.bar8.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar8.DockCol = 0;
            this.bar8.DockRow = 0;
            this.bar8.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar8.OptionsBar.AllowQuickCustomization = false;
            this.bar8.OptionsBar.DrawDragBorder = false;
            this.bar8.OptionsBar.UseWholeRow = true;
            this.bar8.Text = "Barra de estado";
            // 
            // ColImagen
            // 
            this.ColImagen.Caption = "Imagen";
            this.ColImagen.FieldName = "Imagen";
            this.ColImagen.Name = "ColImagen";
            this.ColImagen.Visible = true;
            this.ColImagen.VisibleIndex = 14;
            // 
            // frmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 568);
            this.Controls.Add(this.gcProductos);
            this.Controls.Add(this.barDockControl7);
            this.Controls.Add(this.barDockControl8);
            this.Controls.Add(this.barDockControl6);
            this.Controls.Add(this.barDockControl5);
            this.Name = "frmProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.frmProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraGrid.GridControl gcProductos;
        private DevExpress.XtraGrid.Views.Grid.GridView gvProductos;
        private DevExpress.XtraBars.Bar bar6;
        private DevExpress.XtraBars.Bar bar5;
        private DevExpress.XtraBars.Bar bar4;
        private System.Windows.Forms.BindingSource productoBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn ColIdProducto;
        private DevExpress.XtraGrid.Columns.GridColumn ColDescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn ColUnidadMedida;
        private DevExpress.XtraGrid.Columns.GridColumn ColCodigo;
        private DevExpress.XtraGrid.Columns.GridColumn ColPrecioCompra;
        private DevExpress.XtraGrid.Columns.GridColumn ColStock;
        private DevExpress.XtraGrid.Columns.GridColumn ColMarca;
        private DevExpress.XtraGrid.Columns.GridColumn ColActivo;
        private DevExpress.XtraBars.BarDockControl barDockControl7;
        private DevExpress.XtraBars.BarManager barManager3;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnActualizarProducto;
        private DevExpress.XtraBars.BarButtonItem btnNuevoProducto;
        private DevExpress.XtraBars.BarButtonItem btnModificarProducto;
        private DevExpress.XtraBars.BarButtonItem btnEliminarProducto;
        private DevExpress.XtraBars.BarDockControl barDockControl5;
        private DevExpress.XtraBars.BarDockControl barDockControl6;
        private DevExpress.XtraBars.BarDockControl barDockControl8;
        private DevExpress.XtraBars.SkinBarSubItem skinBarSubItem1;
        private DevExpress.XtraGrid.Columns.GridColumn ColCodigoBarras;
        private DevExpress.XtraGrid.Columns.GridColumn ColNombre;
        private DevExpress.XtraGrid.Columns.GridColumn ColMargenGanancia;
        private DevExpress.XtraGrid.Columns.GridColumn ColPrecioVenta;
        private DevExpress.XtraGrid.Columns.GridColumn ColStockMin;
        private DevExpress.XtraGrid.Columns.GridColumn ColStockMax;
        private DevExpress.XtraBars.Bar bar8;
        private DevExpress.XtraBars.SkinBarSubItem skinBarSubItem2;
        private DevExpress.XtraGrid.Columns.GridColumn ColIdCategoria;
        private DevExpress.XtraGrid.Columns.GridColumn ColFechaRegistro;
        private DevExpress.XtraGrid.Columns.GridColumn ColImagen;
    }
}