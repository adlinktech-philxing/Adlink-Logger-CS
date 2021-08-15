using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Media;
using Microsoft.Win32;

namespace Adlink_Logger_CS
{
    public partial class Form1 : Form
    {
        public const string APP_KEY							="Logger";
        public const string APP_VERSION_VALUE   			="AppVersion";
        public const string APP_REGISTRY_VERSION			="0.2";

        public const string COMPANY_NAME				    ="ADLink";

        public const string VALUE_MESSAGE_TYPE_TAG          ="MessageTypeTag";
        public const string VALUE_MESSAGE_TYPE_MARK         ="MessageTypeMark";
        public const string VALUE_MESSAGE_TYPE_MESSAGE      ="MessageTypeMessage";
        public const string VALUE_BIOS_TYPE_CRB             ="BiosTypeCrb";
        public const string VALUE_BIOS_TYPE_STANDARD        ="BiosTypeStandard";
        public const string VALUE_BIOS_TYPE_CUSTOMIZED      ="BiosTypeCustomized";
        public const string VALUE_PROJECT_NAME              ="ProjectName";
        public const string VALUE_CUSTOMER_NAME				="CustomerName";
        public const string VALUE_BIOS_VERSION				="BiosVersion";
        public const string VALUE_MODIFY_TYPE_BF            ="ModifyTypeBugFix";
        public const string VALUE_MODIFY_TYPE_FA            ="ModifyTypeFunctionAdd";
        public const string VALUE_MODIFY_TYPE_FD            ="ModifyTypeFunctionRemove";
        public const string VALUE_ISSUE_NUMBER				="IssueNumber";
        public const string VALUE_SUMMARY					="Summary";
        public const string VALUE_SIGNATURE_CHECKED			="SignatureChecked";
        public const string VALUE_SIGNATURE_AUTHOR			="SignatureAuthor";
        public const string VALUE_SIGNATURE_DATE			="SignatureDate";
        public const string VALUE_SIGNATURE_SERIAL_NUM		="SignatureSerialNumber";
        public const string VALUE_DESCRIPTION				="Description";
        public const string VALUE_TEST_CASE					="TestCase";
        public const string VALUE_MODIFY_FILES				="ModifyFiles";

        public const string FORM_LOCATION_VALUE			    ="FormLocationV";
        public const string FORM_LOCATION_X_VALUE			="FormLocationXV";
        public const string FORM_LOCATION_Y_VALUE			="FormLocationYV";

        public const string PROJECT_NAME_KEY				="ProjectName";
        public const    int MAX_PROJECT_NAME_SAVED			=5;

        public Form1()
        {
            InitializeComponent();
			RestoreSettings();
		}

		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			SaveSettings();
		}
		private void SaveComboSettings(RegistryKey appKey, string keyName, System.Windows.Forms.ComboBox comboBox)
		{
			string keyNameIndex = keyName + "_Index";
			RegistryKey subKey = appKey.OpenSubKey(keyName, true);
			if (subKey != null)
			{
				appKey.DeleteSubKeyTree(keyName);
			}
			subKey = appKey.CreateSubKey(keyName);
			for (int i = 0; i < comboBox.Items.Count && i < MAX_PROJECT_NAME_SAVED; i++)
			{
				comboBox.SelectedIndex = i;
				subKey.SetValue(i.ToString(), comboBox.Text);
			}
		}

