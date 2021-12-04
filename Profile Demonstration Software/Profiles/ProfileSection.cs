using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Xml.Serialization;

namespace CuraProfileDemonstration
{
	/// <summary>
	/// 
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