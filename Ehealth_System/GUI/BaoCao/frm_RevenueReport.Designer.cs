namespace GUI.BaoCao
{
    partial class DoanhThu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.comboItem2 = new DevComponents.Editors.ComboItem();
            this.comboItem1 = new DevComponents.Editors.ComboItem();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.cbo_DonVi = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem5 = new DevComponents.Editors.ComboItem();
            this.comboItem6 = new DevComponents.Editors.ComboItem();
            this.lbl_DonVi = new DevComponents.DotNetBar.LabelX();
            this.rad_TheoTuan = new System.Windows.Forms.RadioButton();
            this.rad_TheoNgay = new System.Windows.Forms.RadioButton();
            this.btn_InBaoCao = new DevComponents.DotNetBar.ButtonX();
            this.rad_TheoThang = new System.Windows.Forms.RadioButton();
            this.btn_XemBaoCao = new DevComponents.DotNetBar.ButtonX();
            this.cbo_LoaiDichVu = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem3 = new DevComponents.Editors.ComboItem();
            this.comboItem4 = new DevComponents.Editors.ComboItem();
            this.dp_TuNgay = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.lbl_LoaiDichVu = new DevComponents.DotNetBar.LabelX();
            this.lbl_ChonNgay = new DevComponents.DotNetBar.LabelX();
            this.grd_BaoCao = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDonViThuNgan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaBienLai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tuoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dp_TuNgay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_BaoCao)).BeginInit();
            this.SuspendLayout();
            // 
            // comboItem2
            // 
            this.comboItem2.Text = "Đơn vị thu ngân";
            // 
            // comboItem1
            // 
            this.comboItem1.Text = "Nhóm dịch vụ";
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.cbo_DonVi);
            this.panelEx1.Controls.Add(this.lbl_DonVi);
            this.panelEx1.Controls.Add(this.rad_TheoTuan);
            this.panelEx1.Controls.Add(this.rad_TheoNgay);
            this.panelEx1.Controls.Add(this.btn_InBaoCao);
            this.panelEx1.Controls.Add(this.rad_TheoThang);
            this.panelEx1.Controls.Add(this.btn_XemBaoCao);
            this.panelEx1.Controls.Add(this.cbo_LoaiDichVu);
            this.panelEx1.Controls.Add(this.dp_TuNgay);
            this.panelEx1.Controls.Add(this.lbl_LoaiDichVu);
            this.panelEx1.Controls.Add(this.lbl_ChonNgay);
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(1256, 40);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 0;
            // 
            // cbo_DonVi
            // 
            this.cbo_DonVi.DisplayMember = "Text";
            this.cbo_DonVi.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbo_DonVi.FormattingEnabled = true;
            this.cbo_DonVi.ItemHeight = 20;
            this.cbo_DonVi.Items.AddRange(new object[] {
            this.comboItem5,
            this.comboItem6});
            this.cbo_DonVi.Location = new System.Drawing.Point(416, 6);
            this.cbo_DonVi.Name = "cbo_DonVi";
            this.cbo_DonVi.Size = new System.Drawing.Size(160, 26);
            this.cbo_DonVi.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbo_DonVi.TabIndex = 7;
            // 
            // comboItem5
            // 
            this.comboItem5.Text = "Nhóm dịch vụ";
            // 
            // comboItem6
            // 
            this.comboItem6.Text = "Đơn vị thu ngân";
            // 
            // lbl_DonVi
            // 
            // 
            // 
            // 
            this.lbl_DonVi.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_DonVi.Location = new System.Drawing.Point(287, 7);
            this.lbl_DonVi.Name = "lbl_DonVi";
            this.lbl_DonVi.Size = new System.Drawing.Size(123, 23);
            this.lbl_DonVi.TabIndex = 2;
            this.lbl_DonVi.Text = "Đơn vị thu tiền";
            // 
            // rad_TheoTuan
            // 
            this.rad_TheoTuan.AutoSize = true;
            this.rad_TheoTuan.Location = new System.Drawing.Point(700, 10);
            this.rad_TheoTuan.Name = "rad_TheoTuan";
            this.rad_TheoTuan.Size = new System.Drawing.Size(87, 23);
            this.rad_TheoTuan.TabIndex = 2;
            this.rad_TheoTuan.TabStop = true;
            this.rad_TheoTuan.Text = "Theo tuần";
            this.rad_TheoTuan.UseVisualStyleBackColor = true;
            // 
            // rad_TheoNgay
            // 
            this.rad_TheoNgay.AutoSize = true;
            this.rad_TheoNgay.Location = new System.Drawing.Point(593, 10);
            this.rad_TheoNgay.Name = "rad_TheoNgay";
            this.rad_TheoNgay.Size = new System.Drawing.Size(90, 23);
            this.rad_TheoNgay.TabIndex = 1;
            this.rad_TheoNgay.TabStop = true;
            this.rad_TheoNgay.Text = "Theo ngày";
            this.rad_TheoNgay.UseVisualStyleBackColor = true;
            // 
            // btn_InBaoCao
            // 
            this.btn_InBaoCao.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_InBaoCao.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_InBaoCao.Image = global::GUI.Properties.Resources.print_icon;
            this.btn_InBaoCao.Location = new System.Drawing.Point(1207, 4);
            this.btn_InBaoCao.Name = "btn_InBaoCao";
            this.btn_InBaoCao.Size = new System.Drawing.Size(90, 30);
            this.btn_InBaoCao.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_InBaoCao.TabIndex = 8;
            // 
            // rad_TheoThang
            // 
            this.rad_TheoThang.AutoSize = true;
            this.rad_TheoThang.Location = new System.Drawing.Point(804, 9);
            this.rad_TheoThang.Name = "rad_TheoThang";
            this.rad_TheoThang.Size = new System.Drawing.Size(94, 23);
            this.rad_TheoThang.TabIndex = 3;
            this.rad_TheoThang.TabStop = true;
            this.rad_TheoThang.Text = "Theo tháng";
            this.rad_TheoThang.UseVisualStyleBackColor = true;
            // 
            // btn_XemBaoCao
            // 
            this.btn_XemBaoCao.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_XemBaoCao.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_XemBaoCao.Image = global::GUI.Properties.Resources.viewdoanhthu;
            this.btn_XemBaoCao.Location = new System.Drawing.Point(1111, 4);
            this.btn_XemBaoCao.Name = "btn_XemBaoCao";
            this.btn_XemBaoCao.Size = new System.Drawing.Size(90, 30);
            this.btn_XemBaoCao.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_XemBaoCao.TabIndex = 7;
            this.btn_XemBaoCao.Click += new System.EventHandler(this.btn_XemBaoCao_Click);
            // 
            // cbo_LoaiDichVu
            // 
            this.cbo_LoaiDichVu.DisplayMember = "Text";
            this.cbo_LoaiDichVu.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbo_LoaiDichVu.FormattingEnabled = true;
            this.cbo_LoaiDichVu.ItemHeight = 20;
            this.cbo_LoaiDichVu.Items.AddRange(new object[] {
            this.comboItem3,
            this.comboItem4});
            this.cbo_LoaiDichVu.Location = new System.Drawing.Point(111, 8);
            this.cbo_LoaiDichVu.Name = "cbo_LoaiDichVu";
            this.cbo_LoaiDichVu.Size = new System.Drawing.Size(157, 26);
            this.cbo_LoaiDichVu.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbo_LoaiDichVu.TabIndex = 6;
            // 
            // comboItem3
            // 
            this.comboItem3.Text = "Nhóm dịch vụ";
            // 
            // comboItem4
            // 
            this.comboItem4.Text = "Đơn vị thu ngân";
            // 
            // dp_TuNgay
            // 
            // 
            // 
            // 
            this.dp_TuNgay.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dp_TuNgay.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dp_TuNgay.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dp_TuNgay.ButtonDropDown.Visible = true;
            this.dp_TuNgay.IsPopupCalendarOpen = false;
            this.dp_TuNgay.Location = new System.Drawing.Point(988, 6);
            // 
            // 
            // 
            this.dp_TuNgay.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dp_TuNgay.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dp_TuNgay.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dp_TuNgay.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dp_TuNgay.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dp_TuNgay.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dp_TuNgay.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dp_TuNgay.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dp_TuNgay.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dp_TuNgay.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dp_TuNgay.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dp_TuNgay.MonthCalendar.DisplayMonth = new System.DateTime(2013, 6, 1, 0, 0, 0, 0);
            this.dp_TuNgay.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dp_TuNgay.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dp_TuNgay.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dp_TuNgay.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dp_TuNgay.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dp_TuNgay.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dp_TuNgay.MonthCalendar.TodayButtonVisible = true;
            this.dp_TuNgay.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dp_TuNgay.Name = "dp_TuNgay";
            this.dp_TuNgay.Size = new System.Drawing.Size(110, 26);
            this.dp_TuNgay.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dp_TuNgay.TabIndex = 4;
            // 
            // lbl_LoaiDichVu
            // 
            // 
            // 
            // 
            this.lbl_LoaiDichVu.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_LoaiDichVu.Location = new System.Drawing.Point(12, 9);
            this.lbl_LoaiDichVu.Name = "lbl_LoaiDichVu";
            this.lbl_LoaiDichVu.Size = new System.Drawing.Size(93, 23);
            this.lbl_LoaiDichVu.TabIndex = 0;
            this.lbl_LoaiDichVu.Text = "Loại dịch vụ";
            // 
            // lbl_ChonNgay
            // 
            // 
            // 
            // 
            this.lbl_ChonNgay.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_ChonNgay.Location = new System.Drawing.Point(915, 7);
            this.lbl_ChonNgay.Name = "lbl_ChonNgay";
            this.lbl_ChonNgay.Size = new System.Drawing.Size(75, 23);
            this.lbl_ChonNgay.TabIndex = 0;
            this.lbl_ChonNgay.Text = "Chọn ngày";
            // 
            // grd_BaoCao
            // 
            this.grd_BaoCao.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grd_BaoCao.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.grd_BaoCao.BackgroundColor = System.Drawing.Color.White;
            this.grd_BaoCao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_BaoCao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.TenDonViThuNgan,
            this.MaBienLai,
            this.Tile,
            this.Tuoi,
            this.GioiTinh,
            this.Date,
            this.TongTien,
            this.Column5});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grd_BaoCao.DefaultCellStyle = dataGridViewCellStyle2;
            this.grd_BaoCao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_BaoCao.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.grd_BaoCao.Location = new System.Drawing.Point(0, 40);
            this.grd_BaoCao.MultiSelect = false;
            this.grd_BaoCao.Name = "grd_BaoCao";
            this.grd_BaoCao.ReadOnly = true;
            this.grd_BaoCao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grd_BaoCao.Size = new System.Drawing.Size(1256, 510);
            this.grd_BaoCao.TabIndex = 1;
            // 
            // STT
            // 
            this.STT.DataPropertyName = "(none)";
            dataGridViewCellStyle1.NullValue = "1";
            this.STT.DefaultCellStyle = dataGridViewCellStyle1;
            this.STT.FillWeight = 41.99583F;
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            // 
            // TenDonViThuNgan
            // 
            this.TenDonViThuNgan.DataPropertyName = "tendonvithungan_";
            this.TenDonViThuNgan.FillWeight = 120.0315F;
            this.TenDonViThuNgan.HeaderText = "Đơn vị thu ngân";
            this.TenDonViThuNgan.Name = "TenDonViThuNgan";
            this.TenDonViThuNgan.ReadOnly = true;
            // 
            // MaBienLai
            // 
            this.MaBienLai.DataPropertyName = "mabienlai_";
            this.MaBienLai.FillWeight = 106.6102F;
            this.MaBienLai.HeaderText = "Mã Biên Lai";
            this.MaBienLai.Name = "MaBienLai";
            this.MaBienLai.ReadOnly = true;
            // 
            // Tile
            // 
            this.Tile.DataPropertyName = "hotenbenhnhan_";
            this.Tile.FillWeight = 150.5279F;
            this.Tile.HeaderText = "Họ tên BN";
            this.Tile.Name = "Tile";
            this.Tile.ReadOnly = true;
            // 
            // Tuoi
            // 
            this.Tuoi.DataPropertyName = "tuoibenhnhan_";
            this.Tuoi.FillWeight = 49.93533F;
            this.Tuoi.HeaderText = "Tuổi BN";
            this.Tuoi.Name = "Tuoi";
            this.Tuoi.ReadOnly = true;
            // 
            // GioiTinh
            // 
            this.GioiTinh.DataPropertyName = "gioitinh_";
            this.GioiTinh.FillWeight = 51.68512F;
            this.GioiTinh.HeaderText = "Giới tính ";
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "ngaydangky_";
            this.Date.FillWeight = 102.0263F;
            this.Date.HeaderText = "Ngày đăng ký";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // TongTien
            // 
            this.TongTien.DataPropertyName = "tongtien_";
            this.TongTien.FillWeight = 162.9748F;
            this.TongTien.HeaderText = "Tổng tiền BL";
            this.TongTien.Name = "TongTien";
            this.TongTien.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "tennhomdichvu_";
            this.Column5.FillWeight = 114.2132F;
            this.Column5.HeaderText = "Tên dịch vụ";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // DoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1256, 550);
            this.Controls.Add(this.grd_BaoCao);
            this.Controls.Add(this.panelEx1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DoanhThu";
            this.Text = "DoanhThu";
            this.Load += new System.EventHandler(this.DoanhThu_Load);
            this.panelEx1.ResumeLayout(false);
            this.panelEx1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dp_TuNgay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_BaoCao)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.Editors.ComboItem comboItem2;
        private DevComponents.Editors.ComboItem comboItem1;
        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.LabelX lbl_LoaiDichVu;
        private DevComponents.DotNetBar.LabelX lbl_ChonNgay;
        private DevComponents.DotNetBar.ButtonX btn_XemBaoCao;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbo_LoaiDichVu;
        private DevComponents.Editors.ComboItem comboItem3;
        private DevComponents.Editors.ComboItem comboItem4;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dp_TuNgay;
        private System.Windows.Forms.RadioButton rad_TheoThang;
        private System.Windows.Forms.RadioButton rad_TheoTuan;
        private System.Windows.Forms.RadioButton rad_TheoNgay;
        private DevComponents.DotNetBar.ButtonX btn_InBaoCao;
        private DevComponents.DotNetBar.Controls.DataGridViewX grd_BaoCao;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbo_DonVi;
        private DevComponents.Editors.ComboItem comboItem5;
        private DevComponents.Editors.ComboItem comboItem6;
        private DevComponents.DotNetBar.LabelX lbl_DonVi;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDonViThuNgan;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaBienLai;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tile;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tuoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;


    }
}