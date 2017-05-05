namespace ReptileNetwork
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
            this.lblUrl = new System.Windows.Forms.Label();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.btnDowLoad = new System.Windows.Forms.Button();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblUrl
            // 
            this.lblUrl.AutoSize = true;
            this.lblUrl.Location = new System.Drawing.Point(12, 21);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(41, 12);
            this.lblUrl.TabIndex = 0;
            this.lblUrl.Text = "地址：";
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(59, 18);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(294, 21);
            this.txtUrl.TabIndex = 1;
            // 
            // btnDowLoad
            // 
            this.btnDowLoad.Location = new System.Drawing.Point(379, 21);
            this.btnDowLoad.Name = "btnDowLoad";
            this.btnDowLoad.Size = new System.Drawing.Size(75, 23);
            this.btnDowLoad.TabIndex = 2;
            this.btnDowLoad.Text = "下载";
            this.btnDowLoad.UseVisualStyleBackColor = true;
            this.btnDowLoad.Click += new System.EventHandler(this.btnDowLoad_Click);
            // 
            // txtContent
            // 
            this.txtContent.Location = new System.Drawing.Point(59, 69);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtContent.Size = new System.Drawing.Size(642, 370);
            this.txtContent.TabIndex = 3;
            this.txtContent.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtContent_KeyDown);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 464);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.btnDowLoad);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.lblUrl);
            this.Name = "Main";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUrl;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Button btnDowLoad;
        private System.Windows.Forms.TextBox txtContent;
    }
}

