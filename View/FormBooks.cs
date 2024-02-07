using Controller;
using Entities.Books;
using Entities.GenericClass;
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
    public partial class FormBooks : Form
    {
        private BooksController bookController;
        private Data<Book> instance;
        public FormBooks()
        {
            InitializeComponent();
            bookController = new BooksController();
            instance = new Data<Book>();
        }

        // Metodo que carga las imagenes de las tapas de los books atraves de su lista.
        private void LoadImages(List<Book> books)
        {
            PictureBox[] boxes = { Box1, Box2, Box3, Box4, Box5, Box6, Box7 }; // Array de PictureBox.
            for (int i = 0; i < books.Count && i < boxes.Length; i++)
            {
                var index = i;
                boxes[i].Load(books[i].attributes.cover); // Carga la imagen en el PictureBox correspondiente.
                boxes[i].Click += (sender, e) => OpenBook(books[index]); // Agrego un evento click al PictureBox.
            }
        }

        private async void FormBooks_Load(object sender, EventArgs e)
        {
            instance = await bookController.GetAll();
            LoadImages(instance.data);
        }

        private void OpenBook(Book book)
        {
            FormBook formBook = new FormBook(book);
            formBook.ShowDialog();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
