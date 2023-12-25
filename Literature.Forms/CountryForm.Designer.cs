namespace Literature.Forms
{
	partial class CountryForm
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
			this.panel2 = new System.Windows.Forms.Panel();
			this.NewCountryBtn = new System.Windows.Forms.Button();
			this.DeleteCountryBtn = new System.Windows.Forms.Button();
			this.SaveCountryBtn = new System.Windows.Forms.Button();
			this.GenreNameLabel = new System.Windows.Forms.Label();
			this.CountryNameBox = new System.Windows.Forms.TextBox();
			this.CountriesList = new System.Windows.Forms.ListBox();
			this.CountryUnselectBtn = new System.Windows.Forms.Button();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.NewCountryBtn);
			this.panel2.Controls.Add(this.DeleteCountryBtn);
			this.panel2.Controls.Add(this.SaveCountryBtn);
			this.panel2.Controls.Add(this.GenreNameLabel);
			this.panel2.Controls.Add(this.CountryNameBox);
			this.panel2.Location = new System.Drawing.Point(212, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(585, 447);
			this.panel2.TabIndex = 4;
			// 
			// NewCountryBtn
			// 
			this.NewCountryBtn.Location = new System.Drawing.Point(8, 89);
			this.NewCountryBtn.Name = "NewCountryBtn";
			this.NewCountryBtn.Size = new System.Drawing.Size(200, 36);
			this.NewCountryBtn.TabIndex = 4;
			this.NewCountryBtn.Text = "Створити";
			this.NewCountryBtn.UseVisualStyleBackColor = true;
			this.NewCountryBtn.Click += new System.EventHandler(this.NewCountryBtn_Click);
			// 
			// DeleteCountryBtn
			// 
			this.DeleteCountryBtn.Location = new System.Drawing.Point(8, 173);
			this.DeleteCountryBtn.Name = "DeleteCountryBtn";
			this.DeleteCountryBtn.Size = new System.Drawing.Size(200, 36);
			this.DeleteCountryBtn.TabIndex = 0;
			this.DeleteCountryBtn.Text = "Видалити";
			this.DeleteCountryBtn.UseVisualStyleBackColor = true;
			this.DeleteCountryBtn.Click += new System.EventHandler(this.DeleteCountryBtn_Click);
			// 
			// SaveCountryBtn
			// 
			this.SaveCountryBtn.Location = new System.Drawing.Point(8, 131);
			this.SaveCountryBtn.Name = "SaveCountryBtn";
			this.SaveCountryBtn.Size = new System.Drawing.Size(200, 36);
			this.SaveCountryBtn.TabIndex = 3;
			this.SaveCountryBtn.Text = "Оновити";
			this.SaveCountryBtn.UseVisualStyleBackColor = true;
			this.SaveCountryBtn.Click += new System.EventHandler(this.SaveCountryBtn_Click);
			// 
			// GenreNameLabel
			// 
			this.GenreNameLabel.AutoSize = true;
			this.GenreNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.GenreNameLabel.Location = new System.Drawing.Point(13, 20);
			this.GenreNameLabel.Name = "GenreNameLabel";
			this.GenreNameLabel.Size = new System.Drawing.Size(143, 25);
			this.GenreNameLabel.TabIndex = 2;
			this.GenreNameLabel.Text = "Назва країни";
			// 
			// CountryNameBox
			// 
			this.CountryNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.CountryNameBox.Location = new System.Drawing.Point(8, 48);
			this.CountryNameBox.Name = "CountryNameBox";
			this.CountryNameBox.Size = new System.Drawing.Size(200, 35);
			this.CountryNameBox.TabIndex = 1;
			// 
			// CountriesList
			// 
			this.CountriesList.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.CountriesList.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.CountriesList.ForeColor = System.Drawing.SystemColors.Menu;
			this.CountriesList.FormattingEnabled = true;
			this.CountriesList.ItemHeight = 23;
			this.CountriesList.Location = new System.Drawing.Point(3, 52);
			this.CountriesList.Name = "CountriesList";
			this.CountriesList.Size = new System.Drawing.Size(207, 395);
			this.CountriesList.TabIndex = 5;
			this.CountriesList.SelectedIndexChanged += new System.EventHandler(this.CountriesList_SelectedIndexChanged);
			// 
			// CountryUnselectBtn
			// 
			this.CountryUnselectBtn.Location = new System.Drawing.Point(1, 9);
			this.CountryUnselectBtn.Name = "CountryUnselectBtn";
			this.CountryUnselectBtn.Size = new System.Drawing.Size(208, 36);
			this.CountryUnselectBtn.TabIndex = 28;
			this.CountryUnselectBtn.Text = "Очистити вибране";
			this.CountryUnselectBtn.UseVisualStyleBackColor = true;
			this.CountryUnselectBtn.Click += new System.EventHandler(this.CountryUnselectBtn_Click);
			// 
			// CountryForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.CountryUnselectBtn);
			this.Controls.Add(this.CountriesList);
			this.Controls.Add(this.panel2);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "CountryForm";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "CountryForm";
			this.Load += new System.EventHandler(this.CountryForm_Load_1);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button NewCountryBtn;
		private System.Windows.Forms.Button DeleteCountryBtn;
		private System.Windows.Forms.Button SaveCountryBtn;
		private System.Windows.Forms.Label GenreNameLabel;
		private System.Windows.Forms.TextBox CountryNameBox;
		private System.Windows.Forms.ListBox CountriesList;
		private System.Windows.Forms.Button CountryUnselectBtn;
	}
}