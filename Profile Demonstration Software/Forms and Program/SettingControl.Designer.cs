namespace CuraProfileDemonstration
{
	partial class SettingControl
	{
		#region Members

		private System.Windows.Forms.Label labelName;

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
			this.labelName = new System.Windows.Forms.Label();
			this.checkBoxOverride = new System.Windows.Forms.CheckBox();
			this.textBoxValue = new System.Windows.Forms.TextBox();
			this.buttonSaveProfile = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// labelName
			// 
			this.labelName.Location = new System.Drawing.Point(4, 0);
			this.labelName.Name = "labelName";
			this.labelName.Size = new System.Drawing.Size(128, 26);
			this.labelName.TabIndex = 0;
			this.labelName.Text = "Name";
			this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// checkBoxOverride
			// 
			this.checkBoxOverride.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.checkBoxOverride.AutoSize = true;
			this.checkBoxOverride.Location = new System.Drawing.Point(229, 5);
			this.checkBoxOverride.Name = "checkBoxOverride";
			this.checkBoxOverride.Size = new System.Drawing.Size(66, 17);
			this.checkBoxOverride.TabIndex = 2;
			this.checkBoxOverride.Text = "Override";
			this.checkBoxOverride.UseVisualStyleBackColor = true;
			this.checkBoxOverride.CheckedChanged += new System.EventHandler(this.CheckBoxOverride_CheckedChanged);
			// 
			// textBoxValue
			// 
			this.textBoxValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxValue.Location = new System.Drawing.Point(138, 3);
			this.textBoxValue.Name = "textBoxValue";
			this.textBoxValue.Size = new System.Drawing.Size(82, 20);
			this.textBoxValue.TabIndex = 3;
			this.textBoxValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.textBoxValue.Leave += new System.EventHandler(this.TextBoxValue_Leave);
			// 
			// buttonSaveProfile
			// 
			this.buttonSaveProfile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonSaveProfile.Image = global::CuraProfileDemonstration.Properties.Resources.Save_16x;
			this.buttonSaveProfile.Location = new System.Drawing.Point(299, 1);
			this.buttonSaveProfile.Name = "buttonSaveProfile";
			this.buttonSaveProfile.Size = new System.Drawing.Size(25, 25);
			this.buttonSaveProfile.TabIndex = 4;
			this.buttonSaveProfile.Text = "Save";
			this.buttonSaveProfile.UseVisualStyleBackColor = true;
			this.buttonSaveProfile.Click += new System.EventHandler(this.buttonSaveProfile_Click);
			// 
			// SettingControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.buttonSaveProfile);
			this.Controls.Add(this.textBoxValue);
			this.Controls.Add(this.checkBoxOverride);
			this.Controls.Add(this.labelName);
			this.Name = "SettingControl";
			this.Size = new System.Drawing.Size(328, 26);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.CheckBox checkBoxOverride;
		private System.Windows.Forms.TextBox textBoxValue;
		private System.Windows.Forms.Button buttonSaveProfile;
	} // End class.
} // End namespace.
