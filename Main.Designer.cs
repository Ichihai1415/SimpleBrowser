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
            ((System.ComponentModel.ISupportInitialize)(this.MainBrowser)).BeginInit();
            this.SuspendLayout();
            // 
            // URLtext
            // 
            this.URLtext.Location = new System.Drawing.Point(5, 5);
            this.URLtext.Name = "URLtext";
            this.URLtext.Size = new System.Drawing.Size(500, 19);
            this.URLtext.TabIndex = 1;
            this.URLtext.Text = "https://Ichihai1415.github.io/programs/simple-browser/default.html";
            // 
            // LoadPage
            // 
            this.LoadPage.Location = new System.Drawing.Point(510, 4);
            this.LoadPage.Name = "LoadPage";
            this.LoadPage.Size = new System.Drawing.Size(60, 21);
            this.LoadPage.TabIndex = 2;
            this.LoadPage.Text = "読み込み";
            this.LoadPage.UseVisualStyleBackColor = true;
            this.LoadPage.Click += new System.EventHandler(this.View_Click);
            // 
            // MainBrowser
            // 
            this.MainBrowser.AllowExternalDrop = true;
            this.MainBrowser.CreationProperties = null;
            this.MainBrowser.DefaultBackgroundColor = System.Drawing.Color.White;
            this.MainBrowser.Location = new System.Drawing.Point(0, 30);
            this.MainBrowser.Margin = new System.Windows.Forms.Padding(0);
            this.MainBrowser.Name = "MainBrowser";
            this.MainBrowser.Size = new System.Drawing.Size(640, 330);
            this.MainBrowser.Source = new System.Uri("https://Ichihai1415.github.io/programs/simple-browser/default.html", System.UriKind.Absolute);
            this.MainBrowser.TabIndex = 3;
            this.MainBrowser.ZoomFactor = 1D;
            this.MainBrowser.SourceChanged += new System.EventHandler<Microsoft.Web.WebView2.Core.CoreWebView2SourceChangedEventArgs>(this.MainBrowser_SourceChanged);
            // 
            // Back
            // 
            this.Back.Enabled = false;
            this.Back.Location = new System.Drawing.Point(576, 4);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(20, 21);
            this.Back.TabIndex = 4;
            this.Back.Text = "←";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Forward
            // 
            this.Forward.Enabled = false;
            this.Forward.Location = new System.Drawing.Point(596, 4);
            this.Forward.Name = "Forward";
            this.Forward.Size = new System.Drawing.Size(20, 21);
            this.Forward.TabIndex = 5;
            this.Forward.Text = "→";
            this.Forward.UseVisualStyleBackColor = true;
            this.Forward.Click += new System.EventHandler(this.Forward_Click);
            // 
            // Reload
            // 
            this.Reload.Location = new System.Drawing.Point(616, 4);
            this.Reload.Name = "Reload";
            this.Reload.Size = new System.Drawing.Size(20, 21);
            this.Reload.TabIndex = 6;
            this.Reload.Text = "↻";
            this.Reload.UseVisualStyleBackColor = true;
            this.Reload.Click += new System.EventHandler(this.Reload_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.LoadPage;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 360);
            this.Controls.Add(this.Reload);
            this.Controls.Add(this.Forward);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.MainBrowser);
            this.Controls.Add(this.LoadPage);
            this.Controls.Add(this.URLtext);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "SimpleBrowser";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.MainBrowser)).EndInit();
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
    }
}

