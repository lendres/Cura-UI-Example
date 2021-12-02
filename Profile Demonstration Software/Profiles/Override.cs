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
	public class Override
	{
		#region Enumerations

		#endregion

		#region Delegates

		#endregion

		#region Events

		#endregion

		#region Members

		private Guid						_defaultSettingGroupId;
		private	SettingGroup				_overrideSettingGroup;

		#endregion

		#region Construction

		/// <summary>
		/// Default constructor.
		/// </summary>
		public Override()
		{
		}

		#endregion

		#region Properties

		/// <summary>
		/// Guid of default SettingGroup.
		/// </summary>
		[XmlAttribute("defaultsettinggroupid")]
		public Guid DefaultSettingGroupId
		{
			get => _defaultSettingGroupId;
			set => _defaultSettingGroupId = value;
		}

		/// <summary>
		/// A SettingGroup that contains any override settings.
		/// </summary>
		[XmlElement("overridesettinggroup")]
		public SettingGroup OverrideSettingGroup
		{
			get => _overrideSettingGroup;
			set => _overrideSettingGroup = value;
		}

		#endregion

		#region Methods

		#endregion

	} // End class.
} // End namespace.