namespace Lab_02
{
    partial class Bai_3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bai_3));
            btnDoc = new Button();
            btnTG = new Button();
            label1 = new Label();
            label2 = new Label();
            rtbND = new RichTextBox();
            rtbKQ = new RichTextBox();
            SuspendLayout();
            // 
            // btnDoc
            // 
            btnDoc.BackColor = Color.FromArgb(205, 235, 252);
            btnDoc.Cursor = Cursors.Hand;
            btnDoc.FlatAppearance.BorderColor = Color.FromArgb(130, 195, 230);
            btnDoc.FlatAppearance.MouseDownBackColor = Color.FromArgb(160, 210, 240);
            btnDoc.FlatAppearance.MouseOverBackColor = Color.FromArgb(185, 225, 248);
            btnDoc.FlatStyle = FlatStyle.Flat;
            btnDoc.Font = new Font("Times New Roman", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDoc.ForeColor = Color.FromArgb(25, 75, 115);
            btnDoc.Location = new Point(145, 28);
            btnDoc.Name = "btnDoc";
            btnDoc.Size = new Size(542, 118);
            btnDoc.TabIndex = 0;
            btnDoc.Text = "ĐỌC FILE";
            btnDoc.UseVisualStyleBackColor = false;
            btnDoc.Click += btnDoc_Click;
            // 
            // btnTG
            // 
            btnTG.BackColor = Color.FromArgb(165, 225, 248);
            btnTG.Cursor = Cursors.Hand;
            btnTG.FlatAppearance.BorderColor = Color.FromArgb(95, 185, 225);
            btnTG.FlatAppearance.MouseDownBackColor = Color.FromArgb(115, 195, 230);
            btnTG.FlatAppearance.MouseOverBackColor = Color.FromArgb(140, 210, 240);
            btnTG.FlatStyle = FlatStyle.Flat;
            btnTG.Font = new Font("Times New Roman", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTG.ForeColor = Color.FromArgb(15, 65, 105);
            btnTG.Location = new Point(895, 28);
            btnTG.Name = "btnTG";
            btnTG.Size = new Size(542, 118);
            btnTG.TabIndex = 1;
            btnTG.Text = "TÍNH VÀ GHI FILE";
            btnTG.UseVisualStyleBackColor = false;
            btnTG.Click += btnTG_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 13.875F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(25, 85, 125);
            label1.Location = new Point(35, 158);
            label1.Name = "label1";
            label1.Size = new Size(295, 43);
            label1.TabIndex = 2;
            label1.Text = "Nội dung đầu vào";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Times New Roman", 13.875F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(25, 85, 125);
            label2.Location = new Point(783, 158);
            label2.Name = "label2";
            label2.Size = new Size(138, 43);
            label2.TabIndex = 3;
            label2.Text = "Kết quả";
            // 
            // rtbND
            // 
            rtbND.BackColor = Color.FromArgb(245, 251, 255);
            rtbND.BorderStyle = BorderStyle.FixedSingle;
            rtbND.Font = new Font("Times New Roman", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rtbND.ForeColor = Color.FromArgb(25, 65, 100);
            rtbND.Location = new Point(35, 218);
            rtbND.Name = "rtbND";
            rtbND.ReadOnly = true;
            rtbND.Size = new Size(722, 628);
            rtbND.TabIndex = 4;
            rtbND.Text = "";
            // 
            // rtbKQ
            // 
            rtbKQ.BackColor = Color.FromArgb(235, 250, 255);
            rtbKQ.BorderStyle = BorderStyle.FixedSingle;
            rtbKQ.Font = new Font("Times New Roman", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rtbKQ.ForeColor = Color.FromArgb(15, 80, 110);
            rtbKQ.Location = new Point(783, 218);
            rtbKQ.Name = "rtbKQ";
            rtbKQ.ReadOnly = true;
            rtbKQ.Size = new Size(754, 628);
            rtbKQ.TabIndex = 5;
            rtbKQ.Text = "";
            // 
            // Bai_3
            // 
            AutoScaleDimensions = new SizeF(18F, 36F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1578, 896);
            Controls.Add(rtbKQ);
            Controls.Add(rtbND);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnTG);
            Controls.Add(btnDoc);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Bai_3";
            Text = "Bài 3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDoc;
        private Button btnTG;
        private Label label1;
        private Label label2;
        private RichTextBox rtbND;
        private RichTextBox rtbKQ;
    }
}