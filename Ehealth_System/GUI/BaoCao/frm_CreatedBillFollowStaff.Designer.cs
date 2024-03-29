﻿using System.Windows.Forms;
namespace GUI.BaoCao
{
    partial class frm_CreatedBillFollowStaff
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_InBaoCao = new DevComponents.DotNetBar.ButtonX();
            this.cbo_Theo = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem3 = new DevComponents.Editors.ComboItem();
            this.comboItem4 = new DevComponents.Editors.ComboItem();
            this.grd_BaoCao = new DevComponents.DotNetBar.Controls.DataGridViewX();
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
            this.dp_DenNgay = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.dp_TuNgay = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.comboItem1 = new DevComponents.Editors.ComboItem();
            this.rad_TheoThang = new System.Windows.Forms.RadioButton();
            this.rad_TheoTuan = new System.Windows.Forms.RadioButton();
            this.rad_TheoNgay = new System.Windows.Forms.RadioButton();
            this.comboItem2 = new DevComponents.Editors.ComboItem();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.cbo_Thang = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.lbl_ChonThang = new DevComponents.DotNetBar.LabelX();
            this.btn_BaoCao = new DevComponents.DotNetBar.ButtonX();
            this.lbl_Theo = new DevComponents.DotNetBar.LabelX();
            this.lbl_DenNgay = new DevComponents.DotNetBar.LabelX();
            this.lbl_TuNgay = new DevComponents.DotNetBar.LabelX();
            this.comboItem5 = new DevComponents.Editors.ComboItem();
            this.comboItem6 = new DevComponents.Editors.ComboItem();
            this.panelEx2 = new DevComponents.DotNetBar.PanelEx();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.lbl_Tongbienlai = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.lbl_Tongtien = new DevComponents.DotNetBar.LabelX();
            ((System.ComponentModel.ISupportInitialize)(this.grd_BaoCao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dp_DenNgay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dp_TuNgay)).BeginInit();
            this.panelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_Thang)).BeginInit();
            this.panelEx2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_InBaoCao
            // 
            this.btn_InBaoCao.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_InBaoCao.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_InBaoCao.Image = global::GUI.Properties.Resources.print_icon;
            this.btn_InBaoCao.Location = new System.Drawing.Point(1174, 6);
            this.btn_InBaoCao.Name = "btn_InBaoCao";
            this.btn_InBaoCao.Size = new System.Drawing.Size(90, 30);
            this.btn_InBaoCao.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_InBaoCao.TabIndex = 8;
            this.btn_InBaoCao.Text = "In";
            this.btn_InBaoCao.Click += new System.EventHandler(this.btn_InBaoCao_Click);
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
            this.cbo_Theo.Location = new System.Drawing.Point(869, 7);
            this.cbo_Theo.Name = "cbo_Theo";
            this.cbo_Theo.Size = new System.Drawing.Size(145, 26);
            this.cbo_Theo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbo_Theo.TabIndex = 6;
            // 
            // grd_BaoCao
            // 
            this.grd_BaoCao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grd_BaoCao.DefaultCellStyle = dataGridViewCellStyle4;
            this.grd_BaoCao.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.grd_BaoCao.Location = new System.Drawing.Point(0, 40);
            this.grd_BaoCao.MultiSelect = false;
            this.grd_BaoCao.Name = "grd_BaoCao";
            this.grd_BaoCao.ReadOnly = true;
            this.grd_BaoCao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grd_BaoCao.Size = new System.Drawing.Size(1300, 476);
            this.grd_BaoCao.TabIndex = 3;
            this.grd_BaoCao.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.grd_BaoCao_RowsAdded);
            // 
            // STT
            // 
            this.STT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            this.STT.Width = 61;
            // 
            // USERNAME
            // 
            this.USERNAME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.USERNAME.DataPropertyName = "_USERNAME";
            this.USERNAME.HeaderText = "Tên nhân viên";
            this.USERNAME.Name = "USERNAME";
            this.USERNAME.ReadOnly = true;
            this.USERNAME.Width = 200;
            // 
            // BILLID
            // 
            this.BILLID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.BILLID.DataPropertyName = "_BILLID";
            this.BILLID.FillWeight = 110F;
            this.BILLID.HeaderText = "Mã hóa đơn";
            this.BILLID.Name = "BILLID";
            this.BILLID.ReadOnly = true;
            this.BILLID.Width = 149;
            // 
            // PATIENTNAME
            // 
            this.PATIENTNAME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.PATIENTNAME.DataPropertyName = "_PATIENTNAME";
            this.PATIENTNAME.HeaderText = "Họ Tên BN";
            this.PATIENTNAME.Name = "PATIENTNAME";
            this.PATIENTNAME.ReadOnly = true;
            this.PATIENTNAME.Width = 200;
            // 
            // PATIENTAGE
            // 
            this.PATIENTAGE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.PATIENTAGE.DataPropertyName = "_PATIENTAGE";
            this.PATIENTAGE.HeaderText = "Tuổi BN";
            this.PATIENTAGE.Name = "PATIENTAGE";
            this.PATIENTAGE.ReadOnly = true;
            this.PATIENTAGE.Width = 86;
            // 
            // GENDER
            // 
            this.GENDER.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.GENDER.DataPropertyName = "_PATIENTGENDER";
            this.GENDER.HeaderText = "Giới tính";
            this.GENDER.Name = "GENDER";
            this.GENDER.ReadOnly = true;
            this.GENDER.Width = 85;
            // 
            // DATETIME
            // 
            this.DATETIME.DataPropertyName = "_BILLDATE";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.DATETIME.DefaultCellStyle = dataGridViewCellStyle2;
            this.DATETIME.HeaderText = "Ngày lập";
            this.DATETIME.Name = "DATETIME";
            this.DATETIME.ReadOnly = true;
            // 
            // COST
            // 
            this.COST.DataPropertyName = "_BILLCOST";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.NullValue = null;
            this.COST.DefaultCellStyle = dataGridViewCellStyle3;
            this.COST.HeaderText = "Tổng tiền";
            this.COST.Name = "COST";
            this.COST.ReadOnly = true;
            // 
            // SERVICEGROUPNAME
            // 
            this.SERVICEGROUPNAME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.SERVICEGROUPNAME.DataPropertyName = "_SERVICEGROUPNAME";
            this.SERVICEGROUPNAME.HeaderText = "Nhóm dịch vụ";
            this.SERVICEGROUPNAME.Name = "SERVICEGROUPNAME";
            this.SERVICEGROUPNAME.ReadOnly = true;
            this.SERVICEGROUPNAME.Width = 200;
            // 
            // BILLSTATUS
            // 
            this.BILLSTATUS.Checked = true;
            this.BILLSTATUS.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.BILLSTATUS.CheckValue = null;
            this.BILLSTATUS.DataPropertyName = "_BILLSTATUS";
            this.BILLSTATUS.HeaderText = "Trạng Thái";
            this.BILLSTATUS.Name = "BILLSTATUS";
            this.BILLSTATUS.ReadOnly = true;
            this.BILLSTATUS.Visible = false;
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
            this.dp_DenNgay.Location = new System.Drawing.Point(629, 8);
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
            this.dp_TuNgay.Location = new System.Drawing.Point(419, 8);
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
            // comboItem1
            // 
            this.comboItem1.Text = "Nhóm dịch vụ";
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
            this.rad_TheoNgay.Location = new System.Drawing.Point(45, 9);
            this.rad_TheoNgay.Name = "rad_TheoNgay";
            this.rad_TheoNgay.Size = new System.Drawing.Size(90, 23);
            this.rad_TheoNgay.TabIndex = 1;
            this.rad_TheoNgay.TabStop = true;
            this.rad_TheoNgay.Text = "Theo ngày";
            this.rad_TheoNgay.UseVisualStyleBackColor = true;
            this.rad_TheoNgay.CheckedChanged += new System.EventHandler(this.rad_TheoNgay_CheckedChanged);
            // 
            // comboItem2
            // 
            this.comboItem2.Text = "Đơn vị thu ngân";
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.cbo_Thang);
            this.panelEx1.Controls.Add(this.lbl_ChonThang);
            this.panelEx1.Controls.Add(this.btn_InBaoCao);
            this.panelEx1.Controls.Add(this.btn_BaoCao);
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
            this.panelEx1.TabIndex = 2;
            // 
            // cbo_Thang
            // 
            // 
            // 
            // 
            this.cbo_Thang.BackgroundStyle.Class = "DateTimeInputBackground";
            this.cbo_Thang.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cbo_Thang.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.cbo_Thang.ButtonDropDown.Visible = true;
            this.cbo_Thang.IsPopupCalendarOpen = false;
            this.cbo_Thang.Location = new System.Drawing.Point(419, 8);
            // 
            // 
            // 
            this.cbo_Thang.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.cbo_Thang.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cbo_Thang.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.cbo_Thang.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.cbo_Thang.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.cbo_Thang.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.cbo_Thang.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.cbo_Thang.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.cbo_Thang.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.cbo_Thang.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.cbo_Thang.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cbo_Thang.MonthCalendar.DisplayMonth = new System.DateTime(2013, 6, 1, 0, 0, 0, 0);
            this.cbo_Thang.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.cbo_Thang.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.cbo_Thang.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.cbo_Thang.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.cbo_Thang.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.cbo_Thang.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cbo_Thang.MonthCalendar.TodayButtonVisible = true;
            this.cbo_Thang.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.cbo_Thang.MonthCalendar.DateChanged += new System.EventHandler(this.dp_TuNgay_MonthCalendar_DateChanged);
            this.cbo_Thang.Name = "cbo_Thang";
            this.cbo_Thang.Size = new System.Drawing.Size(110, 26);
            this.cbo_Thang.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbo_Thang.TabIndex = 10;
            // 
            // lbl_ChonThang
            // 
            // 
            // 
            // 
            this.lbl_ChonThang.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_ChonThang.Location = new System.Drawing.Point(334, 10);
            this.lbl_ChonThang.Name = "lbl_ChonThang";
            this.lbl_ChonThang.Size = new System.Drawing.Size(75, 23);
            this.lbl_ChonThang.TabIndex = 10;
            this.lbl_ChonThang.Text = "Chọn tháng";
            // 
            // btn_BaoCao
            // 
            this.btn_BaoCao.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_BaoCao.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_BaoCao.Image = global::GUI.Properties.Resources.viewdoanhthu;
            this.btn_BaoCao.Location = new System.Drawing.Point(1048, 5);
            this.btn_BaoCao.Name = "btn_BaoCao";
            this.btn_BaoCao.Size = new System.Drawing.Size(90, 30);
            this.btn_BaoCao.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_BaoCao.TabIndex = 7;
            this.btn_BaoCao.Text = "Xem";
            this.btn_BaoCao.Click += new System.EventHandler(this.btn_BaoCao_Click);
            // 
            // lbl_Theo
            // 
            // 
            // 
            // 
            this.lbl_Theo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_Theo.Location = new System.Drawing.Point(757, 11);
            this.lbl_Theo.Name = "lbl_Theo";
            this.lbl_Theo.Size = new System.Drawing.Size(112, 23);
            this.lbl_Theo.TabIndex = 0;
            this.lbl_Theo.Text = "Chọn nhân viên";
            // 
            // lbl_DenNgay
            // 
            // 
            // 
            // 
            this.lbl_DenNgay.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_DenNgay.Location = new System.Drawing.Point(551, 10);
            this.lbl_DenNgay.Name = "lbl_DenNgay";
            this.lbl_DenNgay.Size = new System.Drawing.Size(75, 23);
            this.lbl_DenNgay.TabIndex = 0;
            this.lbl_DenNgay.Text = "Đến ngày";
            // 
            // lbl_TuNgay
            // 
            // 
            // 
            // 
            this.lbl_TuNgay.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_TuNgay.Location = new System.Drawing.Point(337, 9);
            this.lbl_TuNgay.Name = "lbl_TuNgay";
            this.lbl_TuNgay.Size = new System.Drawing.Size(75, 23);
            this.lbl_TuNgay.TabIndex = 0;
            this.lbl_TuNgay.Text = "Từ ngày";
            // 
            // comboItem5
            // 
            this.comboItem5.Text = "Nguyễn Văn A";
            // 
            // comboItem6
            // 
            this.comboItem6.Text = "Nguyễn Văn B";
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
            this.panelEx2.Location = new System.Drawing.Point(0, 516);
            this.panelEx2.Name = "panelEx2";
            this.panelEx2.Size = new System.Drawing.Size(1300, 34);
            this.panelEx2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx2.Style.GradientAngle = 90;
            this.panelEx2.TabIndex = 7;
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(914, 6);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(75, 23);
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
            this.lbl_Tongbienlai.Location = new System.Drawing.Point(828, 6);
            this.lbl_Tongbienlai.Name = "lbl_Tongbienlai";
            this.lbl_Tongbienlai.Size = new System.Drawing.Size(75, 23);
            this.lbl_Tongbienlai.TabIndex = 3;
            this.lbl_Tongbienlai.Text = "0";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(705, 6);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(116, 23);
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
            this.lbl_Tongtien.Location = new System.Drawing.Point(995, 6);
            this.lbl_Tongtien.Name = "lbl_Tongtien";
            this.lbl_Tongtien.Size = new System.Drawing.Size(214, 23);
            this.lbl_Tongtien.TabIndex = 1;
            this.lbl_Tongtien.Text = "0";
            // 
            // frm_CreatedBillFollowStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1300, 550);
            this.Controls.Add(this.panelEx2);
            this.Controls.Add(this.grd_BaoCao);
            this.Controls.Add(this.panelEx1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frm_CreatedBillFollowStaff";
            this.Text = "DSHoaDonDuocLap";
            this.Load += new System.EventHandler(this.frm_CreatedBillFollowStaff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grd_BaoCao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dp_DenNgay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dp_TuNgay)).EndInit();
            this.panelEx1.ResumeLayout(false);
            this.panelEx1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_Thang)).EndInit();
            this.panelEx2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btn_InBaoCao;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbo_Theo;
        private DevComponents.Editors.ComboItem comboItem3;
        private DevComponents.Editors.ComboItem comboItem4;
        private DevComponents.DotNetBar.Controls.DataGridViewX grd_BaoCao;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dp_DenNgay;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dp_TuNgay;
        private DevComponents.Editors.ComboItem comboItem1;
        private System.Windows.Forms.RadioButton rad_TheoThang;
        private System.Windows.Forms.RadioButton rad_TheoTuan;
        private System.Windows.Forms.RadioButton rad_TheoNgay;
        private DevComponents.Editors.ComboItem comboItem2;
        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.LabelX lbl_Theo;
        private DevComponents.DotNetBar.LabelX lbl_DenNgay;
        private DevComponents.DotNetBar.LabelX lbl_TuNgay;
        private DevComponents.Editors.ComboItem comboItem5;
        private DevComponents.Editors.ComboItem comboItem6;
        private DevComponents.DotNetBar.LabelX lbl_ChonThang;
        private DevComponents.DotNetBar.ButtonX btn_BaoCao;
        private DevComponents.DotNetBar.PanelEx panelEx2;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX lbl_Tongbienlai;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX lbl_Tongtien;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput cbo_Thang;
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