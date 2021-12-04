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
	/// Holds a collection of SettingsGroups.
	/// </summary>
	public class SettingsGroupCollection
	{
		#region Members

		private Dictionary<Guid, SettingsGroup>				_settingsGroups			= new Dictionary<Guid, SettingsGroup>();

		#endregion

		#region Construction

		/// <summary>
		/// Default constructor.
		/// </summary>
		public SettingsGroupCollection()
		{
		}

		#endregion

		#region Properties

		/// <summary>
		/// Get a list of all the names in this collection of SettingsGroups.
		/// </summary>
		public List<string> SettingsGroupsNames
		{
			get
			{
			List<string> names = new List<string>();

			foreach (KeyValuePair<Guid, SettingsGroup> keyValuePair in _settingsGroups)
			{
				names.Add(keyValuePair.Value.Name);
			}

			return names;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// Add a SettingsGroup to the collection.
		/// </summary>
		/// <param name="settingsGroup"></param>
		public void Add(SettingsGroup settingsGroup)
		{
			_settingsGroups.Add(settingsGroup.Id, settingsGroup);
		}

		/// <summary>
		/// Get a SettingsGroup from its ID.
		/// </summary>
		/// <param name="id">Guid that is unique to the SettingsGroup.</param>
		public SettingsGroup GetSettingsGroup(Guid id)
		{
			foreach (KeyValuePair<Guid, SettingsGroup> keyValuePair in _settingsGroups)
			{
				SettingsGroup settingsGroup = keyValuePair.Value;

				if (settingsGroup.Id == id)
				{
					return settingsGroup;
				}
			}

			throw new Exception("A SettingsGroup with the specified ID was not found.");
		}

		/// <summary>
		/// Get a SettingsGroup from its name.
		/// </summary>
		/// <param name="id">Guid that is unique to the SettingsGroup.</param>
		public SettingsGroup GetSettingsGroup(string name)
		{
			foreach (KeyValuePair<Guid, SettingsGroup> keyValuePair in _settingsGroups)
			{
				SettingsGroup settingsGroup = keyValuePair.Value;

				if (settingsGroup.Name == name)
				{
					return settingsGroup;
				}
			}

			throw new Exception("A SettingsGroup with the specified ID was not found.");
		}

		#endregion

		#region XML

		/// <summary>
		/// Deserializes all the files of a specific file type in a directory.  Those files are converted to a SettingsGroup on a one-to-one basis.
		/// </summary>
		/// <param name="path">Directory to deserialize from.</param>
		/// <param name="fileExtension">File extension of the files to deserialize.</param>
		public static SettingsGroupCollection Deserialize<T>(string path, string fileExtension) where T : SettingsGroup
		{
			SettingsGroupCollection settingsGroupCollection = new SettingsGroupCollection();

			List<string> files = Directory.EnumerateFiles(path, "*.*", SearchOption.TopDirectoryOnly).Where(s => Path.GetExtension(s).ToLowerInvariant() == fileExtension).ToList();

			foreach (string file in files)
			{
				SettingsGroup settingsGroup = SettingsGroup.Deserialize<T>(Path.Combine(path, file));
				settingsGroupCollection.Add(settingsGroup);
			}

			return settingsGroupCollection;
		}

		/// <summary>
		/// Serialize all the SettingsGroups into separate files.
		/// </summary>
		/// <param name="path">Directory to serialize to.</param>
		public void Serialize(string path)
		{
			foreach (KeyValuePair<Guid, SettingsGroup> keyValuePair in _settingsGroups)
			{
				keyValuePair.Value.Serialize(path);
			}
		}

		#endregion

	} // End class.
} // End namespace.