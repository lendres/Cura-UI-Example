using System;

namespace ProfileDemo
{
	/// <summary>
	/// 
	/// </summary>
	public class Property
	{
		#region Members / Variables / Delegates

        private string				_name;
        private double				_value;

		#endregion

		#region Construction

		/// <summary>
		/// Default constructor.
		/// </summary>
        public Property() { }

        #endregion

        #region Properties

        /// <summary>
        /// The name shown on the setup page.
        /// </summary>
        public string Name { get => _name; set => _name = value; }

        /// <summary>
        /// The value of the property.  For simplicity sake of the demonstration we assume
        /// everything is a double.  In practice you would also need int and bool types.
        /// </summary>
        public double Value { get => _value; set => _value = value; }
        
        #endregion

        #region Functions



        #endregion

        #region XML

        #endregion

    } // End class.
} // End namespace.