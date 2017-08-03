namespace AccountManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.DataSource = new System.Windows.Forms.Label();
            this.DataLabel = new System.Windows.Forms.Label();
            this.Setting = new System.Windows.Forms.Button();
            this.KeyLabel = new System.Windows.Forms.Label();
            this.Login = new System.Windows.Forms.Button();
            this.Password = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // DataSource
            // 
            this.DataSource.AutoSize = true;
            this.DataSource.Location = new System.Drawing.Point(75, 22);
            this.DataSource.Name = "DataSource";
            this.DataSource.Size = new System.Drawing.Size(99, 24);
            this.DataSource.TabIndex = 5;
            this.DataSource.Text = "Source.am";
            // 
            // DataLabel
            // 
            this.DataLabel.AutoSize = true;
            this.DataLabel.Location = new System.Drawing.Point(12, 22);
            this.DataLabel.Name = "DataLabel";
            this.DataLabel.Size = new System.Drawing.Size(65, 24);
            this.DataLabel.TabIndex = 4;
            this.DataLabel.Text = "Data : ";
            // 
            // Setting
            // 
            this.Setting.Location = new System.Drawing.Point(106, 99);
            this.Setting.Name = "Setting";
            this.Setting.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Setting.Size = new System.Drawing.Size(75, 29);
            this.Setting.TabIndex = 3;
            this.Setting.Text = "Setting";
            this.Setting.UseVisualStyleBackColor = true;
            this.Setting.Click += new System.EventHandler(this.Setting_Click);
            // 
            // KeyLabel
            // 
            this.KeyLabel.AutoSize = true;
            this.KeyLabel.Location = new System.Drawing.Point(12, 60);
            this.KeyLabel.Name = "KeyLabel";
            this.KeyLabel.Size = new System.Drawing.Size(50, 24);
            this.KeyLabel.TabIndex = 2;
            this.KeyLabel.Text = "Key :";
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(25, 99);
            this.Login.Name = "Login";
            this.Login.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Login.Size = new System.Drawing.Size(75, 29);
            this.Login.TabIndex = 1;
            this.Login.Text = "Login";
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(68, 57);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.Size = new System.Drawing.Size(116, 31);
            this.Password.TabIndex = 0;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(208, 134);
            this.Controls.Add(this.DataSource);
            this.Controls.Add(this.DataLabel);
            this.Controls.Add(this.Setting);
            this.Controls.Add(this.KeyLabel);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.Password);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(300, 200);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(230, 190);
            this.MinimumSize = new System.Drawing.Size(230, 190);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DataSource;
        private System.Windows.Forms.Label DataLabel;
        private System.Windows.Forms.Button Setting;
        private System.Windows.Forms.Label KeyLabel;
        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.TextBox Password;
    }
}