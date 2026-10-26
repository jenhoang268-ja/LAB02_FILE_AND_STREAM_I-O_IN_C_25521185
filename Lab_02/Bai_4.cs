using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Text.RegularExpressions; 
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.Unicode;
using System.Text.Encodings.Web;

namespace Lab_02
{
    public partial class Bai_4 : Form
    {
        private List<SinhVien> danhSachNhap = new List<SinhVien>();
        private List<SinhVien> danhSachDoc = new List<SinhVien>();

        private int viTri = 0;

        private readonly string fileInput = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "input4.txt");

        private readonly string fileOutput = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "output4.txt");
        public Bai_4()
        {
            InitializeComponent();
            btnBack.Enabled = false;
            btnNext.Enabled = false;
            lblTrang.Text = "0/0";
        }

        private bool DiemHopLe(float diem)
        {
            return !float.IsNaN(diem)
                && !float.IsInfinity(diem)
                && diem >= 0
                && diem <= 10;
        }

        // Kiểm tra
        private void KiemTraSinhVien(SinhVien sv)
        {
            if (sv == null)
                throw new Exception("Dữ liệu sinh viên không hợp lệ.");

            if (string.IsNullOrWhiteSpace(sv.Name))
                throw new Exception("Họ tên không được để trống.");

            if (sv.MSSV < 10000000 || sv.MSSV > 99999999)
                throw new Exception("MSSV phải là số có đúng 8 chữ số.");

            if (!Regex.IsMatch(sv.Phone ?? "", @"^0[0-9]{9}$"))
                throw new Exception(
                    "Điện thoại phải có 10 chữ số và bắt đầu bằng 0.");

            if (!DiemHopLe(sv.Mon1)
                || !DiemHopLe(sv.Mon2)
                || !DiemHopLe(sv.Mon3))
            {
                throw new Exception("Điểm mỗi môn phải từ 0 đến 10.");
            }
        }

        private void Bai_4_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string ma = txtmssv.Text.Trim();

                if (!Regex.IsMatch(ma, @"^[1-9][0-9]{7}$"))
                {
                    throw new Exception(
                        "MSSV phải có đúng 8 chữ số, không bắt đầu bằng 0.");
                }

                SinhVien sv = new SinhVien
                {
                    Name = txtTen.Text.Trim(),
                    MSSV = int.Parse(ma),
                    Phone = txtPhone.Text.Trim(),

                    Mon1 = (float)nudMon1.Value,
                    Mon2 = (float)nudMon2.Value,
                    Mon3 = (float)nudMon3.Value
                };

                KiemTraSinhVien(sv);

                if (danhSachNhap.Any(x => x.MSSV == sv.MSSV))
                {
                    throw new Exception("MSSV này đã có trong danh sách.");
                }

                danhSachNhap.Add(sv);

                rtbDanhSach.AppendText(
                    $"Họ tên: {sv.Name}\n" +
                    $"MSSV: {sv.MSSV}\n" +
                    $"Điện thoại: {sv.Phone}\n" +
                    $"Điểm: {sv.Mon1}; {sv.Mon2}; {sv.Mon3}\n\n");

                txtTen.Clear();
                txtmssv.Clear();
                txtPhone.Clear();

                nudMon1.Value = 0;
                nudMon2.Value = 0;
                nudMon3.Value = 0;

                txtTen.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Kiểm tra dữ liệu");
            }
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            try
            {
                if (danhSachNhap.Count == 0)
                {
                    MessageBox.Show("Hãy thêm ít nhất một sinh viên.");
                    return;
                }

                JsonSerializerOptions tuyChon = new JsonSerializerOptions
                {
                    WriteIndented = true,
                    Encoder = JavaScriptEncoder.Create(UnicodeRanges.All)
                };

                string json = JsonSerializer.Serialize(danhSachNhap.ToArray(), tuyChon);

                File.WriteAllText(fileInput, json, Encoding.UTF8);

                MessageBox.Show("Đã ghi danh sách vào:\n" + fileInput);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không ghi được file:\n" + ex.Message);
            }
        }

        private void HienThiSinhVien()
        {
            if (danhSachDoc.Count == 0)
            {
                lblTrang.Text = "0/0";
                btnBack.Enabled = false;
                btnNext.Enabled = false;
                return;
            }

            SinhVien sv = danhSachDoc[viTri];

            txtNameDoc.Text = sv.Name;
            txtmssvDoc.Text = sv.MSSV.ToString();
            txtPhoneDoc.Text = sv.Phone;

            txtDocM1.Text = sv.Mon1.ToString("0.##");
            txtDocM2.Text = sv.Mon2.ToString("0.##");
            txtDocM3.Text = sv.Mon3.ToString("0.##");

            txtTB.Text = sv.DiemTrungBinh.ToString("0.00");

            lblTrang.Text = $"{viTri + 1}/{danhSachDoc.Count}";

            btnBack.Enabled = viTri > 0;
            btnNext.Enabled = viTri < danhSachDoc.Count - 1;
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            try
            {
                string json = File.ReadAllText(fileInput, Encoding.UTF8);

                SinhVien[] mang = JsonSerializer.Deserialize<SinhVien[]>(json)
                    ?? throw new Exception("File không có mảng sinh viên hợp lệ.");

                if (mang.Length == 0)
                {
                    MessageBox.Show("Danh sách trong file đang rỗng.");
                    return;
                }

                HashSet<int> cacMa = new HashSet<int>();

                foreach (SinhVien sv in mang)
                {
                    KiemTraSinhVien(sv);

                    if (!cacMa.Add(sv.MSSV))
                    {
                        throw new Exception("File có MSSV bị trùng: " + sv.MSSV);
                    }

                    sv.DiemTrungBinh = (sv.Mon1 + sv.Mon2 + sv.Mon3) / 3f;
                }

                string jsonKetQua = JsonSerializer.Serialize(
                mang,
                new JsonSerializerOptions
                {
                WriteIndented = true,
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.All)
                });

                File.WriteAllText(fileOutput, jsonKetQua, Encoding.UTF8);

                danhSachDoc = mang.ToList();
                viTri = 0;

                HienThiSinhVien();

                MessageBox.Show(
                    "Đã tính điểm trung bình và ghi vào:\n" + fileOutput);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không xử lý được dữ liệu:\n" + ex.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (viTri > 0)
            {
                viTri--;
                HienThiSinhVien();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (viTri < danhSachDoc.Count - 1)
            {
                viTri++;
                HienThiSinhVien();
            }
        }
    }
}
