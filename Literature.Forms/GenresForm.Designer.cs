namespace Literature.Forms
{
	partial class GenresForm
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
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.GenreUnselectBtn = new System.Windows.Forms.Button();
			this.GenresList = new System.Windows.Forms.ListBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.NewGenreBtn = new System.Windows.Forms.Button();
			this.DeleteGenreBtn = new System.Windows.Forms.Button();
			this.SaveGenreBtn = new System.Windows.Forms.Button();
			this.GenreNameLabel = new System.Windows.Forms.Label();
			this.GenreNameBox = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.IsSplitterFixed = true;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.GenreUnselectBtn);
			this.splitContainer1.Panel1.Controls.Add(this.GenresList);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.panel2);
			this.splitContainer1.Size = new System.Drawing.Size(800, 450);
			this.splitContainer1.SplitterDistance = 206;
			this.splitContainer1.TabIndex = 0;
			// 
			// GenreUnselectBtn
			// 
			this.GenreUnselectBtn.Location = new System.Drawing.Point(0, 12);
			this.GenreUnselectBtn.Name = "GenreUnselectBtn";
			this.GenreUnselectBtn.Size = new System.Drawing.Size(208, 36);
			this.GenreUnselectBtn.TabIndex = 27;
			this.GenreUnselectBtn.Text = "Очистити вибране";
			this.GenreUnselectBtn.UseVisualStyleBackColor = true;
			this.GenreUnselectBtn.Click += new System.EventHandler(this.GenreUnselectBtn_Click);
			// 
			// GenresList
			// 
			this.GenresList.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.GenresList.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.GenresList.ForeColor = System.Drawing.SystemColors.Menu;
			this.GenresList.FormattingEnabled = true;
			this.GenresList.ItemHeight = 23;
			this.GenresList.Location = new System.Drawing.Point(3, 55);
			this.GenresList.Name = "GenresList";
			this.GenresList.Size = new System.Drawing.Size(203, 395);
			this.GenresList.TabIndex = 0;
			this.GenresList.SelectedIndexChanged += new System.EventHandler(this.Genres_SelectedIndexChanged);
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.NewGenreBtn);
			this.panel2.Controls.Add(this.DeleteGenreBtn);
			this.panel2.Controls.Add(this.SaveGenreBtn);
			this.panel2.Controls.Add(this.GenreNameLabel);
			this.panel2.Controls.Add(this.GenreNameBox);
			this.panel2.Location = new System.Drawing.Point(3, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(584, 447);
			this.panel2.TabIndex = 3;
			// 
			// NewGenreBtn
			// 
			this.NewGenreBtn.Location = new System.Drawing.Point(8, 89);
			this.NewGenreBtn.Name = "NewGenreBtn";
			this.NewGenreBtn.Size = new System.Drawing.Size(200, 36);
			this.NewGenreBtn.TabIndex = 4;
			this.NewGenreBtn.Text = "Створити";
			this.NewGenreBtn.UseVisualStyleBackColor = true;
			this.NewGenreBtn.Click += new System.EventHandler(this.NewGenreBtn_Click);
			// 
			// DeleteGenreBtn
			// 
			this.DeleteGenreBtn.Location = new System.Drawing.Point(8, 173);
			this.DeleteGenreBtn.Name = "DeleteGenreBtn";
			this.DeleteGenreBtn.Size = new System.Drawing.Size(200, 36);
			this.DeleteGenreBtn.TabIndex = 0;
			this.DeleteGenreBtn.Text = "Видалити";
			this.DeleteGenreBtn.UseVisualStyleBackColor = true;
			this.DeleteGenreBtn.Click += new System.EventHandler(this.DeleteGenreBtn_Click);
			// 
			// SaveGenreBtn
			// 
			this.SaveGenreBtn.Location = new System.Drawing.Point(8, 131);
			this.SaveGenreBtn.Name = "SaveGenreBtn";
			this.SaveGenreBtn.Size = new System.Drawing.Size(200, 36);
			this.SaveGenreBtn.TabIndex = 3;
			this.SaveGenreBtn.Text = "Оновити";
			this.SaveGenreBtn.UseVisualStyleBackColor = true;
			this.SaveGenreBtn.Click += new System.EventHandler(this.SaveGenreBtn_Click_1);
			// 
			// GenreNameLabel
			// 
			this.GenreNameLabel.AutoSize = true;
			this.GenreNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.GenreNameLabel.Location = new System.Drawing.Point(13, 20);
			this.GenreNameLabel.Name = "GenreNameLabel";
			this.GenreNameLabel.Size = new System.Drawing.Size(141, 25);
			this.GenreNameLabel.TabIndex = 2;
			this.GenreNameLabel.Text = "Назва жанру";
			// 
			// GenreNameBox
			// 
			this.GenreNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.GenreNameBox.Location = new System.Drawing.Point(8, 48);
			this.GenreNameBox.Name = "GenreNameBox";
			this.GenreNameBox.Size = new System.Drawing.Size(200, 35);
			this.GenreNameBox.TabIndex = 1;
			// 
			// GenresForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.splitContainer1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "GenresForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Genres";
			this.Load += new System.EventHandler(this.GenresForm_Load);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.ListBox GenresList;
		private System.Windows.Forms.Label GenreNameLabel;
		private System.Windows.Forms.TextBox GenreNameBox;
		private System.Windows.Forms.Button DeleteGenreBtn;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button SaveGenreBtn;
		private System.Windows.Forms.Button NewGenreBtn;
		private System.Windows.Forms.Button GenreUnselectBtn;
	}
}