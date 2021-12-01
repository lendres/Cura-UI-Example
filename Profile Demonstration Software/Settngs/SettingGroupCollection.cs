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
	/// Holds a collection of SettingGroups.
	/// </summary>
	public class SettingGroupCollection<T> where T : SettingGroup
	{
		#region Enumerations

		#endregion

		#region Delegates

		#endregion

		#region Events

		#endregion

		#region Members

		private Dictionary<Guid, SettingGroup>				_settingGroups			= new Dictionary<Guid, SettingGroup>();

		#endregion

		#region Construction

		/// <summary>
		/// Default constructor.
		/// </summary>
		public SettingGroupCollection()
		{
		}

		#endregion

		#region Properties

		#endregion

		#region Methods

		/// <summary>
		/// Add a SettingGroup to the collection.
		/// </summary>
		/// <param name="settingGroup"></param>
		public void Add(T settingGroup)
		{
			_settingGroups.Add(settingGroup.Id, settingGroup);
		}

		#endregion

		#region XML

		#endregion

	} // End class.
} // End namespace.