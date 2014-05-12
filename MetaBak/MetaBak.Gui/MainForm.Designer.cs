namespace MetaBak
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this._list = new System.Windows.Forms.ListView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.ftpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sFTPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.webDavToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.dropBozToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.skyDriveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.googleDriveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ownCloudToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bAculaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rsyncdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.listView1 = new System.Windows.Forms.ListView();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this._list);
            this.splitContainer1.Panel1.Controls.Add(this.toolStrip1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.listView1);
            this.splitContainer1.Panel2.Controls.Add(this.toolStrip2);
            this.splitContainer1.Panel2.Controls.Add(this.statusStrip1);
            this.splitContainer1.Size = new System.Drawing.Size(1397, 666);
            this.splitContainer1.SplitterDistance = 465;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // _list
            // 
            this._list.Dock = System.Windows.Forms.DockStyle.Fill;
            this._list.Location = new System.Drawing.Point(0, 25);
            this._list.Margin = new System.Windows.Forms.Padding(4);
            this._list.Name = "_list";
            this._list.Size = new System.Drawing.Size(465, 641);
            this._list.TabIndex = 0;
            this._list.UseCompatibleStateImageBehavior = false;
            this._list.View = System.Windows.Forms.View.Tile;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(465, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ftpToolStripMenuItem,
            this.sFTPToolStripMenuItem,
            this.webDavToolStripMenuItem,
            this.toolStripSeparator1,
            this.dropBozToolStripMenuItem,
            this.skyDriveToolStripMenuItem,
            this.googleDriveToolStripMenuItem,
            this.ownCloudToolStripMenuItem,
            this.toolStripSeparator2,
            this.bAculaToolStripMenuItem,
            this.rsyncdToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(29, 22);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // ftpToolStripMenuItem
            // 
            this.ftpToolStripMenuItem.Name = "ftpToolStripMenuItem";
            this.ftpToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
            this.ftpToolStripMenuItem.Text = "FTP";
            this.ftpToolStripMenuItem.Click += new System.EventHandler(this.ftpToolStripMenuItem_Click);
            // 
            // sFTPToolStripMenuItem
            // 
            this.sFTPToolStripMenuItem.Name = "sFTPToolStripMenuItem";
            this.sFTPToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
            this.sFTPToolStripMenuItem.Text = "SFTP";
            // 
            // webDavToolStripMenuItem
            // 
            this.webDavToolStripMenuItem.Enabled = false;
            this.webDavToolStripMenuItem.Name = "webDavToolStripMenuItem";
            this.webDavToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
            this.webDavToolStripMenuItem.Text = "WebDav";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(172, 6);
            // 
            // dropBozToolStripMenuItem
            // 
            this.dropBozToolStripMenuItem.Name = "dropBozToolStripMenuItem";
            this.dropBozToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
            this.dropBozToolStripMenuItem.Text = "DropBox";
            this.dropBozToolStripMenuItem.Click += new System.EventHandler(this.dropBozToolStripMenuItem_Click);
            // 
            // skyDriveToolStripMenuItem
            // 
            this.skyDriveToolStripMenuItem.Enabled = false;
            this.skyDriveToolStripMenuItem.Name = "skyDriveToolStripMenuItem";
            this.skyDriveToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
            this.skyDriveToolStripMenuItem.Text = "SkyDrive";
            // 
            // googleDriveToolStripMenuItem
            // 
            this.googleDriveToolStripMenuItem.Enabled = false;
            this.googleDriveToolStripMenuItem.Name = "googleDriveToolStripMenuItem";
            this.googleDriveToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
            this.googleDriveToolStripMenuItem.Text = "Google Drive";
            // 
            // ownCloudToolStripMenuItem
            // 
            this.ownCloudToolStripMenuItem.Enabled = false;
            this.ownCloudToolStripMenuItem.Name = "ownCloudToolStripMenuItem";
            this.ownCloudToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
            this.ownCloudToolStripMenuItem.Text = "OwnCloud";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(172, 6);
            // 
            // bAculaToolStripMenuItem
            // 
            this.bAculaToolStripMenuItem.Name = "bAculaToolStripMenuItem";
            this.bAculaToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
            this.bAculaToolStripMenuItem.Text = "Bacula";
            // 
            // rsyncdToolStripMenuItem
            // 
            this.rsyncdToolStripMenuItem.Name = "rsyncdToolStripMenuItem";
            this.rsyncdToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
            this.rsyncdToolStripMenuItem.Text = "rsyncd";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 640);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(927, 26);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(133, 20);
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(927, 25);
            this.toolStrip2.TabIndex = 1;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // listView1
            // 
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Location = new System.Drawing.Point(0, 25);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(927, 615);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "_addSyncPath";
            this.toolStripButton1.ToolTipText = "Add Sync Path";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1397, 666);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "MetaBak";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListView _list;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem ftpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sFTPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem webDavToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem dropBozToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ownCloudToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem bAculaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rsyncdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem skyDriveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem googleDriveToolStripMenuItem;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}

