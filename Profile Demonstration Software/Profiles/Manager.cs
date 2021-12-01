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
	public class Manager
	{
		#region Enumerations

		#endregion

		#region Delegates

		#endregion

		#region Events

		#endregion

		#region Members

		private static string								_libraryPath;

		private SettingGroupCollection<Material>			_materials				= new SettingGroupCollection<Material>();

		#endregion

		#region Construction

		/// <summary>
		/// Default constructor.
		/// </summary>
		public Manager()
		{
			_libraryPath =  Path.Combine(DigitalProduction.Reflection.Assembly.Path(), "Libraries\\");
			if (!Directory.Exists(_libraryPath))
			{
				Directory.CreateDirectory(_libraryPath);
				CreateInitialLibrary();
			}

			ReadLibraries();
		}

		#endregion

		#region Properties

		#endregion

		#region Methods

		public void ReadLibraries()
		{
			_materials = SettingGroupCollection<Material>.Deserialize(_libraryPath, Material.FileExtension);
		}

		/// <summary>
		/// This function is only to be used to write an initial set of library files.  It should be used
		/// carefully as it will over write existing data.
		/// </summary>
		public void CreateInitialLibrary()
		{
			_materials.Add(new Material("PLA 1"));
			_materials.Add(new Material("PLA 2"));
			_materials.Add(new Material("Breakaway"));
			_materials.Add(new Material("PVA"));
			_materials.Add(new Material("PETG"));

			_materials.Serialize(_libraryPath);
		}

		#endregion

		#region XML

		#endregion

	} // End class.
} // End namespace.