using System;
using System.IO;
using System.Globalization;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Lab_02
{
    public partial class Bai_3 : Form
    {
        public Bai_3()
        {
            InitializeComponent();
            btnTG.Enabled = false;
        }

        private void btnDoc_Click(object sender, EventArgs e)
        {
            string duongDan = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "input3.txt");

            try
            {
                using (StreamReader reader = new StreamReader(duongDan, Encoding.UTF8))
                {
                    rtbND.Text = reader.ReadToEnd();
                }
                rtbKQ.Clear();
                btnTG.Enabled = true;
            }
            catch (Exception ex)
            {
                btnTG.Enabled = false;
                MessageBox.Show("Không đọc được file:\n" + ex.Message);
            }
        }

        private void btnTG_Click(object sender, EventArgs e)
        {
            string duongDan = Path.Combine( AppDomain.CurrentDomain.BaseDirectory, "output3.txt");

            try
            {
                StringBuilder ketQua = new StringBuilder();

                using (StringReader reader = new StringReader(rtbND.Text))
                {
                    string dong;

                    while ((dong = reader.ReadLine()) != null)
                    {
                        // Bỏ qua dòng trống.
                        if (string.IsNullOrWhiteSpace(dong))
                        {
                            continue;
                        }

                        string bieuThuc = dong.Trim();

                        try
                        {
                            TinhBieuThuc boTinh = new TinhBieuThuc(bieuThuc);

                            double giaTri = boTinh.Tinh();

                            ketQua.AppendLine( bieuThuc + " = " +  giaTri.ToString(CultureInfo.InvariantCulture));
                        }
                        catch (Exception loiDong)
                        {
                            ketQua.AppendLine( bieuThuc + " = Lỗi: " + loiDong.Message);
                        }
                    }
                }

                using (StreamWriter writer =  new StreamWriter(duongDan, false, Encoding.UTF8))
                {
                    writer.Write(ketQua.ToString());
                }

                rtbKQ.Text = ketQua.ToString();

                MessageBox.Show( "Đã xử lý và ghi kết quả tại:\n" + duongDan);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không xử lý được file:\n" + ex.Message);
            }
        }
    }
}
