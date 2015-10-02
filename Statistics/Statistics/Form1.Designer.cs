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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.viewBox = new System.Windows.Forms.TextBox();
			this.tempbtn = new System.Windows.Forms.Button();
			this.viewPageLoadBtn = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
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
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
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
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.viewBox);
			this.groupBox1.Controls.Add(this.tempbtn);
			this.groupBox1.Controls.Add(this.viewPageLoadBtn);
			this.groupBox1.Location = new System.Drawing.Point(12, 132);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(1117, 505);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "groupBox1";
			// 
			// viewBox
			// 
			this.viewBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.viewBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.viewBox.Location = new System.Drawing.Point(6, 95);
			this.viewBox.Multiline = true;
			this.viewBox.Name = "viewBox";
			this.viewBox.ReadOnly = true;
			this.viewBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.viewBox.Size = new System.Drawing.Size(1105, 360);
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
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.totalRecievedLabel);
			this.groupBox2.Controls.Add(this.totalSentLabel);
			this.groupBox2.Controls.Add(this.totalDnsLabel);
			this.groupBox2.Controls.Add(this.totalConnectLabel);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.totalWaitingLabel);
			this.groupBox2.Controls.Add(this.totalBlockingLabel);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Location = new System.Drawing.Point(244, 25);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(826, 82);
			this.groupBox2.TabIndex = 2;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Totals";
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
			this.groupBox3.Controls.Add(this.groupBox2);
			this.groupBox3.Controls.Add(this.openHarButton);
			this.groupBox3.Location = new System.Drawing.Point(12, 0);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(1133, 126);
			this.groupBox3.TabIndex = 4;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "groupBox3";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1157, 599);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox1);
			this.Name = "Form1";
			this.Text = "Statistics";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.OpenFileDialog openHarFile;
		private System.Windows.Forms.Button openHarButton;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button viewPageLoadBtn;
		private System.Windows.Forms.Button tempbtn;
		private System.Windows.Forms.TextBox viewBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox2;
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
	}
}

