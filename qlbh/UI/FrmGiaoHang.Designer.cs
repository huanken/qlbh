
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
            this.cbb_mnv = new CustomControls.RJControls.RJComboBox();
            this.cbb_mactdb = new CustomControls.RJControls.RJComboBox();
            this.rjCircularPictureBox1 = new CustomControls.RJControls.RJCircularPictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_GiaoHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.OrangeRed;
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
            this.GridView_GiaoHang.Location = new System.Drawing.Point(402, 132);
            this.GridView_GiaoHang.Name = "GridView_GiaoHang";
            this.GridView_GiaoHang.Size = new System.Drawing.Size(476, 239);
            this.GridView_GiaoHang.TabIndex = 1;
            this.GridView_GiaoHang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridView_GiaoHang_CellContentClick);
            // 
            // btn_TaoMoi
            // 
            this.btn_TaoMoi.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_TaoMoi.BackgroundColor = System.Drawing.Color.DarkOrange;
            this.btn_TaoMoi.BorderColor = System.Drawing.Color.Black;
            this.btn_TaoMoi.BorderRadius = 15;
            this.btn_TaoMoi.BorderSize = 2;
            this.btn_TaoMoi.FlatAppearance.BorderSize = 0;
            this.btn_TaoMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TaoMoi.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TaoMoi.ForeColor = System.Drawing.Color.Black;
            this.btn_TaoMoi.Location = new System.Drawing.Point(215, 397);
            this.btn_TaoMoi.Name = "btn_TaoMoi";
            this.btn_TaoMoi.Size = new System.Drawing.Size(100, 35);
            this.btn_TaoMoi.TabIndex = 2;
            this.btn_TaoMoi.Text = "Tạo mới";
            this.btn_TaoMoi.TextColor = System.Drawing.Color.Black;
            this.btn_TaoMoi.UseVisualStyleBackColor = false;
            this.btn_TaoMoi.Click += new System.EventHandler(this.btn_TaoMoi_Click);
            // 
            // txt_mavd
            // 
            this.txt_mavd.BackColor = System.Drawing.SystemColors.Window;
            this.txt_mavd.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.txt_mavd.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_mavd.BorderRadius = 7;
            this.txt_mavd.BorderSize = 2;
            this.txt_mavd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_mavd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mavd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_mavd.Location = new System.Drawing.Point(193, 132);
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
            this.label2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(84, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mã Vận Đơn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(84, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Thời gian:";
            // 
            // btn_Luu
            // 
            this.btn_Luu.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_Luu.BackgroundColor = System.Drawing.Color.DarkOrange;
            this.btn_Luu.BorderColor = System.Drawing.Color.Black;
            this.btn_Luu.BorderRadius = 15;
            this.btn_Luu.BorderSize = 2;
            this.btn_Luu.FlatAppearance.BorderSize = 0;
            this.btn_Luu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Luu.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Luu.ForeColor = System.Drawing.Color.Black;
            this.btn_Luu.Location = new System.Drawing.Point(345, 397);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(100, 35);
            this.btn_Luu.TabIndex = 7;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.TextColor = System.Drawing.Color.Black;
            this.btn_Luu.UseVisualStyleBackColor = false;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_sua.BackgroundColor = System.Drawing.Color.DarkOrange;
            this.btn_sua.BorderColor = System.Drawing.Color.Black;
            this.btn_sua.BorderRadius = 15;
            this.btn_sua.BorderSize = 2;
            this.btn_sua.FlatAppearance.BorderSize = 0;
            this.btn_sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sua.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua.ForeColor = System.Drawing.Color.Black;
            this.btn_sua.Location = new System.Drawing.Point(479, 397);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(100, 35);
            this.btn_sua.TabIndex = 8;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.TextColor = System.Drawing.Color.Black;
            this.btn_sua.UseVisualStyleBackColor = false;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_xoa.BackgroundColor = System.Drawing.Color.DarkOrange;
            this.btn_xoa.BorderColor = System.Drawing.Color.Black;
            this.btn_xoa.BorderRadius = 15;
            this.btn_xoa.BorderSize = 2;
            this.btn_xoa.FlatAppearance.BorderSize = 0;
            this.btn_xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_xoa.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.ForeColor = System.Drawing.Color.Black;
            this.btn_xoa.Location = new System.Drawing.Point(602, 397);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(100, 35);
            this.btn_xoa.TabIndex = 9;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.TextColor = System.Drawing.Color.Black;
            this.btn_xoa.UseVisualStyleBackColor = false;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(84, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 18);
            this.label4.TabIndex = 13;
            this.label4.Text = "SĐT_KH";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(85, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 18);
            this.label5.TabIndex = 12;
            this.label5.Text = "Địa Chỉ ";
            // 
            // txt_dc
            // 
            this.txt_dc.BackColor = System.Drawing.SystemColors.Window;
            this.txt_dc.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.txt_dc.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_dc.BorderRadius = 7;
            this.txt_dc.BorderSize = 2;
            this.txt_dc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_dc.Location = new System.Drawing.Point(193, 212);
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
            this.txt_sđtkh.BorderSize = 2;
            this.txt_sđtkh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sđtkh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_sđtkh.Location = new System.Drawing.Point(193, 259);
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
            this.label1.Font = new System.Drawing.Font("Algerian", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(397, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Giao Hàng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(84, 309);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 18);
            this.label6.TabIndex = 13;
            this.label6.Text = "Mã_NV";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(84, 355);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 18);
            this.label7.TabIndex = 13;
            this.label7.Text = "Mã_CTĐB";
            // 
            // dp_Time
            // 
            this.dp_Time.BorderColor = System.Drawing.Color.MintCream;
            this.dp_Time.BorderSize = 2;
            this.dp_Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.dp_Time.Location = new System.Drawing.Point(193, 170);
            this.dp_Time.MinimumSize = new System.Drawing.Size(4, 35);
            this.dp_Time.Name = "dp_Time";
            this.dp_Time.Size = new System.Drawing.Size(200, 35);
            this.dp_Time.SkinColor = System.Drawing.Color.MediumAquamarine;
            this.dp_Time.TabIndex = 18;
            this.dp_Time.TextColor = System.Drawing.Color.White;
            // 
            // cbb_mnv
            // 
            this.cbb_mnv.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbb_mnv.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.cbb_mnv.BorderSize = 2;
            this.cbb_mnv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbb_mnv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbb_mnv.ForeColor = System.Drawing.Color.DimGray;
            this.cbb_mnv.IconColor = System.Drawing.Color.MediumSeaGreen;
            this.cbb_mnv.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbb_mnv.ListTextColor = System.Drawing.Color.DimGray;
            this.cbb_mnv.Location = new System.Drawing.Point(193, 297);
            this.cbb_mnv.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbb_mnv.Name = "cbb_mnv";
            this.cbb_mnv.Padding = new System.Windows.Forms.Padding(2);
            this.cbb_mnv.Size = new System.Drawing.Size(200, 30);
            this.cbb_mnv.TabIndex = 19;
            this.cbb_mnv.Texts = "";
            // 
            // cbb_mactdb
            // 
            this.cbb_mactdb.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbb_mactdb.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.cbb_mactdb.BorderSize = 2;
            this.cbb_mactdb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbb_mactdb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbb_mactdb.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.cbb_mactdb.IconColor = System.Drawing.Color.MediumSeaGreen;
            this.cbb_mactdb.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbb_mactdb.ListTextColor = System.Drawing.Color.DimGray;
            this.cbb_mactdb.Location = new System.Drawing.Point(193, 343);
            this.cbb_mactdb.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbb_mactdb.Name = "cbb_mactdb";
            this.cbb_mactdb.Padding = new System.Windows.Forms.Padding(2);
            this.cbb_mactdb.Size = new System.Drawing.Size(200, 30);
            this.cbb_mactdb.TabIndex = 20;
            this.cbb_mactdb.Texts = "";
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
            // FrmGiaoHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(890, 530);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.rjCircularPictureBox1);
            this.Controls.Add(this.cbb_mactdb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbb_mnv);
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
        private CustomControls.RJControls.RJComboBox cbb_mnv;
        private CustomControls.RJControls.RJComboBox cbb_mactdb;
        private CustomControls.RJControls.RJCircularPictureBox rjCircularPictureBox1;
        private System.Windows.Forms.Panel panel2;
    }
}