using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_02
{
    public partial class Bai_5 : Form
    {
        private string phim_dang_chon = "";
        private int phong_dang_chon = 0;

        private Dictionary<string, decimal> gia_phim = new Dictionary<string, decimal>();

        private Dictionary<string, int[]> phong_phim = new Dictionary<string, int[]>();

        private readonly Dictionary<string, decimal> so_ghe =
            new Dictionary<string, decimal>()
            {
                { "A1", 0.25m },
                { "A2", 1m },
                { "A3", 1m },
                { "A4", 1m },
                { "A5", 0.25m },

                { "B1", 1m },
                { "B2", 2m },
                { "B3", 2m },
                { "B4", 2m },
                { "B5", 1m },

                { "C1", 0.25m },
                { "C2", 1m },
                { "C3", 1m },
                { "C4", 1m },
                { "C5", 0.25m }
            };

        private Dictionary<string, Button> nut_ghe;

        private readonly HashSet<string> ghe_dang_chon = new HashSet<string>();
        private readonly Dictionary<string, HashSet<string>>
            ghe_da_mua =
               new Dictionary<string, HashSet<string>>();

        private readonly Dictionary<string, decimal> doanh_thu =
            new Dictionary<string, decimal>();

        private readonly CultureInfo nuoc =
            CultureInfo.GetCultureInfo("vi-VN");

        private readonly string fileInput = Path.Combine(
            AppDomain.CurrentDomain.BaseDirectory,
            "input5.txt");

        private readonly string fileOutput = Path.Combine(
            AppDomain.CurrentDomain.BaseDirectory,
            "output5.txt");

        private bool dangXuatFile = false;

        public Bai_5()
        {
            InitializeComponent();
            KhoiTaoGiaoDien();
        }
        private void KhoiTaoGiaoDien()
        {
            txtPhim.ReadOnly = true;
            txtPhim.Clear();

            nut_ghe = new Dictionary<string, Button>()
            {
                { "A1", A1 },
                { "A2", A2 },
                { "A3", A3 },
                { "A4", A4 },
                { "A5", A5 },

                { "B1", B1 },
                { "B2", B2 },
                { "B3", B3 },
                { "B4", B4 },
                { "B5", B5 },

                { "C1", C1 },
                { "C2", C2 },
                { "C3", C3 },
                { "C4", C4 },
                { "C5", C5 }
            };

            foreach (KeyValuePair<string, Button> ghe in nut_ghe)
            {
                ghe.Value.Tag = ghe.Key;
                ghe.Value.UseVisualStyleBackColor = false;
                ghe.Value.ForeColor = Color.Black;

                // 15 nút ghế dùng chung một sự kiện.
                ghe.Value.Click += Ghe_Click;
            }

            cPhong1.UseVisualStyleBackColor = false;
            cPhong2.UseVisualStyleBackColor = false;
            cPhong3.UseVisualStyleBackColor = false;

            dgvTK.AutoGenerateColumns = true;
            dgvTK.ReadOnly = true;
            dgvTK.AllowUserToAddRows = false;
            dgvTK.AllowUserToDeleteRows = false;
            dgvTK.RowHeadersVisible = false;

            dgvTK.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            prgXuatFile.Minimum = 0;
            prgXuatFile.Maximum = 100;
            prgXuatFile.Value = 0;
            prgXuatFile.Style = ProgressBarStyle.Continuous;

            lblTienDo.Text = "0%";
            if (string.IsNullOrWhiteSpace(rtbCHP.Text))
            {
                rtbCHP.Text = string.Join(
                    Environment.NewLine,
                    new string[]
                    {
                        "Đào, phở và piano",
                        "45000",
                        "1,2,3",
                        "Mai",
                        "100000",
                        "2,3",
                        "Gặp lại chị bầu",
                        "70000",
                        "1",
                        "Tarot",
                        "90000",
                        "3"
                    });
            }

            CapNhatPhong();
            CapNhatGhe();
        }
        private Color MauGhe(string tenGhe)
        {
            if (so_ghe[tenGhe] == 0.25m)
                return Color.LightSkyBlue;

            if (so_ghe[tenGhe] == 2m)
                return Color.Gold;

            return Color.WhiteSmoke;
        }

        private string LayMaPhong()
        {
            return phim_dang_chon + "|" + phong_dang_chon;
        }

        private bool DaBanVe()
        {
            return ghe_da_mua.Values.Any(ds => ds.Count > 0);
        }

        private void CapNhatPhong()
        {
            Button[] cacNut =
            {
                cPhong1,
                cPhong2,
                cPhong3
            };

            for (int i = 0; i < cacNut.Length; i++)
            {
                int soPhong = i + 1;

                bool hopLe =
                    phong_phim.ContainsKey(phim_dang_chon)
                    && phong_phim[phim_dang_chon]
                        .Contains(soPhong);

                cacNut[i].Enabled = hopLe && !dangXuatFile;

                cacNut[i].BackColor =
                    phong_dang_chon == soPhong
                    ? Color.LightSkyBlue
                    : SystemColors.Control;
            }
        }

        private void CapNhatGhe()
        {
            bool daChonPhong =
                phim_dang_chon != ""
                && phong_dang_chon != 0;

            string maPhong = daChonPhong
                ? LayMaPhong()
                : "";

            foreach (KeyValuePair<string, Button> ghe in nut_ghe)
            {
                string tenGhe = ghe.Key;
                Button nut = ghe.Value;

                nut.Visible = daChonPhong;

                bool daMua =
                    daChonPhong
                    && ghe_da_mua.ContainsKey(maPhong)
                    && ghe_da_mua[maPhong].Contains(tenGhe);

                nut.Enabled =
                    daChonPhong
                    && !daMua
                    && !dangXuatFile;

                if (daMua)
                    nut.BackColor = Color.Gray;
                else if (ghe_dang_chon.Contains(tenGhe))
                    nut.BackColor = Color.LightGreen;
                else
                    nut.BackColor = MauGhe(tenGhe);
            }

            thanhtoan.Enabled =
                daChonPhong
                && ghe_dang_chon.Count > 0
                && !dangXuatFile;
        }

        private void PhanTichCauHinh(
           string noiDung,
           out Dictionary<string, decimal> giaMoi,
           out Dictionary<string, int[]> phongMoi)
        {
            giaMoi = new Dictionary<string, decimal>();
            phongMoi = new Dictionary<string, int[]>();

            List<string> cacDong = new List<string>();

            using (StringReader reader = new StringReader(noiDung))
            {
                string dong;

                while ((dong = reader.ReadLine()) != null)
                {
                    cacDong.Add(dong.Trim());
                }
            }

            // Cho phép dòng trống ở cuối file.
            while (cacDong.Count > 0
                && cacDong[cacDong.Count - 1] == "")
            {
                cacDong.RemoveAt(cacDong.Count - 1);
            }

            if (cacDong.Count == 0 || cacDong.Count % 3 != 0)
            {
                throw new Exception(
                    "Mỗi phim phải có đúng 3 dòng:\n"
                    + "Tên phim\nGiá vé chuẩn\nPhòng chiếu");
            }

            // Giao diện hiện tại có bốn nút chọn poster này.
            string[] tenPhimHopLe =
            {
                "Đào, phở và piano",
                "Mai",
                "Gặp lại chị bầu",
                "Tarot"
            };

            for (int i = 0; i < cacDong.Count; i += 3)
            {
                string ten = cacDong[i];

                if (!tenPhimHopLe.Contains(ten))
                {
                    throw new Exception(
                        "Tên phim chưa khớp với poster:\n" + ten);
                }

                if (giaMoi.ContainsKey(ten))
                {
                    throw new Exception("Phim bị trùng: " + ten);
                }

                decimal gia;

                if (!decimal.TryParse(
                    cacDong[i + 1],
                    NumberStyles.AllowDecimalPoint,
                    CultureInfo.InvariantCulture,
                    out gia) || gia <= 0)
                {
                    throw new Exception(
                        "Giá phim " + ten
                        + " phải là số dương, ví dụ 45000.");
                }

                List<int> cacPhong = new List<int>();

                foreach (string chuoi in cacDong[i + 2].Split(','))
                {
                    int phong;

                    if (!int.TryParse(chuoi.Trim(), out phong)
                        || phong < 1 || phong > 3)
                    {
                        throw new Exception(
                            "Phòng của phim " + ten
                            + " chỉ được là 1, 2 hoặc 3.");
                    }

                    if (cacPhong.Contains(phong))
                    {
                        throw new Exception(
                            "Phòng bị trùng trong phim: " + ten);
                    }

                    cacPhong.Add(phong);
                }

                giaMoi.Add(ten, gia);
                phongMoi.Add(ten, cacPhong.ToArray());
            }
        }

        private void btnGhi_Click(object sender, EventArgs e)
        {
            if (dangXuatFile)
                return;

            try
            {
                if (DaBanVe())
                {
                    MessageBox.Show(
                        "Đã bán vé. Không thay đổi cấu hình "
                        + "trong phiên này.");
                    return;
                }

                Dictionary<string, decimal> giaMoi;
                Dictionary<string, int[]> phongMoi;

                PhanTichCauHinh(
                    rtbCHP.Text, out giaMoi, out phongMoi);

                File.WriteAllText(
                    fileInput, rtbCHP.Text, Encoding.UTF8);

                MessageBox.Show(
                    "Đã ghi file:\n" + fileInput
                    + "\n\nBấm ĐỌC INPUT5 để áp dụng.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không ghi được file:\n" + ex.Message);
            }
        }

        private void btnDoc_Click_1(object sender, EventArgs e)
        {
            if (dangXuatFile)
                return;

            try
            {
                if (DaBanVe())
                {
                    MessageBox.Show(
                        "Đã bán vé. Không nạp lại cấu hình "
                        + "trong phiên này.");
                    return;
                }

                string noiDung =
                    File.ReadAllText(fileInput, Encoding.UTF8);

                Dictionary<string, decimal> giaMoi;
                Dictionary<string, int[]> phongMoi;

                PhanTichCauHinh(
                    noiDung, out giaMoi, out phongMoi);

                // Chỉ thay dữ liệu sau khi kiểm tra thành công.
                gia_phim = giaMoi;
                phong_phim = phongMoi;

                ghe_da_mua.Clear();
                doanh_thu.Clear();
                ghe_dang_chon.Clear();

                phim_dang_chon = "";
                phong_dang_chon = 0;

                txtPhim.Clear();
                rtbCHP.Text = noiDung;

                CapNhatPhong();
                CapNhatGhe();

                dgvTK.DataSource = null;
                prgXuatFile.Value = 0;
                lblTienDo.Text = "0%";

                MessageBox.Show("Đã đọc thông tin phim thành công.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không đọc được file:\n" + ex.Message);
            }
        }
        private void chon_phim(string tenPhim)
        {
            if (dangXuatFile)
                return;

            if (!gia_phim.ContainsKey(tenPhim))
            {
                MessageBox.Show(
                    "Chưa có dữ liệu phim này.\n"
                    + "Hãy ghi và đọc input5.txt trước.");
                return;
            }

            phim_dang_chon = tenPhim;
            phong_dang_chon = 0;

            ghe_dang_chon.Clear();
            txtPhim.Text = tenPhim;

            CapNhatPhong();
            CapNhatGhe();
        }

        private void chonDao_Click_1(object sender, EventArgs e)
        {
            chon_phim("Đào, phở và piano");
        }

        private void chonMai_Click_1(object sender, EventArgs e)
        {
            chon_phim("Mai");
        }

        private void chonChi_Click_1(object sender, EventArgs e)
        {
            chon_phim("Gặp lại chị bầu");
        }

        private void chonTarot_Click_1(object sender, EventArgs e)
        {
            chon_phim("Tarot");
        }
        private void chon_phong(int soPhong)
        {
            if (dangXuatFile || phim_dang_chon == "")
                return;

            if (!phong_phim[phim_dang_chon].Contains(soPhong))
                return;

            if (phong_dang_chon == soPhong)
                return;

            phong_dang_chon = soPhong;

            ghe_dang_chon.Clear();

            string maPhong = LayMaPhong();

            if (!ghe_da_mua.ContainsKey(maPhong))
            {
                ghe_da_mua.Add(
                    maPhong, new HashSet<string>());
            }

            CapNhatPhong();
            CapNhatGhe();
        }

        private void cPhong1_Click_1(object sender, EventArgs e)
        {
            chon_phong(1);
        }

        private void cPhong2_Click(object sender, EventArgs e)
        {
            chon_phong(2);
        }

        private void cPhong3_Click(object sender, EventArgs e)
        {
            chon_phong(3);
        }
        private void Ghe_Click(object sender, EventArgs e)
        {
            if (dangXuatFile || phong_dang_chon == 0)
                return;

            Button nut = sender as Button;

            if (nut == null || nut.Tag == null)
                return;

            string tenGhe = nut.Tag.ToString();
            string maPhong = LayMaPhong();

            if (ghe_da_mua[maPhong].Contains(tenGhe))
                return;

            if (ghe_dang_chon.Contains(tenGhe))
            {
                ghe_dang_chon.Remove(tenGhe);
            }
            else
            {
                ghe_dang_chon.Add(tenGhe);
            }

            CapNhatGhe();
        }

        private void thanhtoan_Click(object sender, EventArgs e)
        {
            if (dangXuatFile)
                return;

            try
            {
                string hoTen = txtTen.Text.Trim();

                if (hoTen == "")
                {
                    MessageBox.Show("Vui lòng nhập tên khách hàng.");
                    txtTen.Focus();
                    return;
                }

                if (phim_dang_chon == "" || phong_dang_chon == 0)
                {
                    MessageBox.Show("Hãy chọn phim và phòng chiếu.");
                    return;
                }

                if (ghe_dang_chon.Count == 0)
                {
                    MessageBox.Show("Hãy chọn ít nhất một ghế.");
                    return;
                }

                string maPhong = LayMaPhong();

                List<string> danhSachGhe =
                    ghe_dang_chon.OrderBy(g => g).ToList();

                decimal tongTien = 0;
                StringBuilder chiTiet = new StringBuilder();

                foreach (string ghe in danhSachGhe)
                {
                    if (ghe_da_mua[maPhong].Contains(ghe))
                    {
                        MessageBox.Show("Ghế " + ghe + " đã được mua.");
                        return;
                    }

                    decimal tienVe = checked(
                        gia_phim[phim_dang_chon] * so_ghe[ghe]);

                    tongTien = checked(tongTien + tienVe);

                    string loaiVe = so_ghe[ghe] == 0.25m
                        ? "Vé vớt"
                        : so_ghe[ghe] == 2m
                            ? "Vé VIP"
                            : "Vé thường";

                    chiTiet.AppendLine(
                        ghe + " - " + loaiVe + ": "
                        + tienVe.ToString("N0", nuoc) + " đồng");
                }

                decimal doanhThuCu =
                    doanh_thu.ContainsKey(phim_dang_chon)
                    ? doanh_thu[phim_dang_chon] : 0;

                decimal doanhThuMoi =
                    checked(doanhThuCu + tongTien);

                string thongTin =
                    "Khách hàng: " + hoTen
                    + Environment.NewLine
                    + "Phim: " + phim_dang_chon
                    + Environment.NewLine
                    + "Phòng: " + phong_dang_chon
                    + Environment.NewLine
                    + "Ghế: " + string.Join(", ", danhSachGhe)
                    + Environment.NewLine
                    + Environment.NewLine
                    + chiTiet.ToString()
                    + Environment.NewLine
                    + "TỔNG TIỀN: "
                    + tongTien.ToString("N0", nuoc) + " đồng"
                    + Environment.NewLine
                    + "Xác nhận thanh toán?";

                DialogResult traLoi = MessageBox.Show(
                thongTin,
                "THANH TOÁN",
                MessageBoxButtons.YesNo);

                if (traLoi != DialogResult.Yes)
                    return;

                // Chỉ ghi nhận sau khi xác nhận thanh toán.
                foreach (string ghe in danhSachGhe)
                {
                    ghe_da_mua[maPhong].Add(ghe);
                }

                doanh_thu[phim_dang_chon] = doanhThuMoi;

                ghe_dang_chon.Clear();
                CapNhatGhe();

                MessageBox.Show("Thanh toán thành công.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Không thanh toán được:\n" + ex.Message);
            }
        }

        private DataTable TaoThongKe()
        {
            DataTable bang = new DataTable();

            bang.Columns.Add("XepHang", typeof(int));
            bang.Columns.Add("TenPhim", typeof(string));
            bang.Columns.Add("VeDaBan", typeof(int));
            bang.Columns.Add("VeTon", typeof(int));
            bang.Columns.Add("TyLeBan", typeof(double));
            bang.Columns.Add("DoanhThu", typeof(decimal));

            foreach (string tenPhim in gia_phim.Keys)
            {
                int tongVe =
                    phong_phim[tenPhim].Length * so_ghe.Count;

                int veBan = 0;

                foreach (int phong in phong_phim[tenPhim])
                {
                    string ma = tenPhim + "|" + phong;

                    if (ghe_da_mua.ContainsKey(ma))
                        veBan += ghe_da_mua[ma].Count;
                }

                double tyLe = tongVe > 0
                    ? veBan * 100.0 / tongVe : 0;

                decimal tien =
                    doanh_thu.ContainsKey(tenPhim)
                    ? doanh_thu[tenPhim] : 0;

                bang.Rows.Add(
                    0, tenPhim, veBan,
                    tongVe - veBan, tyLe, tien);
            }

            // Sắp doanh thu từ cao xuống thấp.
            DataView view = new DataView(bang);
            view.Sort = "DoanhThu DESC, TenPhim ASC";

            DataTable ketQua = view.ToTable();

            for (int i = 0; i < ketQua.Rows.Count; i++)
            {
                ketQua.Rows[i]["XepHang"] = i + 1;
            }

            return ketQua;
        }

        private void HienThiThongKe(DataTable bang)
        {
            dgvTK.DataSource = bang;

            dgvTK.Columns["XepHang"].HeaderText = "Hạng";
            dgvTK.Columns["TenPhim"].HeaderText = "Tên phim";
            dgvTK.Columns["VeDaBan"].HeaderText = "Vé đã bán";
            dgvTK.Columns["VeTon"].HeaderText = "Vé tồn";
            dgvTK.Columns["TyLeBan"].HeaderText = "Tỷ lệ bán (%)";
            dgvTK.Columns["DoanhThu"].HeaderText = "Doanh thu (đồng)";

            dgvTK.Columns["TyLeBan"]
                .DefaultCellStyle.Format = "0.00";

            dgvTK.Columns["DoanhThu"]
                .DefaultCellStyle.Format = "N0";

            dgvTK.Columns["DoanhThu"]
                .DefaultCellStyle.FormatProvider = nuoc;

            dgvTK.Columns["TenPhim"].FillWeight = 200;

            foreach (DataGridViewColumn cot in dgvTK.Columns)
            {
                cot.SortMode =
                    DataGridViewColumnSortMode.NotSortable;
            }
        }

        private void btnTK_Click_1(object sender, EventArgs e)
        {
            if (dangXuatFile)
                return;

            if (gia_phim.Count == 0)
            {
                MessageBox.Show("Hãy đọc input5.txt trước.");
                return;
            }

            HienThiThongKe(TaoThongKe());
        }

        private void DatTrangThaiXuat(bool dangXuat)
        {
            dangXuatFile = dangXuat;

            btnGhi.Enabled = !dangXuat;
            btnDoc.Enabled = !dangXuat;
            btnTK.Enabled = !dangXuat;
            btnXuat.Enabled = !dangXuat;

            rtbCHP.ReadOnly = dangXuat;

            CapNhatPhong();
            CapNhatGhe();
        }

        protected override void OnFormClosing(
            FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (dangXuatFile)
            {
                e.Cancel = true;
                MessageBox.Show("Vui lòng chờ xuất file hoàn tất.");
            }
        }

        private async void btnXuat_Click_1(
            object sender, EventArgs e)
        {
            if (dangXuatFile)
                return;

            if (gia_phim.Count == 0)
            {
                MessageBox.Show("Hãy đọc input5.txt trước.");
                return;
            }

            DatTrangThaiXuat(true);

            prgXuatFile.Value = 0;
            lblTienDo.Text = "0%";

            try
            {
                DataTable bang = TaoThongKe();

                using (StreamWriter writer =
                    new StreamWriter(fileOutput, false, Encoding.UTF8))
                {
                    await writer.WriteLineAsync(
                        "THỐNG KÊ PHÒNG VÉ");

                    await writer.WriteLineAsync();

                    for (int i = 0; i < bang.Rows.Count; i++)
                    {
                        DataRow dong = bang.Rows[i];

                        string noiDung =
                            "Xếp hạng: " + dong["XepHang"]
                            + Environment.NewLine
                            + "Tên phim: " + dong["TenPhim"]
                            + Environment.NewLine
                            + "Vé đã bán: " + dong["VeDaBan"]
                            + Environment.NewLine
                            + "Vé tồn: " + dong["VeTon"]
                            + Environment.NewLine
                            + "Tỷ lệ bán: "
                            + ((double)dong["TyLeBan"])
                                .ToString("0.00", nuoc) + "%"
                            + Environment.NewLine
                            + "Doanh thu: "
                            + ((decimal)dong["DoanhThu"])
                                .ToString("N0", nuoc) + " đồng"
                            + Environment.NewLine
                            + "--------------------------------";

                        await writer.WriteLineAsync(noiDung);
                        await writer.FlushAsync();

                        int phanTram = (i + 1) * 100 / bang.Rows.Count;

                        await CapNhatTienDo(Math.Min(phanTram, 99));
                    }
                }

                await CapNhatTienDo(100);
                prgXuatFile.Maximum = 100;

                HienThiThongKe(bang);

                MessageBox.Show(
                    "Đã xuất thống kê tại:\n" + fileOutput);
            }
            catch (Exception ex)
            {
                lblTienDo.Text = "Xuất thất bại";

                MessageBox.Show(
                    "Không xuất được file:\n" + ex.Message);
            }
            finally
            {
                DatTrangThaiXuat(false);
            }
        }

        private async Task CapNhatTienDo(int mucTieu)
        {
            while (prgXuatFile.Value < mucTieu)
            {
                int phanTram = prgXuatFile.Value + 1;

                // Giúp thanh cập nhật ngay, tránh hiệu ứng chạy trễ.
                prgXuatFile.Maximum = 101;
                prgXuatFile.Value = phanTram + 1;
                prgXuatFile.Value = phanTram;

                lblTienDo.Text = phanTram + "%";

                // Cho giao diện hiển thị từng bước.
                await Task.Delay(20);
            }
        }

        private void Bai_5_Load(object sender, EventArgs e)
        {

        }
    }
}
