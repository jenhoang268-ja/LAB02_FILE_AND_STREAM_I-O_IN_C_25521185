using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab_02
{
    public partial class Bai_6 : Form
    {
        private readonly string duongDanDB = Path.Combine(
        AppDomain.CurrentDomain.BaseDirectory,
         "homnayangi.db");
        private byte[] anhDangChon = null;
        public Bai_6()
        {
            InitializeComponent();
            KhoiTaoGiaoDien();

            try
            {
                TaoCoSoDuLieu();
                HienThiDanhSach();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Không khởi tạo được dữ liệu:\n" + ex.Message);
            }
        }

        private void KhoiTaoGiaoDien()
        {
            txtAnh.ReadOnly = true;
            txtKQ.ReadOnly = true;
            txtNguoidg.ReadOnly = true;

            lvMonan.FullRowSelect = true;
            lvMonan.MultiSelect = false;
            lvMonan.HideSelection = false;
            lvMonan.Sorting = SortOrder.None;

            XoaKetQua();
        }

        private SQLiteConnection MoKetNoi()
        {
            SQLiteConnectionStringBuilder builder =
                new SQLiteConnectionStringBuilder();

            builder.DataSource = duongDanDB;
            builder.Version = 3;

            SQLiteConnection ketNoi =
                new SQLiteConnection(builder.ConnectionString);

            try
            {
                ketNoi.Open();

                using (SQLiteCommand lenh = new SQLiteCommand(
                    "PRAGMA foreign_keys = ON;", ketNoi))
                {
                    lenh.ExecuteNonQuery();
                }

                return ketNoi;
            }
            catch
            {
                ketNoi.Dispose();
                throw;
            }
        }

        private void TaoCoSoDuLieu()
        {
            using (SQLiteConnection ketNoi = MoKetNoi())
            {
                string sqlNguoiDung = @"
                    CREATE TABLE IF NOT EXISTS NguoiDung
                    (
                        IDNCC INTEGER PRIMARY KEY AUTOINCREMENT,
                        HoVaTen TEXT NOT NULL,
                        QuyenHan TEXT NOT NULL
                    );";

                using (SQLiteCommand lenh =
                    new SQLiteCommand(sqlNguoiDung, ketNoi))
                {
                    lenh.ExecuteNonQuery();
                }

                string sqlMonAn = @"
                    CREATE TABLE IF NOT EXISTS MonAn
                    (
                        IDMA INTEGER PRIMARY KEY AUTOINCREMENT,
                        TenMonAn TEXT NOT NULL,
                        HinhAnh BLOB NOT NULL,
                        IDNCC INTEGER NOT NULL,

                        FOREIGN KEY (IDNCC)
                            REFERENCES NguoiDung(IDNCC)
                    );";

                using (SQLiteCommand lenh =
                    new SQLiteCommand(sqlMonAn, ketNoi))
                {
                    lenh.ExecuteNonQuery();
                }
            }
        }

        private Bitmap TaoBitmap(byte[] duLieu)
        {
            using (MemoryStream stream = new MemoryStream(duLieu))
            using (Image anh = Image.FromStream(stream))
            {
                // Tạo bản sao để ảnh vẫn dùng được khi đóng stream.
                return new Bitmap(anh);
            }
        }

        private void HienThiAnh(Bitmap anhMoi)
        {
            Image anhCu = picMonAn.Image;
            picMonAn.Image = anhMoi;

            if (anhCu != null)
                anhCu.Dispose();
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog hopThoai = new OpenFileDialog())
            {
                hopThoai.Title = "Chọn ảnh món ăn";

                hopThoai.Filter =
                    "Ảnh (*.jpg;*.jpeg;*.png;*.bmp)|"
                    + "*.jpg;*.jpeg;*.png;*.bmp";

                if (hopThoai.ShowDialog() != DialogResult.OK)
                    return;

                try
                {
                    byte[] duLieuAnh =
                        File.ReadAllBytes(hopThoai.FileName);

                    Bitmap anhMoi = TaoBitmap(duLieuAnh);

                    anhDangChon = duLieuAnh;
                    txtAnh.Text = hopThoai.FileName;

                    XoaKetQua();
                    HienThiAnh(anhMoi);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Không đọc được ảnh:\n" + ex.Message);
                }
            }
        }

        private void HienThiDanhSach()
        {
            using (SQLiteConnection ketNoi = MoKetNoi())
            {
                string sql = @"
                    SELECT m.IDMA, m.TenMonAn, n.HoVaTen
                    FROM MonAn AS m
                    INNER JOIN NguoiDung AS n
                        ON m.IDNCC = n.IDNCC
                    ORDER BY m.IDMA;";

                using (SQLiteCommand lenh =
                    new SQLiteCommand(sql, ketNoi))
                using (SQLiteDataReader reader =
                    lenh.ExecuteReader())
                {
                    lvMonan.BeginUpdate();

                    try
                    {
                        lvMonan.Items.Clear();

                        int soThuTu = 1;

                        while (reader.Read())
                        {
                            ListViewItem dong =
                                new ListViewItem(soThuTu.ToString());

                            dong.SubItems.Add(reader["TenMonAn"].ToString());
                            dong.SubItems.Add(reader["HoVaTen"].ToString());

                            // Mã lưu nội bộ để tìm và xóa đúng món.
                            dong.Tag = Convert.ToInt64(reader["IDMA"]);

                            lvMonan.Items.Add(dong);

                            soThuTu++;
                        }
                    }
                    finally
                    {
                        lvMonan.EndUpdate();
                    }
                }
            }
        }

        private void XoaKetQua()
        {
            txtKQ.Clear();
            txtNguoidg.Clear();

            HienThiAnh(null);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string tenMon = txtTenMon.Text.Trim();
            string hoTen = txtNguoi.Text.Trim();

            if (tenMon == "")
            {
                MessageBox.Show("Vui lòng nhập tên món ăn.");
                txtTenMon.Focus();
                return;
            }

            if (hoTen == "")
            {
                MessageBox.Show(
                    "Vui lòng nhập tên người đóng góp.");

                txtNguoi.Focus();
                return;
            }

            if (anhDangChon == null)
            {
                MessageBox.Show("Vui lòng chọn ảnh món ăn.");
                return;
            }

            try
            {
                using (SQLiteConnection ketNoi = MoKetNoi())
                using (SQLiteTransaction giaoDich =
                    ketNoi.BeginTransaction())
                {
                    // Thêm người đóng góp vào bảng NguoiDung.
                    string sqlNguoiDung = @"
                        INSERT INTO NguoiDung (HoVaTen, QuyenHan)
                        VALUES (@hoTen, @quyenHan);";

                    using (SQLiteCommand lenh =
                        new SQLiteCommand(sqlNguoiDung, ketNoi))
                    {
                        lenh.Transaction = giaoDich;

                        lenh.Parameters.AddWithValue(
                            "@hoTen", hoTen);

                        lenh.Parameters.AddWithValue(
                            "@quyenHan", "Người dùng");

                        lenh.ExecuteNonQuery();
                    }

                    long idNguoi = ketNoi.LastInsertRowId;

                    // Thêm món và liên kết với người vừa thêm.
                    string sqlMonAn = @"
                        INSERT INTO MonAn
                            (TenMonAn, HinhAnh, IDNCC)
                        VALUES
                            (@tenMon, @anh, @idNguoi);";

                    using (SQLiteCommand lenh =
                        new SQLiteCommand(sqlMonAn, ketNoi))
                    {
                        lenh.Transaction = giaoDich;

                        lenh.Parameters.AddWithValue(
                            "@tenMon", tenMon);

                        lenh.Parameters.Add(
                            "@anh", DbType.Binary).Value =
                                anhDangChon;

                        lenh.Parameters.AddWithValue(
                            "@idNguoi", idNguoi);

                        lenh.ExecuteNonQuery();
                    }

                    // Chỉ xác nhận khi cả hai bước đều thành công.
                    giaoDich.Commit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Không thêm được món ăn:\n" + ex.Message);
                return;
            }

            txtTenMon.Clear();
            txtNguoi.Clear();
            txtAnh.Clear();
            anhDangChon = null;

            XoaKetQua();

            try
            {
                HienThiDanhSach();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Đã lưu món ăn nhưng chưa tải lại được "
                    + "danh sách:\n" + ex.Message);
                return;
            }

            txtTenMon.Focus();

            MessageBox.Show("Đã thêm món ăn thành công.");
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            try
            {
                using (SQLiteConnection ketNoi = MoKetNoi())
                {
                    string sql = @"
                        SELECT m.IDMA,
                               m.TenMonAn,
                               m.HinhAnh,
                               n.HoVaTen
                        FROM MonAn AS m
                        INNER JOIN NguoiDung AS n
                            ON m.IDNCC = n.IDNCC
                        ORDER BY RANDOM()
                        LIMIT 1;";

                    using (SQLiteCommand lenh =
                        new SQLiteCommand(sql, ketNoi))
                    using (SQLiteDataReader reader =
                        lenh.ExecuteReader())
                    {
                        if (!reader.Read())
                        {
                            XoaKetQua();

                            MessageBox.Show(
                                "Danh sách trống. "
                                + "Vui lòng thêm món ăn.");
                            return;
                        }

                        long id = Convert.ToInt64(
                            reader["IDMA"]);

                        byte[] duLieuAnh =
                            (byte[])reader["HinhAnh"];

                        Bitmap anhMoi = TaoBitmap(duLieuAnh);

                        txtKQ.Text =
                            reader["TenMonAn"].ToString();

                        txtNguoidg.Text =
                            reader["HoVaTen"].ToString();

                        HienThiAnh(anhMoi);

                        // Đánh dấu món được chọn trong danh sách.
                        foreach (ListViewItem dong in lvMonan.Items)
                        {
                            bool duocChon =
                                Convert.ToInt64(dong.Tag) == id;

                            dong.Selected = duocChon;

                            if (duocChon)
                            {
                                dong.Focused = true;
                                dong.EnsureVisible();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Không tìm được món ăn:\n" + ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lvMonan.SelectedItems.Count == 0)
            {
                MessageBox.Show(
                    "Hãy chọn một món trong danh sách để xóa.");
                return;
            }

            ListViewItem dong = lvMonan.SelectedItems[0];

            long id = Convert.ToInt64(dong.Tag);
            string tenMon = dong.SubItems[1].Text;

            DialogResult traLoi = MessageBox.Show(
                "Bạn có muốn xóa món \"" + tenMon + "\" không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo);

            if (traLoi != DialogResult.Yes)
                return;

            try
            {
                using (SQLiteConnection ketNoi = MoKetNoi())
                {
                    string sql = @"
                        DELETE FROM MonAn
                        WHERE IDMA = @id;";

                    using (SQLiteCommand lenh =
                        new SQLiteCommand(sql, ketNoi))
                    {
                        lenh.Parameters.AddWithValue("@id", id);
                        lenh.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Không xóa được món ăn:\n" + ex.Message);
                return;
            }

            XoaKetQua();

            try
            {
                HienThiDanhSach();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Đã xóa món nhưng chưa tải lại được "
                    + "danh sách:\n" + ex.Message);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        protected override void OnFormClosed(
            FormClosedEventArgs e)
        {
            HienThiAnh(null);

            base.OnFormClosed(e);
        }

    }
}
