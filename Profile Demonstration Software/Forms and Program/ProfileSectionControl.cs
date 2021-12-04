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
			SettingsGroupCollection librarySettingsGroupCollection = ProfileManager.Manager.GetLibrarySettingsGroupCollection(_profileCategoryEnum);

			SettingsGroup defaultSettingsGroup		= librarySettingsGroupCollection.GetSettingsGroup(this.comboBoxSettingsGroupSelector.Text);
			_profileSection.DefaultSettingsGroupId	= defaultSettingsGroup.Id;

			InitializeSettingControls(defaultSettingsGroup);
		}

		#endregion

		#region Methods

		public void InitializeFromProfile()
		{
			// Must go before call to library collection.
			UpdaeProfileSection();

			SettingsGroupCollection librarySettingsGroupCollection = ProfileManager.Manager.GetLibrarySettingsGroupCollection(_profileCategoryEnum);
			SettingsGroup defaultSettingsGroup = librarySettingsGroupCollection.GetSettingsGroup(_profileSection.DefaultSettingsGroupId);

			InitializeSettingControls(defaultSettingsGroup);

			// Populate drop down box.
			this.comboBoxSettingsGroupSelector.Items.AddRange(librarySettingsGroupCollection.SettingsGroupsNames.ToArray());
			this.comboBoxSettingsGroupSelector.SelectedItem  = defaultSettingsGroup.Name;
		}

		private void InitializeSettingControls(SettingsGroup defaultSettingsGroup)
		{
			// Initialize the SettingsControls.
			this.settingControl0.Initialize(defaultSettingsGroup, _profileSection.OverrideSettingsGroup);
			this.settingControl1.Initialize(defaultSettingsGroup, _profileSection.OverrideSettingsGroup);
			this.settingControl2.Initialize(defaultSettingsGroup, _profileSection.OverrideSettingsGroup);
		}

		private void UpdaeProfileSection()
		{
			_profileSection = ProfileManager.Manager.SelectedProfile.GetProfileSection(_profileSectionEnum);
		}

		#endregion

	} // End class.
} // End namespace.
