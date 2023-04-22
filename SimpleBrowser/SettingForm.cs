using SimpleBrowser.Properties;
using System;
using System.Configuration;
using System.IO;
using System.Windows.Forms;

namespace SimpleBrowser
{
    public partial class SettingForm : Form
    {
        public SettingForm()
        {
            InitializeComponent();
        }

        private void SettingForm_Load(object sender, EventArgs e)
        {
            FontName.Text = Settings.Default.WebView2Font.Name;
        }

        private void SelectFont_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            fontDialog.ShowDialog();
            FontName.Font = fontDialog.Font;
            FontName.Text = fontDialog.Font.Name;
            Settings.Default.WebView2Font = fontDialog.Font;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Settings.Default.Save();
            Configuration Config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.PerUserRoamingAndLocal);
            File.Copy(Config.FilePath, "UserSetting.xml", true);
        }
    }
}
