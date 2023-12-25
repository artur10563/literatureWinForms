using Literature.Forms.Data.Entities;
using Literature.Forms.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Literature.Forms
{
	public partial class CompositionForm : Form
	{
		private static LanguageService languageService;
		private static PublicationService publicationService;
		private static CompositionService compositionService;
		private static GenreService genreService;
		private static AuthorService authorService;

		private static Composition selectedComposition;

		private async Task CreateCompositionsElementsAsync()
		{
			var compositions = await compositionService.GetAll(); ;
			CompositionList.DataSource = compositions;
			CompositionList.DisplayMember = "Name";
			CompositionList.Refresh();
		}
		private void UpdateSelectedGenres(List<Genre> genres)
		{
			GenreListBox.ClearSelected();

			foreach (Genre genre in genres)
			{
				if (genre == null) continue;
				int index = GenreListBox.Items.OfType<Genre>().Select(i => i.Id).ToList().IndexOf(genre.Id);
				if (index != -1)
				{
					GenreListBox.SetSelected(index, true);
				}
			}

			GenreListBox.Refresh();
		}


		public CompositionForm()
		{
			InitializeComponent();
		}

		private async void CompositionForm_Load(object sender, EventArgs e)
		{
			languageService = new LanguageService();
			publicationService = new PublicationService();
			compositionService = new CompositionService();
			genreService = new GenreService();
			authorService = new AuthorService();

			AuthorDropDown.DisplayMember = "FullName";
			GenreListBox.DisplayMember = "Name";
			LanguageDropDown.DisplayMember = "Name";
			PublicationDropDown.DisplayMember = "Name";

			AuthorDropDown.DataSource = await authorService.GetAll();
			GenreListBox.DataSource = await genreService.GetAll();
			LanguageDropDown.DataSource = await languageService.GetAll();
			PublicationDropDown.DataSource = await publicationService.GetAll();

			GenreListBox.ClearSelected();


			await CreateCompositionsElementsAsync();
		}

		private async void NewCompositionBtn_Click(object sender, EventArgs e)
		{
			var name = NameBox.Text.Trim();
			var text = CompositionTextBox.Text.Trim();
			var language = (Language)LanguageDropDown.SelectedValue;
			var publication = (Publication)PublicationDropDown.SelectedValue;
			var author = (Author)AuthorDropDown.SelectedValue;
			var genres = GenreListBox.SelectedItems.OfType<Genre>().ToList();

			if (genres.Count == 0)
			{
				MessageBox.Show("Хоча б один жанр", "Помилка");
				return;
			}
			if (name.Length < 3)
			{
				MessageBox.Show("Назва повинна містити принаймні три символи.", "Помилка");
				return;
			}
			if (text.Length < 3)
			{
				MessageBox.Show("Текст повинний містити принаймні три символи.", "Помилка");
				return;
			}
			if (language == null)
			{
				MessageBox.Show("Оберіть мову.", "Помилка");
				return;
			}
			if (publication == null)
			{
				MessageBox.Show("Оберіть видавництво.", "Помилка");
				return;
			}
			if (author == null)
			{
				MessageBox.Show("Оберіть автора.", "Помилка");
				return;
			}
			try
			{
				var newComposition = new Composition() { Name = name, Text = text, Author = author, Language = language, Publication = publication, Genres = genres };
				await compositionService.CreateAsync(newComposition);
				MessageBox.Show("Твір успішно створений.", "Успіх");

				await CreateCompositionsElementsAsync();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Помилка");
			}

		}

		private async void CompositionList_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (CompositionList.SelectedItem == null) return;

			selectedComposition = (Composition)CompositionList.SelectedItem;
			NameBox.Text = selectedComposition.Name;
			CompositionTextBox.Text = selectedComposition.Text;

			var selectedLanguage = selectedComposition.Language;
			if (selectedLanguage != null)
			{
				LanguageDropDown.SelectedItem = LanguageDropDown.Items
					.OfType<Language>()
					.FirstOrDefault(language => language.Id == selectedLanguage.Id);
			}

			var selectedPublication = selectedComposition.Publication;
			if (selectedPublication != null)
			{
				PublicationDropDown.SelectedItem = PublicationDropDown.Items
					.OfType<Publication>()
					.FirstOrDefault(publication => publication.Id == selectedPublication.Id);
			}

			var selectedAuthor = selectedComposition.Author;
			if (selectedAuthor != null)
			{
				AuthorDropDown.SelectedItem = AuthorDropDown.Items
					.OfType<Author>()
					.FirstOrDefault(author => author.Id == selectedAuthor.Id);
			}

			var cg = await compositionService.GetByIdWithGenres(selectedComposition.Id);
			UpdateSelectedGenres(cg.Genres.ToList());
		}

		private async void SaveCompositionBtn_Click(object sender, EventArgs e)
		{

			if (selectedComposition == null)
			{
				MessageBox.Show("Оберіть твір для редагування!", "Error");
				return;
			}
			var res = MessageBox.Show($"Оновити твір з назвою {selectedComposition.Name}?", "Підтвердіть", MessageBoxButtons.YesNo);
			if (res != DialogResult.Yes) return;

			var name = NameBox.Text.Trim();
			var text = CompositionTextBox.Text.Trim();
			var language = (Language)LanguageDropDown.SelectedValue;
			var publication = (Publication)PublicationDropDown.SelectedValue;
			var author = (Author)AuthorDropDown.SelectedValue;
			var genres = GenreListBox.SelectedItems.OfType<Genre>().ToList();

			if (name.Length < 3)
			{
				MessageBox.Show("Назва повинна містити принаймні три символи.", "Помилка");
				return;
			}
			if (text.Length < 3)
			{
				MessageBox.Show("Текст повинен містити принаймні три символи.", "Помилка");
				return;
			}
			if (language == null)
			{
				MessageBox.Show("Оберіть мову.", "Помилка");
				return;
			}
			if (publication == null)
			{
				MessageBox.Show("Оберіть видавництво.", "Помилка");
				return;
			}
			if (author == null)
			{
				MessageBox.Show("Оберіть автора.", "Помилка");
				return;
			}
			if (genres.Count == 0)
			{
				MessageBox.Show("Хоча б один жанр", "Помилка");
				return;
			}

			try
			{
				selectedComposition.Name = name;
				selectedComposition.Text = text;
				selectedComposition.Author = author;
				selectedComposition.Language = language;
				selectedComposition.Publication = publication;
				selectedComposition.Genres = genres;

				await compositionService.UpdateAsync(selectedComposition);
				await CreateCompositionsElementsAsync();

				MessageBox.Show("Інформацію про твір успішно оновлено.", "Успіх");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Помилка");
			}
		}

		private async void DeleteCompositionBtn_Click(object sender, EventArgs e)
		{
			if (selectedComposition == null)
			{
				MessageBox.Show("Виберіть що видалити");
				return;
			}
			var result = MessageBox.Show("Ви впевнені що хочете видалити цей твір?", "Видалення", MessageBoxButtons.YesNo);
			if (result == DialogResult.Yes)
			{
				var affected = await compositionService.DeleteAsync(selectedComposition);
				if (affected > 0)
				{
					await CreateCompositionsElementsAsync();
					CompositionList.Refresh();
					MessageBox.Show("Видалено успішно", "Видалення");
				}
			}
		}

		private void GenreUnselectAllBtn_Click(object sender, EventArgs e)
		{
			var res = MessageBox.Show("Ви точно хочете очистити вибрані жанри?", "Підтвердіть", MessageBoxButtons.YesNo);
			if (res == DialogResult.Yes)
			{
				GenreListBox.ClearSelected();
				GenreListBox.Refresh();
			}
		}

		private void UnselectCompositionsBtn_Click(object sender, EventArgs e)
		{
			selectedComposition = null;
			CompositionList.SelectedIndex = -1;
			NameBox.Clear();
			CompositionTextBox.Clear();
			GenreListBox.SelectedItems.Clear();

			AuthorDropDown.SelectedIndex = -1;
			LanguageDropDown.SelectedIndex = -1;
			PublicationDropDown.SelectedIndex = -1;
		}
	}
}
