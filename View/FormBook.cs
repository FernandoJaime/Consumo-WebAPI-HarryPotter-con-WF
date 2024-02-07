using Controller;
using Entities.Books;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class FormBook : Form
    {
        private Book instance;
        public FormBook(Book book)
        {
            InitializeComponent();
            instance = book;
        }

        private void FormBook_Load(object sender, EventArgs e)
        {
            Picture.Load(instance.attributes.cover);
            lblAuthor.Text = "Author: " + instance.attributes.author;
            lblDedicatoria.Text = "Dedication: " + instance.attributes.dedication;
            lblSummaryBok.Text = "Summary: " + instance.attributes.summary;
            lblDate.Text = "Date: " + instance.attributes.release_date;
            lblPages.Text = "Pages: " + instance.attributes.pages;
            LinkWiki.Text = instance.attributes.wiki;
            LinkWiki.AutoSize = true;
        }

        private void LinkWiki_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Obtener el enlace wiki del sender (LinkLabel)
            string wikiLink = instance.attributes.wiki;

            // Verificar si el enlace no está vacío antes de intentar abrirlo.
            if (!string.IsNullOrEmpty(wikiLink))
            {
                try
                {
                    // Especifico el comando adecuado para abrir el enlace en el navegador web predeterminado.
                    System.Diagnostics.Process.Start(new ProcessStartInfo
                    {
                        FileName = wikiLink,
                        UseShellExecute = true
                    });
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al abrir el enlace: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("El enlace está vacío.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnChapters_Click(object sender, EventArgs e)
        {
            FormChapters formChapters = new FormChapters(instance);
            formChapters.ShowDialog();
        }
    }
}
