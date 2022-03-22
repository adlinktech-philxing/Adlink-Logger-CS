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
using System.Diagnostics;
using Atlassian.Jira;

namespace Adlink_Logger_CS
{
	public partial class Form1 : Form
	{
		public const string APP_KEY = "Logger";
		public const string APP_VERSION_VALUE = "AppVersion";
		public const string APP_REGISTRY_VERSION = "0.4";

		public const string COMPANY_NAME = "ADLink";

		public const string VALUE_MESSAGE_TYPE_TAG = "MessageTypeTag";
		public const string VALUE_MESSAGE_TYPE_MARK = "MessageTypeMark";
		public const string VALUE_MESSAGE_TYPE_MESSAGE = "MessageTypeMessage";
		public const string VALUE_BIOS_TYPE_CRB = "BiosTypeCrb";
		public const string VALUE_BIOS_TYPE_STANDARD = "BiosTypeStandard";
		public const string VALUE_BIOS_TYPE_CUSTOMIZED = "BiosTypeCustomized";
		public const string VALUE_PROJECT_NAME = "ProjectName";
		public const string VALUE_PROJECT_REPO = "ProjectRepo";
		public const string VALUE_CUSTOMER_NAME = "CustomerName";
		public const string VALUE_BIOS_VERSION = "BiosVersion";
		public const string VALUE_MODIFY_TYPE_BF = "ModifyTypeBugFix";
		public const string VALUE_MODIFY_TYPE_FA = "ModifyTypeFunctionAdd";
		public const string VALUE_MODIFY_TYPE_FD = "ModifyTypeFunctionRemove";
		public const string VALUE_ISSUE_NUMBER = "IssueNumber";
		public const string VALUE_SUMMARY = "Summary";
		public const string VALUE_SIGNATURE_CHECKED = "SignatureChecked";
		public const string VALUE_SIGNATURE_AUTHOR = "SignatureAuthor";
		public const string VALUE_SIGNATURE_DATE = "SignatureDate";
		public const string VALUE_SIGNATURE_SERIAL_NUM = "SignatureSerialNumber";
		public const string VALUE_DESCRIPTION = "Description";
		public const string VALUE_TEST_CASE = "TestCase";
		public const string VALUE_MODIFY_FILES = "ModifyFiles";
		public const string VALUE_JIRA_URL = "JiraURL";
		public const string VALUE_JIRA_UNAME = "JiraUName";
		public const string VALUE_JIRA_UPASSWORD = "JiraUPassword";

		public const string VALUE_COMBO_PROJECT_NAME = "ComboProjectName";
		public const string VALUE_COMBO_REPO_FOLDER = "ComboRepoFolder";

		public const int MAX_PROJECT_NAME_SAVED = 5;
		public const int LEADING_SPACE = 8;

		//
		// Jira settings
		//
		public static string JiraURL="";
		public static string JiraUName="";
		public static string JiraUPassword="";

		public Form1()
		{
			InitializeComponent();
			RestoreSettings();
		}

		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			Properties.Settings.Default.F1State = this.WindowState;
			if (this.WindowState == FormWindowState.Normal)
			{
				// save location and size if the state is normal
				Properties.Settings.Default.F1Location = this.Location;
				Properties.Settings.Default.F1Size = this.Size;
			}
			else
			{
				// save the RestoreBounds if the form is minimized or maximized!
				Properties.Settings.Default.F1Location = this.RestoreBounds.Location;
				Properties.Settings.Default.F1Size = this.RestoreBounds.Size;
			}

