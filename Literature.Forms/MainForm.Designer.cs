namespace Literature.Forms
{
	partial class MainForm
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.panel1 = new System.Windows.Forms.Panel();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.довідникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.AuthorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.CompositionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.PublicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.GenreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.LanguageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.CountryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.CollectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.panel1.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.menuStrip1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(800, 450);
			this.panel1.TabIndex = 0;
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.довідникиToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(800, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// довідникиToolStripMenuItem
			// 
			this.довідникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AuthorToolStripMenuItem,
            this.CompositionToolStripMenuItem,
            this.PublicationToolStripMenuItem,
            this.GenreToolStripMenuItem,
            this.LanguageToolStripMenuItem,
            this.CountryToolStripMenuItem,
            this.CollectionToolStripMenuItem});
			this.довідникиToolStripMenuItem.Name = "довідникиToolStripMenuItem";
			this.довідникиToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
			this.довідникиToolStripMenuItem.Text = "Довідники";
			// 
			// AuthorToolStripMenuItem
			// 
			this.AuthorToolStripMenuItem.Name = "AuthorToolStripMenuItem";
			this.AuthorToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
			this.AuthorToolStripMenuItem.Text = "Автор";
			this.AuthorToolStripMenuItem.Click += new System.EventHandler(this.AuthorToolStripMenuItem_Click);
			// 
			// CompositionToolStripMenuItem
			// 
			this.CompositionToolStripMenuItem.Name = "CompositionToolStripMenuItem";
			this.CompositionToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
			this.CompositionToolStripMenuItem.Text = "Твір";
			this.CompositionToolStripMenuItem.Click += new System.EventHandler(this.CompositionToolStripMenuItem_Click);
			// 
			// PublicationToolStripMenuItem
			// 
			this.PublicationToolStripMenuItem.Name = "PublicationToolStripMenuItem";
			this.PublicationToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
			this.PublicationToolStripMenuItem.Text = "Видавництво";
			this.PublicationToolStripMenuItem.Click += new System.EventHandler(this.PublicationToolStripMenuItem_Click);
			// 
			// GenreToolStripMenuItem
			// 
			this.GenreToolStripMenuItem.Name = "GenreToolStripMenuItem";
			this.GenreToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
			this.GenreToolStripMenuItem.Text = "Жанр";
			this.GenreToolStripMenuItem.Click += new System.EventHandler(this.GenreToolStripMenuItem_Click);
			// 
			// LanguageToolStripMenuItem
			// 
			this.LanguageToolStripMenuItem.Name = "LanguageToolStripMenuItem";
			this.LanguageToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
			this.LanguageToolStripMenuItem.Text = "Мова";
			this.LanguageToolStripMenuItem.Click += new System.EventHandler(this.LanguageToolStripMenuItem_Click);
			// 
			// CountryToolStripMenuItem
			// 
			this.CountryToolStripMenuItem.Name = "CountryToolStripMenuItem";
			this.CountryToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
			this.CountryToolStripMenuItem.Text = "Країна";
			this.CountryToolStripMenuItem.Click += new System.EventHandler(this.CountryToolStripMenuItem_Click);
			// 
			// CollectionToolStripMenuItem
			// 
			this.CollectionToolStripMenuItem.Name = "CollectionToolStripMenuItem";
			this.CollectionToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
			this.CollectionToolStripMenuItem.Text = "Колекція";
			this.CollectionToolStripMenuItem.Click += new System.EventHandler(this.CollectionToolStripMenuItem_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MainMenuStrip = this.menuStrip1;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Literature";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem довідникиToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem AuthorToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem CompositionToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem PublicationToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem GenreToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem LanguageToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem CountryToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem CollectionToolStripMenuItem;
	}
}

