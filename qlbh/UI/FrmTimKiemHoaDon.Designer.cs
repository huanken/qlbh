
namespace qlbh.UI
{
    partial class FrmTimKiemHoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTimKiemHoaDon));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pic1 = new CustomControls.RJControls.RJCircularPictureBox();
            this.btnXoa = new CustomControls.RJControls.RJButton();
            this.btnChiTiet = new CustomControls.RJControls.RJButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnReset = new CustomControls.RJControls.RJButton();
            this.btnTimKiem = new CustomControls.RJControls.RJButton();
            this.GridView_HDBH = new System.Windows.Forms.DataGridView();
            this.optMahdban = new CustomControls.RJControls.RJRadioButton();
            this.txtMahdban = new CustomControls.RJControls.RJTextBox();
            this.dateNgayban = new CustomControls.RJControls.RJDatePicker();
            this.optNgayban = new CustomControls.RJControls.RJRadioButton();
            this.cbbManv = new CustomControls.RJControls.RJComboBox();
            this.optManv = new CustomControls.RJControls.RJRadioButton();
            this.txtTennv = new CustomControls.RJControls.RJTextBox();
            this.lblDenNgay = new System.Windows.Forms.Label();
            this.dateNgayBan2 = new CustomControls.RJControls.RJDatePicker();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_HDBH)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Algerian", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(284, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(411, 30);
            this.label1.TabIndex = 49;
            this.label1.Text = "TÌM KIẾM HOÁ ĐƠN BÁN HÀNG";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightCoral;
            this.panel1.Location = new System.Drawing.Point(134, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(718, 3);
            this.panel1.TabIndex = 48;
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
            this.pic1.Location = new System.Drawing.Point(16, 16);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(109, 109);
            this.pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic1.TabIndex = 47;
            this.pic1.TabStop = false;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Tomato;
            this.btnXoa.BackgroundColor = System.Drawing.Color.Tomato;
            this.btnXoa.BorderColor = System.Drawing.SystemColors.WindowText;
            this.btnXoa.BorderRadius = 20;
            this.btnXoa.BorderSize = 3;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.Black;
            this.btnXoa.Location = new System.Drawing.Point(735, 408);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(128, 40);
            this.btnXoa.TabIndex = 60;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextColor = System.Drawing.Color.Black;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnChiTiet
            // 
            this.btnChiTiet.BackColor = System.Drawing.Color.Tomato;
            this.btnChiTiet.BackgroundColor = System.Drawing.Color.Tomato;
            this.btnChiTiet.BorderColor = System.Drawing.SystemColors.WindowText;
            this.btnChiTiet.BorderRadius = 20;
            this.btnChiTiet.BorderSize = 3;
            this.btnChiTiet.FlatAppearance.BorderSize = 0;
            this.btnChiTiet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChiTiet.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChiTiet.ForeColor = System.Drawing.Color.Black;
            this.btnChiTiet.Location = new System.Drawing.Point(735, 354);
            this.btnChiTiet.Name = "btnChiTiet";
            this.btnChiTiet.Size = new System.Drawing.Size(128, 40);
            this.btnChiTiet.TabIndex = 59;
            this.btnChiTiet.Text = "Chi tiết";
            this.btnChiTiet.TextColor = System.Drawing.Color.Black;
            this.btnChiTiet.UseVisualStyleBackColor = false;
            this.btnChiTiet.Click += new System.EventHandler(this.btnChiTiet_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Firebrick;
            this.panel2.Location = new System.Drawing.Point(105, 507);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(757, 4);
            this.panel2.TabIndex = 58;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Tomato;
            this.btnReset.BackgroundColor = System.Drawing.Color.Tomato;
            this.btnReset.BorderColor = System.Drawing.SystemColors.WindowText;
            this.btnReset.BorderRadius = 20;
            this.btnReset.BorderSize = 3;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.Black;
            this.btnReset.Location = new System.Drawing.Point(735, 298);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(128, 40);
            this.btnReset.TabIndex = 57;
            this.btnReset.Text = "Reset";
            this.btnReset.TextColor = System.Drawing.Color.Black;
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.Tomato;
            this.btnTimKiem.BackgroundColor = System.Drawing.Color.Tomato;
            this.btnTimKiem.BorderColor = System.Drawing.SystemColors.WindowText;
            this.btnTimKiem.BorderRadius = 20;
            this.btnTimKiem.BorderSize = 3;
            this.btnTimKiem.FlatAppearance.BorderSize = 0;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.ForeColor = System.Drawing.Color.Black;
            this.btnTimKiem.Location = new System.Drawing.Point(735, 244);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(127, 40);
            this.btnTimKiem.TabIndex = 56;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.TextColor = System.Drawing.Color.Black;
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // GridView_HDBH
            // 
            this.GridView_HDBH.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GridView_HDBH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView_HDBH.Location = new System.Drawing.Point(105, 223);
            this.GridView_HDBH.Name = "GridView_HDBH";
            this.GridView_HDBH.Size = new System.Drawing.Size(599, 262);
            this.GridView_HDBH.TabIndex = 55;
            // 
            // optMahdban
            // 
            this.optMahdban.AutoSize = true;
            this.optMahdban.CheckedColor = System.Drawing.Color.IndianRed;
            this.optMahdban.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optMahdban.ForeColor = System.Drawing.Color.IndianRed;
            this.optMahdban.Location = new System.Drawing.Point(134, 113);
            this.optMahdban.MinimumSize = new System.Drawing.Size(0, 21);
            this.optMahdban.Name = "optMahdban";
            this.optMahdban.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.optMahdban.Size = new System.Drawing.Size(157, 22);
            this.optMahdban.TabIndex = 62;
            this.optMahdban.TabStop = true;
            this.optMahdban.Text = "Mã hoá đơn bán";
            this.optMahdban.UnCheckedColor = System.Drawing.Color.Gray;
            this.optMahdban.UseVisualStyleBackColor = true;
            this.optMahdban.CheckedChanged += new System.EventHandler(this.optMahdban_CheckedChanged);
            // 
            // txtMahdban
            // 
            this.txtMahdban.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtMahdban.BorderColor = System.Drawing.Color.Salmon;
            this.txtMahdban.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtMahdban.BorderRadius = 7;
            this.txtMahdban.BorderSize = 2;
            this.txtMahdban.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMahdban.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMahdban.Location = new System.Drawing.Point(134, 146);
            this.txtMahdban.Margin = new System.Windows.Forms.Padding(4);
            this.txtMahdban.Multiline = false;
            this.txtMahdban.Name = "txtMahdban";
            this.txtMahdban.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtMahdban.PasswordChar = false;
            this.txtMahdban.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtMahdban.PlaceholderText = "";
            this.txtMahdban.Size = new System.Drawing.Size(173, 31);
            this.txtMahdban.TabIndex = 61;
            this.txtMahdban.Texts = "";
            this.txtMahdban.UnderlinedStyle = false;
            // 
            // dateNgayban
            // 
            this.dateNgayban.BorderColor = System.Drawing.Color.MintCream;
            this.dateNgayban.BorderSize = 2;
            this.dateNgayban.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.dateNgayban.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateNgayban.Location = new System.Drawing.Point(410, 116);
            this.dateNgayban.MinimumSize = new System.Drawing.Size(4, 35);
            this.dateNgayban.Name = "dateNgayban";
            this.dateNgayban.Size = new System.Drawing.Size(187, 35);
            this.dateNgayban.SkinColor = System.Drawing.Color.MediumAquamarine;
            this.dateNgayban.TabIndex = 64;
            this.dateNgayban.TextColor = System.Drawing.Color.White;
            // 
            // optNgayban
            // 
            this.optNgayban.AutoSize = true;
            this.optNgayban.CheckedColor = System.Drawing.Color.MediumAquamarine;
            this.optNgayban.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optNgayban.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.optNgayban.Location = new System.Drawing.Point(434, 87);
            this.optNgayban.MinimumSize = new System.Drawing.Size(0, 21);
            this.optNgayban.Name = "optNgayban";
            this.optNgayban.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.optNgayban.Size = new System.Drawing.Size(106, 22);
            this.optNgayban.TabIndex = 63;
            this.optNgayban.TabStop = true;
            this.optNgayban.Text = "Ngày bán";
            this.optNgayban.UnCheckedColor = System.Drawing.Color.Gray;
            this.optNgayban.UseVisualStyleBackColor = true;
            this.optNgayban.CheckedChanged += new System.EventHandler(this.optNgayNhap_CheckedChanged);
            // 
            // cbbManv
            // 
            this.cbbManv.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbbManv.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cbbManv.BorderSize = 2;
            this.cbbManv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbbManv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbbManv.ForeColor = System.Drawing.Color.DimGray;
            this.cbbManv.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cbbManv.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbbManv.ListTextColor = System.Drawing.Color.DimGray;
            this.cbbManv.Location = new System.Drawing.Point(627, 123);
            this.cbbManv.MinimumSize = new System.Drawing.Size(150, 30);
            this.cbbManv.Name = "cbbManv";
            this.cbbManv.Padding = new System.Windows.Forms.Padding(2);
            this.cbbManv.Size = new System.Drawing.Size(180, 30);
            this.cbbManv.TabIndex = 66;
            this.cbbManv.Texts = "";
            this.cbbManv.OnSelectedIndexChanged += new System.EventHandler(this.cbbManv_OnSelectedIndexChanged);
            // 
            // optManv
            // 
            this.optManv.AutoSize = true;
            this.optManv.CheckedColor = System.Drawing.Color.MediumSlateBlue;
            this.optManv.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optManv.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.optManv.Location = new System.Drawing.Point(641, 89);
            this.optManv.MinimumSize = new System.Drawing.Size(0, 21);
            this.optManv.Name = "optManv";
            this.optManv.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.optManv.Size = new System.Drawing.Size(135, 22);
            this.optManv.TabIndex = 65;
            this.optManv.TabStop = true;
            this.optManv.Text = "Mã nhân viên";
            this.optManv.UnCheckedColor = System.Drawing.Color.Gray;
            this.optManv.UseVisualStyleBackColor = true;
            this.optManv.CheckedChanged += new System.EventHandler(this.optManv_CheckedChanged);
            // 
            // txtTennv
            // 
            this.txtTennv.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtTennv.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtTennv.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtTennv.BorderRadius = 0;
            this.txtTennv.BorderSize = 2;
            this.txtTennv.Enabled = false;
            this.txtTennv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTennv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTennv.Location = new System.Drawing.Point(608, 160);
            this.txtTennv.Margin = new System.Windows.Forms.Padding(4);
            this.txtTennv.Multiline = false;
            this.txtTennv.Name = "txtTennv";
            this.txtTennv.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtTennv.PasswordChar = false;
            this.txtTennv.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTennv.PlaceholderText = "";
            this.txtTennv.Size = new System.Drawing.Size(230, 32);
            this.txtTennv.TabIndex = 67;
            this.txtTennv.Texts = "";
            this.txtTennv.UnderlinedStyle = false;
            // 
            // lblDenNgay
            // 
            this.lblDenNgay.AutoSize = true;
            this.lblDenNgay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDenNgay.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDenNgay.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.lblDenNgay.Location = new System.Drawing.Point(321, 164);
            this.lblDenNgay.Name = "lblDenNgay";
            this.lblDenNgay.Size = new System.Drawing.Size(89, 18);
            this.lblDenNgay.TabIndex = 69;
            this.lblDenNgay.Text = "Đến ngày:";
            // 
            // dateNgayBan2
            // 
            this.dateNgayBan2.BorderColor = System.Drawing.Color.MintCream;
            this.dateNgayBan2.BorderSize = 2;
            this.dateNgayBan2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.dateNgayBan2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateNgayBan2.Location = new System.Drawing.Point(410, 156);
            this.dateNgayBan2.MinimumSize = new System.Drawing.Size(4, 35);
            this.dateNgayBan2.Name = "dateNgayBan2";
            this.dateNgayBan2.Size = new System.Drawing.Size(187, 35);
            this.dateNgayBan2.SkinColor = System.Drawing.Color.MediumAquamarine;
            this.dateNgayBan2.TabIndex = 68;
            this.dateNgayBan2.TextColor = System.Drawing.Color.White;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.label2.Location = new System.Drawing.Point(321, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 18);
            this.label2.TabIndex = 70;
            this.label2.Text = "Từ ngày:";
            // 
            // FrmTimKiemHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 528);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblDenNgay);
            this.Controls.Add(this.dateNgayBan2);
            this.Controls.Add(this.txtTennv);
            this.Controls.Add(this.cbbManv);
            this.Controls.Add(this.optManv);
            this.Controls.Add(this.dateNgayban);
            this.Controls.Add(this.optNgayban);
            this.Controls.Add(this.optMahdban);
            this.Controls.Add(this.txtMahdban);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnChiTiet);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.GridView_HDBH);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pic1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmTimKiemHoaDon";
            this.Text = "FrmTimKiemHoaDon";
            this.Load += new System.EventHandler(this.FrmTimKiemHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_HDBH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private CustomControls.RJControls.RJCircularPictureBox pic1;
        private CustomControls.RJControls.RJButton btnXoa;
        private CustomControls.RJControls.RJButton btnChiTiet;
        private System.Windows.Forms.Panel panel2;
        private CustomControls.RJControls.RJButton btnReset;
        private CustomControls.RJControls.RJButton btnTimKiem;
        private System.Windows.Forms.DataGridView GridView_HDBH;
        private CustomControls.RJControls.RJRadioButton optMahdban;
        private CustomControls.RJControls.RJTextBox txtMahdban;
        private CustomControls.RJControls.RJDatePicker dateNgayban;
        private CustomControls.RJControls.RJRadioButton optNgayban;
        private CustomControls.RJControls.RJComboBox cbbManv;
        private CustomControls.RJControls.RJRadioButton optManv;
        private CustomControls.RJControls.RJTextBox txtTennv;
        private System.Windows.Forms.Label lblDenNgay;
        private CustomControls.RJControls.RJDatePicker dateNgayBan2;
        private System.Windows.Forms.Label label2;
    }
}