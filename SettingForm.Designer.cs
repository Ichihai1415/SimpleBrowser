namespace SimpleBrowser
{
    partial class SettingForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.FreeText = new System.Windows.Forms.Label();
            this.SelectFont = new System.Windows.Forms.Button();
            this.FontName = new System.Windows.Forms.Label();
            this.InfoText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(270, 316);
            this.button1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 31);
            this.button1.TabIndex = 0;
            this.button1.Text = "保存";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // FreeText
            // 
            this.FreeText.AutoSize = true;
            this.FreeText.Location = new System.Drawing.Point(202, 236);
            this.FreeText.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.FreeText.Name = "FreeText";
            this.FreeText.Size = new System.Drawing.Size(323, 40);
            this.FreeText.TabIndex = 1;
            this.FreeText.Text = "設定可能箇所は今後増える予定です。\r\n設定は再起動後反映されます。";
            // 
            // SelectFont
            // 
            this.SelectFont.Location = new System.Drawing.Point(19, 32);
            this.SelectFont.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.SelectFont.Name = "SelectFont";
            this.SelectFont.Size = new System.Drawing.Size(70, 31);
            this.SelectFont.TabIndex = 2;
            this.SelectFont.Text = "選択...";
            this.SelectFont.UseVisualStyleBackColor = true;
            this.SelectFont.Click += new System.EventHandler(this.SelectFont_Click);
            // 
            // FontName
            // 
            this.FontName.AutoSize = true;
            this.FontName.Location = new System.Drawing.Point(94, 39);
            this.FontName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.FontName.Name = "FontName";
            this.FontName.Size = new System.Drawing.Size(121, 20);
            this.FontName.TabIndex = 3;
            this.FontName.Text = "MS UI Gothic";
            // 
            // InfoText
            // 
            this.InfoText.AutoSize = true;
            this.InfoText.Location = new System.Drawing.Point(11, 12);
            this.InfoText.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.InfoText.Name = "InfoText";
            this.InfoText.Size = new System.Drawing.Size(326, 20);
            this.InfoText.TabIndex = 4;
            this.InfoText.Text = "・フォント設定(β) 変わらない可能性あり";
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 360);
            this.Controls.Add(this.InfoText);
            this.Controls.Add(this.FontName);
            this.Controls.Add(this.SelectFont);
            this.Controls.Add(this.FreeText);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "SettingForm";
            this.Text = "SimpleBrowser - Setting";
            this.Load += new System.EventHandler(this.SettingForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label FreeText;
        private System.Windows.Forms.Button SelectFont;
        private System.Windows.Forms.Label FontName;
        private System.Windows.Forms.Label InfoText;
    }
}