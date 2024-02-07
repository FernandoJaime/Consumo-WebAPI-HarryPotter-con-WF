using Controller;
using Entities.Books;
using Entities.Chapters;
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
    public partial class FormChapters : Form
    {
        private BooksController bookController;
        private Book book;
        private Data<Chapter> instance;

        public FormChapters(Book libro)
        {
            InitializeComponent();
            book = libro;
            bookController = new BooksController();
            instance = new Data<Chapter>();
        }

        // Metodo que carga los datos de cada chapter del libro a partir de la lista.
        private async void DGVload(List<Chapter> chapters)
        {
            DGVchapters.AutoGenerateColumns = false;
            DGVchapters.DataSource = null;
            DGVchapters.DataSource = chapters;
            for (int i = 0; i < DGVchapters.Rows.Count; i++)
            {
                DGVchapters.Rows[i].Cells[0].Value = chapters[i].attributes.order;
                DGVchapters.Rows[i].Cells[1].Value = chapters[i].attributes.title;
            }
            DGVchapters.Refresh();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void FormChapters_Load(object sender, EventArgs e)
        {
            lblBookChapter.Text = "Chapters of the book: " + book.attributes.title;
            instance = await bookController.GetAllChapters(book.id);
            DGVload(instance.data);
        }

        private void DGVchapters_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var seleccionado = (Chapter)DGVchapters.CurrentRow.DataBoundItem;
            lblSummary.Text = "Summary of the chapter: " + seleccionado.attributes.title;
            if (seleccionado.attributes.summary == "")
            {
                lblSummaryCap.Text = "No summary available for this chapter";
            }
            else
            {
                lblSummaryCap.Text = seleccionado.attributes.summary;
            }
        }
    }
}
