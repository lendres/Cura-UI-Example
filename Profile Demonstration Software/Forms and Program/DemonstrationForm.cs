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
using DigitalProduction.Delegates;

namespace CuraProfileDemonstration
{
	/// <summary>
	/// Main window.
	/// </summary>
	[CommandLineManager(ApplicationName = "Cura Demonstration Example", Copyright = "Copyright (c) Lance A. Endres.")]
	public partial class Demostration : Form
	{
		#region Events

		private event NoArgumentsEventHandler		OnSelectedProfileChanged;

		#endregion

		#region Members


		private ProfileManager				_manager				= new ProfileManager();

		#endregion

		#region Construction

		/// <summary>
		/// Default constructor.
		/// </summary>
		public Demostration()
		{
			InitializeComponent();

			// Add entries to drop down lists, et cetera.
			PopulateDataToControls();

		}


		#endregion

		#region Methods

		/// <summary>
		/// Initializes all controls.
		/// </summary>
		private void PopulateDataToControls()
		{
			this.comboBoxProfiles.Items.AddRange(_manager.ProfileCollection.ProfileNames.ToArray());

			// Set the control to the first item.
			// This will also trigger the selected index event which will populate the values from the Profile to the controls.
			this.comboBoxProfiles.SelectedIndex = 0;

			FindProfileSelectControls(this);
		}

		/// <summary>
		/// Find all the ProfileSectionControls.
		/// </summary>
		/// <param name="rootControl">Control to search through.</param>
		protected void FindProfileSelectControls(Control rootControl)
		{
			foreach (Control childControl in rootControl.Controls)
			{
				if (childControl is ProfileSectionControl)
				{
					ProfileSectionControl profileSectionControl = (ProfileSectionControl)childControl;
					profileSectionControl.InitializeFromProfile();
					this.OnSelectedProfileChanged += profileSectionControl.UpdateFromProfile;
				}

				// Search the children controls.
				FindProfileSelectControls(childControl);
			}
		}

		/// <summary>
		/// Safely fire an event.
		/// </summary>
		private void RaiseOnSelectedProfileChangedEvent()
		{
			// Trigger event only if there are any subscribers.
			if (this.OnSelectedProfileChanged != null)
			{
				OnSelectedProfileChanged();
			}
		}

		#endregion

		#region Form Event Handlers

		/// <summary>
		/// Clock ticking event.
		/// </summary>
		/// <param name="sender">Sender.</param>
		/// <param name="eventArgs">Event arguments.</param>
		private void TimerClock_Tick(object sender, EventArgs eventArgs)
		{
			this.statusBarPanelClock.Text = System.DateTime.Now.ToLongTimeString();
		}

		#endregion

		#region File Menu Event Handlers

		/// <summary>
		/// Close the form.
		/// </summary>
		/// <param name="sender">Sender.</param>
		/// <param name="eventArgs">Event arguments.</param>
		private void ToolStripMenuItemExit_Click(object sender, EventArgs eventArgs)
		{
			Close();
		}

		#endregion

		#region Tools Menu Event Handlers

		/// <summary>
		/// Show the options.
		/// </summary>
		/// <param name="sender">Sender.</param>
		/// <param name="eventArgs">Event arguments.</param>
		private void ToolStripMenuItemOptions_Click(object sender, EventArgs eventArgs)
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

		#region Controls Event Handlers

		/// <summary>
		/// Profile save button click handler.
		/// </summary>
		/// <param name="sender">Sender.</param>
		/// <param name="eventArgs">Event arguments.</param>
		private void ButtonSaveProfile_Click(object sender, EventArgs e)
		{
			string activeProfile = this.comboBoxProfiles.Text;
			_manager.SerializeProfile(activeProfile);
		}

		/// <summary>
		/// Profile drop down box index changed event handler.
		/// </summary>
		/// <param name="sender">Sender.</param>
		/// <param name="eventArgs">Event arguments.</param>
		private void ComboBoxProfiles_SelectedIndexChanged(object sender, EventArgs e)
		{
			_manager.SetSelectedProfile(this.comboBoxProfiles.Text);
			RaiseOnSelectedProfileChangedEvent();
		}

		#endregion

	} // End class.
} // End namespace.