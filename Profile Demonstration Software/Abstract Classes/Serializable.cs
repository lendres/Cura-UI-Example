﻿using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using DigitalProduction.XML.Serialization;

namespace CuraProfileDemonstration
{
	/// <summary>
	/// 
	/// </summary>
	public abstract class Serializable : UniqueId
	{
		#region Members

		// This is the location of the project file that this file was serialized from and will be serialized to.
		protected string								_path							= "";

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

		#endregion

		#region Methods

		#endregion

		#region XML

		/// <summary>
		/// Create an instance from a file.
		/// </summary>
		/// <param name="path">The file to read from.</param>
		protected static T Deserialize<T>(string path) where T : Serializable
		{
			T serial		= Serialization.DeserializeObject<T>(path);

			serial._path	= path;

			return serial;
		}

		/// <summary>
		/// Main work of serialization.
		/// </summary>
		public void Serialize(string path)
		{
			Serialization.SerializeObject(this, path);
		}

		#endregion

	} // End class.
} // End namespace.