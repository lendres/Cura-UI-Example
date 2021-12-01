using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Xml.Serialization;

namespace CuraProfileDemonstration.Profiles
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

		private SettingGroupCollection<Material>				_materials				= new SettingGroupCollection<Material>();

		#endregion

		#region Construction

		/// <summary>
		/// Default constructor.
		/// </summary>
		public Manager()
		{
		}

		#endregion

		#region Properties

		#endregion

		#region Methods

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
		}

		#endregion

		#region XML

		#endregion

	} // End class.
} // End namespace.