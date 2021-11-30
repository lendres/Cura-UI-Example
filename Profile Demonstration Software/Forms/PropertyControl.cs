using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProfileDemo
{
	public partial class PropertyControl : UserControl
	{
		#region Members

		private int				_index;

		#endregion

		#region Construction

		public PropertyControl()
		{
			InitializeComponent();
		}

		/// <summary>
		/// Index of this control on the form.  Used to access the properties.
		/// </summary>
		[Category("Cura")]
		public int Index
		{
			get => _index;
			set => _index = value;
		}

		#endregion

		#region Properties

		#endregion

	} // End class.
} // End namespace.
