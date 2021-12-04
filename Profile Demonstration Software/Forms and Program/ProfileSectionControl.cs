using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuraProfileDemonstration
{
	public partial class ProfileSectionControl : UserControl
	{
		#region Members

		private ProfileCategoryEnum				_profileCategoryEnum			= ProfileCategoryEnum.Length;
		private ProfileSectionEnum				_profileSectionEnum				= ProfileSectionEnum.Length;

		private ProfileSection					_profileSection;
		private SettingsGroupCollection			_librarySettingsGroupCollection;
		private SettingsGroup					_defaultSettingsGroup;

		#endregion

		#region Construction

		public ProfileSectionControl()
		{
			InitializeComponent();
		}

		#endregion

		#region Properties

		/// <summary>
		/// Use this to add a property in the designer.
		/// </summary>
		[Category("Cura")]
		public ProfileCategoryEnum ProfileCategoryEnum
		{
			get => _profileCategoryEnum;
			set => _profileCategoryEnum=value;
		}

		/// <summary>
		/// Use this to add a property in the designer.
		/// </summary>
		[Category("Cura")]
		public ProfileSectionEnum ProfileSectionEnum
		{
			get => _profileSectionEnum;
			set => _profileSectionEnum = value;
		}

		#endregion

		#region Events

		/// <summary>
		/// Event to handle the section of a different SettingGroup from the library.
		/// </summary>
		/// <param name="sender">Sender.</param>
		/// <param name="eventArgs">Event arguments.</param>
		private void ComboBoxSettingsGroupSelector_SelectedIndexChanged(object sender, EventArgs e)
		{
			_defaultSettingsGroup					= _librarySettingsGroupCollection.GetSettingsGroup(this.comboBoxSettingsGroupSelector.Text);
			_profileSection.DefaultSettingsGroupId	= _defaultSettingsGroup.Id;

			InitializeSettingControls();
		}

		#endregion

		#region Methods

		/// <summary>
		/// Initialize the control from the profile.
		/// </summary>
		public void InitializeFromProfile()
		{
			// Must go before call to library collection.
			UpdateProfileAndSettingsGroups();

			InitializeSettingControls();

			// Populate and update drop down box.
			this.comboBoxSettingsGroupSelector.Items.AddRange(_librarySettingsGroupCollection.SettingsGroupsNames.ToArray());
			this.comboBoxSettingsGroupSelector.SelectedItem  = _defaultSettingsGroup.Name;
		}

		/// <summary>
		/// Update everything from a newly selected profile.
		/// </summary>
		public void UpdateFromProfile()
		{
			// Must go before call to library collection.
			UpdateProfileAndSettingsGroups();

			InitializeSettingControls();

			// Update drop down box.
			this.comboBoxSettingsGroupSelector.SelectedItem  = _defaultSettingsGroup.Name;
		}

		/// <summary>
		/// Initialize the settings.
		/// </summary>
		private void InitializeSettingControls()
		{
			// Initialize the SettingsControls.
			this.settingControl0.Initialize(_defaultSettingsGroup, _profileSection.OverrideSettingsGroup);
			this.settingControl1.Initialize(_defaultSettingsGroup, _profileSection.OverrideSettingsGroup);
			this.settingControl2.Initialize(_defaultSettingsGroup, _profileSection.OverrideSettingsGroup);
		}

		/// <summary>
		/// Gather the necessary data.
		/// </summary>
		private void UpdateProfileAndSettingsGroups()
		{
			_profileSection = ProfileManager.Manager.SelectedProfile.GetProfileSection(_profileSectionEnum);
			_librarySettingsGroupCollection	= ProfileManager.Manager.GetLibrarySettingsGroupCollection(_profileCategoryEnum);
			_defaultSettingsGroup			= _librarySettingsGroupCollection.GetSettingsGroup(_profileSection.DefaultSettingsGroupId);
		}

		#endregion

	} // End class.
} // End namespace.
