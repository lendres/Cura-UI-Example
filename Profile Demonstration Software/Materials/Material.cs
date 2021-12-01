using System.Collections.Generic;
using System.Xml.Serialization;

namespace CuraProfileDemonstration
{
	public class Material : SettingGroup
	{
		#region Members

		public static string		FileExtension		= ".material";

		#endregion

		#region Construction

		/// <summary>
		/// Default constructor.
		/// 
		/// Required for serializationi.
		/// </summary>
		public Material()
		{
		}

		/// <summary>
		/// Constructor for creating a new material.
		/// </summary>
		public Material(string name)
		{
			this.Name = name;

			AddProperty("Temperature", 200);
			AddProperty("Cool Down Modifier", 2);
			AddProperty("Flow Rate", 100);
		}

		#endregion

		#region Properties

		/// <summary>
		/// File extension for serialization.
		/// </summary>
		public override string GetFileExtension()
		{
			return Material.FileExtension;
		}

		#endregion

		#region XML

		#endregion

	} // End class.
}  // End namespace.
