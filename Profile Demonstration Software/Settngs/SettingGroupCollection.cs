using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Xml.Serialization;
using System.IO;
using DigitalProduction.XML.Serialization;

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


		public static SettingGroupCollection<T> Deserialize(string path, string fileExtension)
		{
			SettingGroupCollection<T> settingGroupCollection = new SettingGroupCollection<T>();

			List<string> files = Directory.EnumerateFiles(path, "*.*", SearchOption.TopDirectoryOnly).Where(s => Path.GetExtension(s).ToLowerInvariant() == fileExtension).ToList();

			foreach (string file in files)
			{
				T settingGroup = Serialization.DeserializeObject<T>(Path.Combine(path, file));
				settingGroupCollection.Add(settingGroup);
			}

			return settingGroupCollection;
		}

		/// <summary>
		/// Serialize all the SettingGroups.
		/// </summary>
		/// <param name="path"></param>
		public void Serialize(string path)
		{
			foreach (KeyValuePair<Guid, SettingGroup> keyValuePair in _settingGroups)
			{
				keyValuePair.Value.Serialize(path);
			}
		}

		#endregion

	} // End class.
} // End namespace.