using System;

namespace ProfileDemo
{
	/// <summary>
	/// 
	/// </summary>
	public class Property
	{
		#region Members

        private string				_name;
        private double				_value;

		#endregion

		#region Construction

		/// <summary>
		/// Default constructor.
		/// 
		/// Required for serialization.
		/// </summary>
        public Property()
		{
		}


		/// <summary>
		/// Default constructor.
		/// 
		/// Required for serialization.
		/// </summary>
        public Property(string name, double value)
		{
			_name = name;
			_value = value;
		}
		

        #endregion

        #region Properties

        /// <summary>
        /// The name shown on the setup page.
        /// </summary>
        public string Name
		{
			get => _name;
			set => _name = value;
		}

        /// <summary>
        /// The value of the property.  For simplicity sake of the demonstration we assume
        /// everything is a double.  In practice you would also need int and bool types.
        /// </summary>
        public double Value
		{
			get => _value;
			set => _value = value;
		}
        
        #endregion

        #region Functions



        #endregion

        #region XML

        #endregion

    } // End class.
} // End namespace.