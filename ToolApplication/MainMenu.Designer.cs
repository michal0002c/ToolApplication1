﻿namespace ToolApplication
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
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.networkInfo = new System.Windows.Forms.ToolStripButton();
            this.calculator = new System.Windows.Forms.ToolStripButton();
            this.storagegroup_box = new System.Windows.Forms.GroupBox();
            this.listBoxClipboard = new System.Windows.Forms.ListBox();
            this.toolStrip1.SuspendLayout();
            this.storagegroup_box.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.networkInfo,
            this.calculator});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(444, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(156, 22);
            this.toolStripButton1.Text = "Password generator";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // networkInfo
            // 
            this.networkInfo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.networkInfo.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.networkInfo.Image = ((System.Drawing.Image)(resources.GetObject("networkInfo.Image")));
            this.networkInfo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.networkInfo.Name = "networkInfo";
            this.networkInfo.Size = new System.Drawing.Size(164, 22);
            this.networkInfo.Text = "Network information";
            this.networkInfo.Click += new System.EventHandler(this.networkInfo_Click);
            // 
            // calculator
            // 
            this.calculator.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.calculator.Image = ((System.Drawing.Image)(resources.GetObject("calculator.Image")));
            this.calculator.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.calculator.Name = "calculator";
            this.calculator.Size = new System.Drawing.Size(80, 36);
            this.calculator.Text = "Calculator";
            this.calculator.Click += new System.EventHandler(this.calculator_Click);
            // 
            // storagegroup_box
            // 
            this.storagegroup_box.Controls.Add(this.listBoxClipboard);
            this.storagegroup_box.Location = new System.Drawing.Point(13, 35);
            this.storagegroup_box.Name = "storagegroup_box";
            this.storagegroup_box.Size = new System.Drawing.Size(419, 191);
            this.storagegroup_box.TabIndex = 1;
            this.storagegroup_box.TabStop = false;
            this.storagegroup_box.Text = "Copied items: ";
            // 
            // listBoxClipboard
            // 
            this.listBoxClipboard.ItemHeight = 15;
            this.listBoxClipboard.Location = new System.Drawing.Point(6, 25);
            this.listBoxClipboard.Name = "listBoxClipboard";
            this.listBoxClipboard.Size = new System.Drawing.Size(407, 154);
            this.listBoxClipboard.TabIndex = 0;
            this.listBoxClipboard.DoubleClick += new System.EventHandler(this.listBoxClipboard_DoubleClick);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 243);
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
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.GroupBox storagegroup_box;
        private System.Windows.Forms.ListBox listBoxClipboard;
        private System.Windows.Forms.ToolStripButton networkInfo;
        private System.Windows.Forms.ToolStripButton calculator;
    }
}

