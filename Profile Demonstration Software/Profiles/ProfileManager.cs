using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Xml.Serialization;
using System.IO;

namespace CuraProfileDemonstration
{
	/// <summary>
	/// 
	/// </summary>
	public class ProfileManager
	{
		#region Members

		public static ProfileManager						Manager;

		private static string								_libraryPath;

		private List<SettingsGroupCollection>				_librarySettingsGroups				= new List<SettingsGroupCollection>();

		private ProfileCollection							_profileCollection					= new ProfileCollection();
		private Profile										_selectedProfile;

		#endregion

		#region Construction

		/// <summary>
		/// Default constructor.
		/// </summary>
		public ProfileManager()
		{
			for (int i = 0; i < (int)ProfileCategoryEnum.Length; i++)
			{
				_librarySettingsGroups.Add(new SettingsGroupCollection());
			}

			// Used to artificially generate the library for this demonstration software.  If the directory of the files does not
			// exist, the directory is created and the files generated.  To regenerate the library, delete the directory and re-run
			// the software.
			//
			// If you have a problem reading files or similar, it is recommended to delete the library and allow it to be recreated.
			_libraryPath =  Path.Combine(DigitalProduction.Reflection.Assembly.Path(), "Libraries\\");
			if (!Directory.Exists(_libraryPath))
			{
				Directory.CreateDirectory(_libraryPath);
				CreateInitialLibrary();
			}

			// Read in the library.  Astute readers will note that if a library did not exist, we are now reading in the files generated
			// immediately above.
			ReadLibraries();

			// Global access.
			ProfileManager.Manager = this;
		}


		#endregion

		#region Properties

		/// <summary>
		/// ProfileGroup access.
		/// </summary>
		public ProfileCollection ProfileCollection
		{
			get => _profileCollection;
			set => _profileCollection = value;
		}

		/// <summary>
		/// The currently selected/active profile.
		/// </summary>
		public Profile SelectedProfile
		{
			get => _selectedProfile;
		}

		#endregion

		#region Methods

		/// <summary>
		/// Set the selected Profile.
		/// </summary>
		/// <param name="name">Name of the profile to set as the selected/active.</param>
		public void SetSelectedProfile(string name)
		{
			_selectedProfile = _profileCollection.GetProfile(name);
		}

		/// <summary>
		/// Get a SettingsGroupCollection.
		/// </summary>
		/// <param name="profileCategory">ProfileCategoryEnum.</param>
		public SettingsGroupCollection GetLibrarySettingsGroupCollection(ProfileCategoryEnum profileCategory)
		{
			return _librarySettingsGroups[(int)profileCategory];
		}

		#endregion

		#region XML

		/// <summary>
		/// Serialize one profile.
		/// </summary>
		/// <param name="profileName">Name of the profile to serialize.</param>
		public void SerializeProfile(string profileName)
		{
			_profileCollection.GetProfile(profileName).Serialize(_libraryPath);
		}

		/// <summary>
		/// Read the libraries from disk (deserialize them).
		/// </summary>
		public void ReadLibraries()
		{
			_librarySettingsGroups[(int)ProfileCategoryEnum.Cooling]		= SettingsGroupCollection.Deserialize<Cooling>(_libraryPath, Cooling.FileExtension);
			_librarySettingsGroups[(int)ProfileCategoryEnum.Material]		= SettingsGroupCollection.Deserialize<Material>(_libraryPath, Material.FileExtension);
			_librarySettingsGroups[(int)ProfileCategoryEnum.Support]		= SettingsGroupCollection.Deserialize<Support>(_libraryPath, Support.FileExtension);

			_profileCollection = ProfileCollection.Deserialize(_libraryPath, Profile.FileExtension);
		}

		/// <summary>
		/// This function is only to be used to write an initial set of library files.  It should be used
		/// carefully as it will over write existing data.
		/// </summary>
		public void CreateInitialLibrary()
		{
			SettingsGroupCollection settingsGroupCollection;

			// Create a cooling library.
			settingsGroupCollection = _librarySettingsGroups[(int)ProfileCategoryEnum.Cooling];

			settingsGroupCollection.Add(new Cooling("Max"));
			settingsGroupCollection.Add(new Cooling("Half"));

			_librarySettingsGroups[(int)ProfileCategoryEnum.Cooling].Serialize(_libraryPath);

			// Create a material library.
			settingsGroupCollection = _librarySettingsGroups[(int)ProfileCategoryEnum.Material];

			Material material1 = new Material("PLA 1", 200, 2, 100);
			Material material2 = new Material("PLA 2", 205, 1.5, 98);

			settingsGroupCollection.Add(material1);
			settingsGroupCollection.Add(material2);
			settingsGroupCollection.Add(new Material("Breakaway", 215, 1.75, 92));
			settingsGroupCollection.Add(new Material("PVA", 218, 2.2, 90));
			settingsGroupCollection.Add(new Material("PETG", 220, 2.5, 102));

			settingsGroupCollection.Serialize(_libraryPath);

			// Create a support library.
			settingsGroupCollection =  _librarySettingsGroups[(int)ProfileCategoryEnum.Support];

			settingsGroupCollection.Add(new Support("Separate Interface"));
			settingsGroupCollection.Add(new Support("All Same Material"));

			settingsGroupCollection.Serialize(_libraryPath);

			// Create some Profiles.
			Profile profile = new Profile("Profile 1");
			profile.Initialize(material1, material2);
			_profileCollection.Add(profile);

			profile = new Profile("Profile 2");
			profile.Initialize(material1, material2);
			_profileCollection.Add(profile);

			_profileCollection.Serialize(_libraryPath);
		}

		#endregion

	} // End class.
} // End namespace.