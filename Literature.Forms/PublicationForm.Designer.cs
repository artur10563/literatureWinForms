namespace Literature.Forms
{
	partial class PublicationForm
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
			this.label1 = new System.Windows.Forms.Label();
			this.YearBox = new System.Windows.Forms.MaskedTextBox();
			this.CountryDropDown = new System.Windows.Forms.ComboBox();
			this.CountryLabel = new System.Windows.Forms.Label();
			this.EmailBox = new System.Windows.Forms.TextBox();
			this.EmailLabel = new System.Windows.Forms.Label();
			this.NewPublicationBtn = new System.Windows.Forms.Button();
			this.DeletePublicationBtn = new System.Windows.Forms.Button();
			this.SavePublicationBtn = new System.Windows.Forms.Button();
			this.NameLabel = new System.Windows.Forms.Label();
			this.NameBox = new System.Windows.Forms.TextBox();
			this.PublicationList = new System.Windows.Forms.ListBox();
			this.PublicationUnselectBtn = new System.Windows.Forms.Button();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.label1);
			this.panel2.Controls.Add(this.YearBox);
			this.panel2.Controls.Add(this.CountryDropDown);
			this.panel2.Controls.Add(this.CountryLabel);
			this.panel2.Controls.Add(this.EmailBox);
			this.panel2.Controls.Add(this.EmailLabel);
			this.panel2.Controls.Add(this.NewPublicationBtn);
			this.panel2.Controls.Add(this.DeletePublicationBtn);
			this.panel2.Controls.Add(this.SavePublicationBtn);
			this.panel2.Controls.Add(this.NameLabel);
			this.panel2.Controls.Add(this.NameBox);
			this.panel2.Location = new System.Drawing.Point(215, 2);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(585, 447);
			this.panel2.TabIndex = 8;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(13, 89);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(163, 25);
			this.label1.TabIndex = 12;
			this.label1.Text = "Рік заснування";
			// 
			// YearBox
			// 
			this.YearBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.YearBox.Location = new System.Drawing.Point(8, 117);
			this.YearBox.Mask = "9900";
			this.YearBox.Name = "YearBox";
			this.YearBox.Size = new System.Drawing.Size(200, 35);
			this.YearBox.TabIndex = 11;
			this.YearBox.ValidatingType = typeof(int);
			// 
			// CountryDropDown
			// 
			this.CountryDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.CountryDropDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.CountryDropDown.FormattingEnabled = true;
			this.CountryDropDown.Location = new System.Drawing.Point(237, 117);
			this.CountryDropDown.Name = "CountryDropDown";
			this.CountryDropDown.Size = new System.Drawing.Size(200, 33);
			this.CountryDropDown.TabIndex = 9;
			// 
			// CountryLabel
			// 
			this.CountryLabel.AutoSize = true;
			this.CountryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.CountryLabel.Location = new System.Drawing.Point(232, 89);
			this.CountryLabel.Name = "CountryLabel";
			this.CountryLabel.Size = new System.Drawing.Size(200, 25);
			this.CountryLabel.TabIndex = 7;
			this.CountryLabel.Text = "Країна заснування";
			// 
			// EmailBox
			// 
			this.EmailBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.EmailBox.Location = new System.Drawing.Point(237, 37);
			this.EmailBox.Name = "EmailBox";
			this.EmailBox.Size = new System.Drawing.Size(200, 35);
			this.EmailBox.TabIndex = 6;
			// 
			// EmailLabel
			// 
			this.EmailLabel.AutoSize = true;
			this.EmailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.EmailLabel.Location = new System.Drawing.Point(232, 9);
			this.EmailLabel.Name = "EmailLabel";
			this.EmailLabel.Size = new System.Drawing.Size(65, 25);
			this.EmailLabel.TabIndex = 5;
			this.EmailLabel.Text = "Email";
			// 
			// NewPublicationBtn
			// 
			this.NewPublicationBtn.Location = new System.Drawing.Point(8, 181);
			this.NewPublicationBtn.Name = "NewPublicationBtn";
			this.NewPublicationBtn.Size = new System.Drawing.Size(200, 36);
			this.NewPublicationBtn.TabIndex = 4;
			this.NewPublicationBtn.Text = "Створити";
			this.NewPublicationBtn.UseVisualStyleBackColor = true;
			this.NewPublicationBtn.Click += new System.EventHandler(this.NewPublicationBtn_Click);
			// 
			// DeletePublicationBtn
			// 
			this.DeletePublicationBtn.Location = new System.Drawing.Point(8, 265);
			this.DeletePublicationBtn.Name = "DeletePublicationBtn";
			this.DeletePublicationBtn.Size = new System.Drawing.Size(200, 36);
			this.DeletePublicationBtn.TabIndex = 0;
			this.DeletePublicationBtn.Text = "Видалити";
			this.DeletePublicationBtn.UseVisualStyleBackColor = true;
			this.DeletePublicationBtn.Click += new System.EventHandler(this.DeletePublicationBtn_Click);
			// 
			// SavePublicationBtn
			// 
			this.SavePublicationBtn.Location = new System.Drawing.Point(8, 223);
			this.SavePublicationBtn.Name = "SavePublicationBtn";
			this.SavePublicationBtn.Size = new System.Drawing.Size(200, 36);
			this.SavePublicationBtn.TabIndex = 3;
			this.SavePublicationBtn.Text = "Оновити";
			this.SavePublicationBtn.UseVisualStyleBackColor = true;
			this.SavePublicationBtn.Click += new System.EventHandler(this.SavePublicationBtn_Click);
			// 
			// NameLabel
			// 
			this.NameLabel.AutoSize = true;
			this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.NameLabel.Location = new System.Drawing.Point(13, 9);
			this.NameLabel.Name = "NameLabel";
			this.NameLabel.Size = new System.Drawing.Size(73, 25);
			this.NameLabel.TabIndex = 2;
			this.NameLabel.Text = "Назва";
			// 
			// NameBox
			// 
			this.NameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.NameBox.Location = new System.Drawing.Point(8, 37);
			this.NameBox.Name = "NameBox";
			this.NameBox.Size = new System.Drawing.Size(200, 35);
			this.NameBox.TabIndex = 1;
			// 
			// PublicationList
			// 
			this.PublicationList.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.PublicationList.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.PublicationList.ForeColor = System.Drawing.SystemColors.Menu;
			this.PublicationList.FormattingEnabled = true;
			this.PublicationList.ItemHeight = 23;
			this.PublicationList.Location = new System.Drawing.Point(1, 54);
			this.PublicationList.Name = "PublicationList";
			this.PublicationList.Size = new System.Drawing.Size(208, 395);
			this.PublicationList.TabIndex = 9;
			this.PublicationList.SelectedIndexChanged += new System.EventHandler(this.PublicationList_SelectedIndexChanged);
			// 
			// PublicationUnselectBtn
			// 
			this.PublicationUnselectBtn.Location = new System.Drawing.Point(1, 12);
			this.PublicationUnselectBtn.Name = "PublicationUnselectBtn";
			this.PublicationUnselectBtn.Size = new System.Drawing.Size(208, 36);
			this.PublicationUnselectBtn.TabIndex = 25;
			this.PublicationUnselectBtn.Text = "Очистити вибране";
			this.PublicationUnselectBtn.UseVisualStyleBackColor = true;
			this.PublicationUnselectBtn.Click += new System.EventHandler(this.PublicationUnselectBtn_Click);
			// 
			// PublicationForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.PublicationUnselectBtn);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.PublicationList);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "PublicationForm";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "PublicationForm";
			this.Load += new System.EventHandler(this.PublicationForm_Load);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.ComboBox CountryDropDown;
		private System.Windows.Forms.Label CountryLabel;
		private System.Windows.Forms.TextBox EmailBox;
		private System.Windows.Forms.Label EmailLabel;
		private System.Windows.Forms.Button NewPublicationBtn;
		private System.Windows.Forms.Button DeletePublicationBtn;
		private System.Windows.Forms.Button SavePublicationBtn;
		private System.Windows.Forms.Label NameLabel;
		private System.Windows.Forms.TextBox NameBox;
		private System.Windows.Forms.ListBox PublicationList;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.MaskedTextBox YearBox;
		private System.Windows.Forms.Button PublicationUnselectBtn;
	}
}