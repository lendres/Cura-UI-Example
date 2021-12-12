namespace CuraProfileDemonstration
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
			this.splitContainerMain = new System.Windows.Forms.SplitContainer();
			this.panelProfileControls = new System.Windows.Forms.Panel();
			this.buttonSaveProfile = new System.Windows.Forms.Button();
			this.comboBoxProfiles = new System.Windows.Forms.ComboBox();
			this.tabControlSettingsGroups = new System.Windows.Forms.TabControl();
			this.tabPageExtruder1 = new System.Windows.Forms.TabPage();
			this.tableLayoutPanelExtruder1 = new System.Windows.Forms.TableLayoutPanel();
			this.settingsGroupSelectionWalls1 = new CuraProfileDemonstration.SettingsGroupSelectionControl();
			this.settingsGroupControlMaterial1 = new CuraProfileDemonstration.SettingsGroupSelectionControl();
			this.tabPageExtruder2 = new System.Windows.Forms.TabPage();
			this.tableLayoutPanelExtruder2 = new System.Windows.Forms.TableLayoutPanel();
			this.settingsGroupControlWalls2 = new CuraProfileDemonstration.SettingsGroupSelectionControl();
			this.settingsGroupControlMaterial2 = new CuraProfileDemonstration.SettingsGroupSelectionControl();
			this.tabPageOther = new System.Windows.Forms.TabPage();
			this.tableLayoutPanelOther = new System.Windows.Forms.TableLayoutPanel();
			this.settingsGroupSelectionSupport = new CuraProfileDemonstration.SettingsGroupSelectionControl();
			this.settingsGroupControlCooling = new CuraProfileDemonstration.SettingsGroupSelectionControl();
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
			this.toolStripContainer1.ContentPanel.SuspendLayout();
			this.toolStripContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
			this.splitContainerMain.Panel2.SuspendLayout();
			this.splitContainerMain.SuspendLayout();
			this.panelProfileControls.SuspendLayout();
			this.tabControlSettingsGroups.SuspendLayout();
			this.tabPageExtruder1.SuspendLayout();
			this.tableLayoutPanelExtruder1.SuspendLayout();
			this.tabPageExtruder2.SuspendLayout();
			this.tableLayoutPanelExtruder2.SuspendLayout();
			this.tabPageOther.SuspendLayout();
			this.tableLayoutPanelOther.SuspendLayout();
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
			this.timerClock.Tick += new System.EventHandler(this.TimerClock_Tick);
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
			this.toolStripContainer1.ContentPanel.Controls.Add(this.splitContainerMain);
			this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(1366, 602);
			this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.toolStripContainer1.Location = new System.Drawing.Point(0, 24);
			this.toolStripContainer1.Name = "toolStripContainer1";
			this.toolStripContainer1.Size = new System.Drawing.Size(1366, 627);
			this.toolStripContainer1.TabIndex = 35;
			this.toolStripContainer1.Text = "toolStripContainer1";
			// 
			// splitContainerMain
			// 
			this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainerMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
			this.splitContainerMain.Location = new System.Drawing.Point(0, 0);
			this.splitContainerMain.Name = "splitContainerMain";
			// 
			// splitContainerMain.Panel1
			// 
			this.splitContainerMain.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
			this.splitContainerMain.Panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("splitContainerMain.Panel1.BackgroundImage")));
			this.splitContainerMain.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			// 
			// splitContainerMain.Panel2
			// 
			this.splitContainerMain.Panel2.Controls.Add(this.panelProfileControls);
			this.splitContainerMain.Panel2.Controls.Add(this.tabControlSettingsGroups);
			this.splitContainerMain.Size = new System.Drawing.Size(1366, 602);
			this.splitContainerMain.SplitterDistance = 600;
			this.splitContainerMain.TabIndex = 0;
			// 
			// panelProfileControls
			// 
			this.panelProfileControls.Controls.Add(this.buttonSaveProfile);
			this.panelProfileControls.Controls.Add(this.comboBoxProfiles);
			this.panelProfileControls.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelProfileControls.Location = new System.Drawing.Point(0, 0);
			this.panelProfileControls.Name = "panelProfileControls";
			this.panelProfileControls.Size = new System.Drawing.Size(762, 58);
			this.panelProfileControls.TabIndex = 1;
			// 
			// buttonSaveProfile
			// 
			this.buttonSaveProfile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonSaveProfile.Image = global::CuraProfileDemonstration.Properties.Resources.Save_16x;
			this.buttonSaveProfile.Location = new System.Drawing.Point(734, 14);
			this.buttonSaveProfile.Name = "buttonSaveProfile";
			this.buttonSaveProfile.Size = new System.Drawing.Size(25, 25);
			this.buttonSaveProfile.TabIndex = 1;
			this.buttonSaveProfile.Text = "Save";
			this.buttonSaveProfile.UseVisualStyleBackColor = true;
			this.buttonSaveProfile.Click += new System.EventHandler(this.ButtonSaveProfile_Click);
			// 
			// comboBoxProfiles
			// 
			this.comboBoxProfiles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.comboBoxProfiles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxProfiles.FormattingEnabled = true;
			this.comboBoxProfiles.Location = new System.Drawing.Point(4, 16);
			this.comboBoxProfiles.Name = "comboBoxProfiles";
			this.comboBoxProfiles.Size = new System.Drawing.Size(724, 21);
			this.comboBoxProfiles.TabIndex = 0;
			this.comboBoxProfiles.SelectedIndexChanged += new System.EventHandler(this.ComboBoxProfiles_SelectedIndexChanged);
			// 
			// tabControlSettingsGroups
			// 
			this.tabControlSettingsGroups.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tabControlSettingsGroups.Controls.Add(this.tabPageExtruder1);
			this.tabControlSettingsGroups.Controls.Add(this.tabPageExtruder2);
			this.tabControlSettingsGroups.Controls.Add(this.tabPageOther);
			this.tabControlSettingsGroups.Location = new System.Drawing.Point(0, 64);
			this.tabControlSettingsGroups.Name = "tabControlSettingsGroups";
			this.tabControlSettingsGroups.SelectedIndex = 0;
			this.tabControlSettingsGroups.Size = new System.Drawing.Size(762, 538);
			this.tabControlSettingsGroups.TabIndex = 0;
			// 
			// tabPageExtruder1
			// 
			this.tabPageExtruder1.BackColor = System.Drawing.SystemColors.Control;
			this.tabPageExtruder1.Controls.Add(this.tableLayoutPanelExtruder1);
			this.tabPageExtruder1.Location = new System.Drawing.Point(4, 22);
			this.tabPageExtruder1.Name = "tabPageExtruder1";
			this.tabPageExtruder1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageExtruder1.Size = new System.Drawing.Size(754, 512);
			this.tabPageExtruder1.TabIndex = 0;
			this.tabPageExtruder1.Text = "Extruder 1";
			// 
			// tableLayoutPanelExtruder1
			// 
			this.tableLayoutPanelExtruder1.ColumnCount = 2;
			this.tableLayoutPanelExtruder1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanelExtruder1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanelExtruder1.Controls.Add(this.settingsGroupSelectionWalls1, 1, 0);
			this.tableLayoutPanelExtruder1.Controls.Add(this.settingsGroupControlMaterial1, 0, 0);
			this.tableLayoutPanelExtruder1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanelExtruder1.Location = new System.Drawing.Point(3, 3);
			this.tableLayoutPanelExtruder1.Name = "tableLayoutPanelExtruder1";
			this.tableLayoutPanelExtruder1.RowCount = 1;
			this.tableLayoutPanelExtruder1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanelExtruder1.Size = new System.Drawing.Size(748, 506);
			this.tableLayoutPanelExtruder1.TabIndex = 1;
			// 
			// settingsGroupSelectionWalls1
			// 
			this.settingsGroupSelectionWalls1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.settingsGroupSelectionWalls1.Location = new System.Drawing.Point(377, 3);
			this.settingsGroupSelectionWalls1.MaximumSize = new System.Drawing.Size(0, 194);
			this.settingsGroupSelectionWalls1.MinimumSize = new System.Drawing.Size(338, 194);
			this.settingsGroupSelectionWalls1.Name = "settingsGroupSelectionWalls1";
			this.settingsGroupSelectionWalls1.ProfileCategoryEnum = CuraProfileDemonstration.ProfileCategoryEnum.Walls;
			this.settingsGroupSelectionWalls1.ProfileSectionEnum = CuraProfileDemonstration.ProfileSectionEnum.Walls1;
			this.settingsGroupSelectionWalls1.Size = new System.Drawing.Size(368, 194);
			this.settingsGroupSelectionWalls1.TabIndex = 1;
			// 
			// settingsGroupControlMaterial1
			// 
			this.settingsGroupControlMaterial1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.settingsGroupControlMaterial1.Location = new System.Drawing.Point(3, 3);
			this.settingsGroupControlMaterial1.MaximumSize = new System.Drawing.Size(0, 194);
			this.settingsGroupControlMaterial1.MinimumSize = new System.Drawing.Size(338, 194);
			this.settingsGroupControlMaterial1.Name = "settingsGroupControlMaterial1";
			this.settingsGroupControlMaterial1.ProfileCategoryEnum = CuraProfileDemonstration.ProfileCategoryEnum.Material;
			this.settingsGroupControlMaterial1.ProfileSectionEnum = CuraProfileDemonstration.ProfileSectionEnum.Material1;
			this.settingsGroupControlMaterial1.Size = new System.Drawing.Size(368, 194);
			this.settingsGroupControlMaterial1.TabIndex = 0;
			// 
			// tabPageExtruder2
			// 
			this.tabPageExtruder2.BackColor = System.Drawing.SystemColors.Control;
			this.tabPageExtruder2.Controls.Add(this.tableLayoutPanelExtruder2);
			this.tabPageExtruder2.Location = new System.Drawing.Point(4, 22);
			this.tabPageExtruder2.Name = "tabPageExtruder2";
			this.tabPageExtruder2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageExtruder2.Size = new System.Drawing.Size(754, 512);
			this.tabPageExtruder2.TabIndex = 1;
			this.tabPageExtruder2.Text = "Extruder 2";
			// 
			// tableLayoutPanelExtruder2
			// 
			this.tableLayoutPanelExtruder2.ColumnCount = 2;
			this.tableLayoutPanelExtruder2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanelExtruder2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanelExtruder2.Controls.Add(this.settingsGroupControlWalls2, 0, 0);
			this.tableLayoutPanelExtruder2.Controls.Add(this.settingsGroupControlMaterial2, 0, 0);
			this.tableLayoutPanelExtruder2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanelExtruder2.Location = new System.Drawing.Point(3, 3);
			this.tableLayoutPanelExtruder2.Name = "tableLayoutPanelExtruder2";
			this.tableLayoutPanelExtruder2.RowCount = 1;
			this.tableLayoutPanelExtruder2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanelExtruder2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 506F));
			this.tableLayoutPanelExtruder2.Size = new System.Drawing.Size(748, 506);
			this.tableLayoutPanelExtruder2.TabIndex = 0;
			// 
			// settingsGroupControlWalls2
			// 
			this.settingsGroupControlWalls2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.settingsGroupControlWalls2.Location = new System.Drawing.Point(377, 3);
			this.settingsGroupControlWalls2.MaximumSize = new System.Drawing.Size(0, 194);
			this.settingsGroupControlWalls2.MinimumSize = new System.Drawing.Size(338, 194);
			this.settingsGroupControlWalls2.Name = "settingsGroupControlWalls2";
			this.settingsGroupControlWalls2.ProfileCategoryEnum = CuraProfileDemonstration.ProfileCategoryEnum.Walls;
			this.settingsGroupControlWalls2.ProfileSectionEnum = CuraProfileDemonstration.ProfileSectionEnum.Walls1;
			this.settingsGroupControlWalls2.Size = new System.Drawing.Size(368, 194);
			this.settingsGroupControlWalls2.TabIndex = 2;
			// 
			// settingsGroupControlMaterial2
			// 
			this.settingsGroupControlMaterial2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.settingsGroupControlMaterial2.Location = new System.Drawing.Point(3, 3);
			this.settingsGroupControlMaterial2.MaximumSize = new System.Drawing.Size(0, 194);
			this.settingsGroupControlMaterial2.MinimumSize = new System.Drawing.Size(338, 194);
			this.settingsGroupControlMaterial2.Name = "settingsGroupControlMaterial2";
			this.settingsGroupControlMaterial2.ProfileCategoryEnum = CuraProfileDemonstration.ProfileCategoryEnum.Material;
			this.settingsGroupControlMaterial2.ProfileSectionEnum = CuraProfileDemonstration.ProfileSectionEnum.Material2;
			this.settingsGroupControlMaterial2.Size = new System.Drawing.Size(368, 194);
			this.settingsGroupControlMaterial2.TabIndex = 1;
			// 
			// tabPageOther
			// 
			this.tabPageOther.BackColor = System.Drawing.SystemColors.Control;
			this.tabPageOther.Controls.Add(this.tableLayoutPanelOther);
			this.tabPageOther.Location = new System.Drawing.Point(4, 22);
			this.tabPageOther.Name = "tabPageOther";
			this.tabPageOther.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageOther.Size = new System.Drawing.Size(754, 512);
			this.tabPageOther.TabIndex = 2;
			this.tabPageOther.Text = "Other";
			// 
			// tableLayoutPanelOther
			// 
			this.tableLayoutPanelOther.ColumnCount = 2;
			this.tableLayoutPanelOther.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanelOther.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanelOther.Controls.Add(this.settingsGroupSelectionSupport, 1, 0);
			this.tableLayoutPanelOther.Controls.Add(this.settingsGroupControlCooling, 0, 0);
			this.tableLayoutPanelOther.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanelOther.Location = new System.Drawing.Point(3, 3);
			this.tableLayoutPanelOther.Name = "tableLayoutPanelOther";
			this.tableLayoutPanelOther.RowCount = 1;
			this.tableLayoutPanelOther.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanelOther.Size = new System.Drawing.Size(748, 506);
			this.tableLayoutPanelOther.TabIndex = 0;
			// 
			// settingsGroupSelectionSupport
			// 
			this.settingsGroupSelectionSupport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.settingsGroupSelectionSupport.Location = new System.Drawing.Point(377, 3);
			this.settingsGroupSelectionSupport.MaximumSize = new System.Drawing.Size(0, 194);
			this.settingsGroupSelectionSupport.MinimumSize = new System.Drawing.Size(338, 194);
			this.settingsGroupSelectionSupport.Name = "settingsGroupSelectionSupport";
			this.settingsGroupSelectionSupport.ProfileCategoryEnum = CuraProfileDemonstration.ProfileCategoryEnum.Support;
			this.settingsGroupSelectionSupport.ProfileSectionEnum = CuraProfileDemonstration.ProfileSectionEnum.Support;
			this.settingsGroupSelectionSupport.Size = new System.Drawing.Size(368, 194);
			this.settingsGroupSelectionSupport.TabIndex = 1;
			// 
			// settingsGroupControlCooling
			// 
			this.settingsGroupControlCooling.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.settingsGroupControlCooling.Location = new System.Drawing.Point(3, 3);
			this.settingsGroupControlCooling.MaximumSize = new System.Drawing.Size(0, 194);
			this.settingsGroupControlCooling.MinimumSize = new System.Drawing.Size(338, 194);
			this.settingsGroupControlCooling.Name = "settingsGroupControlCooling";
			this.settingsGroupControlCooling.ProfileCategoryEnum = CuraProfileDemonstration.ProfileCategoryEnum.Cooling;
			this.settingsGroupControlCooling.ProfileSectionEnum = CuraProfileDemonstration.ProfileSectionEnum.Cooling;
			this.settingsGroupControlCooling.Size = new System.Drawing.Size(368, 194);
			this.settingsGroupControlCooling.TabIndex = 0;
			// 
			// statusBar
			// 
			this.statusBar.Location = new System.Drawing.Point(0, 651);
			this.statusBar.Name = "statusBar";
			this.statusBar.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
            this.statusBarPanelStatus,
            this.statusBarPanelBlank,
            this.statusBarPanelClock});
			this.statusBar.ShowPanels = true;
			this.statusBar.Size = new System.Drawing.Size(1366, 24);
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
			this.statusBarPanelBlank.Width = 1059;
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
            this.toolStripMenuItemProject});
			this.menuStripMain.Location = new System.Drawing.Point(0, 0);
			this.menuStripMain.Name = "menuStripMain";
			this.menuStripMain.Size = new System.Drawing.Size(1366, 24);
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
			this.toolStripMenuItemNew.Size = new System.Drawing.Size(155, 22);
			this.toolStripMenuItemNew.Text = "&New...";
			// 
			// toolStripMenuItemOpen
			// 
			this.toolStripMenuItemOpen.Name = "toolStripMenuItemOpen";
			this.toolStripMenuItemOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
			this.toolStripMenuItemOpen.Size = new System.Drawing.Size(155, 22);
			this.toolStripMenuItemOpen.Text = "&Open...";
			// 
			// toolStripMenuItemClose
			// 
			this.toolStripMenuItemClose.Name = "toolStripMenuItemClose";
			this.toolStripMenuItemClose.Size = new System.Drawing.Size(155, 22);
			this.toolStripMenuItemClose.Text = "&Close";
			// 
			// toolStripSeparatorFile1
			// 
			this.toolStripSeparatorFile1.Name = "toolStripSeparatorFile1";
			this.toolStripSeparatorFile1.Size = new System.Drawing.Size(152, 6);
			// 
			// toolStripMenuItemSave
			// 
			this.toolStripMenuItemSave.Enabled = false;
			this.toolStripMenuItemSave.Name = "toolStripMenuItemSave";
			this.toolStripMenuItemSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
			this.toolStripMenuItemSave.Size = new System.Drawing.Size(155, 22);
			this.toolStripMenuItemSave.Text = "&Save";
			// 
			// toolStripMenuItemSaveAs
			// 
			this.toolStripMenuItemSaveAs.Name = "toolStripMenuItemSaveAs";
			this.toolStripMenuItemSaveAs.Size = new System.Drawing.Size(155, 22);
			this.toolStripMenuItemSaveAs.Text = "Save &As...";
			// 
			// mnuFileExport
			// 
			this.mnuFileExport.Name = "mnuFileExport";
			this.mnuFileExport.Size = new System.Drawing.Size(155, 22);
			this.mnuFileExport.Text = "&Export";
			// 
			// toolStripSeparatorFile2
			// 
			this.toolStripSeparatorFile2.Name = "toolStripSeparatorFile2";
			this.toolStripSeparatorFile2.Size = new System.Drawing.Size(152, 6);
			// 
			// toolStripMenuItemRecentFiles
			// 
			this.toolStripMenuItemRecentFiles.Name = "toolStripMenuItemRecentFiles";
			this.toolStripMenuItemRecentFiles.Size = new System.Drawing.Size(155, 22);
			this.toolStripMenuItemRecentFiles.Text = "&Recent Files";
			// 
			// toolStripSeparatorFile3
			// 
			this.toolStripSeparatorFile3.Name = "toolStripSeparatorFile3";
			this.toolStripSeparatorFile3.Size = new System.Drawing.Size(152, 6);
			// 
			// toolStripMenuItemExit
			// 
			this.toolStripMenuItemExit.Name = "toolStripMenuItemExit";
			this.toolStripMenuItemExit.Size = new System.Drawing.Size(155, 22);
			this.toolStripMenuItemExit.Text = "E&xit";
			this.toolStripMenuItemExit.Click += new System.EventHandler(this.ToolStripMenuItemExit_Click);
			// 
			// toolStripMenuItemProject
			// 
			this.toolStripMenuItemProject.Name = "toolStripMenuItemProject";
			this.toolStripMenuItemProject.Size = new System.Drawing.Size(56, 20);
			this.toolStripMenuItemProject.Text = "&Project";
			// 
			// Demostration
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1366, 675);
			this.Controls.Add(this.toolStripContainer1);
			this.Controls.Add(this.menuStripMain);
			this.Controls.Add(this.statusBar);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Demostration";
			this.Text = "Cura Profile Demonstration Software";
			this.toolStripContainer1.ContentPanel.ResumeLayout(false);
			this.toolStripContainer1.ResumeLayout(false);
			this.toolStripContainer1.PerformLayout();
			this.splitContainerMain.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
			this.splitContainerMain.ResumeLayout(false);
			this.panelProfileControls.ResumeLayout(false);
			this.tabControlSettingsGroups.ResumeLayout(false);
			this.tabPageExtruder1.ResumeLayout(false);
			this.tableLayoutPanelExtruder1.ResumeLayout(false);
			this.tabPageExtruder2.ResumeLayout(false);
			this.tableLayoutPanelExtruder2.ResumeLayout(false);
			this.tabPageOther.ResumeLayout(false);
			this.tableLayoutPanelOther.ResumeLayout(false);
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
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSave;
		private System.Windows.Forms.SplitContainer splitContainerMain;
		private System.Windows.Forms.TabControl tabControlSettingsGroups;
		private System.Windows.Forms.TabPage tabPageExtruder1;
		private System.Windows.Forms.TabPage tabPageExtruder2;
		private System.Windows.Forms.Panel panelProfileControls;
		private SettingsGroupSelectionControl settingsGroupControlMaterial1;
		private System.Windows.Forms.Button buttonSaveProfile;
		private System.Windows.Forms.ComboBox comboBoxProfiles;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanelExtruder2;
		private SettingsGroupSelectionControl settingsGroupControlWalls2;
		private SettingsGroupSelectionControl settingsGroupControlMaterial2;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanelExtruder1;
		private SettingsGroupSelectionControl settingsGroupSelectionWalls1;
		private System.Windows.Forms.TabPage tabPageOther;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanelOther;
		private SettingsGroupSelectionControl settingsGroupSelectionSupport;
		private SettingsGroupSelectionControl settingsGroupControlCooling;
	}
}

