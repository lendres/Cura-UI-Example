using System;
using System.Linq;
using System.Collections.Generic;
using System.Xml.Serialization;
using DigitalProduction.XML.Serialization;

namespace CuraProfileDemonstration
{
	/// <summary>
	/// 
	/// </summary>
	public abstract class SettingGroup : Serializable
	{
		#region Members

		private Dictionary<string, Setting>				_settings				= new Dictionary<string, Setting>();

		#endregion

		#region Construction

		/// <summary>
		/// Default constructor.
		/// </summary>
        public SettingGroup()
		{
		}

		#endregion

		#region Properties

		/// <summary>
		/// Dictionary that contains the properties.
		/// </summary>
		//[XmlArray("properties"), XmlArrayItem("property")]
		//public SerializableDictionary<string, Setting> Properties
		//{
		//	get => _properties;
		//	set => _properties = value;
		//}

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

		#endregion

	} // End class.
} // End namespace.