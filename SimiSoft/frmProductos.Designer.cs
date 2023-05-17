
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
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.barSubItem2 = new DevExpress.XtraBars.BarSubItem();
            this.barSubItem3 = new DevExpress.XtraBars.BarSubItem();
            this.barSubItem4 = new DevExpress.XtraBars.BarSubItem();
            this.barManager2 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl2 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl3 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl4 = new DevExpress.XtraBars.BarDockControl();
            this.bar6 = new DevExpress.XtraBars.Bar();
            this.bar5 = new DevExpress.XtraBars.Bar();
            this.bar4 = new DevExpress.XtraBars.Bar();
            this.gcProductos = new DevExpress.XtraGrid.GridControl();
            this.productoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvProductos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colProductoID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodigoBarra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMarca = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnidadMedida = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrecioCompra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMargenGanancia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrecioVenta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStock = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStockMin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStockMax = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barManager3 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnActualizarProducto = new DevExpress.XtraBars.BarButtonItem();
            this.btnNuevoProducto = new DevExpress.XtraBars.BarButtonItem();
            this.btnModificarProducto = new DevExpress.XtraBars.BarButtonItem();
            this.btnEliminarProducto = new DevExpress.XtraBars.BarButtonItem();
            this.skinBarSubItem1 = new DevExpress.XtraBars.SkinBarSubItem();
            this.bar8 = new DevExpress.XtraBars.Bar();
            this.barDockControl5 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl6 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl7 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl8 = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager3)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barSubItem1,
            this.barSubItem2,
            this.barSubItem3,
            this.barSubItem4});
            this.barManager1.MaxItemId = 4;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 20);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1236, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 548);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1236, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 20);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 528);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1236, 20);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 528);
            // 
            // barSubItem1
            // 
            this.barSubItem1.Caption = "Actualizar";
            this.barSubItem1.Id = 0;
            this.barSubItem1.Name = "barSubItem1";
            // 
            // barSubItem2
            // 
            this.barSubItem2.Caption = "Nuevo";
            this.barSubItem2.Id = 1;
            this.barSubItem2.Name = "barSubItem2";
            // 
            // barSubItem3
            // 
            this.barSubItem3.Caption = "Modificar";
            this.barSubItem3.Id = 2;
            this.barSubItem3.Name = "barSubItem3";
            // 
            // barSubItem4
            // 
            this.barSubItem4.Caption = "Eliminar";
            this.barSubItem4.Id = 3;
            this.barSubItem4.Name = "barSubItem4";
            // 
            // barManager2
            // 
            this.barManager2.DockControls.Add(this.barDockControl1);
            this.barManager2.DockControls.Add(this.barDockControl2);
            this.barManager2.DockControls.Add(this.barDockControl3);
            this.barManager2.DockControls.Add(this.barDockControl4);
            this.barManager2.Form = this;
            // 
            // barDockControl1
            // 
            this.barDockControl1.CausesValidation = false;
            this.barDockControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl1.Location = new System.Drawing.Point(0, 20);
            this.barDockControl1.Manager = this.barManager2;
            this.barDockControl1.Size = new System.Drawing.Size(1236, 0);
            // 
            // barDockControl2
            // 
            this.barDockControl2.CausesValidation = false;
            this.barDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControl2.Location = new System.Drawing.Point(0, 548);
            this.barDockControl2.Manager = this.barManager2;
            this.barDockControl2.Size = new System.Drawing.Size(1236, 0);
            // 
            // barDockControl3
            // 
            this.barDockControl3.CausesValidation = false;
            this.barDockControl3.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControl3.Location = new System.Drawing.Point(0, 20);
            this.barDockControl3.Manager = this.barManager2;
            this.barDockControl3.Size = new System.Drawing.Size(0, 528);
            // 
            // barDockControl4
            // 
            this.barDockControl4.CausesValidation = false;
            this.barDockControl4.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl4.Location = new System.Drawing.Point(1236, 20);
            this.barDockControl4.Manager = this.barManager2;
            this.barDockControl4.Size = new System.Drawing.Size(0, 528);
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
            this.gcProductos.MenuManager = this.barManager1;
            this.gcProductos.Name = "gcProductos";
            this.gcProductos.Size = new System.Drawing.Size(1236, 528);
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
            this.colProductoID,
            this.colCodigo,
            this.colCodigoBarra,
            this.colNombre,
            this.colDescripcion,
            this.colMarca,
            this.colUnidadMedida,
            this.colPrecioCompra,
            this.colMargenGanancia,
            this.colPrecioVenta,
            this.colStock,
            this.colStockMin,
            this.colStockMax,
            this.colStatus});
            this.gvProductos.GridControl = this.gcProductos;
            this.gvProductos.Name = "gvProductos";
            this.gvProductos.OptionsBehavior.Editable = false;
            this.gvProductos.OptionsView.ColumnAutoWidth = false;
            this.gvProductos.OptionsView.EnableAppearanceEvenRow = true;
            this.gvProductos.OptionsView.ShowAutoFilterRow = true;
            this.gvProductos.OptionsView.ShowGroupPanel = false;
            // 
            // colProductoID
            // 
            this.colProductoID.Caption = "ProductoID";
            this.colProductoID.FieldName = "productoID";
            this.colProductoID.Name = "colProductoID";
            this.colProductoID.OptionsColumn.AllowEdit = false;
            this.colProductoID.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colProductoID.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colProductoID.OptionsColumn.AllowMove = false;
            this.colProductoID.OptionsColumn.AllowSize = false;
            this.colProductoID.OptionsColumn.FixedWidth = true;
            this.colProductoID.Visible = true;
            this.colProductoID.VisibleIndex = 0;
            // 
            // colCodigo
            // 
            this.colCodigo.Caption = "Codigo";
            this.colCodigo.FieldName = "codigo";
            this.colCodigo.Name = "colCodigo";
            this.colCodigo.OptionsColumn.AllowEdit = false;
            this.colCodigo.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colCodigo.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colCodigo.OptionsColumn.AllowMove = false;
            this.colCodigo.OptionsColumn.AllowSize = false;
            this.colCodigo.OptionsColumn.FixedWidth = true;
            this.colCodigo.Visible = true;
            this.colCodigo.VisibleIndex = 1;
            // 
            // colCodigoBarra
            // 
            this.colCodigoBarra.Caption = "CodigoBarra";
            this.colCodigoBarra.FieldName = "codigoBarra";
            this.colCodigoBarra.Name = "colCodigoBarra";
            this.colCodigoBarra.OptionsColumn.AllowEdit = false;
            this.colCodigoBarra.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colCodigoBarra.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colCodigoBarra.OptionsColumn.AllowMove = false;
            this.colCodigoBarra.OptionsColumn.AllowSize = false;
            this.colCodigoBarra.OptionsColumn.FixedWidth = true;
            this.colCodigoBarra.Visible = true;
            this.colCodigoBarra.VisibleIndex = 2;
            // 
            // colNombre
            // 
            this.colNombre.Caption = "Nombre";
            this.colNombre.FieldName = "nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.OptionsColumn.AllowEdit = false;
            this.colNombre.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colNombre.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colNombre.OptionsColumn.AllowMove = false;
            this.colNombre.OptionsColumn.AllowSize = false;
            this.colNombre.OptionsColumn.FixedWidth = true;
            this.colNombre.Visible = true;
            this.colNombre.VisibleIndex = 3;
            // 
            // colDescripcion
            // 
            this.colDescripcion.Caption = "Descripcion";
            this.colDescripcion.FieldName = "descripcion";
            this.colDescripcion.Name = "colDescripcion";
            this.colDescripcion.OptionsColumn.AllowEdit = false;
            this.colDescripcion.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colDescripcion.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colDescripcion.OptionsColumn.AllowMove = false;
            this.colDescripcion.OptionsColumn.AllowSize = false;
            this.colDescripcion.OptionsColumn.FixedWidth = true;
            this.colDescripcion.Visible = true;
            this.colDescripcion.VisibleIndex = 4;
            // 
            // colMarca
            // 
            this.colMarca.Caption = "Marca";
            this.colMarca.FieldName = "marca";
            this.colMarca.Name = "colMarca";
            this.colMarca.OptionsColumn.AllowEdit = false;
            this.colMarca.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colMarca.OptionsColumn.AllowMove = false;
            this.colMarca.OptionsColumn.AllowSize = false;
            this.colMarca.OptionsColumn.FixedWidth = true;
            this.colMarca.Visible = true;
            this.colMarca.VisibleIndex = 5;
            // 
            // colUnidadMedida
            // 
            this.colUnidadMedida.Caption = "UnidadMedida";
            this.colUnidadMedida.FieldName = "unidadMedida";
            this.colUnidadMedida.Name = "colUnidadMedida";
            this.colUnidadMedida.OptionsColumn.AllowEdit = false;
            this.colUnidadMedida.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colUnidadMedida.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colUnidadMedida.OptionsColumn.AllowMove = false;
            this.colUnidadMedida.OptionsColumn.AllowSize = false;
            this.colUnidadMedida.OptionsColumn.FixedWidth = true;
            this.colUnidadMedida.Visible = true;
            this.colUnidadMedida.VisibleIndex = 6;
            // 
            // colPrecioCompra
            // 
            this.colPrecioCompra.Caption = "PrecioCompra";
            this.colPrecioCompra.FieldName = "precioCompra";
            this.colPrecioCompra.Name = "colPrecioCompra";
            this.colPrecioCompra.OptionsColumn.AllowEdit = false;
            this.colPrecioCompra.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colPrecioCompra.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colPrecioCompra.OptionsColumn.AllowMove = false;
            this.colPrecioCompra.OptionsColumn.AllowSize = false;
            this.colPrecioCompra.OptionsColumn.FixedWidth = true;
            this.colPrecioCompra.Visible = true;
            this.colPrecioCompra.VisibleIndex = 7;
            // 
            // colMargenGanancia
            // 
            this.colMargenGanancia.Caption = "MargenGanancia";
            this.colMargenGanancia.FieldName = "margenGanancia";
            this.colMargenGanancia.Name = "colMargenGanancia";
            this.colMargenGanancia.OptionsColumn.AllowEdit = false;
            this.colMargenGanancia.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colMargenGanancia.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colMargenGanancia.OptionsColumn.AllowMove = false;
            this.colMargenGanancia.OptionsColumn.AllowSize = false;
            this.colMargenGanancia.OptionsColumn.FixedWidth = true;
            this.colMargenGanancia.Visible = true;
            this.colMargenGanancia.VisibleIndex = 8;
            // 
            // colPrecioVenta
            // 
            this.colPrecioVenta.Caption = "PrecioVenta";
            this.colPrecioVenta.FieldName = "precioVenta";
            this.colPrecioVenta.Name = "colPrecioVenta";
            this.colPrecioVenta.OptionsColumn.AllowEdit = false;
            this.colPrecioVenta.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colPrecioVenta.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colPrecioVenta.OptionsColumn.AllowMove = false;
            this.colPrecioVenta.OptionsColumn.AllowSize = false;
            this.colPrecioVenta.OptionsColumn.FixedWidth = true;
            this.colPrecioVenta.Visible = true;
            this.colPrecioVenta.VisibleIndex = 9;
            // 
            // colStock
            // 
            this.colStock.Caption = "Stock";
            this.colStock.FieldName = "stock";
            this.colStock.Name = "colStock";
            this.colStock.OptionsColumn.AllowEdit = false;
            this.colStock.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colStock.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colStock.OptionsColumn.AllowMove = false;
            this.colStock.OptionsColumn.AllowSize = false;
            this.colStock.OptionsColumn.FixedWidth = true;
            this.colStock.Visible = true;
            this.colStock.VisibleIndex = 10;
            // 
            // colStockMin
            // 
            this.colStockMin.Caption = "StockMin";
            this.colStockMin.FieldName = "stockMin";
            this.colStockMin.Name = "colStockMin";
            this.colStockMin.OptionsColumn.AllowEdit = false;
            this.colStockMin.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colStockMin.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colStockMin.OptionsColumn.AllowMove = false;
            this.colStockMin.OptionsColumn.AllowSize = false;
            this.colStockMin.OptionsColumn.FixedWidth = true;
            this.colStockMin.Visible = true;
            this.colStockMin.VisibleIndex = 11;
            // 
            // colStockMax
            // 
            this.colStockMax.Caption = "StockMax";
            this.colStockMax.FieldName = "stockMax";
            this.colStockMax.Name = "colStockMax";
            this.colStockMax.OptionsColumn.AllowEdit = false;
            this.colStockMax.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colStockMax.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colStockMax.OptionsColumn.AllowMove = false;
            this.colStockMax.OptionsColumn.AllowSize = false;
            this.colStockMax.OptionsColumn.FixedWidth = true;
            this.colStockMax.Visible = true;
            this.colStockMax.VisibleIndex = 12;
            // 
            // colStatus
            // 
            this.colStatus.Caption = "Status";
            this.colStatus.FieldName = "status";
            this.colStatus.Name = "colStatus";
            // 
            // barManager3
            // 
            this.barManager3.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar8});
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
            this.skinBarSubItem1});
            this.barManager3.MaxItemId = 5;
            this.barManager3.StatusBar = this.bar8;
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
            new DevExpress.XtraBars.LinkPersistInfo(this.skinBarSubItem1)});
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
            this.barDockControl6.Location = new System.Drawing.Point(0, 548);
            this.barDockControl6.Manager = this.barManager3;
            this.barDockControl6.Size = new System.Drawing.Size(1236, 20);
            // 
            // barDockControl7
            // 
            this.barDockControl7.CausesValidation = false;
            this.barDockControl7.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControl7.Location = new System.Drawing.Point(0, 20);
            this.barDockControl7.Manager = this.barManager3;
            this.barDockControl7.Size = new System.Drawing.Size(0, 528);
            // 
            // barDockControl8
            // 
            this.barDockControl8.CausesValidation = false;
            this.barDockControl8.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl8.Location = new System.Drawing.Point(1236, 20);
            this.barDockControl8.Manager = this.barManager3;
            this.barDockControl8.Size = new System.Drawing.Size(0, 528);
            // 
            // frmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 568);
            this.Controls.Add(this.gcProductos);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Controls.Add(this.barDockControl3);
            this.Controls.Add(this.barDockControl4);
            this.Controls.Add(this.barDockControl2);
            this.Controls.Add(this.barDockControl1);
            this.Controls.Add(this.barDockControl7);
            this.Controls.Add(this.barDockControl8);
            this.Controls.Add(this.barDockControl6);
            this.Controls.Add(this.barDockControl5);
            this.Name = "frmProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.frmProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.BarSubItem barSubItem2;
        private DevExpress.XtraBars.BarSubItem barSubItem3;
        private DevExpress.XtraBars.BarSubItem barSubItem4;
        private DevExpress.XtraGrid.GridControl gcProductos;
        private DevExpress.XtraGrid.Views.Grid.GridView gvProductos;
        private DevExpress.XtraBars.BarDockControl barDockControl3;
        private DevExpress.XtraBars.BarManager barManager2;
        private DevExpress.XtraBars.BarDockControl barDockControl1;
        private DevExpress.XtraBars.BarDockControl barDockControl2;
        private DevExpress.XtraBars.BarDockControl barDockControl4;
        private DevExpress.XtraBars.Bar bar6;
        private DevExpress.XtraBars.Bar bar5;
        private DevExpress.XtraBars.Bar bar4;
        private System.Windows.Forms.BindingSource productoBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colProductoID;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colUnidadMedida;
        private DevExpress.XtraGrid.Columns.GridColumn colCodigo;
        private DevExpress.XtraGrid.Columns.GridColumn colPrecioCompra;
        private DevExpress.XtraGrid.Columns.GridColumn colStock;
        private DevExpress.XtraGrid.Columns.GridColumn colMarca;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        private DevExpress.XtraBars.BarDockControl barDockControl7;
        private DevExpress.XtraBars.BarManager barManager3;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnActualizarProducto;
        private DevExpress.XtraBars.BarButtonItem btnNuevoProducto;
        private DevExpress.XtraBars.BarButtonItem btnModificarProducto;
        private DevExpress.XtraBars.BarButtonItem btnEliminarProducto;
        private DevExpress.XtraBars.Bar bar8;
        private DevExpress.XtraBars.BarDockControl barDockControl5;
        private DevExpress.XtraBars.BarDockControl barDockControl6;
        private DevExpress.XtraBars.BarDockControl barDockControl8;
        private DevExpress.XtraBars.SkinBarSubItem skinBarSubItem1;
        private DevExpress.XtraGrid.Columns.GridColumn colCodigoBarra;
        private DevExpress.XtraGrid.Columns.GridColumn colNombre;
        private DevExpress.XtraGrid.Columns.GridColumn colMargenGanancia;
        private DevExpress.XtraGrid.Columns.GridColumn colPrecioVenta;
        private DevExpress.XtraGrid.Columns.GridColumn colStockMin;
        private DevExpress.XtraGrid.Columns.GridColumn colStockMax;
    }
}