			// don't forget to save the settings
			Properties.Settings.Default.Save();

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
			appKey.SetValue(VALUE_BIOS_TYPE_STANDARD, radioButtonStandard.Checked);
			appKey.SetValue(VALUE_BIOS_TYPE_CUSTOMIZED, radioButtonCustomized.Checked);
			appKey.SetValue(VALUE_PROJECT_NAME, comboBoxProjectName.Text);
			appKey.SetValue(VALUE_PROJECT_REPO, comboBoxRepo.Text);
			appKey.SetValue(VALUE_CUSTOMER_NAME, textBoxCustomerName.Text);
			appKey.SetValue(VALUE_BIOS_VERSION, textBoxBiosVersion.Text);
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
			appKey.SetValue(VALUE_JIRA_URL, JiraURL);
			appKey.SetValue(VALUE_JIRA_UNAME, JiraUName);
			appKey.SetValue(VALUE_JIRA_UPASSWORD, JiraUPassword);
			//
			// Save comboBox Lists
			// 
			SaveComboSettings(appKey, VALUE_COMBO_PROJECT_NAME, comboBoxProjectName);
			SaveComboSettings(appKey, VALUE_COMBO_REPO_FOLDER, comboBoxRepo);
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
			RestoreComboSettings(appKey, VALUE_COMBO_PROJECT_NAME, comboBoxProjectName);
			RestoreComboSettings(appKey, VALUE_COMBO_REPO_FOLDER, comboBoxRepo);
			//
			// Restore Contexts
			//
			radioButtonTag.Checked = Convert.ToBoolean(appKey.GetValue(VALUE_MESSAGE_TYPE_TAG, false));
			radioButtonMark.Checked = Convert.ToBoolean(appKey.GetValue(VALUE_MESSAGE_TYPE_MARK, false));
			radioButtonMessage.Checked = Convert.ToBoolean(appKey.GetValue(VALUE_MESSAGE_TYPE_MESSAGE, true));
			radioButtonCrb.Checked = Convert.ToBoolean(appKey.GetValue(VALUE_BIOS_TYPE_CRB, false));
			radioButtonStandard.Checked = Convert.ToBoolean(appKey.GetValue(VALUE_BIOS_TYPE_STANDARD, true));
			radioButtonCustomized.Checked = Convert.ToBoolean(appKey.GetValue(VALUE_BIOS_TYPE_CUSTOMIZED, false));
			comboBoxProjectName.Text = (string)appKey.GetValue(VALUE_PROJECT_NAME, "");
			comboBoxRepo.Text = (string)appKey.GetValue(VALUE_PROJECT_REPO, "");
			textBoxCustomerName.Text = (string)appKey.GetValue(VALUE_CUSTOMER_NAME, "");
			textBoxBiosVersion.Text = (string)appKey.GetValue(VALUE_BIOS_VERSION, "");
			radioButtonBugFix.Checked = Convert.ToBoolean(appKey.GetValue(VALUE_MODIFY_TYPE_BF, true));
			radioButtonFunctionAdd.Checked = Convert.ToBoolean(appKey.GetValue(VALUE_MODIFY_TYPE_FA, false));
			radioButtonFunctionRemove.Checked = Convert.ToBoolean(appKey.GetValue(VALUE_MODIFY_TYPE_FD, false));
			textBoxIssueNumber.Text = (string)appKey.GetValue(VALUE_ISSUE_NUMBER, "");
			textBoxSummary.Text = (string)appKey.GetValue(VALUE_SUMMARY, "");
			checkBoxSignature.Checked = Convert.ToBoolean(appKey.GetValue(VALUE_SIGNATURE_CHECKED, true));
			textBoxAuthor.Text = (string)appKey.GetValue(VALUE_SIGNATURE_AUTHOR, "");
			textBoxDate.Text = (string)appKey.GetValue(VALUE_SIGNATURE_DATE, "");
			textBoxSerialNumber.Text = (string)appKey.GetValue(VALUE_SIGNATURE_SERIAL_NUM, "");
			textBoxDescription.Text = (string)appKey.GetValue(VALUE_DESCRIPTION, "");
			textBoxTestCase.Text = (string)appKey.GetValue(VALUE_TEST_CASE, "");
			textBoxModifyFiles.Text = (string)appKey.GetValue(VALUE_MODIFY_FILES, "");
			JiraURL = (string)appKey.GetValue(VALUE_JIRA_URL, "");
			JiraUName = (string)appKey.GetValue(VALUE_JIRA_UNAME, "");
			JiraUPassword = (string)appKey.GetValue(VALUE_JIRA_UPASSWORD, "");
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			if (Properties.Settings.Default.F1Size.Width == 0 || Properties.Settings.Default.F1Size.Height == 0)
			{
				// first start
				// optional: add default values
			}
			else
			{
				this.WindowState = Properties.Settings.Default.F1State;

				// we don't want a minimized window at startup
				if (this.WindowState == FormWindowState.Minimized) this.WindowState = FormWindowState.Normal;

				this.Location = Properties.Settings.Default.F1Location;
				this.Size = Properties.Settings.Default.F1Size;
			}

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

			this.textBoxDescription.Enabled = this.radioButtonMessage.Checked;
			this.textBoxTestCase.Enabled = this.radioButtonMessage.Checked;
			this.textBoxModifyFiles.Enabled = this.radioButtonMessage.Checked;

