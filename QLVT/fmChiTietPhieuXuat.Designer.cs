namespace QLVT
{
    partial class fmChiTietPhieuXuat
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
            this.mAVTLabel = new System.Windows.Forms.Label();
            this.sOLUONGLabel = new System.Windows.Forms.Label();
            this.dONGIALabel = new System.Windows.Forms.Label();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnRefesh = new DevExpress.XtraBars.BarButtonItem();
            this.btnUndo = new DevExpress.XtraBars.BarButtonItem();
            this.btnRedo = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhi = new DevExpress.XtraBars.BarButtonItem();
            this.btnHuy = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.bar4 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.qLVT_DATHANGDataSet1 = new QLVT.QLVT_DATHANGDataSet1();
            this.bdsCTPX = new System.Windows.Forms.BindingSource(this.components);
            this.cTPXTableAdapter = new QLVT.QLVT_DATHANGDataSet1TableAdapters.CTPXTableAdapter();
            this.tableAdapterManager = new QLVT.QLVT_DATHANGDataSet1TableAdapters.TableAdapterManager();
            this.gcCTPX = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAPX = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOLUONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDONGIA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCTPX = new System.Windows.Forms.Button();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtSoLg = new System.Windows.Forms.TextBox();
            this.cmbVatTu = new System.Windows.Forms.ComboBox();
            this.v_DS_KHOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLVT_DATHANGDataSet = new QLVT.QLVT_DATHANGDataSet();
            this.v_DS_KHOTableAdapter = new QLVT.QLVT_DATHANGDataSetTableAdapters.V_DS_KHOTableAdapter();
            this.tableAdapterManager1 = new QLVT.QLVT_DATHANGDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLVT_DATHANGDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTPX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCTPX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.v_DS_KHOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLVT_DATHANGDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // mAVTLabel
            // 
            this.mAVTLabel.AutoSize = true;
            this.mAVTLabel.Location = new System.Drawing.Point(39, 45);
            this.mAVTLabel.Name = "mAVTLabel";
            this.mAVTLabel.Size = new System.Drawing.Size(60, 21);
            this.mAVTLabel.TabIndex = 0;
            this.mAVTLabel.Text = "Vật tư:";
            // 
            // sOLUONGLabel
            // 
            this.sOLUONGLabel.AutoSize = true;
            this.sOLUONGLabel.Location = new System.Drawing.Point(39, 99);
            this.sOLUONGLabel.Name = "sOLUONGLabel";
            this.sOLUONGLabel.Size = new System.Drawing.Size(82, 21);
            this.sOLUONGLabel.TabIndex = 2;
            this.sOLUONGLabel.Text = "Số lượng:";
            // 
            // dONGIALabel
            // 
            this.dONGIALabel.AutoSize = true;
            this.dONGIALabel.Location = new System.Drawing.Point(39, 152);
            this.dONGIALabel.Name = "dONGIALabel";
            this.dONGIALabel.Size = new System.Drawing.Size(73, 21);
            this.dONGIALabel.TabIndex = 4;
            this.dONGIALabel.Text = "Đơn giá:";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar4});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThem,
            this.btnSua,
            this.btnXoa,
            this.btnRefesh,
            this.btnUndo,
            this.btnRedo,
            this.btnGhi,
            this.btnHuy,
            this.barButtonItem1});
            this.barManager1.MaxItemId = 9;
            this.barManager1.StatusBar = this.bar4;
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
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem1)});
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
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Id = 2;
            this.btnXoa.ImageOptions.Image = global::QLVT.Properties.Resources.icons8_delete_bin_48;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnRefesh
            // 
            this.btnRefesh.Caption = "Refesh";
            this.btnRefesh.Id = 3;
            this.btnRefesh.ImageOptions.Image = global::QLVT.Properties.Resources.refesh;
            this.btnRefesh.Name = "btnRefesh";
            this.btnRefesh.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnRefesh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRefesh_ItemClick);
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
            // btnGhi
            // 
            this.btnGhi.Caption = "Ghi";
            this.btnGhi.Id = 6;
            this.btnGhi.ImageOptions.Image = global::QLVT.Properties.Resources.save;
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnGhi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGhi_ItemClick);
            // 
            // btnHuy
            // 
            this.btnHuy.Caption = "Hủy";
            this.btnHuy.Id = 7;
            this.btnHuy.ImageOptions.Image = global::QLVT.Properties.Resources.delete;
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnHuy.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHuy_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Đóng";
            this.barButtonItem1.Id = 8;
            this.barButtonItem1.ImageOptions.Image = global::QLVT.Properties.Resources.icons8_export;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // bar4
            // 
            this.bar4.BarName = "Status bar";
            this.bar4.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar4.DockCol = 0;
            this.bar4.DockRow = 0;
            this.bar4.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar4.OptionsBar.AllowQuickCustomization = false;
            this.bar4.OptionsBar.DrawDragBorder = false;
            this.bar4.OptionsBar.UseWholeRow = true;
            this.bar4.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1067, 90);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 568);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1067, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 90);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 478);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1067, 90);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 478);
            // 
            // qLVT_DATHANGDataSet1
            // 
            this.qLVT_DATHANGDataSet1.DataSetName = "QLVT_DATHANGDataSet1";
            this.qLVT_DATHANGDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsCTPX
            // 
            this.bdsCTPX.DataMember = "CTPX";
            this.bdsCTPX.DataSource = this.qLVT_DATHANGDataSet1;
            // 
            // cTPXTableAdapter
            // 
            this.cTPXTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanhTableAdapter = null;
            this.tableAdapterManager.CTDDHTableAdapter = null;
            this.tableAdapterManager.CTPNTableAdapter = null;
            this.tableAdapterManager.CTPXTableAdapter = this.cTPXTableAdapter;
            this.tableAdapterManager.DatHangTableAdapter = null;
            this.tableAdapterManager.KhoTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.PhieuNhapTableAdapter = null;
            this.tableAdapterManager.PhieuXuatTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLVT.QLVT_DATHANGDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VattuTableAdapter = null;
            // 
            // gcCTPX
            // 
            this.gcCTPX.DataSource = this.bdsCTPX;
            this.gcCTPX.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcCTPX.Location = new System.Drawing.Point(0, 90);
            this.gcCTPX.MainView = this.gridView1;
            this.gcCTPX.MenuManager = this.barManager1;
            this.gcCTPX.Name = "gcCTPX";
            this.gcCTPX.Size = new System.Drawing.Size(1067, 220);
            this.gcCTPX.TabIndex = 5;
            this.gcCTPX.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAPX,
            this.colMAVT,
            this.colSOLUONG,
            this.colDONGIA});
            this.gridView1.GridControl = this.gcCTPX;
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
            // colMAVT
            // 
            this.colMAVT.Caption = "Mã vật tư";
            this.colMAVT.FieldName = "MAVT";
            this.colMAVT.Name = "colMAVT";
            this.colMAVT.Visible = true;
            this.colMAVT.VisibleIndex = 1;
            // 
            // colSOLUONG
            // 
            this.colSOLUONG.Caption = "Số lượng";
            this.colSOLUONG.FieldName = "SOLUONG";
            this.colSOLUONG.Name = "colSOLUONG";
            this.colSOLUONG.Visible = true;
            this.colSOLUONG.VisibleIndex = 2;
            // 
            // colDONGIA
            // 
            this.colDONGIA.Caption = "Đơn giá";
            this.colDONGIA.FieldName = "DONGIA";
            this.colDONGIA.Name = "colDONGIA";
            this.colDONGIA.Visible = true;
            this.colDONGIA.VisibleIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCTPX);
            this.groupBox1.Controls.Add(this.dONGIALabel);
            this.groupBox1.Controls.Add(this.txtDonGia);
            this.groupBox1.Controls.Add(this.sOLUONGLabel);
            this.groupBox1.Controls.Add(this.txtSoLg);
            this.groupBox1.Controls.Add(this.mAVTLabel);
            this.groupBox1.Controls.Add(this.cmbVatTu);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 310);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1067, 258);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // btnCTPX
            // 
            this.btnCTPX.Location = new System.Drawing.Point(634, 87);
            this.btnCTPX.Name = "btnCTPX";
            this.btnCTPX.Size = new System.Drawing.Size(243, 42);
            this.btnCTPX.TabIndex = 6;
            this.btnCTPX.Text = "Chi tiết phiếu xuất";
            this.btnCTPX.UseVisualStyleBackColor = true;
            // 
            // txtDonGia
            // 
            this.txtDonGia.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsCTPX, "DONGIA", true));
            this.txtDonGia.Location = new System.Drawing.Point(146, 149);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(321, 29);
            this.txtDonGia.TabIndex = 5;
            // 
            // txtSoLg
            // 
            this.txtSoLg.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsCTPX, "SOLUONG", true));
            this.txtSoLg.Location = new System.Drawing.Point(146, 96);
            this.txtSoLg.Name = "txtSoLg";
            this.txtSoLg.Size = new System.Drawing.Size(321, 29);
            this.txtSoLg.TabIndex = 3;
            // 
            // cmbVatTu
            // 
            this.cmbVatTu.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bdsCTPX, "MAVT", true));
            this.cmbVatTu.DataSource = this.v_DS_KHOBindingSource;
            this.cmbVatTu.DisplayMember = "TENKHO";
            this.cmbVatTu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVatTu.FormattingEnabled = true;
            this.cmbVatTu.Location = new System.Drawing.Point(146, 42);
            this.cmbVatTu.Name = "cmbVatTu";
            this.cmbVatTu.Size = new System.Drawing.Size(321, 29);
            this.cmbVatTu.TabIndex = 1;
            this.cmbVatTu.ValueMember = "MAKHO";
            // 
            // v_DS_KHOBindingSource
            // 
            this.v_DS_KHOBindingSource.DataMember = "V_DS_KHO";
            this.v_DS_KHOBindingSource.DataSource = this.qLVT_DATHANGDataSet;
            // 
            // qLVT_DATHANGDataSet
            // 
            this.qLVT_DATHANGDataSet.DataSetName = "QLVT_DATHANGDataSet";
            this.qLVT_DATHANGDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // fmChiTietPhieuXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 588);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gcCTPX);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fmChiTietPhieuXuat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fmChiTietPhieuXuat";
            this.Load += new System.EventHandler(this.fmChiTietPhieuXuat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLVT_DATHANGDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTPX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCTPX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.v_DS_KHOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLVT_DATHANGDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnRefesh;
        private DevExpress.XtraBars.BarButtonItem btnUndo;
        private DevExpress.XtraBars.BarButtonItem btnRedo;
        private DevExpress.XtraBars.BarButtonItem btnGhi;
        private DevExpress.XtraBars.BarButtonItem btnHuy;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.Bar bar4;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.BindingSource bdsCTPX;
        private QLVT_DATHANGDataSet1 qLVT_DATHANGDataSet1;
        private QLVT_DATHANGDataSet1TableAdapters.CTPXTableAdapter cTPXTableAdapter;
        private QLVT_DATHANGDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gcCTPX;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtSoLg;
        private System.Windows.Forms.ComboBox cmbVatTu;
        private DevExpress.XtraGrid.Columns.GridColumn colMAPX;
        private DevExpress.XtraGrid.Columns.GridColumn colMAVT;
        private DevExpress.XtraGrid.Columns.GridColumn colSOLUONG;
        private DevExpress.XtraGrid.Columns.GridColumn colDONGIA;
        private QLVT_DATHANGDataSet qLVT_DATHANGDataSet;
        private System.Windows.Forms.BindingSource v_DS_KHOBindingSource;
        private QLVT_DATHANGDataSetTableAdapters.V_DS_KHOTableAdapter v_DS_KHOTableAdapter;
        private QLVT_DATHANGDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.Button btnCTPX;
        private System.Windows.Forms.Label mAVTLabel;
        private System.Windows.Forms.Label sOLUONGLabel;
        private System.Windows.Forms.Label dONGIALabel;
    }
}