namespace CuraProfileDemonstration.Forms_and_Program
{
	partial class SettingGroupControl
	{
		#region Members

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
			this.settingControl2 = new CuraProfileDemonstration.SettingControl();
			this.settingControl1 = new CuraProfileDemonstration.SettingControl();
			this.settingControl0 = new CuraProfileDemonstration.SettingControl();
			this.comboBoxSettingGroupSelector = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// settingControl2
			// 
			this.settingControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.settingControl2.Index = 2;
			this.settingControl2.Location = new System.Drawing.Point(3, 102);
			this.settingControl2.Name = "settingControl2";
			this.settingControl2.Size = new System.Drawing.Size(326, 26);
			this.settingControl2.TabIndex = 2;
			// 
			// settingControl1
			// 
			this.settingControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.settingControl1.Index = 1;
			this.settingControl1.Location = new System.Drawing.Point(3, 70);
			this.settingControl1.Name = "settingControl1";
			this.settingControl1.Size = new System.Drawing.Size(326, 26);
			this.settingControl1.TabIndex = 1;
			// 
			// settingControl0
			// 
			this.settingControl0.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.settingControl0.Index = 0;
			this.settingControl0.Location = new System.Drawing.Point(3, 38);
			this.settingControl0.Name = "settingControl0";
			this.settingControl0.Size = new System.Drawing.Size(326, 26);
			this.settingControl0.TabIndex = 0;
			// 
			// comboBoxSettingGroupSelector
			// 
			this.comboBoxSettingGroupSelector.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.comboBoxSettingGroupSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxSettingGroupSelector.FormattingEnabled = true;
			this.comboBoxSettingGroupSelector.Location = new System.Drawing.Point(3, 3);
			this.comboBoxSettingGroupSelector.Name = "comboBoxSettingGroupSelector";
			this.comboBoxSettingGroupSelector.Size = new System.Drawing.Size(326, 21);
			this.comboBoxSettingGroupSelector.TabIndex = 3;
			// 
			// SettingGroupControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.comboBoxSettingGroupSelector);
			this.Controls.Add(this.settingControl2);
			this.Controls.Add(this.settingControl1);
			this.Controls.Add(this.settingControl0);
			this.Name = "SettingGroupControl";
			this.Size = new System.Drawing.Size(332, 136);
			this.ResumeLayout(false);

		}

		#endregion

		private SettingControl settingControl0;
		private SettingControl settingControl1;
		private SettingControl settingControl2;
		private System.Windows.Forms.ComboBox comboBoxSettingGroupSelector;
	} // End class.
} // End namespace.
