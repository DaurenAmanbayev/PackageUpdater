namespace PackageUpdater
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.folderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filtersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButtonExtensions = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripButtonRemoveByExt = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.removeByExtensionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeByCreatedDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oPtionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearWorkAreaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelDirectoryInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.listViewDirectoryDetails = new System.Windows.Forms.ListView();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.folderToolStripMenuItem,
            this.oPtionsToolStripMenuItem,
            this.filtersToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(647, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // folderToolStripMenuItem
            // 
            this.folderToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFolderToolStripMenuItem,
            this.saveToFolderToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.folderToolStripMenuItem.Name = "folderToolStripMenuItem";
            this.folderToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.folderToolStripMenuItem.Text = "Folder";
            // 
            // openFolderToolStripMenuItem
            // 
            this.openFolderToolStripMenuItem.Name = "openFolderToolStripMenuItem";
            this.openFolderToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openFolderToolStripMenuItem.Text = "Open Folder";
            this.openFolderToolStripMenuItem.Click += new System.EventHandler(this.openFolderToolStripMenuItem_Click);
            // 
            // saveToFolderToolStripMenuItem
            // 
            this.saveToFolderToolStripMenuItem.Name = "saveToFolderToolStripMenuItem";
            this.saveToFolderToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToFolderToolStripMenuItem.Text = "Save As...";
            this.saveToFolderToolStripMenuItem.Click += new System.EventHandler(this.saveToFolderToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(149, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // filtersToolStripMenuItem
            // 
            this.filtersToolStripMenuItem.CheckOnClick = true;
            this.filtersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeByExtensionToolStripMenuItem,
            this.removeByCreatedDateToolStripMenuItem});
            this.filtersToolStripMenuItem.Name = "filtersToolStripMenuItem";
            this.filtersToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.filtersToolStripMenuItem.Text = "Filters";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.helpToolStripMenuItem1});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.helpToolStripMenuItem1.Text = "Help";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButtonExtensions,
            this.toolStripButtonRemoveByExt,
            this.toolStripSeparator1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(647, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButtonExtensions
            // 
            this.toolStripDropDownButtonExtensions.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButtonExtensions.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButtonExtensions.Image")));
            this.toolStripDropDownButtonExtensions.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButtonExtensions.Name = "toolStripDropDownButtonExtensions";
            this.toolStripDropDownButtonExtensions.Size = new System.Drawing.Size(29, 22);
            this.toolStripDropDownButtonExtensions.Text = "Available Extension";
            // 
            // toolStripButtonRemoveByExt
            // 
            this.toolStripButtonRemoveByExt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonRemoveByExt.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonRemoveByExt.Image")));
            this.toolStripButtonRemoveByExt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRemoveByExt.Name = "toolStripButtonRemoveByExt";
            this.toolStripButtonRemoveByExt.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonRemoveByExt.Text = "Remove By Extension";
            this.toolStripButtonRemoveByExt.ToolTipText = "Remove By Extension";
            this.toolStripButtonRemoveByExt.Click += new System.EventHandler(this.toolStripButtonRemoveByExt_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(71, 27);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // removeByExtensionToolStripMenuItem
            // 
            this.removeByExtensionToolStripMenuItem.Checked = true;
            this.removeByExtensionToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.removeByExtensionToolStripMenuItem.Name = "removeByExtensionToolStripMenuItem";
            this.removeByExtensionToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.removeByExtensionToolStripMenuItem.Text = "Remove By Extension";
            // 
            // removeByCreatedDateToolStripMenuItem
            // 
            this.removeByCreatedDateToolStripMenuItem.Name = "removeByCreatedDateToolStripMenuItem";
            this.removeByCreatedDateToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.removeByCreatedDateToolStripMenuItem.Text = "Remove By Created Date";
            // 
            // oPtionsToolStripMenuItem
            // 
            this.oPtionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearWorkAreaToolStripMenuItem});
            this.oPtionsToolStripMenuItem.Name = "oPtionsToolStripMenuItem";
            this.oPtionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.oPtionsToolStripMenuItem.Text = "Options";
            // 
            // clearWorkAreaToolStripMenuItem
            // 
            this.clearWorkAreaToolStripMenuItem.Name = "clearWorkAreaToolStripMenuItem";
            this.clearWorkAreaToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.clearWorkAreaToolStripMenuItem.Text = "Clear Work Area";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelDirectoryInfo});
            this.statusStrip1.Location = new System.Drawing.Point(0, 462);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(647, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelDirectoryInfo
            // 
            this.toolStripStatusLabelDirectoryInfo.Name = "toolStripStatusLabelDirectoryInfo";
            this.toolStripStatusLabelDirectoryInfo.Size = new System.Drawing.Size(34, 17);
            this.toolStripStatusLabelDirectoryInfo.Text = "Info: ";
            // 
            // listViewDirectoryDetails
            // 
            this.listViewDirectoryDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewDirectoryDetails.Location = new System.Drawing.Point(0, 49);
            this.listViewDirectoryDetails.Name = "listViewDirectoryDetails";
            this.listViewDirectoryDetails.Size = new System.Drawing.Size(647, 413);
            this.listViewDirectoryDetails.TabIndex = 4;
            this.listViewDirectoryDetails.UseCompatibleStateImageBehavior = false;
            this.listViewDirectoryDetails.View = System.Windows.Forms.View.Details;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 484);
            this.Controls.Add(this.listViewDirectoryDetails);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "PackageUpdater";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem folderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButtonExtensions;
        private System.Windows.Forms.ToolStripButton toolStripButtonRemoveByExt;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem filtersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeByExtensionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeByCreatedDateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oPtionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearWorkAreaToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelDirectoryInfo;
        private System.Windows.Forms.ListView listViewDirectoryDetails;
    }
}

