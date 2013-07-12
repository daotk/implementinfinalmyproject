﻿using System.Windows.Forms;
namespace GUI.BaoCao
{
    partial class DSBienLaiDuocThuTien
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.lbl_thang = new DevComponents.DotNetBar.LabelX();
            this.cbo_Thang = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.btn_InBaoCao = new DevComponents.DotNetBar.ButtonX();
            this.btn_XemBaoCao = new DevComponents.DotNetBar.ButtonX();
            this.cbo_Theo = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem3 = new DevComponents.Editors.ComboItem();
            this.comboItem4 = new DevComponents.Editors.ComboItem();
            this.dp_DenNgay = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.dp_TuNgay = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.rad_TheoThang = new System.Windows.Forms.RadioButton();
            this.rad_TheoTuan = new System.Windows.Forms.RadioButton();
            this.rad_TheoNgay = new System.Windows.Forms.RadioButton();
            this.lbl_Theo = new DevComponents.DotNetBar.LabelX();
            this.lbl_DenNgay = new DevComponents.DotNetBar.LabelX();
            this.lbl_TuNgay = new DevComponents.DotNetBar.LabelX();
            this.grd_BaoCao = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.panelEx3 = new DevComponents.DotNetBar.PanelEx();
            this.lbl_Tien = new DevComponents.DotNetBar.LabelX();
            this.lbl_Tongbienlai = new DevComponents.DotNetBar.LabelX();
            this.lbl_TongBL = new DevComponents.DotNetBar.LabelX();
            this.lbl_Tongtien = new DevComponents.DotNetBar.LabelX();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.USERNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BILLID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PATIENTNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PATIENTAGE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GENDER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATETIME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COST = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SERVICEGROUPNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BILLSTATUS = new DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn();
            this.panelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dp_DenNgay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dp_TuNgay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_BaoCao)).BeginInit();
            this.panelEx3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.lbl_thang);
            this.panelEx1.Controls.Add(this.cbo_Thang);
            this.panelEx1.Controls.Add(this.btn_InBaoCao);
            this.panelEx1.Controls.Add(this.btn_XemBaoCao);
            this.panelEx1.Controls.Add(this.cbo_Theo);
            this.panelEx1.Controls.Add(this.dp_DenNgay);
            this.panelEx1.Controls.Add(this.dp_TuNgay);
            this.panelEx1.Controls.Add(this.rad_TheoThang);
            this.panelEx1.Controls.Add(this.rad_TheoTuan);
            this.panelEx1.Controls.Add(this.rad_TheoNgay);
            this.panelEx1.Controls.Add(this.lbl_Theo);
            this.panelEx1.Controls.Add(this.lbl_DenNgay);
            this.panelEx1.Controls.Add(this.lbl_TuNgay);
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
            this.panelEx1.TabIndex = 3;
            // 
            // lbl_thang
            // 
            // 
            // 
            // 
            this.lbl_thang.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_thang.Location = new System.Drawing.Point(340, 8);
            this.lbl_thang.Name = "lbl_thang";
            this.lbl_thang.Size = new System.Drawing.Size(75, 23);
            this.lbl_thang.TabIndex = 5;
            this.lbl_thang.Text = "Chọn tháng";
            // 
            // cbo_Thang
            // 
            this.cbo_Thang.DisplayMember = "Text";
            this.cbo_Thang.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbo_Thang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_Thang.FormattingEnabled = true;
            this.cbo_Thang.ItemHeight = 20;
            this.cbo_Thang.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbo_Thang.Location = new System.Drawing.Point(423, 6);
            this.cbo_Thang.Name = "cbo_Thang";
            this.cbo_Thang.Size = new System.Drawing.Size(145, 26);
            this.cbo_Thang.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbo_Thang.TabIndex = 5;
            // 
            // btn_InBaoCao
            // 
            this.btn_InBaoCao.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_InBaoCao.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_InBaoCao.Image = global::GUI.Properties.Resources.print_icon;
            this.btn_InBaoCao.Location = new System.Drawing.Point(1165, 5);
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
            this.btn_XemBaoCao.Location = new System.Drawing.Point(1029, 5);
            this.btn_XemBaoCao.Name = "btn_XemBaoCao";
            this.btn_XemBaoCao.Size = new System.Drawing.Size(90, 30);
            this.btn_XemBaoCao.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_XemBaoCao.TabIndex = 7;
            this.btn_XemBaoCao.Click += new System.EventHandler(this.btn_XemBaoCao_Click);
            // 
            // cbo_Theo
            // 
            this.cbo_Theo.DisplayMember = "Text";
            this.cbo_Theo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbo_Theo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_Theo.FormattingEnabled = true;
            this.cbo_Theo.ItemHeight = 20;
            this.cbo_Theo.Items.AddRange(new object[] {
            this.comboItem3,
            this.comboItem4});
            this.cbo_Theo.Location = new System.Drawing.Point(827, 5);
            this.cbo_Theo.Name = "cbo_Theo";
            this.cbo_Theo.Size = new System.Drawing.Size(145, 26);
            this.cbo_Theo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbo_Theo.TabIndex = 6;
            // 
            // comboItem3
            // 
            this.comboItem3.Text = "Nguyễn Văn A";
            // 
            // comboItem4
            // 
            this.comboItem4.Text = "Nguyễn Văn B";
            // 
            // dp_DenNgay
            // 
            // 
            // 
            // 
            this.dp_DenNgay.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dp_DenNgay.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dp_DenNgay.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dp_DenNgay.ButtonDropDown.Visible = true;
            this.dp_DenNgay.IsPopupCalendarOpen = false;
            this.dp_DenNgay.Location = new System.Drawing.Point(634, 6);
            // 
            // 
            // 
            this.dp_DenNgay.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dp_DenNgay.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dp_DenNgay.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dp_DenNgay.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dp_DenNgay.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dp_DenNgay.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dp_DenNgay.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dp_DenNgay.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dp_DenNgay.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dp_DenNgay.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dp_DenNgay.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dp_DenNgay.MonthCalendar.DisplayMonth = new System.DateTime(2013, 6, 1, 0, 0, 0, 0);
            this.dp_DenNgay.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dp_DenNgay.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dp_DenNgay.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dp_DenNgay.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dp_DenNgay.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dp_DenNgay.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dp_DenNgay.MonthCalendar.TodayButtonVisible = true;
            this.dp_DenNgay.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dp_DenNgay.Name = "dp_DenNgay";
            this.dp_DenNgay.Size = new System.Drawing.Size(110, 26);
            this.dp_DenNgay.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dp_DenNgay.TabIndex = 5;
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
            this.dp_TuNgay.Location = new System.Drawing.Point(415, 6);
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
            this.dp_TuNgay.MonthCalendar.DateChanged += new System.EventHandler(this.dp_TuNgay_MonthCalendar_DateChanged);
            this.dp_TuNgay.Name = "dp_TuNgay";
            this.dp_TuNgay.Size = new System.Drawing.Size(110, 26);
            this.dp_TuNgay.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dp_TuNgay.TabIndex = 4;
            this.dp_TuNgay.ValueChanged += new System.EventHandler(this.dp_TuNgay_ValueChanged);
            // 
            // rad_TheoThang
            // 
            this.rad_TheoThang.AutoSize = true;
            this.rad_TheoThang.Location = new System.Drawing.Point(234, 9);
            this.rad_TheoThang.Name = "rad_TheoThang";
            this.rad_TheoThang.Size = new System.Drawing.Size(94, 23);
            this.rad_TheoThang.TabIndex = 3;
            this.rad_TheoThang.TabStop = true;
            this.rad_TheoThang.Text = "Theo tháng";
            this.rad_TheoThang.UseVisualStyleBackColor = true;
            this.rad_TheoThang.CheckedChanged += new System.EventHandler(this.rad_TheoThang_CheckedChanged);
            // 
            // rad_TheoTuan
            // 
            this.rad_TheoTuan.AutoSize = true;
            this.rad_TheoTuan.Location = new System.Drawing.Point(141, 9);
            this.rad_TheoTuan.Name = "rad_TheoTuan";
            this.rad_TheoTuan.Size = new System.Drawing.Size(87, 23);
            this.rad_TheoTuan.TabIndex = 2;
            this.rad_TheoTuan.TabStop = true;
            this.rad_TheoTuan.Text = "Theo tuần";
            this.rad_TheoTuan.UseVisualStyleBackColor = true;
            this.rad_TheoTuan.CheckedChanged += new System.EventHandler(this.rad_TheoTuan_CheckedChanged);
            // 
            // rad_TheoNgay
            // 
            this.rad_TheoNgay.AutoSize = true;
            this.rad_TheoNgay.Location = new System.Drawing.Point(28, 8);
            this.rad_TheoNgay.Name = "rad_TheoNgay";
            this.rad_TheoNgay.Size = new System.Drawing.Size(90, 23);
            this.rad_TheoNgay.TabIndex = 1;
            this.rad_TheoNgay.TabStop = true;
            this.rad_TheoNgay.Text = "Theo ngày";
            this.rad_TheoNgay.UseVisualStyleBackColor = true;
            this.rad_TheoNgay.CheckedChanged += new System.EventHandler(this.rad_TheoNgay_CheckedChanged_1);
            // 
            // lbl_Theo
            // 
            // 
            // 
            // 
            this.lbl_Theo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_Theo.Location = new System.Drawing.Point(775, 7);
            this.lbl_Theo.Name = "lbl_Theo";
            this.lbl_Theo.Size = new System.Drawing.Size(75, 23);
            this.lbl_Theo.TabIndex = 0;
            this.lbl_Theo.Text = "Theo";
            // 
            // lbl_DenNgay
            // 
            // 
            // 
            // 
            this.lbl_DenNgay.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_DenNgay.Location = new System.Drawing.Point(566, 9);
            this.lbl_DenNgay.Name = "lbl_DenNgay";
            this.lbl_DenNgay.Size = new System.Drawing.Size(75, 23);
            this.lbl_DenNgay.TabIndex = 0;
            this.lbl_DenNgay.Text = "đến ngày";
            // 
            // lbl_TuNgay
            // 
            // 
            // 
            // 
            this.lbl_TuNgay.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_TuNgay.Location = new System.Drawing.Point(334, 8);
            this.lbl_TuNgay.Name = "lbl_TuNgay";
            this.lbl_TuNgay.Size = new System.Drawing.Size(75, 23);
            this.lbl_TuNgay.TabIndex = 0;
            this.lbl_TuNgay.Text = "Từ ngày";
            // 
            // grd_BaoCao
            // 
            this.grd_BaoCao.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grd_BaoCao.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.grd_BaoCao.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grd_BaoCao.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grd_BaoCao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_BaoCao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.USERNAME,
            this.BILLID,
            this.PATIENTNAME,
            this.PATIENTAGE,
            this.GENDER,
            this.DATETIME,
            this.COST,
            this.SERVICEGROUPNAME,
            this.BILLSTATUS});
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
            this.grd_BaoCao.Size = new System.Drawing.Size(1300, 510);
            this.grd_BaoCao.TabIndex = 4;
            this.grd_BaoCao.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.grd_BaoCao_RowsAdded);
            // 
            // panelEx3
            // 
            this.panelEx3.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx3.Controls.Add(this.lbl_Tien);
            this.panelEx3.Controls.Add(this.lbl_Tongbienlai);
            this.panelEx3.Controls.Add(this.lbl_TongBL);
            this.panelEx3.Controls.Add(this.lbl_Tongtien);
            this.panelEx3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelEx3.Location = new System.Drawing.Point(0, 517);
            this.panelEx3.Name = "panelEx3";
            this.panelEx3.Size = new System.Drawing.Size(1300, 33);
            this.panelEx3.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx3.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx3.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx3.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx3.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx3.Style.GradientAngle = 90;
            this.panelEx3.TabIndex = 7;
            // 
            // lbl_Tien
            // 
            // 
            // 
            // 
            this.lbl_Tien.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_Tien.Location = new System.Drawing.Point(968, 7);
            this.lbl_Tien.Name = "lbl_Tien";
            this.lbl_Tien.Size = new System.Drawing.Size(75, 23);
            this.lbl_Tien.TabIndex = 4;
            this.lbl_Tien.Text = "Tổng tiền:";
            // 
            // lbl_Tongbienlai
            // 
            // 
            // 
            // 
            this.lbl_Tongbienlai.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_Tongbienlai.ForeColor = System.Drawing.Color.Red;
            this.lbl_Tongbienlai.Location = new System.Drawing.Point(859, 7);
            this.lbl_Tongbienlai.Name = "lbl_Tongbienlai";
            this.lbl_Tongbienlai.Size = new System.Drawing.Size(75, 23);
            this.lbl_Tongbienlai.TabIndex = 3;
            this.lbl_Tongbienlai.Text = "0";
            // 
            // lbl_TongBL
            // 
            // 
            // 
            // 
            this.lbl_TongBL.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_TongBL.Location = new System.Drawing.Point(737, 7);
            this.lbl_TongBL.Name = "lbl_TongBL";
            this.lbl_TongBL.Size = new System.Drawing.Size(116, 23);
            this.lbl_TongBL.TabIndex = 2;
            this.lbl_TongBL.Text = "Tổng số biên lai:";
            // 
            // lbl_Tongtien
            // 
            // 
            // 
            // 
            this.lbl_Tongtien.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_Tongtien.ForeColor = System.Drawing.Color.Red;
            this.lbl_Tongtien.Location = new System.Drawing.Point(1049, 7);
            this.lbl_Tongtien.Name = "lbl_Tongtien";
            this.lbl_Tongtien.Size = new System.Drawing.Size(94, 23);
            this.lbl_Tongtien.TabIndex = 1;
            this.lbl_Tongtien.Text = "0";
            // 
            // STT
            // 
            this.STT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.STT.FillWeight = 41F;
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            this.STT.Width = 61;
            // 
            // USERNAME
            // 
            this.USERNAME.DataPropertyName = "_USERNAME";
            this.USERNAME.FillWeight = 77.66498F;
            this.USERNAME.HeaderText = "Tên Nhân Viên";
            this.USERNAME.Name = "USERNAME";
            this.USERNAME.ReadOnly = true;
            // 
            // BILLID
            // 
            this.BILLID.DataPropertyName = "_BILLID";
            this.BILLID.FillWeight = 77.66498F;
            this.BILLID.HeaderText = "Mã Hóa Đơn";
            this.BILLID.Name = "BILLID";
            this.BILLID.ReadOnly = true;
            // 
            // PATIENTNAME
            // 
            this.PATIENTNAME.DataPropertyName = "_PATIENTNAME";
            this.PATIENTNAME.FillWeight = 77.66498F;
            this.PATIENTNAME.HeaderText = "Họ Tên BN";
            this.PATIENTNAME.Name = "PATIENTNAME";
            this.PATIENTNAME.ReadOnly = true;
            // 
            // PATIENTAGE
            // 
            this.PATIENTAGE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.PATIENTAGE.DataPropertyName = "_PATIENTAGE";
            this.PATIENTAGE.FillWeight = 50F;
            this.PATIENTAGE.HeaderText = "Tuổi BN";
            this.PATIENTAGE.Name = "PATIENTAGE";
            this.PATIENTAGE.ReadOnly = true;
            this.PATIENTAGE.Width = 86;
            // 
            // GENDER
            // 
            this.GENDER.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.GENDER.DataPropertyName = "_PATIENTGENDER";
            this.GENDER.FillWeight = 50F;
            this.GENDER.HeaderText = "Giới Tính";
            this.GENDER.Name = "GENDER";
            this.GENDER.ReadOnly = true;
            this.GENDER.Width = 90;
            // 
            // DATETIME
            // 
            this.DATETIME.DataPropertyName = "_BILLDATE";
            this.DATETIME.FillWeight = 77.66498F;
            this.DATETIME.HeaderText = "Ngày Lập";
            this.DATETIME.Name = "DATETIME";
            this.DATETIME.ReadOnly = true;
            // 
            // COST
            // 
            this.COST.DataPropertyName = "_BILLCOST";
            this.COST.FillWeight = 77.66498F;
            this.COST.HeaderText = "Tổng Tiền";
            this.COST.Name = "COST";
            this.COST.ReadOnly = true;
            // 
            // SERVICEGROUPNAME
            // 
            this.SERVICEGROUPNAME.DataPropertyName = "_SERVICEGROUPNAME";
            this.SERVICEGROUPNAME.FillWeight = 77.66498F;
            this.SERVICEGROUPNAME.HeaderText = "Nhóm Dịch Vụ";
            this.SERVICEGROUPNAME.Name = "SERVICEGROUPNAME";
            this.SERVICEGROUPNAME.ReadOnly = true;
            // 
            // BILLSTATUS
            // 
            this.BILLSTATUS.Checked = true;
            this.BILLSTATUS.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.BILLSTATUS.CheckValue = null;
            this.BILLSTATUS.DataPropertyName = "_BILLSTATUS";
            this.BILLSTATUS.HeaderText = "Trạng Thái";
            this.BILLSTATUS.Name = "BILLSTATUS";
            this.BILLSTATUS.ReadOnly = true;
            this.BILLSTATUS.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.BILLSTATUS.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.BILLSTATUS.Visible = false;
            // 
            // DSBienLaiDuocThuTien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1300, 550);
            this.Controls.Add(this.panelEx3);
            this.Controls.Add(this.grd_BaoCao);
            this.Controls.Add(this.panelEx1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DSBienLaiDuocThuTien";
            this.Text = "DSHoaDonDuocLap";
            this.Load += new System.EventHandler(this.DSBienLaiDuocThuTien_Load);
            this.panelEx1.ResumeLayout(false);
            this.panelEx1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dp_DenNgay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dp_TuNgay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_BaoCao)).EndInit();
            this.panelEx3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.ButtonX btn_InBaoCao;
        private DevComponents.DotNetBar.ButtonX btn_XemBaoCao;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbo_Theo;
        private DevComponents.Editors.ComboItem comboItem3;
        private DevComponents.Editors.ComboItem comboItem4;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dp_DenNgay;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dp_TuNgay;
        private System.Windows.Forms.RadioButton rad_TheoThang;
        private System.Windows.Forms.RadioButton rad_TheoTuan;
        private System.Windows.Forms.RadioButton rad_TheoNgay;
        private DevComponents.DotNetBar.LabelX lbl_Theo;
        private DevComponents.DotNetBar.LabelX lbl_DenNgay;
        private DevComponents.DotNetBar.LabelX lbl_TuNgay;
        private DevComponents.DotNetBar.Controls.DataGridViewX grd_BaoCao;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbo_Thang;
        private DevComponents.DotNetBar.LabelX lbl_thang;
        private DevComponents.DotNetBar.PanelEx panelEx3;
        private DevComponents.DotNetBar.LabelX lbl_Tien;
        private DevComponents.DotNetBar.LabelX lbl_Tongbienlai;
        private DevComponents.DotNetBar.LabelX lbl_TongBL;
        private DevComponents.DotNetBar.LabelX lbl_Tongtien;
        private DataGridViewTextBoxColumn STT;
        private DataGridViewTextBoxColumn USERNAME;
        private DataGridViewTextBoxColumn BILLID;
        private DataGridViewTextBoxColumn PATIENTNAME;
        private DataGridViewTextBoxColumn PATIENTAGE;
        private DataGridViewTextBoxColumn GENDER;
        private DataGridViewTextBoxColumn DATETIME;
        private DataGridViewTextBoxColumn COST;
        private DataGridViewTextBoxColumn SERVICEGROUPNAME;
        private DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn BILLSTATUS;

    }
}