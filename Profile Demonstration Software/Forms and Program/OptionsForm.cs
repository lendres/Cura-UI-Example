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
	/// Options form.
	/// </summary>
	public partial class OptionsForm : Form
	{
		#region Members

		#endregion

		#region Construction

		/// <summary>
		/// Default constructor.
		/// </summary>
		public OptionsForm()
		{
			InitializeComponent();

			//this.textBoxExample.Text						= registry.Example;
		}

		#endregion

		#region Event Handlers

		/// <summary>
		/// Click handler for browsing for a file.
		/// </summary>
		/// <param name="sender">Sender.</param>
		/// <param name="e">Event Argument.</param>
		private void buttonExample_Click(object sender, EventArgs e)
		{
			string path = FileSelect.BrowseForAnXMLFile(this);

			if (path != "")
			{
				this.textBoxExample.Text = path;
			}
		}

		/// <summary>
		/// Ok click handler.
		/// </summary>
		/// <param name="sender">Sender.</param>
		/// <param name="e">Event Argument.</param>
		private void bntOK_Click(object sender, EventArgs e)
		{

		}

		#endregion

	} // End class.
} // End namespace.