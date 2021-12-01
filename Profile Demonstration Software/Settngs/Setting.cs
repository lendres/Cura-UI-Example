using System;
using System.Xml.Serialization;

namespace CuraProfileDemonstration
{
	/// <summary>
	/// 
	/// </summary>
	public class Setting
	{
		#region Members

        private string				_name					= "";
        private double				_value					= 0;

		// This is a short cut so we don't have to create two types of settings.  This is only used by the setting stored in the profile.
		// The setting stored in the library does not make use of this member.
		private bool				_override				= false;

		#endregion

		#region Construction

		/// <summary>
		/// Default constructor.
		/// 
		/// Required for serialization.
		/// </summary>
        public Setting()
		{
		}

		/// <summary>
		/// Default constructor.
		/// 
		/// Required for serialization.
		/// </summary>
        public Setting(string name)
		{
			_name		= name;
			_value		= 0;
			_override	= false;
		}

		/// <summary>
		/// Default constructor.
		/// 
		/// Required for serialization.
		/// </summary>
        public Setting(string name, double value)
		{
			_name		= name;
			_value		= value;
			_override	= false;
		}

        #endregion

        #region Properties

        /// <summary>
        /// The name shown on the setup page.
        /// </summary>
		[XmlAttribute("name")]
        public string Name
		{
			get => _name;
			set => _name = value;
		}

        /// <summary>
        /// The value of the property.  For simplicity sake of the demonstration we assume
        /// everything is a double.  In practice you would also need int and bool types.
        /// </summary>
		[XmlAttribute("value")]
        public double Value
		{
			get => _value;
			set => _value = value;
		}

		/// <summary>
		/// Specified is the setting should be override by the value stored in the profile.  If the setting is
		/// not overriden, the value stored in the library is used.
		/// </summary>
		[XmlAttribute("override")]
		public bool Override
		{
			get => _override;
			set => _override = value;
		}

		#endregion

		#region Methods



		#endregion

		#region XML

		#endregion

	} // End class.
} // End namespace.