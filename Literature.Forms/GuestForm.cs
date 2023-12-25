using Literature.Forms.Data.Entities;
using Literature.Forms.Data.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Literature.Forms
{
	public partial class GuestForm : Form
	{
		private static CollectionService collectionService;
		private static CompositionService compositionService;


		private static Collection selectedCollection;
		private static Composition selectedComposition;

		public GuestForm()
		{
			InitializeComponent();
		}

		private async void GuestForm_Load(object sender, EventArgs e)
		{
			CollectionList.SelectedItem = null;

			collectionService = new CollectionService();
			compositionService = new CompositionService();

			CollectionList.DataSource = await collectionService.GetAll();
			CollectionList.DisplayMember = "Name";
			CompositionList.DisplayMember = "Name";
		}

		private async void CollectionList_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (CollectionList.SelectedItem == null) return;

			var id = ((Collection)CollectionList.SelectedItem).Id;
			selectedCollection = await collectionService.GetByIdWithCompositions(id);

			CompositionList.DataSource = selectedCollection.Compositions;

		}

		private async void CompositionList_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (CompositionList.SelectedItem == null) return;

			var id = ((Composition)CompositionList.SelectedItem).Id;
			selectedComposition = await compositionService.GetByIdWithGenres(id);

			var genres = selectedComposition.Genres;
			var genresText = string.Join(",", genres.Select(g => g.Name));

			compositionNameLabel.Text = selectedComposition?.Name;
			AuthorNameLabel.Text = selectedComposition.Author?.FullName;
			PublicationLabel.Text = selectedComposition.Publication?.Name;
			ContactsLabel.Text = selectedComposition.Publication?.Email;
			LanguageLabel.Text = selectedComposition.Language?.Name;
			CompositionText.Text = selectedComposition?.Text;
			GenresLabel.Text = genresText;
		}
	}
}