		private void SaveSettings()
		{
			RegistryKey appKey = Registry.CurrentUser.CreateSubKey("Software\\" + COMPANY_NAME + "\\" + APP_KEY);

			appKey.SetValue(VALUE_MESSAGE_TYPE_TAG, radioButtonTag.Checked);
			appKey.SetValue(VALUE_MESSAGE_TYPE_MARK, radioButtonMark.Checked);
			appKey.SetValue(VALUE_MESSAGE_TYPE_MESSAGE, radioButtonMessage.Checked);
			appKey.SetValue(VALUE_BIOS_TYPE_CRB, radioButtonCrb.Checked);
			appKey.SetValue(VALUE_BIOS_TYPE_STANDARD, radioButtonCrb.Checked);
			appKey.SetValue(VALUE_BIOS_TYPE_CUSTOMIZED, radioButtonCustomized.Checked);
			appKey.SetValue(VALUE_PROJECT_NAME, comboBoxProjectName.Text);
			appKey.SetValue(VALUE_CUSTOMER_NAME, textBoxCustomerName);
			appKey.SetValue(VALUE_BIOS_VERSION, textBoxBiosVersion);
			appKey.SetValue(VALUE_MODIFY_TYPE_BF, radioButtonBugFix.Checked);
			appKey.SetValue(VALUE_MODIFY_TYPE_FA, radioButtonFunctionAdd.Checked);
			appKey.SetValue(VALUE_MODIFY_TYPE_FD, radioButtonFunctionRemove.Checked);
			appKey.SetValue(VALUE_ISSUE_NUMBER, textBoxIssueNumber.Text);
			appKey.SetValue(VALUE_SUMMARY, textBoxSummary.Text);
			appKey.SetValue(VALUE_SIGNATURE_CHECKED, checkBoxSignature.Checked);
			appKey.SetValue(VALUE_SIGNATURE_AUTHOR, textBoxAuthor.Text);
			appKey.SetValue(VALUE_SIGNATURE_DATE, textBoxDate.Text);
			appKey.SetValue(VALUE_SIGNATURE_SERIAL_NUM, textBoxSerialNumber.Text);
			appKey.SetValue(VALUE_DESCRIPTION, textBoxDescription.Text);
			appKey.SetValue(VALUE_TEST_CASE, textBoxTestCase.Text);
			appKey.SetValue(VALUE_MODIFY_FILES, textBoxModifyFiles.Text);
			//
			// Save comboBox Lists
			// 
			SaveComboSettings(appKey, PROJECT_NAME_KEY, comboBoxProjectName);
			//
			// Save form layout
			//
			//appKey.SetValue(FORM_LOCATION_X_VALUE, formLocation.X);
			//appKey.SetValue(FORM_LOCATION_Y_VALUE, formLocation.Y);
			appKey.SetValue(FORM_LOCATION_VALUE, this.Location);
			//
			// Save Category List File Name
			//
			//appKey.SetValue(VALUE_CATEGORY_LIST_FILE, fileCategory);
		}

		private void RestoreComboSettings(RegistryKey appKey, string keyName, System.Windows.Forms.ComboBox comboBox)
		{
			RegistryKey subKey = appKey.OpenSubKey(keyName);
			if (subKey != null)
			{
				for (int i = 0; i < MAX_PROJECT_NAME_SAVED; i++)
				{
					string PathName = (string)subKey.GetValue(i.ToString());
					if (String.IsNullOrEmpty(PathName)) break;
					comboBox.Items.Add(PathName);
				}
			}
		}

		private void RestoreSettings()
		{
			//
			// Retrieve Registry keys
			//
			RegistryKey appKey = Registry.CurrentUser.OpenSubKey("Software\\" + COMPANY_NAME + "\\" + APP_KEY);
			if (appKey == null)
			{
				Registry.SetValue("HKEY_CURRENT_USER\\Software\\" + COMPANY_NAME + "\\" + APP_KEY, APP_VERSION_VALUE, APP_REGISTRY_VERSION);
				return;
			}
			string Str = (string)appKey.GetValue(APP_VERSION_VALUE, "0.0");
			if (String.Compare(APP_REGISTRY_VERSION, Str) != 0)
			{
				RegistryKey appFamilyKey = Registry.CurrentUser.OpenSubKey("Software\\" + COMPANY_NAME, true);
				appFamilyKey.DeleteSubKeyTree(APP_KEY);
				Registry.SetValue("HKEY_CURRENT_USER\\Software\\" + COMPANY_NAME + "\\" + APP_KEY, APP_VERSION_VALUE, APP_REGISTRY_VERSION);
				return;
			}

			//
			// Restore comboBox Lists
			//
			RestoreComboSettings(appKey, PROJECT_NAME_KEY, comboBoxProjectName);
			//
			// Restore Contexts
			//
			radioButtonTag.Checked = Convert.ToBoolean(appKey.GetValue(VALUE_MESSAGE_TYPE_TAG, ""));
			radioButtonMark.Checked = Convert.ToBoolean(appKey.GetValue(VALUE_MESSAGE_TYPE_MARK, ""));
			radioButtonMessage.Checked = Convert.ToBoolean(appKey.GetValue(VALUE_MESSAGE_TYPE_MESSAGE, ""));
			radioButtonCrb.Checked = Convert.ToBoolean(appKey.GetValue(VALUE_BIOS_TYPE_CRB, ""));
			radioButtonCrb.Checked = Convert.ToBoolean(appKey.GetValue(VALUE_BIOS_TYPE_STANDARD, ""));
			radioButtonCustomized.Checked = Convert.ToBoolean(appKey.GetValue(VALUE_BIOS_TYPE_CUSTOMIZED, ""));
			comboBoxProjectName.Text = (string) appKey.GetValue(VALUE_PROJECT_NAME, "");
			textBoxCustomerName.Text = (string)appKey.GetValue(VALUE_CUSTOMER_NAME, "");
			textBoxBiosVersion.Text = (string)appKey.GetValue(VALUE_BIOS_VERSION, "");
			radioButtonBugFix.Checked = Convert.ToBoolean(appKey.GetValue(VALUE_MODIFY_TYPE_BF, ""));
			radioButtonFunctionAdd.Checked = Convert.ToBoolean(appKey.GetValue(VALUE_MODIFY_TYPE_FA, ""));
			radioButtonFunctionRemove.Checked = Convert.ToBoolean(appKey.GetValue(VALUE_MODIFY_TYPE_FD, ""));
			textBoxIssueNumber.Text = (string) appKey.GetValue(VALUE_ISSUE_NUMBER, "");
			textBoxSummary.Text = (string) appKey.GetValue(VALUE_SUMMARY, "");
			checkBoxSignature.Checked = Convert.ToBoolean(appKey.GetValue(VALUE_SIGNATURE_CHECKED, ""));
			textBoxAuthor.Text = (string) appKey.GetValue(VALUE_SIGNATURE_AUTHOR, "");
			textBoxDate.Text = (string) appKey.GetValue(VALUE_SIGNATURE_DATE, "");
			textBoxSerialNumber.Text = (string)appKey.GetValue(VALUE_SIGNATURE_SERIAL_NUM, "");
			textBoxDescription.Text = (string) appKey.GetValue(VALUE_DESCRIPTION, "");
			textBoxTestCase.Text = (string) appKey.GetValue(VALUE_TEST_CASE, "");
			textBoxModifyFiles.Text = (string)appKey.GetValue(VALUE_MODIFY_FILES, "");
			//
			// Restore form layout
			//
			//formLocation.X = (Int32)appKey.GetValue(FORM_LOCATION_X_VALUE, this.Location.X);
			//formLocation.Y = (Int32)appKey.GetValue(FORM_LOCATION_Y_VALUE, this.Location.Y);
			//formLocation = (System.Drawing.Point)appKey.GetValue(FORM_LOCATION_X_VALUE, this.Location);
		}

