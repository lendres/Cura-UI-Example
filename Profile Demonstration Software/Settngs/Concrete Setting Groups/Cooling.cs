namespace CuraProfileDemonstration
{
	public class Cooling : SettingGroup
	{
		#region Members

		public static string		FileExtension		= ".cooling";

		#endregion

		#region Construction

		/// <summary>
		/// Default constructor.
		/// 
		/// Required for serializationi.
		/// </summary>
		public Cooling()
		{
		}

		/// <summary>
		/// Constructor for creating a new material.
		/// 
		/// Create some settings with default values.
		/// </summary>
		public Cooling(string name)
		{
			this.Name = name;

			Add(new Setting("Fan Speed", 100));
			Add(new Setting("Initial Fan Speed", 10));
			Add(new Setting("Minimum Layer Type", 5));
		}

		#endregion

		#region Properties

		/// <summary>
		/// File extension for serialization.
		/// </summary>
		public override string GetFileExtension()
		{
			return Cooling.FileExtension;
		}

		#endregion

	} // End class.
}  // End namespace.
