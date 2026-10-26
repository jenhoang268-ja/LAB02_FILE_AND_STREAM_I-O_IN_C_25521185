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
    public partial class Bai_1 : Form
    {
        public Bai_1()
        {
            InitializeComponent();
            btnGhi.Enabled = false;
        }

        private void Bai_1_Load(object sender, EventArgs e)
        {

        }

        private void btnDoc_Click(object sender, EventArgs e)
        {
            string duongdanDoc = Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory, "input1.txt"
                );
            try
            {
                using (StreamReader reader = new StreamReader(duongdanDoc, Encoding.UTF8))
                {
                    rtbKQ.Text = reader.ReadToEnd();
                }
                btnGhi.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không đọc được file: " + ex.Message);
            }
        }

        private void btnGhi_Click(object sender, EventArgs e)
        {
            string duongdanGhi = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "output1.txt");
            try
            {
                string noidungInHoa = rtbKQ.Text.ToUpper();
                using (StreamWriter writer = new StreamWriter(duongdanGhi, false, Encoding.UTF8) )
                {
                    writer.Write(noidungInHoa);
                }
                MessageBox.Show("Đã ghi file tại: \n" + duongdanGhi);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không ghi được file: " + ex.Message);
            }
        }
    }
}
