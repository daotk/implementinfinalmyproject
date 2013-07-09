namespace GUI
{
    partial class PhanQuyen
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
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Cấu hình hệ thống");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Hệ thống", new System.Windows.Forms.TreeNode[] {
            treeNode18});
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Nhóm người dùng");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Người dùng");
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("Danh mục Tỉnh-Thành phố");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("Danh mục Quận-Huyện");
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("Danh mục loại phòng ban");
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("Danh mục phòng ban");
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("Danh mục nhóm dịch vụ");
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("Danh mục dịch vụ");
            System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("Quản trị hệ thống", new System.Windows.Forms.TreeNode[] {
            treeNode20,
            treeNode21,
            treeNode22,
            treeNode23,
            treeNode24,
            treeNode25,
            treeNode26,
            treeNode27});
            System.Windows.Forms.TreeNode treeNode29 = new System.Windows.Forms.TreeNode("Thu ngân");
            System.Windows.Forms.TreeNode treeNode30 = new System.Windows.Forms.TreeNode("DS biên lai được lập");
            System.Windows.Forms.TreeNode treeNode31 = new System.Windows.Forms.TreeNode("DS biên lai đã thu tiền");
            System.Windows.Forms.TreeNode treeNode32 = new System.Windows.Forms.TreeNode("DS thu tiền");
            System.Windows.Forms.TreeNode treeNode33 = new System.Windows.Forms.TreeNode("Doanh thu");
            System.Windows.Forms.TreeNode treeNode34 = new System.Windows.Forms.TreeNode("Báo cáo", new System.Windows.Forms.TreeNode[] {
            treeNode30,
            treeNode31,
            treeNode32,
            treeNode33});
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.trv_PhanQuyen = new System.Windows.Forms.TreeView();
            this.panelEx2 = new DevComponents.DotNetBar.PanelEx();
            this.panelEx4 = new DevComponents.DotNetBar.PanelEx();
            this.grd_NhomNguoiDung = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenVietTat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NhomNguoiDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quyen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn();
            this.panelEx3 = new DevComponents.DotNetBar.PanelEx();
            this.lbl_Title = new DevComponents.DotNetBar.LabelX();
            this.btn_Huy = new DevComponents.DotNetBar.ButtonX();
            this.grb_ThongTinNhomNguoiDung = new System.Windows.Forms.GroupBox();
            this.txt_NhomNguoiDung = new DevComponents.DotNetBar.LabelX();
            this.txt_MoTa = new DevComponents.DotNetBar.LabelX();
            this.lbl_MoTa = new DevComponents.DotNetBar.LabelX();
            this.txt_TenVietTac = new DevComponents.DotNetBar.LabelX();
            this.lbl_TenVietTat = new DevComponents.DotNetBar.LabelX();
            this.lbl_NhomNGuoiDung = new DevComponents.DotNetBar.LabelX();
            this.btn_Luu = new DevComponents.DotNetBar.ButtonX();
            this.panelEx1.SuspendLayout();
            this.panelEx2.SuspendLayout();
            this.panelEx4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_NhomNguoiDung)).BeginInit();
            this.panelEx3.SuspendLayout();
            this.grb_ThongTinNhomNguoiDung.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.trv_PhanQuyen);
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelEx1.Location = new System.Drawing.Point(950, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(350, 567);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 0;
            // 
            // trv_PhanQuyen
            // 
            this.trv_PhanQuyen.CheckBoxes = true;
            this.trv_PhanQuyen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trv_PhanQuyen.Location = new System.Drawing.Point(0, 0);
            this.trv_PhanQuyen.Name = "trv_PhanQuyen";
            treeNode18.Name = "Cấu hình hệ thống";
            treeNode18.Text = "Cấu hình hệ thống";
            treeNode19.Name = "Hệ Thống";
            treeNode19.Text = "Hệ thống";
            treeNode20.Name = "Nhóm người dùng";
            treeNode20.Text = "Nhóm người dùng";
            treeNode21.Name = "Người dùng";
            treeNode21.Text = "Người dùng";
            treeNode22.Name = "Danh mục Tỉnh-Thành phố";
            treeNode22.Text = "Danh mục Tỉnh-Thành phố";
            treeNode23.Name = "Danh mục Quận-Huyện";
            treeNode23.Text = "Danh mục Quận-Huyện";
            treeNode24.Name = "Danh mục loại phòng ban";
            treeNode24.Text = "Danh mục loại phòng ban";
            treeNode25.Name = "Danh mục phòng ban";
            treeNode25.Text = "Danh mục phòng ban";
            treeNode26.Name = "Danh mục nhóm dịch vụ";
            treeNode26.Text = "Danh mục nhóm dịch vụ";
            treeNode27.Name = "Danh mục dịch vụ";
            treeNode27.Text = "Danh mục dịch vụ";
            treeNode28.Name = "Quản trị hệ thống";
            treeNode28.Text = "Quản trị hệ thống";
            treeNode29.Name = "Thu ngân";
            treeNode29.Text = "Thu ngân";
            treeNode30.Name = "DS biên lai được lập";
            treeNode30.Text = "DS biên lai được lập";
            treeNode31.Name = "DS biên lai đã thu tiền";
            treeNode31.Text = "DS biên lai đã thu tiền";
            treeNode32.Name = "DS thu tiền";
            treeNode32.Text = "DS thu tiền";
            treeNode33.Name = "Doanh thu";
            treeNode33.Text = "Doanh thu";
            treeNode34.Name = "Báo cáo";
            treeNode34.Text = "Báo cáo";
            this.trv_PhanQuyen.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode19,
            treeNode28,
            treeNode29,
            treeNode34});
            this.trv_PhanQuyen.Size = new System.Drawing.Size(350, 567);
            this.trv_PhanQuyen.TabIndex = 1;
            this.trv_PhanQuyen.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.HandleOnTreeViewAfterCheck);
            // 
            // panelEx2
            // 
            this.panelEx2.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx2.Controls.Add(this.panelEx4);
            this.panelEx2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx2.Location = new System.Drawing.Point(0, 0);
            this.panelEx2.Name = "panelEx2";
            this.panelEx2.Size = new System.Drawing.Size(950, 567);
            this.panelEx2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx2.Style.GradientAngle = 90;
            this.panelEx2.TabIndex = 1;
            // 
            // panelEx4
            // 
            this.panelEx4.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx4.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx4.Controls.Add(this.grd_NhomNguoiDung);
            this.panelEx4.Controls.Add(this.panelEx3);
            this.panelEx4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx4.Location = new System.Drawing.Point(0, 0);
            this.panelEx4.Name = "panelEx4";
            this.panelEx4.Size = new System.Drawing.Size(950, 567);
            this.panelEx4.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx4.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx4.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx4.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx4.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx4.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx4.Style.GradientAngle = 90;
            this.panelEx4.TabIndex = 1;
            // 
            // grd_NhomNguoiDung
            // 
            this.grd_NhomNguoiDung.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grd_NhomNguoiDung.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.grd_NhomNguoiDung.BackgroundColor = System.Drawing.Color.White;
            this.grd_NhomNguoiDung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_NhomNguoiDung.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.TenVietTat,
            this.NhomNguoiDung,
            this.Mota,
            this.Quyen,
            this.TrangThai});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grd_NhomNguoiDung.DefaultCellStyle = dataGridViewCellStyle4;
            this.grd_NhomNguoiDung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_NhomNguoiDung.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.grd_NhomNguoiDung.Location = new System.Drawing.Point(0, 212);
            this.grd_NhomNguoiDung.MultiSelect = false;
            this.grd_NhomNguoiDung.Name = "grd_NhomNguoiDung";
            this.grd_NhomNguoiDung.ReadOnly = true;
            this.grd_NhomNguoiDung.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grd_NhomNguoiDung.Size = new System.Drawing.Size(950, 355);
            this.grd_NhomNguoiDung.TabIndex = 1;
            this.grd_NhomNguoiDung.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grd_NhomNguoiDung_CellContentClick);
            // 
            // STT
            // 
            this.STT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.STT.DefaultCellStyle = dataGridViewCellStyle3;
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            this.STT.Width = 61;
            // 
            // TenVietTat
            // 
            this.TenVietTat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.TenVietTat.DataPropertyName = "tenviettat_";
            this.TenVietTat.HeaderText = "Tên viết tắt";
            this.TenVietTat.Name = "TenVietTat";
            this.TenVietTat.ReadOnly = true;
            // 
            // NhomNguoiDung
            // 
            this.NhomNguoiDung.DataPropertyName = "tennhom_";
            this.NhomNguoiDung.HeaderText = "Nhóm người dùng";
            this.NhomNguoiDung.Name = "NhomNguoiDung";
            this.NhomNguoiDung.ReadOnly = true;
            // 
            // Mota
            // 
            this.Mota.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Mota.DataPropertyName = "mota_";
            this.Mota.HeaderText = "Mô tả";
            this.Mota.Name = "Mota";
            this.Mota.ReadOnly = true;
            this.Mota.Width = 250;
            // 
            // Quyen
            // 
            this.Quyen.DataPropertyName = "author_";
            this.Quyen.HeaderText = "Quyền";
            this.Quyen.Name = "Quyen";
            this.Quyen.ReadOnly = true;
            this.Quyen.Visible = false;
            // 
            // TrangThai
            // 
            this.TrangThai.Checked = true;
            this.TrangThai.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.TrangThai.CheckValue = "N";
            this.TrangThai.DataPropertyName = "trangthai";
            this.TrangThai.HeaderText = "Trạng thái";
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.ReadOnly = true;
            this.TrangThai.Visible = false;
            // 
            // panelEx3
            // 
            this.panelEx3.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx3.Controls.Add(this.lbl_Title);
            this.panelEx3.Controls.Add(this.btn_Huy);
            this.panelEx3.Controls.Add(this.grb_ThongTinNhomNguoiDung);
            this.panelEx3.Controls.Add(this.btn_Luu);
            this.panelEx3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEx3.Location = new System.Drawing.Point(0, 0);
            this.panelEx3.Name = "panelEx3";
            this.panelEx3.Size = new System.Drawing.Size(950, 212);
            this.panelEx3.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx3.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx3.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx3.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx3.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx3.Style.GradientAngle = 90;
            this.panelEx3.TabIndex = 0;
            // 
            // lbl_Title
            // 
            // 
            // 
            // 
            this.lbl_Title.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_Title.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.Location = new System.Drawing.Point(334, 1);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(282, 29);
            this.lbl_Title.TabIndex = 17;
            this.lbl_Title.Text = "Phân quyền nhóm người dùng";
            // 
            // btn_Huy
            // 
            this.btn_Huy.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Huy.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_Huy.Enabled = false;
            this.btn_Huy.Image = global::GUI.Properties.Resources.cancel1;
            this.btn_Huy.Location = new System.Drawing.Point(500, 166);
            this.btn_Huy.Name = "btn_Huy";
            this.btn_Huy.Size = new System.Drawing.Size(120, 35);
            this.btn_Huy.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Huy.TabIndex = 16;
            this.btn_Huy.Text = "Làm lại";
            this.btn_Huy.Click += new System.EventHandler(this.btn_Huy_Click);
            // 
            // grb_ThongTinNhomNguoiDung
            // 
            this.grb_ThongTinNhomNguoiDung.Controls.Add(this.txt_NhomNguoiDung);
            this.grb_ThongTinNhomNguoiDung.Controls.Add(this.txt_MoTa);
            this.grb_ThongTinNhomNguoiDung.Controls.Add(this.lbl_MoTa);
            this.grb_ThongTinNhomNguoiDung.Controls.Add(this.txt_TenVietTac);
            this.grb_ThongTinNhomNguoiDung.Controls.Add(this.lbl_TenVietTat);
            this.grb_ThongTinNhomNguoiDung.Controls.Add(this.lbl_NhomNGuoiDung);
            this.grb_ThongTinNhomNguoiDung.Location = new System.Drawing.Point(25, 32);
            this.grb_ThongTinNhomNguoiDung.Name = "grb_ThongTinNhomNguoiDung";
            this.grb_ThongTinNhomNguoiDung.Size = new System.Drawing.Size(901, 123);
            this.grb_ThongTinNhomNguoiDung.TabIndex = 14;
            this.grb_ThongTinNhomNguoiDung.TabStop = false;
            this.grb_ThongTinNhomNguoiDung.Text = "Thông tin nhóm người dùng";
            // 
            // txt_NhomNguoiDung
            // 
            // 
            // 
            // 
            this.txt_NhomNguoiDung.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_NhomNguoiDung.Location = new System.Drawing.Point(151, 40);
            this.txt_NhomNguoiDung.Name = "txt_NhomNguoiDung";
            this.txt_NhomNguoiDung.Size = new System.Drawing.Size(132, 23);
            this.txt_NhomNguoiDung.TabIndex = 10;
            // 
            // txt_MoTa
            // 
            // 
            // 
            // 
            this.txt_MoTa.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_MoTa.Location = new System.Drawing.Point(131, 79);
            this.txt_MoTa.Name = "txt_MoTa";
            this.txt_MoTa.Size = new System.Drawing.Size(450, 23);
            this.txt_MoTa.TabIndex = 9;
            // 
            // lbl_MoTa
            // 
            // 
            // 
            // 
            this.lbl_MoTa.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_MoTa.Location = new System.Drawing.Point(6, 79);
            this.lbl_MoTa.Name = "lbl_MoTa";
            this.lbl_MoTa.Size = new System.Drawing.Size(132, 23);
            this.lbl_MoTa.TabIndex = 6;
            this.lbl_MoTa.Text = "Mô tả";
            // 
            // txt_TenVietTac
            // 
            // 
            // 
            // 
            this.txt_TenVietTac.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_TenVietTac.Location = new System.Drawing.Point(465, 40);
            this.txt_TenVietTac.Name = "txt_TenVietTac";
            this.txt_TenVietTac.Size = new System.Drawing.Size(132, 23);
            this.txt_TenVietTac.TabIndex = 5;
            // 
            // lbl_TenVietTat
            // 
            // 
            // 
            // 
            this.lbl_TenVietTat.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_TenVietTat.Location = new System.Drawing.Point(317, 40);
            this.lbl_TenVietTat.Name = "lbl_TenVietTat";
            this.lbl_TenVietTat.Size = new System.Drawing.Size(132, 23);
            this.lbl_TenVietTat.TabIndex = 4;
            this.lbl_TenVietTat.Text = "Tên viết tắt:";
            // 
            // lbl_NhomNGuoiDung
            // 
            // 
            // 
            // 
            this.lbl_NhomNGuoiDung.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_NhomNGuoiDung.Location = new System.Drawing.Point(6, 40);
            this.lbl_NhomNGuoiDung.Name = "lbl_NhomNGuoiDung";
            this.lbl_NhomNGuoiDung.Size = new System.Drawing.Size(132, 23);
            this.lbl_NhomNGuoiDung.TabIndex = 0;
            this.lbl_NhomNGuoiDung.Text = "Nhóm người dùng";
            // 
            // btn_Luu
            // 
            this.btn_Luu.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Luu.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_Luu.Enabled = false;
            this.btn_Luu.Image = global::GUI.Properties.Resources.Save_icon;
            this.btn_Luu.Location = new System.Drawing.Point(330, 166);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(120, 35);
            this.btn_Luu.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Luu.TabIndex = 15;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // PhanQuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1300, 567);
            this.Controls.Add(this.panelEx2);
            this.Controls.Add(this.panelEx1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "PhanQuyen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phân Quyền";
            this.Load += new System.EventHandler(this.PhanQuyen_Load);
            this.panelEx1.ResumeLayout(false);
            this.panelEx2.ResumeLayout(false);
            this.panelEx4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd_NhomNguoiDung)).EndInit();
            this.panelEx3.ResumeLayout(false);
            this.grb_ThongTinNhomNguoiDung.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx1;
        private System.Windows.Forms.TreeView trv_PhanQuyen;
        private DevComponents.DotNetBar.PanelEx panelEx2;
        private DevComponents.DotNetBar.PanelEx panelEx4;
        private DevComponents.DotNetBar.Controls.DataGridViewX grd_NhomNguoiDung;
        private DevComponents.DotNetBar.PanelEx panelEx3;
        private DevComponents.DotNetBar.LabelX lbl_Title;
        private DevComponents.DotNetBar.ButtonX btn_Huy;
        private System.Windows.Forms.GroupBox grb_ThongTinNhomNguoiDung;
        private DevComponents.DotNetBar.LabelX txt_NhomNguoiDung;
        private DevComponents.DotNetBar.LabelX txt_MoTa;
        private DevComponents.DotNetBar.LabelX lbl_MoTa;
        private DevComponents.DotNetBar.LabelX txt_TenVietTac;
        private DevComponents.DotNetBar.LabelX lbl_TenVietTat;
        private DevComponents.DotNetBar.LabelX lbl_NhomNGuoiDung;
        private DevComponents.DotNetBar.ButtonX btn_Luu;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenVietTat;
        private System.Windows.Forms.DataGridViewTextBoxColumn NhomNguoiDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mota;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quyen;
        private DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn TrangThai;

    }
}