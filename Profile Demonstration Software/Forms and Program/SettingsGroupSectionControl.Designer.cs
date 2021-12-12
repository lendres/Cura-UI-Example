namespace CuraProfileDemonstration
{
	partial class SettingsGroupSelectionControl
	{
		#region Members

		private System.Windows.Forms.ComboBox comboBoxSettingsGroupSelector;
		
		private SettingControl settingControl0;
		private SettingControl settingControl1;
		private SettingControl settingControl2;

		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		#endregion

		#region Disposing

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

		#endregion

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.comboBoxSettingsGroupSelector = new System.Windows.Forms.ComboBox();
			this.groupBox = new System.Windows.Forms.GroupBox();
			this.settingControl2 = new CuraProfileDemonstration.SettingControl();
			this.settingControl0 = new CuraProfileDemonstration.SettingControl();
			this.settingControl1 = new CuraProfileDemonstration.SettingControl();
			this.pictureBoxDotDotDot = new System.Windows.Forms.PictureBox();
			this.groupBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxDotDotDot)).BeginInit();
			this.SuspendLayout();
			// 
			// comboBoxSettingsGroupSelector
			// 
			this.comboBoxSettingsGroupSelector.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.comboBoxSettingsGroupSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxSettingsGroupSelector.FormattingEnabled = true;
			this.comboBoxSettingsGroupSelector.Location = new System.Drawing.Point(6, 22);
			this.comboBoxSettingsGroupSelector.Name = "comboBoxSettingsGroupSelector";
			this.comboBoxSettingsGroupSelector.Size = new System.Drawing.Size(326, 21);
			this.comboBoxSettingsGroupSelector.TabIndex = 3;
			this.comboBoxSettingsGroupSelector.SelectedIndexChanged += new System.EventHandler(this.ComboBoxSettingsGroupSelector_SelectedIndexChanged);
			// 
			// groupBox
			// 
			this.groupBox.Controls.Add(this.pictureBoxDotDotDot);
			this.groupBox.Controls.Add(this.comboBoxSettingsGroupSelector);
			this.groupBox.Controls.Add(this.settingControl2);
			this.groupBox.Controls.Add(this.settingControl0);
			this.groupBox.Controls.Add(this.settingControl1);
			this.groupBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox.Location = new System.Drawing.Point(0, 0);
			this.groupBox.Name = "groupBox";
			this.groupBox.Size = new System.Drawing.Size(338, 194);
			this.groupBox.TabIndex = 4;
			this.groupBox.TabStop = false;
			this.groupBox.Text = "groupBox";
			// 
			// settingControl2
			// 
			this.settingControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.settingControl2.Index = 2;
			this.settingControl2.Location = new System.Drawing.Point(6, 160);
			this.settingControl2.Name = "settingControl2";
			this.settingControl2.Size = new System.Drawing.Size(326, 26);
			this.settingControl2.TabIndex = 2;
			// 
			// settingControl0
			// 
			this.settingControl0.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.settingControl0.Index = 0;
			this.settingControl0.Location = new System.Drawing.Point(6, 54);
			this.settingControl0.Name = "settingControl0";
			this.settingControl0.Size = new System.Drawing.Size(326, 26);
			this.settingControl0.TabIndex = 0;
			// 
			// settingControl1
			// 
			this.settingControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.settingControl1.Index = 1;
			this.settingControl1.Location = new System.Drawing.Point(6, 86);
			this.settingControl1.Name = "settingControl1";
			this.settingControl1.Size = new System.Drawing.Size(326, 26);
			this.settingControl1.TabIndex = 1;
			// 
			// pictureBoxDotDotDot
			// 
			this.pictureBoxDotDotDot.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBoxDotDotDot.BackgroundImage = global::CuraProfileDemonstration.Properties.Resources.Dot_Dot_Dot;
			this.pictureBoxDotDotDot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBoxDotDotDot.ErrorImage = null;
			this.pictureBoxDotDotDot.InitialImage = null;
			this.pictureBoxDotDotDot.Location = new System.Drawing.Point(6, 116);
			this.pictureBoxDotDotDot.Name = "pictureBoxDotDotDot";
			this.pictureBoxDotDotDot.Size = new System.Drawing.Size(326, 36);
			this.pictureBoxDotDotDot.TabIndex = 4;
			this.pictureBoxDotDotDot.TabStop = false;
			// 
			// SettingsGroupSelectionControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.groupBox);
			this.MaximumSize = new System.Drawing.Size(0, 194);
			this.MinimumSize = new System.Drawing.Size(338, 194);
			this.Name = "SettingsGroupSelectionControl";
			this.Size = new System.Drawing.Size(338, 194);
			this.groupBox.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxDotDotDot)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox;
		private System.Windows.Forms.PictureBox pictureBoxDotDotDot;
	} // End class.
} // End namespace.