		private void Form1_Load(object sender, EventArgs e)
        {
            EnableControls(sender, e);
        }

        private void EnableControls(object sender, EventArgs e)
        {
            this.comboBoxProjectName.Enabled = !(this.radioButtonTag.Checked && this.radioButtonCrb.Checked);
            this.textBoxCustomerName.Enabled = this.radioButtonCustomized.Checked && !(this.radioButtonMark.Checked);
            this.textBoxBiosVersion.Enabled = !(this.radioButtonMark.Checked) && !(this.radioButtonMessage.Checked);

            this.groupBoxModification.Enabled = this.radioButtonMessage.Checked || this.radioButtonMark.Checked;

            this.textBoxIssueNumber.Enabled = this.radioButtonMessage.Checked;
            this.textBoxSummary.Enabled = this.radioButtonMessage.Checked || this.radioButtonMark.Checked;

            this.groupBoxSignature.Enabled = this.checkBoxSignature.Checked;

            this.textBoxDescription.Enabled = this.radioButtonMessage.Checked;
            this.textBoxTestCase.Enabled = this.radioButtonMessage.Checked;
            this.textBoxModifyFiles.Enabled = this.radioButtonMessage.Checked;

            this.groupBoxSignature.Enabled = this.checkBoxSignature.Checked;
        }

