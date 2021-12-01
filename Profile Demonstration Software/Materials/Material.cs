using System.Collections.Generic;
using System.Xml.Serialization;

namespace CuraProfileDemonstration
{
	public class Material : SettingGroup
	{
		#region Members


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

		#region XML

		/// <summary>
		/// Create an instance from a file.
		/// </summary>
		/// <param name="path">The file to read from.</param>
		protected static Material Deserialize(string path)
		{
			return Deserialize<Material>(path);
		}

		#endregion

	} // End class.
}  // End namespace.
