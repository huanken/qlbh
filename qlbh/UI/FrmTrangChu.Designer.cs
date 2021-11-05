
namespace qlbh.UI
{
    partial class FrmTrangChu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTrangChu));
            this.colapse = new System.Windows.Forms.Timer(this.components);
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.rjButton1 = new CustomControls.RJControls.RJButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.colapse2 = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.logo = new System.Windows.Forms.PictureBox();
            this.btnTrangChu = new CustomControls.RJControls.RJButton();
            this.btnPhieuNhap = new CustomControls.RJControls.RJButton();
            this.btnHoaDon = new CustomControls.RJControls.RJButton();
            this.btnNhanVien = new CustomControls.RJControls.RJButton();
            this.btnNhaCungCap = new CustomControls.RJControls.RJButton();
            this.btnSanPham = new CustomControls.RJControls.RJButton();
            this.btnDanhMuc = new CustomControls.RJControls.RJButton();
            this.btnTimKiemPhieuNhap = new CustomControls.RJControls.RJButton();
            this.btnTimKiemHoaDon = new CustomControls.RJControls.RJButton();
            this.btnTimKiemSanPham = new CustomControls.RJControls.RJButton();
            this.btnTimKiem = new CustomControls.RJControls.RJButton();
            this.btnGiaoHang = new CustomControls.RJControls.RJButton();
            this.btnBaoCao = new CustomControls.RJControls.RJButton();
            this.btnTaiKhoan = new CustomControls.RJControls.RJButton();
            this.btnThoat = new CustomControls.RJControls.RJButton();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // colapse
            // 
            this.colapse.Interval = 10;
            this.colapse.Tick += new System.EventHandler(this.colapse_Tick_1);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.flowLayoutPanel1.Controls.Add(this.rjButton1);
            this.flowLayoutPanel1.Controls.Add(this.pictureBox1);
            this.flowLayoutPanel1.Controls.Add(this.pictureBox2);
            this.flowLayoutPanel1.Controls.Add(this.pictureBox3);
            this.flowLayoutPanel1.Controls.Add(this.logo);
            this.flowLayoutPanel1.Controls.Add(this.btnTrangChu);
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.panel3);
            this.flowLayoutPanel1.Controls.Add(this.btnGiaoHang);
            this.flowLayoutPanel1.Controls.Add(this.btnBaoCao);
            this.flowLayoutPanel1.Controls.Add(this.btnTaiKhoan);
            this.flowLayoutPanel1.Controls.Add(this.btnThoat);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 572);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.rjButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.rjButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton1.BorderRadius = 0;
            this.rjButton1.BorderSize = 0;
            this.rjButton1.Enabled = false;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton1.ForeColor = System.Drawing.Color.White;
            this.rjButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rjButton1.Location = new System.Drawing.Point(3, 3);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(40, 27);
            this.rjButton1.TabIndex = 5;
            this.rjButton1.TextColor = System.Drawing.Color.White;
            this.rjButton1.UseVisualStyleBackColor = false;
            this.rjButton1.Click += new System.EventHandler(this.rjButton1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnPhieuNhap);
            this.panel1.Controls.Add(this.btnHoaDon);
            this.panel1.Controls.Add(this.btnNhanVien);
            this.panel1.Controls.Add(this.btnNhaCungCap);
            this.panel1.Controls.Add(this.btnSanPham);
            this.panel1.Controls.Add(this.btnDanhMuc);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(3, 169);
            this.panel1.MaximumSize = new System.Drawing.Size(198, 271);
            this.panel1.MinimumSize = new System.Drawing.Size(198, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(198, 49);
            this.panel1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnTimKiemPhieuNhap);
            this.panel3.Controls.Add(this.btnTimKiemHoaDon);
            this.panel3.Controls.Add(this.btnTimKiemSanPham);
            this.panel3.Controls.Add(this.btnTimKiem);
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(3, 224);
            this.panel3.MaximumSize = new System.Drawing.Size(198, 182);
            this.panel3.MinimumSize = new System.Drawing.Size(198, 49);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(198, 49);
            this.panel3.TabIndex = 6;
            // 
            // colapse2
            // 
            this.colapse2.Interval = 1;
            this.colapse2.Tick += new System.EventHandler(this.colapse2_Tick);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(200, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(947, 572);
            this.panel2.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(41)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(49, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(41)))));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(84, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(29, 28);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 44;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(41)))));
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(119, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(29, 28);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 45;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // logo
            // 
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(3, 37);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(197, 71);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            // 
            // btnTrangChu
            // 
            this.btnTrangChu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnTrangChu.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnTrangChu.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnTrangChu.BorderRadius = 0;
            this.btnTrangChu.BorderSize = 0;
            this.btnTrangChu.FlatAppearance.BorderSize = 0;
            this.btnTrangChu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrangChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrangChu.ForeColor = System.Drawing.Color.White;
            this.btnTrangChu.Image = ((System.Drawing.Image)(resources.GetObject("btnTrangChu.Image")));
            this.btnTrangChu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrangChu.Location = new System.Drawing.Point(3, 114);
            this.btnTrangChu.Name = "btnTrangChu";
            this.btnTrangChu.Size = new System.Drawing.Size(197, 49);
            this.btnTrangChu.TabIndex = 1;
            this.btnTrangChu.Text = "Trang Chủ";
            this.btnTrangChu.TextColor = System.Drawing.Color.White;
            this.btnTrangChu.UseVisualStyleBackColor = false;
            this.btnTrangChu.Click += new System.EventHandler(this.btnTrangChu_Click);
            // 
            // btnPhieuNhap
            // 
            this.btnPhieuNhap.BackColor = System.Drawing.Color.Gray;
            this.btnPhieuNhap.BackgroundColor = System.Drawing.Color.Gray;
            this.btnPhieuNhap.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnPhieuNhap.BorderRadius = 0;
            this.btnPhieuNhap.BorderSize = 0;
            this.btnPhieuNhap.FlatAppearance.BorderSize = 0;
            this.btnPhieuNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPhieuNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhieuNhap.ForeColor = System.Drawing.Color.White;
            this.btnPhieuNhap.Image = ((System.Drawing.Image)(resources.GetObject("btnPhieuNhap.Image")));
            this.btnPhieuNhap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPhieuNhap.Location = new System.Drawing.Point(0, 225);
            this.btnPhieuNhap.Name = "btnPhieuNhap";
            this.btnPhieuNhap.Size = new System.Drawing.Size(197, 44);
            this.btnPhieuNhap.TabIndex = 7;
            this.btnPhieuNhap.Text = "Phiếu nhập";
            this.btnPhieuNhap.TextColor = System.Drawing.Color.White;
            this.btnPhieuNhap.UseVisualStyleBackColor = false;
            this.btnPhieuNhap.Click += new System.EventHandler(this.btnPhieuNhap_Click);
            // 
            // btnHoaDon
            // 
            this.btnHoaDon.BackColor = System.Drawing.Color.Gray;
            this.btnHoaDon.BackgroundColor = System.Drawing.Color.Gray;
            this.btnHoaDon.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnHoaDon.BorderRadius = 0;
            this.btnHoaDon.BorderSize = 0;
            this.btnHoaDon.FlatAppearance.BorderSize = 0;
            this.btnHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoaDon.ForeColor = System.Drawing.Color.White;
            this.btnHoaDon.Image = ((System.Drawing.Image)(resources.GetObject("btnHoaDon.Image")));
            this.btnHoaDon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHoaDon.Location = new System.Drawing.Point(0, 181);
            this.btnHoaDon.Name = "btnHoaDon";
            this.btnHoaDon.Size = new System.Drawing.Size(197, 44);
            this.btnHoaDon.TabIndex = 6;
            this.btnHoaDon.Text = "Hóa đơn";
            this.btnHoaDon.TextColor = System.Drawing.Color.White;
            this.btnHoaDon.UseVisualStyleBackColor = false;
            this.btnHoaDon.Click += new System.EventHandler(this.btnHoaDon_Click);
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.BackColor = System.Drawing.Color.Gray;
            this.btnNhanVien.BackgroundColor = System.Drawing.Color.Gray;
            this.btnNhanVien.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnNhanVien.BorderRadius = 0;
            this.btnNhanVien.BorderSize = 0;
            this.btnNhanVien.FlatAppearance.BorderSize = 0;
            this.btnNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhanVien.ForeColor = System.Drawing.Color.White;
            this.btnNhanVien.Image = ((System.Drawing.Image)(resources.GetObject("btnNhanVien.Image")));
            this.btnNhanVien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhanVien.Location = new System.Drawing.Point(0, 137);
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.Size = new System.Drawing.Size(197, 44);
            this.btnNhanVien.TabIndex = 5;
            this.btnNhanVien.Text = "Nhân viên";
            this.btnNhanVien.TextColor = System.Drawing.Color.White;
            this.btnNhanVien.UseVisualStyleBackColor = false;
            this.btnNhanVien.Click += new System.EventHandler(this.btnNhanVien_Click);
            // 
            // btnNhaCungCap
            // 
            this.btnNhaCungCap.BackColor = System.Drawing.Color.Gray;
            this.btnNhaCungCap.BackgroundColor = System.Drawing.Color.Gray;
            this.btnNhaCungCap.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnNhaCungCap.BorderRadius = 0;
            this.btnNhaCungCap.BorderSize = 0;
            this.btnNhaCungCap.FlatAppearance.BorderSize = 0;
            this.btnNhaCungCap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhaCungCap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhaCungCap.ForeColor = System.Drawing.Color.White;
            this.btnNhaCungCap.Image = ((System.Drawing.Image)(resources.GetObject("btnNhaCungCap.Image")));
            this.btnNhaCungCap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhaCungCap.Location = new System.Drawing.Point(0, 93);
            this.btnNhaCungCap.Name = "btnNhaCungCap";
            this.btnNhaCungCap.Size = new System.Drawing.Size(197, 44);
            this.btnNhaCungCap.TabIndex = 4;
            this.btnNhaCungCap.Text = "Nhà cung cấp";
            this.btnNhaCungCap.TextColor = System.Drawing.Color.White;
            this.btnNhaCungCap.UseVisualStyleBackColor = false;
            this.btnNhaCungCap.Click += new System.EventHandler(this.btnNhaCungCap_Click);
            // 
            // btnSanPham
            // 
            this.btnSanPham.BackColor = System.Drawing.Color.Gray;
            this.btnSanPham.BackgroundColor = System.Drawing.Color.Gray;
            this.btnSanPham.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSanPham.BorderRadius = 0;
            this.btnSanPham.BorderSize = 0;
            this.btnSanPham.FlatAppearance.BorderSize = 0;
            this.btnSanPham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSanPham.ForeColor = System.Drawing.Color.White;
            this.btnSanPham.Image = ((System.Drawing.Image)(resources.GetObject("btnSanPham.Image")));
            this.btnSanPham.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSanPham.Location = new System.Drawing.Point(0, 49);
            this.btnSanPham.Name = "btnSanPham";
            this.btnSanPham.Size = new System.Drawing.Size(197, 44);
            this.btnSanPham.TabIndex = 3;
            this.btnSanPham.Text = "Sản phẩm";
            this.btnSanPham.TextColor = System.Drawing.Color.White;
            this.btnSanPham.UseVisualStyleBackColor = false;
            this.btnSanPham.Click += new System.EventHandler(this.btnSanPham_Click);
            // 
            // btnDanhMuc
            // 
            this.btnDanhMuc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnDanhMuc.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnDanhMuc.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnDanhMuc.BorderRadius = 0;
            this.btnDanhMuc.BorderSize = 0;
            this.btnDanhMuc.FlatAppearance.BorderSize = 0;
            this.btnDanhMuc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDanhMuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDanhMuc.ForeColor = System.Drawing.Color.White;
            this.btnDanhMuc.Image = ((System.Drawing.Image)(resources.GetObject("btnDanhMuc.Image")));
            this.btnDanhMuc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDanhMuc.Location = new System.Drawing.Point(0, -1);
            this.btnDanhMuc.Name = "btnDanhMuc";
            this.btnDanhMuc.Size = new System.Drawing.Size(197, 51);
            this.btnDanhMuc.TabIndex = 2;
            this.btnDanhMuc.Text = "Danh mục";
            this.btnDanhMuc.TextColor = System.Drawing.Color.White;
            this.btnDanhMuc.UseVisualStyleBackColor = false;
            this.btnDanhMuc.Click += new System.EventHandler(this.btnDanhMuc_Click);
            // 
            // btnTimKiemPhieuNhap
            // 
            this.btnTimKiemPhieuNhap.BackColor = System.Drawing.Color.Gray;
            this.btnTimKiemPhieuNhap.BackgroundColor = System.Drawing.Color.Gray;
            this.btnTimKiemPhieuNhap.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnTimKiemPhieuNhap.BorderRadius = 0;
            this.btnTimKiemPhieuNhap.BorderSize = 0;
            this.btnTimKiemPhieuNhap.FlatAppearance.BorderSize = 0;
            this.btnTimKiemPhieuNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiemPhieuNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiemPhieuNhap.ForeColor = System.Drawing.Color.White;
            this.btnTimKiemPhieuNhap.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiemPhieuNhap.Image")));
            this.btnTimKiemPhieuNhap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiemPhieuNhap.Location = new System.Drawing.Point(0, 137);
            this.btnTimKiemPhieuNhap.Name = "btnTimKiemPhieuNhap";
            this.btnTimKiemPhieuNhap.Size = new System.Drawing.Size(197, 44);
            this.btnTimKiemPhieuNhap.TabIndex = 7;
            this.btnTimKiemPhieuNhap.Text = "Phiếu nhập";
            this.btnTimKiemPhieuNhap.TextColor = System.Drawing.Color.White;
            this.btnTimKiemPhieuNhap.UseVisualStyleBackColor = false;
            this.btnTimKiemPhieuNhap.Click += new System.EventHandler(this.btnTimKiemPhieuNhap_Click);
            // 
            // btnTimKiemHoaDon
            // 
            this.btnTimKiemHoaDon.BackColor = System.Drawing.Color.Gray;
            this.btnTimKiemHoaDon.BackgroundColor = System.Drawing.Color.Gray;
            this.btnTimKiemHoaDon.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnTimKiemHoaDon.BorderRadius = 0;
            this.btnTimKiemHoaDon.BorderSize = 0;
            this.btnTimKiemHoaDon.FlatAppearance.BorderSize = 0;
            this.btnTimKiemHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiemHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiemHoaDon.ForeColor = System.Drawing.Color.White;
            this.btnTimKiemHoaDon.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiemHoaDon.Image")));
            this.btnTimKiemHoaDon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiemHoaDon.Location = new System.Drawing.Point(0, 93);
            this.btnTimKiemHoaDon.Name = "btnTimKiemHoaDon";
            this.btnTimKiemHoaDon.Size = new System.Drawing.Size(197, 44);
            this.btnTimKiemHoaDon.TabIndex = 6;
            this.btnTimKiemHoaDon.Text = "Hóa đơn";
            this.btnTimKiemHoaDon.TextColor = System.Drawing.Color.White;
            this.btnTimKiemHoaDon.UseVisualStyleBackColor = false;
            this.btnTimKiemHoaDon.Click += new System.EventHandler(this.btnTimKiemHoaDon_Click);
            // 
            // btnTimKiemSanPham
            // 
            this.btnTimKiemSanPham.BackColor = System.Drawing.Color.Gray;
            this.btnTimKiemSanPham.BackgroundColor = System.Drawing.Color.Gray;
            this.btnTimKiemSanPham.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnTimKiemSanPham.BorderRadius = 0;
            this.btnTimKiemSanPham.BorderSize = 0;
            this.btnTimKiemSanPham.FlatAppearance.BorderSize = 0;
            this.btnTimKiemSanPham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiemSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiemSanPham.ForeColor = System.Drawing.Color.White;
            this.btnTimKiemSanPham.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiemSanPham.Image")));
            this.btnTimKiemSanPham.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiemSanPham.Location = new System.Drawing.Point(0, 49);
            this.btnTimKiemSanPham.Name = "btnTimKiemSanPham";
            this.btnTimKiemSanPham.Size = new System.Drawing.Size(197, 44);
            this.btnTimKiemSanPham.TabIndex = 3;
            this.btnTimKiemSanPham.Text = "Sản phẩm";
            this.btnTimKiemSanPham.TextColor = System.Drawing.Color.White;
            this.btnTimKiemSanPham.UseVisualStyleBackColor = false;
            this.btnTimKiemSanPham.Click += new System.EventHandler(this.btnTimKiemSanPham_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnTimKiem.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnTimKiem.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnTimKiem.BorderRadius = 0;
            this.btnTimKiem.BorderSize = 0;
            this.btnTimKiem.FlatAppearance.BorderSize = 0;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.ForeColor = System.Drawing.Color.White;
            this.btnTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.Image")));
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.Location = new System.Drawing.Point(0, 0);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(197, 49);
            this.btnTimKiem.TabIndex = 2;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.TextColor = System.Drawing.Color.White;
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnGiaoHang
            // 
            this.btnGiaoHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnGiaoHang.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnGiaoHang.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnGiaoHang.BorderRadius = 0;
            this.btnGiaoHang.BorderSize = 0;
            this.btnGiaoHang.FlatAppearance.BorderSize = 0;
            this.btnGiaoHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGiaoHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGiaoHang.ForeColor = System.Drawing.Color.White;
            this.btnGiaoHang.Image = ((System.Drawing.Image)(resources.GetObject("btnGiaoHang.Image")));
            this.btnGiaoHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGiaoHang.Location = new System.Drawing.Point(3, 279);
            this.btnGiaoHang.Name = "btnGiaoHang";
            this.btnGiaoHang.Size = new System.Drawing.Size(197, 49);
            this.btnGiaoHang.TabIndex = 4;
            this.btnGiaoHang.Text = "Giao hàng";
            this.btnGiaoHang.TextColor = System.Drawing.Color.White;
            this.btnGiaoHang.UseVisualStyleBackColor = false;
            this.btnGiaoHang.Click += new System.EventHandler(this.btnGiaoHang_Click);
            // 
            // btnBaoCao
            // 
            this.btnBaoCao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnBaoCao.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnBaoCao.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnBaoCao.BorderRadius = 0;
            this.btnBaoCao.BorderSize = 0;
            this.btnBaoCao.FlatAppearance.BorderSize = 0;
            this.btnBaoCao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBaoCao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaoCao.ForeColor = System.Drawing.Color.White;
            this.btnBaoCao.Image = ((System.Drawing.Image)(resources.GetObject("btnBaoCao.Image")));
            this.btnBaoCao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBaoCao.Location = new System.Drawing.Point(3, 334);
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.Size = new System.Drawing.Size(197, 49);
            this.btnBaoCao.TabIndex = 3;
            this.btnBaoCao.Text = "Báo cáo";
            this.btnBaoCao.TextColor = System.Drawing.Color.White;
            this.btnBaoCao.UseVisualStyleBackColor = false;
            this.btnBaoCao.Click += new System.EventHandler(this.btnBaoCao_Click);
            // 
            // btnTaiKhoan
            // 
            this.btnTaiKhoan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnTaiKhoan.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnTaiKhoan.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnTaiKhoan.BorderRadius = 0;
            this.btnTaiKhoan.BorderSize = 0;
            this.btnTaiKhoan.FlatAppearance.BorderSize = 0;
            this.btnTaiKhoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaiKhoan.ForeColor = System.Drawing.Color.White;
            this.btnTaiKhoan.Image = ((System.Drawing.Image)(resources.GetObject("btnTaiKhoan.Image")));
            this.btnTaiKhoan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTaiKhoan.Location = new System.Drawing.Point(3, 389);
            this.btnTaiKhoan.Name = "btnTaiKhoan";
            this.btnTaiKhoan.Size = new System.Drawing.Size(197, 49);
            this.btnTaiKhoan.TabIndex = 6;
            this.btnTaiKhoan.Text = "Tài khoản";
            this.btnTaiKhoan.TextColor = System.Drawing.Color.White;
            this.btnTaiKhoan.UseVisualStyleBackColor = false;
            this.btnTaiKhoan.Click += new System.EventHandler(this.btnTaiKhoan_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnThoat.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnThoat.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnThoat.BorderRadius = 0;
            this.btnThoat.BorderSize = 0;
            this.btnThoat.FlatAppearance.BorderSize = 0;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(3, 444);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(197, 49);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextColor = System.Drawing.Color.White;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // FrmTrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 572);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmTrangChu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmTrangChu";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer colapse;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox logo;
        private CustomControls.RJControls.RJButton btnTrangChu;
        private System.Windows.Forms.Panel panel1;
        private CustomControls.RJControls.RJButton btnSanPham;
        private CustomControls.RJControls.RJButton btnDanhMuc;
        private CustomControls.RJControls.RJButton btnPhieuNhap;
        private CustomControls.RJControls.RJButton btnHoaDon;
        private CustomControls.RJControls.RJButton btnNhanVien;
        private CustomControls.RJControls.RJButton btnNhaCungCap;
        private CustomControls.RJControls.RJButton btnTimKiem;
        private CustomControls.RJControls.RJButton btnBaoCao;
        private CustomControls.RJControls.RJButton btnGiaoHang;
        private CustomControls.RJControls.RJButton btnThoat;
        private System.Windows.Forms.Panel panel3;
        private CustomControls.RJControls.RJButton btnTimKiemPhieuNhap;
        private CustomControls.RJControls.RJButton btnTimKiemHoaDon;
        private CustomControls.RJControls.RJButton btnTimKiemSanPham;
        private System.Windows.Forms.Timer colapse2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private CustomControls.RJControls.RJButton rjButton1;
        private System.Windows.Forms.Timer timer1;
        private CustomControls.RJControls.RJButton btnTaiKhoan;
    }
}