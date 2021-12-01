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

namespace CuraProfileDemonstration
{
	/// <summary>
	/// Main window.
	/// </summary>
	[CommandLineManager(ApplicationName = "Template", Copyright = "Copyright (c) APS Technologies.")]
	public partial class Demostration : Form
	{
		#region Members


		private Manager				_manager				= new Manager();

		#endregion

		#region Construction

		/// <summary>
		/// Default constructor.
		/// </summary>
		public Demostration()
		{
			InitializeComponent();

			//_manager.ReadLibraries()
		}

		#endregion

		#region Form Event Handlers
		
		/// <summary>
		/// Clock ticking event.
		/// </summary>
		/// <param name="sender">Sender.</param>
		/// <param name="eventArgs">Event arguments.</param>
		private void timerClock_Tick(object sender, EventArgs eventArgs)
		{
			this.statusBarPanelClock.Text = System.DateTime.Now.ToLongTimeString();
		}

		/// <summary>
		/// Key up event handler.
		/// </summary>
		/// <param name="sender">Sender.</param>
		/// <param name="eventArgs">Event arguments.</param>
		private void Form1_KeyUp(object sender, KeyEventArgs eventArgs)
		{
			switch (eventArgs.KeyCode)
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
		/// <param name="eventArgs">Event arguments.</param>
		protected void toolStripMenuItemFileNew_Click(object sender, EventArgs eventArgs)
		{
			//New();
		}

		/// <summary>
		/// "Open" menu item click handler.
		/// </summary>
		/// <param name="sender">Sender.</param>
		/// <param name="eventArgs">Event arguments.</param>
		protected void toolStripMenuItemFileOpen_Click(object sender, EventArgs eventArgs)
		{
			//BrowseAndOpen();
		}

		/// <summary>
		/// "Close" menu item click handler.
		/// </summary>
		/// <param name="sender">Sender.</param>
		/// <param name="eventArgs">Event arguments.</param>
		protected void toolStripMenuItemFileClose_Click(object sender, EventArgs eventArgs)
		{
			//CloseProject();
		}

		/// <summary>
		/// "Save" menu item click handler.
		/// </summary>
		/// <param name="sender">Sender.</param>
		/// <param name="eventArgs">Event arguments.</param>
		protected void toolStripMenuItemFileSave_Click(object sender, EventArgs eventArgs)
		{
			//Save();
		}

		/// <summary>
		/// "Save As" menu item click handler.
		/// </summary>
		/// <param name="sender">Sender.</param>
		/// <param name="eventArgs">Event arguments.</param>
		protected void toolStripMenuItemFileSaveAs_Click(object sender, EventArgs eventArgs)
		{
			//SaveAs();
		}

		/// <summary>
		/// Close the form.
		/// </summary>
		/// <param name="sender">Sender.</param>
		/// <param name="eventArgs">Event arguments.</param>
		private void toolStripMenuItemExit_Click(object sender, EventArgs eventArgs)
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
		/// <param name="eventArgs">Event arguments.</param>
		private void toolStripMenuItemOptions_Click(object sender, EventArgs eventArgs)
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

		private void writeDefaultLibraryToolStripMenuItem_Click(object sender, EventArgs e)
		{
			// Get a new Project file path.  If no file is selected an empty string is return.
			//string path = DirectorySelect.SelectDirectory("Select Library Location", true, DigitalProduction.Reflection.Assembly.Path());

			//_manager.CreateInitialLibrary(path);
		}

	} // End class.
} // End namespace.