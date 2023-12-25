using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using Literature.Forms.Data.Entities;
using Literature.Forms.Data.Services;

namespace Literature.Forms
{
	public partial class CountryForm : Form
	{
		private static CountryService countryService;
		private static Country selectedCountry;
		private static async Task<List<Country>> LoadCountries()
		{
			return await countryService.GetAll();
		}
		private async Task CreateCountryElementsAsync()
		{
			var countries = await LoadCountries();
			CountriesList.DataSource = countries;
			CountriesList.DisplayMember = "Name";
		}

		public CountryForm()
		{
			InitializeComponent();
		}

		private void CountryList_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (CountriesList.SelectedItem != null)
			{
				selectedCountry = (Country)CountriesList.SelectedItem;
				CountryNameBox.Text = selectedCountry.Name;
			}
		}

		private async void NewCountryBtn_Click(object sender, EventArgs e)
		{
			var newName = CountryNameBox.Text.Trim();
			if (newName.Length < 3) MessageBox.Show("Три символа мінімум", "Помилка");

			try
			{
				var newCountry = new Country() { Name = newName };
				selectedCountry = await countryService.CreateAsync(newCountry);
				if (selectedCountry != null) MessageBox.Show("Успішно створено", "Успіх");
				await CreateCountryElementsAsync();
				CountriesList.Refresh();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error");
			}
		}

		private async void SaveCountryBtn_Click(object sender, EventArgs e)
		{
			if (selectedCountry == null)
			{
				MessageBox.Show("Оберіть країну для редагування!", "Error");
				return;
			}

			var newName = CountryNameBox.Text.Trim();
			if (newName.Length >= 3)
			{
				selectedCountry.Name = newName;
				var affected = 0;
				try
				{
					affected = await countryService.UpdateAsync(selectedCountry);
					if (affected == 1)
					{
						await CreateCountryElementsAsync();
						MessageBox.Show("Оновлено успішно", "Успіх");
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, "Error");
				}
			}
			else
				MessageBox.Show("Довжина має бути більше 3 символів", "Помилка");
		}

		private async void DeleteCountryBtn_Click(object sender, EventArgs e)
		{
			if (selectedCountry == null)
			{
				MessageBox.Show("Виберіть що видалити");
				return;
			}
			var result = MessageBox.Show("Ви впевнені що хочете видалити цю мову?", "Видалення", MessageBoxButtons.YesNo);
			if (result == DialogResult.Yes)
			{
				try
				{
					var affected = await countryService.DeleteAsync(selectedCountry);
					if (affected > 0)
					{
						await CreateCountryElementsAsync();
						CountriesList.Refresh();
						MessageBox.Show("Видалено успішно", "Видалення");
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, "Error");
				}


			}
		}

		private async void CountryForm_Load_1(object sender, EventArgs e)
		{
			countryService = new CountryService();
			await CreateCountryElementsAsync();
		}

		private void CountriesList_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (CountriesList.SelectedItem != null)
			{
				selectedCountry = (Country)CountriesList.SelectedItem;
				CountryNameBox.Text = selectedCountry.Name;
			}
		}

		private void CountryUnselectBtn_Click(object sender, EventArgs e)
		{
			selectedCountry = null;
			CountriesList.SelectedIndex = -1;
			CountryNameBox.Clear();
		}
	}
}
