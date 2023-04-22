namespace SimpleBrowser
{
    partial class Bookmark
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
            this.components = new System.ComponentModel.Container();
            this.Bookmarks = new System.Windows.Forms.DataGridView();
            this.Save = new System.Windows.Forms.Button();
            this.NameMemo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.URL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AutoSave = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Bookmarks)).BeginInit();
            this.SuspendLayout();
            // 
            // Bookmarks
            // 
            this.Bookmarks.AllowUserToOrderColumns = true;
            this.Bookmarks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Bookmarks.ColumnHeadersHeight = 24;
            this.Bookmarks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameMemo,
            this.URL});
            this.Bookmarks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Bookmarks.Location = new System.Drawing.Point(0, 0);
            this.Bookmarks.Name = "Bookmarks";
            this.Bookmarks.RowTemplate.Height = 21;
            this.Bookmarks.Size = new System.Drawing.Size(640, 360);
            this.Bookmarks.TabIndex = 0;
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(0, 0);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(43, 25);
            this.Save.TabIndex = 1;
            this.Save.Text = "保存";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // NameMemo
            // 
            this.NameMemo.HeaderText = "名前";
            this.NameMemo.Name = "NameMemo";
            // 
            // URL
            // 
            this.URL.HeaderText = "URL";
            this.URL.Name = "URL";
            this.URL.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // AutoSave
            // 
            this.AutoSave.Enabled = true;
            this.AutoSave.Interval = 60000;
            this.AutoSave.Tick += new System.EventHandler(this.AutoSave_Tick);
            // 
            // Bookmark
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 360);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Bookmarks);
            this.Name = "Bookmark";
            this.Text = "ブックマーク";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Bookmark_FormClosing);
            this.Load += new System.EventHandler(this.Bookmark_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Bookmarks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Bookmarks;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameMemo;
        private System.Windows.Forms.DataGridViewTextBoxColumn URL;
        private System.Windows.Forms.Timer AutoSave;
    }
}