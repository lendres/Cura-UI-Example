using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DigitalProduction.Forms;

namespace CuraProfileDemonstration
{
	/// <summary>
	/// 
	/// </summary>
	public partial class DialogBoxForm : Form
	{
		#region Members

		#endregion

		#region Construction

		/// <summary>
		/// Default constructor.
		/// </summary>
		public DialogBoxForm()
		{
			InitializeComponent();
		}

		#endregion

		#region Event Handlers

		/// <summary>
		/// Get a file.
		/// </summary>
		/// <param name="sender">Sender.</param>
		/// <param name="e">Event arguments.</param>
		private void buttonBrowse_Click(object sender, EventArgs e)
		{
			string path = FileSelect.BrowseForAnXMLFile(this);

			if (path != "")
			{
				this.textBox.Text = path;
			}
		}

		/// <summary>
		/// Ok click handler.
		/// </summary>
		/// <param name="sender">Sender.</param>
		/// <param name="e">Event arguments.</param>
		private void bntOK_Click(object sender, EventArgs e)
		{
			// Ensure the data is valid.
			if (!ValidateChildren())
			{
				// Have to set the DialogResult to none to prevent the form from closing.
				this.DialogResult = DialogResult.None;
				return;
			}


			// This will close the dialog as well.
			this.DialogResult = DialogResult.OK;
		}

		#endregion

	} // End class.
} // End namespace.