namespace Lab_02
{
    public partial class Lab02 : Form
    {
        public Lab02()
        {
            InitializeComponent();
        }

        private void Lab02_Load(object sender, EventArgs e)
        {

        }

        private void btnBai1_Click(object sender, EventArgs e)
        {
            using (Bai_1 form = new Bai_1())
            {
                form.ShowDialog(this);
            }
        }

        private void btnBai2_Click(object sender, EventArgs e)
        {
            using (Bai_2 form = new Bai_2())
            {
                form.ShowDialog(this);
            }
        }

        private void btnBai3_Click(object sender, EventArgs e)
        {
            using (Bai_3 form = new Bai_3())
            {
                form.ShowDialog(this);
            }
        }

        private void btnBai4_Click(object sender, EventArgs e)
        {
            using (Bai_4 form = new Bai_4())
            {
                form.ShowDialog(this);
            }
        }

        private void btnBai5_Click(object sender, EventArgs e)
        {
            using (Bai_5 form = new Bai_5())
            {
                form.ShowDialog(this);
            }
        }

        private void btnBai6_Click(object sender, EventArgs e)
        {
            using (Bai_6 form = new Bai_6())
            {
                form.ShowDialog(this);
            }
        }

        private void btnBai7_Click(object sender, EventArgs e)
        {
            using (Bai_7 form = new Bai_7())
            {
                form.ShowDialog(this);
            }
        }
    }
}
