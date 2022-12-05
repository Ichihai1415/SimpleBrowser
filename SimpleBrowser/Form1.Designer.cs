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
            this.View = new System.Windows.Forms.Button();
            this.WebView = new Microsoft.Web.WebView2.WinForms.WebView2();
            ((System.ComponentModel.ISupportInitialize)(this.WebView)).BeginInit();
            this.SuspendLayout();
            // 
            // URLtext
            // 
            this.URLtext.Location = new System.Drawing.Point(12, 12);
            this.URLtext.Name = "URLtext";
            this.URLtext.Size = new System.Drawing.Size(510, 19);
            this.URLtext.TabIndex = 1;
            // 
            // View
            // 
            this.View.Location = new System.Drawing.Point(553, 10);
            this.View.Name = "View";
            this.View.Size = new System.Drawing.Size(75, 23);
            this.View.TabIndex = 2;
            this.View.Text = "読み込み";
            this.View.UseVisualStyleBackColor = true;
            this.View.Click += new System.EventHandler(this.View_Click);
            // 
            // WebView
            // 
            this.WebView.AllowExternalDrop = true;
            this.WebView.CreationProperties = null;
            this.WebView.DefaultBackgroundColor = System.Drawing.Color.White;
            this.WebView.Location = new System.Drawing.Point(0, 50);
            this.WebView.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.WebView.Name = "WebView";
            this.WebView.Size = new System.Drawing.Size(641, 310);
            this.WebView.Source = new System.Uri("https://Ichihai1415.github.io/programs/SimpleBrowser", System.UriKind.Absolute);
            this.WebView.TabIndex = 3;
            this.WebView.ZoomFactor = 1D;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 360);
            this.Controls.Add(this.WebView);
            this.Controls.Add(this.View);
            this.Controls.Add(this.URLtext);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.WebView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox URLtext;
        private System.Windows.Forms.Button View;
        private Microsoft.Web.WebView2.WinForms.WebView2 WebView;
    }
}

