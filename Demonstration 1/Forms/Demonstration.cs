using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Plossum.CommandLine;
using DigitalProduction.Forms;

namespace ProfileDemo
{
	/// <summary>
	/// Main window.
	/// </summary>
	[CommandLineManager(ApplicationName = "Template", Copyright = "Copyright (c) APS Technologies.")]
	public partial class Demostration : Form
	{
		#region Members

		#endregion

		#region Construction

		/// <summary>
		/// Default constructor.
		/// </summary>
		public Demostration()
		{
			InitializeComponent();
		}

		#endregion

		#region Form Event Handlers
		
		/// <summary>
		/// Clock ticking event.
		/// </summary>
		/// <param name="sender">Sender.</param>
		/// <param name="e">Event arguments.</param>
		private void timerClock_Tick(object sender, EventArgs e)
		{
			this.statusBarPanelClock.Text = System.DateTime.Now.ToLongTimeString();
		}

		/// <summary>
		/// Key up event handler.
		/// </summary>
		/// <param name="sender">Sender.</param>
		/// <param name="e">Event arguments.</param>
		private void Form1_KeyUp(object sender, KeyEventArgs e)
		{
			switch (e.KeyCode)
			{
				case Keys.F5:
				{
//					Solve();
//					e.Handled = true;
					break;
				}
			}
		}

		#endregion

		#region File Menu Event Handlers

		/// <summary>
		/// "New" menu item click handler.
		/// </summary>
		/// <param name="sender">Sender.</param>
		/// <param name="e">Event arguments.</param>
		protected void toolStripMenuItemFileNew_Click(object sender, EventArgs e)
		{
			//New();
		}

		/// <summary>
		/// "Open" menu item click handler.
		/// </summary>
		/// <param name="sender">Sender.</param>
		/// <param name="e">Event arguments.</param>
		protected void toolStripMenuItemFileOpen_Click(object sender, EventArgs e)
		{
			//BrowseAndOpen();
		}

		/// <summary>
		/// "Close" menu item click handler.
		/// </summary>
		/// <param name="sender">Sender.</param>
		/// <param name="e">Event arguments.</param>
		protected void toolStripMenuItemFileClose_Click(object sender, EventArgs e)
		{
			//CloseProject();
		}

		/// <summary>
		/// "Save" menu item click handler.
		/// </summary>
		/// <param name="sender">Sender.</param>
		/// <param name="e">Event arguments.</param>
		protected void toolStripMenuItemFileSave_Click(object sender, EventArgs e)
		{
			//Save();
		}

		/// <summary>
		/// "Save As" menu item click handler.
		/// </summary>
		/// <param name="sender">Sender.</param>
		/// <param name="e">Event arguments.</param>
		protected void toolStripMenuItemFileSaveAs_Click(object sender, EventArgs e)
		{
			//SaveAs();
		}

		/// <summary>
		/// Close the form.
		/// </summary>
		/// <param name="sender">Sender.</param>
		/// <param name="e">Event arguments.</param>
		private void toolStripMenuItemExit_Click(object sender, EventArgs e)
		{
			Close();
		}

		#endregion

		#region Project Menu Event Handlers

	
		#endregion

		#region Tools Menu Event Handlers

		/// <summary>
		/// Show the options.
		/// </summary>
		/// <param name="sender">Sender.</param>
		/// <param name="e">Event arguments.</param>
		private void toolStripMenuItemOptions_Click(object sender, EventArgs e)
		{
			OptionsForm options = new OptionsForm();
			DialogResult result = options.ShowDialog(this);

			// The options can change the text displayed in the comparison chart so we need to repopulate it in case
			// that option was changed.  Only do it on an "OK" result of the dialog.
			if (result == DialogResult.OK)
			{
//                if (_project != null)
//                {
////					_project.UpdateAfterOptionsChanged();
//                }
			}
		}

		#endregion

		#region Help Menu Event Handlers

		/// <summary>
		/// Shows the help file.
		/// </summary>
		/// <param name="sender">Sender.</param>
		/// <param name="e">Event arguments.</param>
		private void toolStripMenuItemHelpHelp_Click(object sender, EventArgs e)
		{
			string file = System.IO.Path.Combine(DigitalProduction.Reflection.Assembly.LibraryPath, @"Help\Help.chm");
			Help.ShowHelp(this, file);
		}

		/// <summary>
		/// Shows the About dialog box.
		/// </summary>
		/// <param name="sender">Sender.</param>
		/// <param name="e">Event arguments.</param>
		private void toolStripMenuItemHelpAbout_Click(object sender, EventArgs e)
		{
			AboutForm1 about = new AboutForm1("lendres@aps-tech.com", "ProfileDemo.Forms.About.bmp");
			about.ShowDialog(this);
		}

		#endregion

	} // End class.
} // End namespace.