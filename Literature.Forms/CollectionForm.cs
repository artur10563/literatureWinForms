using Literature.Forms.Data.Entities;
using Literature.Forms.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Literature.Forms
{
	public partial class CollectionForm : Form
	{
		private static CollectionService collectionService;
		private static CompositionService compositionService;

		private static Collection selectedCollection;

		private async Task CreateCollectionsElementsAsync()
		{
			CollectionList.DataSource = await collectionService.GetAll();
			CollectionList.DisplayMember = "Name";
			CollectionList.Refresh();
		}

		private void UpdateSelectedCompositions(List<Composition> compositions)
		{
			CompositionListBox.ClearSelected();

			foreach (Composition composition in compositions)
			{
				if (composition == null) continue;
				int index = CompositionListBox.Items.OfType<Composition>().Select(i => i.Id).ToList().IndexOf(composition.Id);
				if (index != -1)
				{
					CompositionListBox.SetSelected(index, true);
				}
			}

			CompositionListBox.Refresh();
		}

		public CollectionForm()
		{
			InitializeComponent();
		}

		private async void CollectionForm_Load(object sender, EventArgs e)
		{
			collectionService = new CollectionService();
			compositionService = new CompositionService();

			CompositionListBox.DataSource = await compositionService.GetAll();
			CompositionListBox.DisplayMember = "Name";

			CompositionListBox.ClearSelected();
			await CreateCollectionsElementsAsync();
		}

		private async void SaveCollectionBtn_Click(object sender, EventArgs e)
		{
			if (selectedCollection == null)
			{
				MessageBox.Show("Оберіть колекцію для редагування!", "Error");
				return;
			}
			var res = MessageBox.Show($"Оновити колекцію з назвою {selectedCollection.Name}?", "Підтвердіть", MessageBoxButtons.YesNo);
			if (res != DialogResult.Yes) return;

			var name = NameBox.Text.Trim();
			var description = CollectionTextBox.Text.Trim();
			var compositions = CompositionListBox.SelectedItems.OfType<Composition>().ToList();

			if (name.Length < 3)
			{
				MessageBox.Show("Назва повинна містити принаймні три символи.", "Помилка");
				return;
			}
			if (description.Length < 3)
			{
				MessageBox.Show("Опис повинен містити принаймні три символи.", "Помилка");
				return;
			}
			if (compositions.Count == 0)
			{
				MessageBox.Show("Хоча б один твір", "Помилка");
				return;
			}

			try
			{
				selectedCollection.Name = name;
				selectedCollection.Description = description;
				selectedCollection.Compositions = compositions;

				await collectionService.UpdateAsync(selectedCollection);
				await CreateCollectionsElementsAsync();

				MessageBox.Show("Інформацію про колекцію успішно оновлено.", "Успіх");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Помилка");
			}
		}

		private async void NewCollectionBtn_Click(object sender, EventArgs e)
		{
			var name = NameBox.Text.Trim();
			var text = CollectionTextBox.Text.Trim();
			var compositions = CompositionListBox.SelectedItems.OfType<Composition>().ToList();

			if (compositions.Count == 0)
			{
				MessageBox.Show("Хоча б один твір", "Помилка");
				return;
			}
			if (name.Length < 3)
			{
				MessageBox.Show("Назва повинна містити принаймні три символи.", "Помилка");
				return;
			}
			if (text.Length < 3)
			{
				MessageBox.Show("Опис повинний містити принаймні три символи.", "Помилка");
				return;
			}

			try
			{
				var newCollection = new Collection() { Name = name, Description = text, Compositions = compositions };
				await collectionService.CreateAsync(newCollection);
				MessageBox.Show("Колекцію успішно створено.", "Успіх");

				await CreateCollectionsElementsAsync();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Помилка");
			}

		}

		private async void DeleteCollectionBtn_Click(object sender, EventArgs e)
		{
			if (selectedCollection == null)
			{
				MessageBox.Show("Виберіть що видалити");
				return;
			}
			var result = MessageBox.Show("Ви впевнені що хочете видалити цю колекцію?", "Видалення", MessageBoxButtons.YesNo);
			if (result == DialogResult.Yes)
			{
				var affected = await collectionService.DeleteAsync(selectedCollection);
				if (affected > 0)
				{
					await CreateCollectionsElementsAsync();
					CollectionList.Refresh();
					MessageBox.Show("Видалено успішно", "Видалення");
				}
			}
		}

		private async void CollectionList_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (CollectionList.SelectedItem == null) return;

			selectedCollection = (Collection)CollectionList.SelectedItem;
			NameBox.Text = selectedCollection.Name;
			CollectionTextBox.Text = selectedCollection.Description;

			var cc = await collectionService.GetByIdWithCompositions(selectedCollection.Id);

			UpdateSelectedCompositions(cc.Compositions.ToList());
		}

		private void CollectionUnselectBtn_Click(object sender, EventArgs e)
		{
			selectedCollection = null;
			CollectionList.SelectedIndex = -1;
			NameBox.Clear();
			CollectionTextBox.Clear();
			CompositionListBox.ClearSelected();
		}

		private void CompositionUnselectAllBtn_Click(object sender, EventArgs e)
		{
			var res = MessageBox.Show("Ви точно хочете очистити вибрані твори?", "Підтвердіть", MessageBoxButtons.YesNo);
			if (res == DialogResult.Yes)
			{
				CompositionListBox.ClearSelected();
				CompositionListBox.Refresh();
			}
		}
	}
}
