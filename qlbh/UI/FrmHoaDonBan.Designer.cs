
namespace qlbh.UI
{
    partial class FrmHoaDonBan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHoaDonBan));
            this.hoadonbanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnThem = new CustomControls.RJControls.RJButton();
            this.btnLuu = new CustomControls.RJControls.RJButton();
            this.btnXoa = new CustomControls.RJControls.RJButton();
            this.btnThoat = new CustomControls.RJControls.RJButton();
            this.grbhoadonban = new System.Windows.Forms.GroupBox();
            this.cbomanv = new System.Windows.Forms.ComboBox();
            this.datengayban = new System.Windows.Forms.DateTimePicker();
            this.txttennv = new System.Windows.Forms.TextBox();
            this.txtmahdon = new System.Windows.Forms.TextBox();
            this.lbltennv = new System.Windows.Forms.Label();
            this.lblmanv = new System.Windows.Forms.Label();
            this.lblngayban = new System.Windows.Forms.Label();
            this.lblmahoadon = new System.Windows.Forms.Label();
            this.grbsanpham = new System.Windows.Forms.GroupBox();
            this.txtthanhtien = new System.Windows.Forms.TextBox();
            this.txtgiamgia = new System.Windows.Forms.TextBox();
            this.txtsoluong = new System.Windows.Forms.TextBox();
            this.txtgiaban = new System.Windows.Forms.TextBox();
            this.txttensp = new System.Windows.Forms.TextBox();
            this.cbomasp = new System.Windows.Forms.ComboBox();
            this.lblthanhtien = new System.Windows.Forms.Label();
            this.lblgiamgia = new System.Windows.Forms.Label();
            this.lblgiaban = new System.Windows.Forms.Label();
            this.lblSoluong = new System.Windows.Forms.Label();
            this.lbltensp = new System.Windows.Forms.Label();
            this.lblmasp = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picbill = new CustomControls.RJControls.RJCircularPictureBox();
            this.lblhoadonban = new System.Windows.Forms.Label();
            this.lblcongtienhang = new System.Windows.Forms.Label();
            this.lblvat = new System.Windows.Forms.Label();
            this.lbltongtien = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblghichu = new System.Windows.Forms.Label();
            this.txtghichu = new System.Windows.Forms.TextBox();
            this.txtcongtienhang = new System.Windows.Forms.TextBox();
            this.txtVAT = new System.Windows.Forms.TextBox();
            this.txttongtien = new System.Windows.Forms.TextBox();
            this.dgvhoadonban = new System.Windows.Forms.DataGridView();
            this.masp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaban = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giamgia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanhtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ghi_chu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.hoadonbanBindingSource)).BeginInit();
            this.grbhoadonban.SuspendLayout();
            this.grbsanpham.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvhoadonban)).BeginInit();
            this.SuspendLayout();
            // 
            // hoadonbanBindingSource
            // 
            this.hoadonbanBindingSource.DataMember = "hoadonban";
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Tomato;
            this.btnThem.BackgroundColor = System.Drawing.Color.Tomato;
            this.btnThem.BorderColor = System.Drawing.Color.Black;
            this.btnThem.BorderRadius = 20;
            this.btnThem.BorderSize = 2;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnThem.Location = new System.Drawing.Point(145, 447);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 40);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.Tomato;
            this.btnLuu.BackgroundColor = System.Drawing.Color.Tomato;
            this.btnLuu.BorderColor = System.Drawing.Color.Black;
            this.btnLuu.BorderRadius = 20;
            this.btnLuu.BorderSize = 2;
            this.btnLuu.FlatAppearance.BorderSize = 0;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLuu.Location = new System.Drawing.Point(694, 431);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(104, 40);
            this.btnLuu.TabIndex = 6;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Goldenrod;
            this.btnXoa.BackgroundColor = System.Drawing.Color.Goldenrod;
            this.btnXoa.BorderColor = System.Drawing.Color.Black;
            this.btnXoa.BorderRadius = 20;
            this.btnXoa.BorderSize = 2;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnXoa.Location = new System.Drawing.Point(260, 447);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(93, 40);
            this.btnXoa.TabIndex = 6;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.TextColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Goldenrod;
            this.btnThoat.BackgroundColor = System.Drawing.Color.Goldenrod;
            this.btnThoat.BorderColor = System.Drawing.Color.Black;
            this.btnThoat.BorderRadius = 20;
            this.btnThoat.BorderSize = 2;
            this.btnThoat.FlatAppearance.BorderSize = 0;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnThoat.Location = new System.Drawing.Point(823, 431);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(92, 40);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Reset";
            this.btnThoat.TextColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // grbhoadonban
            // 
            this.grbhoadonban.Controls.Add(this.cbomanv);
            this.grbhoadonban.Controls.Add(this.datengayban);
            this.grbhoadonban.Controls.Add(this.txttennv);
            this.grbhoadonban.Controls.Add(this.txtmahdon);
            this.grbhoadonban.Controls.Add(this.lbltennv);
            this.grbhoadonban.Controls.Add(this.lblmanv);
            this.grbhoadonban.Controls.Add(this.lblngayban);
            this.grbhoadonban.Controls.Add(this.lblmahoadon);
            this.grbhoadonban.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbhoadonban.ForeColor = System.Drawing.Color.IndianRed;
            this.grbhoadonban.Location = new System.Drawing.Point(117, 69);
            this.grbhoadonban.Name = "grbhoadonban";
            this.grbhoadonban.Size = new System.Drawing.Size(299, 141);
            this.grbhoadonban.TabIndex = 7;
            this.grbhoadonban.TabStop = false;
            this.grbhoadonban.Text = "Thông tin chung";
            // 
            // cbomanv
            // 
            this.cbomanv.FormattingEnabled = true;
            this.cbomanv.Location = new System.Drawing.Point(131, 84);
            this.cbomanv.Name = "cbomanv";
            this.cbomanv.Size = new System.Drawing.Size(153, 24);
            this.cbomanv.TabIndex = 3;
            this.cbomanv.DropDown += new System.EventHandler(this.cbomanv_DropDown);
            this.cbomanv.SelectedIndexChanged += new System.EventHandler(this.cbomanv_SelectedIndexChanged);
            // 
            // datengayban
            // 
            this.datengayban.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datengayban.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datengayban.Location = new System.Drawing.Point(131, 51);
            this.datengayban.Name = "datengayban";
            this.datengayban.Size = new System.Drawing.Size(153, 22);
            this.datengayban.TabIndex = 2;
            this.datengayban.ValueChanged += new System.EventHandler(this.datengayban_ValueChanged);
            // 
            // txttennv
            // 
            this.txttennv.Location = new System.Drawing.Point(131, 113);
            this.txttennv.Name = "txttennv";
            this.txttennv.Size = new System.Drawing.Size(153, 22);
            this.txttennv.TabIndex = 1;
            // 
            // txtmahdon
            // 
            this.txtmahdon.Location = new System.Drawing.Point(131, 16);
            this.txtmahdon.Name = "txtmahdon";
            this.txtmahdon.Size = new System.Drawing.Size(153, 22);
            this.txtmahdon.TabIndex = 1;
            // 
            // lbltennv
            // 
            this.lbltennv.AutoSize = true;
            this.lbltennv.Location = new System.Drawing.Point(13, 113);
            this.lbltennv.Name = "lbltennv";
            this.lbltennv.Size = new System.Drawing.Size(109, 16);
            this.lbltennv.TabIndex = 0;
            this.lbltennv.Text = "Tên nhân viên:";
            // 
            // lblmanv
            // 
            this.lblmanv.AutoSize = true;
            this.lblmanv.Location = new System.Drawing.Point(13, 84);
            this.lblmanv.Name = "lblmanv";
            this.lblmanv.Size = new System.Drawing.Size(107, 16);
            this.lblmanv.TabIndex = 0;
            this.lblmanv.Text = "Mã nhân viên: ";
            // 
            // lblngayban
            // 
            this.lblngayban.AutoSize = true;
            this.lblngayban.Location = new System.Drawing.Point(13, 51);
            this.lblngayban.Name = "lblngayban";
            this.lblngayban.Size = new System.Drawing.Size(79, 16);
            this.lblngayban.TabIndex = 0;
            this.lblngayban.Text = "Ngày bán:";
            // 
            // lblmahoadon
            // 
            this.lblmahoadon.AutoSize = true;
            this.lblmahoadon.ForeColor = System.Drawing.Color.IndianRed;
            this.lblmahoadon.Location = new System.Drawing.Point(13, 22);
            this.lblmahoadon.Name = "lblmahoadon";
            this.lblmahoadon.Size = new System.Drawing.Size(97, 16);
            this.lblmahoadon.TabIndex = 0;
            this.lblmahoadon.Text = "Mã hoá đơn: ";
            // 
            // grbsanpham
            // 
            this.grbsanpham.Controls.Add(this.txtthanhtien);
            this.grbsanpham.Controls.Add(this.txtgiamgia);
            this.grbsanpham.Controls.Add(this.txtsoluong);
            this.grbsanpham.Controls.Add(this.txtgiaban);
            this.grbsanpham.Controls.Add(this.txttensp);
            this.grbsanpham.Controls.Add(this.cbomasp);
            this.grbsanpham.Controls.Add(this.lblthanhtien);
            this.grbsanpham.Controls.Add(this.lblgiamgia);
            this.grbsanpham.Controls.Add(this.lblgiaban);
            this.grbsanpham.Controls.Add(this.lblSoluong);
            this.grbsanpham.Controls.Add(this.lbltensp);
            this.grbsanpham.Controls.Add(this.lblmasp);
            this.grbsanpham.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbsanpham.ForeColor = System.Drawing.Color.IndianRed;
            this.grbsanpham.Location = new System.Drawing.Point(117, 216);
            this.grbsanpham.Name = "grbsanpham";
            this.grbsanpham.Size = new System.Drawing.Size(299, 215);
            this.grbsanpham.TabIndex = 8;
            this.grbsanpham.TabStop = false;
            this.grbsanpham.Text = "Thông tin sản phẩm: ";
            // 
            // txtthanhtien
            // 
            this.txtthanhtien.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtthanhtien.Location = new System.Drawing.Point(126, 170);
            this.txtthanhtien.Name = "txtthanhtien";
            this.txtthanhtien.Size = new System.Drawing.Size(163, 24);
            this.txtthanhtien.TabIndex = 2;
            this.txtthanhtien.Text = "0.00";
            // 
            // txtgiamgia
            // 
            this.txtgiamgia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtgiamgia.Location = new System.Drawing.Point(126, 142);
            this.txtgiamgia.Name = "txtgiamgia";
            this.txtgiamgia.Size = new System.Drawing.Size(163, 24);
            this.txtgiamgia.TabIndex = 2;
            this.txtgiamgia.Text = "0.00";
            this.txtgiamgia.TextChanged += new System.EventHandler(this.txtgia_giamgia_soluong_TextChanged);
            this.txtgiamgia.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtgiamgia_soluong_KeyDown);
            // 
            // txtsoluong
            // 
            this.txtsoluong.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsoluong.Location = new System.Drawing.Point(126, 114);
            this.txtsoluong.Name = "txtsoluong";
            this.txtsoluong.Size = new System.Drawing.Size(163, 24);
            this.txtsoluong.TabIndex = 2;
            this.txtsoluong.Text = "0";
            this.txtsoluong.TextChanged += new System.EventHandler(this.txtgia_giamgia_soluong_TextChanged);
            this.txtsoluong.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtgiamgia_soluong_KeyDown);
            // 
            // txtgiaban
            // 
            this.txtgiaban.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtgiaban.Location = new System.Drawing.Point(126, 86);
            this.txtgiaban.Name = "txtgiaban";
            this.txtgiaban.Size = new System.Drawing.Size(163, 24);
            this.txtgiaban.TabIndex = 2;
            this.txtgiaban.TextChanged += new System.EventHandler(this.txtgia_giamgia_soluong_TextChanged);
            // 
            // txttensp
            // 
            this.txttensp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttensp.Location = new System.Drawing.Point(126, 58);
            this.txttensp.Name = "txttensp";
            this.txttensp.Size = new System.Drawing.Size(163, 24);
            this.txttensp.TabIndex = 2;
            // 
            // cbomasp
            // 
            this.cbomasp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbomasp.FormattingEnabled = true;
            this.cbomasp.Location = new System.Drawing.Point(126, 21);
            this.cbomasp.Name = "cbomasp";
            this.cbomasp.Size = new System.Drawing.Size(163, 26);
            this.cbomasp.TabIndex = 1;
            this.cbomasp.DropDown += new System.EventHandler(this.cbomasp_DropDown);
            this.cbomasp.SelectedIndexChanged += new System.EventHandler(this.cbomasp_SelectedIndexChanged);
            // 
            // lblthanhtien
            // 
            this.lblthanhtien.AutoSize = true;
            this.lblthanhtien.Location = new System.Drawing.Point(7, 178);
            this.lblthanhtien.Name = "lblthanhtien";
            this.lblthanhtien.Size = new System.Drawing.Size(88, 16);
            this.lblthanhtien.TabIndex = 0;
            this.lblthanhtien.Text = "Thành tiền: ";
            // 
            // lblgiamgia
            // 
            this.lblgiamgia.AutoSize = true;
            this.lblgiamgia.Location = new System.Drawing.Point(12, 149);
            this.lblgiamgia.Name = "lblgiamgia";
            this.lblgiamgia.Size = new System.Drawing.Size(105, 16);
            this.lblgiamgia.TabIndex = 0;
            this.lblgiamgia.Text = "Giảm giá (%): ";
            // 
            // lblgiaban
            // 
            this.lblgiaban.AutoSize = true;
            this.lblgiaban.Location = new System.Drawing.Point(12, 91);
            this.lblgiaban.Name = "lblgiaban";
            this.lblgiaban.Size = new System.Drawing.Size(70, 16);
            this.lblgiaban.TabIndex = 0;
            this.lblgiaban.Text = "Giá bán: ";
            // 
            // lblSoluong
            // 
            this.lblSoluong.AutoSize = true;
            this.lblSoluong.Location = new System.Drawing.Point(13, 121);
            this.lblSoluong.Name = "lblSoluong";
            this.lblSoluong.Size = new System.Drawing.Size(77, 16);
            this.lblSoluong.TabIndex = 0;
            this.lblSoluong.Text = "Số lượng: ";
            // 
            // lbltensp
            // 
            this.lbltensp.AutoSize = true;
            this.lbltensp.Location = new System.Drawing.Point(12, 63);
            this.lbltensp.Name = "lbltensp";
            this.lbltensp.Size = new System.Drawing.Size(114, 16);
            this.lbltensp.TabIndex = 0;
            this.lbltensp.Text = "Tên sản phẩm: ";
            // 
            // lblmasp
            // 
            this.lblmasp.AutoSize = true;
            this.lblmasp.Location = new System.Drawing.Point(12, 31);
            this.lblmasp.Name = "lblmasp";
            this.lblmasp.Size = new System.Drawing.Size(108, 16);
            this.lblmasp.TabIndex = 0;
            this.lblmasp.Text = "Mã sản phẩm: ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Salmon;
            this.panel1.ForeColor = System.Drawing.Color.Salmon;
            this.panel1.Location = new System.Drawing.Point(152, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(785, 10);
            this.panel1.TabIndex = 9;
            // 
            // picbill
            // 
            this.picbill.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.picbill.BorderColor = System.Drawing.Color.OrangeRed;
            this.picbill.BorderColor2 = System.Drawing.Color.LawnGreen;
            this.picbill.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            this.picbill.BorderSize = 5;
            this.picbill.GradientAngle = 50F;
            this.picbill.Image = ((System.Drawing.Image)(resources.GetObject("picbill.Image")));
            this.picbill.Location = new System.Drawing.Point(5, -1);
            this.picbill.Name = "picbill";
            this.picbill.Size = new System.Drawing.Size(125, 125);
            this.picbill.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbill.TabIndex = 10;
            this.picbill.TabStop = false;
            // 
            // lblhoadonban
            // 
            this.lblhoadonban.AutoSize = true;
            this.lblhoadonban.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhoadonban.ForeColor = System.Drawing.Color.IndianRed;
            this.lblhoadonban.Location = new System.Drawing.Point(463, 9);
            this.lblhoadonban.Name = "lblhoadonban";
            this.lblhoadonban.Size = new System.Drawing.Size(183, 33);
            this.lblhoadonban.TabIndex = 11;
            this.lblhoadonban.Text = "HÓA ĐƠN BÁN";
            // 
            // lblcongtienhang
            // 
            this.lblcongtienhang.AutoSize = true;
            this.lblcongtienhang.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcongtienhang.ForeColor = System.Drawing.Color.IndianRed;
            this.lblcongtienhang.Location = new System.Drawing.Point(685, 329);
            this.lblcongtienhang.Name = "lblcongtienhang";
            this.lblcongtienhang.Size = new System.Drawing.Size(131, 18);
            this.lblcongtienhang.TabIndex = 12;
            this.lblcongtienhang.Text = "Cộng tiền hàng: ";
            // 
            // lblvat
            // 
            this.lblvat.AutoSize = true;
            this.lblvat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvat.ForeColor = System.Drawing.Color.IndianRed;
            this.lblvat.Location = new System.Drawing.Point(685, 358);
            this.lblvat.Name = "lblvat";
            this.lblvat.Size = new System.Drawing.Size(97, 18);
            this.lblvat.TabIndex = 12;
            this.lblvat.Text = "VAT (10%): ";
            // 
            // lbltongtien
            // 
            this.lbltongtien.AutoSize = true;
            this.lbltongtien.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltongtien.ForeColor = System.Drawing.Color.IndianRed;
            this.lbltongtien.Location = new System.Drawing.Point(685, 389);
            this.lbltongtien.Name = "lbltongtien";
            this.lbltongtien.Size = new System.Drawing.Size(88, 18);
            this.lbltongtien.TabIndex = 12;
            this.lbltongtien.Text = "Tổng tiền: ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Salmon;
            this.panel2.Location = new System.Drawing.Point(88, 518);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(849, 10);
            this.panel2.TabIndex = 14;
            // 
            // lblghichu
            // 
            this.lblghichu.AutoSize = true;
            this.lblghichu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblghichu.ForeColor = System.Drawing.Color.IndianRed;
            this.lblghichu.Location = new System.Drawing.Point(462, 294);
            this.lblghichu.Name = "lblghichu";
            this.lblghichu.Size = new System.Drawing.Size(76, 18);
            this.lblghichu.TabIndex = 12;
            this.lblghichu.Text = "Ghi chú: ";
            // 
            // txtghichu
            // 
            this.txtghichu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtghichu.Location = new System.Drawing.Point(535, 293);
            this.txtghichu.Name = "txtghichu";
            this.txtghichu.Size = new System.Drawing.Size(198, 24);
            this.txtghichu.TabIndex = 15;
            // 
            // txtcongtienhang
            // 
            this.txtcongtienhang.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcongtienhang.Location = new System.Drawing.Point(809, 325);
            this.txtcongtienhang.Name = "txtcongtienhang";
            this.txtcongtienhang.Size = new System.Drawing.Size(115, 24);
            this.txtcongtienhang.TabIndex = 16;
            this.txtcongtienhang.Text = "0.00";
            // 
            // txtVAT
            // 
            this.txtVAT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVAT.Location = new System.Drawing.Point(809, 357);
            this.txtVAT.Name = "txtVAT";
            this.txtVAT.Size = new System.Drawing.Size(115, 24);
            this.txtVAT.TabIndex = 16;
            this.txtVAT.Text = "0.00";
            // 
            // txttongtien
            // 
            this.txttongtien.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttongtien.Location = new System.Drawing.Point(809, 385);
            this.txttongtien.Name = "txttongtien";
            this.txttongtien.Size = new System.Drawing.Size(115, 24);
            this.txttongtien.TabIndex = 16;
            this.txttongtien.Text = "0.00";
            // 
            // dgvhoadonban
            // 
            this.dgvhoadonban.BackgroundColor = System.Drawing.Color.White;
            this.dgvhoadonban.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvhoadonban.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.masp,
            this.soluong,
            this.giaban,
            this.giamgia,
            this.thanhtien,
            this.ghi_chu});
            this.dgvhoadonban.Location = new System.Drawing.Point(414, 85);
            this.dgvhoadonban.Name = "dgvhoadonban";
            this.dgvhoadonban.Size = new System.Drawing.Size(545, 178);
            this.dgvhoadonban.TabIndex = 13;
            // 
            // masp
            // 
            this.masp.HeaderText = "Mã sản phẩm";
            this.masp.Name = "masp";
            // 
            // soluong
            // 
            this.soluong.HeaderText = "Số lượng";
            this.soluong.Name = "soluong";
            // 
            // giaban
            // 
            this.giaban.HeaderText = "Giá bán";
            this.giaban.Name = "giaban";
            // 
            // giamgia
            // 
            this.giamgia.HeaderText = "Giảm giá(%)";
            this.giamgia.Name = "giamgia";
            // 
            // thanhtien
            // 
            this.thanhtien.HeaderText = "Thành tiền";
            this.thanhtien.Name = "thanhtien";
            // 
            // ghi_chu
            // 
            this.ghi_chu.HeaderText = "Ghi chú";
            this.ghi_chu.Name = "ghi_chu";
            // 
            // FrmHoaDonBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(971, 542);
            this.ControlBox = false;
            this.Controls.Add(this.txttongtien);
            this.Controls.Add(this.txtVAT);
            this.Controls.Add(this.txtcongtienhang);
            this.Controls.Add(this.txtghichu);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgvhoadonban);
            this.Controls.Add(this.lblghichu);
            this.Controls.Add(this.lbltongtien);
            this.Controls.Add(this.lblvat);
            this.Controls.Add(this.lblcongtienhang);
            this.Controls.Add(this.lblhoadonban);
            this.Controls.Add(this.picbill);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grbsanpham);
            this.Controls.Add(this.grbhoadonban);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnThem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmHoaDonBan";
            this.Text = "FrmHoaDonBan";
            this.Load += new System.EventHandler(this.FrmHoaDonBan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hoadonbanBindingSource)).EndInit();
            this.grbhoadonban.ResumeLayout(false);
            this.grbhoadonban.PerformLayout();
            this.grbsanpham.ResumeLayout(false);
            this.grbsanpham.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvhoadonban)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CustomControls.RJControls.RJButton btnThem;
        private CustomControls.RJControls.RJButton btnLuu;
        private CustomControls.RJControls.RJButton btnXoa;
        private CustomControls.RJControls.RJButton btnThoat;
       // private qlbanhangDataSet2 qlbanhangDataSet2;
        private System.Windows.Forms.BindingSource hoadonbanBindingSource;
      //  private qlbanhangDataSet2TableAdapters.hoadonbanTableAdapter hoadonbanTableAdapter;
      //  private System.Windows.Forms.DataGridViewTextBoxColumn mahdbanDataGridViewTextBoxColumn;
       // private System.Windows.Forms.DataGridViewTextBoxColumn ngaybanDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn tongtienDataGridViewTextBoxColumn;
       // private System.Windows.Forms.DataGridViewTextBoxColumn manvDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox grbhoadonban;
        private System.Windows.Forms.ComboBox cbomanv;
        private System.Windows.Forms.DateTimePicker datengayban;
        private System.Windows.Forms.TextBox txttennv;
        private System.Windows.Forms.TextBox txtmahdon;
        private System.Windows.Forms.Label lbltennv;
        private System.Windows.Forms.Label lblmanv;
        private System.Windows.Forms.Label lblngayban;
        private System.Windows.Forms.Label lblmahoadon;
        private System.Windows.Forms.GroupBox grbsanpham;
        private System.Windows.Forms.Label lblgiaban;
        private System.Windows.Forms.Label lblSoluong;
        private System.Windows.Forms.Label lbltensp;
        private System.Windows.Forms.Label lblmasp;
        private System.Windows.Forms.Panel panel1;
        private CustomControls.RJControls.RJCircularPictureBox picbill;
        private System.Windows.Forms.Label lblhoadonban;
        private System.Windows.Forms.TextBox txtthanhtien;
        private System.Windows.Forms.TextBox txtgiamgia;
        private System.Windows.Forms.TextBox txtsoluong;
        private System.Windows.Forms.TextBox txtgiaban;
        private System.Windows.Forms.TextBox txttensp;
        private System.Windows.Forms.ComboBox cbomasp;
        private System.Windows.Forms.Label lblthanhtien;
        private System.Windows.Forms.Label lblgiamgia;
        private System.Windows.Forms.Label lblcongtienhang;
        private System.Windows.Forms.Label lblvat;
        private System.Windows.Forms.Label lbltongtien;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblghichu;
        private System.Windows.Forms.TextBox txtghichu;
        private System.Windows.Forms.TextBox txtcongtienhang;
        private System.Windows.Forms.TextBox txtVAT;
        private System.Windows.Forms.TextBox txttongtien;
        private System.Windows.Forms.DataGridView dgvhoadonban;
        private System.Windows.Forms.DataGridViewTextBoxColumn masp;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaban;
        private System.Windows.Forms.DataGridViewTextBoxColumn giamgia;
        private System.Windows.Forms.DataGridViewTextBoxColumn thanhtien;
        private System.Windows.Forms.DataGridViewTextBoxColumn ghi_chu;
    }
}