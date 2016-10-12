namespace BIconReaper
{
    partial class Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.btnReaper = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.loglistBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnReaper
            // 
            this.btnReaper.Location = new System.Drawing.Point(272, 12);
            this.btnReaper.Name = "btnReaper";
            this.btnReaper.Size = new System.Drawing.Size(75, 23);
            this.btnReaper.TabIndex = 0;
            this.btnReaper.Text = "获取";
            this.btnReaper.UseVisualStyleBackColor = true;
            this.btnReaper.Click += new System.EventHandler(this.btnReaper_Click);
            // 
            // progressBar1
            // 
            this.progressBar.Location = new System.Drawing.Point(12, 12);
            this.progressBar.Name = "progressBar1";
            this.progressBar.Size = new System.Drawing.Size(253, 23);
            this.progressBar.TabIndex = 1;
            // 
            // listBox1
            // 
            this.loglistBox.FormattingEnabled = true;
            this.loglistBox.ItemHeight = 12;
            this.loglistBox.Location = new System.Drawing.Point(12, 43);
            this.loglistBox.Name = "listBox1";
            this.loglistBox.Size = new System.Drawing.Size(335, 256);
            this.loglistBox.TabIndex = 2;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 311);
            this.Controls.Add(this.loglistBox);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.btnReaper);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "B站动图获取工具 by Karlock";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReaper;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.ListBox loglistBox;
    }
}

