﻿namespace HRM.ChamCong
{
    partial class formTinhLuong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formTinhLuong));
            this.PHUCAP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl5 = new DevExpress.XtraBars.BarDockControl();
            this.barManager2 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar4 = new DevExpress.XtraBars.Bar();
            this.bar5 = new DevExpress.XtraBars.Bar();
            this.btnTinhLuong = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnPrint = new DevExpress.XtraBars.BarButtonItem();
            this.btnClose = new DevExpress.XtraBars.BarButtonItem();
            this.bar6 = new DevExpress.XtraBars.Bar();
            this.barDockControl2 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl3 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl4 = new DevExpress.XtraBars.BarDockControl();
            this.btnFix = new DevExpress.XtraBars.BarButtonItem();
            this.btnSave = new DevExpress.XtraBars.BarButtonItem();
            this.btnHuy = new DevExpress.XtraBars.BarButtonItem();
            this.btnXemBangCong = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.barBtn_GiaHanHopDong = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.btnXemBangLuong = new DevExpress.XtraEditors.SimpleButton();
            this.NGAYTHUONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TANGCA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UNGLUONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.THUCLANH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.label18 = new System.Windows.Forms.Label();
            this.gridControBanGcong = new DevExpress.XtraGrid.GridControl();
            this.gridViewBangCong = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MAKYCONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HOTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TENPB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NGAYCONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NGAYPHEP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NGAYCHUNHAT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.txtYear = new System.Windows.Forms.Label();
            this.labeMonth = new System.Windows.Forms.Label();
            this.comboBoxMaKyCong = new System.Windows.Forms.ComboBox();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.btnPrintLoolList = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem7 = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.barManager2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControBanGcong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewBangCong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PHUCAP
            // 
            this.PHUCAP.Caption = "Phụ Cấp";
            this.PHUCAP.FieldName = "PHUCAP";
            this.PHUCAP.MinWidth = 25;
            this.PHUCAP.Name = "PHUCAP";
            this.PHUCAP.Visible = true;
            this.PHUCAP.VisibleIndex = 11;
            this.PHUCAP.Width = 94;
            // 
            // barDockControl1
            // 
            this.barDockControl1.CausesValidation = false;
            this.barDockControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl1.Location = new System.Drawing.Point(1236, 51);
            this.barDockControl1.Manager = null;
            this.barDockControl1.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControl1.Size = new System.Drawing.Size(0, 378);
            // 
            // barDockControl5
            // 
            this.barDockControl5.CausesValidation = false;
            this.barDockControl5.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl5.Location = new System.Drawing.Point(1236, 51);
            this.barDockControl5.Manager = this.barManager2;
            this.barDockControl5.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControl5.Size = new System.Drawing.Size(0, 378);
            // 
            // barManager2
            // 
            this.barManager2.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar4,
            this.bar5,
            this.bar6});
            this.barManager2.DockControls.Add(this.barDockControl2);
            this.barManager2.DockControls.Add(this.barDockControl3);
            this.barManager2.DockControls.Add(this.barDockControl4);
            this.barManager2.DockControls.Add(this.barDockControl5);
            this.barManager2.Form = this;
            this.barManager2.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnTinhLuong,
            this.btnFix,
            this.btnXoa,
            this.btnSave,
            this.btnHuy,
            this.btnPrint,
            this.btnClose,
            this.btnXemBangCong});
            this.barManager2.MainMenu = this.bar5;
            this.barManager2.MaxItemId = 8;
            this.barManager2.StatusBar = this.bar6;
            // 
            // bar4
            // 
            this.bar4.BarName = "Tools";
            this.bar4.DockCol = 0;
            this.bar4.DockRow = 1;
            this.bar4.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar4.Text = "Tools";
            // 
            // bar5
            // 
            this.bar5.BarName = "Main menu";
            this.bar5.DockCol = 0;
            this.bar5.DockRow = 0;
            this.bar5.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar5.FloatLocation = new System.Drawing.Point(550, 321);
            this.bar5.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnTinhLuong),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnXoa),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnPrint),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnClose)});
            this.bar5.OptionsBar.MultiLine = true;
            this.bar5.OptionsBar.UseWholeRow = true;
            this.bar5.Text = "Main menu";
            // 
            // btnTinhLuong
            // 
            this.btnTinhLuong.Caption = "Tính Lương";
            this.btnTinhLuong.Id = 0;
            this.btnTinhLuong.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnTinhLuong.ImageOptions.SvgImage")));
            this.btnTinhLuong.Name = "btnTinhLuong";
            this.btnTinhLuong.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnTinhLuong.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTinhLuong_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Id = 2;
            this.btnXoa.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnXoa.ImageOptions.SvgImage")));
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // btnPrint
            // 
            this.btnPrint.Caption = "In";
            this.btnPrint.Id = 5;
            this.btnPrint.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnPrint.ImageOptions.SvgImage")));
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnPrint.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPrint_ItemClick);
            // 
            // btnClose
            // 
            this.btnClose.Caption = "Đóng";
            this.btnClose.Id = 6;
            this.btnClose.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnClose.ImageOptions.SvgImage")));
            this.btnClose.Name = "btnClose";
            this.btnClose.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnClose.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnClose_ItemClick);
            // 
            // bar6
            // 
            this.bar6.BarName = "Status bar";
            this.bar6.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar6.DockCol = 0;
            this.bar6.DockRow = 0;
            this.bar6.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar6.OptionsBar.AllowQuickCustomization = false;
            this.bar6.OptionsBar.DrawDragBorder = false;
            this.bar6.OptionsBar.UseWholeRow = true;
            this.bar6.Text = "Status bar";
            // 
            // barDockControl2
            // 
            this.barDockControl2.CausesValidation = false;
            this.barDockControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl2.Location = new System.Drawing.Point(0, 0);
            this.barDockControl2.Manager = this.barManager2;
            this.barDockControl2.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControl2.Size = new System.Drawing.Size(1236, 51);
            // 
            // barDockControl3
            // 
            this.barDockControl3.CausesValidation = false;
            this.barDockControl3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControl3.Location = new System.Drawing.Point(0, 429);
            this.barDockControl3.Manager = this.barManager2;
            this.barDockControl3.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControl3.Size = new System.Drawing.Size(1236, 20);
            // 
            // barDockControl4
            // 
            this.barDockControl4.CausesValidation = false;
            this.barDockControl4.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControl4.Location = new System.Drawing.Point(0, 51);
            this.barDockControl4.Manager = this.barManager2;
            this.barDockControl4.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControl4.Size = new System.Drawing.Size(0, 378);
            // 
            // btnFix
            // 
            this.btnFix.Caption = "Sửa";
            this.btnFix.Id = 1;
            this.btnFix.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnFix.ImageOptions.SvgImage")));
            this.btnFix.Name = "btnFix";
            this.btnFix.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // btnSave
            // 
            this.btnSave.Caption = "Lưu";
            this.btnSave.Id = 3;
            this.btnSave.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSave.ImageOptions.SvgImage")));
            this.btnSave.Name = "btnSave";
            this.btnSave.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // btnHuy
            // 
            this.btnHuy.Caption = "Hủy";
            this.btnHuy.Id = 4;
            this.btnHuy.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnHuy.ImageOptions.SvgImage")));
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // btnXemBangCong
            // 
            this.btnXemBangCong.Caption = "Xem bảng công";
            this.btnXemBangCong.Id = 7;
            this.btnXemBangCong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXemBangCong.ImageOptions.Image")));
            this.btnXemBangCong.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnXemBangCong.ImageOptions.LargeImage")));
            this.btnXemBangCong.Name = "btnXemBangCong";
            this.btnXemBangCong.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Xóa";
            this.barButtonItem3.Id = 2;
            this.barButtonItem3.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem3.ImageOptions.SvgImage")));
            this.barButtonItem3.Name = "barButtonItem3";
            this.barButtonItem3.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "Hủy";
            this.barButtonItem5.Id = 4;
            this.barButtonItem5.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem5.ImageOptions.SvgImage")));
            this.barButtonItem5.Name = "barButtonItem5";
            this.barButtonItem5.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // barBtn_GiaHanHopDong
            // 
            this.barBtn_GiaHanHopDong.Caption = "Gian Hạn Hợp Đồng";
            this.barBtn_GiaHanHopDong.Id = 8;
            this.barBtn_GiaHanHopDong.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barBtn_GiaHanHopDong.ImageOptions.SvgImage")));
            this.barBtn_GiaHanHopDong.Name = "barBtn_GiaHanHopDong";
            this.barBtn_GiaHanHopDong.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // barButtonItem6
            // 
            this.barButtonItem6.Caption = "In chi tiết";
            this.barButtonItem6.Id = 5;
            this.barButtonItem6.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem6.ImageOptions.SvgImage")));
            this.barButtonItem6.Name = "barButtonItem6";
            this.barButtonItem6.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // btnXemBangLuong
            // 
            this.btnXemBangLuong.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnXemBangLuong.ImageOptions.SvgImage")));
            this.btnXemBangLuong.Location = new System.Drawing.Point(393, 9);
            this.btnXemBangLuong.Name = "btnXemBangLuong";
            this.btnXemBangLuong.Size = new System.Drawing.Size(163, 45);
            this.btnXemBangLuong.TabIndex = 64;
            this.btnXemBangLuong.Text = "Xem Bảng Lương";
            // 
            // NGAYTHUONG
            // 
            this.NGAYTHUONG.Caption = "Ngày Thường";
            this.NGAYTHUONG.FieldName = "NGAYTHUONG";
            this.NGAYTHUONG.MinWidth = 25;
            this.NGAYTHUONG.Name = "NGAYTHUONG";
            this.NGAYTHUONG.Visible = true;
            this.NGAYTHUONG.VisibleIndex = 8;
            this.NGAYTHUONG.Width = 94;
            // 
            // TANGCA
            // 
            this.TANGCA.Caption = "Tăng Ca";
            this.TANGCA.FieldName = "TANGCA";
            this.TANGCA.MinWidth = 25;
            this.TANGCA.Name = "TANGCA";
            this.TANGCA.Visible = true;
            this.TANGCA.VisibleIndex = 9;
            this.TANGCA.Width = 94;
            // 
            // UNGLUONG
            // 
            this.UNGLUONG.Caption = "Ứng Lương";
            this.UNGLUONG.FieldName = "UNGLUONG";
            this.UNGLUONG.MinWidth = 25;
            this.UNGLUONG.Name = "UNGLUONG";
            this.UNGLUONG.Visible = true;
            this.UNGLUONG.VisibleIndex = 10;
            this.UNGLUONG.Width = 94;
            // 
            // THUCLANH
            // 
            this.THUCLANH.Caption = "Thực Lãnh";
            this.THUCLANH.FieldName = "THUCLANH";
            this.THUCLANH.MinWidth = 25;
            this.THUCLANH.Name = "THUCLANH";
            this.THUCLANH.Visible = true;
            this.THUCLANH.VisibleIndex = 12;
            this.THUCLANH.Width = 94;
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Lưu";
            this.barButtonItem4.Id = 3;
            this.barButtonItem4.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem4.ImageOptions.SvgImage")));
            this.barButtonItem4.Name = "barButtonItem4";
            this.barButtonItem4.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Sửa";
            this.barButtonItem2.Id = 1;
            this.barButtonItem2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem2.ImageOptions.SvgImage")));
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(58, 25);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(97, 21);
            this.label18.TabIndex = 27;
            this.label18.Text = "Mã Kỳ Công";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gridControBanGcong
            // 
            this.gridControBanGcong.Location = new System.Drawing.Point(0, 3);
            this.gridControBanGcong.MainView = this.gridViewBangCong;
            this.gridControBanGcong.Name = "gridControBanGcong";
            this.gridControBanGcong.Size = new System.Drawing.Size(1196, 317);
            this.gridControBanGcong.TabIndex = 0;
            this.gridControBanGcong.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewBangCong});
            // 
            // gridViewBangCong
            // 
            this.gridViewBangCong.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.MAKYCONG,
            this.MANV,
            this.HOTEN,
            this.TENPB,
            this.NGAYCONG,
            this.NGAYPHEP,
            this.NGAYCHUNHAT,
            this.NGAYTHUONG,
            this.TANGCA,
            this.UNGLUONG,
            this.PHUCAP,
            this.THUCLANH});
            this.gridViewBangCong.GridControl = this.gridControBanGcong;
            this.gridViewBangCong.Name = "gridViewBangCong";
            this.gridViewBangCong.OptionsView.ShowGroupPanel = false;
            // 
            // ID
            // 
            this.ID.Caption = "ID";
            this.ID.FieldName = "ID";
            this.ID.MinWidth = 25;
            this.ID.Name = "ID";
            this.ID.Visible = true;
            this.ID.VisibleIndex = 0;
            this.ID.Width = 25;
            // 
            // MAKYCONG
            // 
            this.MAKYCONG.Caption = "Mã Kỳ Công";
            this.MAKYCONG.FieldName = "MAKYCONG";
            this.MAKYCONG.MinWidth = 25;
            this.MAKYCONG.Name = "MAKYCONG";
            this.MAKYCONG.Visible = true;
            this.MAKYCONG.VisibleIndex = 1;
            this.MAKYCONG.Width = 110;
            // 
            // MANV
            // 
            this.MANV.Caption = "Mã NV";
            this.MANV.FieldName = "MANV";
            this.MANV.MinWidth = 25;
            this.MANV.Name = "MANV";
            this.MANV.Visible = true;
            this.MANV.VisibleIndex = 2;
            this.MANV.Width = 53;
            // 
            // HOTEN
            // 
            this.HOTEN.Caption = "Họ Tên";
            this.HOTEN.FieldName = "HOTEN";
            this.HOTEN.MinWidth = 25;
            this.HOTEN.Name = "HOTEN";
            this.HOTEN.Visible = true;
            this.HOTEN.VisibleIndex = 3;
            this.HOTEN.Width = 89;
            // 
            // TENPB
            // 
            this.TENPB.Caption = "Phòng Ban";
            this.TENPB.FieldName = "TENPB";
            this.TENPB.MinWidth = 25;
            this.TENPB.Name = "TENPB";
            this.TENPB.Visible = true;
            this.TENPB.VisibleIndex = 4;
            this.TENPB.Width = 123;
            // 
            // NGAYCONG
            // 
            this.NGAYCONG.Caption = "Ngày Công";
            this.NGAYCONG.FieldName = "NGAYCONG";
            this.NGAYCONG.MinWidth = 25;
            this.NGAYCONG.Name = "NGAYCONG";
            this.NGAYCONG.Visible = true;
            this.NGAYCONG.VisibleIndex = 5;
            this.NGAYCONG.Width = 188;
            // 
            // NGAYPHEP
            // 
            this.NGAYPHEP.Caption = "Ngày Phép";
            this.NGAYPHEP.FieldName = "NGAYPHEP";
            this.NGAYPHEP.MinWidth = 25;
            this.NGAYPHEP.Name = "NGAYPHEP";
            this.NGAYPHEP.Visible = true;
            this.NGAYPHEP.VisibleIndex = 6;
            this.NGAYPHEP.Width = 187;
            // 
            // NGAYCHUNHAT
            // 
            this.NGAYCHUNHAT.Caption = "Chủ Nhật";
            this.NGAYCHUNHAT.FieldName = "NGAYCHUNHAT";
            this.NGAYCHUNHAT.MinWidth = 25;
            this.NGAYCHUNHAT.Name = "NGAYCHUNHAT";
            this.NGAYCHUNHAT.Visible = true;
            this.NGAYCHUNHAT.VisibleIndex = 7;
            this.NGAYCHUNHAT.Width = 367;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 51);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel1.Controls.Add(this.btnXemBangLuong);
            this.splitContainer1.Panel1.Controls.Add(this.txtYear);
            this.splitContainer1.Panel1.Controls.Add(this.labeMonth);
            this.splitContainer1.Panel1.Controls.Add(this.comboBoxMaKyCong);
            this.splitContainer1.Panel1.Controls.Add(this.label18);
            this.splitContainer1.Panel1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gridControBanGcong);
            this.splitContainer1.Size = new System.Drawing.Size(1236, 378);
            this.splitContainer1.SplitterDistance = 61;
            this.splitContainer1.TabIndex = 20;
            // 
            // txtYear
            // 
            this.txtYear.AutoSize = true;
            this.txtYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtYear.Location = new System.Drawing.Point(556, 82);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(0, 24);
            this.txtYear.TabIndex = 63;
            // 
            // labeMonth
            // 
            this.labeMonth.AutoSize = true;
            this.labeMonth.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeMonth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labeMonth.Location = new System.Drawing.Point(370, 82);
            this.labeMonth.Name = "labeMonth";
            this.labeMonth.Size = new System.Drawing.Size(0, 24);
            this.labeMonth.TabIndex = 61;
            // 
            // comboBoxMaKyCong
            // 
            this.comboBoxMaKyCong.Font = new System.Drawing.Font("Tahoma", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxMaKyCong.FormattingEnabled = true;
            this.comboBoxMaKyCong.Location = new System.Drawing.Point(161, 22);
            this.comboBoxMaKyCong.Name = "comboBoxMaKyCong";
            this.comboBoxMaKyCong.Size = new System.Drawing.Size(121, 29);
            this.comboBoxMaKyCong.TabIndex = 56;
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Thêm";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem1.ImageOptions.SvgImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // btnPrintLoolList
            // 
            this.btnPrintLoolList.Caption = "In danh sách đang hiển thị";
            this.btnPrintLoolList.Id = 11;
            this.btnPrintLoolList.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnPrintLoolList.ImageOptions.SvgImage")));
            this.btnPrintLoolList.Name = "btnPrintLoolList";
            this.btnPrintLoolList.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // barButtonItem7
            // 
            this.barButtonItem7.Caption = "Đóng";
            this.barButtonItem7.Id = 6;
            this.barButtonItem7.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem7.ImageOptions.SvgImage")));
            this.barButtonItem7.Name = "barButtonItem7";
            this.barButtonItem7.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // formTinhLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 449);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.barDockControl1);
            this.Controls.Add(this.barDockControl4);
            this.Controls.Add(this.barDockControl5);
            this.Controls.Add(this.barDockControl3);
            this.Controls.Add(this.barDockControl2);
            this.Name = "formTinhLuong";
            this.Text = "Tính Lương";
            this.Load += new System.EventHandler(this.formTinhLuong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControBanGcong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewBangCong)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.Columns.GridColumn PHUCAP;
        private DevExpress.XtraBars.BarDockControl barDockControl1;
        private DevExpress.XtraBars.BarDockControl barDockControl5;
        private DevExpress.XtraBars.BarManager barManager2;
        private DevExpress.XtraBars.Bar bar4;
        private DevExpress.XtraBars.Bar bar5;
        private DevExpress.XtraBars.BarButtonItem btnTinhLuong;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnPrint;
        private DevExpress.XtraBars.BarButtonItem btnClose;
        private DevExpress.XtraBars.Bar bar6;
        private DevExpress.XtraBars.BarDockControl barDockControl2;
        private DevExpress.XtraBars.BarDockControl barDockControl3;
        private DevExpress.XtraBars.BarDockControl barDockControl4;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraEditors.SimpleButton btnXemBangLuong;
        private System.Windows.Forms.Label txtYear;
        private System.Windows.Forms.Label labeMonth;
        private System.Windows.Forms.ComboBox comboBoxMaKyCong;
        private System.Windows.Forms.Label label18;
        private DevExpress.XtraGrid.GridControl gridControBanGcong;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewBangCong;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn MAKYCONG;
        private DevExpress.XtraGrid.Columns.GridColumn MANV;
        private DevExpress.XtraGrid.Columns.GridColumn HOTEN;
        private DevExpress.XtraGrid.Columns.GridColumn TENPB;
        private DevExpress.XtraGrid.Columns.GridColumn NGAYCONG;
        private DevExpress.XtraGrid.Columns.GridColumn NGAYPHEP;
        private DevExpress.XtraGrid.Columns.GridColumn NGAYCHUNHAT;
        private DevExpress.XtraGrid.Columns.GridColumn NGAYTHUONG;
        private DevExpress.XtraGrid.Columns.GridColumn TANGCA;
        private DevExpress.XtraGrid.Columns.GridColumn UNGLUONG;
        private DevExpress.XtraGrid.Columns.GridColumn THUCLANH;
        private DevExpress.XtraBars.BarButtonItem btnFix;
        private DevExpress.XtraBars.BarButtonItem btnSave;
        private DevExpress.XtraBars.BarButtonItem btnHuy;
        private DevExpress.XtraBars.BarButtonItem btnXemBangCong;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.BarButtonItem barBtn_GiaHanHopDong;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem btnPrintLoolList;
        private DevExpress.XtraBars.BarButtonItem barButtonItem7;
    }
}