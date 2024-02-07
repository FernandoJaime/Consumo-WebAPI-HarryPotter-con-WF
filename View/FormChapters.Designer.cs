namespace View
{
    partial class FormChapters
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChapters));
            lblBookChapter = new Label();
            btnBack = new Button();
            DGVchapters = new DataGridView();
            order = new DataGridViewTextBoxColumn();
            title = new DataGridViewTextBoxColumn();
            PanelSummary = new FlowLayoutPanel();
            lblSummaryCap = new Label();
            lblSummary = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)DGVchapters).BeginInit();
            PanelSummary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblBookChapter
            // 
            lblBookChapter.AutoSize = true;
            lblBookChapter.BackColor = Color.Transparent;
            lblBookChapter.Font = new Font("Mongolian Baiti", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBookChapter.ForeColor = Color.White;
            lblBookChapter.Location = new Point(12, 24);
            lblBookChapter.Name = "lblBookChapter";
            lblBookChapter.Size = new Size(221, 23);
            lblBookChapter.TabIndex = 14;
            lblBookChapter.Text = "Chapters of the book: ";
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Transparent;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Mongolian Baiti", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.ForeColor = Color.Goldenrod;
            btnBack.Location = new Point(662, 499);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 28);
            btnBack.TabIndex = 21;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // DGVchapters
            // 
            DGVchapters.AllowUserToAddRows = false;
            DGVchapters.AllowUserToDeleteRows = false;
            DGVchapters.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            DGVchapters.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Mongolian Baiti", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.Desktop;
            dataGridViewCellStyle1.SelectionBackColor = Color.Goldenrod;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DGVchapters.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DGVchapters.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVchapters.Columns.AddRange(new DataGridViewColumn[] { order, title });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Mongolian Baiti", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.Desktop;
            dataGridViewCellStyle2.SelectionBackColor = Color.Goldenrod;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            DGVchapters.DefaultCellStyle = dataGridViewCellStyle2;
            DGVchapters.Location = new Point(12, 66);
            DGVchapters.MultiSelect = false;
            DGVchapters.Name = "DGVchapters";
            DGVchapters.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Mongolian Baiti", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.White;
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            DGVchapters.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            DGVchapters.RowHeadersVisible = false;
            DGVchapters.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGVchapters.Size = new Size(616, 228);
            DGVchapters.TabIndex = 22;
            DGVchapters.CellClick += DGVchapters_CellClick;
            // 
            // order
            // 
            order.HeaderText = "Order";
            order.Name = "order";
            order.ReadOnly = true;
            // 
            // title
            // 
            title.HeaderText = "Title";
            title.Name = "title";
            title.ReadOnly = true;
            // 
            // PanelSummary
            // 
            PanelSummary.BackColor = Color.Transparent;
            PanelSummary.Controls.Add(lblSummaryCap);
            PanelSummary.Location = new Point(12, 344);
            PanelSummary.Name = "PanelSummary";
            PanelSummary.Size = new Size(616, 178);
            PanelSummary.TabIndex = 23;
            // 
            // lblSummaryCap
            // 
            lblSummaryCap.AutoSize = true;
            lblSummaryCap.Font = new Font("Mongolian Baiti", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSummaryCap.ForeColor = Color.White;
            lblSummaryCap.Location = new Point(3, 0);
            lblSummaryCap.Name = "lblSummaryCap";
            lblSummaryCap.Size = new Size(87, 16);
            lblSummaryCap.TabIndex = 0;
            lblSummaryCap.Text = "summary...";
            // 
            // lblSummary
            // 
            lblSummary.AutoSize = true;
            lblSummary.BackColor = Color.Transparent;
            lblSummary.Font = new Font("Mongolian Baiti", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSummary.ForeColor = Color.White;
            lblSummary.Location = new Point(12, 310);
            lblSummary.Name = "lblSummary";
            lblSummary.Size = new Size(189, 16);
            lblSummary.TabIndex = 24;
            lblSummary.Text = "Select chapter  summary:";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.lentes;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(639, 120);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(99, 105);
            pictureBox1.TabIndex = 25;
            pictureBox1.TabStop = false;
            // 
            // FormChapters
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.img;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(750, 534);
            ControlBox = false;
            Controls.Add(pictureBox1);
            Controls.Add(lblSummary);
            Controls.Add(PanelSummary);
            Controls.Add(DGVchapters);
            Controls.Add(btnBack);
            Controls.Add(lblBookChapter);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormChapters";
            StartPosition = FormStartPosition.CenterScreen;
            Load += FormChapters_Load;
            ((System.ComponentModel.ISupportInitialize)DGVchapters).EndInit();
            PanelSummary.ResumeLayout(false);
            PanelSummary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblBookChapter;
        private Button btnBack;
        private DataGridView DGVchapters;
        private FlowLayoutPanel PanelSummary;
        private Label lblSummary;
        private DataGridViewTextBoxColumn order;
        private DataGridViewTextBoxColumn title;
        private Label lblSummaryCap;
        private PictureBox pictureBox1;
    }
}