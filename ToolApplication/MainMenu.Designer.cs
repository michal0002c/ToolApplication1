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
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.storagegroup_box = new System.Windows.Forms.GroupBox();
            this.listBoxClipboard = new System.Windows.Forms.ListBox();
            this.toolStrip1.SuspendLayout();
            this.storagegroup_box.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(564, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(143, 24);
            this.toolStripButton1.Text = "Password generator";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // storagegroup_box
            // 
            this.storagegroup_box.Controls.Add(this.listBoxClipboard);
            this.storagegroup_box.Location = new System.Drawing.Point(12, 30);
            this.storagegroup_box.Name = "storagegroup_box";
            this.storagegroup_box.Size = new System.Drawing.Size(539, 255);
            this.storagegroup_box.TabIndex = 1;
            this.storagegroup_box.TabStop = false;
            this.storagegroup_box.Text = "Copied items: ";
            // 
            // listBoxClipboard
            // 
            this.listBoxClipboard.ItemHeight = 16;
            this.listBoxClipboard.Location = new System.Drawing.Point(6, 21);
            this.listBoxClipboard.Name = "listBoxClipboard";
            this.listBoxClipboard.Size = new System.Drawing.Size(527, 212);
            this.listBoxClipboard.TabIndex = 0;
            this.listBoxClipboard.DoubleClick += new System.EventHandler(this.listBoxClipboard_DoubleClick);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 303);
            this.Controls.Add(this.storagegroup_box);
            this.Controls.Add(this.toolStrip1);
            this.Name = "MainMenu";
            this.Text = "Form1";
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
    }
}

