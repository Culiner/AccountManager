using System;
using System.Windows.Forms;

namespace AccountManager
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            var mainForm = new MainForm();
            var loginForm = new LoginForm(mainForm);
            loginForm.ShowDialog();
            if (loginForm.DialogResult == DialogResult.OK)
            {
                mainForm.Initialize();
                Application.Run(mainForm);
            }
        }
    }
}
