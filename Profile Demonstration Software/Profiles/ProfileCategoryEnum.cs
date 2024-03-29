﻿using System.ComponentModel;

namespace CuraProfileDemonstration
{
	/// <summary>
	/// A ProfileCategory is unique.  It consists of a default file and a SettingGroup that are overrides of the default values.  It is
	/// abstract.  A ProfileSection is an instance of a ProfileCategory.  There can be multiple ProfileSections of the same ProfileCategory.
	/// 
	/// The "Description" attribute can be accessed using Reflection to get a string representing the enumeration type.
	/// 
	/// The "Length" enumeration can be used in loops as a convenient way of terminating a loop that does not have to be changed if
	/// the number of items in the enumeration changes.  The "Length" enumeration must be the last item.
	/// for (int i = 0; i &lt; (int)EnumType.Length; i++) {...}
	/// </summary>
	public enum ProfileCategoryEnum
	{
		/// <summary>Cooling.</summary>
		[Description("Cooling")]
		Cooling,

		/// <summary>Material.</summary>
		[Description("Material")]
		Material,

		/// <summary>Support.</summary>
		[Description("Support")]
		Support,

		/// <summary>Walls.</summary>
		[Description("Walls")]
		Walls,

		/// <summary>The number of types/items in the enumeration.</summary>
		[Description("Length")]
		Length

	} // End enum.
} // End namespace.