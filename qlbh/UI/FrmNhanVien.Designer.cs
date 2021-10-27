
namespace qlbh.UI
{
    partial class FrmNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNhanVien));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rjTextBox1 = new CustomControls.RJControls.RJTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.GridView_NV = new System.Windows.Forms.DataGridView();
            this.lbl_MNV = new System.Windows.Forms.Label();
            this.lbl_TênNV = new System.Windows.Forms.Label();
            this.lbl_address = new System.Windows.Forms.Label();
            this.lbl_SĐT = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.txt_MNV = new CustomControls.RJControls.RJTextBox();
            this.txt_TenNV = new CustomControls.RJControls.RJTextBox();
            this.txt_SĐT = new CustomControls.RJControls.RJTextBox();
            this.txt_ĐChi = new CustomControls.RJControls.RJTextBox();
            this.txt_Email = new CustomControls.RJControls.RJTextBox();
            this.btn_Add = new CustomControls.RJControls.RJButton();
            this.btn_Save = new CustomControls.RJControls.RJButton();
            this.btn_Sua = new CustomControls.RJControls.RJButton();
            this.btn_Xoa = new CustomControls.RJControls.RJButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_giơitinh = new CustomControls.RJControls.RJTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_NV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Salmon;
            this.panel2.Location = new System.Drawing.Point(305, 33);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(74, 437);
            this.panel2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.rjTextBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(306, 619);
            this.panel1.TabIndex = 0;
            // 
            // rjTextBox1
            // 
            this.rjTextBox1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.rjTextBox1.BorderColor = System.Drawing.Color.GhostWhite;
            this.rjTextBox1.BorderFocusColor = System.Drawing.Color.GhostWhite;
            this.rjTextBox1.BorderRadius = 0;
            this.rjTextBox1.BorderSize = 2;
            this.rjTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBox1.ForeColor = System.Drawing.Color.Silver;
            this.rjTextBox1.Location = new System.Drawing.Point(19, 439);
            this.rjTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.rjTextBox1.Multiline = false;
            this.rjTextBox1.Name = "rjTextBox1";
            this.rjTextBox1.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjTextBox1.PasswordChar = false;
            this.rjTextBox1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTextBox1.PlaceholderText = "";
            this.rjTextBox1.Size = new System.Drawing.Size(91, 31);
            this.rjTextBox1.TabIndex = 4;
            this.rjTextBox1.Texts = "About Staff";
            this.rjTextBox1.UnderlinedStyle = false;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Salmon;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 389);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 35);
            this.label2.TabIndex = 2;
            this.label2.Text = "Food World Restaurant";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 389);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.BackColor = System.Drawing.Color.Transparent;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl.Location = new System.Drawing.Point(18, 350);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(151, 29);
            this.lbl.TabIndex = 0;
            this.lbl.Text = "NHÂN VIÊN";
            // 
            // GridView_NV
            // 
            this.GridView_NV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView_NV.Location = new System.Drawing.Point(421, 375);
            this.GridView_NV.Name = "GridView_NV";
            this.GridView_NV.Size = new System.Drawing.Size(539, 234);
            this.GridView_NV.TabIndex = 2;
            this.GridView_NV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridView_NV_CellContentClick);
            // 
            // lbl_MNV
            // 
            this.lbl_MNV.AutoSize = true;
            this.lbl_MNV.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MNV.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lbl_MNV.Location = new System.Drawing.Point(469, 55);
            this.lbl_MNV.Name = "lbl_MNV";
            this.lbl_MNV.Size = new System.Drawing.Size(116, 18);
            this.lbl_MNV.TabIndex = 3;
            this.lbl_MNV.Text = "Mã Nhân Viên";
            // 
            // lbl_TênNV
            // 
            this.lbl_TênNV.AutoSize = true;
            this.lbl_TênNV.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TênNV.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lbl_TênNV.Location = new System.Drawing.Point(470, 94);
            this.lbl_TênNV.Name = "lbl_TênNV";
            this.lbl_TênNV.Size = new System.Drawing.Size(121, 18);
            this.lbl_TênNV.TabIndex = 3;
            this.lbl_TênNV.Text = "Tên Nhân Viên";
            // 
            // lbl_address
            // 
            this.lbl_address.AutoSize = true;
            this.lbl_address.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_address.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lbl_address.Location = new System.Drawing.Point(470, 173);
            this.lbl_address.Name = "lbl_address";
            this.lbl_address.Size = new System.Drawing.Size(62, 18);
            this.lbl_address.TabIndex = 3;
            this.lbl_address.Text = "Địa Chỉ";
            // 
            // lbl_SĐT
            // 
            this.lbl_SĐT.AutoSize = true;
            this.lbl_SĐT.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SĐT.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lbl_SĐT.Location = new System.Drawing.Point(470, 134);
            this.lbl_SĐT.Name = "lbl_SĐT";
            this.lbl_SĐT.Size = new System.Drawing.Size(41, 18);
            this.lbl_SĐT.TabIndex = 3;
            this.lbl_SĐT.Text = "SĐT";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lbl_email.Location = new System.Drawing.Point(470, 212);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(53, 18);
            this.lbl_email.TabIndex = 3;
            this.lbl_email.Text = "Email";
            // 
            // txt_MNV
            // 
            this.txt_MNV.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_MNV.BorderColor = System.Drawing.Color.LightCoral;
            this.txt_MNV.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_MNV.BorderRadius = 0;
            this.txt_MNV.BorderSize = 2;
            this.txt_MNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MNV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_MNV.Location = new System.Drawing.Point(631, 46);
            this.txt_MNV.Margin = new System.Windows.Forms.Padding(4);
            this.txt_MNV.Multiline = false;
            this.txt_MNV.Name = "txt_MNV";
            this.txt_MNV.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_MNV.PasswordChar = false;
            this.txt_MNV.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_MNV.PlaceholderText = "";
            this.txt_MNV.Size = new System.Drawing.Size(250, 31);
            this.txt_MNV.TabIndex = 4;
            this.txt_MNV.Texts = "";
            this.txt_MNV.UnderlinedStyle = false;
            // 
            // txt_TenNV
            // 
            this.txt_TenNV.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_TenNV.BorderColor = System.Drawing.Color.LightCoral;
            this.txt_TenNV.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_TenNV.BorderRadius = 0;
            this.txt_TenNV.BorderSize = 2;
            this.txt_TenNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenNV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_TenNV.Location = new System.Drawing.Point(631, 85);
            this.txt_TenNV.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TenNV.Multiline = false;
            this.txt_TenNV.Name = "txt_TenNV";
            this.txt_TenNV.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_TenNV.PasswordChar = false;
            this.txt_TenNV.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_TenNV.PlaceholderText = "";
            this.txt_TenNV.Size = new System.Drawing.Size(250, 31);
            this.txt_TenNV.TabIndex = 4;
            this.txt_TenNV.Texts = "";
            this.txt_TenNV.UnderlinedStyle = false;
            // 
            // txt_SĐT
            // 
            this.txt_SĐT.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_SĐT.BorderColor = System.Drawing.Color.LightCoral;
            this.txt_SĐT.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_SĐT.BorderRadius = 0;
            this.txt_SĐT.BorderSize = 2;
            this.txt_SĐT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SĐT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_SĐT.Location = new System.Drawing.Point(631, 124);
            this.txt_SĐT.Margin = new System.Windows.Forms.Padding(4);
            this.txt_SĐT.Multiline = false;
            this.txt_SĐT.Name = "txt_SĐT";
            this.txt_SĐT.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_SĐT.PasswordChar = false;
            this.txt_SĐT.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_SĐT.PlaceholderText = "";
            this.txt_SĐT.Size = new System.Drawing.Size(250, 31);
            this.txt_SĐT.TabIndex = 4;
            this.txt_SĐT.Texts = "";
            this.txt_SĐT.UnderlinedStyle = false;
            // 
            // txt_ĐChi
            // 
            this.txt_ĐChi.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_ĐChi.BorderColor = System.Drawing.Color.LightCoral;
            this.txt_ĐChi.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_ĐChi.BorderRadius = 0;
            this.txt_ĐChi.BorderSize = 2;
            this.txt_ĐChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ĐChi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_ĐChi.Location = new System.Drawing.Point(631, 163);
            this.txt_ĐChi.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ĐChi.Multiline = false;
            this.txt_ĐChi.Name = "txt_ĐChi";
            this.txt_ĐChi.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_ĐChi.PasswordChar = false;
            this.txt_ĐChi.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_ĐChi.PlaceholderText = "";
            this.txt_ĐChi.Size = new System.Drawing.Size(250, 31);
            this.txt_ĐChi.TabIndex = 4;
            this.txt_ĐChi.Texts = "";
            this.txt_ĐChi.UnderlinedStyle = false;
            // 
            // txt_Email
            // 
            this.txt_Email.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_Email.BorderColor = System.Drawing.Color.LightCoral;
            this.txt_Email.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_Email.BorderRadius = 0;
            this.txt_Email.BorderSize = 2;
            this.txt_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Email.Location = new System.Drawing.Point(631, 202);
            this.txt_Email.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Email.Multiline = false;
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_Email.PasswordChar = false;
            this.txt_Email.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_Email.PlaceholderText = "";
            this.txt_Email.Size = new System.Drawing.Size(250, 31);
            this.txt_Email.TabIndex = 4;
            this.txt_Email.Texts = "";
            this.txt_Email.UnderlinedStyle = false;
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.IndianRed;
            this.btn_Add.BackgroundColor = System.Drawing.Color.IndianRed;
            this.btn_Add.BorderColor = System.Drawing.Color.Snow;
            this.btn_Add.BorderRadius = 20;
            this.btn_Add.BorderSize = 0;
            this.btn_Add.FlatAppearance.BorderSize = 0;
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.ForeColor = System.Drawing.Color.Snow;
            this.btn_Add.Location = new System.Drawing.Point(432, 317);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(102, 40);
            this.btn_Add.TabIndex = 6;
            this.btn_Add.Text = "Tạo Mới";
            this.btn_Add.TextColor = System.Drawing.Color.Snow;
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.IndianRed;
            this.btn_Save.BackgroundColor = System.Drawing.Color.IndianRed;
            this.btn_Save.BorderColor = System.Drawing.Color.Snow;
            this.btn_Save.BorderRadius = 20;
            this.btn_Save.BorderSize = 0;
            this.btn_Save.FlatAppearance.BorderSize = 0;
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Save.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.Snow;
            this.btn_Save.Location = new System.Drawing.Point(565, 317);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(102, 40);
            this.btn_Save.TabIndex = 6;
            this.btn_Save.Text = "Lưu";
            this.btn_Save.TextColor = System.Drawing.Color.Snow;
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.BackColor = System.Drawing.Color.IndianRed;
            this.btn_Sua.BackgroundColor = System.Drawing.Color.IndianRed;
            this.btn_Sua.BorderColor = System.Drawing.Color.Snow;
            this.btn_Sua.BorderRadius = 20;
            this.btn_Sua.BorderSize = 0;
            this.btn_Sua.FlatAppearance.BorderSize = 0;
            this.btn_Sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Sua.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.ForeColor = System.Drawing.Color.Snow;
            this.btn_Sua.Location = new System.Drawing.Point(703, 317);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(102, 40);
            this.btn_Sua.TabIndex = 6;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.TextColor = System.Drawing.Color.Snow;
            this.btn_Sua.UseVisualStyleBackColor = false;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.Color.IndianRed;
            this.btn_Xoa.BackgroundColor = System.Drawing.Color.IndianRed;
            this.btn_Xoa.BorderColor = System.Drawing.Color.Snow;
            this.btn_Xoa.BorderRadius = 20;
            this.btn_Xoa.BorderSize = 0;
            this.btn_Xoa.FlatAppearance.BorderSize = 0;
            this.btn_Xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Xoa.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.ForeColor = System.Drawing.Color.Snow;
            this.btn_Xoa.Location = new System.Drawing.Point(846, 317);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(102, 40);
            this.btn_Xoa.TabIndex = 6;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.TextColor = System.Drawing.Color.Snow;
            this.btn_Xoa.UseVisualStyleBackColor = false;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label3.Location = new System.Drawing.Point(469, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Giới Tính";
            // 
            // txt_giơitinh
            // 
            this.txt_giơitinh.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_giơitinh.BorderColor = System.Drawing.Color.LightCoral;
            this.txt_giơitinh.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_giơitinh.BorderRadius = 0;
            this.txt_giơitinh.BorderSize = 2;
            this.txt_giơitinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_giơitinh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_giơitinh.Location = new System.Drawing.Point(631, 254);
            this.txt_giơitinh.Margin = new System.Windows.Forms.Padding(4);
            this.txt_giơitinh.Multiline = false;
            this.txt_giơitinh.Name = "txt_giơitinh";
            this.txt_giơitinh.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_giơitinh.PasswordChar = false;
            this.txt_giơitinh.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_giơitinh.PlaceholderText = "";
            this.txt_giơitinh.Size = new System.Drawing.Size(250, 31);
            this.txt_giơitinh.TabIndex = 4;
            this.txt_giơitinh.Texts = "";
            this.txt_giơitinh.UnderlinedStyle = false;
            // 
            // FrmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(984, 619);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.txt_giơitinh);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.txt_ĐChi);
            this.Controls.Add(this.txt_SĐT);
            this.Controls.Add(this.txt_TenNV);
            this.Controls.Add(this.txt_MNV);
            this.Controls.Add(this.lbl_SĐT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.lbl_address);
            this.Controls.Add(this.lbl_TênNV);
            this.Controls.Add(this.lbl_MNV);
            this.Controls.Add(this.GridView_NV);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmNhanVien";
            this.Load += new System.EventHandler(this.FrmNhanVien_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_NV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private CustomControls.RJControls.RJTextBox rjTextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView GridView_NV;
        private System.Windows.Forms.Label lbl_MNV;
        private System.Windows.Forms.Label lbl_TênNV;
        private System.Windows.Forms.Label lbl_address;
        private System.Windows.Forms.Label lbl_SĐT;
        private System.Windows.Forms.Label lbl_email;
        private CustomControls.RJControls.RJTextBox txt_MNV;
        private CustomControls.RJControls.RJTextBox txt_TenNV;
        private CustomControls.RJControls.RJTextBox txt_SĐT;
        private CustomControls.RJControls.RJTextBox txt_ĐChi;
        private CustomControls.RJControls.RJTextBox txt_Email;
        private CustomControls.RJControls.RJButton btn_Add;
        private CustomControls.RJControls.RJButton btn_Save;
        private CustomControls.RJControls.RJButton btn_Sua;
        private CustomControls.RJControls.RJButton btn_Xoa;
        private System.Windows.Forms.Label label3;
        private CustomControls.RJControls.RJTextBox txt_giơitinh;
    }
}