namespace View
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            btnBooks = new Button();
            btnSalir = new Button();
            btnMovies = new Button();
            SuspendLayout();
            // 
            // btnBooks
            // 
            btnBooks.BackColor = Color.Transparent;
            btnBooks.FlatStyle = FlatStyle.Flat;
            btnBooks.Font = new Font("Mongolian Baiti", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBooks.ForeColor = Color.White;
            btnBooks.Location = new Point(88, 34);
            btnBooks.Name = "btnBooks";
            btnBooks.Size = new Size(75, 29);
            btnBooks.TabIndex = 0;
            btnBooks.Text = "Books";
            btnBooks.UseVisualStyleBackColor = false;
            btnBooks.Click += btnBooks_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.Transparent;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Mongolian Baiti", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalir.ForeColor = Color.White;
            btnSalir.Location = new Point(142, 377);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 25);
            btnSalir.TabIndex = 1;
            btnSalir.Text = "Exit";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnMovies
            // 
            btnMovies.BackColor = Color.Transparent;
            btnMovies.FlatStyle = FlatStyle.Flat;
            btnMovies.Font = new Font("Mongolian Baiti", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMovies.ForeColor = Color.White;
            btnMovies.Location = new Point(199, 34);
            btnMovies.Name = "btnMovies";
            btnMovies.Size = new Size(75, 29);
            btnMovies.TabIndex = 3;
            btnMovies.Text = "Movies";
            btnMovies.UseVisualStyleBackColor = false;
            btnMovies.Click += btnMovies_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = Properties.Resources.imagenInicio;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(366, 414);
            ControlBox = false;
            Controls.Add(btnMovies);
            Controls.Add(btnSalir);
            Controls.Add(btnBooks);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Menu";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
        }

        #endregion

        private Button btnBooks;
        private Button btnSalir;
        private Button btnMovies;
    }
}
