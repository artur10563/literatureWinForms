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
		private static List<Composition> allCompositions;

		public GuestForm()
		{
			InitializeComponent();
		}

		private async void GuestForm_Load(object sender, EventArgs e)
		{
			CollectionList.SelectedItem = null;

			collectionService = new CollectionService();
			compositionService = new CompositionService();
			allCompositions = await compositionService.GetAll();

			CollectionList.DataSource = await collectionService.GetAll();
			CollectionList.DisplayMember = "Name";
			CompositionList.DisplayMember = "Name";

			CollectionList.SelectedItem = null;
			CompositionList.SelectedItem = null;
	
		}

		private async void CollectionList_SelectedIndexChanged(object sender, EventArgs e)
		{
			var compositions = new List<Composition>();

			if (CollectionList.SelectedItem == null)
			{
				compositions = await compositionService.GetAll();
			}
			else
			{
				var id = ((Collection)CollectionList.SelectedItem).Id;
				selectedCollection = await collectionService.GetByIdWithCompositions(id);
				compositions = selectedCollection.Compositions.ToList();
			}

			CompositionList.DataSource = compositions;
			CompositionList.SelectedItem = null;
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

		private async void searchBox_TextChanged(object sender, EventArgs e)
		{
			CollectionList.SelectedItem = null;
			var text = searchBox.Text.ToLower();

			CompositionList.DataSource =
				allCompositions.Where(
					c =>
					c.Name.ToLower().Contains(text) ||
					c.Author.FirstName.ToLower().Contains(text) ||
					c.Author.LastName.ToLower().Contains(text)
					)
				.ToList();
		}
	}
}
