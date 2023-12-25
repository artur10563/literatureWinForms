namespace Literature.Forms
{
	partial class LoginForm
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
			this.loginInput = new System.Windows.Forms.TextBox();
			this.PasswordInput = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.loginBtn = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// loginInput
			// 
			this.loginInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.loginInput.Location = new System.Drawing.Point(127, 32);
			this.loginInput.Name = "loginInput";
			this.loginInput.Size = new System.Drawing.Size(208, 29);
			this.loginInput.TabIndex = 0;
			// 
			// PasswordInput
			// 
			this.PasswordInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.PasswordInput.Location = new System.Drawing.Point(127, 82);
			this.PasswordInput.Name = "PasswordInput";
			this.PasswordInput.PasswordChar = '*';
			this.PasswordInput.Size = new System.Drawing.Size(208, 29);
			this.PasswordInput.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(22, 31);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(74, 29);
			this.label1.TabIndex = 2;
			this.label1.Text = "Логін";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(22, 82);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(99, 29);
			this.label2.TabIndex = 3;
			this.label2.Text = "Пароль";
			// 
			// loginBtn
			// 
			this.loginBtn.Location = new System.Drawing.Point(127, 126);
			this.loginBtn.Name = "loginBtn";
			this.loginBtn.Size = new System.Drawing.Size(208, 41);
			this.loginBtn.TabIndex = 4;
			this.loginBtn.Text = "Продовжити";
			this.loginBtn.UseVisualStyleBackColor = true;
			this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
			// 
			// LoginForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.ClientSize = new System.Drawing.Size(386, 192);
			this.Controls.Add(this.loginBtn);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.PasswordInput);
			this.Controls.Add(this.loginInput);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "LoginForm";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "LoginForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox loginInput;
		private System.Windows.Forms.TextBox PasswordInput;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button loginBtn;
	}
}