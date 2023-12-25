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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.довідникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.CompositionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.CollectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.звітиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.звіт1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.CollectionList = new System.Windows.Forms.ListBox();
			this.CompositionList = new System.Windows.Forms.ListBox();
			this.infoPanel = new System.Windows.Forms.Panel();
			this.GenresLabel = new System.Windows.Forms.Label();
			this.label12433124 = new System.Windows.Forms.Label();
			this.ContactsLabel = new System.Windows.Forms.Label();
			this.label54325345 = new System.Windows.Forms.Label();
			this.CompositionText = new System.Windows.Forms.RichTextBox();
			this.LanguageLabel = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.PublicationLabel = new System.Windows.Forms.Label();
			this.AuthorNameLabel = new System.Windows.Forms.Label();
			this.compositionNameLabel = new System.Windows.Forms.Label();
			this.menuStrip1.SuspendLayout();
			this.infoPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.довідникиToolStripMenuItem,
            this.звітиToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1199, 24);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// довідникиToolStripMenuItem
			// 
			this.довідникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CompositionToolStripMenuItem,
            this.CollectionToolStripMenuItem});
			this.довідникиToolStripMenuItem.Name = "довідникиToolStripMenuItem";
			this.довідникиToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
			this.довідникиToolStripMenuItem.Text = "Довідники";
			// 
			// CompositionToolStripMenuItem
			// 
			this.CompositionToolStripMenuItem.Name = "CompositionToolStripMenuItem";
			this.CompositionToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
			this.CompositionToolStripMenuItem.Text = "Твір";
			// 
			// CollectionToolStripMenuItem
			// 
			this.CollectionToolStripMenuItem.Name = "CollectionToolStripMenuItem";
			this.CollectionToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
			this.CollectionToolStripMenuItem.Text = "Колекція";
			// 
			// звітиToolStripMenuItem
			// 
			this.звітиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.звіт1ToolStripMenuItem});
			this.звітиToolStripMenuItem.Name = "звітиToolStripMenuItem";
			this.звітиToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
			this.звітиToolStripMenuItem.Text = "Пошук";
			// 
			// звіт1ToolStripMenuItem
			// 
			this.звіт1ToolStripMenuItem.Name = "звіт1ToolStripMenuItem";
			this.звіт1ToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
			this.звіт1ToolStripMenuItem.Text = "Звіт1";
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
			this.infoPanel.Controls.Add(this.GenresLabel);
			this.infoPanel.Controls.Add(this.label12433124);
			this.infoPanel.Controls.Add(this.ContactsLabel);
			this.infoPanel.Controls.Add(this.label54325345);
			this.infoPanel.Controls.Add(this.CompositionText);
			this.infoPanel.Controls.Add(this.LanguageLabel);
			this.infoPanel.Controls.Add(this.label2);
			this.infoPanel.Controls.Add(this.label1);
			this.infoPanel.Controls.Add(this.PublicationLabel);
			this.infoPanel.Controls.Add(this.AuthorNameLabel);
			this.infoPanel.Controls.Add(this.compositionNameLabel);
			this.infoPanel.Location = new System.Drawing.Point(423, 25);
			this.infoPanel.Name = "infoPanel";
			this.infoPanel.Size = new System.Drawing.Size(776, 521);
			this.infoPanel.TabIndex = 24;
			// 
			// GenresLabel
			// 
			this.GenresLabel.AutoSize = true;
			this.GenresLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.GenresLabel.Location = new System.Drawing.Point(72, 135);
			this.GenresLabel.Name = "GenresLabel";
			this.GenresLabel.Size = new System.Drawing.Size(118, 24);
			this.GenresLabel.TabIndex = 10;
			this.GenresLabel.Text = "GenresLabel";
			// 
			// label12433124
			// 
			this.label12433124.AutoSize = true;
			this.label12433124.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label12433124.Location = new System.Drawing.Point(3, 135);
			this.label12433124.Name = "label12433124";
			this.label12433124.Size = new System.Drawing.Size(74, 24);
			this.label12433124.TabIndex = 9;
			this.label12433124.Text = "Жанри:";
			// 
			// ContactsLabel
			// 
			this.ContactsLabel.AutoSize = true;
			this.ContactsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.ContactsLabel.Location = new System.Drawing.Point(106, 87);
			this.ContactsLabel.Name = "ContactsLabel";
			this.ContactsLabel.Size = new System.Drawing.Size(125, 24);
			this.ContactsLabel.TabIndex = 8;
			this.ContactsLabel.Text = "contactsLabel";
			// 
			// label54325345
			// 
			this.label54325345.AutoSize = true;
			this.label54325345.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label54325345.Location = new System.Drawing.Point(3, 87);
			this.label54325345.Name = "label54325345";
			this.label54325345.Size = new System.Drawing.Size(99, 24);
			this.label54325345.TabIndex = 7;
			this.label54325345.Text = "Контакти:";
			// 
			// CompositionText
			// 
			this.CompositionText.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.CompositionText.Location = new System.Drawing.Point(2, 182);
			this.CompositionText.Name = "CompositionText";
			this.CompositionText.ReadOnly = true;
			this.CompositionText.Size = new System.Drawing.Size(770, 337);
			this.CompositionText.TabIndex = 6;
			this.CompositionText.Text = "";
			// 
			// LanguageLabel
			// 
			this.LanguageLabel.AutoSize = true;
			this.LanguageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.LanguageLabel.Location = new System.Drawing.Point(161, 111);
			this.LanguageLabel.Name = "LanguageLabel";
			this.LanguageLabel.Size = new System.Drawing.Size(141, 24);
			this.LanguageLabel.TabIndex = 5;
			this.LanguageLabel.Text = "LanguageLabel";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(3, 111);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(162, 24);
			this.label2.TabIndex = 4;
			this.label2.Text = "Мова перекладу:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(3, 62);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(136, 24);
			this.label1.TabIndex = 3;
			this.label1.Text = "Видавництво:";
			// 
			// PublicationLabel
			// 
			this.PublicationLabel.AutoSize = true;
			this.PublicationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.PublicationLabel.Location = new System.Drawing.Point(136, 62);
			this.PublicationLabel.Name = "PublicationLabel";
			this.PublicationLabel.Size = new System.Drawing.Size(148, 24);
			this.PublicationLabel.TabIndex = 2;
			this.PublicationLabel.Text = "PublicationLabel";
			// 
			// AuthorNameLabel
			// 
			this.AuthorNameLabel.AutoSize = true;
			this.AuthorNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.AuthorNameLabel.Location = new System.Drawing.Point(3, 37);
			this.AuthorNameLabel.Name = "AuthorNameLabel";
			this.AuthorNameLabel.Size = new System.Drawing.Size(163, 24);
			this.AuthorNameLabel.TabIndex = 1;
			this.AuthorNameLabel.Text = "AuthorNameLabel";
			// 
			// compositionNameLabel
			// 
			this.compositionNameLabel.AutoSize = true;
			this.compositionNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.compositionNameLabel.Location = new System.Drawing.Point(3, 6);
			this.compositionNameLabel.Name = "compositionNameLabel";
			this.compositionNameLabel.Size = new System.Drawing.Size(231, 31);
			this.compositionNameLabel.TabIndex = 0;
			this.compositionNameLabel.Text = "compositionName";
			// 
			// GuestForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.ClientSize = new System.Drawing.Size(1199, 547);
			this.Controls.Add(this.infoPanel);
			this.Controls.Add(this.CompositionList);
			this.Controls.Add(this.CollectionList);
			this.Controls.Add(this.menuStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "GuestForm";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "GuestForm";
			this.Load += new System.EventHandler(this.GuestForm_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.infoPanel.ResumeLayout(false);
			this.infoPanel.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem довідникиToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem CompositionToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem CollectionToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem звітиToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem звіт1ToolStripMenuItem;
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
	}
}