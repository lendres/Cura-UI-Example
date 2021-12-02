﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuraProfileDemonstration
{
	public partial class SettingControl : UserControl
	{
		#region Members

		private int						_index;

		private Setting					_setting;
		private Setting					_overrideSetting;

		#endregion

		#region Construction

		public SettingControl()
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

		#region Events

		/// <summary>
		/// Save the override setting when the control is exited.
		/// </summary>
		/// <param name="sender">Sender.</param>
		/// <param name="eventArgs">Event arguments.</param>
		private void textBoxValue_Leave(object sender, EventArgs e)
		{
			_overrideSetting.Value = this.textBoxValue.Text;
		}

		/// <summary>
		/// Override setting or not.  Also stores the value in the data container.
		/// </summary>
		/// <param name="sender">Sender.</param>
		/// <param name="eventArgs">Event arguments.</param>
		private void checkBoxOverride_CheckedChanged(object sender, EventArgs eventArgs)
		{
			bool enabled = this.checkBoxOverride.Checked;

			this.textBoxValue.Enabled = enabled;
			_overrideSetting.Override = enabled;

			if (enabled)
			{
				this.textBoxValue.Text  = _overrideSetting.Value;
			}
			else
			{
				this.textBoxValue.Text  = _setting.Value;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// Initial the control.
		/// </summary>
		/// <param name="settingGroup">The group of settings that are in the library.</param>
		/// <param name="overrideSettingGroup">The group of settings that are the overrides.</param>
		public void Initialize(SettingGroup settingGroup, SettingGroup overrideSettingGroup)
		{
			// Save setting and override for use.
			_setting				= settingGroup.GetProperty(_index);
			_overrideSetting		= overrideSettingGroup.GetProperty(_index);

			// Set up the label with the name of the property.
			this.labelName.Text		= _setting.Name;
		}

		#endregion

	} // End class.
} // End namespace.
