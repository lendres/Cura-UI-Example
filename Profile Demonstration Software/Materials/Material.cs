using System.Collections.Generic;
using System.Xml.Serialization;

namespace ProfileDemo.Materials
{
	class Material
	{
		#region Members

		private double				_temperature;
		private double				_coolDownModifier;
		private double				_flow;


		#endregion

		#region Construction

		/// <summary>
		/// Default constructor.
		/// </summary>
		public Material()
		{
		}

		#endregion

		#region Properties

		/// <summary>
		/// Primary printing temperature in Celcius.
		/// </summary>
		[XmlAttribute("datamode")]
		public double Temperature
		{
			get
			{
				return _temperature;
			}

			set
			{
				_temperature = value;
			}
		}

		/// <summary>
		/// Cool down modifier in degrees Celcius per second.
		/// </summary>
		[XmlAttribute("cooldownmodifier")]
		public double CoolDownModifier
		{
			get
			{
				return _coolDownModifier;
			}

			set
			{
				_coolDownModifier = value;
			}
		}

		/// <summary>
		/// Flow rate as a percent (0 = 100).
		/// </summary>
		[XmlAttribute("flow")]
		public double Flow
		{
			get
			{
				return _flow;
			}

			set
			{
				_flow = value;
			}
		}

		#endregion

	} // End class.
}  // End namespace.