			this.checkBoxSignature.Enabled = this.radioButtonMessage.Checked;
			this.groupBoxSignature.Enabled = this.radioButtonMessage.Checked;
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
					strLog = strLog + "\r\n        " + textBoxDescription.Text.Replace("\r\n", "\r\n        ");
				}
			}
			if (this.textBoxTestCase.Enabled)
			{
				strLog = strLog + "\r\n\r\nTest Case:";
				if (!(System.String.IsNullOrEmpty(textBoxTestCase.Text)))
				{
					strLog = strLog + "\r\n        " + textBoxTestCase.Text.Replace("\r\n", "\r\n        ");
				}
			}
			if (this.textBoxModifyFiles.Enabled)
			{
				strLog = strLog + "\r\n\r\nModify Files:";
				if (!(System.String.IsNullOrEmpty(textBoxModifyFiles.Text)))
				{
					strLog = strLog + "\r\n        " + textBoxModifyFiles.Text.Replace("\r\n", "\r\n        ");
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
					if (comboBox.Items.Count > MAX_PROJECT_NAME_SAVED)
					{
						comboBox.Items.RemoveAt(0);
					}
					comboBox.SelectedIndex = comboBox.FindStringExact(str);
				}
				else
				{
					comboBox.Text = "";
				}
			}
			else
			{
				comboBox.SelectedIndex = index;
			}
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


		private void comboBoxProjectName_Leave(object sender, EventArgs e)
		{
			UpdateComboBox(comboBoxProjectName, comboBoxProjectName.Text, true);
		}

		private void checkBoxSignature_CheckedChanged(object sender, EventArgs e)
		{
			groupBoxSignature.Enabled = checkBoxSignature.Checked;
			if (checkBoxSignature.Checked)
			{
				this.checkBoxSignature.Text = "<ADLINK-" + textBoxAuthor.Text + textBoxDate.Text + "_" + textBoxSerialNumber.Text + ">";
			}
			else
			{
				this.checkBoxSignature.Text = "";
			}


		}

		private void textBoxDate_TextChanged(object sender, EventArgs e)
		{
			this.checkBoxSignature.Text = "<ADLINK-" + textBoxAuthor.Text + textBoxDate.Text + "_" + textBoxSerialNumber.Text + ">";
		}

		private void textBoxSerialNumber_TextChanged(object sender, EventArgs e)
		{
			this.checkBoxSignature.Text = "<ADLINK-" + textBoxAuthor.Text + textBoxDate.Text + "_" + textBoxSerialNumber.Text + ">";
		}

		private void textBoxBiosVersion_Leave(object sender, EventArgs e)
		{
			if (this.radioButtonCrb.Checked)
			{
				if (this.textBoxBiosVersion.Text.Length >= 4)
				{
					if (String.Compare(this.textBoxBiosVersion.Text.Substring(0, 4), "CRB_") != 0)
					{
						this.textBoxBiosVersion.Text = "CRB_" + this.textBoxBiosVersion.Text;
					}
				}
				else
				{
					this.textBoxBiosVersion.Text = "CRB_" + this.textBoxBiosVersion.Text;
				}
			}
		}

		private void buttonToday_Click(object sender, EventArgs e)
		{
			DateTime localDate = DateTime.Now;
			this.textBoxDate.Text = localDate.Year.ToString("0000") + localDate.Month.ToString("00") + localDate.Day.ToString("00");
			this.textBoxSerialNumber.Text = "01";
		}

		private void buttonExport_Click(object sender, EventArgs e)
		{
			string strIssue = this.textBoxIssueNumber.Text;
			string FileName = strIssue + ".txt";

			if (folderBrowserDialog1.ShowDialog() != System.Windows.Forms.DialogResult.OK) return;
			FileName = Path.Combine(folderBrowserDialog1.SelectedPath, FileName);
			StreamWriter dout = new StreamWriter(FileName, false, System.Text.Encoding.ASCII);
			dout.WriteLine(exportLog());
			dout.Close();
			//
			// Sound
			//
			SystemSounds.Asterisk.Play();
			MessageBox.Show("Export to " + Path.GetFileName(FileName) + " done!");
		}

		private void pictureBoxAdlinkLogo_Click(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start("http://tpdc-km.adlinktech.com:8090/pages/viewpage.action?pageId=21037656");
		}

		private void pictureBoxAdlinkLogo_DoubleClick(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start("https://github.com/PhilXing/Adlink-Logger-CS");
		}

		private void buttonBrowse_Click(object sender, EventArgs e)
		{
			if (Directory.Exists(comboBoxRepo.Text))
			{
				this.folderBrowserDialog1.SelectedPath = comboBoxRepo.Text;
			}
			if (folderBrowserDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				comboBoxRepo.Text = folderBrowserDialog1.SelectedPath;
				int index = comboBoxRepo.FindStringExact(comboBoxRepo.Text);
				if (index == -1)
				{
					comboBoxRepo.Items.Insert(0, folderBrowserDialog1.SelectedPath);
					if (comboBoxRepo.Items.Count > MAX_PROJECT_NAME_SAVED)
					{
						comboBoxRepo.Items.RemoveAt(0);
					}
					comboBoxRepo.SelectedIndex = comboBoxRepo.FindStringExact(comboBoxRepo.Text);
				}
				else
				{
					comboBoxRepo.SelectedIndex = index;
					comboBoxRepo.Items.Insert(0, comboBoxRepo.SelectedItem);
					comboBoxRepo.Items.RemoveAt(comboBoxRepo.SelectedIndex);
					comboBoxRepo.SelectedIndex = 0;
				}
				//ResetControls();
				comboBoxRepo_Leave(sender, e);
			}
		}

		private void comboBoxRepo_Leave(object sender, EventArgs e)
		{
			// get list of staged files
			// declare GIT process
			var process = new Process
			{
				StartInfo = new ProcessStartInfo
				{
					FileName = "git.exe",
					WorkingDirectory = comboBoxRepo.Text,
					Arguments = "diff --cached --name-only",
					UseShellExecute = false,
					RedirectStandardOutput = true,
					RedirectStandardInput = true,
					CreateNoWindow = true
				}
			};
			process.Start();
			textBoxModifyFiles.Text = "";
			while (!process.StandardOutput.EndOfStream)
			{
				string line = process.StandardOutput.ReadLine();
				textBoxModifyFiles.Text += (line + Environment.NewLine);
			}

			// get projest name form git branch name
			process.StartInfo.Arguments = "rev-parse --abbrev-ref HEAD";
			process.Start();
			string branchName = process.StandardOutput.ReadToEnd();
			// remove tail after '_' as the project name if any
			int up = branchName.IndexOf('_');
			if (up >= 0)
			{
				branchName = branchName.Substring(0, up);
			}

			process.WaitForExit();

			// get all VEB files
			if (Directory.Exists(comboBoxRepo.Text))
			{
				string[] fileEntries = Directory
					.EnumerateFiles(comboBoxRepo.Text, "*.veb", SearchOption.TopDirectoryOnly)
					.Select(Path.GetFileNameWithoutExtension)
					.Select(p => p.Substring(0)).ToArray();

				foreach (string veb in fileEntries)
				{
					if (branchName.IndexOf(veb) >= 0)
					{
						comboBoxProjectName.Text = veb;
						UpdateComboBox(comboBoxProjectName, comboBoxProjectName.Text, true);
						break;
					}
				}

				UpdateComboBox(comboBoxRepo, comboBoxRepo.Text, true);
			}
		}

		private void textBoxAuthor_Leave(object sender, EventArgs e)
		{
			this.textBoxAuthor.Text = this.textBoxAuthor.Text.ToUpper();
			this.checkBoxSignature.Text = "<ADLINK-" + textBoxAuthor.Text + textBoxDate.Text + "_" + textBoxSerialNumber.Text + ">";
		}

		private async void textBoxIssueNumber_Leave(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(textBoxIssueNumber.Text))
            {
				var jira = Jira.CreateRestClient(JiraURL, JiraUName, JiraUPassword);
				if (jira != null)
				{
					try
                    {
						var issue = await jira.Issues.GetIssueAsync(textBoxIssueNumber.Text);
						if (issue != null)
						{
							textBoxSummary.Text = issue.Summary;
						}
                    }
					catch (Exception ex)
                    {
						MessageBox.Show("Jira connection or data query error.");
                    }
				}
            }
		}
		private void buttonJiraLogin_Click(object sender, EventArgs e)
		{
			Form2 form2 = new Form2();
            if (form2.ShowDialog() == DialogResult.OK)
            {
				this.textBoxIssueNumber_Leave(sender, e);
			}
        }
	}
}
