﻿namespace SimiSoft
{
    partial class frmRoles
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
            this.btnActualizarRoles = new DevExpress.XtraBars.BarButtonItem();
            this.btnNuevoRol = new DevExpress.XtraBars.BarButtonItem();
            this.btnModificarRol = new DevExpress.XtraBars.BarButtonItem();
            this.btnEliminarRol = new DevExpress.XtraBars.BarButtonItem();
            this.skinBarSubItem2 = new DevExpress.XtraBars.SkinBarSubItem();
            this.barDockControl5 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl6 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl7 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl8 = new DevExpress.XtraBars.BarDockControl();
            this.skinBarSubItem1 = new DevExpress.XtraBars.SkinBarSubItem();
            this.gcRoles = new DevExpress.XtraGrid.GridControl();
            this.rolesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvRoles = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colrolID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colstatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfechaRegistro = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcRoles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvRoles)).BeginInit();
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
            this.btnActualizarRoles,
            this.btnNuevoRol,
            this.btnModificarRol,
            this.btnEliminarRol,
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
            new DevExpress.XtraBars.LinkPersistInfo(this.btnActualizarRoles),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnNuevoRol),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnModificarRol),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnEliminarRol),
            new DevExpress.XtraBars.LinkPersistInfo(this.skinBarSubItem2)});
            this.bar1.Text = "Herramientas";
            // 
            // btnActualizarRoles
            // 
            this.btnActualizarRoles.Caption = "Actualizar";
            this.btnActualizarRoles.Id = 0;
            this.btnActualizarRoles.Name = "btnActualizarRoles";
            // 
            // btnNuevoRol
            // 
            this.btnNuevoRol.Caption = "Nuevo";
            this.btnNuevoRol.Id = 1;
            this.btnNuevoRol.Name = "btnNuevoRol";
            this.btnNuevoRol.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNuevoRol_ItemClick);
            // 
            // btnModificarRol
            // 
            this.btnModificarRol.Caption = "Modificar";
            this.btnModificarRol.Id = 2;
            this.btnModificarRol.Name = "btnModificarRol";
            // 
            // btnEliminarRol
            // 
            this.btnEliminarRol.Caption = "Eliminar";
            this.btnEliminarRol.Id = 3;
            this.btnEliminarRol.Name = "btnEliminarRol";
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
            // gcRoles
            // 
            this.gcRoles.DataSource = this.rolesBindingSource;
            this.gcRoles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcRoles.Location = new System.Drawing.Point(0, 20);
            this.gcRoles.MainView = this.gvRoles;
            this.gcRoles.MenuManager = this.barManager3;
            this.gcRoles.Name = "gcRoles";
            this.gcRoles.Size = new System.Drawing.Size(1236, 548);
            this.gcRoles.TabIndex = 4;
            this.gcRoles.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvRoles});
            // 
            // rolesBindingSource
            // 
            this.rolesBindingSource.DataSource = typeof(FarmsRamirezBML.Roles);
            // 
            // gvRoles
            // 
            this.gvRoles.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colrolID,
            this.coldescripcion,
            this.colstatus,
            this.colfechaRegistro});
            this.gvRoles.GridControl = this.gcRoles;
            this.gvRoles.Name = "gvRoles";
            this.gvRoles.OptionsBehavior.Editable = false;
            this.gvRoles.OptionsView.ColumnAutoWidth = false;
            this.gvRoles.OptionsView.EnableAppearanceEvenRow = true;
            this.gvRoles.OptionsView.ShowAutoFilterRow = true;
            this.gvRoles.OptionsView.ShowGroupPanel = false;
            // 
            // colrolID
            // 
            this.colrolID.Caption = "RolID";
            this.colrolID.FieldName = "rolID";
            this.colrolID.Name = "colrolID";
            this.colrolID.OptionsColumn.AllowEdit = false;
            this.colrolID.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colrolID.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colrolID.OptionsColumn.AllowMove = false;
            this.colrolID.OptionsColumn.AllowSize = false;
            this.colrolID.OptionsColumn.FixedWidth = true;
            this.colrolID.Visible = true;
            this.colrolID.VisibleIndex = 0;
            // 
            // coldescripcion
            // 
            this.coldescripcion.FieldName = "descripcion";
            this.coldescripcion.Name = "coldescripcion";
            this.coldescripcion.OptionsColumn.AllowEdit = false;
            this.coldescripcion.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.coldescripcion.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.coldescripcion.OptionsColumn.AllowMove = false;
            this.coldescripcion.OptionsColumn.AllowSize = false;
            this.coldescripcion.OptionsColumn.FixedWidth = true;
            this.coldescripcion.Visible = true;
            this.coldescripcion.VisibleIndex = 1;
            // 
            // colstatus
            // 
            this.colstatus.FieldName = "status";
            this.colstatus.Name = "colstatus";
            // 
            // colfechaRegistro
            // 
            this.colfechaRegistro.FieldName = "fechaRegistro";
            this.colfechaRegistro.Name = "colfechaRegistro";
            // 
            // frmRoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 568);
            this.Controls.Add(this.gcRoles);
            this.Controls.Add(this.barDockControl7);
            this.Controls.Add(this.barDockControl8);
            this.Controls.Add(this.barDockControl6);
            this.Controls.Add(this.barDockControl5);
            this.Name = "frmRoles";
            this.Text = "Roles";
            ((System.ComponentModel.ISupportInitialize)(this.barManager3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcRoles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvRoles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager3;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnActualizarRoles;
        private DevExpress.XtraBars.BarButtonItem btnNuevoRol;
        private DevExpress.XtraBars.BarButtonItem btnModificarRol;
        private DevExpress.XtraBars.BarButtonItem btnEliminarRol;
        private DevExpress.XtraBars.SkinBarSubItem skinBarSubItem2;
        private DevExpress.XtraBars.BarDockControl barDockControl5;
        private DevExpress.XtraBars.BarDockControl barDockControl6;
        private DevExpress.XtraBars.BarDockControl barDockControl7;
        private DevExpress.XtraBars.BarDockControl barDockControl8;
        private DevExpress.XtraBars.SkinBarSubItem skinBarSubItem1;
        private DevExpress.XtraGrid.GridControl gcRoles;
        private DevExpress.XtraGrid.Views.Grid.GridView gvRoles;
        private System.Windows.Forms.BindingSource rolesBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colrolID;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colstatus;
        private DevExpress.XtraGrid.Columns.GridColumn colfechaRegistro;
    }
}