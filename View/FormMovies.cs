using Controller;
using Entities.Books;
using Entities.GenericClass;
using Entities.Movies;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class FormMovies : Form
    {
        private MoviesController movieController;
        private Data<Movie> instance;
        public FormMovies()
        {
            InitializeComponent();
            movieController = new MoviesController();
            instance = new Data<Movie>();
        }

        // Metodo que carga las imagenes de los posters de las movies atraves de su lista.
        private void LoadImages(List<Movie> movies)
        {
            PictureBox[] boxes = { Box1, Box2, Box3, Box4, Box5, Box6, Box7, Box8, Box9, Box10, Box11 }; // Array de PictureBox.
            for (int i = 0; i < movies.Count && i < boxes.Length; i++)
            {
                var index = i;
                boxes[i].Load(movies[i].attributes.poster); // Carga la imagen en el PictureBox correspondiente.
                boxes[i].Click += (sender, e) => OpenMovie(movies[index]); // Agrego un evento click al PictureBox.
            }
        }

        private void OpenMovie(Movie movie)
        {
            FormMovie formMovie = new FormMovie(movie);
            formMovie.ShowDialog();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void FormMovies_Load(object sender, EventArgs e)
        {
            instance = await movieController.GetAll();
            LoadImages(instance.data);
        }
    }
}
