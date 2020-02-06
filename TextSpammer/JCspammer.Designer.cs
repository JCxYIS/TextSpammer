namespace TextSpammer
{
    partial class JCspammer
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JCspammer));
            this.StartButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.CdInputField = new System.Windows.Forms.TextBox();
            this.mainTextBox = new System.Windows.Forms.RichTextBox();
            this.cdLab = new System.Windows.Forms.Label();
            this.logoLabel = new System.Windows.Forms.Label();
            this.spamTimesInput = new System.Windows.Forms.TextBox();
            this.timesLab = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.spamCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.StartButton.Location = new System.Drawing.Point(50, 343);
            this.StartButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(159, 58);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "Start!";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.StopButton.Location = new System.Drawing.Point(264, 343);
            this.StopButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(159, 58);
            this.StopButton.TabIndex = 1;
            this.StopButton.Text = "Stop!";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // CdInputField
            // 
            this.CdInputField.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.CdInputField.Location = new System.Drawing.Point(109, 202);
            this.CdInputField.MaxLength = 7;
            this.CdInputField.Name = "CdInputField";
            this.CdInputField.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CdInputField.Size = new System.Drawing.Size(100, 27);
            this.CdInputField.TabIndex = 4;
            this.CdInputField.Text = "3";
            // 
            // mainTextBox
            // 
            this.mainTextBox.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.mainTextBox.Location = new System.Drawing.Point(50, 93);
            this.mainTextBox.MaxLength = 2000;
            this.mainTextBox.Name = "mainTextBox";
            this.mainTextBox.Size = new System.Drawing.Size(373, 103);
            this.mainTextBox.TabIndex = 6;
            this.mainTextBox.Text = "wow JC is not a lolicon{ENTER}";
            // 
            // cdLab
            // 
            this.cdLab.AutoSize = true;
            this.cdLab.BackColor = System.Drawing.Color.Transparent;
            this.cdLab.Location = new System.Drawing.Point(230, 205);
            this.cdLab.Name = "cdLab";
            this.cdLab.Size = new System.Drawing.Size(124, 19);
            this.cdLab.TabIndex = 7;
            this.cdLab.Text = "Seconds Interval";
            // 
            // logoLabel
            // 
            this.logoLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.logoLabel.AutoSize = true;
            this.logoLabel.BackColor = System.Drawing.Color.Transparent;
            this.logoLabel.Cursor = System.Windows.Forms.Cursors.Help;
            this.logoLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.logoLabel.Font = new System.Drawing.Font("Comic Sans MS", 19.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoLabel.ForeColor = System.Drawing.Color.DarkCyan;
            this.logoLabel.Location = new System.Drawing.Point(60, 28);
            this.logoLabel.Name = "logoLabel";
            this.logoLabel.Size = new System.Drawing.Size(346, 46);
            this.logoLabel.TabIndex = 8;
            this.logoLabel.Text = "J.C.\'s Text Spammer";
            this.logoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // spamTimesInput
            // 
            this.spamTimesInput.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.spamTimesInput.Location = new System.Drawing.Point(109, 235);
            this.spamTimesInput.MaxLength = 7;
            this.spamTimesInput.Name = "spamTimesInput";
            this.spamTimesInput.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.spamTimesInput.Size = new System.Drawing.Size(100, 27);
            this.spamTimesInput.TabIndex = 9;
            this.spamTimesInput.Text = "10";
            // 
            // timesLab
            // 
            this.timesLab.AutoSize = true;
            this.timesLab.BackColor = System.Drawing.Color.Transparent;
            this.timesLab.Location = new System.Drawing.Point(230, 238);
            this.timesLab.Name = "timesLab";
            this.timesLab.Size = new System.Drawing.Size(94, 19);
            this.timesLab.TabIndex = 10;
            this.timesLab.Text = "Spam Times";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(114, 286);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 19);
            this.label1.TabIndex = 11;
            this.label1.Text = "Spam Count";
            // 
            // spamCount
            // 
            this.spamCount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.spamCount.AutoSize = true;
            this.spamCount.BackColor = System.Drawing.Color.Transparent;
            this.spamCount.Font = new System.Drawing.Font("微軟正黑體", 30F);
            this.spamCount.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.spamCount.Location = new System.Drawing.Point(223, 266);
            this.spamCount.Name = "spamCount";
            this.spamCount.Size = new System.Drawing.Size(56, 63);
            this.spamCount.TabIndex = 12;
            this.spamCount.Text = "0";
            this.spamCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // JCspammer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(457, 428);
            this.Controls.Add(this.spamCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.timesLab);
            this.Controls.Add(this.spamTimesInput);
            this.Controls.Add(this.logoLabel);
            this.Controls.Add(this.cdLab);
            this.Controls.Add(this.mainTextBox);
            this.Controls.Add(this.CdInputField);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.StartButton);
            this.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "JCspammer";
            this.Text = "J.C.\'s Text Spammer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.TextBox CdInputField;
        private System.Windows.Forms.RichTextBox mainTextBox;
        private System.Windows.Forms.Label cdLab;
        private System.Windows.Forms.Label logoLabel;
        private System.Windows.Forms.TextBox spamTimesInput;
        private System.Windows.Forms.Label timesLab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label spamCount;
    }
}

