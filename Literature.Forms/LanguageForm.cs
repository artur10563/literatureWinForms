using Literature.Forms.Data.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using Literature.Forms.Data.Services;

namespace Literature.Forms
{
	public partial class LanguageForm : Form
	{
		private static Language selectedLanguage;
		private static LanguageService languageService;
		private static async Task<List<Language>> LoadLanguages()
		{
			return await languageService.GetAll();
		}
		private async Task CreateLanguageElementsAsync()
		{
			var languages = await LoadLanguages();
			LanguageList.DataSource = languages;
			LanguageList.DisplayMember = "Name";
		}

		public LanguageForm()
		{
			InitializeComponent();
		}


		private async void LanguageForm_Load(object sender, EventArgs e)
		{
			languageService = new LanguageService();
			await CreateLanguageElementsAsync();
		}
		private void LanguageList_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (LanguageList.SelectedItem != null)
			{
				selectedLanguage = (Language)LanguageList.SelectedItem;
				LanguageNameBox.Text = selectedLanguage.Name;
			}
		}

		private async void NewLanguageBtn_Click(object sender, EventArgs e)
		{

			var newName = LanguageNameBox.Text.Trim();
			if (newName.Length < 3) MessageBox.Show("Три символа мінімум", "Помилка");

			try
			{
				var newLanguage = new Language() { Name = newName };
				selectedLanguage = await languageService.CreateAsync(newLanguage);
				if (selectedLanguage != null) MessageBox.Show("Успішно створено", "Успіх");
				await CreateLanguageElementsAsync();
				LanguageList.Refresh();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error");
			}
		}

		private async void SaveLanguageBtn_Click(object sender, EventArgs e)
		{
			if (selectedLanguage == null)
			{
				MessageBox.Show("Оберіть мову для редагування!", "Error");
				return;
			}

			var newName = LanguageNameBox.Text.Trim();
			if (newName.Length >= 3)
			{
				selectedLanguage.Name = newName;
				var affected = 0;
				try
				{
					affected = await languageService.UpdateAsync(selectedLanguage);
					if (affected == 1)
					{
						await CreateLanguageElementsAsync();
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

		private async void DeleteLanguageBtn_Click(object sender, EventArgs e)
		{
			if (selectedLanguage == null)
			{
				MessageBox.Show("Три символа мінімум", "Помилка");
				return;
			}
			var result = MessageBox.Show("Ви впевнені що хочете видалити цю мову?", "Видалення", MessageBoxButtons.YesNo);
			if (result == DialogResult.Yes)
			{

				try
				{
					var affected = await languageService.DeleteAsync(selectedLanguage);
					if (affected > 0)
					{
						await CreateLanguageElementsAsync();
						LanguageList.Refresh();
						MessageBox.Show("Видалено успішно", "Видалення");
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, "Error");
				}
			}
		}

		private void LanguageUnselectBtn_Click(object sender, EventArgs e)
		{
			selectedLanguage = null;
			LanguageList.SelectedIndex = -1;
			LanguageNameBox.Clear();
		}
	}
}
