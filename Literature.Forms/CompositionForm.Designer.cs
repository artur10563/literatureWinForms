namespace Literature.Forms
{
	partial class CompositionForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.DeleteCompositionBtn = new System.Windows.Forms.Button();
			this.panel22 = new System.Windows.Forms.Panel();
			this.label4324 = new System.Windows.Forms.Label();
			this.AuthorDropDown = new System.Windows.Forms.ComboBox();
			this.CompositionTextBox = new System.Windows.Forms.RichTextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.PublicationDropDown = new System.Windows.Forms.ComboBox();
			this.LanguageDropDown = new System.Windows.Forms.ComboBox();
			this.CountryLabel = new System.Windows.Forms.Label();
			this.NewCompositionBtn = new System.Windows.Forms.Button();
			this.SaveCompositionBtn = new System.Windows.Forms.Button();
			this.NameLabel = new System.Windows.Forms.Label();
			this.NameBox = new System.Windows.Forms.TextBox();
			this.CompositionList = new System.Windows.Forms.ListBox();
			this.GenreListBox = new System.Windows.Forms.ListBox();
			this.UnselectCompositionsBtn = new System.Windows.Forms.Button();
			this.GenreUnselectAllBtn = new System.Windows.Forms.Button();
			this.panel22.SuspendLayout();
			this.SuspendLayout();
			// 
			// DeleteCompositionBtn
			// 
			this.DeleteCompositionBtn.Location = new System.Drawing.Point(415, 90);
			this.DeleteCompositionBtn.Name = "DeleteCompositionBtn";
			this.DeleteCompositionBtn.Size = new System.Drawing.Size(200, 36);
			this.DeleteCompositionBtn.TabIndex = 0;
			this.DeleteCompositionBtn.Text = "Видалити";
			this.DeleteCompositionBtn.UseVisualStyleBackColor = true;
			this.DeleteCompositionBtn.Click += new System.EventHandler(this.DeleteCompositionBtn_Click);
			// 
			// panel22
			// 
			this.panel22.Controls.Add(this.label4324);
			this.panel22.Controls.Add(this.AuthorDropDown);
			this.panel22.Controls.Add(this.CompositionTextBox);
			this.panel22.Controls.Add(this.label1);
			this.panel22.Controls.Add(this.PublicationDropDown);
			this.panel22.Controls.Add(this.LanguageDropDown);
			this.panel22.Controls.Add(this.CountryLabel);
			this.panel22.Controls.Add(this.NewCompositionBtn);
			this.panel22.Controls.Add(this.DeleteCompositionBtn);
			this.panel22.Controls.Add(this.SaveCompositionBtn);
			this.panel22.Controls.Add(this.NameLabel);
			this.panel22.Controls.Add(this.NameBox);
			this.panel22.Location = new System.Drawing.Point(218, 4);
			this.panel22.Name = "panel22";
			this.panel22.Size = new System.Drawing.Size(743, 447);
			this.panel22.TabIndex = 10;
			// 
			// label4324
			// 
			this.label4324.AutoSize = true;
			this.label4324.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4324.Location = new System.Drawing.Point(560, 9);
			this.label4324.Name = "label4324";
			this.label4324.Size = new System.Drawing.Size(71, 25);
			this.label4324.TabIndex = 17;
			this.label4324.Text = "Автор";
			// 
			// AuthorDropDown
			// 
			this.AuthorDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.AuthorDropDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.AuthorDropDown.FormattingEnabled = true;
			this.AuthorDropDown.Location = new System.Drawing.Point(565, 37);
			this.AuthorDropDown.Name = "AuthorDropDown";
			this.AuthorDropDown.Size = new System.Drawing.Size(172, 33);
			this.AuthorDropDown.TabIndex = 16;
			// 
			// CompositionTextBox
			// 
			this.CompositionTextBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.CompositionTextBox.Location = new System.Drawing.Point(-2, 149);
			this.CompositionTextBox.Name = "CompositionTextBox";
			this.CompositionTextBox.Size = new System.Drawing.Size(739, 295);
			this.CompositionTextBox.TabIndex = 15;
			this.CompositionTextBox.Text = "";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(397, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(142, 25);
			this.label1.TabIndex = 14;
			this.label1.Text = "Видавництво";
			// 
			// PublicationDropDown
			// 
			this.PublicationDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.PublicationDropDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.PublicationDropDown.FormattingEnabled = true;
			this.PublicationDropDown.Location = new System.Drawing.Point(387, 37);
			this.PublicationDropDown.Name = "PublicationDropDown";
			this.PublicationDropDown.Size = new System.Drawing.Size(172, 33);
			this.PublicationDropDown.TabIndex = 13;
			// 
			// LanguageDropDown
			// 
			this.LanguageDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.LanguageDropDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.LanguageDropDown.FormattingEnabled = true;
			this.LanguageDropDown.Location = new System.Drawing.Point(209, 37);
			this.LanguageDropDown.Name = "LanguageDropDown";
			this.LanguageDropDown.Size = new System.Drawing.Size(172, 33);
			this.LanguageDropDown.TabIndex = 9;
			// 
			// CountryLabel
			// 
			this.CountryLabel.AutoSize = true;
			this.CountryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.CountryLabel.Location = new System.Drawing.Point(204, 9);
			this.CountryLabel.Name = "CountryLabel";
			this.CountryLabel.Size = new System.Drawing.Size(177, 25);
			this.CountryLabel.TabIndex = 7;
			this.CountryLabel.Text = "Мова перекладу";
			// 
			// NewCompositionBtn
			// 
			this.NewCompositionBtn.Location = new System.Drawing.Point(3, 90);
			this.NewCompositionBtn.Name = "NewCompositionBtn";
			this.NewCompositionBtn.Size = new System.Drawing.Size(200, 36);
			this.NewCompositionBtn.TabIndex = 4;
			this.NewCompositionBtn.Text = "Створити";
			this.NewCompositionBtn.UseVisualStyleBackColor = true;
			this.NewCompositionBtn.Click += new System.EventHandler(this.NewCompositionBtn_Click);
			// 
			// SaveCompositionBtn
			// 
			this.SaveCompositionBtn.Location = new System.Drawing.Point(209, 90);
			this.SaveCompositionBtn.Name = "SaveCompositionBtn";
			this.SaveCompositionBtn.Size = new System.Drawing.Size(200, 36);
			this.SaveCompositionBtn.TabIndex = 3;
			this.SaveCompositionBtn.Text = "Оновити";
			this.SaveCompositionBtn.UseVisualStyleBackColor = true;
			this.SaveCompositionBtn.Click += new System.EventHandler(this.SaveCompositionBtn_Click);
			// 
			// NameLabel
			// 
			this.NameLabel.AutoSize = true;
			this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.NameLabel.Location = new System.Drawing.Point(1, 11);
			this.NameLabel.Name = "NameLabel";
			this.NameLabel.Size = new System.Drawing.Size(73, 25);
			this.NameLabel.TabIndex = 2;
			this.NameLabel.Text = "Назва";
			// 
			// NameBox
			// 
			this.NameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.NameBox.Location = new System.Drawing.Point(3, 37);
			this.NameBox.Name = "NameBox";
			this.NameBox.Size = new System.Drawing.Size(200, 35);
			this.NameBox.TabIndex = 1;
			// 
			// CompositionList
			// 
			this.CompositionList.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.CompositionList.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.CompositionList.ForeColor = System.Drawing.SystemColors.Menu;
			this.CompositionList.FormattingEnabled = true;
			this.CompositionList.ItemHeight = 23;
			this.CompositionList.Location = new System.Drawing.Point(3, 56);
			this.CompositionList.Name = "CompositionList";
			this.CompositionList.Size = new System.Drawing.Size(208, 395);
			this.CompositionList.TabIndex = 11;
			this.CompositionList.SelectedIndexChanged += new System.EventHandler(this.CompositionList_SelectedIndexChanged);
			// 
			// GenreListBox
			// 
			this.GenreListBox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.GenreListBox.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.GenreListBox.ForeColor = System.Drawing.SystemColors.Menu;
			this.GenreListBox.FormattingEnabled = true;
			this.GenreListBox.ItemHeight = 23;
			this.GenreListBox.Location = new System.Drawing.Point(964, 57);
			this.GenreListBox.Name = "GenreListBox";
			this.GenreListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
			this.GenreListBox.Size = new System.Drawing.Size(215, 395);
			this.GenreListBox.TabIndex = 18;
			// 
			// UnselectCompositionsBtn
			// 
			this.UnselectCompositionsBtn.Location = new System.Drawing.Point(2, 15);
			this.UnselectCompositionsBtn.Name = "UnselectCompositionsBtn";
			this.UnselectCompositionsBtn.Size = new System.Drawing.Size(209, 36);
			this.UnselectCompositionsBtn.TabIndex = 19;
			this.UnselectCompositionsBtn.Text = "Очистити вибране";
			this.UnselectCompositionsBtn.UseVisualStyleBackColor = true;
			this.UnselectCompositionsBtn.Click += new System.EventHandler(this.UnselectCompositionsBtn_Click);
			// 
			// GenreUnselectAllBtn
			// 
			this.GenreUnselectAllBtn.Location = new System.Drawing.Point(964, 15);
			this.GenreUnselectAllBtn.Name = "GenreUnselectAllBtn";
			this.GenreUnselectAllBtn.Size = new System.Drawing.Size(209, 36);
			this.GenreUnselectAllBtn.TabIndex = 20;
			this.GenreUnselectAllBtn.Text = "Очистити вибране";
			this.GenreUnselectAllBtn.UseVisualStyleBackColor = true;
			this.GenreUnselectAllBtn.Click += new System.EventHandler(this.GenreUnselectAllBtn_Click);
			// 
			// CompositionForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.ClientSize = new System.Drawing.Size(1184, 452);
			this.Controls.Add(this.GenreUnselectAllBtn);
			this.Controls.Add(this.UnselectCompositionsBtn);
			this.Controls.Add(this.GenreListBox);
			this.Controls.Add(this.panel22);
			this.Controls.Add(this.CompositionList);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "CompositionForm";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "CompositionForm";
			this.Load += new System.EventHandler(this.CompositionForm_Load);
			this.panel22.ResumeLayout(false);
			this.panel22.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button DeleteCompositionBtn;
		private System.Windows.Forms.Panel panel22;
		private System.Windows.Forms.ComboBox LanguageDropDown;
		private System.Windows.Forms.Label CountryLabel;
		private System.Windows.Forms.Button NewCompositionBtn;
		private System.Windows.Forms.Button SaveCompositionBtn;
		private System.Windows.Forms.Label NameLabel;
		private System.Windows.Forms.TextBox NameBox;
		private System.Windows.Forms.ListBox CompositionList;
		private System.Windows.Forms.RichTextBox CompositionTextBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox PublicationDropDown;
		private System.Windows.Forms.ListBox GenreListBox;
		private System.Windows.Forms.Button UnselectCompositionsBtn;
		private System.Windows.Forms.Button GenreUnselectAllBtn;
		private System.Windows.Forms.Label label4324;
		private System.Windows.Forms.ComboBox AuthorDropDown;
	}
}