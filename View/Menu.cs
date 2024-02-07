namespace View
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnBooks_Click(object sender, EventArgs e)
        {
            FormBooks formBooks = new FormBooks();
            formBooks.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMovies_Click(object sender, EventArgs e)
        {
            FormMovies formMovies = new FormMovies();
            formMovies.ShowDialog();
        }
    }
}
