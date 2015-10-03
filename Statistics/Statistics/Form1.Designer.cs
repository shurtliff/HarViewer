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
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
			this.openHarFile = new System.Windows.Forms.OpenFileDialog();
			this.openHarButton = new System.Windows.Forms.Button();
			this.detailGroupBox = new System.Windows.Forms.GroupBox();
			this.viewBox = new System.Windows.Forms.TextBox();
			this.tempbtn = new System.Windows.Forms.Button();
			this.viewPageLoadBtn = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.totalGroupBox = new System.Windows.Forms.GroupBox();
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
			this.mainChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.loadFromUrlButton = new System.Windows.Forms.Button();
			this.compareTotalRecievedLabel = new System.Windows.Forms.Label();
			this.compareTotalSentLabel = new System.Windows.Forms.Label();
			this.compareTotalDnsLabel = new System.Windows.Forms.Label();
			this.compareTotalConnectLabel = new System.Windows.Forms.Label();
			this.compareTotalWaitingLabel = new System.Windows.Forms.Label();
			this.compareTotalBlockingLabel = new System.Windows.Forms.Label();
			this.improveTotalRecievedLabel = new System.Windows.Forms.Label();
			this.improveTotalSentLabel = new System.Windows.Forms.Label();
			this.improveTotalDnsLabel = new System.Windows.Forms.Label();
			this.improveTotalConnectLabel = new System.Windows.Forms.Label();
			this.improveTotalWaitingLabel = new System.Windows.Forms.Label();
			this.improveTotalBlockingLabel = new System.Windows.Forms.Label();
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.viewBoxCompare = new System.Windows.Forms.TextBox();
			this.detailGroupBox.SuspendLayout();
			this.totalGroupBox.SuspendLayout();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.mainChart)).BeginInit();
			this.SuspendLayout();
			// 
			// openHarFile
			// 
			this.openHarFile.FileName = "openHarFile";
			// 
			// openHarButton
			// 
			this.openHarButton.Location = new System.Drawing.Point(45, 26);
			this.openHarButton.Name = "openHarButton";
			this.openHarButton.Size = new System.Drawing.Size(193, 52);
			this.openHarButton.TabIndex = 0;
			this.openHarButton.Text = "Open From File";
			this.openHarButton.UseVisualStyleBackColor = true;
			this.openHarButton.Click += new System.EventHandler(this.openHarButton_Click);
			// 
			// detailGroupBox
			// 
			this.detailGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.detailGroupBox.Controls.Add(this.viewBoxCompare);
			this.detailGroupBox.Controls.Add(this.loadFromUrlButton);
			this.detailGroupBox.Controls.Add(this.mainChart);
			this.detailGroupBox.Controls.Add(this.viewBox);
			this.detailGroupBox.Controls.Add(this.tempbtn);
			this.detailGroupBox.Controls.Add(this.viewPageLoadBtn);
			this.detailGroupBox.Enabled = false;
			this.detailGroupBox.Location = new System.Drawing.Point(28, 164);
			this.detailGroupBox.Name = "detailGroupBox";
			this.detailGroupBox.Size = new System.Drawing.Size(1117, 402);
			this.detailGroupBox.TabIndex = 1;
			this.detailGroupBox.TabStop = false;
			this.detailGroupBox.Text = "details";
			// 
			// viewBox
			// 
			this.viewBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.viewBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.viewBox.Location = new System.Drawing.Point(37, 146);
			this.viewBox.Multiline = true;
			this.viewBox.Name = "viewBox";
			this.viewBox.ReadOnly = true;
			this.viewBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.viewBox.Size = new System.Drawing.Size(524, 206);
			this.viewBox.TabIndex = 3;
			this.viewBox.WordWrap = false;
			// 
			// tempbtn
			// 
			this.tempbtn.Location = new System.Drawing.Point(7, 62);
			this.tempbtn.Name = "tempbtn";
			this.tempbtn.Size = new System.Drawing.Size(149, 27);
			this.tempbtn.TabIndex = 2;
			this.tempbtn.Text = "temp button";
			this.tempbtn.UseVisualStyleBackColor = true;
			this.tempbtn.Click += new System.EventHandler(this.tempbtn_Click);
			// 
			// viewPageLoadBtn
			// 
			this.viewPageLoadBtn.Location = new System.Drawing.Point(7, 26);
			this.viewPageLoadBtn.Name = "viewPageLoadBtn";
			this.viewPageLoadBtn.Size = new System.Drawing.Size(149, 29);
			this.viewPageLoadBtn.TabIndex = 0;
			this.viewPageLoadBtn.Text = "View Page Load";
			this.viewPageLoadBtn.UseVisualStyleBackColor = true;
			this.viewPageLoadBtn.Click += new System.EventHandler(this.viewPageLoadBtn_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(69, 20);
			this.label1.TabIndex = 4;
			this.label1.Text = "Blocking";
			this.label1.Click += new System.EventHandler(this.totalBlockingLabel_Click);
			// 
			// totalGroupBox
			// 
			this.totalGroupBox.Controls.Add(this.improveTotalRecievedLabel);
			this.totalGroupBox.Controls.Add(this.improveTotalSentLabel);
			this.totalGroupBox.Controls.Add(this.improveTotalDnsLabel);
			this.totalGroupBox.Controls.Add(this.improveTotalConnectLabel);
			this.totalGroupBox.Controls.Add(this.improveTotalWaitingLabel);
			this.totalGroupBox.Controls.Add(this.improveTotalBlockingLabel);
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
			this.totalGroupBox.Location = new System.Drawing.Point(244, 25);
			this.totalGroupBox.Name = "totalGroupBox";
			this.totalGroupBox.Size = new System.Drawing.Size(826, 119);
			this.totalGroupBox.TabIndex = 2;
			this.totalGroupBox.TabStop = false;
			this.totalGroupBox.Text = "Totals";
			// 
			// totalRecievedLabel
			// 
			this.totalRecievedLabel.Location = new System.Drawing.Point(343, 46);
			this.totalRecievedLabel.Name = "totalRecievedLabel";
			this.totalRecievedLabel.Size = new System.Drawing.Size(62, 21);
			this.totalRecievedLabel.TabIndex = 15;
			this.totalRecievedLabel.Text = "-1";
			this.totalRecievedLabel.Click += new System.EventHandler(this.totalRecievedLabel_Click);
			// 
			// totalSentLabel
			// 
			this.totalSentLabel.Location = new System.Drawing.Point(268, 46);
			this.totalSentLabel.Name = "totalSentLabel";
			this.totalSentLabel.Size = new System.Drawing.Size(65, 21);
			this.totalSentLabel.TabIndex = 14;
			this.totalSentLabel.Text = "-1";
			this.totalSentLabel.Click += new System.EventHandler(this.totalSentLabel_Click);
			// 
			// totalDnsLabel
			// 
			this.totalDnsLabel.Location = new System.Drawing.Point(224, 46);
			this.totalDnsLabel.Name = "totalDnsLabel";
			this.totalDnsLabel.Size = new System.Drawing.Size(38, 21);
			this.totalDnsLabel.TabIndex = 13;
			this.totalDnsLabel.Text = "-1";
			this.totalDnsLabel.Click += new System.EventHandler(this.totalDnsLabel_Click);
			// 
			// totalConnectLabel
			// 
			this.totalConnectLabel.Location = new System.Drawing.Point(149, 46);
			this.totalConnectLabel.Name = "totalConnectLabel";
			this.totalConnectLabel.Size = new System.Drawing.Size(65, 21);
			this.totalConnectLabel.TabIndex = 12;
			this.totalConnectLabel.Text = "-1";
			this.totalConnectLabel.Click += new System.EventHandler(this.totalConnectLabel_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(343, 22);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(75, 20);
			this.label5.TabIndex = 11;
			this.label5.Text = "Recieved";
			this.label5.Click += new System.EventHandler(this.totalRecievedLabel_Click);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(268, 22);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(43, 20);
			this.label6.TabIndex = 10;
			this.label6.Text = "Sent";
			this.label6.Click += new System.EventHandler(this.totalSentLabel_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(224, 22);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(38, 20);
			this.label2.TabIndex = 9;
			this.label2.Text = "Dns";
			this.label2.Click += new System.EventHandler(this.totalDnsLabel_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(149, 22);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(69, 20);
			this.label4.TabIndex = 8;
			this.label4.Text = "Connect";
			this.label4.Click += new System.EventHandler(this.totalConnectLabel_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(81, 22);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(62, 20);
			this.label3.TabIndex = 7;
			this.label3.Text = "Waiting";
			this.label3.Click += new System.EventHandler(this.totalWaitingLabel_Click);
			// 
			// totalWaitingLabel
			// 
			this.totalWaitingLabel.Location = new System.Drawing.Point(81, 46);
			this.totalWaitingLabel.Name = "totalWaitingLabel";
			this.totalWaitingLabel.Size = new System.Drawing.Size(62, 21);
			this.totalWaitingLabel.TabIndex = 6;
			this.totalWaitingLabel.Text = "-1";
			this.totalWaitingLabel.Click += new System.EventHandler(this.totalWaitingLabel_Click);
			// 
			// totalBlockingLabel
			// 
			this.totalBlockingLabel.Location = new System.Drawing.Point(10, 46);
			this.totalBlockingLabel.Name = "totalBlockingLabel";
			this.totalBlockingLabel.Size = new System.Drawing.Size(65, 21);
			this.totalBlockingLabel.TabIndex = 5;
			this.totalBlockingLabel.Text = "-1";
			this.totalBlockingLabel.Click += new System.EventHandler(this.totalBlockingLabel_Click);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.totalGroupBox);
			this.groupBox3.Controls.Add(this.openHarButton);
			this.groupBox3.Location = new System.Drawing.Point(12, 0);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(1133, 158);
			this.groupBox3.TabIndex = 4;
			this.groupBox3.TabStop = false;
			// 
			// mainChart
			// 
			chartArea1.Name = "ChartArea1";
			this.mainChart.ChartAreas.Add(chartArea1);
			legend1.Name = "Legend1";
			this.mainChart.Legends.Add(legend1);
			this.mainChart.Location = new System.Drawing.Point(195, 25);
			this.mainChart.Name = "mainChart";
			series1.ChartArea = "ChartArea1";
			series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
			series1.Legend = "Legend1";
			series1.Name = "Main";
			this.mainChart.Series.Add(series1);
			this.mainChart.Size = new System.Drawing.Size(335, 114);
			this.mainChart.TabIndex = 16;
			this.mainChart.Text = "chart1";
			// 
			// loadFromUrlButton
			// 
			this.loadFromUrlButton.Location = new System.Drawing.Point(7, 95);
			this.loadFromUrlButton.Name = "loadFromUrlButton";
			this.loadFromUrlButton.Size = new System.Drawing.Size(149, 37);
			this.loadFromUrlButton.TabIndex = 3;
			this.loadFromUrlButton.Text = "Compare with Live";
			this.loadFromUrlButton.UseVisualStyleBackColor = true;
			this.loadFromUrlButton.Click += new System.EventHandler(this.loadFromUrlButton_Click);
			// 
			// compareTotalRecievedLabel
			// 
			this.compareTotalRecievedLabel.Location = new System.Drawing.Point(343, 67);
			this.compareTotalRecievedLabel.Name = "compareTotalRecievedLabel";
			this.compareTotalRecievedLabel.Size = new System.Drawing.Size(62, 21);
			this.compareTotalRecievedLabel.TabIndex = 21;
			this.compareTotalRecievedLabel.Text = "-1";
			// 
			// compareTotalSentLabel
			// 
			this.compareTotalSentLabel.Location = new System.Drawing.Point(268, 67);
			this.compareTotalSentLabel.Name = "compareTotalSentLabel";
			this.compareTotalSentLabel.Size = new System.Drawing.Size(65, 21);
			this.compareTotalSentLabel.TabIndex = 20;
			this.compareTotalSentLabel.Text = "-1";
			// 
			// compareTotalDnsLabel
			// 
			this.compareTotalDnsLabel.Location = new System.Drawing.Point(224, 67);
			this.compareTotalDnsLabel.Name = "compareTotalDnsLabel";
			this.compareTotalDnsLabel.Size = new System.Drawing.Size(38, 21);
			this.compareTotalDnsLabel.TabIndex = 19;
			this.compareTotalDnsLabel.Text = "-1";
			// 
			// compareTotalConnectLabel
			// 
			this.compareTotalConnectLabel.Location = new System.Drawing.Point(149, 67);
			this.compareTotalConnectLabel.Name = "compareTotalConnectLabel";
			this.compareTotalConnectLabel.Size = new System.Drawing.Size(65, 21);
			this.compareTotalConnectLabel.TabIndex = 18;
			this.compareTotalConnectLabel.Text = "-1";
			// 
			// compareTotalWaitingLabel
			// 
			this.compareTotalWaitingLabel.Location = new System.Drawing.Point(81, 67);
			this.compareTotalWaitingLabel.Name = "compareTotalWaitingLabel";
			this.compareTotalWaitingLabel.Size = new System.Drawing.Size(62, 21);
			this.compareTotalWaitingLabel.TabIndex = 17;
			this.compareTotalWaitingLabel.Text = "-1";
			// 
			// compareTotalBlockingLabel
			// 
			this.compareTotalBlockingLabel.Location = new System.Drawing.Point(10, 67);
			this.compareTotalBlockingLabel.Name = "compareTotalBlockingLabel";
			this.compareTotalBlockingLabel.Size = new System.Drawing.Size(65, 21);
			this.compareTotalBlockingLabel.TabIndex = 16;
			this.compareTotalBlockingLabel.Text = "-1";
			// 
			// improveTotalRecievedLabel
			// 
			this.improveTotalRecievedLabel.Location = new System.Drawing.Point(343, 95);
			this.improveTotalRecievedLabel.Name = "improveTotalRecievedLabel";
			this.improveTotalRecievedLabel.Size = new System.Drawing.Size(62, 21);
			this.improveTotalRecievedLabel.TabIndex = 27;
			this.improveTotalRecievedLabel.Text = "-1";
			// 
			// improveTotalSentLabel
			// 
			this.improveTotalSentLabel.Location = new System.Drawing.Point(268, 95);
			this.improveTotalSentLabel.Name = "improveTotalSentLabel";
			this.improveTotalSentLabel.Size = new System.Drawing.Size(65, 21);
			this.improveTotalSentLabel.TabIndex = 26;
			this.improveTotalSentLabel.Text = "-1";
			// 
			// improveTotalDnsLabel
			// 
			this.improveTotalDnsLabel.Location = new System.Drawing.Point(224, 95);
			this.improveTotalDnsLabel.Name = "improveTotalDnsLabel";
			this.improveTotalDnsLabel.Size = new System.Drawing.Size(38, 21);
			this.improveTotalDnsLabel.TabIndex = 25;
			this.improveTotalDnsLabel.Text = "-1";
			// 
			// improveTotalConnectLabel
			// 
			this.improveTotalConnectLabel.Location = new System.Drawing.Point(149, 95);
			this.improveTotalConnectLabel.Name = "improveTotalConnectLabel";
			this.improveTotalConnectLabel.Size = new System.Drawing.Size(65, 21);
			this.improveTotalConnectLabel.TabIndex = 24;
			this.improveTotalConnectLabel.Text = "-1";
			// 
			// improveTotalWaitingLabel
			// 
			this.improveTotalWaitingLabel.Location = new System.Drawing.Point(81, 95);
			this.improveTotalWaitingLabel.Name = "improveTotalWaitingLabel";
			this.improveTotalWaitingLabel.Size = new System.Drawing.Size(62, 21);
			this.improveTotalWaitingLabel.TabIndex = 23;
			this.improveTotalWaitingLabel.Text = "-1";
			// 
			// improveTotalBlockingLabel
			// 
			this.improveTotalBlockingLabel.Location = new System.Drawing.Point(10, 95);
			this.improveTotalBlockingLabel.Name = "improveTotalBlockingLabel";
			this.improveTotalBlockingLabel.Size = new System.Drawing.Size(65, 21);
			this.improveTotalBlockingLabel.TabIndex = 22;
			this.improveTotalBlockingLabel.Text = "-1";
			// 
			// viewBoxCompare
			// 
			this.viewBoxCompare.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.viewBoxCompare.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.viewBoxCompare.Location = new System.Drawing.Point(546, 146);
			this.viewBoxCompare.Multiline = true;
			this.viewBoxCompare.Name = "viewBoxCompare";
			this.viewBoxCompare.ReadOnly = true;
			this.viewBoxCompare.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.viewBoxCompare.Size = new System.Drawing.Size(524, 206);
			this.viewBoxCompare.TabIndex = 17;
			this.viewBoxCompare.WordWrap = false;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1157, 599);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.detailGroupBox);
			this.Name = "Form1";
			this.Text = "Statistics";
			this.detailGroupBox.ResumeLayout(false);
			this.detailGroupBox.PerformLayout();
			this.totalGroupBox.ResumeLayout(false);
			this.totalGroupBox.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.mainChart)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.OpenFileDialog openHarFile;
		private System.Windows.Forms.Button openHarButton;
		private System.Windows.Forms.GroupBox detailGroupBox;
		private System.Windows.Forms.Button viewPageLoadBtn;
		private System.Windows.Forms.Button tempbtn;
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
		private System.Windows.Forms.DataVisualization.Charting.Chart mainChart;
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
	}
}

