using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using DigitalProduction.XML.Serialization;

namespace CuraProfileDemonstration
{

	/// <summary>
	/// Container for Profiles.
	/// </summary>
	public class MaterialGroup
	{
		#region Members

        //private List<Material>           _profiles           = new List<Material>();
        //private string                  _path;

		#endregion

		#region Construction

		/// <summary>
		/// Default constructor.
		/// </summary>
		public MaterialGroup()
		{
		}

		#endregion

		#region Properties

  //      /// <summary>
		///// Profiles.
		///// </summary>
		//[XmlArray("fields"), XmlArrayItem("field")]
		//public List<Material> Profiles
		//{
		//	get
		//	{
		//		return _profiles;
		//	}

		//	set
		//	{
		//		_profiles = value;
		//	}
		//}

		#endregion

		#region Methods



		#endregion

		#region XML

  //      		/// <summary>
		///// Create an instance from a file.
		///// </summary>
		///// <param name="path">The file to read from.</param>
		///// <returns>The deserialized file types.</returns>
		//private static MaterialGroup Deserialize(string path)
		//{
  //          MaterialGroup group			= Serialization.DeserializeObject<MaterialGroup>(path);
  //          group._path                  = path;
		//	return group;
		//}

		///// <summary>
		///// Write this object to a file.  The Path must be set and represent a valid path or this method will throw an exception.
		///// </summary>
		///// <exception cref="InvalidOperationException">Thrown when the projects path is not set or not valid.</exception>
		//public void Serialize()
		//{
		//	Serialization.SerializeObject(this, _path);
		//}

		#endregion

	} // End class.
} // End namespace.