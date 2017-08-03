namespace AccountManager
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.TagText = new System.Windows.Forms.TextBox();
            this.SubclassText = new System.Windows.Forms.TextBox();
            this.TagLabel = new System.Windows.Forms.Label();
            this.AdditionText = new System.Windows.Forms.TextBox();
            this.UsernameText = new System.Windows.Forms.TextBox();
            this.PasswordText = new System.Windows.Forms.TextBox();
            this.SubclassLabel = new System.Windows.Forms.Label();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.AdditionLabel = new System.Windows.Forms.Label();
            this.NextButton = new System.Windows.Forms.Button();
            this.PrevButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.NewButton = new System.Windows.Forms.Button();
            this.Tags = new System.Windows.Forms.ComboBox();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.OkButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TagText
            // 
            this.TagText.Location = new System.Drawing.Point(141, 66);
            this.TagText.Name = "TagText";
            this.TagText.ReadOnly = true;
            this.TagText.Size = new System.Drawing.Size(318, 31);
            this.TagText.TabIndex = 1;
            // 
            // SubclassText
            // 
            this.SubclassText.Location = new System.Drawing.Point(141, 102);
            this.SubclassText.Name = "SubclassText";
            this.SubclassText.ReadOnly = true;
            this.SubclassText.Size = new System.Drawing.Size(318, 31);
            this.SubclassText.TabIndex = 2;
            // 
            // TagLabel
            // 
            this.TagLabel.AutoSize = true;
            this.TagLabel.Location = new System.Drawing.Point(42, 68);
            this.TagLabel.Name = "TagLabel";
            this.TagLabel.Size = new System.Drawing.Size(51, 24);
            this.TagLabel.TabIndex = 5;
            this.TagLabel.Text = "Tag :";
            // 
            // AdditionText
            // 
            this.AdditionText.Location = new System.Drawing.Point(141, 215);
            this.AdditionText.Multiline = true;
            this.AdditionText.Name = "AdditionText";
            this.AdditionText.ReadOnly = true;
            this.AdditionText.Size = new System.Drawing.Size(318, 166);
            this.AdditionText.TabIndex = 5;
            // 
            // UsernameText
            // 
            this.UsernameText.Location = new System.Drawing.Point(141, 140);
            this.UsernameText.Name = "UsernameText";
            this.UsernameText.ReadOnly = true;
            this.UsernameText.Size = new System.Drawing.Size(318, 31);
            this.UsernameText.TabIndex = 3;
            // 
            // PasswordText
            // 
            this.PasswordText.Location = new System.Drawing.Point(141, 178);
            this.PasswordText.Name = "PasswordText";
            this.PasswordText.ReadOnly = true;
            this.PasswordText.Size = new System.Drawing.Size(318, 31);
            this.PasswordText.TabIndex = 4;
            // 
            // SubclassLabel
            // 
            this.SubclassLabel.AutoSize = true;
            this.SubclassLabel.Location = new System.Drawing.Point(42, 105);
            this.SubclassLabel.Name = "SubclassLabel";
            this.SubclassLabel.Size = new System.Drawing.Size(92, 24);
            this.SubclassLabel.TabIndex = 6;
            this.SubclassLabel.Text = "Subclass :";
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Location = new System.Drawing.Point(42, 143);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(105, 24);
            this.UsernameLabel.TabIndex = 7;
            this.UsernameLabel.Text = "Username :";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(42, 181);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(100, 24);
            this.PasswordLabel.TabIndex = 8;
            this.PasswordLabel.Text = "Password :";
            // 
            // AdditionLabel
            // 
            this.AdditionLabel.AutoSize = true;
            this.AdditionLabel.Location = new System.Drawing.Point(42, 218);
            this.AdditionLabel.Name = "AdditionLabel";
            this.AdditionLabel.Size = new System.Drawing.Size(95, 24);
            this.AdditionLabel.TabIndex = 9;
            this.AdditionLabel.Text = "Addition :";
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(480, 135);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(75, 29);
            this.NextButton.TabIndex = 10;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // PrevButton
            // 
            this.PrevButton.Location = new System.Drawing.Point(480, 100);
            this.PrevButton.Name = "PrevButton";
            this.PrevButton.Size = new System.Drawing.Size(75, 29);
            this.PrevButton.TabIndex = 11;
            this.PrevButton.Text = "Prev";
            this.PrevButton.UseVisualStyleBackColor = true;
            this.PrevButton.Click += new System.EventHandler(this.PrevButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(399, 28);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(75, 29);
            this.EditButton.TabIndex = 14;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // NewButton
            // 
            this.NewButton.Location = new System.Drawing.Point(318, 28);
            this.NewButton.Name = "NewButton";
            this.NewButton.Size = new System.Drawing.Size(75, 29);
            this.NewButton.TabIndex = 15;
            this.NewButton.Text = "New";
            this.NewButton.UseVisualStyleBackColor = true;
            this.NewButton.Click += new System.EventHandler(this.New_Click);
            // 
            // Tags
            // 
            this.Tags.FormattingEnabled = true;
            this.Tags.Location = new System.Drawing.Point(46, 28);
            this.Tags.Name = "Tags";
            this.Tags.Size = new System.Drawing.Size(139, 32);
            this.Tags.TabIndex = 0;
            this.Tags.SelectedIndexChanged += new System.EventHandler(this.SearchTag);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(480, 28);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 29);
            this.DeleteButton.TabIndex = 16;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(480, 304);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 29);
            this.OkButton.TabIndex = 17;
            this.OkButton.Text = "Ok";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Visible = false;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(480, 339);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 29);
            this.CancelButton.TabIndex = 18;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Visible = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 394);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.Tags);
            this.Controls.Add(this.NewButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.PrevButton);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.AdditionLabel);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.SubclassLabel);
            this.Controls.Add(this.PasswordText);
            this.Controls.Add(this.UsernameText);
            this.Controls.Add(this.AdditionText);
            this.Controls.Add(this.TagLabel);
            this.Controls.Add(this.SubclassText);
            this.Controls.Add(this.TagText);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(100, 100);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 450);
            this.MinimumSize = new System.Drawing.Size(600, 450);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Account Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TagText;
        private System.Windows.Forms.TextBox SubclassText;
        private System.Windows.Forms.Label TagLabel;
        private System.Windows.Forms.TextBox AdditionText;
        private System.Windows.Forms.TextBox UsernameText;
        private System.Windows.Forms.TextBox PasswordText;
        private System.Windows.Forms.Label SubclassLabel;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label AdditionLabel;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Button PrevButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button NewButton;
        private System.Windows.Forms.ComboBox Tags;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Button CancelButton;
    }
}

