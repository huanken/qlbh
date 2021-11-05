
namespace qlbh.UI
{
    partial class FrmSanPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSanPham));
            this.txtBox_dvt = new System.Windows.Forms.TextBox();
            this.txtBox_giasp = new System.Windows.Forms.TextBox();
            this.txtBox_tensp = new System.Windows.Forms.TextBox();
            this.txtBox_masp = new System.Windows.Forms.TextBox();
            this.txt_masp = new System.Windows.Forms.Label();
            this.txt_dm = new System.Windows.Forms.Label();
            this.txt_dvt = new System.Windows.Forms.Label();
            this.btn_Luu = new CustomControls.RJControls.RJButton();
            this.btn_Xoa = new CustomControls.RJControls.RJButton();
            this.btn_Sua = new CustomControls.RJControls.RJButton();
            this.btn_Them = new CustomControls.RJControls.RJButton();
            this.pic_B1 = new System.Windows.Forms.PictureBox();
            this.txt_giaB1 = new System.Windows.Forms.Label();
            this.txt_tenB1 = new System.Windows.Forms.Label();
            this.txt_SanPham = new System.Windows.Forms.Label();
            this.rjCircularPictureBox1 = new CustomControls.RJControls.RJCircularPictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbo_dm = new System.Windows.Forms.ComboBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet = new qlbh.qlbanhangDataSet1();
            this.sanphamTableAdapter1 = new qlbh.qlbanhangDataSet1TableAdapters.sanphamTableAdapter();
            this.dgv_sanpham = new System.Windows.Forms.DataGridView();
            this.txtImagepath = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pic_B1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sanpham)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBox_dvt
            // 
            this.txtBox_dvt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBox_dvt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_dvt.Location = new System.Drawing.Point(132, 205);
            this.txtBox_dvt.Name = "txtBox_dvt";
            this.txtBox_dvt.Size = new System.Drawing.Size(220, 23);
            this.txtBox_dvt.TabIndex = 29;
            // 
            // txtBox_giasp
            // 
            this.txtBox_giasp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBox_giasp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_giasp.Location = new System.Drawing.Point(132, 174);
            this.txtBox_giasp.Name = "txtBox_giasp";
            this.txtBox_giasp.Size = new System.Drawing.Size(220, 23);
            this.txtBox_giasp.TabIndex = 28;
            // 
            // txtBox_tensp
            // 
            this.txtBox_tensp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBox_tensp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_tensp.Location = new System.Drawing.Point(132, 143);
            this.txtBox_tensp.Name = "txtBox_tensp";
            this.txtBox_tensp.Size = new System.Drawing.Size(220, 23);
            this.txtBox_tensp.TabIndex = 27;
            // 
            // txtBox_masp
            // 
            this.txtBox_masp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBox_masp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_masp.Location = new System.Drawing.Point(132, 112);
            this.txtBox_masp.Name = "txtBox_masp";
            this.txtBox_masp.Size = new System.Drawing.Size(220, 23);
            this.txtBox_masp.TabIndex = 26;
            // 
            // txt_masp
            // 
            this.txt_masp.AutoSize = true;
            this.txt_masp.BackColor = System.Drawing.Color.Transparent;
            this.txt_masp.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_masp.ForeColor = System.Drawing.Color.IndianRed;
            this.txt_masp.Location = new System.Drawing.Point(17, 114);
            this.txt_masp.Name = "txt_masp";
            this.txt_masp.Size = new System.Drawing.Size(109, 18);
            this.txt_masp.TabIndex = 25;
            this.txt_masp.Text = "Mã sản phẩm: ";
            // 
            // txt_dm
            // 
            this.txt_dm.AutoSize = true;
            this.txt_dm.BackColor = System.Drawing.SystemColors.Control;
            this.txt_dm.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dm.ForeColor = System.Drawing.Color.IndianRed;
            this.txt_dm.Location = new System.Drawing.Point(17, 238);
            this.txt_dm.Name = "txt_dm";
            this.txt_dm.Size = new System.Drawing.Size(83, 18);
            this.txt_dm.TabIndex = 23;
            this.txt_dm.Text = "Danh mục:";
            // 
            // txt_dvt
            // 
            this.txt_dvt.AutoSize = true;
            this.txt_dvt.BackColor = System.Drawing.SystemColors.Control;
            this.txt_dvt.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dvt.ForeColor = System.Drawing.Color.IndianRed;
            this.txt_dvt.Location = new System.Drawing.Point(17, 207);
            this.txt_dvt.Name = "txt_dvt";
            this.txt_dvt.Size = new System.Drawing.Size(88, 18);
            this.txt_dvt.TabIndex = 22;
            this.txt_dvt.Text = "Đơn vị tính:";
            // 
            // btn_Luu
            // 
            this.btn_Luu.BackColor = System.Drawing.Color.IndianRed;
            this.btn_Luu.BackgroundColor = System.Drawing.Color.IndianRed;
            this.btn_Luu.BorderColor = System.Drawing.Color.White;
            this.btn_Luu.BorderRadius = 20;
            this.btn_Luu.BorderSize = 3;
            this.btn_Luu.FlatAppearance.BorderSize = 0;
            this.btn_Luu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Luu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Luu.ForeColor = System.Drawing.Color.White;
            this.btn_Luu.Location = new System.Drawing.Point(445, 519);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(119, 45);
            this.btn_Luu.TabIndex = 21;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.TextColor = System.Drawing.Color.White;
            this.btn_Luu.UseVisualStyleBackColor = false;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click_1);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.Color.IndianRed;
            this.btn_Xoa.BackgroundColor = System.Drawing.Color.IndianRed;
            this.btn_Xoa.BorderColor = System.Drawing.Color.White;
            this.btn_Xoa.BorderRadius = 20;
            this.btn_Xoa.BorderSize = 3;
            this.btn_Xoa.FlatAppearance.BorderSize = 0;
            this.btn_Xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.ForeColor = System.Drawing.Color.White;
            this.btn_Xoa.Location = new System.Drawing.Point(749, 519);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(119, 45);
            this.btn_Xoa.TabIndex = 20;
            this.btn_Xoa.Text = "Xoá";
            this.btn_Xoa.TextColor = System.Drawing.Color.White;
            this.btn_Xoa.UseVisualStyleBackColor = false;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.BackColor = System.Drawing.Color.IndianRed;
            this.btn_Sua.BackgroundColor = System.Drawing.Color.IndianRed;
            this.btn_Sua.BorderColor = System.Drawing.Color.White;
            this.btn_Sua.BorderRadius = 20;
            this.btn_Sua.BorderSize = 3;
            this.btn_Sua.FlatAppearance.BorderSize = 0;
            this.btn_Sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.ForeColor = System.Drawing.Color.White;
            this.btn_Sua.Location = new System.Drawing.Point(595, 519);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(119, 45);
            this.btn_Sua.TabIndex = 19;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.TextColor = System.Drawing.Color.White;
            this.btn_Sua.UseVisualStyleBackColor = false;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click_1);
            // 
            // btn_Them
            // 
            this.btn_Them.BackColor = System.Drawing.Color.IndianRed;
            this.btn_Them.BackgroundColor = System.Drawing.Color.IndianRed;
            this.btn_Them.BorderColor = System.Drawing.Color.White;
            this.btn_Them.BorderRadius = 20;
            this.btn_Them.BorderSize = 3;
            this.btn_Them.FlatAppearance.BorderSize = 0;
            this.btn_Them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Them.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.ForeColor = System.Drawing.Color.White;
            this.btn_Them.Location = new System.Drawing.Point(293, 519);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(119, 45);
            this.btn_Them.TabIndex = 18;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.TextColor = System.Drawing.Color.White;
            this.btn_Them.UseVisualStyleBackColor = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click_1);
            // 
            // pic_B1
            // 
            this.pic_B1.Location = new System.Drawing.Point(15, 271);
            this.pic_B1.Name = "pic_B1";
            this.pic_B1.Size = new System.Drawing.Size(332, 200);
            this.pic_B1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pic_B1.TabIndex = 17;
            this.pic_B1.TabStop = false;
            // 
            // txt_giaB1
            // 
            this.txt_giaB1.AutoSize = true;
            this.txt_giaB1.BackColor = System.Drawing.SystemColors.Control;
            this.txt_giaB1.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_giaB1.ForeColor = System.Drawing.Color.IndianRed;
            this.txt_giaB1.Location = new System.Drawing.Point(17, 176);
            this.txt_giaB1.Name = "txt_giaB1";
            this.txt_giaB1.Size = new System.Drawing.Size(107, 18);
            this.txt_giaB1.TabIndex = 16;
            this.txt_giaB1.Text = "Giá sản phẩm:";
            // 
            // txt_tenB1
            // 
            this.txt_tenB1.AutoSize = true;
            this.txt_tenB1.BackColor = System.Drawing.SystemColors.Control;
            this.txt_tenB1.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tenB1.ForeColor = System.Drawing.Color.IndianRed;
            this.txt_tenB1.Location = new System.Drawing.Point(17, 145);
            this.txt_tenB1.Name = "txt_tenB1";
            this.txt_tenB1.Size = new System.Drawing.Size(108, 18);
            this.txt_tenB1.TabIndex = 15;
            this.txt_tenB1.Text = "Tên sản phẩm:";
            // 
            // txt_SanPham
            // 
            this.txt_SanPham.AutoSize = true;
            this.txt_SanPham.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SanPham.ForeColor = System.Drawing.Color.IndianRed;
            this.txt_SanPham.Location = new System.Drawing.Point(420, 14);
            this.txt_SanPham.Name = "txt_SanPham";
            this.txt_SanPham.Size = new System.Drawing.Size(144, 31);
            this.txt_SanPham.TabIndex = 14;
            this.txt_SanPham.Text = "Sản phẩm ";
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
            this.rjCircularPictureBox1.Location = new System.Drawing.Point(54, 9);
            this.rjCircularPictureBox1.Name = "rjCircularPictureBox1";
            this.rjCircularPictureBox1.Size = new System.Drawing.Size(100, 100);
            this.rjCircularPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.rjCircularPictureBox1.TabIndex = 31;
            this.rjCircularPictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.IndianRed;
            this.panel1.Location = new System.Drawing.Point(160, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(718, 3);
            this.panel1.TabIndex = 32;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(202)))), ((int)(((byte)(64)))));
            this.panel2.Location = new System.Drawing.Point(123, 646);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(718, 3);
            this.panel2.TabIndex = 33;
            // 
            // cbo_dm
            // 
            this.cbo_dm.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_dm.FormattingEnabled = true;
            this.cbo_dm.Location = new System.Drawing.Point(132, 239);
            this.cbo_dm.Name = "cbo_dm";
            this.cbo_dm.Size = new System.Drawing.Size(220, 26);
            this.cbo_dm.TabIndex = 34;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "sanpham";
            this.bindingSource1.DataSource = this.dataSet;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "qlbanhangDataSet1";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sanphamTableAdapter1
            // 
            this.sanphamTableAdapter1.ClearBeforeFill = true;
            // 
            // dgv_sanpham
            // 
            this.dgv_sanpham.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_sanpham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_sanpham.Location = new System.Drawing.Point(358, 103);
            this.dgv_sanpham.Name = "dgv_sanpham";
            this.dgv_sanpham.Size = new System.Drawing.Size(522, 389);
            this.dgv_sanpham.TabIndex = 24;
            this.dgv_sanpham.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_sanpham_CellContentClick);
            // 
            // txtImagepath
            // 
            this.txtImagepath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtImagepath.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImagepath.Location = new System.Drawing.Point(12, 477);
            this.txtImagepath.Name = "txtImagepath";
            this.txtImagepath.Size = new System.Drawing.Size(340, 23);
            this.txtImagepath.TabIndex = 36;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.IndianRed;
            this.panel3.Location = new System.Drawing.Point(132, 578);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(718, 3);
            this.panel3.TabIndex = 37;
            // 
            // FrmSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(907, 593);
            this.ControlBox = false;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.txtImagepath);
            this.Controls.Add(this.cbo_dm);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.rjCircularPictureBox1);
            this.Controls.Add(this.txtBox_dvt);
            this.Controls.Add(this.txtBox_giasp);
            this.Controls.Add(this.txtBox_tensp);
            this.Controls.Add(this.txtBox_masp);
            this.Controls.Add(this.txt_masp);
            this.Controls.Add(this.dgv_sanpham);
            this.Controls.Add(this.txt_dm);
            this.Controls.Add(this.txt_dvt);
            this.Controls.Add(this.btn_Luu);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.pic_B1);
            this.Controls.Add(this.txt_giaB1);
            this.Controls.Add(this.txt_tenB1);
            this.Controls.Add(this.txt_SanPham);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSanPham";
            this.Text = "FrmSanPham";
            this.Load += new System.EventHandler(this.FrmSanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_B1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sanpham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtBox_dvt;
        private System.Windows.Forms.TextBox txtBox_giasp;
        private System.Windows.Forms.TextBox txtBox_tensp;
        private System.Windows.Forms.TextBox txtBox_masp;
        private System.Windows.Forms.Label txt_masp;
        private System.Windows.Forms.Label txt_dm;
        private System.Windows.Forms.Label txt_dvt;
        private CustomControls.RJControls.RJButton btn_Luu;
        private CustomControls.RJControls.RJButton btn_Xoa;
        private CustomControls.RJControls.RJButton btn_Sua;
        private CustomControls.RJControls.RJButton btn_Them;
        private System.Windows.Forms.PictureBox pic_B1;
        private System.Windows.Forms.Label txt_giaB1;
        private System.Windows.Forms.Label txt_tenB1;
        private System.Windows.Forms.Label txt_SanPham;
        private CustomControls.RJControls.RJCircularPictureBox rjCircularPictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbo_dm;
        private System.Windows.Forms.BindingSource bindingSource1;
        private qlbanhangDataSet1 dataSet;
        private qlbanhangDataSet1TableAdapters.sanphamTableAdapter sanphamTableAdapter1;
        private System.Windows.Forms.DataGridView dgv_sanpham;
        private System.Windows.Forms.TextBox txtImagepath;
        private System.Windows.Forms.Panel panel3;
    }
}