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

		public static string				FileExtension			= ".profile";

		private List<Override>				_overrides				= new List<Override>();

		#endregion

		#region Construction

		/// <summary>
		/// Default constructor.
		/// </summary>
		public Profile()
		{
			for (int i = 0; i < (int)OverrideEnum.Length; i++)
			{
				_overrides.Add(new Override());
			}

//			_overrides[(int)OverrideEnum.Material1].OverrideSettingGroup = new Material();
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
		[XmlArray("overrides"), XmlArrayItem("override")]
		public List<Override> Overrides
		{
			get => _overrides;
			set => _overrides = value;
		}


		#endregion

		#region Methods

		/// <summary>
		/// File extension for serialization.
		/// </summary>
		public override string GetFileExtension()
		{
			return Profile.FileExtension;
		}

		public void Initialize(Material material1, Material material2)
		{
			_overrides[(int)OverrideEnum.Material1].Initialize(material1);
			_overrides[(int)OverrideEnum.Material2].DefaultSettingGroupId = material2.Id;
		}

		#endregion

		#region XML

		#endregion

	} // End class.
} // End namespace.