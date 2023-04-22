using System;
using System.IO;
using System.Windows.Forms;

namespace SimpleBrowser
{
    public partial class Bookmark : Form
    {
        public Bookmark()
        {
            InitializeComponent();
        }

        private void Bookmark_Load(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists("Bookmark.csv"))
                {
                    string[] bookmarks = File.ReadAllText("Bookmark.csv").Split('\n');
                    foreach (string bookmark in bookmarks)
                    {
                        string[] bookmark_ = bookmark.Split(',');
                        Bookmarks.Rows.Add(bookmark_[0], bookmark_[1]);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ブックマークの取得に失敗しました。" + ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            try
            {
                string csv = "\n";
                foreach (DataGridViewRow data in Bookmarks.Rows)
                    csv += $"\n{data.Cells[0].Value},{data.Cells[1].Value}";
                csv = csv.Replace("\n\n", "");
                File.WriteAllText("Bookmark.csv", csv);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ブックマークの保存に失敗しました。" + ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AutoSave_Tick(object sender, EventArgs e)
        {
            Save_Click(sender, e);
        }

        private void Bookmark_FormClosing(object sender, FormClosingEventArgs e)
        {
            Save_Click(sender, e);
        }
    }
}
