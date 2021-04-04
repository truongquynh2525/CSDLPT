namespace QLVT
{
    partial class fmPhieuXuat
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
            System.Windows.Forms.Label hOTENKHLabel;
            System.Windows.Forms.Label nGAYLabel;
            System.Windows.Forms.Label mAPXLabel;
            System.Windows.Forms.Label mAKHOLabel;
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
            this.bdsPX = new System.Windows.Forms.BindingSource(this.components);
            this.phieuXuatTableAdapter = new QLVT.QLVT_DATHANGDataSet1TableAdapters.PhieuXuatTableAdapter();
            this.tableAdapterManager = new QLVT.QLVT_DATHANGDataSet1TableAdapters.TableAdapterManager();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbCN = new System.Windows.Forms.ComboBox();
            this.v_DS_PHANMANHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLVT_DATHANGDataSet = new QLVT.QLVT_DATHANGDataSet();
            this.gcPX = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAPX = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOTENKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAKHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCTPX = new System.Windows.Forms.Button();
            this.cmbKho = new System.Windows.Forms.ComboBox();
            this.v_DS_KHOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtHoTenKH = new System.Windows.Forms.TextBox();
            this.txtNgay = new System.Windows.Forms.DateTimePicker();
            this.txtMaPX = new System.Windows.Forms.TextBox();
            this.v_DS_KHOTableAdapter = new QLVT.QLVT_DATHANGDataSetTableAdapters.V_DS_KHOTableAdapter();
            this.tableAdapterManager1 = new QLVT.QLVT_DATHANGDataSetTableAdapters.TableAdapterManager();
            this.v_DS_PHANMANHTableAdapter = new QLVT.QLVT_DATHANGDataSetTableAdapters.V_DS_PHANMANHTableAdapter();
            hOTENKHLabel = new System.Windows.Forms.Label();
            nGAYLabel = new System.Windows.Forms.Label();
            mAPXLabel = new System.Windows.Forms.Label();
            mAKHOLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLVT_DATHANGDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPX)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.v_DS_PHANMANHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLVT_DATHANGDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.v_DS_KHOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // hOTENKHLabel
            // 
            hOTENKHLabel.AutoSize = true;
            hOTENKHLabel.Location = new System.Drawing.Point(13, 226);
            hOTENKHLabel.Name = "hOTENKHLabel";
            hOTENKHLabel.Size = new System.Drawing.Size(95, 21);
            hOTENKHLabel.TabIndex = 4;
            hOTENKHLabel.Text = "Họ tên KH:";
            // 
            // nGAYLabel
            // 
            nGAYLabel.AutoSize = true;
            nGAYLabel.Location = new System.Drawing.Point(29, 97);
            nGAYLabel.Name = "nGAYLabel";
            nGAYLabel.Size = new System.Drawing.Size(53, 21);
            nGAYLabel.TabIndex = 2;
            nGAYLabel.Text = "Ngày:";
            // 
            // mAPXLabel
            // 
            mAPXLabel.AutoSize = true;
            mAPXLabel.Location = new System.Drawing.Point(29, 48);
            mAPXLabel.Name = "mAPXLabel";
            mAPXLabel.Size = new System.Drawing.Size(119, 21);
            mAPXLabel.TabIndex = 0;
            mAPXLabel.Text = "Mã phiếu xuất:";
            // 
            // mAKHOLabel
            // 
            mAKHOLabel.AutoSize = true;
            mAKHOLabel.Location = new System.Drawing.Point(605, 48);
            mAKHOLabel.Name = "mAKHOLabel";
            mAKHOLabel.Size = new System.Drawing.Size(46, 21);
            mAKHOLabel.TabIndex = 6;
            mAKHOLabel.Text = "Kho:";
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
            // 
            // btnHuy
            // 
            this.btnHuy.Caption = "Hủy";
            this.btnHuy.Id = 8;
            this.btnHuy.ImageOptions.Image = global::QLVT.Properties.Resources.delete;
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
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
            this.barDockControlTop.Size = new System.Drawing.Size(1293, 90);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 569);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1293, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 90);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 479);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1293, 90);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 479);
            // 
            // qLVT_DATHANGDataSet1
            // 
            this.qLVT_DATHANGDataSet1.DataSetName = "QLVT_DATHANGDataSet1";
            this.qLVT_DATHANGDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsPX
            // 
            this.bdsPX.DataMember = "PhieuXuat";
            this.bdsPX.DataSource = this.qLVT_DATHANGDataSet1;
            // 
            // phieuXuatTableAdapter
            // 
            this.phieuXuatTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.PhieuNhapTableAdapter = null;
            this.tableAdapterManager.PhieuXuatTableAdapter = this.phieuXuatTableAdapter;
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
            this.panel1.Size = new System.Drawing.Size(1293, 73);
            this.panel1.TabIndex = 101;
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
            // gcPX
            // 
            this.gcPX.DataSource = this.bdsPX;
            this.gcPX.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcPX.Location = new System.Drawing.Point(0, 163);
            this.gcPX.MainView = this.gridView1;
            this.gcPX.MenuManager = this.barManager1;
            this.gcPX.Name = "gcPX";
            this.gcPX.Size = new System.Drawing.Size(1293, 220);
            this.gcPX.TabIndex = 102;
            this.gcPX.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAPX,
            this.colNGAY,
            this.colHOTENKH,
            this.colMANV,
            this.colMAKHO});
            this.gridView1.GridControl = this.gcPX;
            this.gridView1.Name = "gridView1";
            this.gridView1.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.gridView1_InitNewRow);
            // 
            // colMAPX
            // 
            this.colMAPX.Caption = "Mã phiếu xuất";
            this.colMAPX.FieldName = "MAPX";
            this.colMAPX.Name = "colMAPX";
            this.colMAPX.Visible = true;
            this.colMAPX.VisibleIndex = 0;
            // 
            // colNGAY
            // 
            this.colNGAY.Caption = "Ngày";
            this.colNGAY.FieldName = "NGAY";
            this.colNGAY.Name = "colNGAY";
            this.colNGAY.Visible = true;
            this.colNGAY.VisibleIndex = 1;
            // 
            // colHOTENKH
            // 
            this.colHOTENKH.Caption = "Họ tên khách hàng";
            this.colHOTENKH.FieldName = "HOTENKH";
            this.colHOTENKH.Name = "colHOTENKH";
            this.colHOTENKH.Visible = true;
            this.colHOTENKH.VisibleIndex = 2;
            // 
            // colMANV
            // 
            this.colMANV.Caption = "Mã nhân viên";
            this.colMANV.FieldName = "MANV";
            this.colMANV.Name = "colMANV";
            this.colMANV.Visible = true;
            this.colMANV.VisibleIndex = 3;
            // 
            // colMAKHO
            // 
            this.colMAKHO.Caption = "Mã kho";
            this.colMAKHO.FieldName = "MAKHO";
            this.colMAKHO.Name = "colMAKHO";
            this.colMAKHO.Visible = true;
            this.colMAKHO.VisibleIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCTPX);
            this.groupBox1.Controls.Add(mAKHOLabel);
            this.groupBox1.Controls.Add(this.cmbKho);
            this.groupBox1.Controls.Add(hOTENKHLabel);
            this.groupBox1.Controls.Add(this.txtHoTenKH);
            this.groupBox1.Controls.Add(nGAYLabel);
            this.groupBox1.Controls.Add(this.txtNgay);
            this.groupBox1.Controls.Add(mAPXLabel);
            this.groupBox1.Controls.Add(this.txtMaPX);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 383);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1293, 181);
            this.groupBox1.TabIndex = 103;
            this.groupBox1.TabStop = false;
            // 
            // btnCTPX
            // 
            this.btnCTPX.Location = new System.Drawing.Point(689, 93);
            this.btnCTPX.Name = "btnCTPX";
            this.btnCTPX.Size = new System.Drawing.Size(258, 41);
            this.btnCTPX.TabIndex = 8;
            this.btnCTPX.Text = "Chi tiết phiếu xuất";
            this.btnCTPX.UseVisualStyleBackColor = true;
            this.btnCTPX.Click += new System.EventHandler(this.btnCTPX_Click);
            // 
            // cmbKho
            // 
            this.cmbKho.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bdsPX, "MAKHO", true));
            this.cmbKho.DataSource = this.v_DS_KHOBindingSource;
            this.cmbKho.DisplayMember = "TENKHO";
            this.cmbKho.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKho.FormattingEnabled = true;
            this.cmbKho.Location = new System.Drawing.Point(689, 48);
            this.cmbKho.Name = "cmbKho";
            this.cmbKho.Size = new System.Drawing.Size(339, 29);
            this.cmbKho.TabIndex = 7;
            this.cmbKho.ValueMember = "MAKHO";
            this.cmbKho.SelectedIndexChanged += new System.EventHandler(this.cmbKho_SelectedIndexChanged);
            // 
            // v_DS_KHOBindingSource
            // 
            this.v_DS_KHOBindingSource.DataMember = "V_DS_KHO";
            this.v_DS_KHOBindingSource.DataSource = this.qLVT_DATHANGDataSet;
            // 
            // txtHoTenKH
            // 
            this.txtHoTenKH.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsPX, "HOTENKH", true));
            this.txtHoTenKH.Location = new System.Drawing.Point(124, 223);
            this.txtHoTenKH.Name = "txtHoTenKH";
            this.txtHoTenKH.Size = new System.Drawing.Size(339, 29);
            this.txtHoTenKH.TabIndex = 5;
            // 
            // txtNgay
            // 
            this.txtNgay.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bdsPX, "NGAY", true));
            this.txtNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtNgay.Location = new System.Drawing.Point(175, 97);
            this.txtNgay.Name = "txtNgay";
            this.txtNgay.Size = new System.Drawing.Size(339, 29);
            this.txtNgay.TabIndex = 3;
            // 
            // txtMaPX
            // 
            this.txtMaPX.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsPX, "MAPX", true));
            this.txtMaPX.Location = new System.Drawing.Point(175, 45);
            this.txtMaPX.Name = "txtMaPX";
            this.txtMaPX.Size = new System.Drawing.Size(185, 29);
            this.txtMaPX.TabIndex = 1;
            // 
            // v_DS_KHOTableAdapter
            // 
            this.v_DS_KHOTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.UpdateOrder = QLVT.QLVT_DATHANGDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // v_DS_PHANMANHTableAdapter
            // 
            this.v_DS_PHANMANHTableAdapter.ClearBeforeFill = true;
            // 
            // fmPhieuXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1293, 589);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gcPX);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fmPhieuXuat";
            this.Text = "Phiếu Xuất";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.fmPhieuXuat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLVT_DATHANGDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPX)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.v_DS_PHANMANHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLVT_DATHANGDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.BindingSource bdsPX;
        private QLVT_DATHANGDataSet1 qLVT_DATHANGDataSet1;
        private QLVT_DATHANGDataSet1TableAdapters.PhieuXuatTableAdapter phieuXuatTableAdapter;
        private QLVT_DATHANGDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtHoTenKH;
        private System.Windows.Forms.DateTimePicker txtNgay;
        private System.Windows.Forms.TextBox txtMaPX;
        private DevExpress.XtraGrid.GridControl gcPX;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAPX;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAY;
        private DevExpress.XtraGrid.Columns.GridColumn colHOTENKH;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKHO;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbCN;
        private DevExpress.XtraBars.BarButtonItem btnHuy;
        private System.Windows.Forms.Button btnCTPX;
        private System.Windows.Forms.ComboBox cmbKho;
        private QLVT_DATHANGDataSet qLVT_DATHANGDataSet;
        private System.Windows.Forms.BindingSource v_DS_KHOBindingSource;
        private QLVT_DATHANGDataSetTableAdapters.V_DS_KHOTableAdapter v_DS_KHOTableAdapter;
        private QLVT_DATHANGDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.Label tENCNLabel;
        private System.Windows.Forms.BindingSource v_DS_PHANMANHBindingSource;
        private QLVT_DATHANGDataSetTableAdapters.V_DS_PHANMANHTableAdapter v_DS_PHANMANHTableAdapter;
    }
}
