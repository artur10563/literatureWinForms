namespace Literature.Forms
{
	partial class AuthorForm
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
			this.CountryDropDown = new System.Windows.Forms.ComboBox();
			this.CountryLabel = new System.Windows.Forms.Label();
			this.LastNameBox = new System.Windows.Forms.TextBox();
			this.LastNameLabel = new System.Windows.Forms.Label();
			this.NewAuthorBtn = new System.Windows.Forms.Button();
			this.DeleteAuthorBtn = new System.Windows.Forms.Button();
			this.SaveAuthorBtn = new System.Windows.Forms.Button();
			this.FirstNameLabel = new System.Windows.Forms.Label();
			this.FirstNameBox = new System.Windows.Forms.TextBox();
			this.AuthorsList = new System.Windows.Forms.ListBox();
			this.AuthorUnselectBtn = new System.Windows.Forms.Button();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.CountryDropDown);
			this.panel2.Controls.Add(this.CountryLabel);
			this.panel2.Controls.Add(this.LastNameBox);
			this.panel2.Controls.Add(this.LastNameLabel);
			this.panel2.Controls.Add(this.NewAuthorBtn);
			this.panel2.Controls.Add(this.DeleteAuthorBtn);
			this.panel2.Controls.Add(this.SaveAuthorBtn);
			this.panel2.Controls.Add(this.FirstNameLabel);
			this.panel2.Controls.Add(this.FirstNameBox);
			this.panel2.Location = new System.Drawing.Point(217, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(585, 447);
			this.panel2.TabIndex = 6;
			// 
			// CountryDropDown
			// 
			this.CountryDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.CountryDropDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.CountryDropDown.FormattingEnabled = true;
			this.CountryDropDown.Location = new System.Drawing.Point(8, 204);
			this.CountryDropDown.Name = "CountryDropDown";
			this.CountryDropDown.Size = new System.Drawing.Size(200, 33);
			this.CountryDropDown.TabIndex = 9;
			// 
			// CountryLabel
			// 
			this.CountryLabel.AutoSize = true;
			this.CountryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.CountryLabel.Location = new System.Drawing.Point(13, 174);
			this.CountryLabel.Name = "CountryLabel";
			this.CountryLabel.Size = new System.Drawing.Size(79, 25);
			this.CountryLabel.TabIndex = 7;
			this.CountryLabel.Text = "Країна";
			// 
			// LastNameBox
			// 
			this.LastNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.LastNameBox.Location = new System.Drawing.Point(8, 117);
			this.LastNameBox.Name = "LastNameBox";
			this.LastNameBox.Size = new System.Drawing.Size(200, 35);
			this.LastNameBox.TabIndex = 6;
			// 
			// LastNameLabel
			// 
			this.LastNameLabel.AutoSize = true;
			this.LastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.LastNameLabel.Location = new System.Drawing.Point(13, 89);
			this.LastNameLabel.Name = "LastNameLabel";
			this.LastNameLabel.Size = new System.Drawing.Size(90, 25);
			this.LastNameLabel.TabIndex = 5;
			this.LastNameLabel.Text = "Фамілія";
			// 
			// NewAuthorBtn
			// 
			this.NewAuthorBtn.Location = new System.Drawing.Point(362, 40);
			this.NewAuthorBtn.Name = "NewAuthorBtn";
			this.NewAuthorBtn.Size = new System.Drawing.Size(200, 36);
			this.NewAuthorBtn.TabIndex = 4;
			this.NewAuthorBtn.Text = "Створити";
			this.NewAuthorBtn.UseVisualStyleBackColor = true;
			this.NewAuthorBtn.Click += new System.EventHandler(this.NewAuthorBtn_Click);
			// 
			// DeleteAuthorBtn
			// 
			this.DeleteAuthorBtn.Location = new System.Drawing.Point(362, 201);
			this.DeleteAuthorBtn.Name = "DeleteAuthorBtn";
			this.DeleteAuthorBtn.Size = new System.Drawing.Size(200, 36);
			this.DeleteAuthorBtn.TabIndex = 0;
			this.DeleteAuthorBtn.Text = "Видалити";
			this.DeleteAuthorBtn.UseVisualStyleBackColor = true;
			this.DeleteAuthorBtn.Click += new System.EventHandler(this.DeleteAuthorBtn_Click);
			// 
			// SaveAuthorBtn
			// 
			this.SaveAuthorBtn.Location = new System.Drawing.Point(362, 116);
			this.SaveAuthorBtn.Name = "SaveAuthorBtn";
			this.SaveAuthorBtn.Size = new System.Drawing.Size(200, 36);
			this.SaveAuthorBtn.TabIndex = 3;
			this.SaveAuthorBtn.Text = "Оновити";
			this.SaveAuthorBtn.UseVisualStyleBackColor = true;
			this.SaveAuthorBtn.Click += new System.EventHandler(this.SaveAuthorBtn_Click);
			// 
			// FirstNameLabel
			// 
			this.FirstNameLabel.AutoSize = true;
			this.FirstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.FirstNameLabel.Location = new System.Drawing.Point(13, 9);
			this.FirstNameLabel.Name = "FirstNameLabel";
			this.FirstNameLabel.Size = new System.Drawing.Size(47, 25);
			this.FirstNameLabel.TabIndex = 2;
			this.FirstNameLabel.Text = "Ім\'я";
			// 
			// FirstNameBox
			// 
			this.FirstNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.FirstNameBox.Location = new System.Drawing.Point(8, 37);
			this.FirstNameBox.Name = "FirstNameBox";
			this.FirstNameBox.Size = new System.Drawing.Size(200, 35);
			this.FirstNameBox.TabIndex = 1;
			// 
			// AuthorsList
			// 
			this.AuthorsList.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.AuthorsList.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.AuthorsList.ForeColor = System.Drawing.SystemColors.Menu;
			this.AuthorsList.FormattingEnabled = true;
			this.AuthorsList.ItemHeight = 23;
			this.AuthorsList.Location = new System.Drawing.Point(3, 52);
			this.AuthorsList.Name = "AuthorsList";
			this.AuthorsList.Size = new System.Drawing.Size(208, 395);
			this.AuthorsList.TabIndex = 7;
			this.AuthorsList.SelectedIndexChanged += new System.EventHandler(this.AuthorsList_SelectedIndexChanged);
			// 
			// AuthorUnselectBtn
			// 
			this.AuthorUnselectBtn.Location = new System.Drawing.Point(1, 9);
			this.AuthorUnselectBtn.Name = "AuthorUnselectBtn";
			this.AuthorUnselectBtn.Size = new System.Drawing.Size(213, 36);
			this.AuthorUnselectBtn.TabIndex = 25;
			this.AuthorUnselectBtn.Text = "Очистити вибране";
			this.AuthorUnselectBtn.UseVisualStyleBackColor = true;
			this.AuthorUnselectBtn.Click += new System.EventHandler(this.AuthorUnselectBtn_Click);
			// 
			// AuthorForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.AuthorUnselectBtn);
			this.Controls.Add(this.AuthorsList);
			this.Controls.Add(this.panel2);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "AuthorForm";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "AuthorForm";
			this.Load += new System.EventHandler(this.AuthorForm_Load);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button NewAuthorBtn;
		private System.Windows.Forms.Button DeleteAuthorBtn;
		private System.Windows.Forms.Button SaveAuthorBtn;
		private System.Windows.Forms.Label FirstNameLabel;
		private System.Windows.Forms.TextBox FirstNameBox;
		private System.Windows.Forms.ListBox AuthorsList;
		private System.Windows.Forms.TextBox LastNameBox;
		private System.Windows.Forms.Label LastNameLabel;
		private System.Windows.Forms.ComboBox CountryDropDown;
		private System.Windows.Forms.Label CountryLabel;
		private System.Windows.Forms.Button AuthorUnselectBtn;
	}
}