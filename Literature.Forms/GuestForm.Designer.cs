namespace Literature.Forms
{
	partial class GuestForm
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
			this.CollectionList = new System.Windows.Forms.ListBox();
			this.CompositionList = new System.Windows.Forms.ListBox();
			this.infoPanel = new System.Windows.Forms.Panel();
			this.informationPanel = new System.Windows.Forms.Panel();
			this.label3 = new System.Windows.Forms.Label();
			this.searchBox = new System.Windows.Forms.TextBox();
			this.compositionNameLabel = new System.Windows.Forms.Label();
			this.GenresLabel = new System.Windows.Forms.Label();
			this.AuthorNameLabel = new System.Windows.Forms.Label();
			this.label12433124 = new System.Windows.Forms.Label();
			this.PublicationLabel = new System.Windows.Forms.Label();
			this.ContactsLabel = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label54325345 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.LanguageLabel = new System.Windows.Forms.Label();
			this.CompositionText = new System.Windows.Forms.RichTextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.infoPanel.SuspendLayout();
			this.informationPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// CollectionList
			// 
			this.CollectionList.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.CollectionList.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.CollectionList.ForeColor = System.Drawing.SystemColors.Menu;
			this.CollectionList.FormattingEnabled = true;
			this.CollectionList.ItemHeight = 27;
			this.CollectionList.Location = new System.Drawing.Point(0, 31);
			this.CollectionList.Name = "CollectionList";
			this.CollectionList.Size = new System.Drawing.Size(213, 517);
			this.CollectionList.Sorted = true;
			this.CollectionList.TabIndex = 22;
			this.CollectionList.SelectedIndexChanged += new System.EventHandler(this.CollectionList_SelectedIndexChanged);
			// 
			// CompositionList
			// 
			this.CompositionList.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.CompositionList.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.CompositionList.ForeColor = System.Drawing.SystemColors.Menu;
			this.CompositionList.FormattingEnabled = true;
			this.CompositionList.ItemHeight = 27;
			this.CompositionList.Location = new System.Drawing.Point(211, 31);
			this.CompositionList.Name = "CompositionList";
			this.CompositionList.Size = new System.Drawing.Size(213, 517);
			this.CompositionList.TabIndex = 23;
			this.CompositionList.SelectedIndexChanged += new System.EventHandler(this.CompositionList_SelectedIndexChanged);
			// 
			// infoPanel
			// 
			this.infoPanel.Controls.Add(this.label3);
			this.infoPanel.Controls.Add(this.informationPanel);
			this.infoPanel.Controls.Add(this.CompositionText);
			this.infoPanel.Controls.Add(this.searchBox);
			this.infoPanel.Location = new System.Drawing.Point(423, 1);
			this.infoPanel.Name = "infoPanel";
			this.infoPanel.Size = new System.Drawing.Size(776, 545);
			this.infoPanel.TabIndex = 24;
			// 
			// informationPanel
			// 
			this.informationPanel.Controls.Add(this.compositionNameLabel);
			this.informationPanel.Controls.Add(this.GenresLabel);
			this.informationPanel.Controls.Add(this.AuthorNameLabel);
			this.informationPanel.Controls.Add(this.label12433124);
			this.informationPanel.Controls.Add(this.PublicationLabel);
			this.informationPanel.Controls.Add(this.ContactsLabel);
			this.informationPanel.Controls.Add(this.label1);
			this.informationPanel.Controls.Add(this.label54325345);
			this.informationPanel.Controls.Add(this.label2);
			this.informationPanel.Controls.Add(this.LanguageLabel);
			this.informationPanel.Location = new System.Drawing.Point(3, 3);
			this.informationPanel.Name = "informationPanel";
			this.informationPanel.Size = new System.Drawing.Size(575, 174);
			this.informationPanel.TabIndex = 11;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(632, 2);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(78, 25);
			this.label3.TabIndex = 13;
			this.label3.Text = "Пошук";
			// 
			// searchBox
			// 
			this.searchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.searchBox.Location = new System.Drawing.Point(596, 30);
			this.searchBox.Name = "searchBox";
			this.searchBox.Size = new System.Drawing.Size(152, 29);
			this.searchBox.TabIndex = 12;
			this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
			// 
			// compositionNameLabel
			// 
			this.compositionNameLabel.AutoSize = true;
			this.compositionNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.compositionNameLabel.Location = new System.Drawing.Point(3, 13);
			this.compositionNameLabel.Name = "compositionNameLabel";
			this.compositionNameLabel.Size = new System.Drawing.Size(231, 31);
			this.compositionNameLabel.TabIndex = 0;
			this.compositionNameLabel.Text = "compositionName";
			// 
			// GenresLabel
			// 
			this.GenresLabel.AutoSize = true;
			this.GenresLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.GenresLabel.Location = new System.Drawing.Point(72, 142);
			this.GenresLabel.Name = "GenresLabel";
			this.GenresLabel.Size = new System.Drawing.Size(118, 24);
			this.GenresLabel.TabIndex = 10;
			this.GenresLabel.Text = "GenresLabel";
			// 
			// AuthorNameLabel
			// 
			this.AuthorNameLabel.AutoSize = true;
			this.AuthorNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.AuthorNameLabel.Location = new System.Drawing.Point(3, 44);
			this.AuthorNameLabel.Name = "AuthorNameLabel";
			this.AuthorNameLabel.Size = new System.Drawing.Size(163, 24);
			this.AuthorNameLabel.TabIndex = 1;
			this.AuthorNameLabel.Text = "AuthorNameLabel";
			// 
			// label12433124
			// 
			this.label12433124.AutoSize = true;
			this.label12433124.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label12433124.Location = new System.Drawing.Point(3, 142);
			this.label12433124.Name = "label12433124";
			this.label12433124.Size = new System.Drawing.Size(74, 24);
			this.label12433124.TabIndex = 9;
			this.label12433124.Text = "Жанри:";
			// 
			// PublicationLabel
			// 
			this.PublicationLabel.AutoSize = true;
			this.PublicationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.PublicationLabel.Location = new System.Drawing.Point(136, 69);
			this.PublicationLabel.Name = "PublicationLabel";
			this.PublicationLabel.Size = new System.Drawing.Size(148, 24);
			this.PublicationLabel.TabIndex = 2;
			this.PublicationLabel.Text = "PublicationLabel";
			// 
			// ContactsLabel
			// 
			this.ContactsLabel.AutoSize = true;
			this.ContactsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.ContactsLabel.Location = new System.Drawing.Point(106, 94);
			this.ContactsLabel.Name = "ContactsLabel";
			this.ContactsLabel.Size = new System.Drawing.Size(125, 24);
			this.ContactsLabel.TabIndex = 8;
			this.ContactsLabel.Text = "contactsLabel";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(3, 69);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(136, 24);
			this.label1.TabIndex = 3;
			this.label1.Text = "Видавництво:";
			// 
			// label54325345
			// 
			this.label54325345.AutoSize = true;
			this.label54325345.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label54325345.Location = new System.Drawing.Point(3, 94);
			this.label54325345.Name = "label54325345";
			this.label54325345.Size = new System.Drawing.Size(99, 24);
			this.label54325345.TabIndex = 7;
			this.label54325345.Text = "Контакти:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(3, 118);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(162, 24);
			this.label2.TabIndex = 4;
			this.label2.Text = "Мова перекладу:";
			// 
			// LanguageLabel
			// 
			this.LanguageLabel.AutoSize = true;
			this.LanguageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.LanguageLabel.Location = new System.Drawing.Point(161, 118);
			this.LanguageLabel.Name = "LanguageLabel";
			this.LanguageLabel.Size = new System.Drawing.Size(141, 24);
			this.LanguageLabel.TabIndex = 5;
			this.LanguageLabel.Text = "LanguageLabel";
			// 
			// CompositionText
			// 
			this.CompositionText.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.CompositionText.Location = new System.Drawing.Point(3, 183);
			this.CompositionText.Name = "CompositionText";
			this.CompositionText.ReadOnly = true;
			this.CompositionText.Size = new System.Drawing.Size(770, 362);
			this.CompositionText.TabIndex = 6;
			this.CompositionText.Text = "";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.Location = new System.Drawing.Point(34, 1);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(111, 31);
			this.label4.TabIndex = 25;
			this.label4.Text = "Колекції";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label5.Location = new System.Drawing.Point(276, 1);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(83, 31);
			this.label5.TabIndex = 26;
			this.label5.Text = "Твори";
			// 
			// GuestForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.ClientSize = new System.Drawing.Size(1199, 547);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.infoPanel);
			this.Controls.Add(this.CompositionList);
			this.Controls.Add(this.CollectionList);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "GuestForm";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "GuestForm";
			this.Load += new System.EventHandler(this.GuestForm_Load);
			this.infoPanel.ResumeLayout(false);
			this.infoPanel.PerformLayout();
			this.informationPanel.ResumeLayout(false);
			this.informationPanel.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.ListBox CollectionList;
		private System.Windows.Forms.ListBox CompositionList;
		private System.Windows.Forms.Panel infoPanel;
		private System.Windows.Forms.RichTextBox CompositionText;
		private System.Windows.Forms.Label LanguageLabel;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label PublicationLabel;
		private System.Windows.Forms.Label AuthorNameLabel;
		private System.Windows.Forms.Label compositionNameLabel;
		private System.Windows.Forms.Label ContactsLabel;
		private System.Windows.Forms.Label label54325345;
		private System.Windows.Forms.Label GenresLabel;
		private System.Windows.Forms.Label label12433124;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox searchBox;
		private System.Windows.Forms.Panel informationPanel;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
	}
}