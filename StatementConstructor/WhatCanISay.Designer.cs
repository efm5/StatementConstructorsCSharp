namespace StatementConstructors {
   partial class WhatCanISay {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing) {
         if (disposing && (components != null)) {
            components.Dispose();
        }
         base.Dispose(disposing);
     }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent() {
         this.components = new System.ComponentModel.Container();
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WhatCanISay));
         this.primaryPanel = new System.Windows.Forms.Panel();
         this.directionsTextBox = new System.Windows.Forms.TextBox();
         this.directionsContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
         this.readTheseDirectionsInATextFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.copyAllOfThePossibleUtterancesToTheClipboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.fontSelectorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.fontDialog = new System.Windows.Forms.FontDialog();
         this.toolTips = new System.Windows.Forms.ToolTip(this.components);
         this.primaryPanel.SuspendLayout();
         this.directionsContextMenuStrip.SuspendLayout();
         this.SuspendLayout();
         // 
         // primaryPanel
         // 
         this.primaryPanel.AutoScroll = true;
         this.primaryPanel.Controls.Add(this.directionsTextBox);
         this.primaryPanel.Dock = System.Windows.Forms.DockStyle.Fill;
         this.primaryPanel.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.primaryPanel.Location = new System.Drawing.Point(0, 0);
         this.primaryPanel.Name = "primaryPanel";
         this.primaryPanel.Size = new System.Drawing.Size(1784, 956);
         this.primaryPanel.TabIndex = 1;
         this.primaryPanel.Resize += new System.EventHandler(this.PrimaryPanel_Resize);
         // 
         // directionsTextBox
         // 
         this.directionsTextBox.ContextMenuStrip = this.directionsContextMenuStrip;
         this.directionsTextBox.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.directionsTextBox.Location = new System.Drawing.Point(1, 1);
         this.directionsTextBox.Multiline = true;
         this.directionsTextBox.Name = "directionsTextBox";
         this.directionsTextBox.ReadOnly = true;
         this.directionsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
         this.directionsTextBox.Size = new System.Drawing.Size(790, 120);
         this.directionsTextBox.TabIndex = 0;
         this.directionsTextBox.Text = "imports \"WhatYouCanSay.txt\"";
         this.toolTips.SetToolTip(this.directionsTextBox, "Use the context menu to change the font and other actions.");
         // 
         // directionsContextMenuStrip
         // 
         this.directionsContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.readTheseDirectionsInATextFileToolStripMenuItem,
            this.copyAllOfThePossibleUtterancesToTheClipboardToolStripMenuItem,
            this.fontSelectorToolStripMenuItem});
         this.directionsContextMenuStrip.Name = "directionsContextMenuStrip";
         this.directionsContextMenuStrip.Size = new System.Drawing.Size(595, 94);
         // 
         // readTheseDirectionsInATextFileToolStripMenuItem
         // 
         this.readTheseDirectionsInATextFileToolStripMenuItem.Name = "readTheseDirectionsInATextFileToolStripMenuItem";
         this.readTheseDirectionsInATextFileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
         this.readTheseDirectionsInATextFileToolStripMenuItem.Size = new System.Drawing.Size(594, 30);
         this.readTheseDirectionsInATextFileToolStripMenuItem.Text = "&Read these directions in your favorite text editor…";
         this.readTheseDirectionsInATextFileToolStripMenuItem.Click += new System.EventHandler(this.ReadTheseDirectionsInATextFileToolStripMenuItem_Click);
         // 
         // copyAllOfThePossibleUtterancesToTheClipboardToolStripMenuItem
         // 
         this.copyAllOfThePossibleUtterancesToTheClipboardToolStripMenuItem.Name = "copyAllOfThePossibleUtterancesToTheClipboardToolStripMenuItem";
         this.copyAllOfThePossibleUtterancesToTheClipboardToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
         this.copyAllOfThePossibleUtterancesToTheClipboardToolStripMenuItem.Size = new System.Drawing.Size(594, 30);
         this.copyAllOfThePossibleUtterancesToTheClipboardToolStripMenuItem.Text = "&Copy all of the dictionary utterances to the clipboard";
         this.copyAllOfThePossibleUtterancesToTheClipboardToolStripMenuItem.Click += new System.EventHandler(this.CopyAllOfThePossibleUtterancesToTheClipboardToolStripMenuItem_Click);
         // 
         // fontSelectorToolStripMenuItem
         // 
         this.fontSelectorToolStripMenuItem.Name = "fontSelectorToolStripMenuItem";
         this.fontSelectorToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
         this.fontSelectorToolStripMenuItem.Size = new System.Drawing.Size(594, 30);
         this.fontSelectorToolStripMenuItem.Text = "&Font selector…";
         this.fontSelectorToolStripMenuItem.Click += new System.EventHandler(this.FontSelectorToolStripMenuItem_Click);
         // 
         // WhatCanISay
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(1784, 956);
         this.ContextMenuStrip = this.directionsContextMenuStrip;
         this.Controls.Add(this.primaryPanel);
         this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
         this.Location = new System.Drawing.Point(1, 1);
         this.Name = "WhatCanISay";
         this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
         this.Text = "What Can I Say?";
         this.TopMost = true;
         this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WhatCanISay_FormClosing);
         this.Shown += new System.EventHandler(this.WhatCanISay_Shown);
         this.primaryPanel.ResumeLayout(false);
         this.primaryPanel.PerformLayout();
         this.directionsContextMenuStrip.ResumeLayout(false);
         this.ResumeLayout(false);

     }

      #endregion
      private System.Windows.Forms.Panel primaryPanel;
      private System.Windows.Forms.TextBox directionsTextBox;
      private System.Windows.Forms.ToolTip toolTips;
      private System.Windows.Forms.ContextMenuStrip directionsContextMenuStrip;
      private System.Windows.Forms.ToolStripMenuItem readTheseDirectionsInATextFileToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem copyAllOfThePossibleUtterancesToTheClipboardToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem fontSelectorToolStripMenuItem;
      private System.Windows.Forms.FontDialog fontDialog;
  }
}