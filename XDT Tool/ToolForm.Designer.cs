namespace XDT_Tool
{
    partial class ToolForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToolForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.diffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transformToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fastColoredTextBoxTransformed = new FastColoredTextBoxNS.FastColoredTextBox();
            this.fastColoredTextBoxXDT = new FastColoredTextBoxNS.FastColoredTextBox();
            this.fastColoredTextBoxTarget = new FastColoredTextBoxNS.FastColoredTextBox();
            this.fastColoredTextBoxSource = new FastColoredTextBoxNS.FastColoredTextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fastColoredTextBoxTransformed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fastColoredTextBoxXDT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fastColoredTextBoxTarget)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fastColoredTextBoxSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1010, 681);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.fastColoredTextBoxSource);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1002, 652);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Source XML";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.fastColoredTextBoxTarget);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1002, 652);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Target XML";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.fastColoredTextBoxXDT);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1002, 652);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "XDT";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.fastColoredTextBoxTransformed);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1002, 652);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Transformed";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.diffToolStripMenuItem,
            this.transformToolStripMenuItem,
            this.clearToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1010, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // diffToolStripMenuItem
            // 
            this.diffToolStripMenuItem.Name = "diffToolStripMenuItem";
            this.diffToolStripMenuItem.Size = new System.Drawing.Size(95, 24);
            this.diffToolStripMenuItem.Text = "Create XDT";
            this.diffToolStripMenuItem.Click += new System.EventHandler(this.diffToolStripMenuItem_Click);
            // 
            // transformToolStripMenuItem
            // 
            this.transformToolStripMenuItem.Name = "transformToolStripMenuItem";
            this.transformToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.transformToolStripMenuItem.Text = "Transform";
            this.transformToolStripMenuItem.Click += new System.EventHandler(this.transformToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // fastColoredTextBoxTransformed
            // 
            this.fastColoredTextBoxTransformed.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.fastColoredTextBoxTransformed.AutoScrollMinSize = new System.Drawing.Size(31, 18);
            this.fastColoredTextBoxTransformed.BackBrush = null;
            this.fastColoredTextBoxTransformed.CharHeight = 18;
            this.fastColoredTextBoxTransformed.CharWidth = 10;
            this.fastColoredTextBoxTransformed.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fastColoredTextBoxTransformed.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.fastColoredTextBoxTransformed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fastColoredTextBoxTransformed.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.fastColoredTextBoxTransformed.IsReplaceMode = false;
            this.fastColoredTextBoxTransformed.Language = FastColoredTextBoxNS.Language.XML;
            this.fastColoredTextBoxTransformed.Location = new System.Drawing.Point(0, 0);
            this.fastColoredTextBoxTransformed.Name = "fastColoredTextBoxTransformed";
            this.fastColoredTextBoxTransformed.Paddings = new System.Windows.Forms.Padding(0);
            this.fastColoredTextBoxTransformed.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fastColoredTextBoxTransformed.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fastColoredTextBoxTransformed.ServiceColors")));
            this.fastColoredTextBoxTransformed.Size = new System.Drawing.Size(1002, 652);
            this.fastColoredTextBoxTransformed.TabIndex = 3;
            this.fastColoredTextBoxTransformed.Zoom = 100;
            // 
            // fastColoredTextBoxXDT
            // 
            this.fastColoredTextBoxXDT.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.fastColoredTextBoxXDT.AutoScrollMinSize = new System.Drawing.Size(31, 18);
            this.fastColoredTextBoxXDT.BackBrush = null;
            this.fastColoredTextBoxXDT.CharHeight = 18;
            this.fastColoredTextBoxXDT.CharWidth = 10;
            this.fastColoredTextBoxXDT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fastColoredTextBoxXDT.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.fastColoredTextBoxXDT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fastColoredTextBoxXDT.IsReplaceMode = false;
            this.fastColoredTextBoxXDT.Language = FastColoredTextBoxNS.Language.XML;
            this.fastColoredTextBoxXDT.Location = new System.Drawing.Point(0, 0);
            this.fastColoredTextBoxXDT.Name = "fastColoredTextBoxXDT";
            this.fastColoredTextBoxXDT.Paddings = new System.Windows.Forms.Padding(0);
            this.fastColoredTextBoxXDT.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fastColoredTextBoxXDT.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fastColoredTextBoxXDT.ServiceColors")));
            this.fastColoredTextBoxXDT.Size = new System.Drawing.Size(1002, 652);
            this.fastColoredTextBoxXDT.TabIndex = 4;
            this.fastColoredTextBoxXDT.Zoom = 100;
            // 
            // fastColoredTextBoxTarget
            // 
            this.fastColoredTextBoxTarget.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.fastColoredTextBoxTarget.AutoScrollMinSize = new System.Drawing.Size(31, 18);
            this.fastColoredTextBoxTarget.BackBrush = null;
            this.fastColoredTextBoxTarget.CharHeight = 18;
            this.fastColoredTextBoxTarget.CharWidth = 10;
            this.fastColoredTextBoxTarget.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fastColoredTextBoxTarget.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.fastColoredTextBoxTarget.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fastColoredTextBoxTarget.IsReplaceMode = false;
            this.fastColoredTextBoxTarget.Language = FastColoredTextBoxNS.Language.XML;
            this.fastColoredTextBoxTarget.Location = new System.Drawing.Point(3, 3);
            this.fastColoredTextBoxTarget.Name = "fastColoredTextBoxTarget";
            this.fastColoredTextBoxTarget.Paddings = new System.Windows.Forms.Padding(0);
            this.fastColoredTextBoxTarget.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fastColoredTextBoxTarget.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fastColoredTextBoxTarget.ServiceColors")));
            this.fastColoredTextBoxTarget.Size = new System.Drawing.Size(996, 646);
            this.fastColoredTextBoxTarget.TabIndex = 5;
            this.fastColoredTextBoxTarget.Zoom = 100;
            // 
            // fastColoredTextBoxSource
            // 
            this.fastColoredTextBoxSource.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.fastColoredTextBoxSource.AutoScrollMinSize = new System.Drawing.Size(31, 18);
            this.fastColoredTextBoxSource.BackBrush = null;
            this.fastColoredTextBoxSource.CharHeight = 18;
            this.fastColoredTextBoxSource.CharWidth = 10;
            this.fastColoredTextBoxSource.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fastColoredTextBoxSource.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.fastColoredTextBoxSource.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fastColoredTextBoxSource.IsReplaceMode = false;
            this.fastColoredTextBoxSource.Language = FastColoredTextBoxNS.Language.XML;
            this.fastColoredTextBoxSource.Location = new System.Drawing.Point(3, 3);
            this.fastColoredTextBoxSource.Name = "fastColoredTextBoxSource";
            this.fastColoredTextBoxSource.Paddings = new System.Windows.Forms.Padding(0);
            this.fastColoredTextBoxSource.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fastColoredTextBoxSource.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fastColoredTextBoxSource.ServiceColors")));
            this.fastColoredTextBoxSource.Size = new System.Drawing.Size(996, 646);
            this.fastColoredTextBoxSource.TabIndex = 6;
            this.fastColoredTextBoxSource.Zoom = 100;
            // 
            // ToolForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 709);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ToolForm";
            this.Text = "XDT Tool";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fastColoredTextBoxTransformed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fastColoredTextBoxXDT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fastColoredTextBoxTarget)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fastColoredTextBoxSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem diffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ToolStripMenuItem transformToolStripMenuItem;
        private FastColoredTextBoxNS.FastColoredTextBox fastColoredTextBoxTransformed;
        private FastColoredTextBoxNS.FastColoredTextBox fastColoredTextBoxXDT;
        private FastColoredTextBoxNS.FastColoredTextBox fastColoredTextBoxTarget;
        private FastColoredTextBoxNS.FastColoredTextBox fastColoredTextBoxSource;
    }
}

