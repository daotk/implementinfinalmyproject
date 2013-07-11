namespace GUI.BaoCao
{
    partial class frm_ListBill
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ListBill));
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.cbo_TheoTN = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.btn_InBaoCao = new DevComponents.DotNetBar.ButtonX();
            this.btn_XemBaoCao = new DevComponents.DotNetBar.ButtonX();
            this.cbo_TheoDV = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem1 = new DevComponents.Editors.ComboItem();
            this.comboItem2 = new DevComponents.Editors.ComboItem();
            this.dp_ChonNgay = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.lbl_Theo = new DevComponents.DotNetBar.LabelX();
            this.lbl_ChonNgay = new DevComponents.DotNetBar.LabelX();
            this.dataGridViewX1 = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenThuNgan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaBienLai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenBenhNhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tuoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThoiGian = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NhomDichVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ribbonOrbMenuItem1 = new System.Windows.Forms.RibbonOrbMenuItem();
            this.ribbonHost1 = new System.Windows.Forms.RibbonHost();
            this.panelEx2 = new DevComponents.DotNetBar.PanelEx();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.lbl_Tongbienlai = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.lbl_Tongtien = new DevComponents.DotNetBar.LabelX();
            this.panelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dp_ChonNgay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).BeginInit();
            this.panelEx2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.cbo_TheoTN);
            this.panelEx1.Controls.Add(this.labelX1);
            this.panelEx1.Controls.Add(this.btn_InBaoCao);
            this.panelEx1.Controls.Add(this.btn_XemBaoCao);
            this.panelEx1.Controls.Add(this.cbo_TheoDV);
            this.panelEx1.Controls.Add(this.dp_ChonNgay);
            this.panelEx1.Controls.Add(this.lbl_Theo);
            this.panelEx1.Controls.Add(this.lbl_ChonNgay);
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(1300, 40);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 4;
            // 
            // cbo_TheoTN
            // 
            this.cbo_TheoTN.DisplayMember = "Text";
            this.cbo_TheoTN.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbo_TheoTN.FormattingEnabled = true;
            this.cbo_TheoTN.ItemHeight = 20;
            this.cbo_TheoTN.Location = new System.Drawing.Point(395, 9);
            this.cbo_TheoTN.Name = "cbo_TheoTN";
            this.cbo_TheoTN.Size = new System.Drawing.Size(147, 26);
            this.cbo_TheoTN.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbo_TheoTN.TabIndex = 10;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(274, 11);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(115, 23);
            this.labelX1.TabIndex = 9;
            this.labelX1.Text = "Đơn vị thu ngân:";
            // 
            // btn_InBaoCao
            // 
            this.btn_InBaoCao.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_InBaoCao.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_InBaoCao.Image = global::GUI.Properties.Resources.print_icon;
            this.btn_InBaoCao.Location = new System.Drawing.Point(931, 5);
            this.btn_InBaoCao.Name = "btn_InBaoCao";
            this.btn_InBaoCao.Size = new System.Drawing.Size(90, 30);
            this.btn_InBaoCao.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_InBaoCao.TabIndex = 8;
            // 
            // btn_XemBaoCao
            // 
            this.btn_XemBaoCao.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_XemBaoCao.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_XemBaoCao.Image = global::GUI.Properties.Resources.viewdoanhthu;
            this.btn_XemBaoCao.Location = new System.Drawing.Point(817, 5);
            this.btn_XemBaoCao.Name = "btn_XemBaoCao";
            this.btn_XemBaoCao.Size = new System.Drawing.Size(90, 30);
            this.btn_XemBaoCao.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_XemBaoCao.TabIndex = 7;
            this.btn_XemBaoCao.Click += new System.EventHandler(this.btn_XemBaoCao_Click);
            // 
            // cbo_TheoDV
            // 
            this.cbo_TheoDV.DisplayMember = "Text";
            this.cbo_TheoDV.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbo_TheoDV.FormattingEnabled = true;
            this.cbo_TheoDV.ItemHeight = 20;
            this.cbo_TheoDV.Items.AddRange(new object[] {
            this.comboItem1,
            this.comboItem2});
            this.cbo_TheoDV.Location = new System.Drawing.Point(123, 9);
            this.cbo_TheoDV.Name = "cbo_TheoDV";
            this.cbo_TheoDV.Size = new System.Drawing.Size(145, 26);
            this.cbo_TheoDV.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbo_TheoDV.TabIndex = 6;
            // 
            // comboItem1
            // 
            this.comboItem1.Text = "Nhóm dịch vụ";
            // 
            // comboItem2
            // 
            this.comboItem2.Text = "Đơn vị thu ngân";
            // 
            // dp_ChonNgay
            // 
            // 
            // 
            // 
            this.dp_ChonNgay.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dp_ChonNgay.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dp_ChonNgay.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dp_ChonNgay.ButtonDropDown.Visible = true;
            this.dp_ChonNgay.IsPopupCalendarOpen = false;
            this.dp_ChonNgay.Location = new System.Drawing.Point(654, 9);
            // 
            // 
            // 
            this.dp_ChonNgay.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dp_ChonNgay.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dp_ChonNgay.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dp_ChonNgay.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dp_ChonNgay.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dp_ChonNgay.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dp_ChonNgay.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dp_ChonNgay.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dp_ChonNgay.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dp_ChonNgay.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dp_ChonNgay.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dp_ChonNgay.MonthCalendar.DisplayMonth = new System.DateTime(2013, 6, 1, 0, 0, 0, 0);
            this.dp_ChonNgay.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dp_ChonNgay.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dp_ChonNgay.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dp_ChonNgay.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dp_ChonNgay.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dp_ChonNgay.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dp_ChonNgay.MonthCalendar.TodayButtonVisible = true;
            this.dp_ChonNgay.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dp_ChonNgay.Name = "dp_ChonNgay";
            this.dp_ChonNgay.Size = new System.Drawing.Size(110, 26);
            this.dp_ChonNgay.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dp_ChonNgay.TabIndex = 4;
            // 
            // lbl_Theo
            // 
            // 
            // 
            // 
            this.lbl_Theo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_Theo.Location = new System.Drawing.Point(12, 11);
            this.lbl_Theo.Name = "lbl_Theo";
            this.lbl_Theo.Size = new System.Drawing.Size(105, 23);
            this.lbl_Theo.TabIndex = 0;
            this.lbl_Theo.Text = "Nhóm dịch vụ:";
            // 
            // lbl_ChonNgay
            // 
            // 
            // 
            // 
            this.lbl_ChonNgay.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_ChonNgay.Location = new System.Drawing.Point(571, 9);
            this.lbl_ChonNgay.Name = "lbl_ChonNgay";
            this.lbl_ChonNgay.Size = new System.Drawing.Size(75, 23);
            this.lbl_ChonNgay.TabIndex = 0;
            this.lbl_ChonNgay.Text = "Chọn ngày";
            // 
            // dataGridViewX1
            // 
            this.dataGridViewX1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewX1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridViewX1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewX1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewX1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.TenThuNgan,
            this.MaBienLai,
            this.TenBenhNhan,
            this.Tuoi,
            this.GioiTinh,
            this.ThoiGian,
            this.TongTien,
            this.NhomDichVu});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewX1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewX1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewX1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataGridViewX1.Location = new System.Drawing.Point(0, 40);
            this.dataGridViewX1.Name = "dataGridViewX1";
            this.dataGridViewX1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewX1.Size = new System.Drawing.Size(1300, 309);
            this.dataGridViewX1.TabIndex = 5;
            this.dataGridViewX1.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridViewX1_RowsAdded);
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            // 
            // TenThuNgan
            // 
            this.TenThuNgan.DataPropertyName = "_tendvtn";
            this.TenThuNgan.HeaderText = "Tên đơn vị thu ngân";
            this.TenThuNgan.Name = "TenThuNgan";
            // 
            // MaBienLai
            // 
            this.MaBienLai.DataPropertyName = "_mabl";
            this.MaBienLai.HeaderText = "Mã hóa đơn";
            this.MaBienLai.Name = "MaBienLai";
            // 
            // TenBenhNhan
            // 
            this.TenBenhNhan.DataPropertyName = "_tenbn";
            this.TenBenhNhan.HeaderText = "Tên bệnh nhân";
            this.TenBenhNhan.Name = "TenBenhNhan";
            // 
            // Tuoi
            // 
            this.Tuoi.DataPropertyName = "_tuoi";
            this.Tuoi.HeaderText = "Tuổi";
            this.Tuoi.Name = "Tuoi";
            // 
            // GioiTinh
            // 
            this.GioiTinh.DataPropertyName = "_gioitinh";
            this.GioiTinh.HeaderText = "Giới tính";
            this.GioiTinh.Name = "GioiTinh";
            // 
            // ThoiGian
            // 
            this.ThoiGian.DataPropertyName = "_thoigian";
            this.ThoiGian.HeaderText = "Ngày lập";
            this.ThoiGian.Name = "ThoiGian";
            // 
            // TongTien
            // 
            this.TongTien.DataPropertyName = "_tongtien";
            this.TongTien.HeaderText = "Tổng tiền";
            this.TongTien.Name = "TongTien";
            // 
            // NhomDichVu
            // 
            this.NhomDichVu.DataPropertyName = "_nhomdv";
            this.NhomDichVu.HeaderText = "Nhóm dịch vụ";
            this.NhomDichVu.Name = "NhomDichVu";
            // 
            // ribbonOrbMenuItem1
            // 
            this.ribbonOrbMenuItem1.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonOrbMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("ribbonOrbMenuItem1.Image")));
            this.ribbonOrbMenuItem1.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonOrbMenuItem1.SmallImage")));
            // 
            // ribbonHost1
            // 
            this.ribbonHost1.HostedControl = null;
            // 
            // panelEx2
            // 
            this.panelEx2.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx2.Controls.Add(this.labelX2);
            this.panelEx2.Controls.Add(this.lbl_Tongbienlai);
            this.panelEx2.Controls.Add(this.labelX3);
            this.panelEx2.Controls.Add(this.lbl_Tongtien);
            this.panelEx2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelEx2.Location = new System.Drawing.Point(0, 322);
            this.panelEx2.Name = "panelEx2";
            this.panelEx2.Size = new System.Drawing.Size(1300, 27);
            this.panelEx2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx2.Style.GradientAngle = 90;
            this.panelEx2.TabIndex = 6;
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.Location = new System.Drawing.Point(820, 4);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(95, 23);
            this.labelX2.TabIndex = 4;
            this.labelX2.Text = "Tổng tiền:";
            // 
            // lbl_Tongbienlai
            // 
            // 
            // 
            // 
            this.lbl_Tongbienlai.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_Tongbienlai.ForeColor = System.Drawing.Color.Red;
            this.lbl_Tongbienlai.Location = new System.Drawing.Point(1143, 4);
            this.lbl_Tongbienlai.Name = "lbl_Tongbienlai";
            this.lbl_Tongbienlai.Size = new System.Drawing.Size(75, 23);
            this.lbl_Tongbienlai.TabIndex = 3;
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX3.Location = new System.Drawing.Point(1001, 4);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(136, 23);
            this.labelX3.TabIndex = 2;
            this.labelX3.Text = "Tổng số biên lai:";
            // 
            // lbl_Tongtien
            // 
            // 
            // 
            // 
            this.lbl_Tongtien.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_Tongtien.ForeColor = System.Drawing.Color.Red;
            this.lbl_Tongtien.Location = new System.Drawing.Point(921, 4);
            this.lbl_Tongtien.Name = "lbl_Tongtien";
            this.lbl_Tongtien.Size = new System.Drawing.Size(94, 23);
            this.lbl_Tongtien.TabIndex = 1;
            // 
            // frm_ListBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1300, 349);
            this.Controls.Add(this.panelEx2);
            this.Controls.Add(this.dataGridViewX1);
            this.Controls.Add(this.panelEx1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frm_ListBill";
            this.Load += new System.EventHandler(this.frm_ListBill_Load);
            this.panelEx1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dp_ChonNgay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).EndInit();
            this.panelEx2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.ButtonX btn_InBaoCao;
        private DevComponents.DotNetBar.ButtonX btn_XemBaoCao;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbo_TheoDV;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dp_ChonNgay;
        private DevComponents.DotNetBar.LabelX lbl_Theo;
        private DevComponents.DotNetBar.LabelX lbl_ChonNgay;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewX1;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenThuNgan;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaBienLai;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenBenhNhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tuoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThoiGian;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn NhomDichVu;
        private DevComponents.Editors.ComboItem comboItem1;
        private DevComponents.Editors.ComboItem comboItem2;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbo_TheoTN;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.RibbonOrbMenuItem ribbonOrbMenuItem1;
        private System.Windows.Forms.RibbonHost ribbonHost1;
        private DevComponents.DotNetBar.PanelEx panelEx2;
        private DevComponents.DotNetBar.LabelX lbl_Tongbienlai;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX lbl_Tongtien;
        private DevComponents.DotNetBar.LabelX labelX2;


    }
}