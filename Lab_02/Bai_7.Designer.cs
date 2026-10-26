namespace Lab_02
{
    partial class Bai_7
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
            tvThumuc = new TreeView();
            grpContent = new GroupBox();
            rtbND = new RichTextBox();
            picND = new PictureBox();
            grpContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picND).BeginInit();
            SuspendLayout();
            // 
            // tvThumuc
            // 
            tvThumuc.HideSelection = false;
            tvThumuc.Location = new Point(23, 24);
            tvThumuc.Name = "tvThumuc";
            tvThumuc.Size = new Size(352, 666);
            tvThumuc.TabIndex = 0;
            // 
            // grpContent
            // 
            grpContent.Controls.Add(rtbND);
            grpContent.Controls.Add(picND);
            grpContent.Location = new Point(395, 24);
            grpContent.Name = "grpContent";
            grpContent.Size = new Size(1014, 660);
            grpContent.TabIndex = 1;
            grpContent.TabStop = false;
            grpContent.Text = "Nội dung File";
            // 
            // rtbND
            // 
            rtbND.Dock = DockStyle.Fill;
            rtbND.Location = new Point(3, 40);
            rtbND.Name = "rtbND";
            rtbND.ReadOnly = true;
            rtbND.Size = new Size(1008, 617);
            rtbND.TabIndex = 1;
            rtbND.Text = "";
            rtbND.Visible = false;
            // 
            // picND
            // 
            picND.Dock = DockStyle.Fill;
            picND.Location = new Point(3, 40);
            picND.Name = "picND";
            picND.Size = new Size(1008, 617);
            picND.SizeMode = PictureBoxSizeMode.Zoom;
            picND.TabIndex = 0;
            picND.TabStop = false;
            picND.Visible = false;
            // 
            // Bai_7
            // 
            AutoScaleDimensions = new SizeF(18F, 36F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Nền_kem_tối_giản__thư_mục_giấy;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1424, 702);
            Controls.Add(grpContent);
            Controls.Add(tvThumuc);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Bai_7";
            Text = "Bài 7";
            Load += Bai_7_Load;
            grpContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picND).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TreeView tvThumuc;
        private GroupBox grpContent;
        private PictureBox picND;
        private RichTextBox rtbND;
    }
}