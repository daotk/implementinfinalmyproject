namespace GUI.ThuNgan
{
    partial class frm_Cashier
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.grd_HoaDon = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.mabenhnhan_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaHoaDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelEx2 = new DevComponents.DotNetBar.PanelEx();
            this.txt_TimKiemHoaDon = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lbl_TimKiemHoaDon = new DevComponents.DotNetBar.LabelX();
            this.panelEx3 = new DevComponents.DotNetBar.PanelEx();
            this.txt_MaHoaDon = new DevComponents.DotNetBar.LabelX();
            this.txt_MabenhNhan = new DevComponents.DotNetBar.LabelX();
            this.lbl_MaBenhNhan = new DevComponents.DotNetBar.LabelX();
            this.txt_SDT = new DevComponents.DotNetBar.LabelX();
            this.txt_DiaChi = new DevComponents.DotNetBar.LabelX();
            this.txt_Tuoi = new DevComponents.DotNetBar.LabelX();
            this.txt_GioiTinh = new DevComponents.DotNetBar.LabelX();
            this.txt_TenBenhNhan = new DevComponents.DotNetBar.LabelX();
            this.lbl_SDT = new DevComponents.DotNetBar.LabelX();
            this.lbl_DiaChi = new DevComponents.DotNetBar.LabelX();
            this.lbl_Tuoi = new DevComponents.DotNetBar.LabelX();
            this.lbl_GioiTinh = new DevComponents.DotNetBar.LabelX();
            this.lbl_TenBenhNhan = new DevComponents.DotNetBar.LabelX();
            this.lbl_MaHoaDon = new DevComponents.DotNetBar.LabelX();
            this.panelEx4 = new DevComponents.DotNetBar.PanelEx();
            this.rab_tatcabienlai = new System.Windows.Forms.RadioButton();
            this.rad_bienlai = new System.Windows.Forms.RadioButton();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.lbl_TongTienHoanLai = new DevComponents.DotNetBar.LabelX();
            this.lbl_TongTienNhan = new DevComponents.DotNetBar.LabelX();
            this.txt_TongSoTienNhan = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.btn_XacNhan = new DevComponents.DotNetBar.ButtonX();
            this.txt_SoTienHoanLai = new DevComponents.DotNetBar.LabelX();
            this.txt_SoTien = new DevComponents.DotNetBar.LabelX();
            this.txt_SoTienNhan = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lbl_SoTienHoanLai = new DevComponents.DotNetBar.LabelX();
            this.lbl_SoTienNhan = new DevComponents.DotNetBar.LabelX();
            this.lbl_SoTien = new DevComponents.DotNetBar.LabelX();
            this.grd_DichVu = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaiduchvu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dichvu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thanhtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_HoaDon)).BeginInit();
            this.panelEx2.SuspendLayout();
            this.panelEx3.SuspendLayout();
            this.panelEx4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_DichVu)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.grd_HoaDon);
            this.panelEx1.Controls.Add(this.panelEx2);
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(350, 550);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 0;
            // 
            // grd_HoaDon
            // 
            this.grd_HoaDon.AllowUserToAddRows = false;
            this.grd_HoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grd_HoaDon.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.grd_HoaDon.BackgroundColor = System.Drawing.Color.White;
            this.grd_HoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_HoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mabenhnhan_,
            this.MaHoaDon});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grd_HoaDon.DefaultCellStyle = dataGridViewCellStyle2;
            this.grd_HoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_HoaDon.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.grd_HoaDon.Location = new System.Drawing.Point(0, 40);
            this.grd_HoaDon.Name = "grd_HoaDon";
            this.grd_HoaDon.ReadOnly = true;
            this.grd_HoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grd_HoaDon.Size = new System.Drawing.Size(350, 510);
            this.grd_HoaDon.TabIndex = 1;
            this.grd_HoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grd_HoaDon_CellClick);
            // 
            // mabenhnhan_
            // 
            this.mabenhnhan_.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.mabenhnhan_.DefaultCellStyle = dataGridViewCellStyle1;
            this.mabenhnhan_.HeaderText = "Mã bệnh nhân";
            this.mabenhnhan_.Name = "mabenhnhan_";
            this.mabenhnhan_.ReadOnly = true;
            this.mabenhnhan_.Width = 120;
            // 
            // MaHoaDon
            // 
            this.MaHoaDon.DataPropertyName = "tenbenhnhan_";
            this.MaHoaDon.HeaderText = "Tên bệnh nhân";
            this.MaHoaDon.Name = "MaHoaDon";
            this.MaHoaDon.ReadOnly = true;
            // 
            // panelEx2
            // 
            this.panelEx2.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx2.Controls.Add(this.txt_TimKiemHoaDon);
            this.panelEx2.Controls.Add(this.lbl_TimKiemHoaDon);
            this.panelEx2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEx2.Location = new System.Drawing.Point(0, 0);
            this.panelEx2.Name = "panelEx2";
            this.panelEx2.Size = new System.Drawing.Size(350, 40);
            this.panelEx2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx2.Style.GradientAngle = 90;
            this.panelEx2.TabIndex = 0;
            // 
            // txt_TimKiemHoaDon
            // 
            // 
            // 
            // 
            this.txt_TimKiemHoaDon.Border.Class = "TextBoxBorder";
            this.txt_TimKiemHoaDon.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_TimKiemHoaDon.Location = new System.Drawing.Point(171, 7);
            this.txt_TimKiemHoaDon.Name = "txt_TimKiemHoaDon";
            this.txt_TimKiemHoaDon.Size = new System.Drawing.Size(140, 26);
            this.txt_TimKiemHoaDon.TabIndex = 3;
            this.txt_TimKiemHoaDon.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_TimKiemHoaDon_KeyDown);
            // 
            // lbl_TimKiemHoaDon
            // 
            // 
            // 
            // 
            this.lbl_TimKiemHoaDon.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_TimKiemHoaDon.Location = new System.Drawing.Point(40, 10);
            this.lbl_TimKiemHoaDon.Name = "lbl_TimKiemHoaDon";
            this.lbl_TimKiemHoaDon.Size = new System.Drawing.Size(125, 23);
            this.lbl_TimKiemHoaDon.TabIndex = 2;
            this.lbl_TimKiemHoaDon.Text = "Tìm kiếm hóa đơn";
            // 
            // panelEx3
            // 
            this.panelEx3.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx3.Controls.Add(this.txt_MaHoaDon);
            this.panelEx3.Controls.Add(this.txt_MabenhNhan);
            this.panelEx3.Controls.Add(this.lbl_MaBenhNhan);
            this.panelEx3.Controls.Add(this.txt_SDT);
            this.panelEx3.Controls.Add(this.txt_DiaChi);
            this.panelEx3.Controls.Add(this.txt_Tuoi);
            this.panelEx3.Controls.Add(this.txt_GioiTinh);
            this.panelEx3.Controls.Add(this.txt_TenBenhNhan);
            this.panelEx3.Controls.Add(this.lbl_SDT);
            this.panelEx3.Controls.Add(this.lbl_DiaChi);
            this.panelEx3.Controls.Add(this.lbl_Tuoi);
            this.panelEx3.Controls.Add(this.lbl_GioiTinh);
            this.panelEx3.Controls.Add(this.lbl_TenBenhNhan);
            this.panelEx3.Controls.Add(this.lbl_MaHoaDon);
            this.panelEx3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEx3.Location = new System.Drawing.Point(350, 0);
            this.panelEx3.Name = "panelEx3";
            this.panelEx3.Size = new System.Drawing.Size(950, 100);
            this.panelEx3.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx3.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx3.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx3.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx3.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx3.Style.GradientAngle = 90;
            this.panelEx3.TabIndex = 1;
            // 
            // txt_MaHoaDon
            // 
            // 
            // 
            // 
            this.txt_MaHoaDon.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_MaHoaDon.Location = new System.Drawing.Point(180, 10);
            this.txt_MaHoaDon.Name = "txt_MaHoaDon";
            this.txt_MaHoaDon.Size = new System.Drawing.Size(300, 23);
            this.txt_MaHoaDon.TabIndex = 28;
            this.txt_MaHoaDon.Text = "130621-00001-AB";
            // 
            // txt_MabenhNhan
            // 
            // 
            // 
            // 
            this.txt_MabenhNhan.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_MabenhNhan.Location = new System.Drawing.Point(731, 10);
            this.txt_MabenhNhan.Name = "txt_MabenhNhan";
            this.txt_MabenhNhan.Size = new System.Drawing.Size(100, 23);
            this.txt_MabenhNhan.TabIndex = 27;
            this.txt_MabenhNhan.Text = "A130000001";
            // 
            // lbl_MaBenhNhan
            // 
            // 
            // 
            // 
            this.lbl_MaBenhNhan.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_MaBenhNhan.Location = new System.Drawing.Point(611, 10);
            this.lbl_MaBenhNhan.Name = "lbl_MaBenhNhan";
            this.lbl_MaBenhNhan.Size = new System.Drawing.Size(100, 23);
            this.lbl_MaBenhNhan.TabIndex = 26;
            this.lbl_MaBenhNhan.Text = "Mã bệnh nhân:";
            // 
            // txt_SDT
            // 
            // 
            // 
            // 
            this.txt_SDT.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_SDT.Location = new System.Drawing.Point(679, 68);
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.Size = new System.Drawing.Size(99, 23);
            this.txt_SDT.TabIndex = 25;
            this.txt_SDT.Text = "01234567890";
            // 
            // txt_DiaChi
            // 
            // 
            // 
            // 
            this.txt_DiaChi.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_DiaChi.Location = new System.Drawing.Point(180, 68);
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.Size = new System.Drawing.Size(425, 23);
            this.txt_DiaChi.TabIndex = 24;
            this.txt_DiaChi.Text = "45 Nguyễn Khắc nhu, Quận 1, Hồ Chí Minh";
            // 
            // txt_Tuoi
            // 
            // 
            // 
            // 
            this.txt_Tuoi.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_Tuoi.Location = new System.Drawing.Point(776, 40);
            this.txt_Tuoi.Name = "txt_Tuoi";
            this.txt_Tuoi.Size = new System.Drawing.Size(47, 23);
            this.txt_Tuoi.TabIndex = 23;
            this.txt_Tuoi.Text = "25";
            // 
            // txt_GioiTinh
            // 
            // 
            // 
            // 
            this.txt_GioiTinh.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_GioiTinh.Location = new System.Drawing.Point(678, 39);
            this.txt_GioiTinh.Name = "txt_GioiTinh";
            this.txt_GioiTinh.Size = new System.Drawing.Size(40, 23);
            this.txt_GioiTinh.TabIndex = 22;
            this.txt_GioiTinh.Text = "Nam";
            // 
            // txt_TenBenhNhan
            // 
            // 
            // 
            // 
            this.txt_TenBenhNhan.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_TenBenhNhan.Location = new System.Drawing.Point(180, 39);
            this.txt_TenBenhNhan.Name = "txt_TenBenhNhan";
            this.txt_TenBenhNhan.Size = new System.Drawing.Size(425, 23);
            this.txt_TenBenhNhan.TabIndex = 21;
            this.txt_TenBenhNhan.Text = "Nguyễn Văn B";
            // 
            // lbl_SDT
            // 
            // 
            // 
            // 
            this.lbl_SDT.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_SDT.Location = new System.Drawing.Point(613, 68);
            this.lbl_SDT.Name = "lbl_SDT";
            this.lbl_SDT.Size = new System.Drawing.Size(44, 23);
            this.lbl_SDT.TabIndex = 18;
            this.lbl_SDT.Text = "SĐT:";
            // 
            // lbl_DiaChi
            // 
            // 
            // 
            // 
            this.lbl_DiaChi.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_DiaChi.Location = new System.Drawing.Point(70, 68);
            this.lbl_DiaChi.Name = "lbl_DiaChi";
            this.lbl_DiaChi.Size = new System.Drawing.Size(100, 23);
            this.lbl_DiaChi.TabIndex = 19;
            this.lbl_DiaChi.Text = "Địa chỉ:";
            // 
            // lbl_Tuoi
            // 
            // 
            // 
            // 
            this.lbl_Tuoi.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_Tuoi.Location = new System.Drawing.Point(731, 39);
            this.lbl_Tuoi.Name = "lbl_Tuoi";
            this.lbl_Tuoi.Size = new System.Drawing.Size(39, 23);
            this.lbl_Tuoi.TabIndex = 17;
            this.lbl_Tuoi.Text = "Tuổi:";
            // 
            // lbl_GioiTinh
            // 
            // 
            // 
            // 
            this.lbl_GioiTinh.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_GioiTinh.Location = new System.Drawing.Point(611, 39);
            this.lbl_GioiTinh.Name = "lbl_GioiTinh";
            this.lbl_GioiTinh.Size = new System.Drawing.Size(71, 23);
            this.lbl_GioiTinh.TabIndex = 15;
            this.lbl_GioiTinh.Text = "Giới tính:";
            // 
            // lbl_TenBenhNhan
            // 
            // 
            // 
            // 
            this.lbl_TenBenhNhan.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_TenBenhNhan.Location = new System.Drawing.Point(70, 39);
            this.lbl_TenBenhNhan.Name = "lbl_TenBenhNhan";
            this.lbl_TenBenhNhan.Size = new System.Drawing.Size(100, 23);
            this.lbl_TenBenhNhan.TabIndex = 16;
            this.lbl_TenBenhNhan.Text = "Tên bệnh nhân:";
            // 
            // lbl_MaHoaDon
            // 
            // 
            // 
            // 
            this.lbl_MaHoaDon.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_MaHoaDon.Location = new System.Drawing.Point(70, 10);
            this.lbl_MaHoaDon.Name = "lbl_MaHoaDon";
            this.lbl_MaHoaDon.Size = new System.Drawing.Size(100, 23);
            this.lbl_MaHoaDon.TabIndex = 14;
            this.lbl_MaHoaDon.Text = "Mã hóa đơn:";
            // 
            // panelEx4
            // 
            this.panelEx4.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx4.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx4.Controls.Add(this.rab_tatcabienlai);
            this.panelEx4.Controls.Add(this.rad_bienlai);
            this.panelEx4.Controls.Add(this.buttonX1);
            this.panelEx4.Controls.Add(this.lbl_TongTienHoanLai);
            this.panelEx4.Controls.Add(this.lbl_TongTienNhan);
            this.panelEx4.Controls.Add(this.txt_TongSoTienNhan);
            this.panelEx4.Controls.Add(this.labelX3);
            this.panelEx4.Controls.Add(this.labelX4);
            this.panelEx4.Controls.Add(this.labelX5);
            this.panelEx4.Controls.Add(this.btn_XacNhan);
            this.panelEx4.Controls.Add(this.txt_SoTienHoanLai);
            this.panelEx4.Controls.Add(this.txt_SoTien);
            this.panelEx4.Controls.Add(this.txt_SoTienNhan);
            this.panelEx4.Controls.Add(this.lbl_SoTienHoanLai);
            this.panelEx4.Controls.Add(this.lbl_SoTienNhan);
            this.panelEx4.Controls.Add(this.lbl_SoTien);
            this.panelEx4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelEx4.Location = new System.Drawing.Point(350, 417);
            this.panelEx4.Name = "panelEx4";
            this.panelEx4.Size = new System.Drawing.Size(950, 133);
            this.panelEx4.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx4.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx4.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx4.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx4.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx4.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx4.Style.GradientAngle = 90;
            this.panelEx4.TabIndex = 2;
            this.panelEx4.FontChanged += new System.EventHandler(this.panelEx4_FontChanged);
            // 
            // rab_tatcabienlai
            // 
            this.rab_tatcabienlai.AutoSize = true;
            this.rab_tatcabienlai.Location = new System.Drawing.Point(190, 7);
            this.rab_tatcabienlai.Name = "rab_tatcabienlai";
            this.rab_tatcabienlai.Size = new System.Drawing.Size(111, 23);
            this.rab_tatcabienlai.TabIndex = 13;
            this.rab_tatcabienlai.TabStop = true;
            this.rab_tatcabienlai.Text = "Tất cả biên lai";
            this.rab_tatcabienlai.UseVisualStyleBackColor = true;
            // 
            // rad_bienlai
            // 
            this.rad_bienlai.AutoSize = true;
            this.rad_bienlai.Location = new System.Drawing.Point(75, 7);
            this.rad_bienlai.Name = "rad_bienlai";
            this.rad_bienlai.Size = new System.Drawing.Size(99, 23);
            this.rad_bienlai.TabIndex = 12;
            this.rad_bienlai.TabStop = true;
            this.rad_bienlai.Text = "Một biên lai";
            this.rad_bienlai.UseVisualStyleBackColor = true;
            this.rad_bienlai.CheckedChanged += new System.EventHandler(this.rad_bienlai_CheckedChanged);
            this.rad_bienlai.RegionChanged += new System.EventHandler(this.rad_bienlai_RegionChanged);
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Image = global::GUI.Properties.Resources.accept;
            this.buttonX1.Location = new System.Drawing.Point(328, 35);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(120, 80);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.TabIndex = 11;
            this.buttonX1.Text = "Xác nhận tất cả";
            this.buttonX1.Visible = false;
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // lbl_TongTienHoanLai
            // 
            // 
            // 
            // 
            this.lbl_TongTienHoanLai.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_TongTienHoanLai.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TongTienHoanLai.ForeColor = System.Drawing.Color.Red;
            this.lbl_TongTienHoanLai.Location = new System.Drawing.Point(189, 92);
            this.lbl_TongTienHoanLai.Name = "lbl_TongTienHoanLai";
            this.lbl_TongTienHoanLai.Size = new System.Drawing.Size(100, 23);
            this.lbl_TongTienHoanLai.TabIndex = 10;
            this.lbl_TongTienHoanLai.Text = "0";
            this.lbl_TongTienHoanLai.Visible = false;
            // 
            // lbl_TongTienNhan
            // 
            // 
            // 
            // 
            this.lbl_TongTienNhan.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_TongTienNhan.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TongTienNhan.ForeColor = System.Drawing.Color.Red;
            this.lbl_TongTienNhan.Location = new System.Drawing.Point(189, 31);
            this.lbl_TongTienNhan.Name = "lbl_TongTienNhan";
            this.lbl_TongTienNhan.Size = new System.Drawing.Size(100, 23);
            this.lbl_TongTienNhan.TabIndex = 9;
            this.lbl_TongTienNhan.Visible = false;
            // 
            // txt_TongSoTienNhan
            // 
            // 
            // 
            // 
            this.txt_TongSoTienNhan.Border.Class = "TextBoxBorder";
            this.txt_TongSoTienNhan.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_TongSoTienNhan.Location = new System.Drawing.Point(189, 60);
            this.txt_TongSoTienNhan.Name = "txt_TongSoTienNhan";
            this.txt_TongSoTienNhan.Size = new System.Drawing.Size(119, 26);
            this.txt_TongSoTienNhan.TabIndex = 8;
            this.txt_TongSoTienNhan.Visible = false;
            this.txt_TongSoTienNhan.TextChanged += new System.EventHandler(this.txt_TongSoTienNhan_TextChanged);
            this.txt_TongSoTienNhan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_TongSoTienNhan_KeyPress);
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(74, 92);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(109, 23);
            this.labelX3.TabIndex = 5;
            this.labelX3.Text = "Số tiền hoàn lại:";
            this.labelX3.Visible = false;
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(74, 63);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(100, 23);
            this.labelX4.TabIndex = 6;
            this.labelX4.Text = "Số tiền nhận:";
            this.labelX4.Visible = false;
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(74, 34);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(100, 23);
            this.labelX5.TabIndex = 7;
            this.labelX5.Text = "Tổng số tiền:";
            this.labelX5.Visible = false;
            // 
            // btn_XacNhan
            // 
            this.btn_XacNhan.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_XacNhan.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_XacNhan.Image = global::GUI.Properties.Resources.accept;
            this.btn_XacNhan.Location = new System.Drawing.Point(329, 35);
            this.btn_XacNhan.Name = "btn_XacNhan";
            this.btn_XacNhan.Size = new System.Drawing.Size(120, 80);
            this.btn_XacNhan.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_XacNhan.TabIndex = 4;
            this.btn_XacNhan.Text = "Xác nhận";
            this.btn_XacNhan.Click += new System.EventHandler(this.btn_XacNhan_Click);
            // 
            // txt_SoTienHoanLai
            // 
            // 
            // 
            // 
            this.txt_SoTienHoanLai.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_SoTienHoanLai.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SoTienHoanLai.ForeColor = System.Drawing.Color.Red;
            this.txt_SoTienHoanLai.Location = new System.Drawing.Point(190, 92);
            this.txt_SoTienHoanLai.Name = "txt_SoTienHoanLai";
            this.txt_SoTienHoanLai.Size = new System.Drawing.Size(100, 23);
            this.txt_SoTienHoanLai.TabIndex = 3;
            this.txt_SoTienHoanLai.Text = "0";
            // 
            // txt_SoTien
            // 
            // 
            // 
            // 
            this.txt_SoTien.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_SoTien.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SoTien.ForeColor = System.Drawing.Color.Red;
            this.txt_SoTien.Location = new System.Drawing.Point(190, 31);
            this.txt_SoTien.Name = "txt_SoTien";
            this.txt_SoTien.Size = new System.Drawing.Size(100, 23);
            this.txt_SoTien.TabIndex = 2;
            // 
            // txt_SoTienNhan
            // 
            // 
            // 
            // 
            this.txt_SoTienNhan.Border.Class = "TextBoxBorder";
            this.txt_SoTienNhan.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_SoTienNhan.Location = new System.Drawing.Point(190, 60);
            this.txt_SoTienNhan.Name = "txt_SoTienNhan";
            this.txt_SoTienNhan.Size = new System.Drawing.Size(119, 26);
            this.txt_SoTienNhan.TabIndex = 1;
            this.txt_SoTienNhan.TextChanged += new System.EventHandler(this.txt_SoTienNhan_TextChanged);
            this.txt_SoTienNhan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_SoTienNhan_KeyPress);
            // 
            // lbl_SoTienHoanLai
            // 
            // 
            // 
            // 
            this.lbl_SoTienHoanLai.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_SoTienHoanLai.Location = new System.Drawing.Point(75, 92);
            this.lbl_SoTienHoanLai.Name = "lbl_SoTienHoanLai";
            this.lbl_SoTienHoanLai.Size = new System.Drawing.Size(109, 23);
            this.lbl_SoTienHoanLai.TabIndex = 0;
            this.lbl_SoTienHoanLai.Text = "Số tiền hoàn lại:";
            // 
            // lbl_SoTienNhan
            // 
            // 
            // 
            // 
            this.lbl_SoTienNhan.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_SoTienNhan.Location = new System.Drawing.Point(75, 63);
            this.lbl_SoTienNhan.Name = "lbl_SoTienNhan";
            this.lbl_SoTienNhan.Size = new System.Drawing.Size(100, 23);
            this.lbl_SoTienNhan.TabIndex = 0;
            this.lbl_SoTienNhan.Text = "Số tiền nhận:";
            // 
            // lbl_SoTien
            // 
            // 
            // 
            // 
            this.lbl_SoTien.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_SoTien.Location = new System.Drawing.Point(75, 34);
            this.lbl_SoTien.Name = "lbl_SoTien";
            this.lbl_SoTien.Size = new System.Drawing.Size(100, 23);
            this.lbl_SoTien.TabIndex = 0;
            this.lbl_SoTien.Text = "Số tiền:";
            // 
            // grd_DichVu
            // 
            this.grd_DichVu.AllowUserToAddRows = false;
            this.grd_DichVu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grd_DichVu.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.grd_DichVu.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grd_DichVu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grd_DichVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_DichVu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.loaiduchvu,
            this.dichvu,
            this.DonGia,
            this.Thanhtien});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grd_DichVu.DefaultCellStyle = dataGridViewCellStyle5;
            this.grd_DichVu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_DichVu.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.grd_DichVu.Location = new System.Drawing.Point(350, 100);
            this.grd_DichVu.Name = "grd_DichVu";
            this.grd_DichVu.ReadOnly = true;
            this.grd_DichVu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grd_DichVu.Size = new System.Drawing.Size(950, 317);
            this.grd_DichVu.TabIndex = 3;
            this.grd_DichVu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grd_DichVu_CellClick);
            this.grd_DichVu.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.grd_DichVu_RowsAdded);
            this.grd_DichVu.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.grd_DichVu_RowsRemoved);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // STT
            // 
            this.STT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle4.NullValue = "1";
            this.STT.DefaultCellStyle = dataGridViewCellStyle4;
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            this.STT.Width = 61;
            // 
            // loaiduchvu
            // 
            this.loaiduchvu.DataPropertyName = "mahoadon_";
            this.loaiduchvu.HeaderText = "Mã hóa đơn";
            this.loaiduchvu.Name = "loaiduchvu";
            this.loaiduchvu.ReadOnly = true;
            // 
            // dichvu
            // 
            this.dichvu.DataPropertyName = "loaidichvu_";
            this.dichvu.HeaderText = "Nhóm dịch vụ";
            this.dichvu.Name = "dichvu";
            this.dichvu.ReadOnly = true;
            // 
            // DonGia
            // 
            this.DonGia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.DonGia.DataPropertyName = "dongia_";
            this.DonGia.HeaderText = "Đơn giá";
            this.DonGia.Name = "DonGia";
            this.DonGia.ReadOnly = true;
            this.DonGia.Width = 161;
            // 
            // Thanhtien
            // 
            this.Thanhtien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Thanhtien.HeaderText = "Thành tiền";
            this.Thanhtien.Name = "Thanhtien";
            this.Thanhtien.ReadOnly = true;
            this.Thanhtien.Visible = false;
            this.Thanhtien.Width = 5;
            // 
            // frm_Cashier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1300, 550);
            this.Controls.Add(this.grd_DichVu);
            this.Controls.Add(this.panelEx4);
            this.Controls.Add(this.panelEx3);
            this.Controls.Add(this.panelEx1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frm_Cashier";
            this.Text = "cashier";
            this.Load += new System.EventHandler(this.frm_Cashier_Load);
            this.panelEx1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd_HoaDon)).EndInit();
            this.panelEx2.ResumeLayout(false);
            this.panelEx3.ResumeLayout(false);
            this.panelEx4.ResumeLayout(false);
            this.panelEx4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_DichVu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.Controls.DataGridViewX grd_HoaDon;
        private DevComponents.DotNetBar.PanelEx panelEx2;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_TimKiemHoaDon;
        private DevComponents.DotNetBar.LabelX lbl_TimKiemHoaDon;
        private DevComponents.DotNetBar.PanelEx panelEx3;
        private DevComponents.DotNetBar.LabelX txt_MaHoaDon;
        private DevComponents.DotNetBar.LabelX txt_MabenhNhan;
        private DevComponents.DotNetBar.LabelX lbl_MaBenhNhan;
        private DevComponents.DotNetBar.LabelX txt_SDT;
        private DevComponents.DotNetBar.LabelX txt_DiaChi;
        private DevComponents.DotNetBar.LabelX txt_Tuoi;
        private DevComponents.DotNetBar.LabelX txt_GioiTinh;
        private DevComponents.DotNetBar.LabelX txt_TenBenhNhan;
        private DevComponents.DotNetBar.LabelX lbl_SDT;
        private DevComponents.DotNetBar.LabelX lbl_DiaChi;
        private DevComponents.DotNetBar.LabelX lbl_Tuoi;
        private DevComponents.DotNetBar.LabelX lbl_GioiTinh;
        private DevComponents.DotNetBar.LabelX lbl_TenBenhNhan;
        private DevComponents.DotNetBar.LabelX lbl_MaHoaDon;
        private DevComponents.DotNetBar.PanelEx panelEx4;
        private DevComponents.DotNetBar.LabelX txt_SoTienHoanLai;
        private DevComponents.DotNetBar.LabelX txt_SoTien;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_SoTienNhan;
        private DevComponents.DotNetBar.LabelX lbl_SoTienHoanLai;
        private DevComponents.DotNetBar.LabelX lbl_SoTienNhan;
        private DevComponents.DotNetBar.LabelX lbl_SoTien;
        private DevComponents.DotNetBar.ButtonX btn_XacNhan;
        private DevComponents.DotNetBar.Controls.DataGridViewX grd_DichVu;
        private System.Windows.Forms.Timer timer1;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private DevComponents.DotNetBar.LabelX lbl_TongTienHoanLai;
        private DevComponents.DotNetBar.LabelX lbl_TongTienNhan;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_TongSoTienNhan;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX5;
        private System.Windows.Forms.RadioButton rab_tatcabienlai;
        private System.Windows.Forms.RadioButton rad_bienlai;
        private System.Windows.Forms.DataGridViewTextBoxColumn mabenhnhan_;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaiduchvu;
        private System.Windows.Forms.DataGridViewTextBoxColumn dichvu;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thanhtien;
    }
}