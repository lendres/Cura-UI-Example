using System;
using System.Xml.Serialization;

namespace CuraProfileDemonstration
{
	/// <summary>
	/// A profile section or sub category.  It is a specific section of a profile (not a category).  For example, "Material 1" or "Material 2."
	/// See ProfileSectionEnum for a listing of profile sections.
	/// </summary>
	public class ProfileSection
	{
		#region Members

		private Guid						_defaultSettingsGroupId;
		private	SettingsGroup				_overrideSettingsGroup;

		#endregion

		#region Construction

		/// <summary>
		/// Default constructor.
		/// </summary>
		public ProfileSection()
		{
		}

		#endregion

		#region Properties

		/// <summary>
		/// Guid of default SettingsGroup.
		/// </summary>
		[XmlAttribute("defaultsettingsgroupid")]
		public Guid DefaultSettingsGroupId
		{
			get => _defaultSettingsGroupId;
			set => _defaultSettingsGroupId = value;
		}

		/// <summary>
		/// A SettingsGroup that contains any override settings.
		/// </summary>
		[XmlElement("overridesettingsgroup")]
		public SettingsGroup OverrideSettingsGroup
		{
			get => _overrideSettingsGroup;
			set => _overrideSettingsGroup = value;
		}

		#endregion

		#region Methods

		/// <summary>
		/// Initialize this object.
		/// </summary>
		/// <param name="settingsGroup">SettingsGroup to use as initializer.</param>
		public void Initialize(SettingsGroup settingsGroup)
		{
			_defaultSettingsGroupId	= settingsGroup.Id;
			_overrideSettingsGroup	= settingsGroup.Copy();
		}

		#endregion

	} // End class.
} // End namespace.