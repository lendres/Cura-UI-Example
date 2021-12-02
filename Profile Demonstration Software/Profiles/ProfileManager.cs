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
		#region Enumerations

		#endregion

		#region Delegates

		#endregion

		#region Events

		#endregion

		#region Members

		public static ProfileManager						Manager;

		private static string								_libraryPath;

		private SettingGroupCollection<Cooling>				_cooling				= new SettingGroupCollection<Cooling>();
		private SettingGroupCollection<Material>			_material				= new SettingGroupCollection<Material>();
		private SettingGroupCollection<Support>				_support				= new SettingGroupCollection<Support>();

		private ProfileGroup								_profileGroup			= new ProfileGroup();

		#endregion

		#region Construction

		/// <summary>
		/// Default constructor.
		/// </summary>
		public ProfileManager()
		{
			_libraryPath =  Path.Combine(DigitalProduction.Reflection.Assembly.Path(), "Libraries\\");
			if (!Directory.Exists(_libraryPath))
			{
				Directory.CreateDirectory(_libraryPath);
				CreateInitialLibrary();
			}

			ReadLibraries();

			// Global access.
			ProfileManager.Manager = this;
		}


		#endregion

		#region Properties

		#endregion

		#region Methods


		public void ReadLibraries()
		{
			_cooling		= SettingGroupCollection<Cooling>.Deserialize(_libraryPath, Cooling.FileExtension);
			_material		= SettingGroupCollection<Material>.Deserialize(_libraryPath, Material.FileExtension);
			_support		= SettingGroupCollection<Support>.Deserialize(_libraryPath, Support.FileExtension);

			_profileGroup	= ProfileGroup.Deserialize(_libraryPath, Profile.FileExtension);
		}

		/// <summary>
		/// This function is only to be used to write an initial set of library files.  It should be used
		/// carefully as it will over write existing data.
		/// </summary>
		public void CreateInitialLibrary()
		{
			// Create a cooling library.
			_cooling.Add(new Cooling("Max"));
			_cooling.Add(new Cooling("Half"));

			_cooling.Serialize(_libraryPath);

			// Create a material library.
			Material material1 = new Material("PLA 1");
			Material material2 = new Material("PLA 2");

			_material.Add(material1);
			_material.Add(material2);
			_material.Add(new Material("Breakaway"));
			_material.Add(new Material("PVA"));
			_material.Add(new Material("PETG"));

			_material.Serialize(_libraryPath);

			// Create a support library.
			_support.Add(new Support("Separate Interface"));
			_support.Add(new Support("All Same Material"));

			_support.Serialize(_libraryPath);



			Profile profile = new Profile("Profile 1");
			profile.Initialize(material1, material2);

			profile = new Profile("Profile 2");
			profile.Initialize(material1, material2);

			_profileGroup.Add(profile);

			_profileGroup.Serialize(_libraryPath);
		}

		#endregion

		#region XML

		#endregion

	} // End class.
} // End namespace.