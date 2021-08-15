
namespace Adlink_Logger_CS
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBoxAdlinkLogo = new System.Windows.Forms.PictureBox();
            this.groupBoxBiosType = new System.Windows.Forms.GroupBox();
            this.radioButtonMessage = new System.Windows.Forms.RadioButton();
            this.radioButtonMark = new System.Windows.Forms.RadioButton();
            this.radioButtonTag = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonCustomized = new System.Windows.Forms.RadioButton();
            this.radioButtonStandard = new System.Windows.Forms.RadioButton();
            this.radioButtonCrb = new System.Windows.Forms.RadioButton();
            this.labelProjectName = new System.Windows.Forms.Label();
            this.labelCustomerName = new System.Windows.Forms.Label();
            this.labelBiosVersion = new System.Windows.Forms.Label();
            this.comboBoxProjectName = new System.Windows.Forms.ComboBox();
            this.textBoxCustomerName = new System.Windows.Forms.TextBox();
            this.textBoxBiosVersion = new System.Windows.Forms.TextBox();
            this.groupBoxModification = new System.Windows.Forms.GroupBox();
            this.radioButtonFunctionRemove = new System.Windows.Forms.RadioButton();
            this.radioButtonFunctionAdd = new System.Windows.Forms.RadioButton();
            this.radioButtonBugFix = new System.Windows.Forms.RadioButton();
            this.labelIssueNumber = new System.Windows.Forms.Label();
            this.labelSummary = new System.Windows.Forms.Label();
            this.checkBoxSignature = new System.Windows.Forms.CheckBox();
            this.textBoxIssueNumber = new System.Windows.Forms.TextBox();
            this.textBoxSummary = new System.Windows.Forms.TextBox();
            this.groupBoxSignature = new System.Windows.Forms.GroupBox();
            this.buttonToday = new System.Windows.Forms.Button();
            this.textBoxSerialNumber = new System.Windows.Forms.TextBox();
            this.textBoxDate = new System.Windows.Forms.TextBox();
            this.textBoxAuthor = new System.Windows.Forms.TextBox();
            this.labelSerialnumber = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.textBoxTestCase = new System.Windows.Forms.TextBox();
            this.textBoxModifyFiles = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelTestCase = new System.Windows.Forms.Label();
            this.labelModifyFiles = new System.Windows.Forms.Label();
            this.buttonExport = new System.Windows.Forms.Button();
            this.buttonClipboard = new System.Windows.Forms.Button();
            this.buttonImport = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAdlinkLogo)).BeginInit();
            this.groupBoxBiosType.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBoxModification.SuspendLayout();
            this.groupBoxSignature.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxAdlinkLogo
            // 
            this.pictureBoxAdlinkLogo.Image = global::Adlink_Logger_CS.Properties.Resources.ADLINK_logo_0415_2;
            this.pictureBoxAdlinkLogo.InitialImage = global::Adlink_Logger_CS.Properties.Resources.ADLINK_logo_0415_2;
            this.pictureBoxAdlinkLogo.Location = new System.Drawing.Point(310, 12);
            this.pictureBoxAdlinkLogo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBoxAdlinkLogo.Name = "pictureBoxAdlinkLogo";
            this.pictureBoxAdlinkLogo.Size = new System.Drawing.Size(341, 79);
            this.pictureBoxAdlinkLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAdlinkLogo.TabIndex = 0;
            this.pictureBoxAdlinkLogo.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBoxAdlinkLogo, "Click to visit Commit Message Rule page...");
            this.pictureBoxAdlinkLogo.Click += new System.EventHandler(this.pictureBoxAdlinkLogo_Click);
            this.pictureBoxAdlinkLogo.DoubleClick += new System.EventHandler(this.pictureBoxAdlinkLogo_DoubleClick);
            // 
            // groupBoxBiosType
            // 
            this.groupBoxBiosType.Controls.Add(this.radioButtonMessage);
            this.groupBoxBiosType.Controls.Add(this.radioButtonMark);
            this.groupBoxBiosType.Controls.Add(this.radioButtonTag);
            this.groupBoxBiosType.Location = new System.Drawing.Point(25, 12);
            this.groupBoxBiosType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxBiosType.Name = "groupBoxBiosType";
            this.groupBoxBiosType.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxBiosType.Size = new System.Drawing.Size(264, 58);
            this.groupBoxBiosType.TabIndex = 0;
            this.groupBoxBiosType.TabStop = false;
            this.groupBoxBiosType.Text = "Message Type";
            // 
            // radioButtonMessage
            // 
            this.radioButtonMessage.AutoSize = true;
            this.radioButtonMessage.Checked = true;
            this.radioButtonMessage.Location = new System.Drawing.Point(186, 26);
            this.radioButtonMessage.Name = "radioButtonMessage";
            this.radioButtonMessage.Size = new System.Drawing.Size(76, 19);
            this.radioButtonMessage.TabIndex = 2;
            this.radioButtonMessage.TabStop = true;
            this.radioButtonMessage.Text = "Message";
            this.radioButtonMessage.UseVisualStyleBackColor = true;
            this.radioButtonMessage.CheckedChanged += new System.EventHandler(this.EnableControls);
            // 
            // radioButtonMark
            // 
            this.radioButtonMark.AutoSize = true;
            this.radioButtonMark.Location = new System.Drawing.Point(73, 26);
            this.radioButtonMark.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButtonMark.Name = "radioButtonMark";
            this.radioButtonMark.Size = new System.Drawing.Size(107, 19);
            this.radioButtonMark.TabIndex = 1;
            this.radioButtonMark.Text = "Mark in history";
            this.radioButtonMark.UseVisualStyleBackColor = true;
            this.radioButtonMark.CheckedChanged += new System.EventHandler(this.EnableControls);
            // 
            // radioButtonTag
            // 
            this.radioButtonTag.AutoSize = true;
            this.radioButtonTag.Location = new System.Drawing.Point(20, 26);
            this.radioButtonTag.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButtonTag.Name = "radioButtonTag";
            this.radioButtonTag.Size = new System.Drawing.Size(47, 19);
            this.radioButtonTag.TabIndex = 0;
            this.radioButtonTag.Text = "Tag";
            this.radioButtonTag.UseVisualStyleBackColor = true;
            this.radioButtonTag.CheckedChanged += new System.EventHandler(this.EnableControls);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonCustomized);
            this.groupBox1.Controls.Add(this.radioButtonStandard);
            this.groupBox1.Controls.Add(this.radioButtonCrb);
            this.groupBox1.Location = new System.Drawing.Point(25, 77);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(264, 58);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Message Type";
            // 
            // radioButtonCustomized
            // 
            this.radioButtonCustomized.AutoSize = true;
            this.radioButtonCustomized.Location = new System.Drawing.Point(156, 26);
            this.radioButtonCustomized.Name = "radioButtonCustomized";
            this.radioButtonCustomized.Size = new System.Drawing.Size(92, 19);
            this.radioButtonCustomized.TabIndex = 2;
            this.radioButtonCustomized.Text = "Customized";
            this.radioButtonCustomized.UseVisualStyleBackColor = true;
            this.radioButtonCustomized.CheckedChanged += new System.EventHandler(this.EnableControls);
            // 
            // radioButtonStandard
            // 
            this.radioButtonStandard.AutoSize = true;
            this.radioButtonStandard.Checked = true;
            this.radioButtonStandard.Location = new System.Drawing.Point(73, 26);
            this.radioButtonStandard.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButtonStandard.Name = "radioButtonStandard";
            this.radioButtonStandard.Size = new System.Drawing.Size(77, 19);
            this.radioButtonStandard.TabIndex = 1;
            this.radioButtonStandard.TabStop = true;
            this.radioButtonStandard.Text = "Standard";
            this.radioButtonStandard.UseVisualStyleBackColor = true;
            this.radioButtonStandard.CheckedChanged += new System.EventHandler(this.EnableControls);
            // 
            // radioButtonCrb
            // 
            this.radioButtonCrb.AutoSize = true;
            this.radioButtonCrb.Location = new System.Drawing.Point(20, 26);
            this.radioButtonCrb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButtonCrb.Name = "radioButtonCrb";
            this.radioButtonCrb.Size = new System.Drawing.Size(48, 19);
            this.radioButtonCrb.TabIndex = 0;
            this.radioButtonCrb.Text = "CRB";
            this.radioButtonCrb.UseVisualStyleBackColor = true;
            this.radioButtonCrb.CheckedChanged += new System.EventHandler(this.EnableControls);
            // 
            // labelProjectName
            // 
            this.labelProjectName.AutoSize = true;
            this.labelProjectName.Location = new System.Drawing.Point(28, 151);
            this.labelProjectName.Name = "labelProjectName";
            this.labelProjectName.Size = new System.Drawing.Size(84, 15);
            this.labelProjectName.TabIndex = 2;
            this.labelProjectName.Text = "Project Name";
            // 
            // labelCustomerName
            // 
            this.labelCustomerName.AutoSize = true;
            this.labelCustomerName.Location = new System.Drawing.Point(28, 186);
            this.labelCustomerName.Name = "labelCustomerName";
            this.labelCustomerName.Size = new System.Drawing.Size(99, 15);
            this.labelCustomerName.TabIndex = 4;
            this.labelCustomerName.Text = "Customer Name";
            // 
            // labelBiosVersion
            // 
            this.labelBiosVersion.AutoSize = true;
            this.labelBiosVersion.Location = new System.Drawing.Point(28, 219);
            this.labelBiosVersion.Name = "labelBiosVersion";
            this.labelBiosVersion.Size = new System.Drawing.Size(49, 15);
            this.labelBiosVersion.TabIndex = 6;
            this.labelBiosVersion.Text = "Version";
            // 
            // comboBoxProjectName
            // 
            this.comboBoxProjectName.DropDownWidth = 134;
            this.comboBoxProjectName.FormattingEnabled = true;
            this.comboBoxProjectName.Location = new System.Drawing.Point(118, 148);
            this.comboBoxProjectName.MaxLength = 5;
            this.comboBoxProjectName.Name = "comboBoxProjectName";
            this.comboBoxProjectName.Size = new System.Drawing.Size(169, 23);
            this.comboBoxProjectName.Sorted = true;
            this.comboBoxProjectName.TabIndex = 3;
            this.comboBoxProjectName.Leave += new System.EventHandler(this.comboBoxProjectName_Leave);
            // 
            // textBoxCustomerName
            // 
            this.textBoxCustomerName.Location = new System.Drawing.Point(134, 183);
            this.textBoxCustomerName.Name = "textBoxCustomerName";
            this.textBoxCustomerName.Size = new System.Drawing.Size(153, 23);
            this.textBoxCustomerName.TabIndex = 5;
            // 
            // textBoxBiosVersion
            // 
            this.textBoxBiosVersion.Location = new System.Drawing.Point(83, 216);
            this.textBoxBiosVersion.Name = "textBoxBiosVersion";
            this.textBoxBiosVersion.Size = new System.Drawing.Size(204, 23);
            this.textBoxBiosVersion.TabIndex = 7;
            // 
            // groupBoxModification
            // 
            this.groupBoxModification.Controls.Add(this.radioButtonFunctionRemove);
            this.groupBoxModification.Controls.Add(this.radioButtonFunctionAdd);
            this.groupBoxModification.Controls.Add(this.radioButtonBugFix);
            this.groupBoxModification.Location = new System.Drawing.Point(25, 254);
            this.groupBoxModification.Name = "groupBoxModification";
            this.groupBoxModification.Size = new System.Drawing.Size(280, 58);
            this.groupBoxModification.TabIndex = 8;
            this.groupBoxModification.TabStop = false;
            this.groupBoxModification.Text = "Modification Type";
            // 
            // radioButtonFunctionRemove
            // 
            this.radioButtonFunctionRemove.AutoSize = true;
            this.radioButtonFunctionRemove.Location = new System.Drawing.Point(176, 26);
            this.radioButtonFunctionRemove.Name = "radioButtonFunctionRemove";
            this.radioButtonFunctionRemove.Size = new System.Drawing.Size(104, 19);
            this.radioButtonFunctionRemove.TabIndex = 2;
            this.radioButtonFunctionRemove.Text = "Func. Remove";
            this.radioButtonFunctionRemove.UseVisualStyleBackColor = true;
            // 
            // radioButtonFunctionAdd
            // 
            this.radioButtonFunctionAdd.AutoSize = true;
            this.radioButtonFunctionAdd.Location = new System.Drawing.Point(89, 26);
            this.radioButtonFunctionAdd.Name = "radioButtonFunctionAdd";
            this.radioButtonFunctionAdd.Size = new System.Drawing.Size(81, 19);
            this.radioButtonFunctionAdd.TabIndex = 1;
            this.radioButtonFunctionAdd.Text = "Func. Add";
            this.radioButtonFunctionAdd.UseVisualStyleBackColor = true;
            // 
            // radioButtonBugFix
            // 
            this.radioButtonBugFix.AutoSize = true;
            this.radioButtonBugFix.Checked = true;
            this.radioButtonBugFix.Location = new System.Drawing.Point(20, 26);
            this.radioButtonBugFix.Name = "radioButtonBugFix";
            this.radioButtonBugFix.Size = new System.Drawing.Size(63, 19);
            this.radioButtonBugFix.TabIndex = 0;
            this.radioButtonBugFix.TabStop = true;
            this.radioButtonBugFix.Text = "Bug fix";
            this.radioButtonBugFix.UseVisualStyleBackColor = true;
            // 
            // labelIssueNumber
            // 
            this.labelIssueNumber.AutoSize = true;
            this.labelIssueNumber.Location = new System.Drawing.Point(28, 329);
            this.labelIssueNumber.Name = "labelIssueNumber";
            this.labelIssueNumber.Size = new System.Drawing.Size(42, 15);
            this.labelIssueNumber.TabIndex = 9;
            this.labelIssueNumber.Text = "Issue#";
            // 
            // labelSummary
            // 
            this.labelSummary.AutoSize = true;
            this.labelSummary.Location = new System.Drawing.Point(28, 360);
            this.labelSummary.Name = "labelSummary";
            this.labelSummary.Size = new System.Drawing.Size(60, 15);
            this.labelSummary.TabIndex = 11;
            this.labelSummary.Text = "Summary";
            // 
            // checkBoxSignature
            // 
            this.checkBoxSignature.AutoSize = true;
            this.checkBoxSignature.Checked = true;
            this.checkBoxSignature.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxSignature.Location = new System.Drawing.Point(31, 393);
            this.checkBoxSignature.Name = "checkBoxSignature";
            this.checkBoxSignature.Size = new System.Drawing.Size(197, 19);
            this.checkBoxSignature.TabIndex = 13;
            this.checkBoxSignature.Text = "<ADLINK-XXYYYYMMDD_ZZ>";
            this.checkBoxSignature.UseVisualStyleBackColor = true;
            this.checkBoxSignature.CheckedChanged += new System.EventHandler(this.EnableControls);
            // 
            // textBoxIssueNumber
            // 
            this.textBoxIssueNumber.Location = new System.Drawing.Point(75, 326);
            this.textBoxIssueNumber.Name = "textBoxIssueNumber";
            this.textBoxIssueNumber.Size = new System.Drawing.Size(212, 23);
            this.textBoxIssueNumber.TabIndex = 10;
            this.toolTip1.SetToolTip(this.textBoxIssueNumber, "Jira #");
            // 
            // textBoxSummary
            // 
            this.textBoxSummary.Location = new System.Drawing.Point(93, 357);
            this.textBoxSummary.Name = "textBoxSummary";
            this.textBoxSummary.Size = new System.Drawing.Size(194, 23);
            this.textBoxSummary.TabIndex = 12;
            this.toolTip1.SetToolTip(this.textBoxSummary, "Might be Summary from Jira");
            // 
            // groupBoxSignature
            // 
            this.groupBoxSignature.Controls.Add(this.buttonToday);
            this.groupBoxSignature.Controls.Add(this.textBoxSerialNumber);
            this.groupBoxSignature.Controls.Add(this.textBoxDate);
            this.groupBoxSignature.Controls.Add(this.textBoxAuthor);
            this.groupBoxSignature.Controls.Add(this.labelSerialnumber);
            this.groupBoxSignature.Controls.Add(this.labelDate);
            this.groupBoxSignature.Controls.Add(this.labelAuthor);
            this.groupBoxSignature.Location = new System.Drawing.Point(25, 418);
            this.groupBoxSignature.Name = "groupBoxSignature";
            this.groupBoxSignature.Size = new System.Drawing.Size(264, 127);
            this.groupBoxSignature.TabIndex = 14;
            this.groupBoxSignature.TabStop = false;
            this.groupBoxSignature.Text = "Signature";
            // 
            // buttonToday
            // 
            this.buttonToday.Location = new System.Drawing.Point(162, 57);
            this.buttonToday.Name = "buttonToday";
            this.buttonToday.Size = new System.Drawing.Size(62, 23);
            this.buttonToday.TabIndex = 5;
            this.buttonToday.Text = "Today";
            this.buttonToday.UseVisualStyleBackColor = true;
            this.buttonToday.Click += new System.EventHandler(this.buttonToday_Click);
            // 
            // textBoxSerialNumber
            // 
            this.textBoxSerialNumber.Location = new System.Drawing.Point(75, 91);
            this.textBoxSerialNumber.MaxLength = 2;
            this.textBoxSerialNumber.Name = "textBoxSerialNumber";
            this.textBoxSerialNumber.Size = new System.Drawing.Size(81, 23);
            this.textBoxSerialNumber.TabIndex = 7;
            this.toolTip1.SetToolTip(this.textBoxSerialNumber, "personal daily serial number");
            this.textBoxSerialNumber.TextChanged += new System.EventHandler(this.textBoxSerialNumber_TextChanged);
            // 
            // textBoxDate
            // 
            this.textBoxDate.Location = new System.Drawing.Point(75, 58);
            this.textBoxDate.MaxLength = 8;
            this.textBoxDate.Name = "textBoxDate";
            this.textBoxDate.Size = new System.Drawing.Size(81, 23);
            this.textBoxDate.TabIndex = 4;
            this.toolTip1.SetToolTip(this.textBoxDate, "YYYYMMDD, date code");
            this.textBoxDate.TextChanged += new System.EventHandler(this.textBoxDate_TextChanged);
            // 
            // textBoxAuthor
            // 
            this.textBoxAuthor.Location = new System.Drawing.Point(75, 25);
            this.textBoxAuthor.MaxLength = 2;
            this.textBoxAuthor.Name = "textBoxAuthor";
            this.textBoxAuthor.Size = new System.Drawing.Size(81, 23);
            this.textBoxAuthor.TabIndex = 2;
            this.toolTip1.SetToolTip(this.textBoxAuthor, "XX, 2 letters\' initial of the name of the author");
            this.textBoxAuthor.TextChanged += new System.EventHandler(this.textBoxAuthor_TextChanged);
            // 
            // labelSerialnumber
            // 
            this.labelSerialnumber.AutoSize = true;
            this.labelSerialnumber.Location = new System.Drawing.Point(28, 94);
            this.labelSerialnumber.Name = "labelSerialnumber";
            this.labelSerialnumber.Size = new System.Drawing.Size(46, 15);
            this.labelSerialnumber.TabIndex = 6;
            this.labelSerialnumber.Text = "Serial#";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(28, 61);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(34, 15);
            this.labelDate.TabIndex = 3;
            this.labelDate.Text = "Date";
            // 
            // labelAuthor
            // 
            this.labelAuthor.AutoSize = true;
            this.labelAuthor.Location = new System.Drawing.Point(28, 28);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(45, 15);
            this.labelAuthor.TabIndex = 1;
            this.labelAuthor.Text = "Author";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(310, 120);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxDescription.Size = new System.Drawing.Size(341, 108);
            this.textBoxDescription.TabIndex = 16;
            // 
            // textBoxTestCase
            // 
            this.textBoxTestCase.Location = new System.Drawing.Point(310, 259);
            this.textBoxTestCase.Multiline = true;
            this.textBoxTestCase.Name = "textBoxTestCase";
            this.textBoxTestCase.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxTestCase.Size = new System.Drawing.Size(341, 108);
            this.textBoxTestCase.TabIndex = 18;
            // 
            // textBoxModifyFiles
            // 
            this.textBoxModifyFiles.Location = new System.Drawing.Point(310, 396);
            this.textBoxModifyFiles.Multiline = true;
            this.textBoxModifyFiles.Name = "textBoxModifyFiles";
            this.textBoxModifyFiles.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxModifyFiles.Size = new System.Drawing.Size(341, 108);
            this.textBoxModifyFiles.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(307, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "Description";
            // 
            // labelTestCase
            // 
            this.labelTestCase.AutoSize = true;
            this.labelTestCase.Location = new System.Drawing.Point(307, 241);
            this.labelTestCase.Name = "labelTestCase";
            this.labelTestCase.Size = new System.Drawing.Size(60, 15);
            this.labelTestCase.TabIndex = 17;
            this.labelTestCase.Text = "Test Case";
            // 
            // labelModifyFiles
            // 
            this.labelModifyFiles.AutoSize = true;
            this.labelModifyFiles.Location = new System.Drawing.Point(307, 378);
            this.labelModifyFiles.Name = "labelModifyFiles";
            this.labelModifyFiles.Size = new System.Drawing.Size(75, 15);
            this.labelModifyFiles.TabIndex = 19;
            this.labelModifyFiles.Text = "Modify Files";
            // 
            // buttonExport
            // 
            this.buttonExport.Location = new System.Drawing.Point(310, 510);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(99, 47);
            this.buttonExport.TabIndex = 21;
            this.buttonExport.Text = "Export";
            this.buttonExport.UseVisualStyleBackColor = true;
            // 
            // buttonClipboard
            // 
            this.buttonClipboard.Location = new System.Drawing.Point(431, 510);
            this.buttonClipboard.Name = "buttonClipboard";
            this.buttonClipboard.Size = new System.Drawing.Size(99, 47);
            this.buttonClipboard.TabIndex = 22;
            this.buttonClipboard.Text = "Clipboard";
            this.buttonClipboard.UseVisualStyleBackColor = true;
            this.buttonClipboard.Click += new System.EventHandler(this.buttonClipboard_Click);
            // 
            // buttonImport
            // 
            this.buttonImport.Enabled = false;
            this.buttonImport.Location = new System.Drawing.Point(552, 510);
            this.buttonImport.Name = "buttonImport";
            this.buttonImport.Size = new System.Drawing.Size(99, 47);
            this.buttonImport.TabIndex = 23;
            this.buttonImport.Text = "Import";
            this.buttonImport.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 575);
            this.Controls.Add(this.buttonImport);
            this.Controls.Add(this.buttonClipboard);
            this.Controls.Add(this.buttonExport);
            this.Controls.Add(this.labelModifyFiles);
            this.Controls.Add(this.labelTestCase);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxModifyFiles);
            this.Controls.Add(this.textBoxTestCase);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.checkBoxSignature);
            this.Controls.Add(this.groupBoxSignature);
            this.Controls.Add(this.textBoxSummary);
            this.Controls.Add(this.textBoxIssueNumber);
            this.Controls.Add(this.labelSummary);
            this.Controls.Add(this.labelIssueNumber);
            this.Controls.Add(this.groupBoxModification);
            this.Controls.Add(this.textBoxBiosVersion);
            this.Controls.Add(this.textBoxCustomerName);
            this.Controls.Add(this.comboBoxProjectName);
            this.Controls.Add(this.labelBiosVersion);
            this.Controls.Add(this.labelCustomerName);
            this.Controls.Add(this.labelProjectName);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxBiosType);
            this.Controls.Add(this.pictureBoxAdlinkLogo);
            this.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Adlink Logger v0.2-2021-08-14";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAdlinkLogo)).EndInit();
            this.groupBoxBiosType.ResumeLayout(false);
            this.groupBoxBiosType.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxModification.ResumeLayout(false);
            this.groupBoxModification.PerformLayout();
            this.groupBoxSignature.ResumeLayout(false);
            this.groupBoxSignature.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxAdlinkLogo;
        private System.Windows.Forms.GroupBox groupBoxBiosType;
        private System.Windows.Forms.RadioButton radioButtonMessage;
        private System.Windows.Forms.RadioButton radioButtonMark;
        private System.Windows.Forms.RadioButton radioButtonTag;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonCustomized;
        private System.Windows.Forms.RadioButton radioButtonStandard;
        private System.Windows.Forms.RadioButton radioButtonCrb;
        private System.Windows.Forms.Label labelProjectName;
        private System.Windows.Forms.Label labelCustomerName;
        private System.Windows.Forms.Label labelBiosVersion;
        private System.Windows.Forms.ComboBox comboBoxProjectName;
        private System.Windows.Forms.TextBox textBoxCustomerName;
        private System.Windows.Forms.TextBox textBoxBiosVersion;
        private System.Windows.Forms.GroupBox groupBoxModification;
        private System.Windows.Forms.RadioButton radioButtonFunctionRemove;
        private System.Windows.Forms.RadioButton radioButtonFunctionAdd;
        private System.Windows.Forms.RadioButton radioButtonBugFix;
        private System.Windows.Forms.Label labelIssueNumber;
        private System.Windows.Forms.Label labelSummary;
        private System.Windows.Forms.CheckBox checkBoxSignature;
        private System.Windows.Forms.TextBox textBoxIssueNumber;
        private System.Windows.Forms.TextBox textBoxSummary;
        private System.Windows.Forms.GroupBox groupBoxSignature;
        private System.Windows.Forms.Label labelAuthor;
        private System.Windows.Forms.Button buttonToday;
        private System.Windows.Forms.TextBox textBoxSerialNumber;
        private System.Windows.Forms.TextBox textBoxDate;
        private System.Windows.Forms.TextBox textBoxAuthor;
        private System.Windows.Forms.Label labelSerialnumber;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.TextBox textBoxTestCase;
        private System.Windows.Forms.TextBox textBoxModifyFiles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTestCase;
        private System.Windows.Forms.Label labelModifyFiles;
        private System.Windows.Forms.Button buttonExport;
        private System.Windows.Forms.Button buttonClipboard;
        private System.Windows.Forms.Button buttonImport;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

