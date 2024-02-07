namespace View
{
    partial class FormMovie
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
            PictureMovie = new PictureBox();
            lblRating = new Label();
            lblRelease_date = new Label();
            PanelSummary = new FlowLayoutPanel();
            lblSummaryMov = new Label();
            btnBack = new Button();
            PanelLink = new FlowLayoutPanel();
            label1 = new Label();
            lblLinkWiki = new LinkLabel();
            pictureBox1 = new PictureBox();
            PanelDedication = new FlowLayoutPanel();
            lblBox_office = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            lblBudget = new Label();
            flowLayoutPanel2 = new FlowLayoutPanel();
            lblCinematographers = new Label();
            flowLayoutPanel3 = new FlowLayoutPanel();
            lblDirectors = new Label();
            flowLayoutPanel4 = new FlowLayoutPanel();
            lblDistributors = new Label();
            flowLayoutPanel5 = new FlowLayoutPanel();
            lblEditors = new Label();
            flowLayoutPanel6 = new FlowLayoutPanel();
            lblProducers = new Label();
            lblRunning_time = new Label();
            flowLayoutPanel7 = new FlowLayoutPanel();
            lbllink = new Label();
            lblLinkTrailer = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)PictureMovie).BeginInit();
            PanelSummary.SuspendLayout();
            PanelLink.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            PanelDedication.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            flowLayoutPanel4.SuspendLayout();
            flowLayoutPanel5.SuspendLayout();
            flowLayoutPanel6.SuspendLayout();
            flowLayoutPanel7.SuspendLayout();
            SuspendLayout();
            // 
            // PictureMovie
            // 
            PictureMovie.BackColor = Color.Transparent;
            PictureMovie.Location = new Point(12, 12);
            PictureMovie.Name = "PictureMovie";
            PictureMovie.Size = new Size(264, 368);
            PictureMovie.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureMovie.TabIndex = 4;
            PictureMovie.TabStop = false;
            // 
            // lblRating
            // 
            lblRating.AutoSize = true;
            lblRating.BackColor = Color.Transparent;
            lblRating.Font = new Font("Mongolian Baiti", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRating.ForeColor = Color.White;
            lblRating.Location = new Point(295, 364);
            lblRating.Name = "lblRating";
            lblRating.Size = new Size(59, 16);
            lblRating.TabIndex = 7;
            lblRating.Text = "Rating:";
            // 
            // lblRelease_date
            // 
            lblRelease_date.AutoSize = true;
            lblRelease_date.BackColor = Color.Transparent;
            lblRelease_date.Font = new Font("Mongolian Baiti", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRelease_date.ForeColor = Color.White;
            lblRelease_date.Location = new Point(12, 394);
            lblRelease_date.Name = "lblRelease_date";
            lblRelease_date.Size = new Size(45, 16);
            lblRelease_date.TabIndex = 8;
            lblRelease_date.Text = "Date:";
            // 
            // PanelSummary
            // 
            PanelSummary.BackColor = Color.Transparent;
            PanelSummary.Controls.Add(lblSummaryMov);
            PanelSummary.Location = new Point(12, 505);
            PanelSummary.Name = "PanelSummary";
            PanelSummary.Size = new Size(814, 182);
            PanelSummary.TabIndex = 7;
            // 
            // lblSummaryMov
            // 
            lblSummaryMov.AutoSize = true;
            lblSummaryMov.BackColor = Color.Transparent;
            lblSummaryMov.Font = new Font("Mongolian Baiti", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSummaryMov.ForeColor = Color.White;
            lblSummaryMov.Location = new Point(3, 0);
            lblSummaryMov.Name = "lblSummaryMov";
            lblSummaryMov.Size = new Size(79, 16);
            lblSummaryMov.TabIndex = 14;
            lblSummaryMov.Text = "Summary:";
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Transparent;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Mongolian Baiti", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.ForeColor = Color.Goldenrod;
            btnBack.Location = new Point(849, 659);
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
            PanelLink.Controls.Add(label1);
            PanelLink.Controls.Add(lblLinkWiki);
            PanelLink.Location = new Point(12, 436);
            PanelLink.Name = "PanelLink";
            PanelLink.Size = new Size(383, 63);
            PanelLink.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Mongolian Baiti", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(78, 14);
            label1.TabIndex = 22;
            label1.Text = "Wikipedia:";
            // 
            // lblLinkWiki
            // 
            lblLinkWiki.ActiveLinkColor = Color.Goldenrod;
            lblLinkWiki.AutoSize = true;
            lblLinkWiki.Font = new Font("Mongolian Baiti", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLinkWiki.LinkColor = Color.Goldenrod;
            lblLinkWiki.Location = new Point(87, 0);
            lblLinkWiki.Name = "lblLinkWiki";
            lblLinkWiki.Size = new Size(73, 14);
            lblLinkWiki.TabIndex = 0;
            lblLinkWiki.TabStop = true;
            lblLinkWiki.Text = "LinkWiki:";
            lblLinkWiki.VisitedLinkColor = Color.Goldenrod;
            lblLinkWiki.LinkClicked += lblLinkWiki_LinkClicked;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.lentes;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(832, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(99, 105);
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // PanelDedication
            // 
            PanelDedication.BackColor = Color.Transparent;
            PanelDedication.Controls.Add(lblBox_office);
            PanelDedication.Location = new Point(295, 12);
            PanelDedication.Name = "PanelDedication";
            PanelDedication.Size = new Size(531, 23);
            PanelDedication.TabIndex = 6;
            // 
            // lblBox_office
            // 
            lblBox_office.AutoSize = true;
            lblBox_office.BackColor = Color.Transparent;
            lblBox_office.Font = new Font("Mongolian Baiti", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBox_office.ForeColor = Color.White;
            lblBox_office.Location = new Point(3, 0);
            lblBox_office.Name = "lblBox_office";
            lblBox_office.Size = new Size(144, 16);
            lblBox_office.TabIndex = 13;
            lblBox_office.Text = "Revenue collected:";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.Transparent;
            flowLayoutPanel1.Controls.Add(lblBudget);
            flowLayoutPanel1.Location = new Point(295, 41);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(531, 23);
            flowLayoutPanel1.TabIndex = 14;
            // 
            // lblBudget
            // 
            lblBudget.AutoSize = true;
            lblBudget.BackColor = Color.Transparent;
            lblBudget.Font = new Font("Mongolian Baiti", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBudget.ForeColor = Color.White;
            lblBudget.Location = new Point(3, 0);
            lblBudget.Name = "lblBudget";
            lblBudget.Size = new Size(63, 16);
            lblBudget.TabIndex = 13;
            lblBudget.Text = "Budget:";
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.BackColor = Color.Transparent;
            flowLayoutPanel2.Controls.Add(lblCinematographers);
            flowLayoutPanel2.Location = new Point(295, 70);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(531, 49);
            flowLayoutPanel2.TabIndex = 15;
            // 
            // lblCinematographers
            // 
            lblCinematographers.AutoSize = true;
            lblCinematographers.BackColor = Color.Transparent;
            lblCinematographers.Font = new Font("Mongolian Baiti", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCinematographers.ForeColor = Color.White;
            lblCinematographers.Location = new Point(3, 0);
            lblCinematographers.Name = "lblCinematographers";
            lblCinematographers.Size = new Size(142, 16);
            lblCinematographers.TabIndex = 13;
            lblCinematographers.Text = "Cinematographers:";
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.BackColor = Color.Transparent;
            flowLayoutPanel3.Controls.Add(lblDirectors);
            flowLayoutPanel3.Location = new Point(295, 125);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(531, 49);
            flowLayoutPanel3.TabIndex = 16;
            // 
            // lblDirectors
            // 
            lblDirectors.AutoSize = true;
            lblDirectors.BackColor = Color.Transparent;
            lblDirectors.Font = new Font("Mongolian Baiti", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDirectors.ForeColor = Color.White;
            lblDirectors.Location = new Point(3, 0);
            lblDirectors.Name = "lblDirectors";
            lblDirectors.Size = new Size(78, 16);
            lblDirectors.TabIndex = 13;
            lblDirectors.Text = "Directors:";
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.BackColor = Color.Transparent;
            flowLayoutPanel4.Controls.Add(lblDistributors);
            flowLayoutPanel4.Location = new Point(295, 180);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Size = new Size(531, 49);
            flowLayoutPanel4.TabIndex = 17;
            // 
            // lblDistributors
            // 
            lblDistributors.AutoSize = true;
            lblDistributors.BackColor = Color.Transparent;
            lblDistributors.Font = new Font("Mongolian Baiti", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDistributors.ForeColor = Color.White;
            lblDistributors.Location = new Point(3, 0);
            lblDistributors.Name = "lblDistributors";
            lblDistributors.Size = new Size(97, 16);
            lblDistributors.TabIndex = 13;
            lblDistributors.Text = "Distributors:";
            // 
            // flowLayoutPanel5
            // 
            flowLayoutPanel5.BackColor = Color.Transparent;
            flowLayoutPanel5.Controls.Add(lblEditors);
            flowLayoutPanel5.Location = new Point(295, 235);
            flowLayoutPanel5.Name = "flowLayoutPanel5";
            flowLayoutPanel5.Size = new Size(531, 49);
            flowLayoutPanel5.TabIndex = 18;
            // 
            // lblEditors
            // 
            lblEditors.AutoSize = true;
            lblEditors.BackColor = Color.Transparent;
            lblEditors.Font = new Font("Mongolian Baiti", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEditors.ForeColor = Color.White;
            lblEditors.Location = new Point(3, 0);
            lblEditors.Name = "lblEditors";
            lblEditors.Size = new Size(63, 16);
            lblEditors.TabIndex = 13;
            lblEditors.Text = "Editors:";
            // 
            // flowLayoutPanel6
            // 
            flowLayoutPanel6.BackColor = Color.Transparent;
            flowLayoutPanel6.Controls.Add(lblProducers);
            flowLayoutPanel6.Location = new Point(295, 290);
            flowLayoutPanel6.Name = "flowLayoutPanel6";
            flowLayoutPanel6.Size = new Size(531, 49);
            flowLayoutPanel6.TabIndex = 19;
            // 
            // lblProducers
            // 
            lblProducers.AutoSize = true;
            lblProducers.BackColor = Color.Transparent;
            lblProducers.Font = new Font("Mongolian Baiti", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProducers.ForeColor = Color.White;
            lblProducers.Location = new Point(3, 0);
            lblProducers.Name = "lblProducers";
            lblProducers.Size = new Size(83, 16);
            lblProducers.TabIndex = 13;
            lblProducers.Text = "Producers:";
            // 
            // lblRunning_time
            // 
            lblRunning_time.AutoSize = true;
            lblRunning_time.BackColor = Color.Transparent;
            lblRunning_time.Font = new Font("Mongolian Baiti", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRunning_time.ForeColor = Color.White;
            lblRunning_time.Location = new Point(545, 364);
            lblRunning_time.Name = "lblRunning_time";
            lblRunning_time.Size = new Size(75, 16);
            lblRunning_time.TabIndex = 20;
            lblRunning_time.Text = "Duration:";
            // 
            // flowLayoutPanel7
            // 
            flowLayoutPanel7.BackColor = Color.Transparent;
            flowLayoutPanel7.Controls.Add(lbllink);
            flowLayoutPanel7.Controls.Add(lblLinkTrailer);
            flowLayoutPanel7.Location = new Point(459, 436);
            flowLayoutPanel7.Name = "flowLayoutPanel7";
            flowLayoutPanel7.Size = new Size(367, 63);
            flowLayoutPanel7.TabIndex = 8;
            // 
            // lbllink
            // 
            lbllink.AutoSize = true;
            lbllink.BackColor = Color.Transparent;
            lbllink.Font = new Font("Mongolian Baiti", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbllink.ForeColor = Color.White;
            lbllink.Location = new Point(3, 0);
            lbllink.Name = "lbllink";
            lbllink.Size = new Size(55, 14);
            lbllink.TabIndex = 21;
            lbllink.Text = "Trailer:";
            // 
            // lblLinkTrailer
            // 
            lblLinkTrailer.ActiveLinkColor = Color.Goldenrod;
            lblLinkTrailer.AutoSize = true;
            lblLinkTrailer.Font = new Font("Mongolian Baiti", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLinkTrailer.LinkColor = Color.Goldenrod;
            lblLinkTrailer.Location = new Point(64, 0);
            lblLinkTrailer.Name = "lblLinkTrailer";
            lblLinkTrailer.Size = new Size(37, 14);
            lblLinkTrailer.TabIndex = 0;
            lblLinkTrailer.TabStop = true;
            lblLinkTrailer.Text = "Link";
            lblLinkTrailer.VisitedLinkColor = Color.Goldenrod;
            lblLinkTrailer.LinkClicked += lblLinkTrailer_LinkClicked;
            // 
            // FormMovie
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.img;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(943, 699);
            ControlBox = false;
            Controls.Add(lblRunning_time);
            Controls.Add(flowLayoutPanel7);
            Controls.Add(PanelDedication);
            Controls.Add(flowLayoutPanel6);
            Controls.Add(flowLayoutPanel5);
            Controls.Add(flowLayoutPanel4);
            Controls.Add(flowLayoutPanel3);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(pictureBox1);
            Controls.Add(PanelLink);
            Controls.Add(btnBack);
            Controls.Add(PanelSummary);
            Controls.Add(lblRelease_date);
            Controls.Add(lblRating);
            Controls.Add(PictureMovie);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FormMovie";
            StartPosition = FormStartPosition.CenterScreen;
            Load += FormMovie_Load;
            ((System.ComponentModel.ISupportInitialize)PictureMovie).EndInit();
            PanelSummary.ResumeLayout(false);
            PanelSummary.PerformLayout();
            PanelLink.ResumeLayout(false);
            PanelLink.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            PanelDedication.ResumeLayout(false);
            PanelDedication.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel3.PerformLayout();
            flowLayoutPanel4.ResumeLayout(false);
            flowLayoutPanel4.PerformLayout();
            flowLayoutPanel5.ResumeLayout(false);
            flowLayoutPanel5.PerformLayout();
            flowLayoutPanel6.ResumeLayout(false);
            flowLayoutPanel6.PerformLayout();
            flowLayoutPanel7.ResumeLayout(false);
            flowLayoutPanel7.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnView1;
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
        private PictureBox PictureMovie;
        private Label lblRating;
        private Label lblRelease_date;
        private FlowLayoutPanel PanelSummary;
        private Button btnBack;
        private FlowLayoutPanel PanelLink;
        private LinkLabel lblLinkWiki;
        private PictureBox pictureBox1;
        private Label lblSummaryMov;
        private FlowLayoutPanel PanelDedication;
        private Label lblBox_office;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label lblBudget;
        private FlowLayoutPanel flowLayoutPanel2;
        private Label lblCinematographers;
        private FlowLayoutPanel flowLayoutPanel3;
        private Label lblDirectors;
        private FlowLayoutPanel flowLayoutPanel4;
        private Label lblDistributors;
        private FlowLayoutPanel flowLayoutPanel5;
        private Label lblEditors;
        private FlowLayoutPanel flowLayoutPanel6;
        private Label lblProducers;
        private Label lblRunning_time;
        private Label label1;
        private FlowLayoutPanel flowLayoutPanel7;
        private Label lbllink;
        private LinkLabel lblLinkTrailer;
    }
}