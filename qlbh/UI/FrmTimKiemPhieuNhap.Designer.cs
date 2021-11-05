
namespace qlbh.UI
{
    partial class FrmTimKiemPhieuNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTimKiemPhieuNhap));
            this.cbbNCC = new CustomControls.RJControls.RJComboBox();
            this.optNCC = new CustomControls.RJControls.RJRadioButton();
            this.optNgayNhap = new CustomControls.RJControls.RJRadioButton();
            this.optMaPN = new CustomControls.RJControls.RJRadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pic1 = new CustomControls.RJControls.RJCircularPictureBox();
            this.btnReset = new CustomControls.RJControls.RJButton();
            this.btnTimKiem = new CustomControls.RJControls.RJButton();
            this.txtMaPN = new CustomControls.RJControls.RJTextBox();
            this.GridView_PN = new System.Windows.Forms.DataGridView();
            this.dateNgayNhap = new CustomControls.RJControls.RJDatePicker();
            this.btnChiTiet = new CustomControls.RJControls.RJButton();
            this.btnXoa = new CustomControls.RJControls.RJButton();
            this.txtNhaCungCap = new CustomControls.RJControls.RJTextBox();
            this.dateNgayNhap2 = new CustomControls.RJControls.RJDatePicker();
            this.lblTuNgay = new System.Windows.Forms.Label();
            this.lblDenNgay = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_PN)).BeginInit();
            this.SuspendLayout();
            // 
            // cbbNCC
            // 
            this.cbbNCC.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbbNCC.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cbbNCC.BorderSize = 2;
            this.cbbNCC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbbNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbbNCC.ForeColor = System.Drawing.Color.DimGray;
            this.cbbNCC.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cbbNCC.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbbNCC.ListTextColor = System.Drawing.Color.DimGray;
            this.cbbNCC.Location = new System.Drawing.Point(665, 130);
            this.cbbNCC.MinimumSize = new System.Drawing.Size(150, 30);
            this.cbbNCC.Name = "cbbNCC";
            this.cbbNCC.Padding = new System.Windows.Forms.Padding(2);
            this.cbbNCC.Size = new System.Drawing.Size(180, 30);
            this.cbbNCC.TabIndex = 51;
            this.cbbNCC.Texts = "";
            this.cbbNCC.OnSelectedIndexChanged += new System.EventHandler(this.cbbNCC_OnSelectedIndexChanged);
            // 
            // optNCC
            // 
            this.optNCC.AutoSize = true;
            this.optNCC.CheckedColor = System.Drawing.Color.MediumSlateBlue;
            this.optNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optNCC.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.optNCC.Location = new System.Drawing.Point(684, 100);
            this.optNCC.MinimumSize = new System.Drawing.Size(0, 21);
            this.optNCC.Name = "optNCC";
            this.optNCC.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.optNCC.Size = new System.Drawing.Size(139, 22);
            this.optNCC.TabIndex = 50;
            this.optNCC.TabStop = true;
            this.optNCC.Text = "Nhà cung cấp";
            this.optNCC.UnCheckedColor = System.Drawing.Color.Gray;
            this.optNCC.UseVisualStyleBackColor = true;
            this.optNCC.CheckedChanged += new System.EventHandler(this.optNCC_CheckedChanged);
            // 
            // optNgayNhap
            // 
            this.optNgayNhap.AutoSize = true;
            this.optNgayNhap.CheckedColor = System.Drawing.Color.MediumAquamarine;
            this.optNgayNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optNgayNhap.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.optNgayNhap.Location = new System.Drawing.Point(429, 96);
            this.optNgayNhap.MinimumSize = new System.Drawing.Size(0, 21);
            this.optNgayNhap.Name = "optNgayNhap";
            this.optNgayNhap.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.optNgayNhap.Size = new System.Drawing.Size(115, 22);
            this.optNgayNhap.TabIndex = 49;
            this.optNgayNhap.TabStop = true;
            this.optNgayNhap.Text = "Ngày nhập";
            this.optNgayNhap.UnCheckedColor = System.Drawing.Color.Gray;
            this.optNgayNhap.UseVisualStyleBackColor = true;
            this.optNgayNhap.CheckedChanged += new System.EventHandler(this.optNgayNhap_CheckedChanged);
            // 
            // optMaPN
            // 
            this.optMaPN.AutoSize = true;
            this.optMaPN.CheckedColor = System.Drawing.Color.IndianRed;
            this.optMaPN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optMaPN.ForeColor = System.Drawing.Color.IndianRed;
            this.optMaPN.Location = new System.Drawing.Point(133, 130);
            this.optMaPN.MinimumSize = new System.Drawing.Size(0, 21);
            this.optMaPN.Name = "optMaPN";
            this.optMaPN.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.optMaPN.Size = new System.Drawing.Size(145, 22);
            this.optMaPN.TabIndex = 47;
            this.optMaPN.TabStop = true;
            this.optMaPN.Text = "Mã phiếu nhập";
            this.optMaPN.UnCheckedColor = System.Drawing.Color.Gray;
            this.optMaPN.UseVisualStyleBackColor = true;
            this.optMaPN.CheckedChanged += new System.EventHandler(this.optMaPN_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(347, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 31);
            this.label1.TabIndex = 46;
            this.label1.Text = "Tìm Kiếm Phiếu Nhập";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Firebrick;
            this.panel2.Location = new System.Drawing.Point(106, 502);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(757, 3);
            this.panel2.TabIndex = 45;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightCoral;
            this.panel1.Location = new System.Drawing.Point(161, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(718, 3);
            this.panel1.TabIndex = 44;
            // 
            // pic1
            // 
            this.pic1.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Triangle;
            this.pic1.BorderColor = System.Drawing.Color.RoyalBlue;
            this.pic1.BorderColor2 = System.Drawing.Color.HotPink;
            this.pic1.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.pic1.BorderSize = 3;
            this.pic1.GradientAngle = 50F;
            this.pic1.Image = ((System.Drawing.Image)(resources.GetObject("pic1.Image")));
            this.pic1.Location = new System.Drawing.Point(43, 26);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(109, 109);
            this.pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic1.TabIndex = 43;
            this.pic1.TabStop = false;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Tomato;
            this.btnReset.BackgroundColor = System.Drawing.Color.Tomato;
            this.btnReset.BorderColor = System.Drawing.SystemColors.WindowText;
            this.btnReset.BorderRadius = 20;
            this.btnReset.BorderSize = 1;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(736, 293);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(128, 40);
            this.btnReset.TabIndex = 42;
            this.btnReset.Text = "Reset";
            this.btnReset.TextColor = System.Drawing.Color.White;
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.Tomato;
            this.btnTimKiem.BackgroundColor = System.Drawing.Color.Tomato;
            this.btnTimKiem.BorderColor = System.Drawing.SystemColors.WindowText;
            this.btnTimKiem.BorderRadius = 20;
            this.btnTimKiem.BorderSize = 1;
            this.btnTimKiem.FlatAppearance.BorderSize = 0;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.ForeColor = System.Drawing.Color.White;
            this.btnTimKiem.Location = new System.Drawing.Point(736, 239);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(127, 40);
            this.btnTimKiem.TabIndex = 41;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.TextColor = System.Drawing.Color.White;
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtMaPN
            // 
            this.txtMaPN.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtMaPN.BorderColor = System.Drawing.Color.Salmon;
            this.txtMaPN.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtMaPN.BorderRadius = 7;
            this.txtMaPN.BorderSize = 1;
            this.txtMaPN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaPN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMaPN.Location = new System.Drawing.Point(133, 159);
            this.txtMaPN.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaPN.Multiline = false;
            this.txtMaPN.Name = "txtMaPN";
            this.txtMaPN.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtMaPN.PasswordChar = false;
            this.txtMaPN.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtMaPN.PlaceholderText = "";
            this.txtMaPN.Size = new System.Drawing.Size(173, 31);
            this.txtMaPN.TabIndex = 40;
            this.txtMaPN.Texts = "";
            this.txtMaPN.UnderlinedStyle = false;
            // 
            // GridView_PN
            // 
            this.GridView_PN.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GridView_PN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView_PN.Location = new System.Drawing.Point(106, 218);
            this.GridView_PN.Name = "GridView_PN";
            this.GridView_PN.Size = new System.Drawing.Size(599, 262);
            this.GridView_PN.TabIndex = 39;
            // 
            // dateNgayNhap
            // 
            this.dateNgayNhap.BorderColor = System.Drawing.Color.MintCream;
            this.dateNgayNhap.BorderSize = 2;
            this.dateNgayNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.dateNgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateNgayNhap.Location = new System.Drawing.Point(405, 125);
            this.dateNgayNhap.MinimumSize = new System.Drawing.Size(4, 35);
            this.dateNgayNhap.Name = "dateNgayNhap";
            this.dateNgayNhap.Size = new System.Drawing.Size(187, 35);
            this.dateNgayNhap.SkinColor = System.Drawing.Color.MediumAquamarine;
            this.dateNgayNhap.TabIndex = 52;
            this.dateNgayNhap.TextColor = System.Drawing.Color.White;
            // 
            // btnChiTiet
            // 
            this.btnChiTiet.BackColor = System.Drawing.Color.Tomato;
            this.btnChiTiet.BackgroundColor = System.Drawing.Color.Tomato;
            this.btnChiTiet.BorderColor = System.Drawing.SystemColors.WindowText;
            this.btnChiTiet.BorderRadius = 20;
            this.btnChiTiet.BorderSize = 1;
            this.btnChiTiet.FlatAppearance.BorderSize = 0;
            this.btnChiTiet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChiTiet.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChiTiet.ForeColor = System.Drawing.Color.White;
            this.btnChiTiet.Location = new System.Drawing.Point(736, 349);
            this.btnChiTiet.Name = "btnChiTiet";
            this.btnChiTiet.Size = new System.Drawing.Size(128, 40);
            this.btnChiTiet.TabIndex = 53;
            this.btnChiTiet.Text = "Chi tiết";
            this.btnChiTiet.TextColor = System.Drawing.Color.White;
            this.btnChiTiet.UseVisualStyleBackColor = false;
            this.btnChiTiet.Click += new System.EventHandler(this.btnChiTiet_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Tomato;
            this.btnXoa.BackgroundColor = System.Drawing.Color.Tomato;
            this.btnXoa.BorderColor = System.Drawing.SystemColors.WindowText;
            this.btnXoa.BorderRadius = 20;
            this.btnXoa.BorderSize = 1;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(736, 403);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(128, 40);
            this.btnXoa.TabIndex = 54;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextColor = System.Drawing.Color.White;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // txtNhaCungCap
            // 
            this.txtNhaCungCap.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtNhaCungCap.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtNhaCungCap.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtNhaCungCap.BorderRadius = 0;
            this.txtNhaCungCap.BorderSize = 2;
            this.txtNhaCungCap.Enabled = false;
            this.txtNhaCungCap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNhaCungCap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNhaCungCap.Location = new System.Drawing.Point(605, 168);
            this.txtNhaCungCap.Margin = new System.Windows.Forms.Padding(4);
            this.txtNhaCungCap.Multiline = false;
            this.txtNhaCungCap.Name = "txtNhaCungCap";
            this.txtNhaCungCap.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtNhaCungCap.PasswordChar = false;
            this.txtNhaCungCap.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtNhaCungCap.PlaceholderText = "";
            this.txtNhaCungCap.Size = new System.Drawing.Size(302, 32);
            this.txtNhaCungCap.TabIndex = 55;
            this.txtNhaCungCap.Texts = "";
            this.txtNhaCungCap.UnderlinedStyle = false;
            // 
            // dateNgayNhap2
            // 
            this.dateNgayNhap2.BorderColor = System.Drawing.Color.MintCream;
            this.dateNgayNhap2.BorderSize = 2;
            this.dateNgayNhap2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.dateNgayNhap2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateNgayNhap2.Location = new System.Drawing.Point(405, 166);
            this.dateNgayNhap2.MinimumSize = new System.Drawing.Size(4, 35);
            this.dateNgayNhap2.Name = "dateNgayNhap2";
            this.dateNgayNhap2.Size = new System.Drawing.Size(187, 35);
            this.dateNgayNhap2.SkinColor = System.Drawing.Color.MediumAquamarine;
            this.dateNgayNhap2.TabIndex = 56;
            this.dateNgayNhap2.TextColor = System.Drawing.Color.White;
            // 
            // lblTuNgay
            // 
            this.lblTuNgay.AutoSize = true;
            this.lblTuNgay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTuNgay.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTuNgay.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.lblTuNgay.Location = new System.Drawing.Point(316, 134);
            this.lblTuNgay.Name = "lblTuNgay";
            this.lblTuNgay.Size = new System.Drawing.Size(78, 18);
            this.lblTuNgay.TabIndex = 57;
            this.lblTuNgay.Text = "Từ ngày:";
            // 
            // lblDenNgay
            // 
            this.lblDenNgay.AutoSize = true;
            this.lblDenNgay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDenNgay.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDenNgay.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.lblDenNgay.Location = new System.Drawing.Point(316, 174);
            this.lblDenNgay.Name = "lblDenNgay";
            this.lblDenNgay.Size = new System.Drawing.Size(89, 18);
            this.lblDenNgay.TabIndex = 58;
            this.lblDenNgay.Text = "Đến ngày:";
            // 
            // FrmTimKiemPhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(923, 538);
            this.ControlBox = false;
            this.Controls.Add(this.lblDenNgay);
            this.Controls.Add(this.lblTuNgay);
            this.Controls.Add(this.dateNgayNhap2);
            this.Controls.Add(this.txtNhaCungCap);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnChiTiet);
            this.Controls.Add(this.dateNgayNhap);
            this.Controls.Add(this.cbbNCC);
            this.Controls.Add(this.optNCC);
            this.Controls.Add(this.optNgayNhap);
            this.Controls.Add(this.optMaPN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pic1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtMaPN);
            this.Controls.Add(this.GridView_PN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmTimKiemPhieuNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmTimKiemPhieuNhap";
            this.Load += new System.EventHandler(this.FrmTimKiemPhieuNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_PN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.RJControls.RJComboBox cbbNCC;
        private CustomControls.RJControls.RJRadioButton optNCC;
        private CustomControls.RJControls.RJRadioButton optNgayNhap;
        private CustomControls.RJControls.RJRadioButton optMaPN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private CustomControls.RJControls.RJCircularPictureBox pic1;
        private CustomControls.RJControls.RJButton btnReset;
        private CustomControls.RJControls.RJButton btnTimKiem;
        private CustomControls.RJControls.RJTextBox txtMaPN;
        private System.Windows.Forms.DataGridView GridView_PN;
        private CustomControls.RJControls.RJDatePicker dateNgayNhap;
        private CustomControls.RJControls.RJButton btnChiTiet;
        private CustomControls.RJControls.RJButton btnXoa;
        private CustomControls.RJControls.RJTextBox txtNhaCungCap;
        private CustomControls.RJControls.RJDatePicker dateNgayNhap2;
        private System.Windows.Forms.Label lblTuNgay;
        private System.Windows.Forms.Label lblDenNgay;
    }
}