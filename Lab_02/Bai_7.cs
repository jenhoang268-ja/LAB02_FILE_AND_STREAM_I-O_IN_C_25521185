using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace Lab_02
{
    public partial class Bai_7 : Form
    {
        public Bai_7()
        {
            InitializeComponent();
            tvThumuc.BeforeExpand += tvThumuc_BeforeExpand;
            tvThumuc.NodeMouseDoubleClick +=
                tvThumuc_NodeMouseDoubleClick;
            tvThumuc.AfterSelect += tvThumuc_AfterSelect;

            TaiOCung();
        }
        private void TaiOCung()
        {
            tvThumuc.Nodes.Clear();

            foreach (DriveInfo oDia in DriveInfo.GetDrives())
            {
                TreeNode nut = new TreeNode(oDia.Name);

                // Tag lưu đường dẫn
                nut.Tag = oDia.RootDirectory.FullName;

                // Nút tạm giúp hiển thị dấu + để mở.
                nut.Nodes.Add(new TreeNode("Đang chờ tải..."));

                tvThumuc.Nodes.Add(nut);
            }
        }

        private void TaiThuMuc(TreeNode nut)
        {
            string duongDan = nut.Tag as string;

            if (string.IsNullOrEmpty(duongDan))
                return;

            // Chỉ tải khi nút còn chứa nút tạm.
            // Các nút dữ liệu thật đều có Tag.
            if (nut.Nodes.Count != 1 ||
                nut.Nodes[0].Tag != null)
            {
                return;
            }

            try
            {
                // Đọc trước, nếu lỗi thì giữ nút tạm để thử lại.
                string[] thuMucCon =
                    Directory.GetDirectories(duongDan);

                string[] cacFile =  Directory.GetFiles(duongDan);

                Array.Sort(  thuMucCon, StringComparer.OrdinalIgnoreCase);

                Array.Sort(cacFile, StringComparer.OrdinalIgnoreCase);

                nut.Nodes.Clear();

                // Thêm các thư mục con.
                foreach (string thuMuc in thuMucCon)
                {
                    TreeNode nutCon = new TreeNode(
                        Path.GetFileName(thuMuc));

                    nutCon.Tag = thuMuc;

                    nutCon.Nodes.Add(  new TreeNode("Đang chờ tải..."));

                    nut.Nodes.Add(nutCon);
                }

                // Thêm các file.
                foreach (string file in cacFile)
                {
                    TreeNode nutFile = new TreeNode(
                        Path.GetFileName(file));

                    nutFile.Tag = file;

                    nut.Nodes.Add(nutFile);
                }
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show(
                    "Bạn không có quyền truy cập thư mục này.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Không mở được thư mục:\n" + ex.Message);
            }
        }

        // Khi nhấn dấu +, tải nội dung trước khi mở nút.
        private void tvThumuc_BeforeExpand(
            object sender, TreeViewCancelEventArgs e)
        {
            TaiThuMuc(e.Node);
        }

        private void tvThumuc_NodeMouseDoubleClick(
           object sender, TreeNodeMouseClickEventArgs e)
        {
            string duongDan = e.Node.Tag as string;

            if (string.IsNullOrEmpty(duongDan))
                return;

            if (Directory.Exists(duongDan))
            {
                // Expand sẽ kích hoạt BeforeExpand.
                e.Node.Expand();
            }
        }

        private void tvThumuc_AfterSelect(
         object sender, TreeViewEventArgs e)
        {
            XoaNoiDung();

            string duongDan = e.Node.Tag as string;

            if (string.IsNullOrEmpty(duongDan))
                return;

            // Chọn thư mục thì chưa cần xem nội dung file.
            if (!File.Exists(duongDan))
                return;

            grpContent.Text = "Nội dung file: " + Path.GetFileName(duongDan);

            string duoiFile = Path.GetExtension(duongDan).ToLowerInvariant();

            try
            {
                switch (duoiFile)
                {
                    // Các định dạng ảnh.
                    case ".jpg":
                    case ".jpeg":
                    case ".png":
                    case ".bmp":
                    case ".gif":
                    case ".ico":
                        HienThiAnh(duongDan);
                        break;

                    // Các định dạng văn bản.
                    case ".txt":
                    case ".csv":
                    case ".log":
                    case ".cs":
                    case ".json":
                    case ".xml":
                    case ".html":
                    case ".css":
                    case ".js":
                    case ".sql":
                    case ".md":
                    case ".ini":
                        HienThiVanBan(duongDan);
                        break;

                    default:
                        HienThiThongBao(
                            "Chưa hỗ trợ xem trước loại file "
                            + duoiFile
                            + ".\n\nĐường dẫn:\n"
                            + duongDan);
                        break;
                }
            }
            catch (Exception ex)
            {
                HienThiThongBao(
                    "Không đọc được file:\n" + ex.Message);
            }
        }

        private void HienThiAnh(string duongDan)
        {
            // Tạo bản sao để không khóa file ảnh gốc.
            using (Image anhGoc = Image.FromFile(duongDan))
            {
                picND.Image = new Bitmap(anhGoc);
            }

            rtbND.Visible = false;
            picND.Visible = true;
            picND.BringToFront();
        }

        private void HienThiVanBan(string duongDan)
        {
            FileInfo thongTin = new FileInfo(duongDan);

            // Giới hạn xem trước để tránh đọc file quá lớn.
            if (thongTin.Length > 2 * 1024 * 1024)
            {
                HienThiThongBao( "File lớn hơn 2 MB, không xem trước văn bản.");
                return;
            }

            string noiDung = File.ReadAllText(duongDan, Encoding.UTF8);

            HienThiThongBao(noiDung);
        }

        private void HienThiThongBao(string noiDung)
        {
            rtbND.Text = noiDung;

            picND.Visible = false;
            rtbND.Visible = true;
            rtbND.BringToFront();
        }

        private void XoaNoiDung()
        {
            Image anhCu = picND.Image;
            picND.Image = null;

            if (anhCu != null)
                anhCu.Dispose();

            rtbND.Clear();

            picND.Visible = false;
            rtbND.Visible = false;

        }

        protected override void OnFormClosed(
            FormClosedEventArgs e)
        {
            XoaNoiDung();

            base.OnFormClosed(e);
        }
        private void Bai_7_Load(object sender, EventArgs e)
        {

        }
    }
}

   
