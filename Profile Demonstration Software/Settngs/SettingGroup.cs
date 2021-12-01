using System;
using System.Linq;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace CuraProfileDemonstration
{
	/// <summary>
	/// 
	/// </summary>
	public abstract class SettingGroup : Serializable
	{
		#region Members

		private string									_name;
		private Dictionary<string, Setting>				_properties				= new Dictionary<string, Setting>();

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
		/// Name or title of this setting group.
		/// </summary>
		[XmlAttribute("name")]
		public string Name
		{
			get => _name;
			set => _name = value;
		}

		/// <summary>
		/// Dictionary that contains the properties.
		/// </summary>
		[XmlArray("properties"), XmlArrayItem("property")]
		public Dictionary<string, Setting> Properties
		{
			get => _properties;
			set => _properties=value;
		}

		#endregion

		#region Methods

		/// <summary>
		/// Create a new property.
		/// </summary>
		/// <param name="name">Property name.</param>
		/// <param name="value">Property value.</param>
		public void AddProperty(string name, double value)
		{
			_properties.Add(name, new Setting());
		}

		/// <summary>
		/// Get a property by its index.
		/// 
		/// Requires the "System.Linq" using statement.
		/// </summary>
		/// <param name="index">Index of the Property to return.</param>
		public Setting GetProperty(int index)
		{
			return _properties.Values.ElementAt(index);
		}

		#endregion

		#region XML

		#endregion

	} // End class.
} // End namespace.