﻿namespace Statistics
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.openHarFile = new System.Windows.Forms.OpenFileDialog();
			this.openHarButton = new System.Windows.Forms.Button();
			this.detailGroupBox = new System.Windows.Forms.GroupBox();
			this.legendGroupBox = new System.Windows.Forms.GroupBox();
			this.label14 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.multipleCallsBtn = new System.Windows.Forms.Button();
			this.simpleSplitContainer = new System.Windows.Forms.SplitContainer();
			this.viewBox = new System.Windows.Forms.TextBox();
			this.viewBoxCompare = new System.Windows.Forms.TextBox();
			this.comparedDataGrid = new System.Windows.Forms.DataGridView();
			this.simpleModeCheckbox = new System.Windows.Forms.CheckBox();
			this.showAllBtn = new System.Windows.Forms.Button();
			this.viewPageLoadBtn = new System.Windows.Forms.Button();
			this.loadFromUrlButton = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.totalGroupBox = new System.Windows.Forms.GroupBox();
			this.label15 = new System.Windows.Forms.Label();
			this.totalTimeLabel = new System.Windows.Forms.Label();
			this.compareTotalTimeLabel = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.improveTotalBlockingLabel = new System.Windows.Forms.Label();
			this.improvedTotalTimeLabel = new System.Windows.Forms.Label();
			this.improveTotalRecievedLabel = new System.Windows.Forms.Label();
			this.improveTotalWaitingLabel = new System.Windows.Forms.Label();
			this.improveTotalSentLabel = new System.Windows.Forms.Label();
			this.improveTotalConnectLabel = new System.Windows.Forms.Label();
			this.improveTotalDnsLabel = new System.Windows.Forms.Label();
			this.compareTotalRecievedLabel = new System.Windows.Forms.Label();
			this.compareTotalSentLabel = new System.Windows.Forms.Label();
			this.compareTotalDnsLabel = new System.Windows.Forms.Label();
			this.compareTotalConnectLabel = new System.Windows.Forms.Label();
			this.compareTotalWaitingLabel = new System.Windows.Forms.Label();
			this.compareTotalBlockingLabel = new System.Windows.Forms.Label();
			this.totalRecievedLabel = new System.Windows.Forms.Label();
			this.totalSentLabel = new System.Windows.Forms.Label();
			this.totalDnsLabel = new System.Windows.Forms.Label();
			this.totalConnectLabel = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.totalWaitingLabel = new System.Windows.Forms.Label();
			this.totalBlockingLabel = new System.Windows.Forms.Label();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.loadComparisonFromFileButton = new System.Windows.Forms.Button();
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.label16 = new System.Windows.Forms.Label();
			this.loadedFileLbl = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.loadedCompareFilelbl = new System.Windows.Forms.Label();
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.detailGroupBox.SuspendLayout();
			this.legendGroupBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.simpleSplitContainer)).BeginInit();
			this.simpleSplitContainer.Panel1.SuspendLayout();
			this.simpleSplitContainer.Panel2.SuspendLayout();
			this.simpleSplitContainer.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.comparedDataGrid)).BeginInit();
			this.totalGroupBox.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// openHarFile
			// 
			this.openHarFile.FileName = "openHarFile";
			// 
			// openHarButton
			// 
			this.openHarButton.Location = new System.Drawing.Point(16, 25);
			this.openHarButton.Name = "openHarButton";
			this.openHarButton.Size = new System.Drawing.Size(157, 42);
			this.openHarButton.TabIndex = 0;
			this.openHarButton.Text = "Open File";
			this.toolTip.SetToolTip(this.openHarButton, "Open a HAR file to view.");
			this.openHarButton.UseVisualStyleBackColor = true;
			this.openHarButton.Click += new System.EventHandler(this.openHarButton_Click);
			// 
			// detailGroupBox
			// 
			this.detailGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.detailGroupBox.Controls.Add(this.legendGroupBox);
			this.detailGroupBox.Controls.Add(this.multipleCallsBtn);
			this.detailGroupBox.Controls.Add(this.simpleSplitContainer);
			this.detailGroupBox.Controls.Add(this.comparedDataGrid);
			this.detailGroupBox.Controls.Add(this.simpleModeCheckbox);
			this.detailGroupBox.Controls.Add(this.showAllBtn);
			this.detailGroupBox.Controls.Add(this.viewPageLoadBtn);
			this.detailGroupBox.Enabled = false;
			this.detailGroupBox.Location = new System.Drawing.Point(34, 230);
			this.detailGroupBox.Name = "detailGroupBox";
			this.detailGroupBox.Size = new System.Drawing.Size(877, 324);
			this.detailGroupBox.TabIndex = 1;
			this.detailGroupBox.TabStop = false;
			this.detailGroupBox.Text = "details";
			// 
			// legendGroupBox
			// 
			this.legendGroupBox.Controls.Add(this.label14);
			this.legendGroupBox.Controls.Add(this.label13);
			this.legendGroupBox.Controls.Add(this.label12);
			this.legendGroupBox.Controls.Add(this.label11);
			this.legendGroupBox.Location = new System.Drawing.Point(454, 9);
			this.legendGroupBox.Name = "legendGroupBox";
			this.legendGroupBox.Size = new System.Drawing.Size(416, 116);
			this.legendGroupBox.TabIndex = 23;
			this.legendGroupBox.TabStop = false;
			this.legendGroupBox.Text = "Legend";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.BackColor = System.Drawing.Color.Red;
			this.label14.Location = new System.Drawing.Point(7, 82);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(363, 20);
			this.label14.TabIndex = 3;
			this.label14.Text = "Cells with a red backround take longer than before";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.BackColor = System.Drawing.Color.Green;
			this.label13.Location = new System.Drawing.Point(7, 62);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(379, 20);
			this.label13.TabIndex = 2;
			this.label13.Text = "Cells with a green background are faster than before";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.BackColor = System.Drawing.Color.LightGreen;
			this.label12.Location = new System.Drawing.Point(6, 42);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(369, 20);
			this.label12.TabIndex = 1;
			this.label12.Text = "Rows with a green background are no longer called";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.BackColor = System.Drawing.Color.LightPink;
			this.label11.Location = new System.Drawing.Point(6, 22);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(310, 20);
			this.label11.TabIndex = 0;
			this.label11.Text = "Rows with a pink background are new calls";
			// 
			// multipleCallsBtn
			// 
			this.multipleCallsBtn.Location = new System.Drawing.Point(7, 69);
			this.multipleCallsBtn.Name = "multipleCallsBtn";
			this.multipleCallsBtn.Size = new System.Drawing.Size(173, 37);
			this.multipleCallsBtn.TabIndex = 22;
			this.multipleCallsBtn.Text = "Show Multiple Calls";
			this.toolTip.SetToolTip(this.multipleCallsBtn, "Show calls that are called multiple times in the same Har file.");
			this.multipleCallsBtn.UseVisualStyleBackColor = true;
			this.multipleCallsBtn.Click += new System.EventHandler(this.multipleCallsBtn_Click);
			// 
			// simpleSplitContainer
			// 
			this.simpleSplitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.simpleSplitContainer.Location = new System.Drawing.Point(7, 148);
			this.simpleSplitContainer.Name = "simpleSplitContainer";
			// 
			// simpleSplitContainer.Panel1
			// 
			this.simpleSplitContainer.Panel1.Controls.Add(this.viewBox);
			// 
			// simpleSplitContainer.Panel2
			// 
			this.simpleSplitContainer.Panel2.Controls.Add(this.viewBoxCompare);
			this.simpleSplitContainer.Size = new System.Drawing.Size(855, 170);
			this.simpleSplitContainer.SplitterDistance = 366;
			this.simpleSplitContainer.SplitterWidth = 10;
			this.simpleSplitContainer.TabIndex = 21;
			this.simpleSplitContainer.Visible = false;
			// 
			// viewBox
			// 
			this.viewBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.viewBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.viewBox.Location = new System.Drawing.Point(0, 0);
			this.viewBox.Multiline = true;
			this.viewBox.Name = "viewBox";
			this.viewBox.ReadOnly = true;
			this.viewBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.viewBox.Size = new System.Drawing.Size(366, 170);
			this.viewBox.TabIndex = 3;
			this.viewBox.WordWrap = false;
			// 
			// viewBoxCompare
			// 
			this.viewBoxCompare.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.viewBoxCompare.Dock = System.Windows.Forms.DockStyle.Fill;
			this.viewBoxCompare.Location = new System.Drawing.Point(0, 0);
			this.viewBoxCompare.Multiline = true;
			this.viewBoxCompare.Name = "viewBoxCompare";
			this.viewBoxCompare.ReadOnly = true;
			this.viewBoxCompare.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.viewBoxCompare.Size = new System.Drawing.Size(479, 170);
			this.viewBoxCompare.TabIndex = 17;
			this.viewBoxCompare.WordWrap = false;
			// 
			// comparedDataGrid
			// 
			this.comparedDataGrid.AllowUserToOrderColumns = true;
			this.comparedDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.comparedDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.comparedDataGrid.Location = new System.Drawing.Point(6, 138);
			this.comparedDataGrid.Name = "comparedDataGrid";
			this.comparedDataGrid.RowTemplate.Height = 28;
			this.comparedDataGrid.Size = new System.Drawing.Size(856, 177);
			this.comparedDataGrid.TabIndex = 18;
			// 
			// simpleModeCheckbox
			// 
			this.simpleModeCheckbox.AutoSize = true;
			this.simpleModeCheckbox.Location = new System.Drawing.Point(163, 26);
			this.simpleModeCheckbox.Name = "simpleModeCheckbox";
			this.simpleModeCheckbox.Size = new System.Drawing.Size(127, 24);
			this.simpleModeCheckbox.TabIndex = 19;
			this.simpleModeCheckbox.Text = "Simple Mode";
			this.toolTip.SetToolTip(this.simpleModeCheckbox, "View simple display of the 2 HAR files.");
			this.simpleModeCheckbox.UseVisualStyleBackColor = true;
			this.simpleModeCheckbox.CheckedChanged += new System.EventHandler(this.simpleModeCheckbox_CheckedChanged);
			// 
			// showAllBtn
			// 
			this.showAllBtn.Location = new System.Drawing.Point(8, 26);
			this.showAllBtn.Name = "showAllBtn";
			this.showAllBtn.Size = new System.Drawing.Size(149, 37);
			this.showAllBtn.TabIndex = 2;
			this.showAllBtn.Tag = "Order by new time";
			this.showAllBtn.Text = "Show All";
			this.toolTip.SetToolTip(this.showAllBtn, "Show all entries ordered from longest new time to shortest new time");
			this.showAllBtn.UseVisualStyleBackColor = true;
			this.showAllBtn.Click += new System.EventHandler(this.showAllBtn_Click);
			// 
			// viewPageLoadBtn
			// 
			this.viewPageLoadBtn.Location = new System.Drawing.Point(8, 69);
			this.viewPageLoadBtn.Name = "viewPageLoadBtn";
			this.viewPageLoadBtn.Size = new System.Drawing.Size(149, 37);
			this.viewPageLoadBtn.TabIndex = 0;
			this.viewPageLoadBtn.Text = "View Page Load";
			this.viewPageLoadBtn.UseVisualStyleBackColor = true;
			this.viewPageLoadBtn.Visible = false;
			this.viewPageLoadBtn.Click += new System.EventHandler(this.viewPageLoadBtn_Click);
			// 
			// loadFromUrlButton
			// 
			this.loadFromUrlButton.Enabled = false;
			this.loadFromUrlButton.Location = new System.Drawing.Point(16, 112);
			this.loadFromUrlButton.Name = "loadFromUrlButton";
			this.loadFromUrlButton.Size = new System.Drawing.Size(157, 37);
			this.loadFromUrlButton.TabIndex = 3;
			this.loadFromUrlButton.Text = "Compare with Live";
			this.toolTip.SetToolTip(this.loadFromUrlButton, "Compare with the URL in the initial entry of the HAR file.");
			this.loadFromUrlButton.UseVisualStyleBackColor = true;
			this.loadFromUrlButton.Click += new System.EventHandler(this.loadFromUrlButton_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(78, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(69, 20);
			this.label1.TabIndex = 4;
			this.label1.Text = "Blocking";
			this.toolTip.SetToolTip(this.label1, "Filter to only those with a Block time.  Order by longest new Block time to short" +
        "est.");
			this.label1.Click += new System.EventHandler(this.totalBlockingLabel_Click);
			// 
			// totalGroupBox
			// 
			this.totalGroupBox.Controls.Add(this.label15);
			this.totalGroupBox.Controls.Add(this.totalTimeLabel);
			this.totalGroupBox.Controls.Add(this.compareTotalTimeLabel);
			this.totalGroupBox.Controls.Add(this.label10);
			this.totalGroupBox.Controls.Add(this.label9);
			this.totalGroupBox.Controls.Add(this.label8);
			this.totalGroupBox.Controls.Add(this.label7);
			this.totalGroupBox.Controls.Add(this.groupBox1);
			this.totalGroupBox.Controls.Add(this.compareTotalRecievedLabel);
			this.totalGroupBox.Controls.Add(this.compareTotalSentLabel);
			this.totalGroupBox.Controls.Add(this.compareTotalDnsLabel);
			this.totalGroupBox.Controls.Add(this.compareTotalConnectLabel);
			this.totalGroupBox.Controls.Add(this.compareTotalWaitingLabel);
			this.totalGroupBox.Controls.Add(this.compareTotalBlockingLabel);
			this.totalGroupBox.Controls.Add(this.totalRecievedLabel);
			this.totalGroupBox.Controls.Add(this.totalSentLabel);
			this.totalGroupBox.Controls.Add(this.totalDnsLabel);
			this.totalGroupBox.Controls.Add(this.totalConnectLabel);
			this.totalGroupBox.Controls.Add(this.label5);
			this.totalGroupBox.Controls.Add(this.label6);
			this.totalGroupBox.Controls.Add(this.label2);
			this.totalGroupBox.Controls.Add(this.label4);
			this.totalGroupBox.Controls.Add(this.label3);
			this.totalGroupBox.Controls.Add(this.totalWaitingLabel);
			this.totalGroupBox.Controls.Add(this.totalBlockingLabel);
			this.totalGroupBox.Controls.Add(this.label1);
			this.totalGroupBox.Enabled = false;
			this.totalGroupBox.Location = new System.Drawing.Point(179, 25);
			this.totalGroupBox.Name = "totalGroupBox";
			this.totalGroupBox.Size = new System.Drawing.Size(802, 136);
			this.totalGroupBox.TabIndex = 2;
			this.totalGroupBox.TabStop = false;
			this.totalGroupBox.Text = "Totals";
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(153, 0);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(270, 20);
			this.label15.TabIndex = 5;
			this.label15.Text = "Click on the labels to filter the results.";
			// 
			// totalTimeLabel
			// 
			this.totalTimeLabel.Location = new System.Drawing.Point(505, 45);
			this.totalTimeLabel.Name = "totalTimeLabel";
			this.totalTimeLabel.Size = new System.Drawing.Size(62, 21);
			this.totalTimeLabel.TabIndex = 35;
			this.totalTimeLabel.Text = "-1";
			this.toolTip.SetToolTip(this.totalTimeLabel, "Remove filters and order from longest Total Time to shortes Total Time.");
			this.totalTimeLabel.Click += new System.EventHandler(this.showAllBtn_Click);
			// 
			// compareTotalTimeLabel
			// 
			this.compareTotalTimeLabel.Location = new System.Drawing.Point(505, 68);
			this.compareTotalTimeLabel.Name = "compareTotalTimeLabel";
			this.compareTotalTimeLabel.Size = new System.Drawing.Size(62, 21);
			this.compareTotalTimeLabel.TabIndex = 33;
			this.compareTotalTimeLabel.Text = "-1";
			this.toolTip.SetToolTip(this.compareTotalTimeLabel, "Remove filters and order from longest Total Time to shortes Total Time.");
			this.compareTotalTimeLabel.Click += new System.EventHandler(this.showAllBtn_Click);
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(505, 22);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(78, 20);
			this.label10.TabIndex = 32;
			this.label10.Text = "TotalTime";
			this.toolTip.SetToolTip(this.label10, "Remove filters and order from longest Total Time to shortes Total Time.");
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(2, 111);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(83, 20);
			this.label9.TabIndex = 31;
			this.label9.Text = "Difference";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(2, 68);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(62, 20);
			this.label8.TabIndex = 30;
			this.label8.Text = "Current";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(2, 46);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(34, 20);
			this.label7.TabIndex = 29;
			this.label7.Text = "File";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.improveTotalBlockingLabel);
			this.groupBox1.Controls.Add(this.improvedTotalTimeLabel);
			this.groupBox1.Controls.Add(this.improveTotalRecievedLabel);
			this.groupBox1.Controls.Add(this.improveTotalWaitingLabel);
			this.groupBox1.Controls.Add(this.improveTotalSentLabel);
			this.groupBox1.Controls.Add(this.improveTotalConnectLabel);
			this.groupBox1.Controls.Add(this.improveTotalDnsLabel);
			this.groupBox1.Location = new System.Drawing.Point(78, 91);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(731, 45);
			this.groupBox1.TabIndex = 28;
			this.groupBox1.TabStop = false;
			// 
			// improveTotalBlockingLabel
			// 
			this.improveTotalBlockingLabel.Location = new System.Drawing.Point(6, 20);
			this.improveTotalBlockingLabel.Name = "improveTotalBlockingLabel";
			this.improveTotalBlockingLabel.Size = new System.Drawing.Size(65, 21);
			this.improveTotalBlockingLabel.TabIndex = 22;
			this.improveTotalBlockingLabel.Text = "-1";
			this.toolTip.SetToolTip(this.improveTotalBlockingLabel, "Filter to only those with a Block time.  Order by longest new Block time to short" +
        "est.");
			this.improveTotalBlockingLabel.Click += new System.EventHandler(this.totalBlockingLabel_Click);
			// 
			// improvedTotalTimeLabel
			// 
			this.improvedTotalTimeLabel.Location = new System.Drawing.Point(427, 19);
			this.improvedTotalTimeLabel.Name = "improvedTotalTimeLabel";
			this.improvedTotalTimeLabel.Size = new System.Drawing.Size(62, 21);
			this.improvedTotalTimeLabel.TabIndex = 34;
			this.improvedTotalTimeLabel.Text = "-1";
			this.toolTip.SetToolTip(this.improvedTotalTimeLabel, "Remove filters and order from longest Total Time to shortes Total Time.");
			this.improvedTotalTimeLabel.Click += new System.EventHandler(this.showAllBtn_Click);
			// 
			// improveTotalRecievedLabel
			// 
			this.improveTotalRecievedLabel.Location = new System.Drawing.Point(337, 20);
			this.improveTotalRecievedLabel.Name = "improveTotalRecievedLabel";
			this.improveTotalRecievedLabel.Size = new System.Drawing.Size(62, 21);
			this.improveTotalRecievedLabel.TabIndex = 27;
			this.improveTotalRecievedLabel.Text = "-1";
			this.toolTip.SetToolTip(this.improveTotalRecievedLabel, "Filter to only those with a Recieved time.  Order by longest new Recieved time to" +
        " shortest.");
			this.improveTotalRecievedLabel.Click += new System.EventHandler(this.totalRecievedLabel_Click);
			// 
			// improveTotalWaitingLabel
			// 
			this.improveTotalWaitingLabel.Location = new System.Drawing.Point(77, 20);
			this.improveTotalWaitingLabel.Name = "improveTotalWaitingLabel";
			this.improveTotalWaitingLabel.Size = new System.Drawing.Size(62, 21);
			this.improveTotalWaitingLabel.TabIndex = 23;
			this.improveTotalWaitingLabel.Text = "-1";
			this.toolTip.SetToolTip(this.improveTotalWaitingLabel, "Filter to only those with a Wait time.  Order by longest new Wait time to shortes" +
        "t.");
			this.improveTotalWaitingLabel.Click += new System.EventHandler(this.totalWaitingLabel_Click);
			// 
			// improveTotalSentLabel
			// 
			this.improveTotalSentLabel.Location = new System.Drawing.Point(262, 20);
			this.improveTotalSentLabel.Name = "improveTotalSentLabel";
			this.improveTotalSentLabel.Size = new System.Drawing.Size(65, 21);
			this.improveTotalSentLabel.TabIndex = 26;
			this.improveTotalSentLabel.Text = "-1";
			this.toolTip.SetToolTip(this.improveTotalSentLabel, "Filter to only those with a Sent time.  Order by longest new Sent time to shortes" +
        "t.");
			this.improveTotalSentLabel.Click += new System.EventHandler(this.totalSentLabel_Click);
			// 
			// improveTotalConnectLabel
			// 
			this.improveTotalConnectLabel.Location = new System.Drawing.Point(145, 20);
			this.improveTotalConnectLabel.Name = "improveTotalConnectLabel";
			this.improveTotalConnectLabel.Size = new System.Drawing.Size(65, 21);
			this.improveTotalConnectLabel.TabIndex = 24;
			this.improveTotalConnectLabel.Text = "-1";
			this.toolTip.SetToolTip(this.improveTotalConnectLabel, "Filter to only those with a Connect time.  Order by longest new Connect time to s" +
        "hortest.");
			this.improveTotalConnectLabel.Click += new System.EventHandler(this.totalConnectLabel_Click);
			// 
			// improveTotalDnsLabel
			// 
			this.improveTotalDnsLabel.Location = new System.Drawing.Point(220, 20);
			this.improveTotalDnsLabel.Name = "improveTotalDnsLabel";
			this.improveTotalDnsLabel.Size = new System.Drawing.Size(38, 21);
			this.improveTotalDnsLabel.TabIndex = 25;
			this.improveTotalDnsLabel.Text = "-1";
			this.toolTip.SetToolTip(this.improveTotalDnsLabel, "Filter to only those with a DNS time.  Order by longest new DNS time to shortest." +
        "");
			this.improveTotalDnsLabel.Click += new System.EventHandler(this.totalDnsLabel_Click);
			// 
			// compareTotalRecievedLabel
			// 
			this.compareTotalRecievedLabel.Location = new System.Drawing.Point(415, 67);
			this.compareTotalRecievedLabel.Name = "compareTotalRecievedLabel";
			this.compareTotalRecievedLabel.Size = new System.Drawing.Size(62, 21);
			this.compareTotalRecievedLabel.TabIndex = 21;
			this.compareTotalRecievedLabel.Text = "-1";
			this.toolTip.SetToolTip(this.compareTotalRecievedLabel, "Filter to only those with a Recieved time.  Order by longest new Recieved time to" +
        " shortest.");
			this.compareTotalRecievedLabel.Click += new System.EventHandler(this.totalRecievedLabel_Click);
			// 
			// compareTotalSentLabel
			// 
			this.compareTotalSentLabel.Location = new System.Drawing.Point(340, 67);
			this.compareTotalSentLabel.Name = "compareTotalSentLabel";
			this.compareTotalSentLabel.Size = new System.Drawing.Size(65, 21);
			this.compareTotalSentLabel.TabIndex = 20;
			this.compareTotalSentLabel.Text = "-1";
			this.toolTip.SetToolTip(this.compareTotalSentLabel, "Filter to only those with a Sent time.  Order by longest new Sent time to shortes" +
        "t.");
			this.compareTotalSentLabel.Click += new System.EventHandler(this.totalSentLabel_Click);
			// 
			// compareTotalDnsLabel
			// 
			this.compareTotalDnsLabel.Location = new System.Drawing.Point(296, 67);
			this.compareTotalDnsLabel.Name = "compareTotalDnsLabel";
			this.compareTotalDnsLabel.Size = new System.Drawing.Size(38, 21);
			this.compareTotalDnsLabel.TabIndex = 19;
			this.compareTotalDnsLabel.Text = "-1";
			this.toolTip.SetToolTip(this.compareTotalDnsLabel, "Filter to only those with a DNS time.  Order by longest new DNS time to shortest." +
        "");
			this.compareTotalDnsLabel.Click += new System.EventHandler(this.totalDnsLabel_Click);
			// 
			// compareTotalConnectLabel
			// 
			this.compareTotalConnectLabel.Location = new System.Drawing.Point(221, 67);
			this.compareTotalConnectLabel.Name = "compareTotalConnectLabel";
			this.compareTotalConnectLabel.Size = new System.Drawing.Size(65, 21);
			this.compareTotalConnectLabel.TabIndex = 18;
			this.compareTotalConnectLabel.Text = "-1";
			this.toolTip.SetToolTip(this.compareTotalConnectLabel, "Filter to only those with a Connect time.  Order by longest new Connect time to s" +
        "hortest.");
			this.compareTotalConnectLabel.Click += new System.EventHandler(this.totalConnectLabel_Click);
			// 
			// compareTotalWaitingLabel
			// 
			this.compareTotalWaitingLabel.Location = new System.Drawing.Point(153, 67);
			this.compareTotalWaitingLabel.Name = "compareTotalWaitingLabel";
			this.compareTotalWaitingLabel.Size = new System.Drawing.Size(62, 21);
			this.compareTotalWaitingLabel.TabIndex = 17;
			this.compareTotalWaitingLabel.Text = "-1";
			this.toolTip.SetToolTip(this.compareTotalWaitingLabel, "Filter to only those with a Wait time.  Order by longest new Wait time to shortes" +
        "t.");
			this.compareTotalWaitingLabel.Click += new System.EventHandler(this.totalWaitingLabel_Click);
			// 
			// compareTotalBlockingLabel
			// 
			this.compareTotalBlockingLabel.Location = new System.Drawing.Point(82, 67);
			this.compareTotalBlockingLabel.Name = "compareTotalBlockingLabel";
			this.compareTotalBlockingLabel.Size = new System.Drawing.Size(65, 21);
			this.compareTotalBlockingLabel.TabIndex = 16;
			this.compareTotalBlockingLabel.Text = "-1";
			this.toolTip.SetToolTip(this.compareTotalBlockingLabel, "Filter to only those with a Block time.  Order by longest new Block time to short" +
        "est.");
			this.compareTotalBlockingLabel.Click += new System.EventHandler(this.totalBlockingLabel_Click);
			// 
			// totalRecievedLabel
			// 
			this.totalRecievedLabel.Location = new System.Drawing.Point(415, 46);
			this.totalRecievedLabel.Name = "totalRecievedLabel";
			this.totalRecievedLabel.Size = new System.Drawing.Size(62, 21);
			this.totalRecievedLabel.TabIndex = 15;
			this.totalRecievedLabel.Text = "-1";
			this.toolTip.SetToolTip(this.totalRecievedLabel, "Filter to only those with a Recieved time.  Order by longest new Recieved time to" +
        " shortest.");
			this.totalRecievedLabel.Click += new System.EventHandler(this.totalRecievedLabel_Click);
			// 
			// totalSentLabel
			// 
			this.totalSentLabel.Location = new System.Drawing.Point(340, 46);
			this.totalSentLabel.Name = "totalSentLabel";
			this.totalSentLabel.Size = new System.Drawing.Size(65, 21);
			this.totalSentLabel.TabIndex = 14;
			this.totalSentLabel.Text = "-1";
			this.toolTip.SetToolTip(this.totalSentLabel, "Filter to only those with a Sent time.  Order by longest new Sent time to shortes" +
        "t.");
			this.totalSentLabel.Click += new System.EventHandler(this.totalSentLabel_Click);
			// 
			// totalDnsLabel
			// 
			this.totalDnsLabel.Location = new System.Drawing.Point(296, 46);
			this.totalDnsLabel.Name = "totalDnsLabel";
			this.totalDnsLabel.Size = new System.Drawing.Size(38, 21);
			this.totalDnsLabel.TabIndex = 13;
			this.totalDnsLabel.Text = "-1";
			this.toolTip.SetToolTip(this.totalDnsLabel, "Filter to only those with a DNS time.  Order by longest new DNS time to shortest." +
        "");
			this.totalDnsLabel.Click += new System.EventHandler(this.totalDnsLabel_Click);
			// 
			// totalConnectLabel
			// 
			this.totalConnectLabel.Location = new System.Drawing.Point(221, 46);
			this.totalConnectLabel.Name = "totalConnectLabel";
			this.totalConnectLabel.Size = new System.Drawing.Size(65, 21);
			this.totalConnectLabel.TabIndex = 12;
			this.totalConnectLabel.Text = "-1";
			this.toolTip.SetToolTip(this.totalConnectLabel, "Filter to only those with a Connect time.  Order by longest new Connect time to s" +
        "hortest.");
			this.totalConnectLabel.Click += new System.EventHandler(this.totalConnectLabel_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(415, 22);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(75, 20);
			this.label5.TabIndex = 11;
			this.label5.Text = "Recieved";
			this.toolTip.SetToolTip(this.label5, "Filter to only those with a Recieved time.  Order by longest new Recieved time to" +
        " shortest.");
			this.label5.Click += new System.EventHandler(this.totalRecievedLabel_Click);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(340, 22);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(43, 20);
			this.label6.TabIndex = 10;
			this.label6.Text = "Sent";
			this.toolTip.SetToolTip(this.label6, "Filter to only those with a Sent time.  Order by longest new Sent time to shortes" +
        "t.");
			this.label6.Click += new System.EventHandler(this.totalSentLabel_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(296, 22);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(38, 20);
			this.label2.TabIndex = 9;
			this.label2.Text = "Dns";
			this.toolTip.SetToolTip(this.label2, "Filter to only those with a DNS time.  Order by longest new DNS time to shortest." +
        "");
			this.label2.Click += new System.EventHandler(this.totalDnsLabel_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(221, 22);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(69, 20);
			this.label4.TabIndex = 8;
			this.label4.Text = "Connect";
			this.toolTip.SetToolTip(this.label4, "Filter to only those with a Connect time.  Order by longest new Connect time to s" +
        "hortest.");
			this.label4.Click += new System.EventHandler(this.totalConnectLabel_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(153, 22);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(62, 20);
			this.label3.TabIndex = 7;
			this.label3.Text = "Waiting";
			this.toolTip.SetToolTip(this.label3, "Filter to only those with a Wait time.  Order by longest new Wait time to shortes" +
        "t.");
			this.label3.Click += new System.EventHandler(this.totalWaitingLabel_Click);
			// 
			// totalWaitingLabel
			// 
			this.totalWaitingLabel.Location = new System.Drawing.Point(153, 46);
			this.totalWaitingLabel.Name = "totalWaitingLabel";
			this.totalWaitingLabel.Size = new System.Drawing.Size(62, 21);
			this.totalWaitingLabel.TabIndex = 6;
			this.totalWaitingLabel.Text = "-1";
			this.toolTip.SetToolTip(this.totalWaitingLabel, "Filter to only those with a Wait time.  Order by longest new Wait time to shortes" +
        "t.");
			this.totalWaitingLabel.Click += new System.EventHandler(this.totalWaitingLabel_Click);
			// 
			// totalBlockingLabel
			// 
			this.totalBlockingLabel.Location = new System.Drawing.Point(82, 46);
			this.totalBlockingLabel.Name = "totalBlockingLabel";
			this.totalBlockingLabel.Size = new System.Drawing.Size(65, 21);
			this.totalBlockingLabel.TabIndex = 5;
			this.totalBlockingLabel.Text = "-1";
			this.toolTip.SetToolTip(this.totalBlockingLabel, "Filter to only those with a Block time.  Order by longest new Block time to short" +
        "est.");
			this.totalBlockingLabel.Click += new System.EventHandler(this.totalBlockingLabel_Click);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.loadComparisonFromFileButton);
			this.groupBox3.Controls.Add(this.totalGroupBox);
			this.groupBox3.Controls.Add(this.openHarButton);
			this.groupBox3.Controls.Add(this.loadFromUrlButton);
			this.groupBox3.Location = new System.Drawing.Point(34, 50);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(872, 174);
			this.groupBox3.TabIndex = 4;
			this.groupBox3.TabStop = false;
			// 
			// loadComparisonFromFileButton
			// 
			this.loadComparisonFromFileButton.Enabled = false;
			this.loadComparisonFromFileButton.Location = new System.Drawing.Point(16, 73);
			this.loadComparisonFromFileButton.Name = "loadComparisonFromFileButton";
			this.loadComparisonFromFileButton.Size = new System.Drawing.Size(157, 33);
			this.loadComparisonFromFileButton.TabIndex = 4;
			this.loadComparisonFromFileButton.Text = "Compare with File";
			this.toolTip.SetToolTip(this.loadComparisonFromFileButton, "Compare with another HAR file.");
			this.loadComparisonFromFileButton.UseVisualStyleBackColor = true;
			this.loadComparisonFromFileButton.Click += new System.EventHandler(this.loadComparisonFromFileButton_Click);
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Location = new System.Drawing.Point(42, 2);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(96, 20);
			this.label16.TabIndex = 5;
			this.label16.Text = "File Loaded:";
			// 
			// loadedFileLbl
			// 
			this.loadedFileLbl.AutoSize = true;
			this.loadedFileLbl.Location = new System.Drawing.Point(160, 2);
			this.loadedFileLbl.Name = "loadedFileLbl";
			this.loadedFileLbl.Size = new System.Drawing.Size(54, 20);
			this.loadedFileLbl.TabIndex = 6;
			this.loadedFileLbl.Text = "NONE";
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Location = new System.Drawing.Point(46, 26);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(113, 20);
			this.label17.TabIndex = 7;
			this.label17.Text = "Compared To :";
			// 
			// loadedCompareFilelbl
			// 
			this.loadedCompareFilelbl.AutoSize = true;
			this.loadedCompareFilelbl.Location = new System.Drawing.Point(160, 27);
			this.loadedCompareFilelbl.Name = "loadedCompareFilelbl";
			this.loadedCompareFilelbl.Size = new System.Drawing.Size(54, 20);
			this.loadedCompareFilelbl.TabIndex = 8;
			this.loadedCompareFilelbl.Text = "NONE";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(974, 566);
			this.Controls.Add(this.loadedCompareFilelbl);
			this.Controls.Add(this.label17);
			this.Controls.Add(this.loadedFileLbl);
			this.Controls.Add(this.label16);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.detailGroupBox);
			this.Name = "Form1";
			this.Text = "Statistics";
			this.detailGroupBox.ResumeLayout(false);
			this.detailGroupBox.PerformLayout();
			this.legendGroupBox.ResumeLayout(false);
			this.legendGroupBox.PerformLayout();
			this.simpleSplitContainer.Panel1.ResumeLayout(false);
			this.simpleSplitContainer.Panel1.PerformLayout();
			this.simpleSplitContainer.Panel2.ResumeLayout(false);
			this.simpleSplitContainer.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.simpleSplitContainer)).EndInit();
			this.simpleSplitContainer.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.comparedDataGrid)).EndInit();
			this.totalGroupBox.ResumeLayout(false);
			this.totalGroupBox.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.OpenFileDialog openHarFile;
		private System.Windows.Forms.Button openHarButton;
		private System.Windows.Forms.GroupBox detailGroupBox;
		private System.Windows.Forms.Button viewPageLoadBtn;
		private System.Windows.Forms.Button showAllBtn;
		private System.Windows.Forms.TextBox viewBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox totalGroupBox;
		private System.Windows.Forms.Label totalBlockingLabel;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label totalWaitingLabel;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label totalRecievedLabel;
		private System.Windows.Forms.Label totalSentLabel;
		private System.Windows.Forms.Label totalDnsLabel;
		private System.Windows.Forms.Label totalConnectLabel;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Button loadFromUrlButton;
		private System.Windows.Forms.Label improveTotalRecievedLabel;
		private System.Windows.Forms.Label improveTotalSentLabel;
		private System.Windows.Forms.Label improveTotalDnsLabel;
		private System.Windows.Forms.Label improveTotalConnectLabel;
		private System.Windows.Forms.Label improveTotalWaitingLabel;
		private System.Windows.Forms.Label improveTotalBlockingLabel;
		private System.Windows.Forms.Label compareTotalRecievedLabel;
		private System.Windows.Forms.Label compareTotalSentLabel;
		private System.Windows.Forms.Label compareTotalDnsLabel;
		private System.Windows.Forms.Label compareTotalConnectLabel;
		private System.Windows.Forms.Label compareTotalWaitingLabel;
		private System.Windows.Forms.Label compareTotalBlockingLabel;
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
		private System.Windows.Forms.TextBox viewBoxCompare;
		private System.Windows.Forms.DataGridView comparedDataGrid;
		private System.Windows.Forms.CheckBox simpleModeCheckbox;
		private System.Windows.Forms.SplitContainer simpleSplitContainer;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label totalTimeLabel;
		private System.Windows.Forms.Label compareTotalTimeLabel;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label improvedTotalTimeLabel;
		private System.Windows.Forms.Button loadComparisonFromFileButton;
		private System.Windows.Forms.Button multipleCallsBtn;
		private System.Windows.Forms.GroupBox legendGroupBox;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label loadedFileLbl;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label loadedCompareFilelbl;
		private System.Windows.Forms.ToolTip toolTip;
	}
}

