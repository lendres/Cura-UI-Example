namespace CuraProfileDemonstration
{
	/// <summary>
	/// Specifics for the walls SettingsGroup.
	/// </summary>
	public class Walls : SettingsGroup
	{
		#region Members

		public static string		FileExtension		= ".walls";

		#endregion

		#region Construction

		/// <summary>
		/// Default constructor.
		/// 
		/// Required for serializationi.
		/// </summary>
		public Walls()
		{
		}

		/// <summary>
		/// Constructor for creating a new material.
		/// 
		/// Create some settings with default values.
		/// </summary>
		public Walls(string name, double wallThickness, bool outerBeforeInner, string zSeam)
		{
			this.Name = name;

			Add(new Setting("Wall Thickness", wallThickness));
			Add(new Setting("Outer Before Inner", outerBeforeInner));
			Add(new Setting("Z Seam", zSeam));
		}

		/// <summary>
		/// Copy constructor.
		/// </summary>
		public Walls(Walls original) :
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
			return Walls.FileExtension;
		}

		#endregion

		#region Methods

		/// <summary>
		/// Copy the object.
		/// </summary>
		public override SettingsGroup Copy()
		{
			return new Walls(this);
		}

		#endregion

	} // End class.
}  // End namespace.
