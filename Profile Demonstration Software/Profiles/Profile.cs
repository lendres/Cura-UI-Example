using System.Collections.Generic;
using System.Xml.Serialization;

namespace CuraProfileDemonstration
{
	/// <summary>
	/// Top level profile container.
	/// </summary>
	public class Profile : Serializable
	{
		#region Members

		public static string					FileExtension				= ".profile";

		private List<ProfileSection>			_profileSections			= new List<ProfileSection>();

		#endregion

		#region Construction

		/// <summary>
		/// Default constructor.  Used for deserialization.  The deserialization will create the ProfileSections.
		/// </summary>
		public Profile()
		{
		}

		/// <summary>
		/// Constructor for creating a Profile programmically.  It creates the ProfileSections so the can be accessed later.
		/// </summary>
		public Profile(string name) :
			this()
		{
			this.Name = name;

			for (int i = 0; i < (int)ProfileSectionEnum.Length; i++)
			{
				_profileSections.Add(new ProfileSection());
			}

		}

		#endregion

		#region Properties

		/// <summary>
		/// String the defines the filter used to get files in an Open or Save File dialog.
		/// </summary>
		public static string FilterString
		{
			get
			{
				return "Cura profile files (*.profile)|*.profile|Text files (*.txt)|*.txt|All files (*.*)|*.*";
			}
		}

		/// <summary>
		/// For serialization.
		/// </summary>
		[XmlArray("profilesections"), XmlArrayItem("profilesection")]
		public List<ProfileSection> Overrides
		{
			get => _profileSections;
			set => _profileSections = value;
		}


		#endregion

		#region Methods

		/// <summary>
		/// File extension for serialization/deserialization.
		/// </summary>
		public override string GetFileExtension()
		{
			return Profile.FileExtension;
		}

		/// <summary>
		/// Initialize a profile section.
		/// </summary>
		/// <param name="profileSection">ProfileSection to initialize.</param>
		/// <param name="settingsGroup">SettingsGroup.</param>
		public void Initialize(ProfileSectionEnum profileSection, SettingsGroup settingsGroup)
		{

			_profileSections[(int)profileSection].Initialize(settingsGroup);
		}

		/// <summary>
		/// Get a ProfileSection.
		/// </summary>
		/// <param name="profileSection">ProfileSection to return.</param>
		public ProfileSection GetProfileSection(ProfileSectionEnum profileSection)
		{
			return _profileSections[(int)profileSection];
		}

		#endregion

	} // End class.
} // End namespace.