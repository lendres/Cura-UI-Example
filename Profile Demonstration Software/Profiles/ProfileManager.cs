using System.Collections.Generic;
using System.IO;

namespace CuraProfileDemonstration
{
	/// <summary>
	/// Container for the profiles.
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
			_librarySettingsGroups[(int)ProfileCategoryEnum.Walls]			= SettingsGroupCollection.Deserialize<Walls>(_libraryPath, Walls.FileExtension);

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

			Cooling cooling = new Cooling("Max", 100, 50, 5);
			settingsGroupCollection.Add(cooling);
			settingsGroupCollection.Add(new Cooling("Half", 50, 10, 5));

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

			Support support = new Support("Separate Interface", 55, "Extruder 2", "Extruder 1");
			settingsGroupCollection.Add(support);
			settingsGroupCollection.Add(new Support("All Same Material", 55, "Extruder 2", "Extruder 2"));

			settingsGroupCollection.Serialize(_libraryPath);

			// Create a walls library.
			settingsGroupCollection =  _librarySettingsGroups[(int)ProfileCategoryEnum.Walls];

			Walls walls1 = new Walls("Standard Walls", 1, true, "Back");
			Walls walls2 = new Walls("Thick Walls", 1, true, "Back");
			settingsGroupCollection.Add(walls1);
			settingsGroupCollection.Add(walls2);

			settingsGroupCollection.Serialize(_libraryPath);

			// Create some Profiles.
			for (int i = 0; i < 4; i++)
			{
				Profile profile = new Profile("Profile " + (i+1).ToString());
				profile.Initialize(ProfileSectionEnum.Cooling, cooling);
				profile.Initialize(ProfileSectionEnum.Material1, material1);
				profile.Initialize(ProfileSectionEnum.Material2, material2);
				profile.Initialize(ProfileSectionEnum.Support, support);
				profile.Initialize(ProfileSectionEnum.Walls1, walls1);
				profile.Initialize(ProfileSectionEnum.Walls2, walls1);
				_profileCollection.Add(profile);
			}

			_profileCollection.Serialize(_libraryPath);
		}

		#endregion

	} // End class.
} // End namespace.