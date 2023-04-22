namespace SimpleBrowser
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.URLtext = new System.Windows.Forms.TextBox();
            this.LoadPage = new System.Windows.Forms.Button();
            this.MainBrowser = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.Back = new System.Windows.Forms.Button();
            this.Forward = new System.Windows.Forms.Button();
            this.Reload = new System.Windows.Forms.Button();
            this.OpenSetting = new System.Windows.Forms.Button();
            this.OpenBookmark = new System.Windows.Forms.Button();
            this.MainBack = new System.Windows.Forms.Panel();
            this.ButtonsBack = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.MainBrowser)).BeginInit();
            this.MainBack.SuspendLayout();
            this.ButtonsBack.SuspendLayout();
            this.SuspendLayout();
            // 
            // URLtext
            // 
            this.URLtext.Location = new System.Drawing.Point(5, 5);
            this.URLtext.Name = "URLtext";
            this.URLtext.Size = new System.Drawing.Size(480, 19);
            this.URLtext.TabIndex = 1;
            // 
            // LoadPage
            // 
            this.LoadPage.Location = new System.Drawing.Point(0, 0);
            this.LoadPage.Name = "LoadPage";
            this.LoadPage.Size = new System.Drawing.Size(41, 21);
            this.LoadPage.TabIndex = 2;
            this.LoadPage.Text = "Load";
            this.LoadPage.UseVisualStyleBackColor = true;
            this.LoadPage.Click += new System.EventHandler(this.View_Click);
            // 
            // MainBrowser
            // 
            this.MainBrowser.AllowExternalDrop = true;
            this.MainBrowser.CreationProperties = null;
            this.MainBrowser.DefaultBackgroundColor = System.Drawing.Color.White;
            this.MainBrowser.Location = new System.Drawing.Point(0, 0);
            this.MainBrowser.Margin = new System.Windows.Forms.Padding(0);
            this.MainBrowser.Name = "MainBrowser";
            this.MainBrowser.Size = new System.Drawing.Size(640, 330);
            this.MainBrowser.Source = new System.Uri("https://Ichihai1415.github.io/programs/simple-browser/default.html?ver=?", System.UriKind.Absolute);
            this.MainBrowser.TabIndex = 3;
            this.MainBrowser.ZoomFactor = 1D;
            this.MainBrowser.NavigationStarting += new System.EventHandler<Microsoft.Web.WebView2.Core.CoreWebView2NavigationStartingEventArgs>(this.MainBrowser_NavigationStarting);
            this.MainBrowser.NavigationCompleted += new System.EventHandler<Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs>(this.MainBrowser_NavigationCompleted);
            this.MainBrowser.SourceChanged += new System.EventHandler<Microsoft.Web.WebView2.Core.CoreWebView2SourceChangedEventArgs>(this.MainBrowser_SourceChanged);
            // 
            // Back
            // 
            this.Back.Enabled = false;
            this.Back.Font = new System.Drawing.Font("MS UI Gothic", 8F);
            this.Back.Location = new System.Drawing.Point(40, 0);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(21, 21);
            this.Back.TabIndex = 4;
            this.Back.Text = "←";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Forward
            // 
            this.Forward.Enabled = false;
            this.Forward.Font = new System.Drawing.Font("MS UI Gothic", 8F);
            this.Forward.Location = new System.Drawing.Point(60, 0);
            this.Forward.Name = "Forward";
            this.Forward.Size = new System.Drawing.Size(21, 21);
            this.Forward.TabIndex = 5;
            this.Forward.Text = "→";
            this.Forward.UseVisualStyleBackColor = true;
            this.Forward.Click += new System.EventHandler(this.Forward_Click);
            // 
            // Reload
            // 
            this.Reload.Location = new System.Drawing.Point(80, 0);
            this.Reload.Name = "Reload";
            this.Reload.Size = new System.Drawing.Size(21, 21);
            this.Reload.TabIndex = 6;
            this.Reload.Text = "↻";
            this.Reload.UseVisualStyleBackColor = true;
            this.Reload.Click += new System.EventHandler(this.Reload_Click);
            // 
            // OpenSetting
            // 
            this.OpenSetting.Font = new System.Drawing.Font("MS UI Gothic", 9F);
            this.OpenSetting.Location = new System.Drawing.Point(126, 0);
            this.OpenSetting.Name = "OpenSetting";
            this.OpenSetting.Size = new System.Drawing.Size(21, 21);
            this.OpenSetting.TabIndex = 7;
            this.OpenSetting.Text = "⚙";
            this.OpenSetting.UseVisualStyleBackColor = true;
            this.OpenSetting.Click += new System.EventHandler(this.OpenSetting_Click);
            // 
            // OpenBookmark
            // 
            this.OpenBookmark.Font = new System.Drawing.Font("MS UI Gothic", 8F);
            this.OpenBookmark.Location = new System.Drawing.Point(103, 0);
            this.OpenBookmark.Name = "OpenBookmark";
            this.OpenBookmark.Size = new System.Drawing.Size(21, 21);
            this.OpenBookmark.TabIndex = 8;
            this.OpenBookmark.Text = "★";
            this.OpenBookmark.UseVisualStyleBackColor = true;
            this.OpenBookmark.Click += new System.EventHandler(this.OpenBookmark_Click);
            // 
            // MainBack
            // 
            this.MainBack.Controls.Add(this.MainBrowser);
            this.MainBack.Font = new System.Drawing.Font("MS UI Gothic", 9F);
            this.MainBack.Location = new System.Drawing.Point(0, 30);
            this.MainBack.Name = "MainBack";
            this.MainBack.Size = new System.Drawing.Size(640, 330);
            this.MainBack.TabIndex = 9;
            // 
            // ButtonsBack
            // 
            this.ButtonsBack.Controls.Add(this.LoadPage);
            this.ButtonsBack.Controls.Add(this.Back);
            this.ButtonsBack.Controls.Add(this.OpenBookmark);
            this.ButtonsBack.Controls.Add(this.Forward);
            this.ButtonsBack.Controls.Add(this.OpenSetting);
            this.ButtonsBack.Controls.Add(this.Reload);
            this.ButtonsBack.Location = new System.Drawing.Point(490, 5);
            this.ButtonsBack.Name = "ButtonsBack";
            this.ButtonsBack.Size = new System.Drawing.Size(150, 21);
            this.ButtonsBack.TabIndex = 10;
            // 
            // Form1
            // 
            this.AcceptButton = this.LoadPage;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(640, 360);
            this.Controls.Add(this.ButtonsBack);
            this.Controls.Add(this.MainBack);
            this.Controls.Add(this.URLtext);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "SimpleBrowser";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.MainBrowser)).EndInit();
            this.MainBack.ResumeLayout(false);
            this.ButtonsBack.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox URLtext;
        private System.Windows.Forms.Button LoadPage;
        private Microsoft.Web.WebView2.WinForms.WebView2 MainBrowser;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button Forward;
        private System.Windows.Forms.Button Reload;
        private System.Windows.Forms.Button OpenSetting;
        private System.Windows.Forms.Button OpenBookmark;
        private System.Windows.Forms.Panel MainBack;
        private System.Windows.Forms.Panel ButtonsBack;
    }
}

