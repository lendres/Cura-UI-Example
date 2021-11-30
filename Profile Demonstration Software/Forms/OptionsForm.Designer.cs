namespace ProfileDemo
{
	partial class OptionsForm
	{
		#region Members

		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button buttonOK;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.Label labelExample;
		private System.Windows.Forms.Button buttonExample;
		private System.Windows.Forms.TextBox textBoxExample;

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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.buttonOK = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.labelExample = new System.Windows.Forms.Label();
			this.buttonExample = new System.Windows.Forms.Button();
			this.textBoxExample = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// buttonOK
			// 
			this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.buttonOK.Location = new System.Drawing.Point(332, 177);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new System.Drawing.Size(80, 23);
			this.buttonOK.TabIndex = 1;
			this.buttonOK.Text = "&OK";
			this.buttonOK.UseVisualStyleBackColor = true;
			this.buttonOK.Click += new System.EventHandler(this.bntOK_Click);
			// 
			// buttonCancel
			// 
			this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.Location = new System.Drawing.Point(430, 177);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(80, 23);
			this.buttonCancel.TabIndex = 2;
			this.buttonCancel.Text = "&Cancel";
			this.buttonCancel.UseVisualStyleBackColor = true;
			// 
			// labelExample
			// 
			this.labelExample.AutoSize = true;
			this.labelExample.Location = new System.Drawing.Point(11, 10);
			this.labelExample.Name = "labelExample";
			this.labelExample.Size = new System.Drawing.Size(47, 13);
			this.labelExample.TabIndex = 6;
			this.labelExample.Text = "Example";
			// 
			// buttonExample
			// 
			this.buttonExample.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonExample.Location = new System.Drawing.Point(430, 25);
			this.buttonExample.Name = "buttonExample";
			this.buttonExample.Size = new System.Drawing.Size(80, 23);
			this.buttonExample.TabIndex = 7;
			this.buttonExample.Text = "Browse...";
			this.buttonExample.UseVisualStyleBackColor = true;
			this.buttonExample.Click += new System.EventHandler(this.buttonExample_Click);
			// 
			// textBoxExample
			// 
			this.textBoxExample.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxExample.Location = new System.Drawing.Point(12, 26);
			this.textBoxExample.Name = "textBoxExample";
			this.textBoxExample.Size = new System.Drawing.Size(404, 20);
			this.textBoxExample.TabIndex = 8;
			// 
			// OptionsForm
			// 
			this.AcceptButton = this.buttonOK;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.buttonCancel;
			this.ClientSize = new System.Drawing.Size(522, 214);
			this.Controls.Add(this.textBoxExample);
			this.Controls.Add(this.buttonExample);
			this.Controls.Add(this.labelExample);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonOK);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(800, 252);
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(400, 252);
			this.Name = "OptionsForm";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Options";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

	} // End class.
} // End namespace.