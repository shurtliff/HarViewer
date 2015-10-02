using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Statistics
{
	public partial class Form1 : Form
	{
		protected HarProcessor.Processor m_processor = new HarProcessor.Processor();
		public Form1()
		{
			InitializeComponent();
		}

		private void openHarButton_Click(object sender, EventArgs e)
		{
			viewBox.Text = "";
			DialogResult result = openHarFile.ShowDialog();
            if ( result == DialogResult.OK)
			{
				m_processor.LoadFromFile(openHarFile.FileName);
				setLabel(totalBlockingLabel, m_processor.totalBlockTime(), 20000);
				setLabel(totalWaitingLabel, m_processor.totalWaitTime(), 20000);
				setLabel(totalConnectLabel, m_processor.totalConnectTime(), 1000);
				setLabel(totalDnsLabel, m_processor.totalDnsTime(), 0);
				setLabel(totalSentLabel, m_processor.totalSentTime(), 0);
				setLabel(totalRecievedLabel, m_processor.totalRecieveTime(), 0);
			}
		}
		private void setLabel(Label label, double value, int threshold)
		{
			label.Text = value.ToString();
			if(value > threshold)
			{
				label.BackColor = Color.Red;
			} else
			{
				label.BackColor = SystemColors.Control;
			}
		}
		private void viewPageLoadBtn_Click(object sender, EventArgs e)
		{
			viewBox.Text = m_processor.getPageLoadTimes();
		}

		private void tempbtn_Click(object sender, EventArgs e)
		{
			viewBox.Text = m_processor.getAllByTime();

		}

		private void totalBlockingLabel_Click(object sender, EventArgs e)
		{
			viewBox.Text = m_processor.getBlockTimes();
		}

		private void totalWaitingLabel_Click(object sender, EventArgs e)
		{
			viewBox.Text = m_processor.getWaitTimes();
		}

		private void totalConnectLabel_Click(object sender, EventArgs e)
		{
			viewBox.Text = m_processor.getConnectTimes();
		}

		private void totalDnsLabel_Click(object sender, EventArgs e)
		{
			viewBox.Text = m_processor.getDnsTimes();
		}

		private void totalSentLabel_Click(object sender, EventArgs e)
		{
			viewBox.Text = m_processor.getSendTimes();
		}

		private void totalRecievedLabel_Click(object sender, EventArgs e)
		{
			viewBox.Text = m_processor.getRecievedTimes();
		}
	}
}
