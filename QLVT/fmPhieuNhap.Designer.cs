namespace QLVT
{
    partial class fmPhieuNhap
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
            System.Windows.Forms.Label mAKHOLabel;
            System.Windows.Forms.Label masoDDHLabel;
            System.Windows.Forms.Label nGAYLabel;
            System.Windows.Forms.Label mAPNLabel;
            this.tENCNLabel = new System.Windows.Forms.Label();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhi = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnUndo = new DevExpress.XtraBars.BarButtonItem();
            this.btnRedo = new DevExpress.XtraBars.BarButtonItem();
            this.btnRefesh = new DevExpress.XtraBars.BarButtonItem();
            this.btnHuy = new DevExpress.XtraBars.BarButtonItem();
            this.btnDong = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.qLVT_DATHANGDataSet1 = new QLVT.QLVT_DATHANGDataSet1();
            this.bdsPN = new System.Windows.Forms.BindingSource(this.components);
            this.phieuNhapTableAdapter = new QLVT.QLVT_DATHANGDataSet1TableAdapters.PhieuNhapTableAdapter();
            this.tableAdapterManager = new QLVT.QLVT_DATHANGDataSet1TableAdapters.TableAdapterManager();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbCN = new System.Windows.Forms.ComboBox();
            this.v_DS_PHANMANHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLVT_DATHANGDataSet = new QLVT.QLVT_DATHANGDataSet();
            this.gcPN = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAPN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMasoDDH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAKHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbMSDDH = new System.Windows.Forms.ComboBox();
            this.v_DS_DATHANGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnCTPN = new System.Windows.Forms.Button();
            this.cmbKho = new System.Windows.Forms.ComboBox();
            this.v_DS_KHOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtNgay = new System.Windows.Forms.DateTimePicker();
            this.txtMaPN = new System.Windows.Forms.TextBox();
            this.v_DS_KHOTableAdapter = new QLVT.QLVT_DATHANGDataSetTableAdapters.V_DS_KHOTableAdapter();
            this.v_DS_PHANMANHTableAdapter = new QLVT.QLVT_DATHANGDataSetTableAdapters.V_DS_PHANMANHTableAdapter();
            this.tableAdapterManager1 = new QLVT.QLVT_DATHANGDataSetTableAdapters.TableAdapterManager();
            mAKHOLabel = new System.Windows.Forms.Label();
            masoDDHLabel = new System.Windows.Forms.Label();
            nGAYLabel = new System.Windows.Forms.Label();
            mAPNLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLVT_DATHANGDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPN)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.v_DS_PHANMANHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLVT_DATHANGDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.v_DS_DATHANGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_DS_KHOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mAKHOLabel
            // 
            mAKHOLabel.AutoSize = true;
            mAKHOLabel.Location = new System.Drawing.Point(510, 93);
            mAKHOLabel.Name = "mAKHOLabel";
            mAKHOLabel.Size = new System.Drawing.Size(76, 21);
            mAKHOLabel.TabIndex = 8;
            mAKHOLabel.Text = "Tên kho:";
            // 
            // masoDDHLabel
            // 
            masoDDHLabel.AutoSize = true;
            masoDDHLabel.Location = new System.Drawing.Point(510, 25);
            masoDDHLabel.Name = "masoDDHLabel";
            masoDDHLabel.Size = new System.Drawing.Size(105, 21);
            masoDDHLabel.TabIndex = 4;
            masoDDHLabel.Text = "Mã số DDH:";
            // 
            // nGAYLabel
            // 
            nGAYLabel.AutoSize = true;
            nGAYLabel.Location = new System.Drawing.Point(27, 93);
            nGAYLabel.Name = "nGAYLabel";
            nGAYLabel.Size = new System.Drawing.Size(53, 21);
            nGAYLabel.TabIndex = 2;
            nGAYLabel.Text = "Ngày:";
            // 
            // mAPNLabel
            // 
            mAPNLabel.AutoSize = true;
            mAPNLabel.Location = new System.Drawing.Point(27, 40);
            mAPNLabel.Name = "mAPNLabel";
            mAPNLabel.Size = new System.Drawing.Size(67, 21);
            mAPNLabel.TabIndex = 0;
            mAPNLabel.Text = "Mã PN:";
            // 
            // tENCNLabel
            // 
            this.tENCNLabel.AutoSize = true;
            this.tENCNLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tENCNLabel.Location = new System.Drawing.Point(149, 22);
            this.tENCNLabel.Name = "tENCNLabel";
            this.tENCNLabel.Size = new System.Drawing.Size(116, 27);
            this.tENCNLabel.TabIndex = 0;
            this.tENCNLabel.Text = "Chi Nhánh";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThem,
            this.btnSua,
            this.btnGhi,
            this.btnXoa,
            this.btnUndo,
            this.btnRedo,
            this.btnRefesh,
            this.btnDong,
            this.btnHuy});
            this.barManager1.MaxItemId = 9;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnThem),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSua),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnXoa),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnRefesh),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnUndo),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnRedo),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnGhi),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnHuy),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnDong)});
            this.bar1.Text = "Tools";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.Id = 0;
            this.btnThem.ImageOptions.Image = global::QLVT.Properties.Resources.add_file;
            this.btnThem.Name = "btnThem";
            this.btnThem.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnSua
            // 
            this.btnSua.Caption = "Sửa";
            this.btnSua.Id = 1;
            this.btnSua.ImageOptions.Image = global::QLVT.Properties.Resources.edit;
            this.btnSua.Name = "btnSua";
            this.btnSua.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSua_ItemClick);
            // 
            // btnGhi
            // 
            this.btnGhi.Caption = "Ghi";
            this.btnGhi.Id = 2;
            this.btnGhi.ImageOptions.Image = global::QLVT.Properties.Resources.save;
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnGhi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGhi_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Id = 3;
            this.btnXoa.ImageOptions.Image = global::QLVT.Properties.Resources.icons8_delete_bin_48;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnUndo
            // 
            this.btnUndo.Caption = "Undo";
            this.btnUndo.Id = 4;
            this.btnUndo.ImageOptions.Image = global::QLVT.Properties.Resources.undo;
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // btnRedo
            // 
            this.btnRedo.Caption = "Redo";
            this.btnRedo.Id = 5;
            this.btnRedo.ImageOptions.Image = global::QLVT.Properties.Resources.redo;
            this.btnRedo.Name = "btnRedo";
            this.btnRedo.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // btnRefesh
            // 
            this.btnRefesh.Caption = "Refesh";
            this.btnRefesh.Id = 6;
            this.btnRefesh.ImageOptions.Image = global::QLVT.Properties.Resources.refesh;
            this.btnRefesh.Name = "btnRefesh";
            this.btnRefesh.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnRefesh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRefesh_ItemClick);
            // 
            // btnHuy
            // 
            this.btnHuy.Caption = "Hủy";
            this.btnHuy.Id = 8;
            this.btnHuy.ImageOptions.Image = global::QLVT.Properties.Resources.delete;
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnHuy.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHuy_ItemClick);
            // 
            // btnDong
            // 
            this.btnDong.Caption = "Đóng";
            this.btnDong.Id = 7;
            this.btnDong.ImageOptions.Image = global::QLVT.Properties.Resources.icons8_export;
            this.btnDong.Name = "btnDong";
            this.btnDong.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnDong.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDong_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1073, 90);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 581);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1073, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 90);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 491);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1073, 90);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 491);
            // 
            // qLVT_DATHANGDataSet1
            // 
            this.qLVT_DATHANGDataSet1.DataSetName = "QLVT_DATHANGDataSet1";
            this.qLVT_DATHANGDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsPN
            // 
            this.bdsPN.DataMember = "PhieuNhap";
            this.bdsPN.DataSource = this.qLVT_DATHANGDataSet1;
            // 
            // phieuNhapTableAdapter
            // 
            this.phieuNhapTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanhTableAdapter = null;
            this.tableAdapterManager.CTDDHTableAdapter = null;
            this.tableAdapterManager.CTPNTableAdapter = null;
            this.tableAdapterManager.CTPXTableAdapter = null;
            this.tableAdapterManager.DatHangTableAdapter = null;
            this.tableAdapterManager.KhoTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.PhieuNhapTableAdapter = this.phieuNhapTableAdapter;
            this.tableAdapterManager.PhieuXuatTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLVT.QLVT_DATHANGDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VattuTableAdapter = null;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tENCNLabel);
            this.panel1.Controls.Add(this.cmbCN);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 90);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1073, 73);
            this.panel1.TabIndex = 100;
            // 
            // cmbCN
            // 
            this.cmbCN.DataSource = this.v_DS_PHANMANHBindingSource;
            this.cmbCN.DisplayMember = "TENCN";
            this.cmbCN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCN.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCN.FormattingEnabled = true;
            this.cmbCN.Location = new System.Drawing.Point(264, 19);
            this.cmbCN.Name = "cmbCN";
            this.cmbCN.Size = new System.Drawing.Size(500, 34);
            this.cmbCN.TabIndex = 1;
            this.cmbCN.ValueMember = "TENSERVER";
            this.cmbCN.SelectedIndexChanged += new System.EventHandler(this.cmbCN_SelectedIndexChanged);
            // 
            // v_DS_PHANMANHBindingSource
            // 
            this.v_DS_PHANMANHBindingSource.DataMember = "V_DS_PHANMANH";
            this.v_DS_PHANMANHBindingSource.DataSource = this.qLVT_DATHANGDataSet;
            // 
            // qLVT_DATHANGDataSet
            // 
            this.qLVT_DATHANGDataSet.DataSetName = "QLVT_DATHANGDataSet";
            this.qLVT_DATHANGDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gcPN
            // 
            this.gcPN.DataSource = this.bdsPN;
            this.gcPN.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcPN.Location = new System.Drawing.Point(0, 163);
            this.gcPN.MainView = this.gridView1;
            this.gcPN.MenuManager = this.barManager1;
            this.gcPN.Name = "gcPN";
            this.gcPN.Size = new System.Drawing.Size(1073, 220);
            this.gcPN.TabIndex = 101;
            this.gcPN.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAPN,
            this.colNGAY,
            this.colMasoDDH,
            this.colMANV,
            this.colMAKHO});
            this.gridView1.GridControl = this.gcPN;
            this.gridView1.Name = "gridView1";
            this.gridView1.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.gridView1_InitNewRow);
            // 
            // colMAPN
            // 
            this.colMAPN.Caption = "Mã PN";
            this.colMAPN.FieldName = "MAPN";
            this.colMAPN.Name = "colMAPN";
            this.colMAPN.Visible = true;
            this.colMAPN.VisibleIndex = 0;
            // 
            // colNGAY
            // 
            this.colNGAY.Caption = "Ngày";
            this.colNGAY.FieldName = "NGAY";
            this.colNGAY.Name = "colNGAY";
            this.colNGAY.Visible = true;
            this.colNGAY.VisibleIndex = 1;
            // 
            // colMasoDDH
            // 
            this.colMasoDDH.Caption = "Mã số DDH";
            this.colMasoDDH.FieldName = "MasoDDH";
            this.colMasoDDH.Name = "colMasoDDH";
            this.colMasoDDH.Visible = true;
            this.colMasoDDH.VisibleIndex = 2;
            // 
            // colMANV
            // 
            this.colMANV.Caption = "Mã NV";
            this.colMANV.FieldName = "MANV";
            this.colMANV.Name = "colMANV";
            this.colMANV.Visible = true;
            this.colMANV.VisibleIndex = 3;
            // 
            // colMAKHO
            // 
            this.colMAKHO.Caption = "Mã Kho";
            this.colMAKHO.FieldName = "MAKHO";
            this.colMAKHO.Name = "colMAKHO";
            this.colMAKHO.Visible = true;
            this.colMAKHO.VisibleIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbMSDDH);
            this.groupBox1.Controls.Add(this.btnCTPN);
            this.groupBox1.Controls.Add(this.cmbKho);
            this.groupBox1.Controls.Add(mAKHOLabel);
            this.groupBox1.Controls.Add(masoDDHLabel);
            this.groupBox1.Controls.Add(nGAYLabel);
            this.groupBox1.Controls.Add(this.txtNgay);
            this.groupBox1.Controls.Add(mAPNLabel);
            this.groupBox1.Controls.Add(this.txtMaPN);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 383);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1073, 207);
            this.groupBox1.TabIndex = 102;
            this.groupBox1.TabStop = false;
            // 
            // cmbMSDDH
            // 
            this.cmbMSDDH.DataSource = this.v_DS_DATHANGBindingSource;
            this.cmbMSDDH.DisplayMember = "MasoDDH";
            this.cmbMSDDH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMSDDH.FormattingEnabled = true;
            this.cmbMSDDH.Location = new System.Drawing.Point(635, 28);
            this.cmbMSDDH.Name = "cmbMSDDH";
            this.cmbMSDDH.Size = new System.Drawing.Size(281, 29);
            this.cmbMSDDH.TabIndex = 17;
            this.cmbMSDDH.ValueMember = "MasoDDH";
            this.cmbMSDDH.SelectedIndexChanged += new System.EventHandler(this.cmbMSDDH_SelectedIndexChanged);
            // 
            // v_DS_DATHANGBindingSource
            // 
            this.v_DS_DATHANGBindingSource.DataMember = "V_DS_DATHANG";
            this.v_DS_DATHANGBindingSource.DataSource = this.qLVT_DATHANGDataSet1;
            // 
            // btnCTPN
            // 
            this.btnCTPN.Location = new System.Drawing.Point(635, 144);
            this.btnCTPN.Name = "btnCTPN";
            this.btnCTPN.Size = new System.Drawing.Size(224, 38);
            this.btnCTPN.TabIndex = 16;
            this.btnCTPN.Text = "Chi tiết phiếu nhập";
            this.btnCTPN.UseVisualStyleBackColor = true;
            this.btnCTPN.Click += new System.EventHandler(this.btnCTPN_Click);
            // 
            // cmbKho
            // 
            this.cmbKho.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bdsPN, "MAKHO", true));
            this.cmbKho.DataSource = this.v_DS_KHOBindingSource;
            this.cmbKho.DisplayMember = "TENKHO";
            this.cmbKho.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKho.FormattingEnabled = true;
            this.cmbKho.Location = new System.Drawing.Point(635, 85);
            this.cmbKho.Name = "cmbKho";
            this.cmbKho.Size = new System.Drawing.Size(281, 29);
            this.cmbKho.TabIndex = 15;
            this.cmbKho.ValueMember = "MAKHO";
            this.cmbKho.SelectedIndexChanged += new System.EventHandler(this.cmbKho_SelectedIndexChanged);
            // 
            // v_DS_KHOBindingSource
            // 
            this.v_DS_KHOBindingSource.DataMember = "V_DS_KHO";
            this.v_DS_KHOBindingSource.DataSource = this.qLVT_DATHANGDataSet;
            // 
            // txtNgay
            // 
            this.txtNgay.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bdsPN, "NGAY", true));
            this.txtNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtNgay.Location = new System.Drawing.Point(138, 87);
            this.txtNgay.Name = "txtNgay";
            this.txtNgay.Size = new System.Drawing.Size(281, 29);
            this.txtNgay.TabIndex = 3;
            // 
            // txtMaPN
            // 
            this.txtMaPN.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsPN, "MAPN", true));
            this.txtMaPN.Location = new System.Drawing.Point(138, 37);
            this.txtMaPN.Name = "txtMaPN";
            this.txtMaPN.Size = new System.Drawing.Size(188, 29);
            this.txtMaPN.TabIndex = 1;
            // 
            // v_DS_KHOTableAdapter
            // 
            this.v_DS_KHOTableAdapter.ClearBeforeFill = true;
            // 
            // 
            this.v_DS_PHANMANHTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.UpdateOrder = QLVT.QLVT_DATHANGDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // fmPhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 601);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gcPN);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fmPhieuNhap";
            this.Text = "Phiếu Nhập";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.fmPhieuNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLVT_DATHANGDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPN)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.v_DS_PHANMANHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLVT_DATHANGDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.v_DS_DATHANGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_DS_KHOBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.BarButtonItem btnGhi;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnUndo;
        private DevExpress.XtraBars.BarButtonItem btnRedo;
        private DevExpress.XtraBars.BarButtonItem btnRefesh;
        private DevExpress.XtraBars.BarButtonItem btnDong;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.BindingSource bdsPN;
        private QLVT_DATHANGDataSet1 qLVT_DATHANGDataSet1;
        private QLVT_DATHANGDataSet1TableAdapters.PhieuNhapTableAdapter phieuNhapTableAdapter;
        private QLVT_DATHANGDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraBars.BarButtonItem btnHuy;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker txtNgay;
        private System.Windows.Forms.TextBox txtMaPN;
        private DevExpress.XtraGrid.GridControl gcPN;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbCN;
        private DevExpress.XtraGrid.Columns.GridColumn colMAPN;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAY;
        private DevExpress.XtraGrid.Columns.GridColumn colMasoDDH;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKHO;
        private System.Windows.Forms.ComboBox cmbKho;
        private QLVT_DATHANGDataSet qLVT_DATHANGDataSet;
        private System.Windows.Forms.BindingSource v_DS_KHOBindingSource;
        private QLVT_DATHANGDataSetTableAdapters.V_DS_KHOTableAdapter v_DS_KHOTableAdapter;
        private System.Windows.Forms.Button btnCTPN;
        private System.Windows.Forms.Label tENCNLabel;
        private System.Windows.Forms.BindingSource v_DS_DATHANGBindingSource;
        private System.Windows.Forms.ComboBox cmbMSDDH;
        private System.Windows.Forms.BindingSource v_DS_PHANMANHBindingSource;
        private QLVT_DATHANGDataSetTableAdapters.V_DS_PHANMANHTableAdapter v_DS_PHANMANHTableAdapter;
        private QLVT_DATHANGDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
    }
}