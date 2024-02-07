using Entities.Movies;
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
    public partial class FormMovie : Form
    {
        private Movie instance;
        public FormMovie(Movie peli)
        {
            InitializeComponent();
            instance = peli;
        }

        private void FormMovie_Load(object sender, EventArgs e)
        {
            PictureMovie.Load(instance.attributes.poster);
            lblBox_office.Text = "Revenue collected: " + instance.attributes.box_office;
            lblBudget.Text = "Budget: " + instance.attributes.budget;
            lblCinematographers.Text = "Cinematographers: " + string.Join(", ", instance.attributes.cinematographers);
            lblDirectors.Text = "Directors: " + string.Join(", ", instance.attributes.directors);
            lblDistributors.Text = "Distributors: " + string.Join(", ", instance.attributes.distributors);
            lblEditors.Text = "Editors: " + string.Join(", ", instance.attributes.editors);
            lblProducers.Text = "Producers: " + string.Join(", ", instance.attributes.producers);
            lblRating.Text = "Rating: " + instance.attributes.rating;
            lblRelease_date.Text = "Date: " + instance.attributes.release_date;
            lblRunning_time.Text = "Duration: " + instance.attributes.running_time;
            lblLinkWiki.Text = instance.attributes.wiki;
            lblLinkWiki.AutoSize = true;
            lblLinkTrailer.Text = instance.attributes.trailer;
            lblLinkTrailer.AutoSize = true;
            lblSummaryMov.Text = "Summary of " + instance.attributes.title + ": \n" + instance.attributes.summary;
        }

        private void lblLinkWiki_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string wikiLink = instance.attributes.wiki;
            if (!string.IsNullOrEmpty(wikiLink))
            {
                try
                {
                    System.Diagnostics.Process.Start(new ProcessStartInfo // Para abrir el enlace en el navegador web predeterminado.
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

        private void lblLinkTrailer_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string trailerLink = instance.attributes.wiki;
            if (!string.IsNullOrEmpty(trailerLink))
            {
                try
                {
                    System.Diagnostics.Process.Start(new ProcessStartInfo // Para abrir el enlace en el navegador web predeterminado.
                    {
                        FileName = trailerLink,
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
    }
}
