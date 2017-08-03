using System;
using System.IO;
using System.Windows.Forms;
using AccountManager.Core;
using AccountManager.Helper;

namespace AccountManager
{
    public partial class LoginForm : Form
    {
        public static string DataFilePath { get; set; }

        private readonly MainForm _parent;

        public LoginForm(MainForm parent)
        {
            InitializeComponent();
            DataFilePath = "Source.am";
            _parent = parent;
        }

        private void Login_Click(object sender, EventArgs e)
        {
            var password = Password.Text;
            Database db;
            if (File.Exists(DataFilePath))
            {
                var origin = File.ReadAllBytes(DataFilePath);
                var bytes = SecretHelper.AesDecrypt(origin, password);
                if (bytes == null)
                {
                    MessageBox.Show(this, @"Password is wrong.");
                    return;
                }
                var json = System.Text.Encoding.Default.GetString(bytes);
                if (json == string.Empty)
                {
                    MessageBox.Show(this, @"Password is wrong.");
                    return;
                }
                db = Database.Create(json, password, DataFilePath);
            }
            else
            {
                var select = MessageBox.Show(@"Database is not exists. Do you want to create a new one?", @"Error", MessageBoxButtons.YesNo);
                if (select == DialogResult.Yes)
                {
                    db = Database.Create(string.Empty, password, DataFilePath);
                    var result = db.Save();
                    if (!result)
                    {
                        MessageBox.Show(@"Write to file error", @"Error", MessageBoxButtons.OK);
                        return;
                    }
                }
                else
                    return;
            }

            if (db == null)
                return;

            DialogResult = DialogResult.OK;
            _parent.Data = db;
            Close();
        }

        private void Setting_Click(object sender, EventArgs e)
        {
            var file = new OpenFileDialog
            {
                Filter = @"Files (*.am)|*.am"
            };
            file.ShowDialog();
            if (file.FileName == string.Empty) return;

            DataFilePath = file.FileName;
            DataSource.Text = file.SafeFileName;
        }
    }
}
