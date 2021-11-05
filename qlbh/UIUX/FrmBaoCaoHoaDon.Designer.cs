
namespace qlbh.UI
{
    partial class FrmBaoCaoHoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBaoCaoHoaDon));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnXemBC = new CustomControls.RJControls.RJButton();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.CRVBCHD = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.date1 = new CustomControls.RJControls.RJDatePicker();
            this.date2 = new CustomControls.RJControls.RJDatePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rjCircularPictureBox1 = new CustomControls.RJControls.RJCircularPictureBox();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.btnXemBC.Location = new System.Drawing.Point(756, 76);
            this.btnXemBC.Name = "btnXemBC";
            this.btnXemBC.Size = new System.Drawing.Size(139, 40);
            this.btnXemBC.TabIndex = 10;
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
            this.label6.Location = new System.Drawing.Point(370, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(256, 31);
            this.label6.TabIndex = 8;
            this.label6.Text = "Báo Cáo Hóa Đơn";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.CRVBCHD);
            this.panel3.Location = new System.Drawing.Point(25, 122);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(898, 424);
            this.panel3.TabIndex = 14;
            // 
            // CRVBCHD
            // 
            this.CRVBCHD.ActiveViewIndex = -1;
            this.CRVBCHD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CRVBCHD.Cursor = System.Windows.Forms.Cursors.Default;
            this.CRVBCHD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CRVBCHD.Location = new System.Drawing.Point(0, 0);
            this.CRVBCHD.Name = "CRVBCHD";
            this.CRVBCHD.Size = new System.Drawing.Size(898, 424);
            this.CRVBCHD.TabIndex = 0;
            // 
            // date1
            // 
            this.date1.BorderColor = System.Drawing.Color.MintCream;
            this.date1.BorderSize = 0;
            this.date1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.date1.Location = new System.Drawing.Point(235, 77);
            this.date1.MinimumSize = new System.Drawing.Size(4, 35);
            this.date1.Name = "date1";
            this.date1.Size = new System.Drawing.Size(200, 35);
            this.date1.SkinColor = System.Drawing.Color.MediumAquamarine;
            this.date1.TabIndex = 19;
            this.date1.TextColor = System.Drawing.Color.White;
            // 
            // date2
            // 
            this.date2.BorderColor = System.Drawing.Color.MintCream;
            this.date2.BorderSize = 0;
            this.date2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.date2.Location = new System.Drawing.Point(546, 79);
            this.date2.MinimumSize = new System.Drawing.Size(4, 35);
            this.date2.Name = "date2";
            this.date2.Size = new System.Drawing.Size(200, 35);
            this.date2.SkinColor = System.Drawing.Color.MediumAquamarine;
            this.date2.TabIndex = 20;
            this.date2.TextColor = System.Drawing.Color.White;
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
            // FrmBaoCaoHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(945, 571);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.date2);
            this.Controls.Add(this.date1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.rjCircularPictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnXemBC);
            this.Controls.Add(this.label6);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmBaoCaoHoaDon";
            this.Text = "FrmBaoCaoNhapXuat";
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.RJControls.RJCircularPictureBox rjCircularPictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private CustomControls.RJControls.RJButton btnXemBC;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer CRVBCHD;
        private CustomControls.RJControls.RJDatePicker date2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private CustomControls.RJControls.RJDatePicker date1;
    }
}