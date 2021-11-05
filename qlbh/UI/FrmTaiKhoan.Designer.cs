
namespace qlbh.UI
{
    partial class FrmTaiKhoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTaiKhoan));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLuu = new CustomControls.RJControls.RJButton();
            this.btnThemmoi = new CustomControls.RJControls.RJButton();
            this.label6 = new System.Windows.Forms.Label();
            this.rjCircularPictureBox1 = new CustomControls.RJControls.RJCircularPictureBox();
            this.btnXoa = new CustomControls.RJControls.RJButton();
            this.btnSua = new CustomControls.RJControls.RJButton();
            this.txtQuyen = new CustomControls.RJControls.RJTextBox();
            this.txtMatKhau = new CustomControls.RJControls.RJTextBox();
            this.txtTaiKhoan = new CustomControls.RJControls.RJTextBox();
            this.dataGridView_TaiKhoan = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_TaiKhoan)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Salmon;
            this.panel2.Location = new System.Drawing.Point(97, 541);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(803, 3);
            this.panel2.TabIndex = 17;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Salmon;
            this.panel1.Location = new System.Drawing.Point(161, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(737, 3);
            this.panel1.TabIndex = 18;
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.Tomato;
            this.btnLuu.BackgroundColor = System.Drawing.Color.Tomato;
            this.btnLuu.BorderColor = System.Drawing.Color.Black;
            this.btnLuu.BorderRadius = 20;
            this.btnLuu.BorderSize = 1;
            this.btnLuu.FlatAppearance.BorderSize = 0;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLuu.Location = new System.Drawing.Point(344, 415);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(102, 40);
            this.btnLuu.TabIndex = 15;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextColor = System.Drawing.SystemColors.Control;
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThemmoi
            // 
            this.btnThemmoi.BackColor = System.Drawing.Color.Tomato;
            this.btnThemmoi.BackgroundColor = System.Drawing.Color.Tomato;
            this.btnThemmoi.BorderColor = System.Drawing.Color.Black;
            this.btnThemmoi.BorderRadius = 20;
            this.btnThemmoi.BorderSize = 1;
            this.btnThemmoi.FlatAppearance.BorderSize = 0;
            this.btnThemmoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemmoi.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemmoi.ForeColor = System.Drawing.SystemColors.Control;
            this.btnThemmoi.Location = new System.Drawing.Point(172, 415);
            this.btnThemmoi.Name = "btnThemmoi";
            this.btnThemmoi.Size = new System.Drawing.Size(114, 40);
            this.btnThemmoi.TabIndex = 16;
            this.btnThemmoi.Text = "Thêm mới";
            this.btnThemmoi.TextColor = System.Drawing.SystemColors.Control;
            this.btnThemmoi.UseVisualStyleBackColor = false;
            this.btnThemmoi.Click += new System.EventHandler(this.btnThemmoi_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.IndianRed;
            this.label6.Location = new System.Drawing.Point(373, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(258, 31);
            this.label6.TabIndex = 14;
            this.label6.Text = "Quản lý tài khoản";
            // 
            // rjCircularPictureBox1
            // 
            this.rjCircularPictureBox1.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Triangle;
            this.rjCircularPictureBox1.BorderColor = System.Drawing.Color.RoyalBlue;
            this.rjCircularPictureBox1.BorderColor2 = System.Drawing.Color.HotPink;
            this.rjCircularPictureBox1.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.rjCircularPictureBox1.BorderSize = 3;
            this.rjCircularPictureBox1.GradientAngle = 30F;
            this.rjCircularPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("rjCircularPictureBox1.Image")));
            this.rjCircularPictureBox1.Location = new System.Drawing.Point(28, 15);
            this.rjCircularPictureBox1.Name = "rjCircularPictureBox1";
            this.rjCircularPictureBox1.Size = new System.Drawing.Size(115, 115);
            this.rjCircularPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.rjCircularPictureBox1.TabIndex = 19;
            this.rjCircularPictureBox1.TabStop = false;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Tomato;
            this.btnXoa.BackgroundColor = System.Drawing.Color.Tomato;
            this.btnXoa.BorderColor = System.Drawing.Color.Black;
            this.btnXoa.BorderRadius = 20;
            this.btnXoa.BorderSize = 1;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.SystemColors.Control;
            this.btnXoa.Location = new System.Drawing.Point(676, 415);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(102, 40);
            this.btnXoa.TabIndex = 20;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextColor = System.Drawing.SystemColors.Control;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.Tomato;
            this.btnSua.BackgroundColor = System.Drawing.Color.Tomato;
            this.btnSua.BorderColor = System.Drawing.Color.Black;
            this.btnSua.BorderRadius = 20;
            this.btnSua.BorderSize = 1;
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSua.Location = new System.Drawing.Point(509, 415);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(102, 40);
            this.btnSua.TabIndex = 21;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextColor = System.Drawing.SystemColors.Control;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // txtQuyen
            // 
            this.txtQuyen.BackColor = System.Drawing.SystemColors.Window;
            this.txtQuyen.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.txtQuyen.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtQuyen.BorderRadius = 10;
            this.txtQuyen.BorderSize = 1;
            this.txtQuyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuyen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtQuyen.Location = new System.Drawing.Point(180, 285);
            this.txtQuyen.Margin = new System.Windows.Forms.Padding(4);
            this.txtQuyen.Multiline = false;
            this.txtQuyen.Name = "txtQuyen";
            this.txtQuyen.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtQuyen.PasswordChar = false;
            this.txtQuyen.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtQuyen.PlaceholderText = "";
            this.txtQuyen.Size = new System.Drawing.Size(227, 31);
            this.txtQuyen.TabIndex = 28;
            this.txtQuyen.Texts = "";
            this.txtQuyen.UnderlinedStyle = false;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.BackColor = System.Drawing.SystemColors.Window;
            this.txtMatKhau.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.txtMatKhau.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtMatKhau.BorderRadius = 10;
            this.txtMatKhau.BorderSize = 1;
            this.txtMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMatKhau.Location = new System.Drawing.Point(179, 248);
            this.txtMatKhau.Margin = new System.Windows.Forms.Padding(4);
            this.txtMatKhau.Multiline = false;
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtMatKhau.PasswordChar = false;
            this.txtMatKhau.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtMatKhau.PlaceholderText = "";
            this.txtMatKhau.Size = new System.Drawing.Size(227, 31);
            this.txtMatKhau.TabIndex = 29;
            this.txtMatKhau.Texts = "";
            this.txtMatKhau.UnderlinedStyle = false;
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.BackColor = System.Drawing.SystemColors.Window;
            this.txtTaiKhoan.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.txtTaiKhoan.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtTaiKhoan.BorderRadius = 10;
            this.txtTaiKhoan.BorderSize = 1;
            this.txtTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaiKhoan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTaiKhoan.Location = new System.Drawing.Point(180, 208);
            this.txtTaiKhoan.Margin = new System.Windows.Forms.Padding(4);
            this.txtTaiKhoan.Multiline = false;
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtTaiKhoan.PasswordChar = false;
            this.txtTaiKhoan.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTaiKhoan.PlaceholderText = "";
            this.txtTaiKhoan.Size = new System.Drawing.Size(227, 31);
            this.txtTaiKhoan.TabIndex = 30;
            this.txtTaiKhoan.Texts = "";
            this.txtTaiKhoan.UnderlinedStyle = false;
            // 
            // dataGridView_TaiKhoan
            // 
            this.dataGridView_TaiKhoan.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_TaiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_TaiKhoan.Location = new System.Drawing.Point(459, 151);
            this.dataGridView_TaiKhoan.Name = "dataGridView_TaiKhoan";
            this.dataGridView_TaiKhoan.Size = new System.Drawing.Size(372, 215);
            this.dataGridView_TaiKhoan.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.IndianRed;
            this.label4.Location = new System.Drawing.Point(45, 294);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 18);
            this.label4.TabIndex = 23;
            this.label4.Text = "Quyền truy cập:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.IndianRed;
            this.label3.Location = new System.Drawing.Point(43, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 18);
            this.label3.TabIndex = 24;
            this.label3.Text = "Mật khẩu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.IndianRed;
            this.label2.Location = new System.Drawing.Point(47, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 18);
            this.label2.TabIndex = 25;
            this.label2.Text = "Tài khoản:";
            // 
            // FrmTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(937, 558);
            this.ControlBox = false;
            this.Controls.Add(this.txtQuyen);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.txtTaiKhoan);
            this.Controls.Add(this.dataGridView_TaiKhoan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.rjCircularPictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnThemmoi);
            this.Controls.Add(this.label6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmTaiKhoan";
            this.Text = "FrmTaiKhoan";
            this.Load += new System.EventHandler(this.FrmTaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_TaiKhoan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.RJControls.RJCircularPictureBox rjCircularPictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private CustomControls.RJControls.RJButton btnLuu;
        private CustomControls.RJControls.RJButton btnThemmoi;
        private System.Windows.Forms.Label label6;
        private CustomControls.RJControls.RJButton btnXoa;
        private CustomControls.RJControls.RJButton btnSua;
        private CustomControls.RJControls.RJTextBox txtQuyen;
        private CustomControls.RJControls.RJTextBox txtMatKhau;
        private CustomControls.RJControls.RJTextBox txtTaiKhoan;
        private System.Windows.Forms.DataGridView dataGridView_TaiKhoan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}