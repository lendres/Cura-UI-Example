using System;
using System.Xml.Serialization;
using DigitalProduction.XML.Serialization;

namespace ProfileDemo
{
	/// <summary>
	/// 
	/// </summary>
	public class Profile : Serializable
	{
		#region Members



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

		#endregion

		#region Functions



		#endregion

		#region XML

		#endregion

	} // End class.
} // End namespace.