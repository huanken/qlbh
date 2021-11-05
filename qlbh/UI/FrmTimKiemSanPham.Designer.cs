
namespace qlbh.UI
{
    partial class FrmTimKiemSanPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTimKiemSanPham));
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pic1 = new CustomControls.RJControls.RJCircularPictureBox();
            this.btnReset = new CustomControls.RJControls.RJButton();
            this.btnTimKiem = new CustomControls.RJControls.RJButton();
            this.txtTimKiem = new CustomControls.RJControls.RJTextBox();
            this.GridView_SP = new System.Windows.Forms.DataGridView();
            this.optMaSP = new CustomControls.RJControls.RJRadioButton();
            this.picSP = new System.Windows.Forms.PictureBox();
            this.optTenSP = new CustomControls.RJControls.RJRadioButton();
            this.optDanhMuc = new CustomControls.RJControls.RJRadioButton();
            this.cbbTimKiem = new CustomControls.RJControls.RJComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_SP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSP)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(324, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 31);
            this.label1.TabIndex = 32;
            this.label1.Text = "Tìm Kiếm Sản Phẩm";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Firebrick;
            this.panel2.Location = new System.Drawing.Point(94, 500);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(757, 3);
            this.panel2.TabIndex = 31;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightCoral;
            this.panel1.Location = new System.Drawing.Point(149, 79);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(718, 3);
            this.panel1.TabIndex = 30;
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
            this.pic1.Location = new System.Drawing.Point(25, 30);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(118, 118);
            this.pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic1.TabIndex = 29;
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
            this.btnReset.Location = new System.Drawing.Point(683, 432);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(128, 44);
            this.btnReset.TabIndex = 28;
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
            this.btnTimKiem.Location = new System.Drawing.Point(478, 432);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(127, 44);
            this.btnTimKiem.TabIndex = 27;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.TextColor = System.Drawing.Color.White;
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtTimKiem.BorderColor = System.Drawing.Color.Salmon;
            this.txtTimKiem.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtTimKiem.BorderRadius = 7;
            this.txtTimKiem.BorderSize = 1;
            this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTimKiem.Location = new System.Drawing.Point(13, 249);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.txtTimKiem.Multiline = false;
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtTimKiem.PasswordChar = false;
            this.txtTimKiem.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTimKiem.PlaceholderText = "";
            this.txtTimKiem.Size = new System.Drawing.Size(173, 31);
            this.txtTimKiem.TabIndex = 19;
            this.txtTimKiem.Texts = "";
            this.txtTimKiem.UnderlinedStyle = false;
            // 
            // GridView_SP
            // 
            this.GridView_SP.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GridView_SP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView_SP.Location = new System.Drawing.Point(389, 101);
            this.GridView_SP.Name = "GridView_SP";
            this.GridView_SP.Size = new System.Drawing.Size(496, 311);
            this.GridView_SP.TabIndex = 12;
            // 
            // optMaSP
            // 
            this.optMaSP.AutoSize = true;
            this.optMaSP.CheckedColor = System.Drawing.Color.IndianRed;
            this.optMaSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optMaSP.ForeColor = System.Drawing.Color.IndianRed;
            this.optMaSP.Location = new System.Drawing.Point(22, 169);
            this.optMaSP.MinimumSize = new System.Drawing.Size(0, 21);
            this.optMaSP.Name = "optMaSP";
            this.optMaSP.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.optMaSP.Size = new System.Drawing.Size(137, 22);
            this.optMaSP.TabIndex = 33;
            this.optMaSP.TabStop = true;
            this.optMaSP.Text = "Mã sản phẩm";
            this.optMaSP.UnCheckedColor = System.Drawing.Color.Gray;
            this.optMaSP.UseVisualStyleBackColor = true;
            this.optMaSP.CheckedChanged += new System.EventHandler(this.optMaSP_CheckedChanged);
            // 
            // picSP
            // 
            this.picSP.Location = new System.Drawing.Point(67, 302);
            this.picSP.Name = "picSP";
            this.picSP.Size = new System.Drawing.Size(254, 145);
            this.picSP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picSP.TabIndex = 34;
            this.picSP.TabStop = false;
            // 
            // optTenSP
            // 
            this.optTenSP.AutoSize = true;
            this.optTenSP.CheckedColor = System.Drawing.Color.IndianRed;
            this.optTenSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optTenSP.ForeColor = System.Drawing.Color.IndianRed;
            this.optTenSP.Location = new System.Drawing.Point(22, 209);
            this.optTenSP.MinimumSize = new System.Drawing.Size(0, 21);
            this.optTenSP.Name = "optTenSP";
            this.optTenSP.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.optTenSP.Size = new System.Drawing.Size(142, 22);
            this.optTenSP.TabIndex = 35;
            this.optTenSP.TabStop = true;
            this.optTenSP.Text = "Tên sản phẩm";
            this.optTenSP.UnCheckedColor = System.Drawing.Color.Gray;
            this.optTenSP.UseVisualStyleBackColor = true;
            this.optTenSP.CheckedChanged += new System.EventHandler(this.optTenSP_CheckedChanged);
            // 
            // optDanhMuc
            // 
            this.optDanhMuc.AutoSize = true;
            this.optDanhMuc.CheckedColor = System.Drawing.Color.MediumSlateBlue;
            this.optDanhMuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optDanhMuc.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.optDanhMuc.Location = new System.Drawing.Point(193, 209);
            this.optDanhMuc.MinimumSize = new System.Drawing.Size(0, 21);
            this.optDanhMuc.Name = "optDanhMuc";
            this.optDanhMuc.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.optDanhMuc.Size = new System.Drawing.Size(190, 22);
            this.optDanhMuc.TabIndex = 37;
            this.optDanhMuc.TabStop = true;
            this.optDanhMuc.Text = "Danh mục sản phẩm";
            this.optDanhMuc.UnCheckedColor = System.Drawing.Color.Gray;
            this.optDanhMuc.UseVisualStyleBackColor = true;
            this.optDanhMuc.CheckedChanged += new System.EventHandler(this.optDanhMuc_CheckedChanged);
            // 
            // cbbTimKiem
            // 
            this.cbbTimKiem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbbTimKiem.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cbbTimKiem.BorderSize = 2;
            this.cbbTimKiem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbbTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbbTimKiem.ForeColor = System.Drawing.Color.DimGray;
            this.cbbTimKiem.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cbbTimKiem.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbbTimKiem.ListTextColor = System.Drawing.Color.DimGray;
            this.cbbTimKiem.Location = new System.Drawing.Point(193, 249);
            this.cbbTimKiem.MinimumSize = new System.Drawing.Size(150, 30);
            this.cbbTimKiem.Name = "cbbTimKiem";
            this.cbbTimKiem.Padding = new System.Windows.Forms.Padding(2);
            this.cbbTimKiem.Size = new System.Drawing.Size(180, 30);
            this.cbbTimKiem.TabIndex = 38;
            this.cbbTimKiem.Texts = "";
            // 
            // FrmTimKiemSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(906, 548);
            this.ControlBox = false;
            this.Controls.Add(this.cbbTimKiem);
            this.Controls.Add(this.optDanhMuc);
            this.Controls.Add(this.optTenSP);
            this.Controls.Add(this.picSP);
            this.Controls.Add(this.optMaSP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pic1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.GridView_SP);
            this.ForeColor = System.Drawing.Color.IndianRed;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmTimKiemSanPham";
            this.Text = "FrmTimKiemSanPham";
            this.Load += new System.EventHandler(this.FrmTimKiemSanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_SP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private CustomControls.RJControls.RJCircularPictureBox pic1;
        private CustomControls.RJControls.RJButton btnReset;
        private CustomControls.RJControls.RJButton btnTimKiem;
        private CustomControls.RJControls.RJTextBox txtTimKiem;
        private System.Windows.Forms.DataGridView GridView_SP;
        private CustomControls.RJControls.RJRadioButton optMaSP;
        private System.Windows.Forms.PictureBox picSP;
        private CustomControls.RJControls.RJRadioButton optTenSP;
        private CustomControls.RJControls.RJRadioButton optDanhMuc;
        private CustomControls.RJControls.RJComboBox cbbTimKiem;
    }
}