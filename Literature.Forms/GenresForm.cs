using Literature.Forms.Data.Entities;
using Literature.Forms.Data.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Literature.Forms
{
	public partial class GenresForm : Form
	{
		private static Genre selectedGenre;
		private static GenreService genreService;
		private static async Task<List<Genre>> LoadGenres()
		{
			return await genreService.GetAll();
		}
		private async Task CreateGenreElementsAsync()
		{
			var genres = await LoadGenres();
			GenresList.DataSource = genres;
			GenresList.DisplayMember = "Name";
		}

		public GenresForm()
		{
			InitializeComponent();
		}

		private async void GenresForm_Load(object sender, EventArgs e)
		{
			genreService = new GenreService();
			await CreateGenreElementsAsync();
		}

		private void Genres_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (GenresList.SelectedItem != null)
			{
				selectedGenre = (Genre)GenresList.SelectedItem;
				GenreNameBox.Text = selectedGenre.Name;
			}
		}

		private async void SaveGenreBtn_Click_1(object sender, EventArgs e)
		{
			if (selectedGenre == null)
			{
				MessageBox.Show("Оберіть жанр для редагування!", "Error");
				return;
			}

			var newName = GenreNameBox.Text.Trim();
			if (newName.Length >= 3)
			{
				selectedGenre.Name = newName;
				var affected = 0;
				try
				{
					affected = await genreService.UpdateAsync(selectedGenre);
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, "Error");
				}

				if (affected == 1)
				{
					await CreateGenreElementsAsync();
					MessageBox.Show("Оновлено успішно", "Успіх");
				}
				else
					MessageBox.Show("Помилка при оновленні", "Помилка");
			}
			else
				MessageBox.Show("Довжина має бути більше 3 символів", "Помилка");

		}

		private async void DeleteGenreBtn_Click(object sender, EventArgs e)
		{
			if (selectedGenre == null)
			{
				MessageBox.Show("Виберіть що видалити");
				return;
			}
			var result = MessageBox.Show("Ви впевнені що хочете видалити цей жанр?", "Видалення", MessageBoxButtons.YesNo);
			if (result == DialogResult.Yes)
			{
				try
				{
					var affected = await genreService.DeleteAsync(selectedGenre);
					if (affected > 0)
					{
						await CreateGenreElementsAsync();
						GenresList.Refresh();
						MessageBox.Show("Видалено успішно", "Видалення");
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, "Error");
				}


			}
		}

		private async void NewGenreBtn_Click(object sender, EventArgs e)
		{

			var newName = GenreNameBox.Text.Trim();
			if (newName.Length < 3)
			{
				MessageBox.Show("Три символа мінімум", "Помилка");
				return;
			}
			try
			{
				var newGenre = new Genre() { Name = newName };
				selectedGenre = await genreService.CreateAsync(newGenre);
				if (selectedGenre != null) MessageBox.Show("Успішно створено", "Успіх");
				await CreateGenreElementsAsync();
				GenresList.Refresh();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error");
			}
		}

		private void GenreUnselectBtn_Click(object sender, EventArgs e)
		{
			selectedGenre = null;
			GenresList.SelectedIndex = -1;
			GenreNameBox.Clear();
		}
	}
}

