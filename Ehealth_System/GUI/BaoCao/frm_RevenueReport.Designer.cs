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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.dp_TuNgay = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.lbl_ChonNgay = new DevComponents.DotNetBar.LabelX();
            this.grd_BaoCao = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.panelEx2 = new DevComponents.DotNetBar.PanelEx();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDonViThuNgan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dp_TuNgay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_BaoCao)).BeginInit();
            this.panelEx2.SuspendLayout();
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
            this.panelEx1.Controls.Add(this.dp_TuNgay);
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
            this.cbo_DonVi.Location = new System.Drawing.Point(202, 6);
            this.cbo_DonVi.Name = "cbo_DonVi";
            this.cbo_DonVi.Size = new System.Drawing.Size(274, 26);
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
            this.lbl_DonVi.Location = new System.Drawing.Point(73, 7);
            this.lbl_DonVi.Name = "lbl_DonVi";
            this.lbl_DonVi.Size = new System.Drawing.Size(123, 23);
            this.lbl_DonVi.TabIndex = 2;
            this.lbl_DonVi.Text = "Đơn vị thu tiền";
            // 
            // rad_TheoTuan
            // 
            this.rad_TheoTuan.AutoSize = true;
            this.rad_TheoTuan.Location = new System.Drawing.Point(633, 10);
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
            this.rad_TheoNgay.Location = new System.Drawing.Point(526, 10);
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
            this.rad_TheoThang.Location = new System.Drawing.Point(737, 9);
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
            this.grd_BaoCao.AllowUserToAddRows = false;
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
            this.TenDonViThuNgan,
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
            this.grd_BaoCao.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.grd_BaoCao_RowsAdded);
            this.grd_BaoCao.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.grd_BaoCao_RowsRemoved);
            // 
            // panelEx2
            // 
            this.panelEx2.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx2.Controls.Add(this.labelX4);
            this.panelEx2.Controls.Add(this.labelX3);
            this.panelEx2.Controls.Add(this.labelX2);
            this.panelEx2.Controls.Add(this.labelX1);
            this.panelEx2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelEx2.Location = new System.Drawing.Point(0, 519);
            this.panelEx2.Name = "panelEx2";
            this.panelEx2.Size = new System.Drawing.Size(1256, 31);
            this.panelEx2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx2.Style.GradientAngle = 90;
            this.panelEx2.TabIndex = 2;
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX4.ForeColor = System.Drawing.Color.Red;
            this.labelX4.Location = new System.Drawing.Point(1111, 4);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(164, 23);
            this.labelX4.TabIndex = 3;
            this.labelX4.Text = "0";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX3.Location = new System.Drawing.Point(1015, 4);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(117, 23);
            this.labelX3.TabIndex = 2;
            this.labelX3.Text = "Tổng số tiền:";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.ForeColor = System.Drawing.Color.Red;
            this.labelX2.Location = new System.Drawing.Point(940, 3);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(92, 23);
            this.labelX2.TabIndex = 1;
            this.labelX2.Text = "0";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.Location = new System.Drawing.Point(826, 4);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(154, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Tổng số biên lai:";
            // 
            // STT
            // 
            this.STT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.STT.DataPropertyName = "(none)";
            this.STT.FillWeight = 41.99583F;
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            this.STT.Width = 61;
            // 
            // TenDonViThuNgan
            // 
            this.TenDonViThuNgan.DataPropertyName = "tendonvithungan_";
            this.TenDonViThuNgan.FillWeight = 120.0315F;
            this.TenDonViThuNgan.HeaderText = "Đơn vị thu ngân";
            this.TenDonViThuNgan.Name = "TenDonViThuNgan";
            this.TenDonViThuNgan.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Date.DataPropertyName = "ngaydangky_";
            this.Date.FillWeight = 102.0263F;
            this.Date.HeaderText = "Ngày";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.Width = 360;
            // 
            // TongTien
            // 
            this.TongTien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.TongTien.DataPropertyName = "tongtien_";
            this.TongTien.FillWeight = 162.9748F;
            this.TongTien.HeaderText = "Tổng tiền BL";
            this.TongTien.Name = "TongTien";
            this.TongTien.ReadOnly = true;
            this.TongTien.Width = 370;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column5.DataPropertyName = "tennhomdichvu_";
            this.Column5.FillWeight = 114.2132F;
            this.Column5.HeaderText = "Tổng số biên lai";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 180;
            // 
            // DoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1256, 550);
            this.Controls.Add(this.panelEx2);
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
            this.panelEx2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.Editors.ComboItem comboItem2;
        private DevComponents.Editors.ComboItem comboItem1;
        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.LabelX lbl_ChonNgay;
        private DevComponents.DotNetBar.ButtonX btn_XemBaoCao;
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
        private DevComponents.DotNetBar.PanelEx panelEx2;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDonViThuNgan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;


    }
}