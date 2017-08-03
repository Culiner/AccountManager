using System;
using System.Collections.Generic;
using System.Windows.Forms;
using AccountManager.Core;

namespace AccountManager
{
    internal enum Mode
    {
        Normal,
        New,
        Edit
    }

    public partial class MainForm : Form
    {
        public Database Data;
        private List<TextBox> _dataBoxs;
        private Package _nowList;
        private int _nowIndex;
        private List<Button> _buttons;
        private Mode _nowMode;

        public MainForm()
        {
            InitializeComponent();
            _nowIndex = 0;
            _nowList = new Package(string.Empty);
            _nowMode = Mode.Normal;
        }

        public void Initialize()
        {
            RefreshTags();
            _dataBoxs = new List<TextBox>
            {
                TagText,
                SubclassText,
                UsernameText,
                PasswordText,
                AdditionText
            };
            _buttons = new List<Button>
            {
                NewButton,
                EditButton,
                DeleteButton,
                PrevButton,
                NextButton
            };
        }

        private void New_Click(object sender, EventArgs e)
        {
            _nowMode = Mode.New;
            Reset(_nowMode);
        }
        
        private void EditButton_Click(object sender, EventArgs e)
        {
            if (_nowList.Tag == string.Empty)
            {
                MessageBox.Show(@"No Data", @"Error", MessageBoxButtons.OK);
                return;
            }
            
            _nowMode = Mode.Edit;
            Reset(_nowMode);
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            switch (_nowMode)
            {
                case Mode.Normal:
                    break;
                case Mode.New:
                    if (TagText.Text == string.Empty)
                        return;
                    if (!Data.Data.ContainsKey(TagText.Text))
                    {
                        Data.Data[TagText.Text] = new Package(TagText.Text);
                    }
                    Data.Data[TagText.Text].Items.Add(new Item
                    {
                        Subclass = SubclassText.Text,
                        Username = UsernameText.Text,
                        Password = PasswordText.Text,
                        Addition = AdditionText.Text
                    });
                    var result = Data.Save();
                    if (!result)
                    {
                        MessageBox.Show(@"Write to file error", @"Error", MessageBoxButtons.OK);
                        return;
                    }
                    _nowMode = Mode.Normal;
                    Reset(_nowMode);
                    RefreshTags();
                    break;
                case Mode.Edit:
                    var select = MessageBox.Show(@"Confirm to change this data?", @"Confirm", MessageBoxButtons.YesNo);
                    if (select != DialogResult.Yes) return;

                    var tmp = Data.Data[_nowList.Tag];
                    tmp.Items[_nowIndex].Subclass = SubclassText.Text;
                    tmp.Items[_nowIndex].Username = UsernameText.Text;
                    tmp.Items[_nowIndex].Password = PasswordText.Text;
                    tmp.Items[_nowIndex].Addition = AdditionText.Text;

                    if (!Data.Save())
                        MessageBox.Show(@"Something error", @"Error", MessageBoxButtons.OK);
                    
                    _nowMode = Mode.Normal;
                    Reset(_nowMode);

                    _nowList = Data.Data[_nowList.Tag];
                    ShowNowData();
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            _nowMode = Mode.Normal;
            ShowNowData();
            Reset(_nowMode);
        }

        private void SearchTag(object sender, EventArgs e)
        {
            var tag = Tags.Text;
            if (Data.Data.ContainsKey(tag))
            {
                _nowList = Data.Data[tag];
                _nowIndex = 0;
                ShowNowData();
            }
            else
            {
                MessageBox.Show(@"Data Not Found", @"Error", MessageBoxButtons.OK);
            }
        }

        private void PrevButton_Click(object sender, EventArgs e)
        {
            _nowIndex--;
            ShowNowData();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            _nowIndex++;
            ShowNowData();
        }
        
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (_nowList.Tag == string.Empty)
            {
                MessageBox.Show(@"No Data", @"Error", MessageBoxButtons.OK);
                return;
            }

            var select = MessageBox.Show(@"Confirm to delete this data?", @"Confirm", MessageBoxButtons.YesNo);
            if (select != DialogResult.Yes) return;

            var tmp = Data.Data[_nowList.Tag];
            tmp.Items.RemoveAt(_nowIndex);
            if (tmp.Items.Count == 0)
            {
                Data.Data.Remove(_nowList.Tag);
                _nowList = new Package(string.Empty);
                _nowIndex = 0;
                EmptyTextBoxs();
                RefreshTags();
            }
            else
            {
                ShowNowData();
            }

            if (!Data.Save())
            {
                MessageBox.Show(@"Something error", @"Error", MessageBoxButtons.OK);
            }
        }

        #region Helper

        private void RefreshTags()
        {
            Tags.Items.Clear();
            foreach (var tag in Data.GetTags())
            {
                Tags.Items.Add(tag);
            }
        }

        private void ChangeTextBoxs(bool status)
        {
            foreach (var box in _dataBoxs)
            {
                box.ReadOnly = status;
            }
        }

        private void ChangeButtons(bool status)
        {
            foreach (var button in _buttons)
            {
                button.Enabled = status;
            }
        }

        private void EmptyTextBoxs()
        {
            foreach (var box in _dataBoxs)
            {
                box.Text = string.Empty;
            }
        }

        private void ShowNowData()
        {
            if (_nowIndex >= _nowList.Items.Count)
                _nowIndex = 0;
            if (_nowIndex < 0)
                _nowIndex = _nowList.Items.Count - 1;
            
            TagText.Text = _nowList.Tag;
            SubclassText.Text = _nowList.Items[_nowIndex].Subclass;
            UsernameText.Text = _nowList.Items[_nowIndex].Username;
            PasswordText.Text = _nowList.Items[_nowIndex].Password;
            AdditionText.Text = _nowList.Items[_nowIndex].Addition;
        }

        private void Reset(Mode mode)
        {
            switch (mode)
            {
                case Mode.New:
                    EmptyTextBoxs();
                    ChangeTextBoxs(false);
                    ChangeButtons(false);
                    Tags.Enabled = false;
                    OkButton.Visible = true;
                    CancelButton.Visible = true;
                    break;
                case Mode.Normal:
                    EmptyTextBoxs();
                    ChangeTextBoxs(true);
                    ChangeButtons(true);
                    Tags.Enabled = true;
                    OkButton.Visible = false;
                    CancelButton.Visible = false;
                    break;
                case Mode.Edit:
                    ChangeTextBoxs(false);
                    ChangeButtons(false);
                    Tags.Enabled = false;
                    OkButton.Visible = true;
                    CancelButton.Visible = true;
                    TagText.ReadOnly = true;
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(mode), mode, null);
            }
        }

        #endregion
    }
}
