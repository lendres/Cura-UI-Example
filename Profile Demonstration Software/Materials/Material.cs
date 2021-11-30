using System.Collections.Generic;
using System.Xml.Serialization;

namespace ProfileDemo.Materials
{
	class Material : PropertyGroup
	{
		#region Members


		#endregion

		#region Construction

		/// <summary>
		/// Default constructor.
		/// </summary>
		public Material()
		{
			AddProperty("Temperature", 200);
			AddProperty("Cool Down Modifier", 2);
			AddProperty("Flow Rate", 100);
		}

		#endregion

	} // End class.
}  // End namespace.
