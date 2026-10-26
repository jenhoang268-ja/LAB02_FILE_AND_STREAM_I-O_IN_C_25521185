namespace Lab_02
{
    partial class Bai_2
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
            btnRead = new Button();
            btnExit = new Button();
            rtbKQ = new RichTextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtTen = new TextBox();
            txtSize = new TextBox();
            txtLink = new TextBox();
            txtLc = new TextBox();
            txtWc = new TextBox();
            txtCharc = new TextBox();
            SuspendLayout();
            // 
            // btnRead
            // 
            btnRead.BackColor = Color.FromArgb(195, 225, 247);
            btnRead.Cursor = Cursors.Hand;
            btnRead.FlatAppearance.BorderColor = Color.FromArgb(155, 195, 225);
            btnRead.FlatAppearance.MouseDownBackColor = Color.FromArgb(180, 215, 242);
            btnRead.FlatAppearance.MouseOverBackColor = Color.FromArgb(160, 200, 232);
            btnRead.FlatStyle = FlatStyle.Flat;
            btnRead.Font = new Font("Times New Roman", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRead.ForeColor = Color.FromArgb(35, 80, 120);
            btnRead.Location = new Point(71, 30);
            btnRead.Name = "btnRead";
            btnRead.Size = new Size(888, 86);
            btnRead.TabIndex = 0;
            btnRead.Text = "Read from File";
            btnRead.UseVisualStyleBackColor = false;
            btnRead.Click += btnRead_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(225, 240, 252);
            btnExit.Cursor = Cursors.Hand;
            btnExit.FlatAppearance.BorderColor = Color.FromArgb(165, 205, 235);
            btnExit.FlatAppearance.MouseDownBackColor = Color.FromArgb(205, 230, 250);
            btnExit.FlatAppearance.MouseOverBackColor = Color.FromArgb(180, 215, 242);
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Times New Roman", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.FromArgb(35, 80, 120);
            btnExit.Location = new Point(69, 718);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(888, 124);
            btnExit.TabIndex = 1;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // rtbKQ
            // 
            rtbKQ.Location = new Point(1025, 12);
            rtbKQ.Name = "rtbKQ";
            rtbKQ.ReadOnly = true;
            rtbKQ.Size = new Size(1010, 846);
            rtbKQ.TabIndex = 2;
            rtbKQ.Text = "";
            rtbKQ.TextChanged += rtbKQ_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(69, 162);
            label1.Name = "label1";
            label1.Size = new Size(150, 36);
            label1.TabIndex = 3;
            label1.Text = "File name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(69, 236);
            label2.Name = "label2";
            label2.Size = new Size(69, 36);
            label2.TabIndex = 4;
            label2.Text = "Size";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(69, 310);
            label3.Name = "label3";
            label3.Size = new Size(82, 36);
            label3.TabIndex = 5;
            label3.Text = "URL";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(69, 460);
            label4.Name = "label4";
            label4.Size = new Size(162, 36);
            label4.TabIndex = 6;
            label4.Text = "Line count";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(69, 539);
            label5.Name = "label5";
            label5.Size = new Size(190, 36);
            label5.TabIndex = 7;
            label5.Text = "Words count";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(69, 619);
            label6.Name = "label6";
            label6.Size = new Size(239, 36);
            label6.TabIndex = 8;
            label6.Text = "Character count";
            // 
            // txtTen
            // 
            txtTen.Font = new Font("Times New Roman", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTen.Location = new Point(325, 155);
            txtTen.Name = "txtTen";
            txtTen.ReadOnly = true;
            txtTen.Size = new Size(634, 50);
            txtTen.TabIndex = 9;
            // 
            // txtSize
            // 
            txtSize.Font = new Font("Times New Roman", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSize.Location = new Point(325, 229);
            txtSize.Name = "txtSize";
            txtSize.ReadOnly = true;
            txtSize.Size = new Size(634, 50);
            txtSize.TabIndex = 10;
            // 
            // txtLink
            // 
            txtLink.Location = new Point(325, 296);
            txtLink.Multiline = true;
            txtLink.Name = "txtLink";
            txtLink.ReadOnly = true;
            txtLink.Size = new Size(634, 140);
            txtLink.TabIndex = 11;
            // 
            // txtLc
            // 
            txtLc.Font = new Font("Times New Roman", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLc.Location = new Point(325, 453);
            txtLc.Name = "txtLc";
            txtLc.ReadOnly = true;
            txtLc.Size = new Size(634, 50);
            txtLc.TabIndex = 12;
            // 
            // txtWc
            // 
            txtWc.Font = new Font("Times New Roman", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtWc.Location = new Point(325, 532);
            txtWc.Name = "txtWc";
            txtWc.ReadOnly = true;
            txtWc.Size = new Size(634, 50);
            txtWc.TabIndex = 13;
            // 
            // txtCharc
            // 
            txtCharc.Font = new Font("Times New Roman", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCharc.Location = new Point(325, 612);
            txtCharc.Name = "txtCharc";
            txtCharc.ReadOnly = true;
            txtCharc.Size = new Size(634, 50);
            txtCharc.TabIndex = 14;
            txtCharc.TextChanged += textBox6_TextChanged;
            // 
            // Bai_2
            // 
            AutoScaleDimensions = new SizeF(18F, 36F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Nền_băng_xanh_công_nghệ_tinh_tế;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(2168, 870);
            Controls.Add(txtCharc);
            Controls.Add(txtWc);
            Controls.Add(txtLc);
            Controls.Add(txtLink);
            Controls.Add(txtSize);
            Controls.Add(txtTen);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(rtbKQ);
            Controls.Add(btnExit);
            Controls.Add(btnRead);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Bai_2";
            Text = "Bài 2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRead;
        private Button btnExit;
        private RichTextBox rtbKQ;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtTen;
        private TextBox txtSize;
        private TextBox txtLink;
        private TextBox txtLc;
        private TextBox txtWc;
        private TextBox txtCharc;
    }
}