		private string exportLog()
		{
			string strLog = "";

			if (this.comboBoxProjectName.Enabled)
			{
				if (this.radioButtonTag.Checked)
				{
					strLog = comboBoxProjectName.Text + "_";
				}
				else
				{
					strLog = "[" + comboBoxProjectName.Text + "]";
				}
			}
			if (this.textBoxCustomerName.Enabled)
			{
				strLog = strLog + textBoxCustomerName.Text + "_";
			}
			if (this.textBoxBiosVersion.Enabled)
			{
				strLog = strLog + textBoxBiosVersion.Text;
			}

			if (this.groupBoxModification.Enabled)
			{
				if (this.radioButtonBugFix.Checked)
				{
					strLog = strLog + "[B]";
				}
				if (this.radioButtonFunctionAdd.Checked)
				{
					strLog = strLog + "[FA]";
				}
				if (this.radioButtonFunctionRemove.Checked)
				{
					strLog = strLog + "[FD]";
				}
			}

			if (this.textBoxIssueNumber.Enabled)
			{
				if (!(System.String.IsNullOrEmpty(textBoxIssueNumber.Text)))
				{
					strLog = strLog + "Fix Jira:" + textBoxIssueNumber.Text;
				}
			}
			if (this.textBoxSummary.Enabled)
			{
				strLog = strLog + " " + textBoxSummary.Text;
			}

			if (this.groupBoxSignature.Enabled)
			{
				strLog = strLog + "\r\n\r\nSignature:";
				if (!(System.String.IsNullOrEmpty(groupBoxSignature.Text)))
				{
					strLog = strLog + " <ADLINK-" + textBoxAuthor.Text + textBoxDate.Text + "_" + textBoxSerialNumber.Text + ">";
				}
			}
			if (this.textBoxDescription.Enabled)
			{
				strLog = strLog + "\r\n\r\nDescription:";
				if (!(System.String.IsNullOrEmpty(textBoxDescription.Text)))
				{
					strLog = strLog + "\r\n  " + textBoxDescription.Text.Replace("\r\n", "\r\n  ");
				}
			}
			if (this.textBoxTestCase.Enabled)
			{
				strLog = strLog + "\r\n\r\nTest Case:";
				if (!(System.String.IsNullOrEmpty(textBoxTestCase.Text)))
				{
					strLog = strLog + "\r\n  " + textBoxTestCase.Text.Replace("\r\n", "\r\n  ");
				}
			}
			if (this.textBoxModifyFiles.Enabled)
			{
				strLog = strLog + "\r\n\r\nModify Files:";
				if (!(System.String.IsNullOrEmpty(textBoxModifyFiles.Text)))
				{
					strLog = strLog + "\r\n  " + textBoxModifyFiles.Text.Replace("\r\n", "\r\n  ");
				}
			}
			//
			// Convert to ASCII code
			//
			Encoding ascii = Encoding.ASCII;
			Encoding unicode = Encoding.Unicode;
			byte[] unicodeBytes = unicode.GetBytes(strLog);
			byte[] asciiBytes = Encoding.Convert(unicode, ascii, unicodeBytes);
			char[] asciiChars = new char[(ascii.GetCharCount(asciiBytes, 0, asciiBytes.Length))];
			ascii.GetChars(asciiBytes, 0, asciiBytes.Length, asciiChars, 0);
			string asciiString = new string(asciiChars);
			//
			// return converted string
			//
			return asciiString;
		}

		private void pictureBoxAdlinkLogo_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://tpdc-km.adlinktech.com:8090/pages/viewpage.action?pageId=21037656");
        }

        private void pictureBoxAdlinkLogo_DoubleClick(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/PhilXing/Adlink-Logger-CS");
        }

        private void buttonClipboard_Click(object sender, EventArgs e)
        {
			Clipboard.SetDataObject(exportLog());
			//
			// Sound
			//
			SystemSounds.Asterisk.Play();
			MessageBox.Show("Copy to Clipboard done!");
		}

		private void UpdateComboBox(System.Windows.Forms.ComboBox comboBox, string str, bool insert)
		{
			int index;
			if (insert)
			{
				index = comboBox.FindStringExact(str);
			}
			else
			{
				index = comboBox.FindString(str);
			}
			if (index == -1)
			{
				if (insert)
				{
					comboBox.Items.Insert(0, str);
					comboBox.SelectedIndex = 0;
				}
				else
				{
					comboBox.Text = "";
				}
			}
			else
			{
				comboBox.SelectedIndex = index;
				comboBox.Items.Insert(0, comboBox.SelectedItem);
				comboBox.Items.RemoveAt(comboBox.SelectedIndex);
				comboBox.SelectedIndex = 0;
			}
		}
		
		private void comboBoxProjectName_Leave(object sender, EventArgs e)
        {
			UpdateComboBox(comboBoxProjectName, comboBoxProjectName.Text, true);
		}

        private void textBoxAuthor_TextChanged(object sender, EventArgs e)
        {
			this.textBoxAuthor.Text = this.textBoxAuthor.Text.ToUpper();
			this.checkBoxSignature.Text = "<ADLINK-" + textBoxAuthor.Text + textBoxDate.Text + "_" + textBoxSerialNumber.Text + ">";
		}

		private void textBoxDate_TextChanged(object sender, EventArgs e)
        {
			this.checkBoxSignature.Text = "<ADLINK-" + textBoxAuthor.Text + textBoxDate.Text + "_" + textBoxSerialNumber.Text + ">";
		}

		private void textBoxSerialNumber_TextChanged(object sender, EventArgs e)
        {
			this.checkBoxSignature.Text = "<ADLINK-" + textBoxAuthor.Text + textBoxDate.Text + "_" + textBoxSerialNumber.Text + ">";
		}
		private void buttonToday_Click(object sender, EventArgs e)
        {
			DateTime localDate = DateTime.Now;
			this.textBoxDate.Text = localDate.Year.ToString("0000") + localDate.Month.ToString("00") + localDate.Day.ToString("00");
		}

    }
}
