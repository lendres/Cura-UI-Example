using System.Collections.Generic;
using System.Xml.Serialization;

namespace CuraProfileDemonstration
{
	public class Support : SettingGroup
	{
		#region Members

		public static string		FileExtension		= ".support";

		#endregion

		#region Construction

		/// <summary>
		/// Default constructor.
		/// 
		/// Required for serializationi.
		/// </summary>
		public Support()
		{
		}

		/// <summary>
		/// Constructor for creating a new material.
		/// 
		/// Create some settings with default values.
		/// </summary>
		public Support(string name)
		{
			this.Name = name;

			Add(new Setting("Overhang Angle", 55));
			Add(new Setting("Interface Extruder", "Extruder 2"));
			Add(new Setting("Infill Extruder", "Extruder 1"));
		}

		#endregion

		#region Properties

		/// <summary>
		/// File extension for serialization.
		/// </summary>
		public override string GetFileExtension()
		{
			return Support.FileExtension;
		}

		#endregion

	} // End class.
}  // End namespace.
