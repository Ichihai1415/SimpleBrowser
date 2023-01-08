using Microsoft.Web.WebView2.Core;
using SimpleBrowser.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SimpleBrowser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            URLtext.Size = new Size(ClientSize.Width - 140, 19);
            MainBrowser.Size = ClientSize - new Size(MainBrowser.Location);
            LoadPage.Left = ClientSize.Width - 130;
            Back.Left = ClientSize.Width - 64;
            Forward.Left = ClientSize.Width - 44;
            Reload.Left = ClientSize.Width - 24;
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
            Settings.Default.Reload();
                Location = Settings.Default.MainWindowLocation;
            if (Settings.Default.MainWindowMax)
                WindowState = FormWindowState.Maximized;
            else
                Size = Settings.Default.MainWindowSize;
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
            if (MainBrowser.CoreWebView2.CanGoBack)
                Back.Enabled = true;
            else
                Back.Enabled = false;
            if (MainBrowser.CoreWebView2.CanGoForward)
                Forward.Enabled = true;
            else
                Forward.Enabled = false;
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
    }
}
