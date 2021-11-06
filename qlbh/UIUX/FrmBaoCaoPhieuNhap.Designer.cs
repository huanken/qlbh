
namespace qlbh.UI
{
    partial class FrmBaoCaoPhieuNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBaoCaoPhieuNhap));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.date2 = new CustomControls.RJControls.RJDatePicker();
            this.date1 = new CustomControls.RJControls.RJDatePicker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.CRVBCPhieuNhap = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnXemBC = new CustomControls.RJControls.RJButton();
            this.label6 = new System.Windows.Forms.Label();
            this.rjCircularPictureBox1 = new CustomControls.RJControls.RJCircularPictureBox();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.label1.Location = new System.Drawing.Point(464, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 31;
            this.label1.Text = "Đến Ngày:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.label3.Location = new System.Drawing.Point(166, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 30;
            this.label3.Text = "Từ Ngày:";
            // 
            // date2
            // 
            this.date2.BorderColor = System.Drawing.Color.MintCream;
            this.date2.BorderSize = 0;
            this.date2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.date2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date2.Location = new System.Drawing.Point(550, 63);
            this.date2.MinimumSize = new System.Drawing.Size(4, 35);
            this.date2.Name = "date2";
            this.date2.Size = new System.Drawing.Size(200, 35);
            this.date2.SkinColor = System.Drawing.Color.MediumAquamarine;
            this.date2.TabIndex = 29;
            this.date2.TextColor = System.Drawing.Color.White;
            // 
            // date1
            // 
            this.date1.BorderColor = System.Drawing.Color.MintCream;
            this.date1.BorderSize = 0;
            this.date1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.date1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date1.Location = new System.Drawing.Point(239, 61);
            this.date1.MinimumSize = new System.Drawing.Size(4, 35);
            this.date1.Name = "date1";
            this.date1.Size = new System.Drawing.Size(200, 35);
            this.date1.SkinColor = System.Drawing.Color.MediumAquamarine;
            this.date1.TabIndex = 28;
            this.date1.TextColor = System.Drawing.Color.White;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.CRVBCPhieuNhap);
            this.panel3.Location = new System.Drawing.Point(12, 102);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(933, 460);
            this.panel3.TabIndex = 27;
            // 
            // CRVBCPhieuNhap
            // 
            this.CRVBCPhieuNhap.ActiveViewIndex = -1;
            this.CRVBCPhieuNhap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CRVBCPhieuNhap.Cursor = System.Windows.Forms.Cursors.Default;
            this.CRVBCPhieuNhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CRVBCPhieuNhap.Location = new System.Drawing.Point(0, 0);
            this.CRVBCPhieuNhap.Name = "CRVBCPhieuNhap";
            this.CRVBCPhieuNhap.Size = new System.Drawing.Size(933, 460);
            this.CRVBCPhieuNhap.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Salmon;
            this.panel1.Location = new System.Drawing.Point(162, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(737, 3);
            this.panel1.TabIndex = 25;
            // 
            // btnXemBC
            // 
            this.btnXemBC.BackColor = System.Drawing.Color.Tomato;
            this.btnXemBC.BackgroundColor = System.Drawing.Color.Tomato;
            this.btnXemBC.BorderColor = System.Drawing.Color.Black;
            this.btnXemBC.BorderRadius = 20;
            this.btnXemBC.BorderSize = 1;
            this.btnXemBC.FlatAppearance.BorderSize = 0;
            this.btnXemBC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXemBC.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemBC.ForeColor = System.Drawing.SystemColors.Control;
            this.btnXemBC.Location = new System.Drawing.Point(760, 60);
            this.btnXemBC.Name = "btnXemBC";
            this.btnXemBC.Size = new System.Drawing.Size(139, 40);
            this.btnXemBC.TabIndex = 24;
            this.btnXemBC.Text = "Xuất Báo Cáo";
            this.btnXemBC.TextColor = System.Drawing.SystemColors.Control;
            this.btnXemBC.UseVisualStyleBackColor = false;
            this.btnXemBC.Click += new System.EventHandler(this.btnXemBC_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.IndianRed;
            this.label6.Location = new System.Drawing.Point(374, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(291, 31);
            this.label6.TabIndex = 23;
            this.label6.Text = "Báo Cáo Nhập Hàng";
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
            this.rjCircularPictureBox1.Location = new System.Drawing.Point(36, -3);
            this.rjCircularPictureBox1.Name = "rjCircularPictureBox1";
            this.rjCircularPictureBox1.Size = new System.Drawing.Size(107, 107);
            this.rjCircularPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.rjCircularPictureBox1.TabIndex = 26;
            this.rjCircularPictureBox1.TabStop = false;
            // 
            // FrmBaoCaoPhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(957, 567);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.date2);
            this.Controls.Add(this.date1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.rjCircularPictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnXemBC);
            this.Controls.Add(this.label6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmBaoCaoPhieuNhap";
            this.Text = "FrmBaoCaoPhieuNhap";
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private CustomControls.RJControls.RJDatePicker date2;
        private CustomControls.RJControls.RJDatePicker date1;
        private System.Windows.Forms.Panel panel3;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer CRVBCPhieuNhap;
        private CustomControls.RJControls.RJCircularPictureBox rjCircularPictureBox1;
        private System.Windows.Forms.Panel panel1;
        private CustomControls.RJControls.RJButton btnXemBC;
        private System.Windows.Forms.Label label6;
    }
}