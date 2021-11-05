
namespace qlbh.UI
{
    partial class FrmBaoCaoNhapXuat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBaoCaoNhapXuat));
            this.rjCircularPictureBox1 = new CustomControls.RJControls.RJCircularPictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnThemmoi = new CustomControls.RJControls.RJButton();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.CRVNhapXuat = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.dp_Time = new CustomControls.RJControls.RJDatePicker();
            this.rjDatePicker1 = new CustomControls.RJControls.RJDatePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // rjCircularPictureBox1
            // 
            this.rjCircularPictureBox1.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.rjCircularPictureBox1.BorderColor = System.Drawing.Color.RoyalBlue;
            this.rjCircularPictureBox1.BorderColor2 = System.Drawing.Color.HotPink;
            this.rjCircularPictureBox1.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            this.rjCircularPictureBox1.BorderSize = 5;
            this.rjCircularPictureBox1.GradientAngle = 50F;
            this.rjCircularPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("rjCircularPictureBox1.Image")));
            this.rjCircularPictureBox1.Location = new System.Drawing.Point(32, 3);
            this.rjCircularPictureBox1.Name = "rjCircularPictureBox1";
            this.rjCircularPictureBox1.Size = new System.Drawing.Size(107, 107);
            this.rjCircularPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.rjCircularPictureBox1.TabIndex = 13;
            this.rjCircularPictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Salmon;
            this.panel2.Location = new System.Drawing.Point(86, 552);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(803, 3);
            this.panel2.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Salmon;
            this.panel1.Location = new System.Drawing.Point(158, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(737, 3);
            this.panel1.TabIndex = 12;
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
            this.btnThemmoi.Location = new System.Drawing.Point(756, 76);
            this.btnThemmoi.Name = "btnThemmoi";
            this.btnThemmoi.Size = new System.Drawing.Size(139, 40);
            this.btnThemmoi.TabIndex = 10;
            this.btnThemmoi.Text = "Xuất Báo Cáo";
            this.btnThemmoi.TextColor = System.Drawing.SystemColors.Control;
            this.btnThemmoi.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.IndianRed;
            this.label6.Location = new System.Drawing.Point(370, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(282, 31);
            this.label6.TabIndex = 8;
            this.label6.Text = "Báo Cáo Nhập Xuất";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.CRVNhapXuat);
            this.panel3.Location = new System.Drawing.Point(25, 122);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(898, 424);
            this.panel3.TabIndex = 14;
            // 
            // CRVNhapXuat
            // 
            this.CRVNhapXuat.ActiveViewIndex = -1;
            this.CRVNhapXuat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CRVNhapXuat.Cursor = System.Windows.Forms.Cursors.Default;
            this.CRVNhapXuat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CRVNhapXuat.Location = new System.Drawing.Point(0, 0);
            this.CRVNhapXuat.Name = "CRVNhapXuat";
            this.CRVNhapXuat.Size = new System.Drawing.Size(898, 424);
            this.CRVNhapXuat.TabIndex = 0;
            // 
            // dp_Time
            // 
            this.dp_Time.BorderColor = System.Drawing.Color.MintCream;
            this.dp_Time.BorderSize = 0;
            this.dp_Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.dp_Time.Location = new System.Drawing.Point(235, 77);
            this.dp_Time.MinimumSize = new System.Drawing.Size(4, 35);
            this.dp_Time.Name = "dp_Time";
            this.dp_Time.Size = new System.Drawing.Size(200, 35);
            this.dp_Time.SkinColor = System.Drawing.Color.MediumAquamarine;
            this.dp_Time.TabIndex = 19;
            this.dp_Time.TextColor = System.Drawing.Color.White;
            // 
            // rjDatePicker1
            // 
            this.rjDatePicker1.BorderColor = System.Drawing.Color.MintCream;
            this.rjDatePicker1.BorderSize = 0;
            this.rjDatePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.rjDatePicker1.Location = new System.Drawing.Point(546, 79);
            this.rjDatePicker1.MinimumSize = new System.Drawing.Size(4, 35);
            this.rjDatePicker1.Name = "rjDatePicker1";
            this.rjDatePicker1.Size = new System.Drawing.Size(200, 35);
            this.rjDatePicker1.SkinColor = System.Drawing.Color.MediumAquamarine;
            this.rjDatePicker1.TabIndex = 20;
            this.rjDatePicker1.TextColor = System.Drawing.Color.White;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.label3.Location = new System.Drawing.Point(162, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "Từ Ngày:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.label1.Location = new System.Drawing.Point(460, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "Đến Ngày:";
            // 
            // FrmBaoCaoNhapXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(945, 571);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rjDatePicker1);
            this.Controls.Add(this.dp_Time);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.rjCircularPictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnThemmoi);
            this.Controls.Add(this.label6);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmBaoCaoNhapXuat";
            this.Text = "FrmBaoCaoNhapXuat";
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.RJControls.RJCircularPictureBox rjCircularPictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private CustomControls.RJControls.RJButton btnThemmoi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer CRVNhapXuat;
        private CustomControls.RJControls.RJDatePicker dp_Time;
        private CustomControls.RJControls.RJDatePicker rjDatePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}