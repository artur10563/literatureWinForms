namespace Literature.Forms
{
	partial class CollectionForm
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
			this.DeleteCollectionBtn = new System.Windows.Forms.Button();
			this.panel22 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.CollectionTextBox = new System.Windows.Forms.RichTextBox();
			this.NewCollectionBtn = new System.Windows.Forms.Button();
			this.SaveCollectionBtn = new System.Windows.Forms.Button();
			this.NameLabel = new System.Windows.Forms.Label();
			this.NameBox = new System.Windows.Forms.TextBox();
			this.CompositionUnselectAllBtn = new System.Windows.Forms.Button();
			this.CompositionListBox = new System.Windows.Forms.ListBox();
			this.CollectionList = new System.Windows.Forms.ListBox();
			this.CollectionUnselectBtn = new System.Windows.Forms.Button();
			this.panel22.SuspendLayout();
			this.SuspendLayout();
			// 
			// DeleteCollectionBtn
			// 
			this.DeleteCollectionBtn.Location = new System.Drawing.Point(404, 86);
			this.DeleteCollectionBtn.Name = "DeleteCollectionBtn";
			this.DeleteCollectionBtn.Size = new System.Drawing.Size(200, 36);
			this.DeleteCollectionBtn.TabIndex = 0;
			this.DeleteCollectionBtn.Text = "Видалити";
			this.DeleteCollectionBtn.UseVisualStyleBackColor = true;
			this.DeleteCollectionBtn.Click += new System.EventHandler(this.DeleteCollectionBtn_Click);
			// 
			// panel22
			// 
			this.panel22.Controls.Add(this.label1);
			this.panel22.Controls.Add(this.CollectionTextBox);
			this.panel22.Controls.Add(this.NewCollectionBtn);
			this.panel22.Controls.Add(this.DeleteCollectionBtn);
			this.panel22.Controls.Add(this.SaveCollectionBtn);
			this.panel22.Controls.Add(this.NameLabel);
			this.panel22.Controls.Add(this.NameBox);
			this.panel22.Location = new System.Drawing.Point(215, 4);
			this.panel22.Name = "panel22";
			this.panel22.Size = new System.Drawing.Size(609, 447);
			this.panel22.TabIndex = 20;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(8, 87);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(63, 25);
			this.label1.TabIndex = 16;
			this.label1.Text = "Опис";
			// 
			// CollectionTextBox
			// 
			this.CollectionTextBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.CollectionTextBox.Location = new System.Drawing.Point(11, 128);
			this.CollectionTextBox.Name = "CollectionTextBox";
			this.CollectionTextBox.Size = new System.Drawing.Size(593, 307);
			this.CollectionTextBox.TabIndex = 15;
			this.CollectionTextBox.Text = "";
			// 
			// NewCollectionBtn
			// 
			this.NewCollectionBtn.Location = new System.Drawing.Point(404, 8);
			this.NewCollectionBtn.Name = "NewCollectionBtn";
			this.NewCollectionBtn.Size = new System.Drawing.Size(200, 36);
			this.NewCollectionBtn.TabIndex = 4;
			this.NewCollectionBtn.Text = "Створити";
			this.NewCollectionBtn.UseVisualStyleBackColor = true;
			this.NewCollectionBtn.Click += new System.EventHandler(this.NewCollectionBtn_Click);
			// 
			// SaveCollectionBtn
			// 
			this.SaveCollectionBtn.Location = new System.Drawing.Point(405, 47);
			this.SaveCollectionBtn.Name = "SaveCollectionBtn";
			this.SaveCollectionBtn.Size = new System.Drawing.Size(200, 36);
			this.SaveCollectionBtn.TabIndex = 3;
			this.SaveCollectionBtn.Text = "Оновити";
			this.SaveCollectionBtn.UseVisualStyleBackColor = true;
			this.SaveCollectionBtn.Click += new System.EventHandler(this.SaveCollectionBtn_Click);
			// 
			// NameLabel
			// 
			this.NameLabel.AutoSize = true;
			this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.NameLabel.Location = new System.Drawing.Point(8, 9);
			this.NameLabel.Name = "NameLabel";
			this.NameLabel.Size = new System.Drawing.Size(73, 25);
			this.NameLabel.TabIndex = 2;
			this.NameLabel.Text = "Назва";
			// 
			// NameBox
			// 
			this.NameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.NameBox.Location = new System.Drawing.Point(8, 40);
			this.NameBox.Name = "NameBox";
			this.NameBox.Size = new System.Drawing.Size(200, 35);
			this.NameBox.TabIndex = 1;
			// 
			// CompositionUnselectAllBtn
			// 
			this.CompositionUnselectAllBtn.Location = new System.Drawing.Point(826, 13);
			this.CompositionUnselectAllBtn.Name = "CompositionUnselectAllBtn";
			this.CompositionUnselectAllBtn.Size = new System.Drawing.Size(213, 36);
			this.CompositionUnselectAllBtn.TabIndex = 23;
			this.CompositionUnselectAllBtn.Text = "Очистити вибране";
			this.CompositionUnselectAllBtn.UseVisualStyleBackColor = true;
			this.CompositionUnselectAllBtn.Click += new System.EventHandler(this.CompositionUnselectAllBtn_Click);
			// 
			// CompositionListBox
			// 
			this.CompositionListBox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.CompositionListBox.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.CompositionListBox.ForeColor = System.Drawing.SystemColors.Menu;
			this.CompositionListBox.FormattingEnabled = true;
			this.CompositionListBox.ItemHeight = 23;
			this.CompositionListBox.Location = new System.Drawing.Point(826, 55);
			this.CompositionListBox.Name = "CompositionListBox";
			this.CompositionListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
			this.CompositionListBox.Size = new System.Drawing.Size(213, 395);
			this.CompositionListBox.TabIndex = 22;
			// 
			// CollectionList
			// 
			this.CollectionList.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.CollectionList.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.CollectionList.ForeColor = System.Drawing.SystemColors.Menu;
			this.CollectionList.FormattingEnabled = true;
			this.CollectionList.ItemHeight = 23;
			this.CollectionList.Location = new System.Drawing.Point(1, 56);
			this.CollectionList.Name = "CollectionList";
			this.CollectionList.Size = new System.Drawing.Size(213, 395);
			this.CollectionList.TabIndex = 21;
			this.CollectionList.SelectedIndexChanged += new System.EventHandler(this.CollectionList_SelectedIndexChanged);
			// 
			// CollectionUnselectBtn
			// 
			this.CollectionUnselectBtn.Location = new System.Drawing.Point(1, 14);
			this.CollectionUnselectBtn.Name = "CollectionUnselectBtn";
			this.CollectionUnselectBtn.Size = new System.Drawing.Size(213, 36);
			this.CollectionUnselectBtn.TabIndex = 24;
			this.CollectionUnselectBtn.Text = "Очистити вибране";
			this.CollectionUnselectBtn.UseVisualStyleBackColor = true;
			this.CollectionUnselectBtn.Click += new System.EventHandler(this.CollectionUnselectBtn_Click);
			// 
			// CollectionForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.ClientSize = new System.Drawing.Size(1041, 450);
			this.Controls.Add(this.CollectionUnselectBtn);
			this.Controls.Add(this.panel22);
			this.Controls.Add(this.CompositionUnselectAllBtn);
			this.Controls.Add(this.CompositionListBox);
			this.Controls.Add(this.CollectionList);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "CollectionForm";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "CollectionForm";
			this.Load += new System.EventHandler(this.CollectionForm_Load);
			this.panel22.ResumeLayout(false);
			this.panel22.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button DeleteCollectionBtn;
		private System.Windows.Forms.Panel panel22;
		private System.Windows.Forms.RichTextBox CollectionTextBox;
		private System.Windows.Forms.Button NewCollectionBtn;
		private System.Windows.Forms.Button SaveCollectionBtn;
		private System.Windows.Forms.Label NameLabel;
		private System.Windows.Forms.TextBox NameBox;
		private System.Windows.Forms.Button CompositionUnselectAllBtn;
		private System.Windows.Forms.ListBox CompositionListBox;
		private System.Windows.Forms.ListBox CollectionList;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button CollectionUnselectBtn;
	}
}