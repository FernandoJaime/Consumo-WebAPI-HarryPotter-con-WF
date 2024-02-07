namespace View
{
    partial class FormBook
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBook));
            Picture = new PictureBox();
            lblAuthor = new Label();
            PanelDedication = new FlowLayoutPanel();
            lblDedicatoria = new Label();
            lblPages = new Label();
            lblDate = new Label();
            PanelSummary = new FlowLayoutPanel();
            lblSummaryBok = new Label();
            btnChapters = new Button();
            btnBack = new Button();
            PanelLink = new FlowLayoutPanel();
            LinkWiki = new LinkLabel();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)Picture).BeginInit();
            PanelDedication.SuspendLayout();
            PanelSummary.SuspendLayout();
            PanelLink.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Picture
            // 
            Picture.BackColor = Color.Transparent;
            Picture.Location = new Point(12, 12);
            Picture.Name = "Picture";
            Picture.Size = new Size(264, 368);
            Picture.SizeMode = PictureBoxSizeMode.StretchImage;
            Picture.TabIndex = 4;
            Picture.TabStop = false;
            // 
            // lblAuthor
            // 
            lblAuthor.AutoSize = true;
            lblAuthor.BackColor = Color.Transparent;
            lblAuthor.Font = new Font("Mongolian Baiti", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAuthor.ForeColor = Color.White;
            lblAuthor.Location = new Point(295, 12);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(62, 16);
            lblAuthor.TabIndex = 5;
            lblAuthor.Text = "Author:";
            // 
            // PanelDedication
            // 
            PanelDedication.BackColor = Color.Transparent;
            PanelDedication.Controls.Add(lblDedicatoria);
            PanelDedication.Location = new Point(295, 65);
            PanelDedication.Name = "PanelDedication";
            PanelDedication.Size = new Size(346, 66);
            PanelDedication.TabIndex = 6;
            // 
            // lblDedicatoria
            // 
            lblDedicatoria.AutoSize = true;
            lblDedicatoria.BackColor = Color.Transparent;
            lblDedicatoria.Font = new Font("Mongolian Baiti", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDedicatoria.ForeColor = Color.White;
            lblDedicatoria.Location = new Point(3, 0);
            lblDedicatoria.Name = "lblDedicatoria";
            lblDedicatoria.Size = new Size(90, 16);
            lblDedicatoria.TabIndex = 13;
            lblDedicatoria.Text = "Dedication:";
            // 
            // lblPages
            // 
            lblPages.AutoSize = true;
            lblPages.BackColor = Color.Transparent;
            lblPages.Font = new Font("Mongolian Baiti", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPages.ForeColor = Color.White;
            lblPages.Location = new Point(295, 365);
            lblPages.Name = "lblPages";
            lblPages.Size = new Size(53, 16);
            lblPages.TabIndex = 7;
            lblPages.Text = "Pages:";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.BackColor = Color.Transparent;
            lblDate.Font = new Font("Mongolian Baiti", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDate.ForeColor = Color.White;
            lblDate.Location = new Point(12, 394);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(45, 16);
            lblDate.TabIndex = 8;
            lblDate.Text = "Date:";
            // 
            // PanelSummary
            // 
            PanelSummary.BackColor = Color.Transparent;
            PanelSummary.Controls.Add(lblSummaryBok);
            PanelSummary.Location = new Point(295, 137);
            PanelSummary.Name = "PanelSummary";
            PanelSummary.Size = new Size(413, 182);
            PanelSummary.TabIndex = 7;
            // 
            // lblSummaryBok
            // 
            lblSummaryBok.AutoSize = true;
            lblSummaryBok.BackColor = Color.Transparent;
            lblSummaryBok.Font = new Font("Mongolian Baiti", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSummaryBok.ForeColor = Color.White;
            lblSummaryBok.Location = new Point(3, 0);
            lblSummaryBok.Name = "lblSummaryBok";
            lblSummaryBok.Size = new Size(79, 16);
            lblSummaryBok.TabIndex = 14;
            lblSummaryBok.Text = "Summary:";
            // 
            // btnChapters
            // 
            btnChapters.BackColor = Color.Transparent;
            btnChapters.FlatStyle = FlatStyle.Flat;
            btnChapters.Font = new Font("Mongolian Baiti", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnChapters.ForeColor = Color.Goldenrod;
            btnChapters.Location = new Point(194, 388);
            btnChapters.Name = "btnChapters";
            btnChapters.Size = new Size(82, 29);
            btnChapters.TabIndex = 10;
            btnChapters.Text = "Chapters";
            btnChapters.UseVisualStyleBackColor = false;
            btnChapters.Click += btnChapters_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Transparent;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Mongolian Baiti", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.ForeColor = Color.Goldenrod;
            btnBack.Location = new Point(681, 420);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 28);
            btnBack.TabIndex = 11;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // PanelLink
            // 
            PanelLink.BackColor = Color.Transparent;
            PanelLink.Controls.Add(LinkWiki);
            PanelLink.Location = new Point(295, 325);
            PanelLink.Name = "PanelLink";
            PanelLink.Size = new Size(413, 37);
            PanelLink.TabIndex = 7;
            // 
            // LinkWiki
            // 
            LinkWiki.ActiveLinkColor = Color.Goldenrod;
            LinkWiki.AutoSize = true;
            LinkWiki.Font = new Font("Mongolian Baiti", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LinkWiki.LinkColor = Color.Goldenrod;
            LinkWiki.Location = new Point(3, 0);
            LinkWiki.Name = "LinkWiki";
            LinkWiki.Size = new Size(77, 14);
            LinkWiki.TabIndex = 0;
            LinkWiki.TabStop = true;
            LinkWiki.Text = "linkLabel1";
            LinkWiki.VisitedLinkColor = Color.Goldenrod;
            LinkWiki.LinkClicked += LinkWiki_LinkClicked;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.lentes;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(671, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(99, 105);
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // FormBook
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.img;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(768, 455);
            ControlBox = false;
            Controls.Add(pictureBox1);
            Controls.Add(PanelLink);
            Controls.Add(btnBack);
            Controls.Add(btnChapters);
            Controls.Add(PanelSummary);
            Controls.Add(lblDate);
            Controls.Add(lblPages);
            Controls.Add(PanelDedication);
            Controls.Add(lblAuthor);
            Controls.Add(Picture);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormBook";
            StartPosition = FormStartPosition.CenterScreen;
            Load += FormBook_Load;
            ((System.ComponentModel.ISupportInitialize)Picture).EndInit();
            PanelDedication.ResumeLayout(false);
            PanelDedication.PerformLayout();
            PanelSummary.ResumeLayout(false);
            PanelSummary.PerformLayout();
            PanelLink.ResumeLayout(false);
            PanelLink.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnView1;
        private Label lblAuthor;
        private Label label2;
        private Button btnView2;
        private Label label3;
        private Button btnView3;
        private Label label4;
        private Button btnView4;
        private Label label5;
        private Button btnView5;
        private Label label6;
        private Button btnView6;
        private Label label7;
        private Button btnView7;
        private PictureBox Picture;
        private FlowLayoutPanel PanelDedication;
        private Label lblPages;
        private Label lblDate;
        private FlowLayoutPanel PanelSummary;
        private Button btnChapters;
        private Button btnBack;
        private FlowLayoutPanel PanelLink;
        private LinkLabel LinkWiki;
        private PictureBox pictureBox1;
        private Label lblDedicatoria;
        private Label lblSummaryBok;
    }
}