using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Atlassian.Jira;

namespace Adlink_Logger_CS
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            Form1.JiraURL = textBoxJiraUrl.Text;
            Form1.JiraUName = textBoxID.Text;
            Form1.JiraUPassword = textBoxPassword.Text;
            //var jira = Jira.CreateRestClient(textBoxJiraUrl.Text, textBoxID.Text, textBoxPassword.Text);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            textBoxJiraUrl.Text = Form1.JiraURL;
            textBoxID.Text = Form1.JiraUName;
            textBoxPassword.Text = Form1.JiraUPassword;

            if (String.IsNullOrEmpty(textBoxJiraUrl.Text))
            {
                textBoxJiraUrl.Text = "https://jira.adlinktech.com/";
            }

            if (String.IsNullOrEmpty(textBoxID.Text))
            {
                string[] temp = Convert.ToString(WindowsIdentity.GetCurrent().Name).Split('\\');
                textBoxID.Text = temp[1];
            }
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
    }
}
