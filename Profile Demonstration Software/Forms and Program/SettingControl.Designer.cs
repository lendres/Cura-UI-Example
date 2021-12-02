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
			this.SuspendLayout();
			// 
			// labelName
			// 
			this.labelName.AutoSize = true;
			this.labelName.Location = new System.Drawing.Point(4, 5);
			this.labelName.MaximumSize = new System.Drawing.Size(65, 0);
			this.labelName.Name = "labelName";
			this.labelName.Size = new System.Drawing.Size(35, 13);
			this.labelName.TabIndex = 0;
			this.labelName.Text = "Name";
			this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// checkBoxOverride
			// 
			this.checkBoxOverride.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.checkBoxOverride.AutoSize = true;
			this.checkBoxOverride.Location = new System.Drawing.Point(224, 5);
			this.checkBoxOverride.Name = "checkBoxOverride";
			this.checkBoxOverride.Size = new System.Drawing.Size(66, 17);
			this.checkBoxOverride.TabIndex = 2;
			this.checkBoxOverride.Text = "Override";
			this.checkBoxOverride.UseVisualStyleBackColor = true;
			this.checkBoxOverride.CheckedChanged += new System.EventHandler(this.checkBoxOverride_CheckedChanged);
			// 
			// textBoxValue
			// 
			this.textBoxValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxValue.Location = new System.Drawing.Point(138, 3);
			this.textBoxValue.Name = "textBoxValue";
			this.textBoxValue.Size = new System.Drawing.Size(80, 20);
			this.textBoxValue.TabIndex = 3;
			this.textBoxValue.Leave += new System.EventHandler(this.textBoxValue_Leave);
			// 
			// SettingControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.textBoxValue);
			this.Controls.Add(this.checkBoxOverride);
			this.Controls.Add(this.labelName);
			this.Name = "SettingControl";
			this.Size = new System.Drawing.Size(290, 26);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.CheckBox checkBoxOverride;
		private System.Windows.Forms.TextBox textBoxValue;
	} // End class.
} // End namespace.
