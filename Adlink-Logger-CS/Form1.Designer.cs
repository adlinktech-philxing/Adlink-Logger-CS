
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
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBoxAdlinkLogo = new System.Windows.Forms.PictureBox();
            this.textBoxAuthor = new System.Windows.Forms.TextBox();
            this.textBoxDate = new System.Windows.Forms.TextBox();
            this.textBoxSerialNumber = new System.Windows.Forms.TextBox();
            this.textBoxSummary = new System.Windows.Forms.TextBox();
            this.textBoxIssueNumber = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.textBoxTestCase = new System.Windows.Forms.TextBox();
            this.textBoxModifyFiles = new System.Windows.Forms.TextBox();
            this.labelModifyFiles = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelTestCase = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonExport = new System.Windows.Forms.Button();
            this.buttonImport = new System.Windows.Forms.Button();
            this.buttonClipboard = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.labelIssueNumber = new System.Windows.Forms.Label();
            this.labelSummary = new System.Windows.Forms.Label();
            this.groupBoxSignature = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonToday = new System.Windows.Forms.Button();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelSerialnumber = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.labelProjectName = new System.Windows.Forms.Label();
            this.labelCustomerName = new System.Windows.Forms.Label();
            this.labelBiosVersion = new System.Windows.Forms.Label();
            this.comboBoxProjectName = new System.Windows.Forms.ComboBox();
            this.textBoxCustomerName = new System.Windows.Forms.TextBox();
            this.textBoxBiosVersion = new System.Windows.Forms.TextBox();
            this.checkBoxSignature = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.radioButtonCustomized = new System.Windows.Forms.RadioButton();
            this.radioButtonCrb = new System.Windows.Forms.RadioButton();
            this.radioButtonStandard = new System.Windows.Forms.RadioButton();
            this.groupBoxBiosType = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.radioButtonMessage = new System.Windows.Forms.RadioButton();
            this.radioButtonTag = new System.Windows.Forms.RadioButton();
            this.radioButtonMark = new System.Windows.Forms.RadioButton();
            this.groupBoxModification = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.radioButtonFunctionRemove = new System.Windows.Forms.RadioButton();
            this.radioButtonBugFix = new System.Windows.Forms.RadioButton();
            this.radioButtonFunctionAdd = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAdlinkLogo)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.groupBoxSignature.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel10.SuspendLayout();
            this.groupBoxBiosType.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.groupBoxModification.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxAdlinkLogo
            // 
            this.pictureBoxAdlinkLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxAdlinkLogo.Image = global::Adlink_Logger_CS.Properties.Resources.ADLINK_logo_0415_2;
            this.pictureBoxAdlinkLogo.InitialImage = global::Adlink_Logger_CS.Properties.Resources.ADLINK_logo_0415_2;
            this.pictureBoxAdlinkLogo.Location = new System.Drawing.Point(3, 4);
            this.pictureBoxAdlinkLogo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBoxAdlinkLogo.Name = "pictureBoxAdlinkLogo";
            this.pictureBoxAdlinkLogo.Size = new System.Drawing.Size(512, 112);
            this.pictureBoxAdlinkLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAdlinkLogo.TabIndex = 0;
            this.pictureBoxAdlinkLogo.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBoxAdlinkLogo, "Click to visit Commit Message Rule page...");
            this.pictureBoxAdlinkLogo.Click += new System.EventHandler(this.pictureBoxAdlinkLogo_Click);
            this.pictureBoxAdlinkLogo.DoubleClick += new System.EventHandler(this.pictureBoxAdlinkLogo_DoubleClick);
            // 
            // textBoxAuthor
            // 
            this.textBoxAuthor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAuthor.Location = new System.Drawing.Point(85, 6);
            this.textBoxAuthor.MaxLength = 2;
            this.textBoxAuthor.Name = "textBoxAuthor";
            this.textBoxAuthor.Size = new System.Drawing.Size(126, 27);
            this.textBoxAuthor.TabIndex = 2;
            this.toolTip1.SetToolTip(this.textBoxAuthor, "XX, 2 letters\' initial of the name of the author");
            this.textBoxAuthor.TextChanged += new System.EventHandler(this.textBoxAuthor_TextChanged);
            // 
            // textBoxDate
            // 
            this.textBoxDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDate.Location = new System.Drawing.Point(85, 46);
            this.textBoxDate.MaxLength = 8;
            this.textBoxDate.Name = "textBoxDate";
            this.textBoxDate.Size = new System.Drawing.Size(126, 27);
            this.textBoxDate.TabIndex = 4;
            this.toolTip1.SetToolTip(this.textBoxDate, "YYYYMMDD, date code");
            this.textBoxDate.TextChanged += new System.EventHandler(this.textBoxDate_TextChanged);
            // 
            // textBoxSerialNumber
            // 
            this.textBoxSerialNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSerialNumber.Location = new System.Drawing.Point(85, 86);
            this.textBoxSerialNumber.MaxLength = 2;
            this.textBoxSerialNumber.Name = "textBoxSerialNumber";
            this.textBoxSerialNumber.Size = new System.Drawing.Size(126, 27);
            this.textBoxSerialNumber.TabIndex = 7;
            this.toolTip1.SetToolTip(this.textBoxSerialNumber, "personal daily serial number");
            this.textBoxSerialNumber.TextChanged += new System.EventHandler(this.textBoxSerialNumber_TextChanged);
            // 
            // textBoxSummary
            // 
            this.textBoxSummary.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSummary.Location = new System.Drawing.Point(115, 48);
            this.textBoxSummary.Name = "textBoxSummary";
            this.textBoxSummary.Size = new System.Drawing.Size(219, 27);
            this.textBoxSummary.TabIndex = 12;
            this.toolTip1.SetToolTip(this.textBoxSummary, "Might be Summary from Jira");
            // 
            // textBoxIssueNumber
            // 
            this.textBoxIssueNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxIssueNumber.Location = new System.Drawing.Point(115, 7);
            this.textBoxIssueNumber.Name = "textBoxIssueNumber";
            this.textBoxIssueNumber.Size = new System.Drawing.Size(219, 27);
            this.textBoxIssueNumber.TabIndex = 10;
            this.toolTip1.SetToolTip(this.textBoxIssueNumber, "Jira #");
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBoxAdlinkLogo, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxDescription, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBoxTestCase, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.textBoxModifyFiles, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.labelModifyFiles, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelTestCase, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 7);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(352, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.28488F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.363684F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.28488F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.363684F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.28488F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.363684F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.28488F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.769442F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(518, 624);
            this.tableLayoutPanel1.TabIndex = 24;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDescription.Location = new System.Drawing.Point(3, 150);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxDescription.Size = new System.Drawing.Size(512, 114);
            this.textBoxDescription.TabIndex = 16;
            // 
            // textBoxTestCase
            // 
            this.textBoxTestCase.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTestCase.Location = new System.Drawing.Point(3, 297);
            this.textBoxTestCase.Multiline = true;
            this.textBoxTestCase.Name = "textBoxTestCase";
            this.textBoxTestCase.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxTestCase.Size = new System.Drawing.Size(512, 114);
            this.textBoxTestCase.TabIndex = 18;
            // 
            // textBoxModifyFiles
            // 
            this.textBoxModifyFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxModifyFiles.Location = new System.Drawing.Point(3, 444);
            this.textBoxModifyFiles.Multiline = true;
            this.textBoxModifyFiles.Name = "textBoxModifyFiles";
            this.textBoxModifyFiles.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxModifyFiles.Size = new System.Drawing.Size(512, 114);
            this.textBoxModifyFiles.TabIndex = 20;
            // 
            // labelModifyFiles
            // 
            this.labelModifyFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelModifyFiles.AutoSize = true;
            this.labelModifyFiles.Location = new System.Drawing.Point(3, 422);
            this.labelModifyFiles.Name = "labelModifyFiles";
            this.labelModifyFiles.Size = new System.Drawing.Size(94, 19);
            this.labelModifyFiles.TabIndex = 19;
            this.labelModifyFiles.Text = "Modify Files";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 19);
            this.label1.TabIndex = 15;
            this.label1.Text = "Description";
            // 
            // labelTestCase
            // 
            this.labelTestCase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelTestCase.AutoSize = true;
            this.labelTestCase.Location = new System.Drawing.Point(3, 275);
            this.labelTestCase.Name = "labelTestCase";
            this.labelTestCase.Size = new System.Drawing.Size(74, 19);
            this.labelTestCase.TabIndex = 17;
            this.labelTestCase.Text = "Test Case";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.buttonExport, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonImport, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonClipboard, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 564);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(512, 57);
            this.tableLayoutPanel2.TabIndex = 21;
            // 
            // buttonExport
            // 
            this.buttonExport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExport.Location = new System.Drawing.Point(3, 3);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(164, 51);
            this.buttonExport.TabIndex = 21;
            this.buttonExport.Text = "Export";
            this.buttonExport.UseVisualStyleBackColor = true;
            this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
            // 
            // buttonImport
            // 
            this.buttonImport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonImport.Enabled = false;
            this.buttonImport.Location = new System.Drawing.Point(343, 3);
            this.buttonImport.Name = "buttonImport";
            this.buttonImport.Size = new System.Drawing.Size(166, 51);
            this.buttonImport.TabIndex = 23;
            this.buttonImport.Text = "Import";
            this.buttonImport.UseVisualStyleBackColor = true;
            // 
            // buttonClipboard
            // 
            this.buttonClipboard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClipboard.Location = new System.Drawing.Point(173, 3);
            this.buttonClipboard.Name = "buttonClipboard";
            this.buttonClipboard.Size = new System.Drawing.Size(164, 51);
            this.buttonClipboard.TabIndex = 22;
            this.buttonClipboard.Text = "Clipboard";
            this.buttonClipboard.UseVisualStyleBackColor = true;
            this.buttonClipboard.Click += new System.EventHandler(this.buttonClipboard_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel5, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.groupBoxSignature, 0, 6);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.checkBoxSignature, 0, 5);
            this.tableLayoutPanel3.Controls.Add(this.groupBox1, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.groupBoxBiosType, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.groupBoxModification, 0, 3);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 7;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.04952F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.04952F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.01755F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.04952F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.26316F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.467546F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.10317F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(343, 624);
            this.tableLayoutPanel3.TabIndex = 25;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.tableLayoutPanel5.Controls.Add(this.labelIssueNumber, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.labelSummary, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.textBoxIssueNumber, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.textBoxSummary, 1, 1);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 346);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(337, 83);
            this.tableLayoutPanel5.TabIndex = 26;
            // 
            // labelIssueNumber
            // 
            this.labelIssueNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelIssueNumber.AutoSize = true;
            this.labelIssueNumber.Location = new System.Drawing.Point(3, 0);
            this.labelIssueNumber.Name = "labelIssueNumber";
            this.labelIssueNumber.Size = new System.Drawing.Size(106, 41);
            this.labelIssueNumber.TabIndex = 9;
            this.labelIssueNumber.Text = "Issue#";
            this.labelIssueNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelSummary
            // 
            this.labelSummary.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSummary.AutoSize = true;
            this.labelSummary.Location = new System.Drawing.Point(3, 41);
            this.labelSummary.Name = "labelSummary";
            this.labelSummary.Size = new System.Drawing.Size(106, 42);
            this.labelSummary.TabIndex = 11;
            this.labelSummary.Text = "Summary";
            this.labelSummary.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBoxSignature
            // 
            this.groupBoxSignature.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxSignature.Controls.Add(this.tableLayoutPanel6);
            this.groupBoxSignature.Location = new System.Drawing.Point(3, 469);
            this.groupBoxSignature.Name = "groupBoxSignature";
            this.groupBoxSignature.Size = new System.Drawing.Size(337, 152);
            this.groupBoxSignature.TabIndex = 14;
            this.groupBoxSignature.TabStop = false;
            this.groupBoxSignature.Text = "Signature";
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel6.AutoSize = true;
            this.tableLayoutPanel6.ColumnCount = 3;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel6.Controls.Add(this.buttonToday, 2, 1);
            this.tableLayoutPanel6.Controls.Add(this.labelAuthor, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.textBoxSerialNumber, 1, 2);
            this.tableLayoutPanel6.Controls.Add(this.labelDate, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.textBoxDate, 1, 1);
            this.tableLayoutPanel6.Controls.Add(this.labelSerialnumber, 0, 2);
            this.tableLayoutPanel6.Controls.Add(this.textBoxAuthor, 1, 0);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(6, 26);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 3;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(331, 120);
            this.tableLayoutPanel6.TabIndex = 26;
            // 
            // buttonToday
            // 
            this.buttonToday.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonToday.Location = new System.Drawing.Point(217, 43);
            this.buttonToday.Name = "buttonToday";
            this.buttonToday.Size = new System.Drawing.Size(111, 33);
            this.buttonToday.TabIndex = 5;
            this.buttonToday.Text = "Today";
            this.buttonToday.UseVisualStyleBackColor = true;
            this.buttonToday.Click += new System.EventHandler(this.buttonToday_Click);
            // 
            // labelAuthor
            // 
            this.labelAuthor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAuthor.AutoSize = true;
            this.labelAuthor.Location = new System.Drawing.Point(3, 0);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(76, 40);
            this.labelAuthor.TabIndex = 1;
            this.labelAuthor.Text = "Author";
            this.labelAuthor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelDate
            // 
            this.labelDate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(3, 40);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(76, 40);
            this.labelDate.TabIndex = 3;
            this.labelDate.Text = "Date";
            this.labelDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelSerialnumber
            // 
            this.labelSerialnumber.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSerialnumber.AutoSize = true;
            this.labelSerialnumber.Location = new System.Drawing.Point(3, 80);
            this.labelSerialnumber.Name = "labelSerialnumber";
            this.labelSerialnumber.Size = new System.Drawing.Size(76, 40);
            this.labelSerialnumber.TabIndex = 6;
            this.labelSerialnumber.Text = "Serial#";
            this.labelSerialnumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel4.Controls.Add(this.labelProjectName, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.labelCustomerName, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.labelBiosVersion, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.comboBoxProjectName, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.textBoxCustomerName, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.textBoxBiosVersion, 1, 2);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 153);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(337, 112);
            this.tableLayoutPanel4.TabIndex = 26;
            // 
            // labelProjectName
            // 
            this.labelProjectName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelProjectName.AutoSize = true;
            this.labelProjectName.Location = new System.Drawing.Point(3, 0);
            this.labelProjectName.Name = "labelProjectName";
            this.labelProjectName.Size = new System.Drawing.Size(128, 37);
            this.labelProjectName.TabIndex = 2;
            this.labelProjectName.Text = "Project Name";
            this.labelProjectName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelCustomerName
            // 
            this.labelCustomerName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCustomerName.AutoSize = true;
            this.labelCustomerName.Location = new System.Drawing.Point(3, 37);
            this.labelCustomerName.Name = "labelCustomerName";
            this.labelCustomerName.Size = new System.Drawing.Size(128, 37);
            this.labelCustomerName.TabIndex = 4;
            this.labelCustomerName.Text = "Customer Name";
            this.labelCustomerName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelBiosVersion
            // 
            this.labelBiosVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelBiosVersion.AutoSize = true;
            this.labelBiosVersion.Location = new System.Drawing.Point(3, 74);
            this.labelBiosVersion.Name = "labelBiosVersion";
            this.labelBiosVersion.Size = new System.Drawing.Size(128, 38);
            this.labelBiosVersion.TabIndex = 6;
            this.labelBiosVersion.Text = "Version";
            this.labelBiosVersion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBoxProjectName
            // 
            this.comboBoxProjectName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxProjectName.DropDownWidth = 134;
            this.comboBoxProjectName.FormattingEnabled = true;
            this.comboBoxProjectName.Location = new System.Drawing.Point(137, 7);
            this.comboBoxProjectName.Name = "comboBoxProjectName";
            this.comboBoxProjectName.Size = new System.Drawing.Size(197, 27);
            this.comboBoxProjectName.Sorted = true;
            this.comboBoxProjectName.TabIndex = 3;
            this.comboBoxProjectName.Leave += new System.EventHandler(this.comboBoxProjectName_Leave);
            // 
            // textBoxCustomerName
            // 
            this.textBoxCustomerName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCustomerName.Location = new System.Drawing.Point(137, 42);
            this.textBoxCustomerName.Name = "textBoxCustomerName";
            this.textBoxCustomerName.Size = new System.Drawing.Size(197, 27);
            this.textBoxCustomerName.TabIndex = 5;
            // 
            // textBoxBiosVersion
            // 
            this.textBoxBiosVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxBiosVersion.Location = new System.Drawing.Point(137, 79);
            this.textBoxBiosVersion.Name = "textBoxBiosVersion";
            this.textBoxBiosVersion.Size = new System.Drawing.Size(197, 27);
            this.textBoxBiosVersion.TabIndex = 7;
            this.textBoxBiosVersion.Leave += new System.EventHandler(this.textBoxBiosVersion_Leave);
            // 
            // checkBoxSignature
            // 
            this.checkBoxSignature.AutoSize = true;
            this.checkBoxSignature.Checked = true;
            this.checkBoxSignature.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxSignature.Location = new System.Drawing.Point(3, 435);
            this.checkBoxSignature.Name = "checkBoxSignature";
            this.checkBoxSignature.Size = new System.Drawing.Size(244, 23);
            this.checkBoxSignature.TabIndex = 13;
            this.checkBoxSignature.Text = "<ADLINK-XXYYYYMMDD_ZZ>";
            this.checkBoxSignature.UseVisualStyleBackColor = true;
            this.checkBoxSignature.CheckedChanged += new System.EventHandler(this.checkBoxSignature_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.tableLayoutPanel10);
            this.groupBox1.Location = new System.Drawing.Point(3, 79);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(337, 67);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "BIOS Type";
            // 
            // tableLayoutPanel10
            // 
            this.tableLayoutPanel10.ColumnCount = 3;
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38F));
            this.tableLayoutPanel10.Controls.Add(this.radioButtonCustomized, 2, 0);
            this.tableLayoutPanel10.Controls.Add(this.radioButtonCrb, 0, 0);
            this.tableLayoutPanel10.Controls.Add(this.radioButtonStandard, 1, 0);
            this.tableLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel10.Location = new System.Drawing.Point(3, 24);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.RowCount = 1;
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel10.Size = new System.Drawing.Size(331, 39);
            this.tableLayoutPanel10.TabIndex = 27;
            // 
            // radioButtonCustomized
            // 
            this.radioButtonCustomized.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonCustomized.AutoSize = true;
            this.radioButtonCustomized.Location = new System.Drawing.Point(207, 8);
            this.radioButtonCustomized.Name = "radioButtonCustomized";
            this.radioButtonCustomized.Size = new System.Drawing.Size(121, 23);
            this.radioButtonCustomized.TabIndex = 2;
            this.radioButtonCustomized.Text = "Customized";
            this.radioButtonCustomized.UseVisualStyleBackColor = true;
            this.radioButtonCustomized.CheckedChanged += new System.EventHandler(this.EnableControls);
            // 
            // radioButtonCrb
            // 
            this.radioButtonCrb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonCrb.AutoSize = true;
            this.radioButtonCrb.Location = new System.Drawing.Point(3, 8);
            this.radioButtonCrb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButtonCrb.Name = "radioButtonCrb";
            this.radioButtonCrb.Size = new System.Drawing.Size(73, 23);
            this.radioButtonCrb.TabIndex = 0;
            this.radioButtonCrb.Text = "CRB";
            this.radioButtonCrb.UseVisualStyleBackColor = true;
            this.radioButtonCrb.CheckedChanged += new System.EventHandler(this.EnableControls);
            // 
            // radioButtonStandard
            // 
            this.radioButtonStandard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonStandard.AutoSize = true;
            this.radioButtonStandard.Checked = true;
            this.radioButtonStandard.Location = new System.Drawing.Point(82, 8);
            this.radioButtonStandard.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButtonStandard.Name = "radioButtonStandard";
            this.radioButtonStandard.Size = new System.Drawing.Size(119, 23);
            this.radioButtonStandard.TabIndex = 1;
            this.radioButtonStandard.TabStop = true;
            this.radioButtonStandard.Text = "Standard";
            this.radioButtonStandard.UseVisualStyleBackColor = true;
            this.radioButtonStandard.CheckedChanged += new System.EventHandler(this.EnableControls);
            // 
            // groupBoxBiosType
            // 
            this.groupBoxBiosType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxBiosType.Controls.Add(this.tableLayoutPanel8);
            this.groupBoxBiosType.Location = new System.Drawing.Point(3, 4);
            this.groupBoxBiosType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxBiosType.Name = "groupBoxBiosType";
            this.groupBoxBiosType.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxBiosType.Size = new System.Drawing.Size(337, 67);
            this.groupBoxBiosType.TabIndex = 0;
            this.groupBoxBiosType.TabStop = false;
            this.groupBoxBiosType.Text = "Message Type";
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 3;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel8.Controls.Add(this.radioButtonMessage, 2, 0);
            this.tableLayoutPanel8.Controls.Add(this.radioButtonTag, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.radioButtonMark, 1, 0);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(3, 24);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 1;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(331, 39);
            this.tableLayoutPanel8.TabIndex = 27;
            // 
            // radioButtonMessage
            // 
            this.radioButtonMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonMessage.AutoSize = true;
            this.radioButtonMessage.Checked = true;
            this.radioButtonMessage.Location = new System.Drawing.Point(217, 8);
            this.radioButtonMessage.Name = "radioButtonMessage";
            this.radioButtonMessage.Size = new System.Drawing.Size(111, 23);
            this.radioButtonMessage.TabIndex = 2;
            this.radioButtonMessage.TabStop = true;
            this.radioButtonMessage.Text = "Message";
            this.radioButtonMessage.UseVisualStyleBackColor = true;
            this.radioButtonMessage.CheckedChanged += new System.EventHandler(this.EnableControls);
            // 
            // radioButtonTag
            // 
            this.radioButtonTag.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonTag.AutoSize = true;
            this.radioButtonTag.Location = new System.Drawing.Point(3, 8);
            this.radioButtonTag.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButtonTag.Name = "radioButtonTag";
            this.radioButtonTag.Size = new System.Drawing.Size(60, 23);
            this.radioButtonTag.TabIndex = 0;
            this.radioButtonTag.Text = "Tag";
            this.radioButtonTag.UseVisualStyleBackColor = true;
            this.radioButtonTag.CheckedChanged += new System.EventHandler(this.EnableControls);
            // 
            // radioButtonMark
            // 
            this.radioButtonMark.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonMark.AutoSize = true;
            this.radioButtonMark.Location = new System.Drawing.Point(69, 8);
            this.radioButtonMark.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButtonMark.Name = "radioButtonMark";
            this.radioButtonMark.Size = new System.Drawing.Size(142, 23);
            this.radioButtonMark.TabIndex = 1;
            this.radioButtonMark.Text = "Mark in history";
            this.radioButtonMark.UseVisualStyleBackColor = true;
            this.radioButtonMark.CheckedChanged += new System.EventHandler(this.EnableControls);
            // 
            // groupBoxModification
            // 
            this.groupBoxModification.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxModification.Controls.Add(this.tableLayoutPanel9);
            this.groupBoxModification.Location = new System.Drawing.Point(3, 271);
            this.groupBoxModification.Name = "groupBoxModification";
            this.groupBoxModification.Size = new System.Drawing.Size(337, 69);
            this.groupBoxModification.TabIndex = 8;
            this.groupBoxModification.TabStop = false;
            this.groupBoxModification.Text = "Modification Type";
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 3;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel9.Controls.Add(this.radioButtonFunctionRemove, 2, 0);
            this.tableLayoutPanel9.Controls.Add(this.radioButtonBugFix, 0, 0);
            this.tableLayoutPanel9.Controls.Add(this.radioButtonFunctionAdd, 1, 0);
            this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel9.Location = new System.Drawing.Point(3, 23);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 1;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(331, 43);
            this.tableLayoutPanel9.TabIndex = 28;
            // 
            // radioButtonFunctionRemove
            // 
            this.radioButtonFunctionRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonFunctionRemove.AutoSize = true;
            this.radioButtonFunctionRemove.Location = new System.Drawing.Point(200, 10);
            this.radioButtonFunctionRemove.Name = "radioButtonFunctionRemove";
            this.radioButtonFunctionRemove.Size = new System.Drawing.Size(128, 23);
            this.radioButtonFunctionRemove.TabIndex = 2;
            this.radioButtonFunctionRemove.Text = "Func. Remove";
            this.radioButtonFunctionRemove.UseVisualStyleBackColor = true;
            // 
            // radioButtonBugFix
            // 
            this.radioButtonBugFix.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonBugFix.AutoSize = true;
            this.radioButtonBugFix.Checked = true;
            this.radioButtonBugFix.Location = new System.Drawing.Point(3, 10);
            this.radioButtonBugFix.Name = "radioButtonBugFix";
            this.radioButtonBugFix.Size = new System.Drawing.Size(76, 23);
            this.radioButtonBugFix.TabIndex = 0;
            this.radioButtonBugFix.TabStop = true;
            this.radioButtonBugFix.Text = "Bug fix";
            this.radioButtonBugFix.UseVisualStyleBackColor = true;
            // 
            // radioButtonFunctionAdd
            // 
            this.radioButtonFunctionAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonFunctionAdd.AutoSize = true;
            this.radioButtonFunctionAdd.Location = new System.Drawing.Point(85, 10);
            this.radioButtonFunctionAdd.Name = "radioButtonFunctionAdd";
            this.radioButtonFunctionAdd.Size = new System.Drawing.Size(109, 23);
            this.radioButtonFunctionAdd.TabIndex = 1;
            this.radioButtonFunctionAdd.Text = "Func. Add";
            this.radioButtonFunctionAdd.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.AutoSize = true;
            this.tableLayoutPanel7.ColumnCount = 2;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel7.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.tableLayoutPanel1, 1, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(873, 630);
            this.tableLayoutPanel7.TabIndex = 26;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(873, 630);
            this.Controls.Add(this.tableLayoutPanel7);
            this.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "ADLink Commit Logger v0.2-2022-0224";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAdlinkLogo)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.groupBoxSignature.ResumeLayout(false);
            this.groupBoxSignature.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel10.ResumeLayout(false);
            this.tableLayoutPanel10.PerformLayout();
            this.groupBoxBiosType.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            this.groupBoxModification.ResumeLayout(false);
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel9.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBoxAdlinkLogo;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.TextBox textBoxTestCase;
        private System.Windows.Forms.TextBox textBoxModifyFiles;
        private System.Windows.Forms.Label labelModifyFiles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTestCase;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button buttonExport;
        private System.Windows.Forms.Button buttonImport;
        private System.Windows.Forms.Button buttonClipboard;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label labelIssueNumber;
        private System.Windows.Forms.Label labelSummary;
        private System.Windows.Forms.TextBox textBoxIssueNumber;
        private System.Windows.Forms.TextBox textBoxSummary;
        private System.Windows.Forms.GroupBox groupBoxSignature;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Button buttonToday;
        private System.Windows.Forms.Label labelAuthor;
        private System.Windows.Forms.TextBox textBoxSerialNumber;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.TextBox textBoxDate;
        private System.Windows.Forms.Label labelSerialnumber;
        private System.Windows.Forms.TextBox textBoxAuthor;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label labelProjectName;
        private System.Windows.Forms.Label labelCustomerName;
        private System.Windows.Forms.Label labelBiosVersion;
        private System.Windows.Forms.ComboBox comboBoxProjectName;
        private System.Windows.Forms.TextBox textBoxCustomerName;
        private System.Windows.Forms.TextBox textBoxBiosVersion;
        private System.Windows.Forms.CheckBox checkBoxSignature;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonCustomized;
        private System.Windows.Forms.RadioButton radioButtonStandard;
        private System.Windows.Forms.RadioButton radioButtonCrb;
        private System.Windows.Forms.GroupBox groupBoxBiosType;
        private System.Windows.Forms.RadioButton radioButtonMessage;
        private System.Windows.Forms.RadioButton radioButtonMark;
        private System.Windows.Forms.RadioButton radioButtonTag;
        private System.Windows.Forms.GroupBox groupBoxModification;
        private System.Windows.Forms.RadioButton radioButtonFunctionRemove;
        private System.Windows.Forms.RadioButton radioButtonFunctionAdd;
        private System.Windows.Forms.RadioButton radioButtonBugFix;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel10;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
    }
}

