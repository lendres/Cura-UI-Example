using System.Collections.Generic;
using System.Xml.Serialization;

namespace CuraProfileDemonstration
{
	public class Support : SettingsGroup
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

		/// <summary>
		/// Copy constructor.
		/// </summary>
		public Support(Support original) :
			base(original)
		{
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

		#region Methods

		/// <summary>
		/// Copy the object.
		/// </summary>
		public override SettingsGroup Copy()
		{
			return new Support(this);
		}

		#endregion

	} // End class.
}  // End namespace.
