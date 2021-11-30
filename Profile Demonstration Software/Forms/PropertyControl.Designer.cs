namespace ProfileDemo
{
	partial class PropertyControl
	{
		#region Members

		private System.Windows.Forms.Label labelName;
		private System.Windows.Forms.NumericUpDown numericUpDownValue;

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
			this.numericUpDownValue = new System.Windows.Forms.NumericUpDown();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownValue)).BeginInit();
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
			// numericUpDownValue
			// 
			this.numericUpDownValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.numericUpDownValue.Location = new System.Drawing.Point(155, 3);
			this.numericUpDownValue.Name = "numericUpDownValue";
			this.numericUpDownValue.Size = new System.Drawing.Size(86, 20);
			this.numericUpDownValue.TabIndex = 1;
			this.numericUpDownValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// PropertyControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.numericUpDownValue);
			this.Controls.Add(this.labelName);
			this.Name = "PropertyControl";
			this.Size = new System.Drawing.Size(244, 26);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownValue)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

	} // End class.
} // End namespace.
