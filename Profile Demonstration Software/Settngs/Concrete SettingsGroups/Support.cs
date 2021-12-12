namespace CuraProfileDemonstration
{
	/// <summary>
	/// Specifics for the support SettingsGroup.
	/// </summary>
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
		/// Constructor for creating a new support settings group.
		/// </summary>
		public Support(string name, double overHangAngle, string interfaceExtruder, string infillExtruder)
		{
			this.Name = name;

			Add(new Setting("Overhang Angle", 55));
			Add(new Setting("Interface Extruder", interfaceExtruder));
			Add(new Setting("Infill Extruder", infillExtruder));
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
