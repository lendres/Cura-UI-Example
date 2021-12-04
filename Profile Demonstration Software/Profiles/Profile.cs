using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using DigitalProduction.XML.Serialization;

namespace CuraProfileDemonstration
{
	/// <summary>
	/// 
	/// </summary>
	public class Profile : Serializable
	{
		#region Members

		public static string					FileExtension				= ".profile";

		private List<ProfileSection>			_profileSections			= new List<ProfileSection>();

		#endregion

		#region Construction

		/// <summary>
		/// Default constructor.
		/// </summary>
		public Profile()
		{
//			_overrides[(int)OverrideEnum.Material1].OverrideSettingsGroup = new Material();
		}

		/// <summary>
		/// Constructor.
		/// </summary>
		public Profile(string name) :
			this()
		{
			this.Name = name;
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

		public void Initialize(Material material1, Material material2)
		{
			for (int i = 0; i < (int)ProfileSectionEnum.Length; i++)
			{
				_profileSections.Add(new ProfileSection());
			}

			_profileSections[(int)ProfileSectionEnum.Material1].Initialize(material1);
			_profileSections[(int)ProfileSectionEnum.Material2].Initialize(material2);
		}

		public ProfileSection GetProfileSection(ProfileSectionEnum profileSection)
		{
			return _profileSections[(int)profileSection];
		}

		#endregion

		#region XML

		#endregion

	} // End class.
} // End namespace.