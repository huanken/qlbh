
namespace qlbh.UI
{
    partial class FrmPhieuNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPhieuNhap));
            this.rjCircularPictureBox1 = new CustomControls.RJControls.RJCircularPictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_Phieunhap = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_maphieunhap = new System.Windows.Forms.Label();
            this.txt_Ngaynhap = new System.Windows.Forms.Label();
            this.txt_Manv = new System.Windows.Forms.Label();
            this.txt_Trangthai = new System.Windows.Forms.Label();
            this.txt_Tongtien = new System.Windows.Forms.Label();
            this.txt_MaNcc = new System.Windows.Forms.Label();
            this.txtBox_MaPN = new CustomControls.RJControls.RJTextBox();
            this.txtBox_Trangthai = new CustomControls.RJControls.RJTextBox();
            this.txtBox_Tongtien = new CustomControls.RJControls.RJTextBox();
            this.date_nhap = new CustomControls.RJControls.RJDatePicker();
            this.cbo_manv = new CustomControls.RJControls.RJComboBox();
            this.cbo_NCC = new CustomControls.RJControls.RJComboBox();
            this.dgv_phieunhap = new System.Windows.Forms.DataGridView();
            this.btn_Them = new CustomControls.RJControls.RJButton();
            this.btn_Luu = new CustomControls.RJControls.RJButton();
            this.btn_Sua = new CustomControls.RJControls.RJButton();
            this.btn_Xoa = new CustomControls.RJControls.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_phieunhap)).BeginInit();
            this.SuspendLayout();
            // 
            // rjCircularPictureBox1
            // 
            this.rjCircularPictureBox1.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.rjCircularPictureBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(202)))), ((int)(((byte)(64)))));
            this.rjCircularPictureBox1.BorderColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(115)))), ((int)(((byte)(34)))));
            this.rjCircularPictureBox1.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.rjCircularPictureBox1.BorderSize = 2;
            this.rjCircularPictureBox1.GradientAngle = 50F;
            this.rjCircularPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("rjCircularPictureBox1.Image")));
            this.rjCircularPictureBox1.Location = new System.Drawing.Point(43, 18);
            this.rjCircularPictureBox1.Name = "rjCircularPictureBox1";
            this.rjCircularPictureBox1.Size = new System.Drawing.Size(100, 100);
            this.rjCircularPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rjCircularPictureBox1.TabIndex = 0;
            this.rjCircularPictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(202)))), ((int)(((byte)(64)))));
            this.panel1.Location = new System.Drawing.Point(160, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(718, 3);
            this.panel1.TabIndex = 1;
            // 
            // txt_Phieunhap
            // 
            this.txt_Phieunhap.AutoSize = true;
            this.txt_Phieunhap.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Phieunhap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(202)))), ((int)(((byte)(64)))));
            this.txt_Phieunhap.Location = new System.Drawing.Point(387, 18);
            this.txt_Phieunhap.Name = "txt_Phieunhap";
            this.txt_Phieunhap.Size = new System.Drawing.Size(173, 31);
            this.txt_Phieunhap.TabIndex = 2;
            this.txt_Phieunhap.Text = "Phiếu nhập";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(202)))), ((int)(((byte)(64)))));
            this.panel2.Location = new System.Drawing.Point(86, 490);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(718, 3);
            this.panel2.TabIndex = 1;
            // 
            // txt_maphieunhap
            // 
            this.txt_maphieunhap.AutoSize = true;
            this.txt_maphieunhap.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_maphieunhap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(202)))), ((int)(((byte)(64)))));
            this.txt_maphieunhap.Location = new System.Drawing.Point(36, 166);
            this.txt_maphieunhap.Name = "txt_maphieunhap";
            this.txt_maphieunhap.Size = new System.Drawing.Size(129, 18);
            this.txt_maphieunhap.TabIndex = 3;
            this.txt_maphieunhap.Text = "Mã phiếu nhập:";
            // 
            // txt_Ngaynhap
            // 
            this.txt_Ngaynhap.AutoSize = true;
            this.txt_Ngaynhap.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Ngaynhap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(202)))), ((int)(((byte)(64)))));
            this.txt_Ngaynhap.Location = new System.Drawing.Point(36, 203);
            this.txt_Ngaynhap.Name = "txt_Ngaynhap";
            this.txt_Ngaynhap.Size = new System.Drawing.Size(96, 18);
            this.txt_Ngaynhap.TabIndex = 3;
            this.txt_Ngaynhap.Text = "Ngày nhập:";
            // 
            // txt_Manv
            // 
            this.txt_Manv.AutoSize = true;
            this.txt_Manv.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Manv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(202)))), ((int)(((byte)(64)))));
            this.txt_Manv.Location = new System.Drawing.Point(36, 240);
            this.txt_Manv.Name = "txt_Manv";
            this.txt_Manv.Size = new System.Drawing.Size(117, 18);
            this.txt_Manv.TabIndex = 3;
            this.txt_Manv.Text = "Mã nhân viên:";
            // 
            // txt_Trangthai
            // 
            this.txt_Trangthai.AutoSize = true;
            this.txt_Trangthai.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Trangthai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(202)))), ((int)(((byte)(64)))));
            this.txt_Trangthai.Location = new System.Drawing.Point(36, 277);
            this.txt_Trangthai.Name = "txt_Trangthai";
            this.txt_Trangthai.Size = new System.Drawing.Size(94, 18);
            this.txt_Trangthai.TabIndex = 3;
            this.txt_Trangthai.Text = "Trạng thái:";
            // 
            // txt_Tongtien
            // 
            this.txt_Tongtien.AutoSize = true;
            this.txt_Tongtien.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Tongtien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(202)))), ((int)(((byte)(64)))));
            this.txt_Tongtien.Location = new System.Drawing.Point(36, 314);
            this.txt_Tongtien.Name = "txt_Tongtien";
            this.txt_Tongtien.Size = new System.Drawing.Size(87, 18);
            this.txt_Tongtien.TabIndex = 3;
            this.txt_Tongtien.Text = "Tổng tiền:";
            // 
            // txt_MaNcc
            // 
            this.txt_MaNcc.AutoSize = true;
            this.txt_MaNcc.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaNcc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(202)))), ((int)(((byte)(64)))));
            this.txt_MaNcc.Location = new System.Drawing.Point(36, 351);
            this.txt_MaNcc.Name = "txt_MaNcc";
            this.txt_MaNcc.Size = new System.Drawing.Size(92, 18);
            this.txt_MaNcc.TabIndex = 3;
            this.txt_MaNcc.Text = "Mã _ NCC:";
            // 
            // txtBox_MaPN
            // 
            this.txtBox_MaPN.BackColor = System.Drawing.Color.White;
            this.txtBox_MaPN.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(202)))), ((int)(((byte)(64)))));
            this.txtBox_MaPN.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtBox_MaPN.BorderRadius = 0;
            this.txtBox_MaPN.BorderSize = 2;
            this.txtBox_MaPN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_MaPN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBox_MaPN.Location = new System.Drawing.Point(173, 159);
            this.txtBox_MaPN.Margin = new System.Windows.Forms.Padding(4);
            this.txtBox_MaPN.Multiline = false;
            this.txtBox_MaPN.Name = "txtBox_MaPN";
            this.txtBox_MaPN.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtBox_MaPN.PasswordChar = false;
            this.txtBox_MaPN.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtBox_MaPN.PlaceholderText = "";
            this.txtBox_MaPN.Size = new System.Drawing.Size(220, 31);
            this.txtBox_MaPN.TabIndex = 4;
            this.txtBox_MaPN.Texts = "";
            this.txtBox_MaPN.UnderlinedStyle = false;
            // 
            // txtBox_Trangthai
            // 
            this.txtBox_Trangthai.BackColor = System.Drawing.Color.White;
            this.txtBox_Trangthai.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(202)))), ((int)(((byte)(64)))));
            this.txtBox_Trangthai.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtBox_Trangthai.BorderRadius = 0;
            this.txtBox_Trangthai.BorderSize = 2;
            this.txtBox_Trangthai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_Trangthai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBox_Trangthai.Location = new System.Drawing.Point(174, 270);
            this.txtBox_Trangthai.Margin = new System.Windows.Forms.Padding(4);
            this.txtBox_Trangthai.Multiline = false;
            this.txtBox_Trangthai.Name = "txtBox_Trangthai";
            this.txtBox_Trangthai.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtBox_Trangthai.PasswordChar = false;
            this.txtBox_Trangthai.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtBox_Trangthai.PlaceholderText = "";
            this.txtBox_Trangthai.Size = new System.Drawing.Size(220, 31);
            this.txtBox_Trangthai.TabIndex = 4;
            this.txtBox_Trangthai.Texts = "";
            this.txtBox_Trangthai.UnderlinedStyle = false;
            // 
            // txtBox_Tongtien
            // 
            this.txtBox_Tongtien.BackColor = System.Drawing.Color.White;
            this.txtBox_Tongtien.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(202)))), ((int)(((byte)(64)))));
            this.txtBox_Tongtien.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtBox_Tongtien.BorderRadius = 0;
            this.txtBox_Tongtien.BorderSize = 2;
            this.txtBox_Tongtien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_Tongtien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBox_Tongtien.Location = new System.Drawing.Point(173, 307);
            this.txtBox_Tongtien.Margin = new System.Windows.Forms.Padding(4);
            this.txtBox_Tongtien.Multiline = false;
            this.txtBox_Tongtien.Name = "txtBox_Tongtien";
            this.txtBox_Tongtien.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtBox_Tongtien.PasswordChar = false;
            this.txtBox_Tongtien.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtBox_Tongtien.PlaceholderText = "";
            this.txtBox_Tongtien.Size = new System.Drawing.Size(220, 31);
            this.txtBox_Tongtien.TabIndex = 4;
            this.txtBox_Tongtien.Texts = "";
            this.txtBox_Tongtien.UnderlinedStyle = false;
            // 
            // date_nhap
            // 
            this.date_nhap.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(202)))), ((int)(((byte)(64)))));
            this.date_nhap.BorderSize = 2;
            this.date_nhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.date_nhap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_nhap.Location = new System.Drawing.Point(173, 196);
            this.date_nhap.MinimumSize = new System.Drawing.Size(0, 31);
            this.date_nhap.Name = "date_nhap";
            this.date_nhap.Size = new System.Drawing.Size(220, 31);
            this.date_nhap.SkinColor = System.Drawing.Color.White;
            this.date_nhap.TabIndex = 5;
            this.date_nhap.TextColor = System.Drawing.Color.Black;
            // 
            // cbo_manv
            // 
            this.cbo_manv.BackColor = System.Drawing.Color.White;
            this.cbo_manv.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(202)))), ((int)(((byte)(64)))));
            this.cbo_manv.BorderSize = 2;
            this.cbo_manv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cbo_manv.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_manv.ForeColor = System.Drawing.Color.Black;
            this.cbo_manv.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(202)))), ((int)(((byte)(64)))));
            this.cbo_manv.ListBackColor = System.Drawing.Color.White;
            this.cbo_manv.ListTextColor = System.Drawing.Color.Black;
            this.cbo_manv.Location = new System.Drawing.Point(174, 233);
            this.cbo_manv.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbo_manv.Name = "cbo_manv";
            this.cbo_manv.Padding = new System.Windows.Forms.Padding(2);
            this.cbo_manv.Size = new System.Drawing.Size(220, 31);
            this.cbo_manv.TabIndex = 6;
            this.cbo_manv.Texts = "";
            // 
            // cbo_NCC
            // 
            this.cbo_NCC.BackColor = System.Drawing.Color.White;
            this.cbo_NCC.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(202)))), ((int)(((byte)(64)))));
            this.cbo_NCC.BorderSize = 2;
            this.cbo_NCC.DisplayMember = "Đã thah toán";
            this.cbo_NCC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cbo_NCC.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_NCC.ForeColor = System.Drawing.Color.Black;
            this.cbo_NCC.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(202)))), ((int)(((byte)(64)))));
            this.cbo_NCC.ListBackColor = System.Drawing.Color.White;
            this.cbo_NCC.ListTextColor = System.Drawing.Color.Black;
            this.cbo_NCC.Location = new System.Drawing.Point(173, 344);
            this.cbo_NCC.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbo_NCC.Name = "cbo_NCC";
            this.cbo_NCC.Padding = new System.Windows.Forms.Padding(2);
            this.cbo_NCC.Size = new System.Drawing.Size(220, 31);
            this.cbo_NCC.TabIndex = 6;
            this.cbo_NCC.Texts = "";
            // 
            // dgv_phieunhap
            // 
            this.dgv_phieunhap.BackgroundColor = System.Drawing.Color.White;
            this.dgv_phieunhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_phieunhap.Location = new System.Drawing.Point(400, 159);
            this.dgv_phieunhap.Name = "dgv_phieunhap";
            this.dgv_phieunhap.Size = new System.Drawing.Size(478, 216);
            this.dgv_phieunhap.TabIndex = 7;
            // 
            // btn_Them
            // 
            this.btn_Them.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(202)))), ((int)(((byte)(64)))));
            this.btn_Them.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(202)))), ((int)(((byte)(64)))));
            this.btn_Them.BorderColor = System.Drawing.Color.White;
            this.btn_Them.BorderRadius = 20;
            this.btn_Them.BorderSize = 2;
            this.btn_Them.FlatAppearance.BorderSize = 0;
            this.btn_Them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Them.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.ForeColor = System.Drawing.Color.White;
            this.btn_Them.Location = new System.Drawing.Point(148, 426);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(102, 40);
            this.btn_Them.TabIndex = 8;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.TextColor = System.Drawing.Color.White;
            this.btn_Them.UseVisualStyleBackColor = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Luu
            // 
            this.btn_Luu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(202)))), ((int)(((byte)(64)))));
            this.btn_Luu.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(202)))), ((int)(((byte)(64)))));
            this.btn_Luu.BorderColor = System.Drawing.Color.White;
            this.btn_Luu.BorderRadius = 20;
            this.btn_Luu.BorderSize = 2;
            this.btn_Luu.FlatAppearance.BorderSize = 0;
            this.btn_Luu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Luu.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Luu.ForeColor = System.Drawing.Color.White;
            this.btn_Luu.Location = new System.Drawing.Point(323, 426);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(102, 40);
            this.btn_Luu.TabIndex = 8;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.TextColor = System.Drawing.Color.White;
            this.btn_Luu.UseVisualStyleBackColor = false;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(202)))), ((int)(((byte)(64)))));
            this.btn_Sua.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(202)))), ((int)(((byte)(64)))));
            this.btn_Sua.BorderColor = System.Drawing.Color.White;
            this.btn_Sua.BorderRadius = 20;
            this.btn_Sua.BorderSize = 2;
            this.btn_Sua.FlatAppearance.BorderSize = 0;
            this.btn_Sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Sua.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.ForeColor = System.Drawing.Color.White;
            this.btn_Sua.Location = new System.Drawing.Point(498, 426);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(102, 40);
            this.btn_Sua.TabIndex = 8;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.TextColor = System.Drawing.Color.White;
            this.btn_Sua.UseVisualStyleBackColor = false;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(202)))), ((int)(((byte)(64)))));
            this.btn_Xoa.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(202)))), ((int)(((byte)(64)))));
            this.btn_Xoa.BorderColor = System.Drawing.Color.White;
            this.btn_Xoa.BorderRadius = 20;
            this.btn_Xoa.BorderSize = 2;
            this.btn_Xoa.FlatAppearance.BorderSize = 0;
            this.btn_Xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Xoa.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.ForeColor = System.Drawing.Color.White;
            this.btn_Xoa.Location = new System.Drawing.Point(673, 426);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(102, 40);
            this.btn_Xoa.TabIndex = 8;
            this.btn_Xoa.Text = "Xoá";
            this.btn_Xoa.TextColor = System.Drawing.Color.White;
            this.btn_Xoa.UseVisualStyleBackColor = false;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // FrmPhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(890, 530);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Luu);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.dgv_phieunhap);
            this.Controls.Add(this.cbo_NCC);
            this.Controls.Add(this.cbo_manv);
            this.Controls.Add(this.date_nhap);
            this.Controls.Add(this.txtBox_Tongtien);
            this.Controls.Add(this.txtBox_Trangthai);
            this.Controls.Add(this.txtBox_MaPN);
            this.Controls.Add(this.txt_MaNcc);
            this.Controls.Add(this.txt_Tongtien);
            this.Controls.Add(this.txt_Trangthai);
            this.Controls.Add(this.txt_Manv);
            this.Controls.Add(this.txt_Ngaynhap);
            this.Controls.Add(this.txt_maphieunhap);
            this.Controls.Add(this.txt_Phieunhap);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.rjCircularPictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPhieuNhap";
            this.Text = "FrmPhieuNhap";
            this.Load += new System.EventHandler(this.FrmPhieuNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_phieunhap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.RJControls.RJCircularPictureBox rjCircularPictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label txt_Phieunhap;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label txt_maphieunhap;
        private System.Windows.Forms.Label txt_Ngaynhap;
        private System.Windows.Forms.Label txt_Manv;
        private System.Windows.Forms.Label txt_Trangthai;
        private System.Windows.Forms.Label txt_Tongtien;
        private System.Windows.Forms.Label txt_MaNcc;
        private CustomControls.RJControls.RJTextBox txtBox_MaPN;
        private CustomControls.RJControls.RJTextBox txtBox_Trangthai;
        private CustomControls.RJControls.RJTextBox txtBox_Tongtien;
        private CustomControls.RJControls.RJDatePicker date_nhap;
        private CustomControls.RJControls.RJComboBox cbo_manv;
        private CustomControls.RJControls.RJComboBox cbo_NCC;
        private System.Windows.Forms.DataGridView dgv_phieunhap;
        private CustomControls.RJControls.RJButton btn_Them;
        private CustomControls.RJControls.RJButton btn_Luu;
        private CustomControls.RJControls.RJButton btn_Sua;
        private CustomControls.RJControls.RJButton btn_Xoa;
    }
}