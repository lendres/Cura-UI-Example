using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuraProfileDemonstration
{
	/// <summary>
	/// Main entry point and other single instance (static) members which are program wide.  For example, the registry access.
	/// </summary>
	static class Program
	{

		#region Main

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Demostration());
		}

		#endregion

	} // End class.
} // End namespace.
