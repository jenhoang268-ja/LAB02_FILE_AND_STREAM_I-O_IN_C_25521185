namespace Lab_02
{
    partial class Bai_6
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
            lblthem = new Label();
            lbltenmon = new Label();
            lblNguoi = new Label();
            lblAnh = new Label();
            txtTenMon = new TextBox();
            txtNguoi = new TextBox();
            txtAnh = new TextBox();
            btnChonAnh = new Button();
            btnThem = new Button();
            lblDanhsach = new Label();
            lvMonan = new ListView();
            colSTT = new ColumnHeader();
            colTenmon = new ColumnHeader();
            colNguoidg = new ColumnHeader();
            btnTim = new Button();
            btnXoa = new Button();
            btnThoat = new Button();
            lblKQ = new Label();
            txtKQ = new TextBox();
            lblNguoidg = new Label();
            txtNguoidg = new TextBox();
            picMonAn = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picMonAn).BeginInit();
            SuspendLayout();
            // 
            // lblthem
            // 
            lblthem.AutoSize = true;
            lblthem.BackColor = Color.Transparent;
            lblthem.Font = new Font("Times New Roman", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblthem.ForeColor = Color.FromArgb(90, 45, 20);
            lblthem.Location = new Point(136, 85);
            lblthem.Name = "lblthem";
            lblthem.Size = new Size(343, 49);
            lblthem.TabIndex = 0;
            lblthem.Text = "THÊM MÓN ĂN";
            // 
            // lbltenmon
            // 
            lbltenmon.AutoSize = true;
            lbltenmon.BackColor = Color.Transparent;
            lbltenmon.Font = new Font("Times New Roman", 13.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbltenmon.ForeColor = Color.SaddleBrown;
            lbltenmon.Location = new Point(41, 169);
            lbltenmon.Name = "lbltenmon";
            lbltenmon.Size = new Size(194, 40);
            lbltenmon.TabIndex = 1;
            lbltenmon.Text = "Tên món ăn";
            // 
            // lblNguoi
            // 
            lblNguoi.AutoSize = true;
            lblNguoi.BackColor = Color.Transparent;
            lblNguoi.Font = new Font("Times New Roman", 13.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNguoi.ForeColor = Color.SaddleBrown;
            lblNguoi.Location = new Point(41, 264);
            lblNguoi.Name = "lblNguoi";
            lblNguoi.Size = new Size(256, 40);
            lblNguoi.TabIndex = 2;
            lblNguoi.Text = "Người đóng góp";
            // 
            // lblAnh
            // 
            lblAnh.AutoSize = true;
            lblAnh.BackColor = Color.Transparent;
            lblAnh.Font = new Font("Times New Roman", 13.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAnh.ForeColor = Color.SaddleBrown;
            lblAnh.Location = new Point(41, 381);
            lblAnh.Name = "lblAnh";
            lblAnh.Size = new Size(166, 40);
            lblAnh.TabIndex = 3;
            lblAnh.Text = "Hình ảnh ";
            // 
            // txtTenMon
            // 
            txtTenMon.Font = new Font("Times New Roman", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTenMon.Location = new Point(313, 165);
            txtTenMon.Name = "txtTenMon";
            txtTenMon.Size = new Size(626, 50);
            txtTenMon.TabIndex = 4;
            // 
            // txtNguoi
            // 
            txtNguoi.BackColor = Color.White;
            txtNguoi.Font = new Font("Times New Roman", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNguoi.ForeColor = Color.Black;
            txtNguoi.Location = new Point(313, 264);
            txtNguoi.Name = "txtNguoi";
            txtNguoi.Size = new Size(626, 50);
            txtNguoi.TabIndex = 5;
            // 
            // txtAnh
            // 
            txtAnh.BackColor = Color.White;
            txtAnh.Font = new Font("Times New Roman", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAnh.ForeColor = Color.Black;
            txtAnh.Location = new Point(313, 377);
            txtAnh.Name = "txtAnh";
            txtAnh.ReadOnly = true;
            txtAnh.Size = new Size(396, 50);
            txtAnh.TabIndex = 6;
            // 
            // btnChonAnh
            // 
            btnChonAnh.BackColor = Color.PeachPuff;
            btnChonAnh.Font = new Font("Times New Roman", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnChonAnh.ForeColor = Color.FromArgb(90, 45, 20);
            btnChonAnh.Location = new Point(737, 355);
            btnChonAnh.Name = "btnChonAnh";
            btnChonAnh.Size = new Size(202, 72);
            btnChonAnh.TabIndex = 7;
            btnChonAnh.Text = "CHỌN ẢNH";
            btnChonAnh.UseVisualStyleBackColor = false;
            btnChonAnh.Click += btnChonAnh_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.PeachPuff;
            btnThem.Font = new Font("Times New Roman", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThem.ForeColor = Color.FromArgb(90, 45, 20);
            btnThem.Location = new Point(199, 462);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(594, 80);
            btnThem.TabIndex = 8;
            btnThem.Text = "THÊM MÓN";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // lblDanhsach
            // 
            lblDanhsach.AutoSize = true;
            lblDanhsach.BackColor = Color.Transparent;
            lblDanhsach.Font = new Font("Times New Roman", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDanhsach.ForeColor = Color.FromArgb(90, 45, 20);
            lblDanhsach.Location = new Point(1069, 40);
            lblDanhsach.Name = "lblDanhsach";
            lblDanhsach.Size = new Size(467, 49);
            lblDanhsach.TabIndex = 9;
            lblDanhsach.Text = "DANH SÁCH MÓN ĂN";
            // 
            // lvMonan
            // 
            lvMonan.BackColor = Color.White;
            lvMonan.Columns.AddRange(new ColumnHeader[] { colSTT, colTenmon, colNguoidg });
            lvMonan.ForeColor = Color.Black;
            lvMonan.FullRowSelect = true;
            lvMonan.GridLines = true;
            lvMonan.Location = new Point(1013, 101);
            lvMonan.MultiSelect = false;
            lvMonan.Name = "lvMonan";
            lvMonan.Size = new Size(882, 457);
            lvMonan.TabIndex = 10;
            lvMonan.UseCompatibleStateImageBehavior = false;
            lvMonan.View = View.Details;
            // 
            // colSTT
            // 
            colSTT.Text = "Số thứ tự";
            colSTT.Width = 150;
            // 
            // colTenmon
            // 
            colTenmon.Text = "Tên món ăn";
            colTenmon.TextAlign = HorizontalAlignment.Center;
            colTenmon.Width = 380;
            // 
            // colNguoidg
            // 
            colNguoidg.Text = "Người đóng góp";
            colNguoidg.TextAlign = HorizontalAlignment.Center;
            colNguoidg.Width = 348;
            // 
            // btnTim
            // 
            btnTim.BackColor = Color.FromArgb(205, 220, 160);
            btnTim.Font = new Font("Times New Roman", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTim.Location = new Point(1013, 574);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(292, 94);
            btnTim.TabIndex = 11;
            btnTim.Text = "TÌM MÓN ĂN";
            btnTim.UseVisualStyleBackColor = false;
            btnTim.Click += btnTim_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.FromArgb(205, 220, 160);
            btnXoa.Font = new Font("Times New Roman", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXoa.Location = new Point(1323, 574);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(292, 94);
            btnXoa.TabIndex = 12;
            btnXoa.Text = "XÓA MÓN ĂN";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.FromArgb(205, 220, 160);
            btnThoat.Font = new Font("Times New Roman", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThoat.Location = new Point(1637, 577);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(258, 91);
            btnThoat.TabIndex = 13;
            btnThoat.Text = "THOÁT";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // lblKQ
            // 
            lblKQ.AutoSize = true;
            lblKQ.BackColor = Color.Transparent;
            lblKQ.Font = new Font("Times New Roman", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblKQ.ForeColor = Color.FromArgb(90, 45, 20);
            lblKQ.Location = new Point(983, 682);
            lblKQ.Name = "lblKQ";
            lblKQ.Size = new Size(477, 45);
            lblKQ.TabIndex = 14;
            lblKQ.Text = "MÓN ĂN HÔM NAY LÀ: ";
            // 
            // txtKQ
            // 
            txtKQ.BackColor = Color.White;
            txtKQ.Font = new Font("Times New Roman", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtKQ.ForeColor = Color.DarkGreen;
            txtKQ.Location = new Point(1089, 740);
            txtKQ.Multiline = true;
            txtKQ.Name = "txtKQ";
            txtKQ.ReadOnly = true;
            txtKQ.Size = new Size(752, 102);
            txtKQ.TabIndex = 15;
            txtKQ.TextAlign = HorizontalAlignment.Center;
            // 
            // lblNguoidg
            // 
            lblNguoidg.AutoSize = true;
            lblNguoidg.BackColor = Color.Transparent;
            lblNguoidg.Font = new Font("Times New Roman", 13.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNguoidg.Location = new Point(1069, 866);
            lblNguoidg.Name = "lblNguoidg";
            lblNguoidg.Size = new Size(268, 40);
            lblNguoidg.TabIndex = 16;
            lblNguoidg.Text = "Người đóng góp:";
            // 
            // txtNguoidg
            // 
            txtNguoidg.BackColor = Color.White;
            txtNguoidg.Font = new Font("Times New Roman", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNguoidg.ForeColor = Color.DarkGreen;
            txtNguoidg.Location = new Point(1375, 861);
            txtNguoidg.Name = "txtNguoidg";
            txtNguoidg.ReadOnly = true;
            txtNguoidg.Size = new Size(490, 50);
            txtNguoidg.TabIndex = 17;
            // 
            // picMonAn
            // 
            picMonAn.BackColor = Color.Transparent;
            picMonAn.BackgroundImageLayout = ImageLayout.None;
            picMonAn.BorderStyle = BorderStyle.FixedSingle;
            picMonAn.Location = new Point(165, 559);
            picMonAn.Name = "picMonAn";
            picMonAn.Size = new Size(666, 352);
            picMonAn.SizeMode = PictureBoxSizeMode.StretchImage;
            picMonAn.TabIndex = 18;
            picMonAn.TabStop = false;
            // 
            // Bai_6
            // 
            AutoScaleDimensions = new SizeF(18F, 36F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.Nền_kem_món_Việt_bốn_góc1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1932, 938);
            Controls.Add(picMonAn);
            Controls.Add(txtNguoidg);
            Controls.Add(lblNguoidg);
            Controls.Add(txtKQ);
            Controls.Add(lblKQ);
            Controls.Add(btnThoat);
            Controls.Add(btnXoa);
            Controls.Add(btnTim);
            Controls.Add(lvMonan);
            Controls.Add(lblDanhsach);
            Controls.Add(btnThem);
            Controls.Add(btnChonAnh);
            Controls.Add(txtAnh);
            Controls.Add(txtNguoi);
            Controls.Add(txtTenMon);
            Controls.Add(lblAnh);
            Controls.Add(lblNguoi);
            Controls.Add(lbltenmon);
            Controls.Add(lblthem);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.Black;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Bai_6";
            Text = "Bài 6";
            ((System.ComponentModel.ISupportInitialize)picMonAn).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblthem;
        private Label lbltenmon;
        private Label lblNguoi;
        private Label lblAnh;
        private TextBox txtTenMon;
        private TextBox txtNguoi;
        private TextBox txtAnh;
        private Button btnChonAnh;
        private Button btnThem;
        private Label lblDanhsach;
        private ListView lvMonan;
        private ColumnHeader colSTT;
        private ColumnHeader colTenmon;
        private ColumnHeader colNguoidg;
        private Button btnTim;
        private Button btnXoa;
        private Button btnThoat;
        private Label lblKQ;
        private TextBox txtKQ;
        private Label lblNguoidg;
        private TextBox txtNguoidg;
        private PictureBox picMonAn;
    }
}