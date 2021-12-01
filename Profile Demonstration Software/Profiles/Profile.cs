using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using DigitalProduction.XML.Serialization;

namespace CuraProfileDemonstration
{
	/// <summary>
	/// 
	/// </summary>
	public class Profile : Serializable
	{
		#region Members

		private	List<Material>				_materialOverrides		= new List<Material>();
		private List<Guid>					_materialIds			= new List<Guid>();

		#endregion

		#region Construction

		/// <summary>
		/// Default constructor.
		/// </summary>
		public Profile()
		{
		}

		#endregion

		#region Properties

		/// <summary>
		/// String the defines the filter used to get files in an Open or Save File dialog.
		/// </summary>
		public static string FilterString
		{
			get
			{
				return "Cura profile files (*.profile)|*.profile|Text files (*.txt)|*.txt|All files (*.*)|*.*";
			}
		}

		[XmlArray("materialoverrides"), XmlArrayItem("material")]
		public List<Material> Materials
		{
			get => _materialOverrides;
			set => _materialOverrides = value;
		}

		#endregion

		#region Methods



		#endregion

		#region XML

		#endregion

	} // End class.
} // End namespace.