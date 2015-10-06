namespace Statistics
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
			this.openHarFile = new System.Windows.Forms.OpenFileDialog();
			this.openHarButton = new System.Windows.Forms.Button();
			this.detailGroupBox = new System.Windows.Forms.GroupBox();
			this.viewBoxCompare = new System.Windows.Forms.TextBox();
			this.loadFromUrlButton = new System.Windows.Forms.Button();
			this.viewBox = new System.Windows.Forms.TextBox();
			this.showAllBtn = new System.Windows.Forms.Button();
			this.viewPageLoadBtn = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.totalGroupBox = new System.Windows.Forms.GroupBox();
			this.improveTotalRecievedLabel = new System.Windows.Forms.Label();
			this.improveTotalSentLabel = new System.Windows.Forms.Label();
			this.improveTotalDnsLabel = new System.Windows.Forms.Label();
			this.improveTotalConnectLabel = new System.Windows.Forms.Label();
			this.improveTotalWaitingLabel = new System.Windows.Forms.Label();
			this.improveTotalBlockingLabel = new System.Windows.Forms.Label();
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
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.comparedDataGrid = new System.Windows.Forms.DataGridView();
			this.simpleModeCheckbox = new System.Windows.Forms.CheckBox();
			this.simpleSplitContainer = new System.Windows.Forms.SplitContainer();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.totalTimeLabel = new System.Windows.Forms.Label();
			this.improvedTotalTimeLabel = new System.Windows.Forms.Label();
			this.compareTotalTimeLabel = new System.Windows.Forms.Label();
			this.loadComparisonFromFileButton = new System.Windows.Forms.Button();
			this.multipleCallsBtn = new System.Windows.Forms.Button();
			this.detailGroupBox.SuspendLayout();
			this.totalGroupBox.SuspendLayout();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.comparedDataGrid)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.simpleSplitContainer)).BeginInit();
			this.simpleSplitContainer.Panel1.SuspendLayout();
			this.simpleSplitContainer.Panel2.SuspendLayout();
			this.simpleSplitContainer.SuspendLayout();
			this.groupBox1.SuspendLayout();
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
			this.openHarButton.UseVisualStyleBackColor = true;
			this.openHarButton.Click += new System.EventHandler(this.openHarButton_Click);
			// 
			// detailGroupBox
			// 
			this.detailGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.detailGroupBox.Controls.Add(this.multipleCallsBtn);
			this.detailGroupBox.Controls.Add(this.simpleSplitContainer);
			this.detailGroupBox.Controls.Add(this.comparedDataGrid);
			this.detailGroupBox.Controls.Add(this.simpleModeCheckbox);
			this.detailGroupBox.Controls.Add(this.showAllBtn);
			this.detailGroupBox.Controls.Add(this.viewPageLoadBtn);
			this.detailGroupBox.Enabled = false;
			this.detailGroupBox.Location = new System.Drawing.Point(28, 164);
			this.detailGroupBox.Name = "detailGroupBox";
			this.detailGroupBox.Size = new System.Drawing.Size(965, 390);
			this.detailGroupBox.TabIndex = 1;
			this.detailGroupBox.TabStop = false;
			this.detailGroupBox.Text = "details";
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
			this.viewBoxCompare.Size = new System.Drawing.Size(487, 236);
			this.viewBoxCompare.TabIndex = 17;
			this.viewBoxCompare.WordWrap = false;
			// 
			// loadFromUrlButton
			// 
			this.loadFromUrlButton.Enabled = false;
			this.loadFromUrlButton.Location = new System.Drawing.Point(16, 112);
			this.loadFromUrlButton.Name = "loadFromUrlButton";
			this.loadFromUrlButton.Size = new System.Drawing.Size(157, 37);
			this.loadFromUrlButton.TabIndex = 3;
			this.loadFromUrlButton.Text = "Compare with Live";
			this.loadFromUrlButton.UseVisualStyleBackColor = true;
			this.loadFromUrlButton.Click += new System.EventHandler(this.loadFromUrlButton_Click);
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
			this.viewBox.Size = new System.Drawing.Size(452, 236);
			this.viewBox.TabIndex = 3;
			this.viewBox.WordWrap = false;
			// 
			// showAllBtn
			// 
			this.showAllBtn.Location = new System.Drawing.Point(8, 26);
			this.showAllBtn.Name = "showAllBtn";
			this.showAllBtn.Size = new System.Drawing.Size(149, 37);
			this.showAllBtn.TabIndex = 2;
			this.showAllBtn.Text = "Show All";
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
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(78, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(69, 20);
			this.label1.TabIndex = 4;
			this.label1.Text = "Blocking";
			this.label1.Click += new System.EventHandler(this.totalBlockingLabel_Click);
			// 
			// totalGroupBox
			// 
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
			// improveTotalRecievedLabel
			// 
			this.improveTotalRecievedLabel.Location = new System.Drawing.Point(337, 20);
			this.improveTotalRecievedLabel.Name = "improveTotalRecievedLabel";
			this.improveTotalRecievedLabel.Size = new System.Drawing.Size(62, 21);
			this.improveTotalRecievedLabel.TabIndex = 27;
			this.improveTotalRecievedLabel.Text = "-1";
			this.improveTotalRecievedLabel.Click += new System.EventHandler(this.totalRecievedLabel_Click);
			// 
			// improveTotalSentLabel
			// 
			this.improveTotalSentLabel.Location = new System.Drawing.Point(262, 20);
			this.improveTotalSentLabel.Name = "improveTotalSentLabel";
			this.improveTotalSentLabel.Size = new System.Drawing.Size(65, 21);
			this.improveTotalSentLabel.TabIndex = 26;
			this.improveTotalSentLabel.Text = "-1";
			this.improveTotalSentLabel.Click += new System.EventHandler(this.totalSentLabel_Click);
			// 
			// improveTotalDnsLabel
			// 
			this.improveTotalDnsLabel.Location = new System.Drawing.Point(220, 20);
			this.improveTotalDnsLabel.Name = "improveTotalDnsLabel";
			this.improveTotalDnsLabel.Size = new System.Drawing.Size(38, 21);
			this.improveTotalDnsLabel.TabIndex = 25;
			this.improveTotalDnsLabel.Text = "-1";
			this.improveTotalDnsLabel.Click += new System.EventHandler(this.totalDnsLabel_Click);
			// 
			// improveTotalConnectLabel
			// 
			this.improveTotalConnectLabel.Location = new System.Drawing.Point(145, 20);
			this.improveTotalConnectLabel.Name = "improveTotalConnectLabel";
			this.improveTotalConnectLabel.Size = new System.Drawing.Size(65, 21);
			this.improveTotalConnectLabel.TabIndex = 24;
			this.improveTotalConnectLabel.Text = "-1";
			this.improveTotalConnectLabel.Click += new System.EventHandler(this.totalConnectLabel_Click);
			// 
			// improveTotalWaitingLabel
			// 
			this.improveTotalWaitingLabel.Location = new System.Drawing.Point(77, 20);
			this.improveTotalWaitingLabel.Name = "improveTotalWaitingLabel";
			this.improveTotalWaitingLabel.Size = new System.Drawing.Size(62, 21);
			this.improveTotalWaitingLabel.TabIndex = 23;
			this.improveTotalWaitingLabel.Text = "-1";
			this.improveTotalWaitingLabel.Click += new System.EventHandler(this.totalWaitingLabel_Click);
			// 
			// improveTotalBlockingLabel
			// 
			this.improveTotalBlockingLabel.Location = new System.Drawing.Point(6, 20);
			this.improveTotalBlockingLabel.Name = "improveTotalBlockingLabel";
			this.improveTotalBlockingLabel.Size = new System.Drawing.Size(65, 21);
			this.improveTotalBlockingLabel.TabIndex = 22;
			this.improveTotalBlockingLabel.Text = "-1";
			this.improveTotalBlockingLabel.Click += new System.EventHandler(this.totalBlockingLabel_Click);
			// 
			// compareTotalRecievedLabel
			// 
			this.compareTotalRecievedLabel.Location = new System.Drawing.Point(415, 67);
			this.compareTotalRecievedLabel.Name = "compareTotalRecievedLabel";
			this.compareTotalRecievedLabel.Size = new System.Drawing.Size(62, 21);
			this.compareTotalRecievedLabel.TabIndex = 21;
			this.compareTotalRecievedLabel.Text = "-1";
			this.compareTotalRecievedLabel.Click += new System.EventHandler(this.totalRecievedLabel_Click);
			// 
			// compareTotalSentLabel
			// 
			this.compareTotalSentLabel.Location = new System.Drawing.Point(340, 67);
			this.compareTotalSentLabel.Name = "compareTotalSentLabel";
			this.compareTotalSentLabel.Size = new System.Drawing.Size(65, 21);
			this.compareTotalSentLabel.TabIndex = 20;
			this.compareTotalSentLabel.Text = "-1";
			this.compareTotalSentLabel.Click += new System.EventHandler(this.totalSentLabel_Click);
			// 
			// compareTotalDnsLabel
			// 
			this.compareTotalDnsLabel.Location = new System.Drawing.Point(296, 67);
			this.compareTotalDnsLabel.Name = "compareTotalDnsLabel";
			this.compareTotalDnsLabel.Size = new System.Drawing.Size(38, 21);
			this.compareTotalDnsLabel.TabIndex = 19;
			this.compareTotalDnsLabel.Text = "-1";
			this.compareTotalDnsLabel.Click += new System.EventHandler(this.totalDnsLabel_Click);
			// 
			// compareTotalConnectLabel
			// 
			this.compareTotalConnectLabel.Location = new System.Drawing.Point(221, 67);
			this.compareTotalConnectLabel.Name = "compareTotalConnectLabel";
			this.compareTotalConnectLabel.Size = new System.Drawing.Size(65, 21);
			this.compareTotalConnectLabel.TabIndex = 18;
			this.compareTotalConnectLabel.Text = "-1";
			this.compareTotalConnectLabel.Click += new System.EventHandler(this.totalConnectLabel_Click);
			// 
			// compareTotalWaitingLabel
			// 
			this.compareTotalWaitingLabel.Location = new System.Drawing.Point(153, 67);
			this.compareTotalWaitingLabel.Name = "compareTotalWaitingLabel";
			this.compareTotalWaitingLabel.Size = new System.Drawing.Size(62, 21);
			this.compareTotalWaitingLabel.TabIndex = 17;
			this.compareTotalWaitingLabel.Text = "-1";
			this.compareTotalWaitingLabel.Click += new System.EventHandler(this.totalWaitingLabel_Click);
			// 
			// compareTotalBlockingLabel
			// 
			this.compareTotalBlockingLabel.Location = new System.Drawing.Point(82, 67);
			this.compareTotalBlockingLabel.Name = "compareTotalBlockingLabel";
			this.compareTotalBlockingLabel.Size = new System.Drawing.Size(65, 21);
			this.compareTotalBlockingLabel.TabIndex = 16;
			this.compareTotalBlockingLabel.Text = "-1";
			this.compareTotalBlockingLabel.Click += new System.EventHandler(this.totalBlockingLabel_Click);
			// 
			// totalRecievedLabel
			// 
			this.totalRecievedLabel.Location = new System.Drawing.Point(415, 46);
			this.totalRecievedLabel.Name = "totalRecievedLabel";
			this.totalRecievedLabel.Size = new System.Drawing.Size(62, 21);
			this.totalRecievedLabel.TabIndex = 15;
			this.totalRecievedLabel.Text = "-1";
			this.totalRecievedLabel.Click += new System.EventHandler(this.totalRecievedLabel_Click);
			// 
			// totalSentLabel
			// 
			this.totalSentLabel.Location = new System.Drawing.Point(340, 46);
			this.totalSentLabel.Name = "totalSentLabel";
			this.totalSentLabel.Size = new System.Drawing.Size(65, 21);
			this.totalSentLabel.TabIndex = 14;
			this.totalSentLabel.Text = "-1";
			this.totalSentLabel.Click += new System.EventHandler(this.totalSentLabel_Click);
			// 
			// totalDnsLabel
			// 
			this.totalDnsLabel.Location = new System.Drawing.Point(296, 46);
			this.totalDnsLabel.Name = "totalDnsLabel";
			this.totalDnsLabel.Size = new System.Drawing.Size(38, 21);
			this.totalDnsLabel.TabIndex = 13;
			this.totalDnsLabel.Text = "-1";
			this.totalDnsLabel.Click += new System.EventHandler(this.totalDnsLabel_Click);
			// 
			// totalConnectLabel
			// 
			this.totalConnectLabel.Location = new System.Drawing.Point(221, 46);
			this.totalConnectLabel.Name = "totalConnectLabel";
			this.totalConnectLabel.Size = new System.Drawing.Size(65, 21);
			this.totalConnectLabel.TabIndex = 12;
			this.totalConnectLabel.Text = "-1";
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
			this.label3.Click += new System.EventHandler(this.totalWaitingLabel_Click);
			// 
			// totalWaitingLabel
			// 
			this.totalWaitingLabel.Location = new System.Drawing.Point(153, 46);
			this.totalWaitingLabel.Name = "totalWaitingLabel";
			this.totalWaitingLabel.Size = new System.Drawing.Size(62, 21);
			this.totalWaitingLabel.TabIndex = 6;
			this.totalWaitingLabel.Text = "-1";
			this.totalWaitingLabel.Click += new System.EventHandler(this.totalWaitingLabel_Click);
			// 
			// totalBlockingLabel
			// 
			this.totalBlockingLabel.Location = new System.Drawing.Point(82, 46);
			this.totalBlockingLabel.Name = "totalBlockingLabel";
			this.totalBlockingLabel.Size = new System.Drawing.Size(65, 21);
			this.totalBlockingLabel.TabIndex = 5;
			this.totalBlockingLabel.Text = "-1";
			this.totalBlockingLabel.Click += new System.EventHandler(this.totalBlockingLabel_Click);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.loadComparisonFromFileButton);
			this.groupBox3.Controls.Add(this.totalGroupBox);
			this.groupBox3.Controls.Add(this.openHarButton);
			this.groupBox3.Controls.Add(this.loadFromUrlButton);
			this.groupBox3.Location = new System.Drawing.Point(12, 0);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(1133, 167);
			this.groupBox3.TabIndex = 4;
			this.groupBox3.TabStop = false;
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
			this.comparedDataGrid.Size = new System.Drawing.Size(944, 243);
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
			this.simpleModeCheckbox.UseVisualStyleBackColor = true;
			this.simpleModeCheckbox.CheckedChanged += new System.EventHandler(this.simpleModeCheckbox_CheckedChanged);
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
			this.simpleSplitContainer.Size = new System.Drawing.Size(943, 236);
			this.simpleSplitContainer.SplitterDistance = 452;
			this.simpleSplitContainer.TabIndex = 21;
			this.simpleSplitContainer.Visible = false;
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
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(2, 46);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(34, 20);
			this.label7.TabIndex = 29;
			this.label7.Text = "File";
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
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(2, 111);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(83, 20);
			this.label9.TabIndex = 31;
			this.label9.Text = "Difference";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(505, 22);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(78, 20);
			this.label10.TabIndex = 32;
			this.label10.Text = "TotalTime";
			// 
			// totalTimeLabel
			// 
			this.totalTimeLabel.Location = new System.Drawing.Point(505, 45);
			this.totalTimeLabel.Name = "totalTimeLabel";
			this.totalTimeLabel.Size = new System.Drawing.Size(62, 21);
			this.totalTimeLabel.TabIndex = 35;
			this.totalTimeLabel.Text = "-1";
			this.totalTimeLabel.Click += new System.EventHandler(this.showAllBtn_Click);
			// 
			// improvedTotalTimeLabel
			// 
			this.improvedTotalTimeLabel.Location = new System.Drawing.Point(427, 19);
			this.improvedTotalTimeLabel.Name = "improvedTotalTimeLabel";
			this.improvedTotalTimeLabel.Size = new System.Drawing.Size(62, 21);
			this.improvedTotalTimeLabel.TabIndex = 34;
			this.improvedTotalTimeLabel.Text = "-1";
			this.improvedTotalTimeLabel.Click += new System.EventHandler(this.showAllBtn_Click);
			// 
			// compareTotalTimeLabel
			// 
			this.compareTotalTimeLabel.Location = new System.Drawing.Point(505, 68);
			this.compareTotalTimeLabel.Name = "compareTotalTimeLabel";
			this.compareTotalTimeLabel.Size = new System.Drawing.Size(62, 21);
			this.compareTotalTimeLabel.TabIndex = 33;
			this.compareTotalTimeLabel.Text = "-1";
			this.compareTotalTimeLabel.Click += new System.EventHandler(this.showAllBtn_Click);
			// 
			// loadComparisonFromFileButton
			// 
			this.loadComparisonFromFileButton.Enabled = false;
			this.loadComparisonFromFileButton.Location = new System.Drawing.Point(16, 73);
			this.loadComparisonFromFileButton.Name = "loadComparisonFromFileButton";
			this.loadComparisonFromFileButton.Size = new System.Drawing.Size(157, 33);
			this.loadComparisonFromFileButton.TabIndex = 4;
			this.loadComparisonFromFileButton.Text = "Compare with File";
			this.loadComparisonFromFileButton.UseVisualStyleBackColor = true;
			this.loadComparisonFromFileButton.Click += new System.EventHandler(this.loadComparisonFromFileButton_Click);
			// 
			// multipleCallsBtn
			// 
			this.multipleCallsBtn.Location = new System.Drawing.Point(7, 69);
			this.multipleCallsBtn.Name = "multipleCallsBtn";
			this.multipleCallsBtn.Size = new System.Drawing.Size(173, 37);
			this.multipleCallsBtn.TabIndex = 22;
			this.multipleCallsBtn.Text = "Show Multiple Calls";
			this.multipleCallsBtn.UseVisualStyleBackColor = true;
			this.multipleCallsBtn.Click += new System.EventHandler(this.multipleCallsBtn_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1005, 566);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.detailGroupBox);
			this.Name = "Form1";
			this.Text = "Statistics";
			this.detailGroupBox.ResumeLayout(false);
			this.detailGroupBox.PerformLayout();
			this.totalGroupBox.ResumeLayout(false);
			this.totalGroupBox.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.comparedDataGrid)).EndInit();
			this.simpleSplitContainer.Panel1.ResumeLayout(false);
			this.simpleSplitContainer.Panel1.PerformLayout();
			this.simpleSplitContainer.Panel2.ResumeLayout(false);
			this.simpleSplitContainer.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.simpleSplitContainer)).EndInit();
			this.simpleSplitContainer.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

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
	}
}

