using DigitalProduction.XML.Serialization;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;

namespace CuraProfileDemonstration
{
	/// <summary>
	/// A group of settings.
	/// 
	/// The [XmlInclude] lines are required to create the contrete class types while serialzing/deserializing from this base class.
	/// </summary>
	[XmlInclude(typeof(Cooling))]
	[XmlInclude(typeof(Material))]
	[XmlInclude(typeof(Support))]
	[XmlInclude(typeof(Walls))]
	public abstract class SettingsGroup : Serializable
	{
		#region Members

		private Dictionary<string, Setting>				_settings				= new Dictionary<string, Setting>();

		#endregion

		#region Construction

		/// <summary>
		/// Default constructor.
		/// </summary>
        public SettingsGroup()
		{
		}

		/// <summary>
		/// Default constructor.
		/// </summary>
        public SettingsGroup(SettingsGroup original)
		{
			_settings = new Dictionary<string, Setting>(original._settings);
		}

		#endregion

		#region Properties

		/// <summary>
		/// Dictionary that contains the properties.
		/// </summary>
		[XmlArray("properties"), XmlArrayItem("property")]
		public SerializableKeyValuePair<string, Setting>[] Properties
		{
			get
			{
				List<SerializableKeyValuePair<string, Setting>> list = new List<SerializableKeyValuePair<string, Setting>>();
				if (_settings != null)
				{
					list.AddRange(_settings.Keys.Select(key => new SerializableKeyValuePair<string, Setting>() {Key = key, Value = _settings[key]}));
				}
				return list.ToArray();
			}

			set
			{
				_settings = new Dictionary<string, Setting>();
				foreach (SerializableKeyValuePair<string, Setting> item in value)
				{
					_settings.Add(item.Key, item.Value);
				}
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// Add a setting
		/// </summary>
		/// <param name="setting">Setting to add</param>
		public void Add(Setting setting)
		{
			_settings.Add(setting.Name, setting);
		}

		/// <summary>
		/// Get a property by its index.
		/// 
		/// Requires the "System.Linq" using statement.
		/// </summary>
		/// <param name="index">Index of the Property to return.</param>
		public Setting GetProperty(int index)
		{
			return _settings.Values.ElementAt(index);
		}

		/// <summary>
		/// Copy the object.
		/// </summary>
		public abstract SettingsGroup Copy();

		#endregion

		#region XML

		/// <summary>
		/// Deserializes a SettingsGroupl
		/// </summary>
		/// <param name="fullPath">Directory to deserialize from.</param>
		/// <param name="fileExtension">File extension of the files to deserialize.</param>
		public static SettingsGroup Deserialize<T>(string fullPath) where T : SettingsGroup
		{
			T settingsGroup = Serialization.DeserializeObject<T>(fullPath);

			settingsGroup._fullPath = fullPath;

			foreach (KeyValuePair<string, Setting> keyValuePair in settingsGroup._settings)
			{
				// Value is the Setting.
				keyValuePair.Value.Parent = settingsGroup;
			}

			return settingsGroup;
		}

		#endregion

	} // End class.
} // End namespace.