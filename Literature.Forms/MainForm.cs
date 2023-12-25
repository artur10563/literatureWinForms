using Literature.Forms.Data;
using System;
using System.Windows.Forms;

namespace Literature.Forms
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void GenreToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var genresForm = new GenresForm();
			genresForm.ShowDialog();
		}

		private void LanguageToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var languageForm = new LanguageForm();
			languageForm.ShowDialog();
		}

		private void CountryToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var countryForm = new CountryForm();
			countryForm.ShowDialog();
		}

		private void CollectionToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var collectionForm = new CollectionForm();
			collectionForm.ShowDialog();
		}

		private void AuthorToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var authorForm = new AuthorForm();
			authorForm.ShowDialog();
		}

		private void PublicationToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var publicationForm = new PublicationForm();
			publicationForm.ShowDialog();
		}

		private void CompositionToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var compositionForm = new CompositionForm();
			compositionForm.ShowDialog();
		}


	}
}
