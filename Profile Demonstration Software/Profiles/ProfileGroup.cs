using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Xml.Serialization;
using DigitalProduction.XML.Serialization;

namespace CuraProfileDemonstration
{

	/// <summary>
	/// Container for Profiles.
	/// </summary>
	public class ProfileGroup
	{
		#region Members

        private List<Profile>           _profiles           = new List<Profile>();
        private string                  _path;

		#endregion

		#region Construction

		/// <summary>
		/// Default constructor.
		/// </summary>
		public ProfileGroup()
		{
		}

		#endregion

		#region Properties

        /// <summary>
		/// Profiles.
		/// </summary>
		[XmlArray("profiles"), XmlArrayItem("profile")]
		public List<Profile> Profiles
		{
			get => _profiles;
			set => _profiles = value;
		}

		#endregion

		#region Methods

		/// <summary>
		/// Add a Profile to the collection.
		/// </summary>
		/// <param name="profile">The Profile to add.</param>
		public void Add(Profile profile)
		{
			_profiles.Add(profile);
		}

		#endregion

		#region XML

		/// <summary>
		/// Deserializes all the files of a specific file type in a directory.  Those files are converted to a SettingGroup on a one-to-one basis.
		/// </summary>
		/// <param name="path">Directory to deserialize from.</param>
		/// <param name="fileExtension">File extension of the files to deserialize.</param>
		public static ProfileGroup Deserialize(string path, string fileExtension)
		{
			ProfileGroup profileGroup = new ProfileGroup();

			List<string> files = Directory.EnumerateFiles(path, "*.*", SearchOption.TopDirectoryOnly).Where(s => Path.GetExtension(s).ToLowerInvariant() == fileExtension).ToList();

			foreach (string file in files)
			{
				Profile profile = Serialization.DeserializeObject<Profile>(Path.Combine(path, file));
				profileGroup._profiles.Add(profile);
			}

			return profileGroup;
		}

		/// <summary>
		/// Serialize all the SettingGroups into separate files.
		/// </summary>
		/// <param name="path">Directory to serialize to.</param>
		public void Serialize(string path)
		{
			foreach (Profile profile in _profiles)
			{
				profile.Serialize(path);
			}
		}

		#endregion

	} // End class.
} // End namespace.