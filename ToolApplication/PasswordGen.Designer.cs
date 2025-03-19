namespace ToolApplication
{
    partial class PasswordGen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PasswordGen));
            this.passwordLabel = new System.Windows.Forms.Label();
            this.showButton = new System.Windows.Forms.Button();
            this.copyButton = new System.Windows.Forms.Button();
            this.passGenButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPasswordLen = new System.Windows.Forms.TextBox();
            this.passBar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.passwordLabel.Location = new System.Drawing.Point(13, 209);
            this.passwordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(0, 20);
            this.passwordLabel.TabIndex = 13;
            this.passwordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // showButton
            // 
            this.showButton.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.showButton.Location = new System.Drawing.Point(480, 272);
            this.showButton.Margin = new System.Windows.Forms.Padding(4);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(163, 60);
            this.showButton.TabIndex = 12;
            this.showButton.Text = "Show";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // copyButton
            // 
            this.copyButton.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.copyButton.Location = new System.Drawing.Point(8, 272);
            this.copyButton.Margin = new System.Windows.Forms.Padding(4);
            this.copyButton.Name = "copyButton";
            this.copyButton.Size = new System.Drawing.Size(464, 60);
            this.copyButton.TabIndex = 11;
            this.copyButton.Text = "Copy";
            this.copyButton.UseVisualStyleBackColor = true;
            this.copyButton.Click += new System.EventHandler(this.copyButton_Click);
            // 
            // passGenButton
            // 
            this.passGenButton.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.passGenButton.Location = new System.Drawing.Point(331, 97);
            this.passGenButton.Margin = new System.Windows.Forms.Padding(4);
            this.passGenButton.Name = "passGenButton";
            this.passGenButton.Size = new System.Drawing.Size(312, 96);
            this.passGenButton.TabIndex = 9;
            this.passGenButton.Text = "Generate password";
            this.passGenButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.passGenButton.UseVisualStyleBackColor = true;
            this.passGenButton.Click += new System.EventHandler(this.passGenButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(9, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(339, 43);
            this.label1.TabIndex = 8;
            this.label1.Text = "Password length:";
            // 
            // textBoxPasswordLen
            // 
            this.textBoxPasswordLen.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxPasswordLen.Location = new System.Drawing.Point(396, 39);
            this.textBoxPasswordLen.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPasswordLen.Name = "textBoxPasswordLen";
            this.textBoxPasswordLen.Size = new System.Drawing.Size(245, 50);
            this.textBoxPasswordLen.TabIndex = 7;
            // 
            // passBar
            // 
            this.passBar.Location = new System.Drawing.Point(17, 97);
            this.passBar.Name = "passBar";
            this.passBar.Size = new System.Drawing.Size(297, 96);
            this.passBar.TabIndex = 14;
            // 
            // PasswordGen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 334);
            this.Controls.Add(this.passBar);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.copyButton);
            this.Controls.Add(this.passGenButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPasswordLen);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PasswordGen";
            this.Text = "Password generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.Button copyButton;
        private System.Windows.Forms.Button passGenButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPasswordLen;
        private System.Windows.Forms.ProgressBar passBar;
    }
}