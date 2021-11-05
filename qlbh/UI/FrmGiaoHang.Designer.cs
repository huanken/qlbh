
namespace qlbh.UI
{
    partial class FrmGiaoHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGiaoHang));
            this.panel1 = new System.Windows.Forms.Panel();
            this.GridView_GiaoHang = new System.Windows.Forms.DataGridView();
            this.btn_TaoMoi = new CustomControls.RJControls.RJButton();
            this.txt_mavd = new CustomControls.RJControls.RJTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Luu = new CustomControls.RJControls.RJButton();
            this.btn_sua = new CustomControls.RJControls.RJButton();
            this.btn_xoa = new CustomControls.RJControls.RJButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_dc = new CustomControls.RJControls.RJTextBox();
            this.txt_sđtkh = new CustomControls.RJControls.RJTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dp_Time = new CustomControls.RJControls.RJDatePicker();
            this.rjCircularPictureBox1 = new CustomControls.RJControls.RJCircularPictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_CapNhat = new CustomControls.RJControls.RJButton();
            this.cbo_TrangThai = new CustomControls.RJControls.RJComboBox();
            this.btnTrangThai = new CustomControls.RJControls.RJButton();
            this.progressTT = new CustomControls.RJControls.RJProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cbb_mactdb = new System.Windows.Forms.ComboBox();
            this.cbb_mnv = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_GiaoHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.IndianRed;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.ForeColor = System.Drawing.Color.Coral;
            this.panel1.Location = new System.Drawing.Point(162, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 3);
            this.panel1.TabIndex = 0;
            // 
            // GridView_GiaoHang
            // 
            this.GridView_GiaoHang.BackgroundColor = System.Drawing.Color.Snow;
            this.GridView_GiaoHang.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.GridView_GiaoHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView_GiaoHang.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.GridView_GiaoHang.Location = new System.Drawing.Point(386, 161);
            this.GridView_GiaoHang.Name = "GridView_GiaoHang";
            this.GridView_GiaoHang.Size = new System.Drawing.Size(476, 239);
            this.GridView_GiaoHang.TabIndex = 1;
            this.GridView_GiaoHang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridView_GiaoHang_CellContentClick);
            // 
            // btn_TaoMoi
            // 
            this.btn_TaoMoi.BackColor = System.Drawing.Color.Tomato;
            this.btn_TaoMoi.BackgroundColor = System.Drawing.Color.Tomato;
            this.btn_TaoMoi.BorderColor = System.Drawing.Color.Black;
            this.btn_TaoMoi.BorderRadius = 15;
            this.btn_TaoMoi.BorderSize = 1;
            this.btn_TaoMoi.FlatAppearance.BorderSize = 0;
            this.btn_TaoMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TaoMoi.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TaoMoi.ForeColor = System.Drawing.Color.Transparent;
            this.btn_TaoMoi.Location = new System.Drawing.Point(199, 419);
            this.btn_TaoMoi.Name = "btn_TaoMoi";
            this.btn_TaoMoi.Size = new System.Drawing.Size(100, 42);
            this.btn_TaoMoi.TabIndex = 2;
            this.btn_TaoMoi.Text = "Tạo mới";
            this.btn_TaoMoi.TextColor = System.Drawing.Color.Transparent;
            this.btn_TaoMoi.UseVisualStyleBackColor = false;
            this.btn_TaoMoi.Click += new System.EventHandler(this.btn_TaoMoi_Click);
            // 
            // txt_mavd
            // 
            this.txt_mavd.BackColor = System.Drawing.SystemColors.Window;
            this.txt_mavd.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.txt_mavd.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_mavd.BorderRadius = 7;
            this.txt_mavd.BorderSize = 1;
            this.txt_mavd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mavd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_mavd.Location = new System.Drawing.Point(177, 161);
            this.txt_mavd.Margin = new System.Windows.Forms.Padding(4);
            this.txt_mavd.Multiline = false;
            this.txt_mavd.Name = "txt_mavd";
            this.txt_mavd.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_mavd.PasswordChar = false;
            this.txt_mavd.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_mavd.PlaceholderText = "";
            this.txt_mavd.Size = new System.Drawing.Size(200, 31);
            this.txt_mavd.TabIndex = 3;
            this.txt_mavd.Texts = "";
            this.txt_mavd.UnderlinedStyle = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.IndianRed;
            this.label2.Location = new System.Drawing.Point(50, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mã Vận Đơn:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.IndianRed;
            this.label3.Location = new System.Drawing.Point(50, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Thời Gian:";
            // 
            // btn_Luu
            // 
            this.btn_Luu.BackColor = System.Drawing.Color.Tomato;
            this.btn_Luu.BackgroundColor = System.Drawing.Color.Tomato;
            this.btn_Luu.BorderColor = System.Drawing.Color.Black;
            this.btn_Luu.BorderRadius = 15;
            this.btn_Luu.BorderSize = 1;
            this.btn_Luu.FlatAppearance.BorderSize = 0;
            this.btn_Luu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Luu.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Luu.ForeColor = System.Drawing.Color.Transparent;
            this.btn_Luu.Location = new System.Drawing.Point(357, 419);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(100, 42);
            this.btn_Luu.TabIndex = 7;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.TextColor = System.Drawing.Color.Transparent;
            this.btn_Luu.UseVisualStyleBackColor = false;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.BackColor = System.Drawing.Color.Tomato;
            this.btn_sua.BackgroundColor = System.Drawing.Color.Tomato;
            this.btn_sua.BorderColor = System.Drawing.Color.Black;
            this.btn_sua.BorderRadius = 15;
            this.btn_sua.BorderSize = 1;
            this.btn_sua.FlatAppearance.BorderSize = 0;
            this.btn_sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sua.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua.ForeColor = System.Drawing.Color.Transparent;
            this.btn_sua.Location = new System.Drawing.Point(505, 419);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(100, 42);
            this.btn_sua.TabIndex = 8;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.TextColor = System.Drawing.Color.Transparent;
            this.btn_sua.UseVisualStyleBackColor = false;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.BackColor = System.Drawing.Color.Tomato;
            this.btn_xoa.BackgroundColor = System.Drawing.Color.Tomato;
            this.btn_xoa.BorderColor = System.Drawing.Color.Black;
            this.btn_xoa.BorderRadius = 15;
            this.btn_xoa.BorderSize = 1;
            this.btn_xoa.FlatAppearance.BorderSize = 0;
            this.btn_xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_xoa.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.ForeColor = System.Drawing.Color.Transparent;
            this.btn_xoa.Location = new System.Drawing.Point(663, 419);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(100, 42);
            this.btn_xoa.TabIndex = 9;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.TextColor = System.Drawing.Color.Transparent;
            this.btn_xoa.UseVisualStyleBackColor = false;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.IndianRed;
            this.label4.Location = new System.Drawing.Point(50, 296);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "SĐT KH:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.IndianRed;
            this.label5.Location = new System.Drawing.Point(51, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Địa Chỉ:";
            // 
            // txt_dc
            // 
            this.txt_dc.BackColor = System.Drawing.SystemColors.Window;
            this.txt_dc.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.txt_dc.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_dc.BorderRadius = 7;
            this.txt_dc.BorderSize = 1;
            this.txt_dc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_dc.Location = new System.Drawing.Point(177, 247);
            this.txt_dc.Margin = new System.Windows.Forms.Padding(4);
            this.txt_dc.Multiline = false;
            this.txt_dc.Name = "txt_dc";
            this.txt_dc.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_dc.PasswordChar = false;
            this.txt_dc.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_dc.PlaceholderText = "";
            this.txt_dc.Size = new System.Drawing.Size(200, 31);
            this.txt_dc.TabIndex = 15;
            this.txt_dc.Texts = "";
            this.txt_dc.UnderlinedStyle = false;
            // 
            // txt_sđtkh
            // 
            this.txt_sđtkh.BackColor = System.Drawing.SystemColors.Window;
            this.txt_sđtkh.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.txt_sđtkh.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_sđtkh.BorderRadius = 7;
            this.txt_sđtkh.BorderSize = 1;
            this.txt_sđtkh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sđtkh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_sđtkh.Location = new System.Drawing.Point(177, 288);
            this.txt_sđtkh.Margin = new System.Windows.Forms.Padding(4);
            this.txt_sđtkh.Multiline = false;
            this.txt_sđtkh.Name = "txt_sđtkh";
            this.txt_sđtkh.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_sđtkh.PasswordChar = false;
            this.txt_sđtkh.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_sđtkh.PlaceholderText = "";
            this.txt_sđtkh.Size = new System.Drawing.Size(200, 31);
            this.txt_sđtkh.TabIndex = 16;
            this.txt_sđtkh.Texts = "";
            this.txt_sđtkh.UnderlinedStyle = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(397, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Giao Hàng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.IndianRed;
            this.label6.Location = new System.Drawing.Point(47, 336);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Mã Nhân Viên:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.IndianRed;
            this.label7.Location = new System.Drawing.Point(47, 377);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Mã Hóa Đơn:";
            // 
            // dp_Time
            // 
            this.dp_Time.BorderColor = System.Drawing.Color.MintCream;
            this.dp_Time.BorderSize = 0;
            this.dp_Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.dp_Time.Location = new System.Drawing.Point(177, 202);
            this.dp_Time.MinimumSize = new System.Drawing.Size(4, 35);
            this.dp_Time.Name = "dp_Time";
            this.dp_Time.Size = new System.Drawing.Size(200, 35);
            this.dp_Time.SkinColor = System.Drawing.Color.MediumAquamarine;
            this.dp_Time.TabIndex = 18;
            this.dp_Time.TextColor = System.Drawing.Color.White;
            // 
            // rjCircularPictureBox1
            // 
            this.rjCircularPictureBox1.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.rjCircularPictureBox1.BorderColor = System.Drawing.Color.RoyalBlue;
            this.rjCircularPictureBox1.BorderColor2 = System.Drawing.Color.HotPink;
            this.rjCircularPictureBox1.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.rjCircularPictureBox1.BorderSize = 2;
            this.rjCircularPictureBox1.GradientAngle = 50F;
            this.rjCircularPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("rjCircularPictureBox1.Image")));
            this.rjCircularPictureBox1.Location = new System.Drawing.Point(49, 8);
            this.rjCircularPictureBox1.Name = "rjCircularPictureBox1";
            this.rjCircularPictureBox1.Size = new System.Drawing.Size(114, 114);
            this.rjCircularPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.rjCircularPictureBox1.TabIndex = 2;
            this.rjCircularPictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.OrangeRed;
            this.panel2.Location = new System.Drawing.Point(114, 471);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(750, 3);
            this.panel2.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.IndianRed;
            this.label8.Location = new System.Drawing.Point(162, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(175, 20);
            this.label8.TabIndex = 22;
            this.label8.Text = "Trạng thái đơn hàng:";
            // 
            // btn_CapNhat
            // 
            this.btn_CapNhat.BackColor = System.Drawing.Color.Tomato;
            this.btn_CapNhat.BackgroundColor = System.Drawing.Color.Tomato;
            this.btn_CapNhat.BorderColor = System.Drawing.Color.Black;
            this.btn_CapNhat.BorderRadius = 15;
            this.btn_CapNhat.BorderSize = 1;
            this.btn_CapNhat.FlatAppearance.BorderSize = 0;
            this.btn_CapNhat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CapNhat.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CapNhat.ForeColor = System.Drawing.Color.Transparent;
            this.btn_CapNhat.Location = new System.Drawing.Point(767, 93);
            this.btn_CapNhat.Name = "btn_CapNhat";
            this.btn_CapNhat.Size = new System.Drawing.Size(110, 41);
            this.btn_CapNhat.TabIndex = 24;
            this.btn_CapNhat.Text = "Cập nhật";
            this.btn_CapNhat.TextColor = System.Drawing.Color.Transparent;
            this.btn_CapNhat.UseVisualStyleBackColor = false;
            this.btn_CapNhat.Click += new System.EventHandler(this.btn_CapNhat_Click);
            // 
            // cbo_TrangThai
            // 
            this.cbo_TrangThai.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbo_TrangThai.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.cbo_TrangThai.BorderSize = 2;
            this.cbo_TrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbo_TrangThai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbo_TrangThai.ForeColor = System.Drawing.Color.DimGray;
            this.cbo_TrangThai.IconColor = System.Drawing.Color.MediumSeaGreen;
            this.cbo_TrangThai.Items.AddRange(new object[] {
            "Đang Giao",
            "Giao Thành Công",
            "Giao Thất Bại"});
            this.cbo_TrangThai.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbo_TrangThai.ListTextColor = System.Drawing.Color.DimGray;
            this.cbo_TrangThai.Location = new System.Drawing.Point(563, 98);
            this.cbo_TrangThai.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbo_TrangThai.Name = "cbo_TrangThai";
            this.cbo_TrangThai.Padding = new System.Windows.Forms.Padding(2);
            this.cbo_TrangThai.Size = new System.Drawing.Size(200, 33);
            this.cbo_TrangThai.TabIndex = 25;
            this.cbo_TrangThai.Texts = "";
            // 
            // btnTrangThai
            // 
            this.btnTrangThai.BackColor = System.Drawing.Color.Lavender;
            this.btnTrangThai.BackgroundColor = System.Drawing.Color.Lavender;
            this.btnTrangThai.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnTrangThai.BorderRadius = 0;
            this.btnTrangThai.BorderSize = 0;
            this.btnTrangThai.FlatAppearance.BorderSize = 0;
            this.btnTrangThai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrangThai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.btnTrangThai.ForeColor = System.Drawing.Color.Black;
            this.btnTrangThai.Location = new System.Drawing.Point(346, 98);
            this.btnTrangThai.Name = "btnTrangThai";
            this.btnTrangThai.Size = new System.Drawing.Size(211, 40);
            this.btnTrangThai.TabIndex = 26;
            this.btnTrangThai.TextColor = System.Drawing.Color.Black;
            this.btnTrangThai.UseVisualStyleBackColor = false;
            this.btnTrangThai.TextChanged += new System.EventHandler(this.btnTrangThai_TextChanged);
            // 
            // progressTT
            // 
            this.progressTT.ChannelColor = System.Drawing.Color.LightSteelBlue;
            this.progressTT.ChannelHeight = 6;
            this.progressTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progressTT.ForeBackColor = System.Drawing.Color.RoyalBlue;
            this.progressTT.ForeColor = System.Drawing.Color.White;
            this.progressTT.Location = new System.Drawing.Point(346, 72);
            this.progressTT.Name = "progressTT";
            this.progressTT.ShowMaximun = false;
            this.progressTT.ShowValue = CustomControls.RJControls.TextPosition.Right;
            this.progressTT.Size = new System.Drawing.Size(211, 25);
            this.progressTT.SliderColor = System.Drawing.Color.DeepSkyBlue;
            this.progressTT.SliderHeight = 6;
            this.progressTT.SymbolAfter = "%";
            this.progressTT.SymbolBefore = "";
            this.progressTT.TabIndex = 27;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // cbb_mactdb
            // 
            this.cbb_mactdb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_mactdb.FormattingEnabled = true;
            this.cbb_mactdb.Location = new System.Drawing.Point(178, 374);
            this.cbb_mactdb.Name = "cbb_mactdb";
            this.cbb_mactdb.Size = new System.Drawing.Size(199, 26);
            this.cbb_mactdb.TabIndex = 28;
            // 
            // cbb_mnv
            // 
            this.cbb_mnv.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_mnv.FormattingEnabled = true;
            this.cbb_mnv.Location = new System.Drawing.Point(178, 334);
            this.cbb_mnv.Name = "cbb_mnv";
            this.cbb_mnv.Size = new System.Drawing.Size(199, 26);
            this.cbb_mnv.TabIndex = 29;
            // 
            // FrmGiaoHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(890, 530);
            this.ControlBox = false;
            this.Controls.Add(this.cbb_mnv);
            this.Controls.Add(this.cbb_mactdb);
            this.Controls.Add(this.progressTT);
            this.Controls.Add(this.btnTrangThai);
            this.Controls.Add(this.cbo_TrangThai);
            this.Controls.Add(this.btn_CapNhat);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.rjCircularPictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dp_Time);
            this.Controls.Add(this.txt_sđtkh);
            this.Controls.Add(this.txt_dc);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_Luu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_mavd);
            this.Controls.Add(this.btn_TaoMoi);
            this.Controls.Add(this.GridView_GiaoHang);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmGiaoHang";
            this.Text = "FrmGiaoHang";
            this.Load += new System.EventHandler(this.FrmGiaoHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridView_GiaoHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView GridView_GiaoHang;
        private CustomControls.RJControls.RJButton btn_TaoMoi;
        private CustomControls.RJControls.RJTextBox txt_mavd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private CustomControls.RJControls.RJButton btn_Luu;
        private CustomControls.RJControls.RJButton btn_sua;
        private CustomControls.RJControls.RJButton btn_xoa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private CustomControls.RJControls.RJTextBox txt_dc;
        private CustomControls.RJControls.RJTextBox txt_sđtkh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private CustomControls.RJControls.RJDatePicker dp_Time;
        private CustomControls.RJControls.RJCircularPictureBox rjCircularPictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private CustomControls.RJControls.RJButton btn_CapNhat;
        private CustomControls.RJControls.RJComboBox cbo_TrangThai;
        private CustomControls.RJControls.RJButton btnTrangThai;
        private CustomControls.RJControls.RJProgressBar progressTT;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox cbb_mactdb;
        private System.Windows.Forms.ComboBox cbb_mnv;
    }
}