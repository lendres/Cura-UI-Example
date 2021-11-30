namespace ProfileDemo
{
	partial class Demostration
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Demostration));
			this.timerClock = new System.Windows.Forms.Timer(this.components);
			this.BottomToolStripPanel = new System.Windows.Forms.ToolStripPanel();
			this.TopToolStripPanel = new System.Windows.Forms.ToolStripPanel();
			this.RightToolStripPanel = new System.Windows.Forms.ToolStripPanel();
			this.LeftToolStripPanel = new System.Windows.Forms.ToolStripPanel();
			this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
			this.toolStripFile = new System.Windows.Forms.ToolStrip();
			this.toolStripButtonNew = new System.Windows.Forms.ToolStripButton();
			this.toolStripButtonOpen = new System.Windows.Forms.ToolStripButton();
			this.toolStripButtonSave = new System.Windows.Forms.ToolStripButton();
			this.statusBar = new System.Windows.Forms.StatusBar();
			this.statusBarPanelStatus = new System.Windows.Forms.StatusBarPanel();
			this.statusBarPanelBlank = new System.Windows.Forms.StatusBarPanel();
			this.statusBarPanelClock = new System.Windows.Forms.StatusBarPanel();
			this.menuStripMain = new System.Windows.Forms.MenuStrip();
			this.toolStripMenuItemFile = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemNew = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemOpen = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemClose = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparatorFile1 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripMenuItemSave = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemSaveAs = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuFileExport = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparatorFile2 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripMenuItemRecentFiles = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparatorFile3 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripMenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemProject = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemTools = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemOptions = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
			this.toolStripContainer1.SuspendLayout();
			this.toolStripFile.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.statusBarPanelStatus)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.statusBarPanelBlank)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.statusBarPanelClock)).BeginInit();
			this.menuStripMain.SuspendLayout();
			this.SuspendLayout();
			// 
			// timerClock
			// 
			this.timerClock.Enabled = true;
			this.timerClock.Interval = 1000;
			this.timerClock.Tick += new System.EventHandler(this.timerClock_Tick);
			// 
			// BottomToolStripPanel
			// 
			this.BottomToolStripPanel.Location = new System.Drawing.Point(0, 0);
			this.BottomToolStripPanel.Name = "BottomToolStripPanel";
			this.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
			this.BottomToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
			this.BottomToolStripPanel.Size = new System.Drawing.Size(0, 0);
			// 
			// TopToolStripPanel
			// 
			this.TopToolStripPanel.Location = new System.Drawing.Point(0, 0);
			this.TopToolStripPanel.Name = "TopToolStripPanel";
			this.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
			this.TopToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
			this.TopToolStripPanel.Size = new System.Drawing.Size(0, 0);
			// 
			// RightToolStripPanel
			// 
			this.RightToolStripPanel.Location = new System.Drawing.Point(0, 0);
			this.RightToolStripPanel.Name = "RightToolStripPanel";
			this.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
			this.RightToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
			this.RightToolStripPanel.Size = new System.Drawing.Size(0, 0);
			// 
			// LeftToolStripPanel
			// 
			this.LeftToolStripPanel.Location = new System.Drawing.Point(0, 0);
			this.LeftToolStripPanel.Name = "LeftToolStripPanel";
			this.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
			this.LeftToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
			this.LeftToolStripPanel.Size = new System.Drawing.Size(0, 0);
			// 
			// toolStripContainer1
			// 
			// 
			// toolStripContainer1.ContentPanel
			// 
			this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(742, 418);
			this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.toolStripContainer1.Location = new System.Drawing.Point(0, 24);
			this.toolStripContainer1.Name = "toolStripContainer1";
			this.toolStripContainer1.Size = new System.Drawing.Size(742, 443);
			this.toolStripContainer1.TabIndex = 35;
			this.toolStripContainer1.Text = "toolStripContainer1";
			// 
			// toolStripContainer1.TopToolStripPanel
			// 
			this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStripFile);
			// 
			// toolStripFile
			// 
			this.toolStripFile.Dock = System.Windows.Forms.DockStyle.None;
			this.toolStripFile.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonNew,
            this.toolStripButtonOpen,
            this.toolStripButtonSave});
			this.toolStripFile.Location = new System.Drawing.Point(4, 0);
			this.toolStripFile.Name = "toolStripFile";
			this.toolStripFile.Size = new System.Drawing.Size(81, 25);
			this.toolStripFile.TabIndex = 33;
			// 
			// toolStripButtonNew
			// 
			this.toolStripButtonNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonNew.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonNew.Image")));
			this.toolStripButtonNew.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonNew.Name = "toolStripButtonNew";
			this.toolStripButtonNew.Size = new System.Drawing.Size(23, 22);
			this.toolStripButtonNew.Text = "&New";
			this.toolStripButtonNew.ToolTipText = "New Project (Ctrl+N)";
			// 
			// toolStripButtonOpen
			// 
			this.toolStripButtonOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonOpen.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonOpen.Image")));
			this.toolStripButtonOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonOpen.Name = "toolStripButtonOpen";
			this.toolStripButtonOpen.Size = new System.Drawing.Size(23, 22);
			this.toolStripButtonOpen.Text = "&Open...";
			this.toolStripButtonOpen.ToolTipText = "Open Project (Ctrl+O)";
			// 
			// toolStripButtonSave
			// 
			this.toolStripButtonSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonSave.Enabled = false;
			this.toolStripButtonSave.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSave.Image")));
			this.toolStripButtonSave.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonSave.Name = "toolStripButtonSave";
			this.toolStripButtonSave.Size = new System.Drawing.Size(23, 22);
			this.toolStripButtonSave.Text = "&Save";
			// 
			// statusBar
			// 
			this.statusBar.Location = new System.Drawing.Point(0, 467);
			this.statusBar.Name = "statusBar";
			this.statusBar.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
            this.statusBarPanelStatus,
            this.statusBarPanelBlank,
            this.statusBarPanelClock});
			this.statusBar.ShowPanels = true;
			this.statusBar.Size = new System.Drawing.Size(742, 24);
			this.statusBar.TabIndex = 29;
			// 
			// statusBarPanelStatus
			// 
			this.statusBarPanelStatus.MinWidth = 80;
			this.statusBarPanelStatus.Name = "statusBarPanelStatus";
			this.statusBarPanelStatus.Text = "Ready.";
			this.statusBarPanelStatus.Width = 200;
			// 
			// statusBarPanelBlank
			// 
			this.statusBarPanelBlank.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring;
			this.statusBarPanelBlank.Name = "statusBarPanelBlank";
			this.statusBarPanelBlank.Width = 435;
			// 
			// statusBarPanelClock
			// 
			this.statusBarPanelClock.MinWidth = 80;
			this.statusBarPanelClock.Name = "statusBarPanelClock";
			this.statusBarPanelClock.Width = 90;
			// 
			// menuStripMain
			// 
			this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemFile,
            this.toolStripMenuItemProject,
            this.toolStripMenuItemTools});
			this.menuStripMain.Location = new System.Drawing.Point(0, 0);
			this.menuStripMain.Name = "menuStripMain";
			this.menuStripMain.Size = new System.Drawing.Size(742, 24);
			this.menuStripMain.TabIndex = 30;
			this.menuStripMain.Text = "menuStrip";
			// 
			// toolStripMenuItemFile
			// 
			this.toolStripMenuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemNew,
            this.toolStripMenuItemOpen,
            this.toolStripMenuItemClose,
            this.toolStripSeparatorFile1,
            this.toolStripMenuItemSave,
            this.toolStripMenuItemSaveAs,
            this.mnuFileExport,
            this.toolStripSeparatorFile2,
            this.toolStripMenuItemRecentFiles,
            this.toolStripSeparatorFile3,
            this.toolStripMenuItemExit});
			this.toolStripMenuItemFile.Name = "toolStripMenuItemFile";
			this.toolStripMenuItemFile.Size = new System.Drawing.Size(37, 20);
			this.toolStripMenuItemFile.Text = "&File";
			// 
			// toolStripMenuItemNew
			// 
			this.toolStripMenuItemNew.Name = "toolStripMenuItemNew";
			this.toolStripMenuItemNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
			this.toolStripMenuItemNew.Size = new System.Drawing.Size(180, 22);
			this.toolStripMenuItemNew.Text = "&New...";
			this.toolStripMenuItemNew.Click += new System.EventHandler(this.toolStripMenuItemFileNew_Click);
			// 
			// toolStripMenuItemOpen
			// 
			this.toolStripMenuItemOpen.Name = "toolStripMenuItemOpen";
			this.toolStripMenuItemOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
			this.toolStripMenuItemOpen.Size = new System.Drawing.Size(180, 22);
			this.toolStripMenuItemOpen.Text = "&Open...";
			this.toolStripMenuItemOpen.Click += new System.EventHandler(this.toolStripMenuItemFileOpen_Click);
			// 
			// toolStripMenuItemClose
			// 
			this.toolStripMenuItemClose.Name = "toolStripMenuItemClose";
			this.toolStripMenuItemClose.Size = new System.Drawing.Size(180, 22);
			this.toolStripMenuItemClose.Text = "&Close";
			this.toolStripMenuItemClose.Click += new System.EventHandler(this.toolStripMenuItemFileClose_Click);
			// 
			// toolStripSeparatorFile1
			// 
			this.toolStripSeparatorFile1.Name = "toolStripSeparatorFile1";
			this.toolStripSeparatorFile1.Size = new System.Drawing.Size(177, 6);
			// 
			// toolStripMenuItemSave
			// 
			this.toolStripMenuItemSave.Enabled = false;
			this.toolStripMenuItemSave.Name = "toolStripMenuItemSave";
			this.toolStripMenuItemSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
			this.toolStripMenuItemSave.Size = new System.Drawing.Size(180, 22);
			this.toolStripMenuItemSave.Text = "&Save";
			// 
			// toolStripMenuItemSaveAs
			// 
			this.toolStripMenuItemSaveAs.Name = "toolStripMenuItemSaveAs";
			this.toolStripMenuItemSaveAs.Size = new System.Drawing.Size(180, 22);
			this.toolStripMenuItemSaveAs.Text = "Save &As...";
			this.toolStripMenuItemSaveAs.Click += new System.EventHandler(this.toolStripMenuItemFileSaveAs_Click);
			// 
			// mnuFileExport
			// 
			this.mnuFileExport.Name = "mnuFileExport";
			this.mnuFileExport.Size = new System.Drawing.Size(180, 22);
			this.mnuFileExport.Text = "&Export";
			// 
			// toolStripSeparatorFile2
			// 
			this.toolStripSeparatorFile2.Name = "toolStripSeparatorFile2";
			this.toolStripSeparatorFile2.Size = new System.Drawing.Size(177, 6);
			// 
			// toolStripMenuItemRecentFiles
			// 
			this.toolStripMenuItemRecentFiles.Name = "toolStripMenuItemRecentFiles";
			this.toolStripMenuItemRecentFiles.Size = new System.Drawing.Size(180, 22);
			this.toolStripMenuItemRecentFiles.Text = "&Recent Files";
			// 
			// toolStripSeparatorFile3
			// 
			this.toolStripSeparatorFile3.Name = "toolStripSeparatorFile3";
			this.toolStripSeparatorFile3.Size = new System.Drawing.Size(177, 6);
			// 
			// toolStripMenuItemExit
			// 
			this.toolStripMenuItemExit.Name = "toolStripMenuItemExit";
			this.toolStripMenuItemExit.Size = new System.Drawing.Size(180, 22);
			this.toolStripMenuItemExit.Text = "E&xit";
			this.toolStripMenuItemExit.Click += new System.EventHandler(this.toolStripMenuItemExit_Click);
			// 
			// toolStripMenuItemProject
			// 
			this.toolStripMenuItemProject.Name = "toolStripMenuItemProject";
			this.toolStripMenuItemProject.Size = new System.Drawing.Size(56, 20);
			this.toolStripMenuItemProject.Text = "&Project";
			// 
			// toolStripMenuItemTools
			// 
			this.toolStripMenuItemTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemOptions});
			this.toolStripMenuItemTools.Name = "toolStripMenuItemTools";
			this.toolStripMenuItemTools.Size = new System.Drawing.Size(46, 20);
			this.toolStripMenuItemTools.Text = "&Tools";
			// 
			// toolStripMenuItemOptions
			// 
			this.toolStripMenuItemOptions.Name = "toolStripMenuItemOptions";
			this.toolStripMenuItemOptions.Size = new System.Drawing.Size(180, 22);
			this.toolStripMenuItemOptions.Text = "&Options";
			this.toolStripMenuItemOptions.Click += new System.EventHandler(this.toolStripMenuItemOptions_Click);
			// 
			// Demostration
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(742, 491);
			this.Controls.Add(this.toolStripContainer1);
			this.Controls.Add(this.menuStripMain);
			this.Controls.Add(this.statusBar);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Demostration";
			this.Text = "Cura Profile Demonstration Software";
			this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
			this.toolStripContainer1.TopToolStripPanel.PerformLayout();
			this.toolStripContainer1.ResumeLayout(false);
			this.toolStripContainer1.PerformLayout();
			this.toolStripFile.ResumeLayout(false);
			this.toolStripFile.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.statusBarPanelStatus)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.statusBarPanelBlank)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.statusBarPanelClock)).EndInit();
			this.menuStripMain.ResumeLayout(false);
			this.menuStripMain.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Timer timerClock;
		private System.Windows.Forms.ToolStripPanel BottomToolStripPanel;
		private System.Windows.Forms.ToolStripPanel TopToolStripPanel;
		private System.Windows.Forms.ToolStripPanel RightToolStripPanel;
		private System.Windows.Forms.ToolStripPanel LeftToolStripPanel;
		private System.Windows.Forms.ToolStripContainer toolStripContainer1;
		private System.Windows.Forms.ToolStrip toolStripFile;
		private System.Windows.Forms.ToolStripButton toolStripButtonNew;
		private System.Windows.Forms.ToolStripButton toolStripButtonOpen;
		private System.Windows.Forms.StatusBar statusBar;
		private System.Windows.Forms.StatusBarPanel statusBarPanelStatus;
		private System.Windows.Forms.StatusBarPanel statusBarPanelBlank;
		private System.Windows.Forms.StatusBarPanel statusBarPanelClock;
		private System.Windows.Forms.MenuStrip menuStripMain;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFile;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemNew;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemOpen;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemClose;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparatorFile1;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSaveAs;
		private System.Windows.Forms.ToolStripMenuItem mnuFileExport;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparatorFile2;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemRecentFiles;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparatorFile3;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemExit;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemProject;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemTools;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemOptions;
        private System.Windows.Forms.ToolStripButton toolStripButtonSave;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSave;
	}
}

