namespace SimiSoft
{
    partial class frmProveedores
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
            this.gcProveedores = new DevExpress.XtraGrid.GridControl();
            this.gvProveedores = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colProveedorID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombreEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodigoPostal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCiudad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMunicipio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colColonia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCalle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNInterior = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNExterior = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCelular = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTelFijo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCorreo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPaginaWeb = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombreRepresentante = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCorreoRepresentante = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCelularRepresentante = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTelFijoRepresentante = new DevExpress.XtraGrid.Columns.GridColumn();
            this.proveedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.barManager3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcProveedores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProveedores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource)).BeginInit();
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
            // gcProveedores
            // 
            this.gcProveedores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcProveedores.Location = new System.Drawing.Point(0, 20);
            this.gcProveedores.MainView = this.gvProveedores;
            this.gcProveedores.MenuManager = this.barManager3;
            this.gcProveedores.Name = "gcProveedores";
            this.gcProveedores.Size = new System.Drawing.Size(1236, 548);
            this.gcProveedores.TabIndex = 8;
            this.gcProveedores.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvProveedores});
            this.gcProveedores.Click += new System.EventHandler(this.gcProveedores_Click);
            // 
            // gvProveedores
            // 
            this.gvProveedores.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colProveedorID,
            this.colNombreEmpresa,
            this.colCodigoPostal,
            this.colEstado,
            this.colCiudad,
            this.colMunicipio,
            this.colColonia,
            this.colCalle,
            this.colNInterior,
            this.colNExterior,
            this.colCelular,
            this.colTelFijo,
            this.colCorreo,
            this.colPaginaWeb,
            this.colNombreRepresentante,
            this.colCorreoRepresentante,
            this.colCelularRepresentante,
            this.colTelFijoRepresentante});
            this.gvProveedores.GridControl = this.gcProveedores;
            this.gvProveedores.Name = "gvProveedores";
            this.gvProveedores.OptionsBehavior.Editable = false;
            this.gvProveedores.OptionsView.ColumnAutoWidth = false;
            this.gvProveedores.OptionsView.EnableAppearanceEvenRow = true;
            this.gvProveedores.OptionsView.ShowAutoFilterRow = true;
            this.gvProveedores.OptionsView.ShowGroupPanel = false;
            // 
            // colProveedorID
            // 
            this.colProveedorID.Caption = "proveedorID";
            this.colProveedorID.FieldName = "proveedorID";
            this.colProveedorID.Name = "colProveedorID";
            this.colProveedorID.Visible = true;
            this.colProveedorID.VisibleIndex = 0;
            // 
            // colNombreEmpresa
            // 
            this.colNombreEmpresa.Caption = "nombreEmpresa";
            this.colNombreEmpresa.FieldName = "nombreEmpresa";
            this.colNombreEmpresa.Name = "colNombreEmpresa";
            this.colNombreEmpresa.Visible = true;
            this.colNombreEmpresa.VisibleIndex = 1;
            // 
            // colCodigoPostal
            // 
            this.colCodigoPostal.Caption = "codigoPostal";
            this.colCodigoPostal.FieldName = "codigoPostal";
            this.colCodigoPostal.Name = "colCodigoPostal";
            this.colCodigoPostal.Visible = true;
            this.colCodigoPostal.VisibleIndex = 2;
            // 
            // colEstado
            // 
            this.colEstado.Caption = "estado";
            this.colEstado.FieldName = "estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.Visible = true;
            this.colEstado.VisibleIndex = 3;
            // 
            // colCiudad
            // 
            this.colCiudad.Caption = "ciudad";
            this.colCiudad.FieldName = "ciudad";
            this.colCiudad.Name = "colCiudad";
            this.colCiudad.Visible = true;
            this.colCiudad.VisibleIndex = 4;
            // 
            // colMunicipio
            // 
            this.colMunicipio.Caption = "municipio";
            this.colMunicipio.FieldName = "municipio";
            this.colMunicipio.Name = "colMunicipio";
            this.colMunicipio.Visible = true;
            this.colMunicipio.VisibleIndex = 5;
            // 
            // colColonia
            // 
            this.colColonia.Caption = "colonia";
            this.colColonia.FieldName = "colonia";
            this.colColonia.Name = "colColonia";
            this.colColonia.Visible = true;
            this.colColonia.VisibleIndex = 6;
            // 
            // colCalle
            // 
            this.colCalle.Caption = "calle";
            this.colCalle.FieldName = "calle";
            this.colCalle.Name = "colCalle";
            this.colCalle.Visible = true;
            this.colCalle.VisibleIndex = 7;
            // 
            // colNInterior
            // 
            this.colNInterior.Caption = "nInterior";
            this.colNInterior.FieldName = "nInterior";
            this.colNInterior.Name = "colNInterior";
            this.colNInterior.Visible = true;
            this.colNInterior.VisibleIndex = 8;
            // 
            // colNExterior
            // 
            this.colNExterior.Caption = "nExterior";
            this.colNExterior.FieldName = "nExterior";
            this.colNExterior.Name = "colNExterior";
            this.colNExterior.Visible = true;
            this.colNExterior.VisibleIndex = 9;
            // 
            // colCelular
            // 
            this.colCelular.Caption = "celular";
            this.colCelular.FieldName = "celular";
            this.colCelular.Name = "colCelular";
            this.colCelular.Visible = true;
            this.colCelular.VisibleIndex = 10;
            // 
            // colTelFijo
            // 
            this.colTelFijo.Caption = "telFijo";
            this.colTelFijo.FieldName = "telFijo";
            this.colTelFijo.Name = "colTelFijo";
            this.colTelFijo.Visible = true;
            this.colTelFijo.VisibleIndex = 11;
            // 
            // colCorreo
            // 
            this.colCorreo.Caption = "correo";
            this.colCorreo.FieldName = "correo";
            this.colCorreo.Name = "colCorreo";
            this.colCorreo.Visible = true;
            this.colCorreo.VisibleIndex = 12;
            // 
            // colPaginaWeb
            // 
            this.colPaginaWeb.Caption = "paginaWeb";
            this.colPaginaWeb.FieldName = "paginaWeb";
            this.colPaginaWeb.Name = "colPaginaWeb";
            this.colPaginaWeb.Visible = true;
            this.colPaginaWeb.VisibleIndex = 13;
            // 
            // colNombreRepresentante
            // 
            this.colNombreRepresentante.Caption = "nombreRepresentante";
            this.colNombreRepresentante.FieldName = "nombreRepresentante";
            this.colNombreRepresentante.Name = "colNombreRepresentante";
            this.colNombreRepresentante.Visible = true;
            this.colNombreRepresentante.VisibleIndex = 14;
            // 
            // colCorreoRepresentante
            // 
            this.colCorreoRepresentante.Caption = "correoRepresentante";
            this.colCorreoRepresentante.FieldName = "correoRepresentante";
            this.colCorreoRepresentante.Name = "colCorreoRepresentante";
            this.colCorreoRepresentante.Visible = true;
            this.colCorreoRepresentante.VisibleIndex = 15;
            // 
            // colCelularRepresentante
            // 
            this.colCelularRepresentante.Caption = "celularRepresentante";
            this.colCelularRepresentante.FieldName = "celularRepresentante";
            this.colCelularRepresentante.Name = "colCelularRepresentante";
            this.colCelularRepresentante.Visible = true;
            this.colCelularRepresentante.VisibleIndex = 16;
            // 
            // colTelFijoRepresentante
            // 
            this.colTelFijoRepresentante.Caption = "telFijoRepresentante";
            this.colTelFijoRepresentante.FieldName = "telFijoRepresentante";
            this.colTelFijoRepresentante.Name = "colTelFijoRepresentante";
            this.colTelFijoRepresentante.Visible = true;
            this.colTelFijoRepresentante.VisibleIndex = 17;
            // 
            // proveedorBindingSource
            // 
            this.proveedorBindingSource.DataSource = typeof(FarmsRamirezBML.Proveedor);
            // 
            // frmProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 568);
            this.Controls.Add(this.gcProveedores);
            this.Controls.Add(this.barDockControl7);
            this.Controls.Add(this.barDockControl8);
            this.Controls.Add(this.barDockControl6);
            this.Controls.Add(this.barDockControl5);
            this.Name = "frmProveedores";
            this.Text = "Proveedores";
            this.Load += new System.EventHandler(this.frmProveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcProveedores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProveedores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource)).EndInit();
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
        private DevExpress.XtraBars.BarDockControl barDockControl5;
        private DevExpress.XtraBars.BarDockControl barDockControl6;
        private DevExpress.XtraBars.BarDockControl barDockControl7;
        private DevExpress.XtraBars.BarDockControl barDockControl8;
        private DevExpress.XtraBars.SkinBarSubItem skinBarSubItem1;
        private DevExpress.XtraGrid.GridControl gcProveedores;
        private DevExpress.XtraGrid.Views.Grid.GridView gvProveedores;
        private DevExpress.XtraBars.SkinBarSubItem skinBarSubItem2;
        private System.Windows.Forms.BindingSource proveedorBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colProveedorID;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn colCodigoPostal;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado;
        private DevExpress.XtraGrid.Columns.GridColumn colCiudad;
        private DevExpress.XtraGrid.Columns.GridColumn colMunicipio;
        private DevExpress.XtraGrid.Columns.GridColumn colColonia;
        private DevExpress.XtraGrid.Columns.GridColumn colCalle;
        private DevExpress.XtraGrid.Columns.GridColumn colNInterior;
        private DevExpress.XtraGrid.Columns.GridColumn colNExterior;
        private DevExpress.XtraGrid.Columns.GridColumn colCelular;
        private DevExpress.XtraGrid.Columns.GridColumn colTelFijo;
        private DevExpress.XtraGrid.Columns.GridColumn colCorreo;
        private DevExpress.XtraGrid.Columns.GridColumn colPaginaWeb;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreRepresentante;
        private DevExpress.XtraGrid.Columns.GridColumn colCorreoRepresentante;
        private DevExpress.XtraGrid.Columns.GridColumn colCelularRepresentante;
        private DevExpress.XtraGrid.Columns.GridColumn colTelFijoRepresentante;
    }
}