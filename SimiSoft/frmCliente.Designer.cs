namespace SimiSoft
{
    partial class frmCliente
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colClienteID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombres = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colApellidoPaterno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colApellidoMaterno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCelular = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTelefonoFijo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCorreo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodigoPostal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCiudad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMunicipio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colColonia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCalle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumeroInterior = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumeroExterior = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
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
            this.barManager3.MaxItemId = 6;
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
            this.skinBarSubItem2.Id = 5;
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
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 20);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.barManager3;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1236, 548);
            this.gridControl1.TabIndex = 8;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colClienteID,
            this.colNombres,
            this.colApellidoPaterno,
            this.colApellidoMaterno,
            this.colCelular,
            this.colTelefonoFijo,
            this.colCorreo,
            this.colCodigoPostal,
            this.colEstado,
            this.colCiudad,
            this.colMunicipio,
            this.colColonia,
            this.colCalle,
            this.colNumeroInterior,
            this.colNumeroExterior,
            this.colStatus});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colClienteID
            // 
            this.colClienteID.Caption = "ClienteID";
            this.colClienteID.FieldName = "clienteID";
            this.colClienteID.Name = "colClienteID";
            this.colClienteID.OptionsColumn.AllowEdit = false;
            this.colClienteID.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colClienteID.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colClienteID.OptionsColumn.AllowMove = false;
            this.colClienteID.OptionsColumn.AllowSize = false;
            this.colClienteID.OptionsColumn.FixedWidth = true;
            this.colClienteID.Visible = true;
            this.colClienteID.VisibleIndex = 0;
            // 
            // colNombres
            // 
            this.colNombres.Caption = "Nombres";
            this.colNombres.FieldName = "nombres";
            this.colNombres.Name = "colNombres";
            this.colNombres.OptionsColumn.AllowEdit = false;
            this.colNombres.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colNombres.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colNombres.OptionsColumn.AllowMove = false;
            this.colNombres.OptionsColumn.AllowSize = false;
            this.colNombres.OptionsColumn.FixedWidth = true;
            this.colNombres.Visible = true;
            this.colNombres.VisibleIndex = 1;
            // 
            // colApellidoPaterno
            // 
            this.colApellidoPaterno.Caption = "ApellidoPaterno";
            this.colApellidoPaterno.FieldName = "apellidoP";
            this.colApellidoPaterno.Name = "colApellidoPaterno";
            this.colApellidoPaterno.OptionsColumn.AllowEdit = false;
            this.colApellidoPaterno.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colApellidoPaterno.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colApellidoPaterno.OptionsColumn.AllowMove = false;
            this.colApellidoPaterno.OptionsColumn.AllowSize = false;
            this.colApellidoPaterno.OptionsColumn.FixedWidth = true;
            this.colApellidoPaterno.Visible = true;
            this.colApellidoPaterno.VisibleIndex = 2;
            // 
            // colApellidoMaterno
            // 
            this.colApellidoMaterno.Caption = "ApellidoMaterno";
            this.colApellidoMaterno.FieldName = "apellidoM";
            this.colApellidoMaterno.Name = "colApellidoMaterno";
            this.colApellidoMaterno.OptionsColumn.AllowEdit = false;
            this.colApellidoMaterno.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colApellidoMaterno.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colApellidoMaterno.OptionsColumn.AllowMove = false;
            this.colApellidoMaterno.OptionsColumn.AllowSize = false;
            this.colApellidoMaterno.OptionsColumn.FixedWidth = true;
            this.colApellidoMaterno.Visible = true;
            this.colApellidoMaterno.VisibleIndex = 3;
            // 
            // colCelular
            // 
            this.colCelular.Caption = "Celular";
            this.colCelular.FieldName = "celular";
            this.colCelular.Name = "colCelular";
            this.colCelular.OptionsColumn.AllowEdit = false;
            this.colCelular.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colCelular.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colCelular.OptionsColumn.AllowMove = false;
            this.colCelular.OptionsColumn.AllowSize = false;
            this.colCelular.OptionsColumn.FixedWidth = true;
            this.colCelular.Visible = true;
            this.colCelular.VisibleIndex = 4;
            // 
            // colTelefonoFijo
            // 
            this.colTelefonoFijo.Caption = "TelefonoFijo";
            this.colTelefonoFijo.FieldName = "telFijo";
            this.colTelefonoFijo.Name = "colTelefonoFijo";
            this.colTelefonoFijo.OptionsColumn.AllowEdit = false;
            this.colTelefonoFijo.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colTelefonoFijo.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colTelefonoFijo.OptionsColumn.AllowMove = false;
            this.colTelefonoFijo.OptionsColumn.AllowSize = false;
            this.colTelefonoFijo.OptionsColumn.FixedWidth = true;
            this.colTelefonoFijo.Visible = true;
            this.colTelefonoFijo.VisibleIndex = 5;
            // 
            // colCorreo
            // 
            this.colCorreo.Caption = "Correo";
            this.colCorreo.FieldName = "correo";
            this.colCorreo.Name = "colCorreo";
            this.colCorreo.OptionsColumn.AllowEdit = false;
            this.colCorreo.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colCorreo.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colCorreo.OptionsColumn.AllowMove = false;
            this.colCorreo.OptionsColumn.AllowSize = false;
            this.colCorreo.OptionsColumn.FixedWidth = true;
            this.colCorreo.Visible = true;
            this.colCorreo.VisibleIndex = 6;
            // 
            // colCodigoPostal
            // 
            this.colCodigoPostal.Caption = "CodigoPostal";
            this.colCodigoPostal.FieldName = "codigoPostal";
            this.colCodigoPostal.Name = "colCodigoPostal";
            this.colCodigoPostal.OptionsColumn.AllowEdit = false;
            this.colCodigoPostal.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colCodigoPostal.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colCodigoPostal.OptionsColumn.AllowMove = false;
            this.colCodigoPostal.OptionsColumn.AllowSize = false;
            this.colCodigoPostal.OptionsColumn.FixedWidth = true;
            this.colCodigoPostal.Visible = true;
            this.colCodigoPostal.VisibleIndex = 7;
            // 
            // colEstado
            // 
            this.colEstado.Caption = "Estado";
            this.colEstado.FieldName = "estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.OptionsColumn.AllowEdit = false;
            this.colEstado.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colEstado.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colEstado.OptionsColumn.AllowMove = false;
            this.colEstado.OptionsColumn.AllowSize = false;
            this.colEstado.OptionsColumn.FixedWidth = true;
            this.colEstado.Visible = true;
            this.colEstado.VisibleIndex = 8;
            // 
            // colCiudad
            // 
            this.colCiudad.Caption = "Ciudad";
            this.colCiudad.FieldName = "ciudad";
            this.colCiudad.Name = "colCiudad";
            this.colCiudad.OptionsColumn.AllowEdit = false;
            this.colCiudad.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colCiudad.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colCiudad.OptionsColumn.AllowMove = false;
            this.colCiudad.OptionsColumn.AllowSize = false;
            this.colCiudad.OptionsColumn.FixedWidth = true;
            this.colCiudad.Visible = true;
            this.colCiudad.VisibleIndex = 9;
            // 
            // colMunicipio
            // 
            this.colMunicipio.Caption = "Municipio";
            this.colMunicipio.FieldName = "municipio";
            this.colMunicipio.Name = "colMunicipio";
            this.colMunicipio.OptionsColumn.AllowEdit = false;
            this.colMunicipio.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colMunicipio.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colMunicipio.OptionsColumn.AllowMove = false;
            this.colMunicipio.OptionsColumn.AllowSize = false;
            this.colMunicipio.OptionsColumn.FixedWidth = true;
            this.colMunicipio.Visible = true;
            this.colMunicipio.VisibleIndex = 10;
            // 
            // colColonia
            // 
            this.colColonia.Caption = "Colonia";
            this.colColonia.FieldName = "colonia";
            this.colColonia.Name = "colColonia";
            this.colColonia.OptionsColumn.AllowEdit = false;
            this.colColonia.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colColonia.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colColonia.OptionsColumn.AllowMove = false;
            this.colColonia.OptionsColumn.AllowSize = false;
            this.colColonia.OptionsColumn.FixedWidth = true;
            this.colColonia.Visible = true;
            this.colColonia.VisibleIndex = 11;
            // 
            // colCalle
            // 
            this.colCalle.Caption = "Calle";
            this.colCalle.FieldName = "calle";
            this.colCalle.Name = "colCalle";
            this.colCalle.OptionsColumn.AllowEdit = false;
            this.colCalle.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colCalle.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colCalle.OptionsColumn.AllowMove = false;
            this.colCalle.OptionsColumn.AllowSize = false;
            this.colCalle.OptionsColumn.FixedWidth = true;
            this.colCalle.Visible = true;
            this.colCalle.VisibleIndex = 12;
            // 
            // colNumeroInterior
            // 
            this.colNumeroInterior.Caption = "NumeroInterior";
            this.colNumeroInterior.FieldName = "nInterior";
            this.colNumeroInterior.Name = "colNumeroInterior";
            this.colNumeroInterior.OptionsColumn.AllowEdit = false;
            this.colNumeroInterior.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colNumeroInterior.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colNumeroInterior.OptionsColumn.AllowMove = false;
            this.colNumeroInterior.OptionsColumn.AllowSize = false;
            this.colNumeroInterior.OptionsColumn.FixedWidth = true;
            this.colNumeroInterior.Visible = true;
            this.colNumeroInterior.VisibleIndex = 13;
            // 
            // colNumeroExterior
            // 
            this.colNumeroExterior.Caption = "NumeroExterior";
            this.colNumeroExterior.FieldName = "nExterior";
            this.colNumeroExterior.Name = "colNumeroExterior";
            this.colNumeroExterior.OptionsColumn.AllowEdit = false;
            this.colNumeroExterior.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colNumeroExterior.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colNumeroExterior.OptionsColumn.AllowMove = false;
            this.colNumeroExterior.OptionsColumn.AllowSize = false;
            this.colNumeroExterior.OptionsColumn.FixedWidth = true;
            this.colNumeroExterior.Visible = true;
            this.colNumeroExterior.VisibleIndex = 14;
            // 
            // colStatus
            // 
            this.colStatus.Caption = "Status";
            this.colStatus.FieldName = "status";
            this.colStatus.Name = "colStatus";
            this.colStatus.OptionsColumn.AllowEdit = false;
            this.colStatus.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colStatus.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colStatus.OptionsColumn.AllowMove = false;
            this.colStatus.OptionsColumn.AllowSize = false;
            this.colStatus.OptionsColumn.FixedWidth = true;
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 568);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.barDockControl7);
            this.Controls.Add(this.barDockControl8);
            this.Controls.Add(this.barDockControl6);
            this.Controls.Add(this.barDockControl5);
            this.Name = "frmCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.barManager3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraBars.SkinBarSubItem skinBarSubItem1;
        private DevExpress.XtraGrid.Columns.GridColumn colClienteID;
        private DevExpress.XtraGrid.Columns.GridColumn colNombres;
        private DevExpress.XtraGrid.Columns.GridColumn colApellidoPaterno;
        private DevExpress.XtraGrid.Columns.GridColumn colApellidoMaterno;
        private DevExpress.XtraGrid.Columns.GridColumn colCelular;
        private DevExpress.XtraGrid.Columns.GridColumn colTelefonoFijo;
        private DevExpress.XtraGrid.Columns.GridColumn colCorreo;
        private DevExpress.XtraGrid.Columns.GridColumn colCodigoPostal;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado;
        private DevExpress.XtraGrid.Columns.GridColumn colCiudad;
        private DevExpress.XtraGrid.Columns.GridColumn colMunicipio;
        private DevExpress.XtraGrid.Columns.GridColumn colColonia;
        private DevExpress.XtraGrid.Columns.GridColumn colCalle;
        private DevExpress.XtraGrid.Columns.GridColumn colNumeroInterior;
        private DevExpress.XtraGrid.Columns.GridColumn colNumeroExterior;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
    }
}