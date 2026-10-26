using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Lab_02
{
    public partial class Bai_2 : Form
    {
        public Bai_2()
        {
            InitializeComponent();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Chọn file văn bản";
                ofd.Filter = "Text files (*.txt)|*.txt";
                ofd.CheckFileExists = true;
                ofd.Multiselect = false;

                if (ofd.ShowDialog() != DialogResult.OK)
                {
                    return;
                }

                try
                {
                    string noiDung;

                    using (StreamReader reader = new StreamReader(ofd.FileName, Encoding.UTF8))
                    {
                        noiDung = reader.ReadToEnd();
                    }

                    FileInfo thongTinFile = new FileInfo(ofd.FileName);
                    int soDong = 0;

                    using (StringReader readerDong = new StringReader(noiDung))
                    {
                        while (readerDong.ReadLine() != null)
                        {
                            soDong++;
                        }
                    }

                    int soTu = Regex.Matches(noiDung, @"\S+").Count;
                    int soKyTu = noiDung.Length;

                    // Hiển thị kết quả.
                    txtTen.Text = ofd.SafeFileName;
                    txtSize.Text = thongTinFile.Length + " bytes";
                    txtLink.Text = thongTinFile.FullName;
                    txtLc.Text = soDong.ToString();
                    txtWc.Text = soTu.ToString();
                    txtCharc.Text = soKyTu.ToString();

                    rtbKQ.Text = noiDung;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Không thể đọc file:\n" + ex.Message,
                        "Lỗi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void rtbKQ_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
