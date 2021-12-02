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
		/// 
		/// Create some settings with default values.
		/// </summary>
		public Material(string name)
		{
			this.Name = name;

			Add(new Setting("Temperature", 200));
			Add(new Setting("Cool Down Modifier", 2));
			Add(new Setting("Flow Rate", 100));
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

	} // End class.
}  // End namespace.
