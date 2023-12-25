using Literature.Forms.Data.Entities;
using Literature.Forms.Data.Services;
using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Literature.Forms
{
	public partial class PublicationForm : Form
	{
		private static PublicationService publicationService;
		private static CountryService countryService;
		private static Publication selectedPublication;
		private static readonly Regex EmailRegex = new Regex("^\\S+@\\S+\\.\\S+$");

		private async Task CreatePublicationsElementsAsync()
		{
			var publications = await publicationService.GetAll(); ;
			PublicationList.DataSource = publications;
			PublicationList.DisplayMember = "Name";
		}

		public PublicationForm()
		{
			InitializeComponent();
		}

		private async void PublicationForm_Load(object sender, EventArgs e)
		{
			publicationService = new PublicationService();
			countryService = new CountryService();


			CountryDropDown.DataSource = await countryService.GetAll();
			CountryDropDown.DisplayMember = "Name";
			await CreatePublicationsElementsAsync();
		}

		private async void NewPublicationBtn_Click(object sender, EventArgs e)
		{
			var name = NameBox.Text.Trim();
			var country = (Country)CountryDropDown.SelectedValue;
			var email = EmailBox.Text.Trim();
			int year;

			if (!int.TryParse(YearBox.Text.Trim(), out year))
			{
				MessageBox.Show("Введіть правильний рік заснування", "Помилка");
				return;
			}

			if (name.Length < 3)
			{
				MessageBox.Show("Ім'я повинно містити принаймні три символи.", "Помилка");
				return;
			}

			if (country == null)
			{
				MessageBox.Show("Оберіть країну.", "Помилка");
				return;
			}

			if (!EmailRegex.IsMatch(email))
			{
				MessageBox.Show("Введіть правильний email", "Помилка");
				return;
			}

			try
			{
				var newPublication = new Publication() { Name = name, Email = email, Created_Year = year, Country = country };
				await publicationService.CreateAsync(newPublication);
				MessageBox.Show("Видавництво успішно створено.", "Успіх");

				await CreatePublicationsElementsAsync();
				PublicationList.Refresh();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Помилка");
			}
		}

		private void PublicationList_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (PublicationList.SelectedItem != null)
			{
				selectedPublication = (Publication)PublicationList.SelectedItem;
				NameBox.Text = selectedPublication.Name;
				EmailBox.Text = selectedPublication.Email;
				YearBox.Text = selectedPublication.Created_Year.ToString();

				var selectedCountry = selectedPublication.Country;
				if (selectedCountry != null)
				{
					CountryDropDown.SelectedItem = CountryDropDown.Items
						.OfType<Country>()
						.FirstOrDefault(country => country.Id == selectedCountry.Id);
				}
			}
		}

		private async void SavePublicationBtn_Click(object sender, EventArgs e)
		{
			if (selectedPublication == null)
			{
				MessageBox.Show("Оберіть видавництво для редагування!", "Error");
				return;
			}

			var name = NameBox.Text.Trim();
			var country = (Country)CountryDropDown.SelectedValue;
			var email = EmailBox.Text.Trim();
			int year;

			if (!int.TryParse(YearBox.Text.Trim(), out year))
			{
				MessageBox.Show("Введіть правильний рік заснування", "Помилка");
				return;
			}

			if (name.Length < 3)
			{
				MessageBox.Show("Ім'я повинно містити принаймні три символи.", "Помилка");
				return;
			}

			if (country == null)
			{
				MessageBox.Show("Оберіть країну.", "Помилка");
				return;
			}

			if (!EmailRegex.IsMatch(email))
			{
				MessageBox.Show("Введіть правильний email", "Помилка");
				return;
			}

			try
			{
				selectedPublication.Name = name;
				selectedPublication.Email = email;
				selectedPublication.Country = country;
				selectedPublication.Created_Year = year;

				await publicationService.UpdateAsync(selectedPublication);
				await CreatePublicationsElementsAsync();

				MessageBox.Show("Інформацію про видавництво успішно оновлено.", "Успіх");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Помилка");
			}

		}

		private async void DeletePublicationBtn_Click(object sender, EventArgs e)
		{
			if (selectedPublication == null)
			{
				MessageBox.Show("Виберіть що видалити");
				return;
			}
			var result = MessageBox.Show("Ви впевнені що хочете видалити це видавництво?", "Видалення", MessageBoxButtons.YesNo);
			if (result == DialogResult.Yes)
			{
				try
				{
					var affected = await publicationService.DeleteAsync(selectedPublication);
					if (affected > 0)
					{
						await CreatePublicationsElementsAsync();
						PublicationList.Refresh();
						MessageBox.Show("Видалено успішно", "Видалення");
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, "Error");
				}
				
			}
		}

		private void PublicationUnselectBtn_Click(object sender, EventArgs e)
		{
			selectedPublication = null;
			PublicationList.SelectedIndex = -1;
			NameBox.Clear();
			EmailBox.Clear();
			YearBox.Clear();
			CountryDropDown.SelectedIndex = -1;
		}
	}
}
