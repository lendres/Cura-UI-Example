using System;
using System.Linq;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace ProfileDemo
{
	/// <summary>
	/// 
	/// </summary>
	public class PropertyGroup : Serializable
	{
		#region Members

		private Dictionary<string, Property>		_properties;

		#endregion

		#region Construction

		/// <summary>
		/// Default constructor.
		/// </summary>
        public PropertyGroup()
		{
		}

		#endregion

		#region Properties

		/// <summary>
		/// Dictionary that contains the properties.
		/// </summary>
		[XmlArray("properties"), XmlArrayItem("property")]
		public Dictionary<string, Property> Properties
		{
			get => _properties;
			set => _properties=value;
		}


		#endregion

		#region Functions

		/// <summary>
		/// Create a new property.
		/// </summary>
		/// <param name="name">Property name.</param>
		/// <param name="value">Property value.</param>
		public void AddProperty(string name, double value)
		{
			_properties.Add(name, new Property());
		}

		/// <summary>
		/// Get a property by its index.
		/// 
		/// Requires the "System.Linq" using statement.
		/// </summary>
		/// <param name="index">Index of the Property to return.</param>
		public Property GetProperty(int index)
		{
			return _properties.Values.ElementAt(index);
		}

		#endregion

		#region XML

		#endregion

	} // End class.
} // End namespace.