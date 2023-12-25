using Literature.Forms.Data.Entities;
using Literature.Forms.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Literature.Forms
{
	public partial class AuthorForm : Form
	{
		private static AuthorService authorService;
		private static CountryService countryService;
		private static Author selectedAuthor;

		private async Task CreateAuthorsElementsAsync()
		{
			var authors = await authorService.GetAll(); ;
			AuthorsList.DataSource = authors;
			AuthorsList.DisplayMember = "FullName";
		}

		public AuthorForm()
		{
			InitializeComponent();
		}

		private async void AuthorForm_Load(object sender, EventArgs e)
		{
			authorService = new AuthorService();
			countryService = new CountryService();
			

			CountryDropDown.DataSource = await countryService.GetAll();
			CountryDropDown.DisplayMember = "Name";
			await CreateAuthorsElementsAsync();
		}

		private async void NewAuthorBtn_Click(object sender, EventArgs e)
		{
			var fname = FirstNameBox.Text.Trim();
			var lname = LastNameBox.Text.Trim();
			var country = (Country)CountryDropDown.SelectedValue;

			if (fname.Length < 3)
			{
				MessageBox.Show("Ім'я повинно містити принаймні три символи.", "Помилка");
				return;
			}

			if (lname.Length < 3)
			{
				MessageBox.Show("Прізвище повинно містити принаймні три символи.", "Помилка");
				return;
			}

			if (country == null)
			{
				MessageBox.Show("Оберіть країну.", "Помилка");
				return;
			}

			try
			{
				var newAuthor = new Author() { FirstName = fname, LastName = lname, Country = country };
				await authorService.CreateAsync(newAuthor);
				MessageBox.Show("Автор успішно створений.", "Успіх");

				await CreateAuthorsElementsAsync();
				AuthorsList.Refresh();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Помилка");
			}
		}

		private async void SaveAuthorBtn_Click(object sender, EventArgs e)
		{
			if (selectedAuthor == null)
			{
				MessageBox.Show("Оберіть автора для редагування!", "Error");
				return;
			}
			var res = MessageBox.Show($"Оновити автора {selectedAuthor.FullName}?", "Підтвердіть", MessageBoxButtons.YesNo);
			if (res != DialogResult.Yes) return;

			var fname = FirstNameBox.Text.Trim();
			var lname = LastNameBox.Text.Trim();
			var country = (Country)CountryDropDown.SelectedItem;

			if (fname.Length < 3)
			{
				MessageBox.Show("Ім'я повинно містити принаймні три символи.", "Помилка");
				return;
			}

			if (lname.Length < 3)
			{
				MessageBox.Show("Прізвище повинно містити принаймні три символи.", "Помилка");
				return;
			}

			if (country == null)
			{
				MessageBox.Show("Оберіть країну.", "Помилка");
				return;
			}

			try
			{
				selectedAuthor.FirstName = fname;
				selectedAuthor.LastName = lname;
				selectedAuthor.Country = country;

				await authorService.UpdateAsync(selectedAuthor);
				await CreateAuthorsElementsAsync();

				MessageBox.Show("Інформацію про автора успішно оновлено.", "Успіх");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Помилка");
			}

		}

		private void AuthorsList_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (AuthorsList.SelectedItem != null)
			{
				selectedAuthor = (Author)AuthorsList.SelectedItem;
				FirstNameBox.Text = selectedAuthor.FirstName;
				LastNameBox.Text = selectedAuthor.LastName;

				var selectedCountry = selectedAuthor.Country;
				if (selectedCountry != null)
				{
					CountryDropDown.SelectedItem = CountryDropDown.Items
						.OfType<Country>()
						.FirstOrDefault(country => country.Id == selectedCountry.Id);
				}
			}
		}

		private async void DeleteAuthorBtn_Click(object sender, EventArgs e)
		{
			if (selectedAuthor == null)
			{
				MessageBox.Show("Виберіть що видалити");
				return;
			}
			var result = MessageBox.Show("Ви впевнені що хочете видалити цього автора?", "Видалення", MessageBoxButtons.YesNo);
			if (result == DialogResult.Yes)
			{
				var affected = await authorService.DeleteAsync(selectedAuthor);
				if (affected > 0)
				{
					await CreateAuthorsElementsAsync();
					AuthorsList.Refresh();
					MessageBox.Show("Видалено успішно", "Видалення");
				}
			}
		}

		private void AuthorUnselectBtn_Click(object sender, EventArgs e)
		{
			selectedAuthor = null;
			AuthorsList.SelectedIndex = -1;
			FirstNameBox.Clear();
			LastNameBox.Clear();
			
			CountryDropDown.SelectedIndex = -1;
		}
	}
}
