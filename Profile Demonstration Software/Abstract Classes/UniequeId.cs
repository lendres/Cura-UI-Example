using System;
using System.Xml.Serialization;

namespace CuraProfileDemonstration
{
	/// <summary>
	/// An item that needs to have a unique id.  Specifically, this is useful for when an instance of
	/// a class has to have an unique ID unique.  This is useful for when you want to allow the common
	/// name (presented to a user) to be changed by the user, but still need to be able to cross reference
	/// items internally.
	/// </summary>
	public abstract class UniqueId : IEquatable<UniqueId>
	{
		#region Members

		// Identification.
		private Guid						_id;

		#endregion

		#region Construction

		/// <summary>
		/// Default constructor.
		/// </summary>
		protected UniqueId()
		{
			_id	= Guid.NewGuid();
		}

		/// <summary>
		/// Default constructor.
		/// </summary>
		protected UniqueId(UniqueId uniqueId)
		{
			_id	= uniqueId._id;
		}

		#endregion

		#region Properties

		/// <summary>
		/// Id.
		/// </summary>
		[XmlAttribute("id")]
		public Guid Id
		{
			get => _id;
			set => _id = value;
		}

		#endregion

		#region Equality Interface Implementation

		/// <summary>
		/// Checks equality to an object.
		/// </summary>
		/// <param name="obj">Object to compare to.</param>
		public override bool Equals(object obj)
		{
			// If parameter is null return false.
			if (obj == null)
			{
				return false;
			}

			// If parameter cannot be cast, return false.
			UniqueId objAsUniqueId = obj as UniqueId;
			if (objAsUniqueId == null)
			{
				return false;
			}

			// Return true if the fields match:
			return this.Id == objAsUniqueId.Id;
		}

		/// <summary>
		/// Checks equality to another instance.
		/// </summary>
		/// <param name="material">Instance to compare to.</param>
		public bool Equals(UniqueId material)
		{
			// If parameter is null return false:
			if ((object)material == null)
			{
				return false;
			}

			// Return true if the fields match:
			return this.Id == material.Id;
		}

		/// <summary>
		/// Get a hash code of the object.
		/// </summary>
		public override int GetHashCode()
		{
			return this.Id.GetHashCode();
		}

		/// <summary>
		/// Operator overload.
		/// </summary>
		/// <param name="leftHandSide">Instance on the left hand side of operator.</param>
		/// <param name="rightHandSide">Instance on the right hand side of operator.</param>
		public static bool operator==(UniqueId leftHandSide, UniqueId rightHandSide)
		{
			// If both are null, or both are same instance, return true.
			if (System.Object.ReferenceEquals(leftHandSide, rightHandSide))
			{
				return true;
			}

			// If one is null, but not both, return false.
			if (((object)leftHandSide == null) || ((object)rightHandSide == null))
			{
				return false;
			}

			// Return true if the fields match:
			return leftHandSide.Id == rightHandSide.Id;
		}

		/// <summary>
		/// Operator overload.
		/// </summary>
		/// <param name="leftHandSide">Instance on the left hand side of operator.</param>
		/// <param name="rightHandSide">Instance on the right hand side of operator.</param>
		public static bool operator!=(UniqueId leftHandSide, UniqueId rightHandSide)
		{
			return !(leftHandSide == rightHandSide);
		}

		/// <summary>
		/// Override the conversion to a string.
		/// </summary>
		public override string ToString()
		{
			return this.Id.ToString();
		}

		#endregion

	} // End class.
} // End namespace.