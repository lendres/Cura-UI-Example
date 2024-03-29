﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using DigitalProduction.XML.Serialization;
using DigitalProduction.SystemDpm;

namespace CuraProfileDemonstration
{
	/// <summary>
	/// 
	/// </summary>
	public abstract class Serializable : UniqueId
	{
		#region Members

		private string									_name;
		
		// This is the location of the project file that this file was serialized from and will be serialized to.
		protected string								_fullPath							= "";

		#endregion

		#region Construction

		/// <summary>
		/// Default constructor.
		/// </summary>
		public Serializable()
		{
		}

		#endregion

		#region Properties

		/// <summary>
		/// Name or title of this setting group.
		/// </summary>
		[XmlAttribute("name")]
		public string Name
		{
			get => _name;
			set => _name = value;
		}

		#endregion

		#region Methods

		/// <summary>
		/// File extension for serialization.
		/// </summary>
		public abstract string GetFileExtension();

		#endregion

		#region XML

		///// <summary>
		///// Create an instance from a file.
		///// </summary>
		///// <param name="path">The file to read from.</param>
		//protected static T Deserialize<T>(string path) where T : Serializable
		//{
		//	T serial		= Serialization.DeserializeObject<T>(path);

		//	serial._path	= path;

		//	return serial;
		//}

		/// <summary>
		/// Serialize to the location that the object was deserialized from.
		/// 
		/// To use this, the _fullPath (directory, file name, and file extension) must be set when the object is deserialized.
		/// </summary>
		public void Serialize()
		{
			Serialization.SerializeObject(this, _fullPath);
		}

		/// <summary>
		/// Main work of serialization.
		/// </summary>
		public void Serialize(string path)
		{
			Serialization.SerializeObject(this, Path.Combine(path, _name) + this.GetFileExtension());
		}

		#endregion

	} // End class.
} // End namespace.