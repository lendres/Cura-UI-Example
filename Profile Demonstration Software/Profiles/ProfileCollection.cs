using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Xml.Serialization;
using DigitalProduction.XML.Serialization;

namespace CuraProfileDemonstration
{

	/// <summary>
	/// Container for Profiles.
	/// 
	/// This class is fairly dumb.  It is only meant to act as a container and have a few convenient functions/methods.
	/// </summary>
	public class ProfileCollection
	{
		#region Members

        private List<Profile>           _profiles           = new List<Profile>();

		#endregion

		#region Construction

		/// <summary>
		/// Default constructor.
		/// </summary>
		public ProfileCollection()
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

		/// <summary>
		/// Get a list of the names of the profiles.
		/// </summary>
		[XmlIgnore()]
		public List<string> ProfileNames
		{
			get
			{
				List<string> names = new List<string>();

				foreach (Profile profile in _profiles)
				{
					names.Add(profile.Name);
				}

				return names;
			}
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

		/// <summary>
		/// Get a profile by name.
		/// </summary>
		/// <param name="name">Profile name.</param>
		public Profile GetProfile(string name)
		{
			foreach (Profile profile in _profiles)
			{
				if (profile.Name == name)
				{
					return profile;
				}
			}

			throw new System.Exception("Profile not found.");
		}

		#endregion

		#region XML

		/// <summary>
		/// Deserializes all the files of a specific file type in a directory.  Those files are converted to a SettingsGroup on a one-to-one basis.
		/// </summary>
		/// <param name="path">Directory to deserialize from.</param>
		/// <param name="fileExtension">File extension of the files to deserialize.</param>
		public static ProfileCollection Deserialize(string path, string fileExtension)
		{
			ProfileCollection profileGroup = new ProfileCollection();

			List<string> files = Directory.EnumerateFiles(path, "*.*", SearchOption.TopDirectoryOnly).Where(s => Path.GetExtension(s).ToLowerInvariant() == fileExtension).ToList();

			foreach (string file in files)
			{
				Profile profile = Serialization.DeserializeObject<Profile>(Path.Combine(path, file));
				profileGroup._profiles.Add(profile);
			}

			return profileGroup;
		}

		/// <summary>
		/// Serialize all the SettingsGroups into separate files.
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