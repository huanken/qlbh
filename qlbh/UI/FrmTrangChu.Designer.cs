﻿
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnTrangChu = new CustomControls.RJControls.RJButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPhieuNhap = new CustomControls.RJControls.RJButton();
            this.btnHoaDon = new CustomControls.RJControls.RJButton();
            this.btnNhanVien = new CustomControls.RJControls.RJButton();
            this.btnNhaCungCap = new CustomControls.RJControls.RJButton();
            this.btnSanPham = new CustomControls.RJControls.RJButton();
            this.btnDanhMuc = new CustomControls.RJControls.RJButton();
            this.btnTimKiem = new CustomControls.RJControls.RJButton();
            this.btnGiaoHang = new CustomControls.RJControls.RJButton();
            this.btnBaoCao = new CustomControls.RJControls.RJButton();
            this.btnThoat = new CustomControls.RJControls.RJButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.flowLayoutPanel1.Controls.Add(this.pictureBox1);
            this.flowLayoutPanel1.Controls.Add(this.btnTrangChu);
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.btnTimKiem);
            this.flowLayoutPanel1.Controls.Add(this.btnGiaoHang);
            this.flowLayoutPanel1.Controls.Add(this.btnBaoCao);
            this.flowLayoutPanel1.Controls.Add(this.btnThoat);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 531);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(197, 71);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
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
            this.btnTrangChu.Location = new System.Drawing.Point(3, 80);
            this.btnTrangChu.Name = "btnTrangChu";
            this.btnTrangChu.Size = new System.Drawing.Size(197, 49);
            this.btnTrangChu.TabIndex = 1;
            this.btnTrangChu.Text = "Trang Chủ";
            this.btnTrangChu.TextColor = System.Drawing.Color.White;
            this.btnTrangChu.UseVisualStyleBackColor = false;
            this.btnTrangChu.Click += new System.EventHandler(this.btnTrangChu_Click);
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
            this.panel1.Location = new System.Drawing.Point(3, 135);
            this.panel1.MaximumSize = new System.Drawing.Size(198, 271);
            this.panel1.MinimumSize = new System.Drawing.Size(198, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(198, 50);
            this.panel1.TabIndex = 1;
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
            this.btnTimKiem.Location = new System.Drawing.Point(3, 191);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(197, 49);
            this.btnTimKiem.TabIndex = 2;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.TextColor = System.Drawing.Color.White;
            this.btnTimKiem.UseVisualStyleBackColor = false;
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
            this.btnGiaoHang.Location = new System.Drawing.Point(3, 246);
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
            this.btnBaoCao.Location = new System.Drawing.Point(3, 301);
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.Size = new System.Drawing.Size(197, 49);
            this.btnBaoCao.TabIndex = 3;
            this.btnBaoCao.Text = "Báo cáo";
            this.btnBaoCao.TextColor = System.Drawing.Color.White;
            this.btnBaoCao.UseVisualStyleBackColor = false;
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
            this.btnThoat.Location = new System.Drawing.Point(3, 356);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(197, 49);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextColor = System.Drawing.Color.White;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(200, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(827, 531);
            this.panel2.TabIndex = 1;
            // 
            // FrmTrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 531);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmTrangChu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmTrangChu";
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer colapse;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
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
        private System.Windows.Forms.Panel panel2;
    }
}