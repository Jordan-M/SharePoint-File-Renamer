namespace SharepointFileRenamer
{
    partial class UserInterface
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
            this.uxOpenSourceButton = new System.Windows.Forms.Button();
            this.uxSourceTextbox = new System.Windows.Forms.TextBox();
            this.uxDestTextbox = new System.Windows.Forms.TextBox();
            this.uxOpenDestButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.uxCopyFolder = new System.Windows.Forms.Button();
            this.uxLog = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // uxOpenSourceButton
            // 
            this.uxOpenSourceButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uxOpenSourceButton.Location = new System.Drawing.Point(430, 10);
            this.uxOpenSourceButton.Name = "uxOpenSourceButton";
            this.uxOpenSourceButton.Size = new System.Drawing.Size(34, 23);
            this.uxOpenSourceButton.TabIndex = 0;
            this.uxOpenSourceButton.Text = "...";
            this.uxOpenSourceButton.UseVisualStyleBackColor = true;
            this.uxOpenSourceButton.Click += new System.EventHandler(this.uxOpenFileButton_Click);
            // 
            // uxSourceTextbox
            // 
            this.uxSourceTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uxSourceTextbox.Location = new System.Drawing.Point(75, 12);
            this.uxSourceTextbox.Name = "uxSourceTextbox";
            this.uxSourceTextbox.ReadOnly = true;
            this.uxSourceTextbox.Size = new System.Drawing.Size(349, 20);
            this.uxSourceTextbox.TabIndex = 1;
            // 
            // uxDestTextbox
            // 
            this.uxDestTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uxDestTextbox.Location = new System.Drawing.Point(75, 39);
            this.uxDestTextbox.Name = "uxDestTextbox";
            this.uxDestTextbox.ReadOnly = true;
            this.uxDestTextbox.Size = new System.Drawing.Size(349, 20);
            this.uxDestTextbox.TabIndex = 4;
            // 
            // uxOpenDestButton
            // 
            this.uxOpenDestButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uxOpenDestButton.Location = new System.Drawing.Point(430, 37);
            this.uxOpenDestButton.Name = "uxOpenDestButton";
            this.uxOpenDestButton.Size = new System.Drawing.Size(34, 23);
            this.uxOpenDestButton.TabIndex = 3;
            this.uxOpenDestButton.Text = "...";
            this.uxOpenDestButton.UseVisualStyleBackColor = true;
            this.uxOpenDestButton.Click += new System.EventHandler(this.uxOpenDestButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Source:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Destination";
            // 
            // uxCopyFolder
            // 
            this.uxCopyFolder.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.uxCopyFolder.Location = new System.Drawing.Point(146, 231);
            this.uxCopyFolder.Name = "uxCopyFolder";
            this.uxCopyFolder.Size = new System.Drawing.Size(167, 23);
            this.uxCopyFolder.TabIndex = 7;
            this.uxCopyFolder.Text = "Copy Folder";
            this.uxCopyFolder.UseVisualStyleBackColor = true;
            this.uxCopyFolder.Click += new System.EventHandler(this.uxCopyFolder_Click);
            // 
            // uxLog
            // 
            this.uxLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uxLog.Location = new System.Drawing.Point(12, 66);
            this.uxLog.Name = "uxLog";
            this.uxLog.Size = new System.Drawing.Size(452, 158);
            this.uxLog.TabIndex = 8;
            this.uxLog.Text = "";
            // 
            // UserInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 261);
            this.Controls.Add(this.uxLog);
            this.Controls.Add(this.uxCopyFolder);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uxDestTextbox);
            this.Controls.Add(this.uxOpenDestButton);
            this.Controls.Add(this.uxSourceTextbox);
            this.Controls.Add(this.uxOpenSourceButton);
            this.Name = "UserInterface";
            this.Text = "Sharepoint File Renamer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uxOpenSourceButton;
        private System.Windows.Forms.TextBox uxSourceTextbox;
        private System.Windows.Forms.TextBox uxDestTextbox;
        private System.Windows.Forms.Button uxOpenDestButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button uxCopyFolder;
        private System.Windows.Forms.RichTextBox uxLog;
    }
}

