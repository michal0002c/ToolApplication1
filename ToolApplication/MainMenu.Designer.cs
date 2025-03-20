namespace ToolApplication
{
    partial class MainMenu
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.calculator = new System.Windows.Forms.ToolStripButton();
            this.passGen = new System.Windows.Forms.ToolStripButton();
            this.networkInfo = new System.Windows.Forms.ToolStripButton();
            this.listBoxClipboard = new System.Windows.Forms.ListBox();
            this.storagegroup_box = new Siticone.Desktop.UI.WinForms.SiticoneGroupBox();
            this.toolStrip1.SuspendLayout();
            this.storagegroup_box.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.toolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.toolStrip1.GripMargin = new System.Windows.Forms.Padding(12);
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculator,
            this.passGen,
            this.networkInfo});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(5);
            this.toolStrip1.Size = new System.Drawing.Size(214, 290);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // calculator
            // 
            this.calculator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(162)))), ((int)(((byte)(188)))));
            this.calculator.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.calculator.Image = ((System.Drawing.Image)(resources.GetObject("calculator.Image")));
            this.calculator.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.calculator.Name = "calculator";
            this.calculator.Padding = new System.Windows.Forms.Padding(20);
            this.calculator.Size = new System.Drawing.Size(203, 71);
            this.calculator.Text = "Calculator";
            this.calculator.Click += new System.EventHandler(this.calculator_Click);
            // 
            // passGen
            // 
            this.passGen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(162)))), ((int)(((byte)(188)))));
            this.passGen.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.passGen.Image = ((System.Drawing.Image)(resources.GetObject("passGen.Image")));
            this.passGen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.passGen.Name = "passGen";
            this.passGen.Padding = new System.Windows.Forms.Padding(20);
            this.passGen.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.passGen.Size = new System.Drawing.Size(203, 71);
            this.passGen.Text = "PassGen";
            this.passGen.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // networkInfo
            // 
            this.networkInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(162)))), ((int)(((byte)(188)))));
            this.networkInfo.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.networkInfo.Image = ((System.Drawing.Image)(resources.GetObject("networkInfo.Image")));
            this.networkInfo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.networkInfo.Name = "networkInfo";
            this.networkInfo.Padding = new System.Windows.Forms.Padding(20);
            this.networkInfo.Size = new System.Drawing.Size(203, 71);
            this.networkInfo.Text = "Network ";
            this.networkInfo.Click += new System.EventHandler(this.networkInfo_Click);
            // 
            // listBoxClipboard
            // 
            this.listBoxClipboard.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBoxClipboard.ItemHeight = 15;
            this.listBoxClipboard.Location = new System.Drawing.Point(13, 57);
            this.listBoxClipboard.Name = "listBoxClipboard";
            this.listBoxClipboard.Size = new System.Drawing.Size(518, 199);
            this.listBoxClipboard.TabIndex = 0;
            this.listBoxClipboard.DoubleClick += new System.EventHandler(this.listBoxClipboard_DoubleClick);
            // 
            // storagegroup_box
            // 
            this.storagegroup_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(162)))), ((int)(((byte)(188)))));
            this.storagegroup_box.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.storagegroup_box.Controls.Add(this.listBoxClipboard);
            this.storagegroup_box.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(162)))), ((int)(((byte)(188)))));
            this.storagegroup_box.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.storagegroup_box.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.storagegroup_box.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.storagegroup_box.Location = new System.Drawing.Point(220, 12);
            this.storagegroup_box.Name = "storagegroup_box";
            this.storagegroup_box.ShadowDecoration.BorderRadius = 1;
            this.storagegroup_box.ShadowDecoration.Color = System.Drawing.Color.DarkGray;
            this.storagegroup_box.ShadowDecoration.Depth = 100;
            this.storagegroup_box.ShadowDecoration.Enabled = true;
            this.storagegroup_box.Size = new System.Drawing.Size(539, 263);
            this.storagegroup_box.TabIndex = 2;
            this.storagegroup_box.Text = "Copied items:";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(771, 290);
            this.Controls.Add(this.storagegroup_box);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainMenu";
            this.Text = "Toolbox";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.storagegroup_box.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton passGen;
        private System.Windows.Forms.ListBox listBoxClipboard;
        private System.Windows.Forms.ToolStripButton networkInfo;
        private System.Windows.Forms.ToolStripButton calculator;
        private Siticone.Desktop.UI.WinForms.SiticoneGroupBox storagegroup_box;
    }
}

