namespace CuraProfileDemonstration
{
	public class Material : SettingsGroup
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
		public Material(string name, double temerature, double coolDownModifier, double flowRate)
		{
			this.Name = name;

			Add(new Setting("Temperature", temerature));
			Add(new Setting("Cool Down Modifier", coolDownModifier));
			Add(new Setting("Flow Rate", flowRate));
		}

		/// <summary>
		/// Copy constructor.
		/// </summary>
		public Material(Material original) :
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
			return Material.FileExtension;
		}

		#endregion

		#region Methods

		/// <summary>
		/// Copy the object.
		/// </summary>
		public override SettingsGroup Copy()
		{
			return new Material(this);
		}

		#endregion

	} // End class.
}  // End namespace.
