using System;
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

		private Setting					_defaultSetting;
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
		private void TextBoxValue_Leave(object sender, EventArgs e)
		{
			_overrideSetting.Value = this.textBoxValue.Text;
		}

		/// <summary>
		/// Override setting or not.  Also stores the value in the data container.
		/// </summary>
		/// <param name="sender">Sender.</param>
		/// <param name="eventArgs">Event arguments.</param>
		private void CheckBoxOverride_CheckedChanged(object sender, EventArgs eventArgs)
		{
			SetControls();
			_overrideSetting.Override = this.checkBoxOverride.Checked;
		}

		/// <summary>
		/// Save the override back to the library and establish it as the default.
		/// </summary>
		/// <param name="sender">Sender.</param>
		/// <param name="eventArgs">Event arguments.</param>
		private void buttonSaveProfile_Click(object sender, EventArgs e)
		{
			DialogResult dialogResult  = MessageBox.Show(this, "Saving this setting can effect other profiles.  Continue?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

			if (dialogResult == DialogResult.Yes)
			{
				_defaultSetting.Value = this.textBoxValue.Text;
				_defaultSetting.Parent.Serialize();
				this.checkBoxOverride.Checked = false;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// Initial the control.
		/// </summary>
		/// <param name="defaultSettingsGroup">The group of settings that are in the library.</param>
		/// <param name="overrideSettingsGroup">The group of settings that are the overrides.</param>
		public void Initialize(SettingsGroup defaultSettingsGroup, SettingsGroup overrideSettingsGroup)
		{
			// Save setting and override for use.
			_defaultSetting					= defaultSettingsGroup.GetProperty(_index);
			_overrideSetting				= overrideSettingsGroup.GetProperty(_index);

			// Set up the label with the name of the property.
			this.labelName.Text				= _defaultSetting.Name;

			this.checkBoxOverride.Checked	= _overrideSetting.Override;

			SetControls();
		}

		/// <summary>
		/// Sets the states and values of the check box and text box.
		/// </summary>
		private void SetControls()
		{
			bool enabled = this.checkBoxOverride.Checked;

			this.textBoxValue.Enabled = enabled;

			if (enabled)
			{
				this.textBoxValue.Text  = _overrideSetting.Value;
			}
			else
			{
				this.textBoxValue.Text  = _defaultSetting.Value;
			}
		}

		#endregion

	} // End class.
} // End namespace.
