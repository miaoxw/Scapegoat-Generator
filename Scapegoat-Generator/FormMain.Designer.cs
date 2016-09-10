namespace Scapegoat_Generator
{
    partial class formMain
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
            this.components = new System.ComponentModel.Container();
            this.labelScapegoat = new System.Windows.Forms.Label();
            this.textBoxQQ = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCopyToClipboard = new System.Windows.Forms.Button();
            this.pictureBoxResult = new System.Windows.Forms.PictureBox();
            this.textBoxContent = new System.Windows.Forms.TextBox();
            this.labelContent = new System.Windows.Forms.Label();
            this.labelHint = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxResult)).BeginInit();
            this.SuspendLayout();
            // 
            // labelScapegoat
            // 
            this.labelScapegoat.AutoSize = true;
            this.labelScapegoat.Location = new System.Drawing.Point(12, 16);
            this.labelScapegoat.Name = "labelScapegoat";
            this.labelScapegoat.Size = new System.Drawing.Size(89, 12);
            this.labelScapegoat.TabIndex = 0;
            this.labelScapegoat.Text = "背锅人的QQ号：";
            this.labelScapegoat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxQQ
            // 
            this.textBoxQQ.CausesValidation = false;
            this.textBoxQQ.Location = new System.Drawing.Point(102, 12);
            this.textBoxQQ.MaxLength = 15;
            this.textBoxQQ.Name = "textBoxQQ";
            this.textBoxQQ.Size = new System.Drawing.Size(126, 21);
            this.textBoxQQ.TabIndex = 1;
            this.textBoxQQ.TextChanged += new System.EventHandler(this.textBoxQQ_TextChanged);
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGenerate.Enabled = false;
            this.buttonGenerate.Location = new System.Drawing.Point(188, 71);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(68, 23);
            this.buttonGenerate.TabIndex = 3;
            this.buttonGenerate.Text = " 走你！";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.Enabled = false;
            this.buttonSave.Location = new System.Drawing.Point(175, 273);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 5;
            this.buttonSave.Text = "保存到本地";
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // buttonCopyToClipboard
            // 
            this.buttonCopyToClipboard.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCopyToClipboard.Location = new System.Drawing.Point(68, 273);
            this.buttonCopyToClipboard.Name = "buttonCopyToClipboard";
            this.buttonCopyToClipboard.Size = new System.Drawing.Size(90, 23);
            this.buttonCopyToClipboard.TabIndex = 4;
            this.buttonCopyToClipboard.Text = "复制到剪贴板";
            this.buttonCopyToClipboard.UseVisualStyleBackColor = true;
            this.buttonCopyToClipboard.Click += new System.EventHandler(this.buttonCopyToClipboard_Click);
            // 
            // pictureBoxResult
            // 
            this.pictureBoxResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxResult.Image = global::Scapegoat_Generator.Properties.Resources.background;
            this.pictureBoxResult.InitialImage = null;
            this.pictureBoxResult.Location = new System.Drawing.Point(12, 105);
            this.pictureBoxResult.Name = "pictureBoxResult";
            this.pictureBoxResult.Size = new System.Drawing.Size(244, 155);
            this.pictureBoxResult.TabIndex = 3;
            this.pictureBoxResult.TabStop = false;
            // 
            // textBoxContent
            // 
            this.textBoxContent.CausesValidation = false;
            this.textBoxContent.Location = new System.Drawing.Point(102, 39);
            this.textBoxContent.MaxLength = 15;
            this.textBoxContent.Name = "textBoxContent";
            this.textBoxContent.Size = new System.Drawing.Size(126, 21);
            this.textBoxContent.TabIndex = 2;
            // 
            // labelContent
            // 
            this.labelContent.AutoSize = true;
            this.labelContent.Location = new System.Drawing.Point(24, 42);
            this.labelContent.Name = "labelContent";
            this.labelContent.Size = new System.Drawing.Size(77, 12);
            this.labelContent.TabIndex = 6;
            this.labelContent.Text = "背锅的内容：";
            this.labelContent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelHint
            // 
            this.labelHint.AutoSize = true;
            this.labelHint.Location = new System.Drawing.Point(12, 76);
            this.labelHint.Name = "labelHint";
            this.labelHint.Size = new System.Drawing.Size(0, 12);
            this.labelHint.TabIndex = 0;
            this.labelHint.Visible = false;
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 309);
            this.Controls.Add(this.labelHint);
            this.Controls.Add(this.textBoxContent);
            this.Controls.Add(this.labelContent);
            this.Controls.Add(this.buttonCopyToClipboard);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.pictureBoxResult);
            this.Controls.Add(this.buttonGenerate);
            this.Controls.Add(this.textBoxQQ);
            this.Controls.Add(this.labelScapegoat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "formMain";
            this.Text = "背锅生成器";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelScapegoat;
        private System.Windows.Forms.TextBox textBoxQQ;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.PictureBox pictureBoxResult;
        private System.Windows.Forms.Button buttonCopyToClipboard;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textBoxContent;
        private System.Windows.Forms.Label labelContent;
        private System.Windows.Forms.Label labelHint;
    }
}

