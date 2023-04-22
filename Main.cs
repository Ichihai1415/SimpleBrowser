using Microsoft.Web.WebView2.Core;
using SimpleBrowser.Properties;
using System;
using System.Configuration;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace SimpleBrowser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MainBrowser.Source = new Uri("https://Ichihai1415.github.io/programs/simple-browser/default.html?ver=1.0.2");
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            URLtext.Size = new Size(ClientSize.Width - 160, 19);
            ButtonsBack.Location = new Point(ClientSize.Width - 150, 5);
            MainBack.Size = ClientSize - new Size(MainBack.Location);
            MainBrowser.Size = MainBack.Size;
        }

        private void View_Click(object sender, EventArgs e)
        {
            if (!URLtext.Text.StartsWith("http://") && !URLtext.Text.StartsWith("https://"))
            {
                DialogResult Result = MessageBox.Show("URLが\"http://\"または\"https://\"で始まっていません。再試行を押すと\"http://\"を追加して取得します。", "確認", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Exclamation);
                if (Result == DialogResult.Retry)
                    URLtext.Text = "http://" + URLtext.Text;
                else if (Result == DialogResult.Abort)
                    return;
            }
            try
            {
                MainBrowser.CoreWebView2.Navigate(URLtext.Text);
            }
            catch (Exception ex)
            {
                string AddText = "";
                if (ex.Message == "値が有効な範囲にありません。")
                    AddText = "URLの形式が正しくない可能性があります。";
                MessageBox.Show($"エラーが発生しました。{AddText}\n\n{ex.Message}", "SimpleBrowser", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Configuration Config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.PerUserRoamingAndLocal);
            if (File.Exists("UserSetting.xml"))//AppDataに保存
            {
                if (!Directory.Exists(Config.FilePath.Replace("\\user.config", "")))//実質更新時
                    Directory.CreateDirectory(Config.FilePath.Replace("\\user.config", ""));
                File.Copy("UserSetting.xml", Config.FilePath, true);
            }
            Settings.Default.Reload();
            Location = Settings.Default.MainWindowLocation;
            if (Settings.Default.MainWindowMax)
                WindowState = FormWindowState.Maximized;
            else
                Size = Settings.Default.MainWindowSize;
            if (Settings.Default.WebView2Font != null)
                MainBack.Font = Settings.Default.WebView2Font;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Settings.Default.MainWindowSize = Size;
            Settings.Default.MainWindowLocation = Location;
            if (WindowState == FormWindowState.Maximized)
                Settings.Default.MainWindowMax = true;
            else
                Settings.Default.MainWindowMax = false;
            Settings.Default.Save();
        }

        private void MainBrowser_SourceChanged(object sender, CoreWebView2SourceChangedEventArgs e)
        {
            URLtext.Text = MainBrowser.CoreWebView2.Source;
        }

        private void Back_Click(object sender, EventArgs e)
        {
            MainBrowser.CoreWebView2.GoBack();
        }

        private void Forward_Click(object sender, EventArgs e)
        {
            MainBrowser.CoreWebView2.GoForward();
        }

        private void Reload_Click(object sender, EventArgs e)
        {
            MainBrowser.CoreWebView2.Reload();
        }

        private void OpenBookmark_Click(object sender, EventArgs e)
        {
            Bookmark bookmark = new Bookmark();
            bookmark.Show();
        }

        private void OpenSetting_Click(object sender, EventArgs e)
        {
            SettingForm settingForm = new SettingForm();
            settingForm.Show();
        }

        private void MainBrowser_NavigationStarting(object sender, CoreWebView2NavigationStartingEventArgs e)
        {
            LoadPage.Enabled = false;
            Back.Enabled = false;
            Forward.Enabled = false;
            Reload.Enabled = false;
        }

        private async void MainBrowser_NavigationCompleted(object sender, CoreWebView2NavigationCompletedEventArgs e)
        {
            LoadPage.Enabled = true;
            Reload.Enabled = true;
            if (MainBrowser.CoreWebView2.CanGoBack)
                Back.Enabled = true;
            if (MainBrowser.CoreWebView2.CanGoForward)
                Forward.Enabled = true;
            if (File.Exists("script.js"))
                await MainBrowser.CoreWebView2.ExecuteScriptAsync(File.ReadAllText("script.js"));
        }
    }
}
