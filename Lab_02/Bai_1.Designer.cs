namespace Lab_02
{
    partial class Bai_1
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
            btnDoc = new Button();
            btnGhi = new Button();
            rtbKQ = new RichTextBox();
            SuspendLayout();
            // 
            // btnDoc
            // 
            btnDoc.BackColor = Color.FromArgb(225, 240, 252);
            btnDoc.Font = new Font("Times New Roman", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDoc.ForeColor = Color.FromArgb(30, 75, 110);
            btnDoc.Location = new Point(51, 68);
            btnDoc.Name = "btnDoc";
            btnDoc.Size = new Size(324, 140);
            btnDoc.TabIndex = 0;
            btnDoc.Text = "ĐỌC FILE";
            btnDoc.UseVisualStyleBackColor = false;
            btnDoc.Click += btnDoc_Click;
            // 
            // btnGhi
            // 
            btnGhi.BackColor = Color.FromArgb(225, 240, 252);
            btnGhi.Font = new Font("Times New Roman", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGhi.ForeColor = Color.FromArgb(30, 75, 110);
            btnGhi.Location = new Point(51, 236);
            btnGhi.Name = "btnGhi";
            btnGhi.Size = new Size(324, 140);
            btnGhi.TabIndex = 1;
            btnGhi.Text = "GHI FILE";
            btnGhi.UseVisualStyleBackColor = false;
            btnGhi.Click += btnGhi_Click;
            // 
            // rtbKQ
            // 
            rtbKQ.Location = new Point(413, 12);
            rtbKQ.Name = "rtbKQ";
            rtbKQ.ReadOnly = true;
            rtbKQ.Size = new Size(696, 640);
            rtbKQ.TabIndex = 2;
            rtbKQ.Text = "";
            // 
            // Bai_1
            // 
            AutoScaleDimensions = new SizeF(18F, 36F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Nền_xanh_với_cụm_thư_mục;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1290, 664);
            Controls.Add(rtbKQ);
            Controls.Add(btnGhi);
            Controls.Add(btnDoc);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Bai_1";
            Text = "Bài 1";
            Load += Bai_1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnDoc;
        private Button btnGhi;
        private RichTextBox rtbKQ;
    }
}