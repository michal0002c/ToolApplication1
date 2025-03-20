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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPasswordLen = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.passBar = new Siticone.Desktop.UI.WinForms.SiticoneProgressBar();
            this.passGenButton = new Siticone.Desktop.UI.WinForms.SiticoneTileButton();
            this.copyButton = new Siticone.Desktop.UI.WinForms.SiticoneGradientTileButton();
            this.showButton = new Siticone.Desktop.UI.WinForms.SiticoneGradientTileButton();
            this.siticoneGroupBox1 = new Siticone.Desktop.UI.WinForms.SiticoneGroupBox();
            this.siticoneGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.passwordLabel.Location = new System.Drawing.Point(7, 51);
            this.passwordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(0, 20);
            this.passwordLabel.TabIndex = 13;
            this.passwordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(9, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(339, 43);
            this.label1.TabIndex = 8;
            this.label1.Text = "Password length:";
            // 
            // textBoxPasswordLen
            // 
            this.textBoxPasswordLen.Animated = true;
            this.textBoxPasswordLen.BorderRadius = 30;
            this.textBoxPasswordLen.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.textBoxPasswordLen.BorderThickness = 2;
            this.textBoxPasswordLen.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxPasswordLen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxPasswordLen.DefaultText = "";
            this.textBoxPasswordLen.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxPasswordLen.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxPasswordLen.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxPasswordLen.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxPasswordLen.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxPasswordLen.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxPasswordLen.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxPasswordLen.Location = new System.Drawing.Point(342, 10);
            this.textBoxPasswordLen.Name = "textBoxPasswordLen";
            this.textBoxPasswordLen.PasswordChar = '\0';
            this.textBoxPasswordLen.PlaceholderText = "Type the number of characters";
            this.textBoxPasswordLen.SelectedText = "";
            this.textBoxPasswordLen.Size = new System.Drawing.Size(301, 60);
            this.textBoxPasswordLen.TabIndex = 15;
            // 
            // passBar
            // 
            this.passBar.BorderRadius = 30;
            this.passBar.Location = new System.Drawing.Point(17, 87);
            this.passBar.Name = "passBar";
            this.passBar.ProgressColor = System.Drawing.Color.Firebrick;
            this.passBar.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.passBar.Size = new System.Drawing.Size(291, 93);
            this.passBar.TabIndex = 16;
            this.passBar.Text = "siticoneProgressBar1";
            this.passBar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // passGenButton
            // 
            this.passGenButton.BorderRadius = 15;
            this.passGenButton.BorderThickness = 1;
            this.passGenButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.passGenButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.passGenButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.passGenButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.passGenButton.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.passGenButton.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.passGenButton.ForeColor = System.Drawing.Color.White;
            this.passGenButton.Location = new System.Drawing.Point(314, 87);
            this.passGenButton.Name = "passGenButton";
            this.passGenButton.Size = new System.Drawing.Size(325, 93);
            this.passGenButton.TabIndex = 17;
            this.passGenButton.Text = "Generate";
            this.passGenButton.Click += new System.EventHandler(this.passGenButton_Click);
            // 
            // copyButton
            // 
            this.copyButton.BorderColor = System.Drawing.Color.DimGray;
            this.copyButton.BorderRadius = 5;
            this.copyButton.BorderThickness = 2;
            this.copyButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.copyButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.copyButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.copyButton.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.copyButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.copyButton.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.copyButton.FillColor2 = System.Drawing.SystemColors.ButtonShadow;
            this.copyButton.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.copyButton.ForeColor = System.Drawing.Color.White;
            this.copyButton.Location = new System.Drawing.Point(12, 294);
            this.copyButton.Name = "copyButton";
            this.copyButton.Size = new System.Drawing.Size(288, 52);
            this.copyButton.TabIndex = 18;
            this.copyButton.Text = "Copy";
            this.copyButton.Click += new System.EventHandler(this.copyButton_Click);
            // 
            // showButton
            // 
            this.showButton.BorderColor = System.Drawing.Color.DimGray;
            this.showButton.BorderRadius = 5;
            this.showButton.BorderThickness = 2;
            this.showButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.showButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.showButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.showButton.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.showButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.showButton.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.showButton.FillColor2 = System.Drawing.Color.DarkRed;
            this.showButton.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.showButton.ForeColor = System.Drawing.Color.White;
            this.showButton.Location = new System.Drawing.Point(351, 294);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(288, 52);
            this.showButton.TabIndex = 19;
            this.showButton.Text = "Show password";
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // siticoneGroupBox1
            // 
            this.siticoneGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneGroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.siticoneGroupBox1.Controls.Add(this.passwordLabel);
            this.siticoneGroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneGroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.siticoneGroupBox1.Location = new System.Drawing.Point(12, 191);
            this.siticoneGroupBox1.Name = "siticoneGroupBox1";
            this.siticoneGroupBox1.Size = new System.Drawing.Size(627, 90);
            this.siticoneGroupBox1.TabIndex = 20;
            this.siticoneGroupBox1.Text = "Generated password";
            this.siticoneGroupBox1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            // 
            // PasswordGen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(651, 358);
            this.Controls.Add(this.siticoneGroupBox1);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.copyButton);
            this.Controls.Add(this.passGenButton);
            this.Controls.Add(this.passBar);
            this.Controls.Add(this.textBoxPasswordLen);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PasswordGen";
            this.Text = "Password generator";
            this.siticoneGroupBox1.ResumeLayout(false);
            this.siticoneGroupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label label1;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox textBoxPasswordLen;
        private Siticone.Desktop.UI.WinForms.SiticoneProgressBar passBar;
        private Siticone.Desktop.UI.WinForms.SiticoneTileButton passGenButton;
        private Siticone.Desktop.UI.WinForms.SiticoneGradientTileButton copyButton;
        private Siticone.Desktop.UI.WinForms.SiticoneGradientTileButton showButton;
        private Siticone.Desktop.UI.WinForms.SiticoneGroupBox siticoneGroupBox1;
    }
}