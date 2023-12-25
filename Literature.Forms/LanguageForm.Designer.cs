namespace Literature.Forms
{
	partial class LanguageForm
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
			this.panel22 = new System.Windows.Forms.Panel();
			this.NewLanguageBtn = new System.Windows.Forms.Button();
			this.DeleteLanguageBtn = new System.Windows.Forms.Button();
			this.SaveLanguageBtn = new System.Windows.Forms.Button();
			this.LanguageNameLabel = new System.Windows.Forms.Label();
			this.LanguageNameBox = new System.Windows.Forms.TextBox();
			this.GenresList = new System.Windows.Forms.ListBox();
			this.LanguageList = new System.Windows.Forms.ListBox();
			this.LanguageUnselectBtn = new System.Windows.Forms.Button();
			this.panel22.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel22
			// 
			this.panel22.Controls.Add(this.NewLanguageBtn);
			this.panel22.Controls.Add(this.DeleteLanguageBtn);
			this.panel22.Controls.Add(this.SaveLanguageBtn);
			this.panel22.Controls.Add(this.LanguageNameLabel);
			this.panel22.Controls.Add(this.LanguageNameBox);
			this.panel22.Location = new System.Drawing.Point(216, 0);
			this.panel22.Name = "panel22";
			this.panel22.Size = new System.Drawing.Size(585, 447);
			this.panel22.TabIndex = 5;
			// 
			// NewLanguageBtn
			// 
			this.NewLanguageBtn.Location = new System.Drawing.Point(8, 89);
			this.NewLanguageBtn.Name = "NewLanguageBtn";
			this.NewLanguageBtn.Size = new System.Drawing.Size(200, 36);
			this.NewLanguageBtn.TabIndex = 4;
			this.NewLanguageBtn.Text = "Створити";
			this.NewLanguageBtn.UseVisualStyleBackColor = true;
			this.NewLanguageBtn.Click += new System.EventHandler(this.NewLanguageBtn_Click);
			// 
			// DeleteLanguageBtn
			// 
			this.DeleteLanguageBtn.Location = new System.Drawing.Point(8, 173);
			this.DeleteLanguageBtn.Name = "DeleteLanguageBtn";
			this.DeleteLanguageBtn.Size = new System.Drawing.Size(200, 36);
			this.DeleteLanguageBtn.TabIndex = 0;
			this.DeleteLanguageBtn.Text = "Видалити";
			this.DeleteLanguageBtn.UseVisualStyleBackColor = true;
			this.DeleteLanguageBtn.Click += new System.EventHandler(this.DeleteLanguageBtn_Click);
			// 
			// SaveLanguageBtn
			// 
			this.SaveLanguageBtn.Location = new System.Drawing.Point(8, 131);
			this.SaveLanguageBtn.Name = "SaveLanguageBtn";
			this.SaveLanguageBtn.Size = new System.Drawing.Size(200, 36);
			this.SaveLanguageBtn.TabIndex = 3;
			this.SaveLanguageBtn.Text = "Оновити";
			this.SaveLanguageBtn.UseVisualStyleBackColor = true;
			this.SaveLanguageBtn.Click += new System.EventHandler(this.SaveLanguageBtn_Click);
			// 
			// LanguageNameLabel
			// 
			this.LanguageNameLabel.AutoSize = true;
			this.LanguageNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.LanguageNameLabel.Location = new System.Drawing.Point(13, 20);
			this.LanguageNameLabel.Name = "LanguageNameLabel";
			this.LanguageNameLabel.Size = new System.Drawing.Size(129, 25);
			this.LanguageNameLabel.TabIndex = 2;
			this.LanguageNameLabel.Text = "Назва мови";
			// 
			// LanguageNameBox
			// 
			this.LanguageNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.LanguageNameBox.Location = new System.Drawing.Point(8, 48);
			this.LanguageNameBox.Name = "LanguageNameBox";
			this.LanguageNameBox.Size = new System.Drawing.Size(200, 35);
			this.LanguageNameBox.TabIndex = 1;
			// 
			// GenresList
			// 
			this.GenresList.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.GenresList.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.GenresList.ForeColor = System.Drawing.SystemColors.Menu;
			this.GenresList.FormattingEnabled = true;
			this.GenresList.ItemHeight = 23;
			this.GenresList.Location = new System.Drawing.Point(217, 9);
			this.GenresList.Name = "GenresList";
			this.GenresList.Size = new System.Drawing.Size(203, 441);
			this.GenresList.TabIndex = 4;
			// 
			// LanguageList
			// 
			this.LanguageList.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.LanguageList.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.LanguageList.ForeColor = System.Drawing.SystemColors.Menu;
			this.LanguageList.FormattingEnabled = true;
			this.LanguageList.ItemHeight = 23;
			this.LanguageList.Location = new System.Drawing.Point(1, 52);
			this.LanguageList.Name = "LanguageList";
			this.LanguageList.Size = new System.Drawing.Size(211, 395);
			this.LanguageList.TabIndex = 6;
			this.LanguageList.SelectedIndexChanged += new System.EventHandler(this.LanguageList_SelectedIndexChanged);
			// 
			// LanguageUnselectBtn
			// 
			this.LanguageUnselectBtn.Location = new System.Drawing.Point(1, 10);
			this.LanguageUnselectBtn.Name = "LanguageUnselectBtn";
			this.LanguageUnselectBtn.Size = new System.Drawing.Size(208, 36);
			this.LanguageUnselectBtn.TabIndex = 26;
			this.LanguageUnselectBtn.Text = "Очистити вибране";
			this.LanguageUnselectBtn.UseVisualStyleBackColor = true;
			this.LanguageUnselectBtn.Click += new System.EventHandler(this.LanguageUnselectBtn_Click);
			// 
			// LanguageForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.LanguageUnselectBtn);
			this.Controls.Add(this.LanguageList);
			this.Controls.Add(this.panel22);
			this.Controls.Add(this.GenresList);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "LanguageForm";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "LanguageForm";
			this.Load += new System.EventHandler(this.LanguageForm_Load);
			this.panel22.ResumeLayout(false);
			this.panel22.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel22;
		private System.Windows.Forms.Button NewLanguageBtn;
		private System.Windows.Forms.Button DeleteLanguageBtn;
		private System.Windows.Forms.Button SaveLanguageBtn;
		private System.Windows.Forms.Label LanguageNameLabel;
		private System.Windows.Forms.TextBox LanguageNameBox;
		private System.Windows.Forms.ListBox GenresList;
		private System.Windows.Forms.ListBox LanguageList;
		private System.Windows.Forms.Button LanguageUnselectBtn;
	}
}