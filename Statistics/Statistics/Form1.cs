using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Statistics
{
	public partial class Form1 : Form
	{
		protected HarProcessor.Processor m_processor = new HarProcessor.Processor();
		protected HarProcessor.Processor m_compProcessor = new HarProcessor.Processor();
		public Form1()
		{
			InitializeComponent();
		}

		private void openHarButton_Click(object sender, EventArgs e)
		{
			//populateChart();
			viewBox.Text = "";
			DialogResult result = openHarFile.ShowDialog();
            if ( result == DialogResult.OK)
			{
				m_processor.LoadFromFile(openHarFile.FileName);
				m_compProcessor.loadFromURL(m_processor.getUrl());
				setupTotals();
				setupCompTotals();
				totalGroupBox.Enabled = true;
				detailGroupBox.Enabled = true;
			}
		}
		private void setupTotals()
		{
			setLabel(totalBlockingLabel, m_processor.totalBlockTime(), 20000);
			setLabel(totalWaitingLabel, m_processor.totalWaitTime(), 20000);
			setLabel(totalConnectLabel, m_processor.totalConnectTime(), 1000);
			setLabel(totalDnsLabel, m_processor.totalDnsTime(), 0);
			setLabel(totalSentLabel, m_processor.totalSentTime(), 0);
			setLabel(totalRecievedLabel, m_processor.totalRecieveTime(), 0);

		}
		private void setupCompTotals()
		{
			setLabel(compareTotalBlockingLabel, m_compProcessor.totalBlockTime(), 20000);
			setLabel(improveTotalBlockingLabel, m_compProcessor.totalBlockTime() - m_processor.totalBlockTime(), 0);
			setLabel(compareTotalWaitingLabel, m_compProcessor.totalWaitTime(), 20000);
			setLabel(improveTotalWaitingLabel, m_compProcessor.totalWaitTime() - m_processor.totalWaitTime(), 0);
			setLabel(compareTotalConnectLabel, m_compProcessor.totalConnectTime(), 1000);
			setLabel(improveTotalConnectLabel, m_compProcessor.totalConnectTime() - m_processor.totalConnectTime(), 0);
			setLabel(compareTotalDnsLabel, m_compProcessor.totalDnsTime(), 0);
			setLabel(improveTotalDnsLabel, m_compProcessor.totalDnsTime() - m_processor.totalDnsTime(), 0);
			setLabel(compareTotalSentLabel, m_compProcessor.totalSentTime(), 0);
			setLabel(improveTotalSentLabel, m_compProcessor.totalSentTime() - m_processor.totalSentTime(), 0);
			setLabel(compareTotalRecievedLabel, m_compProcessor.totalRecieveTime(), 0);
			setLabel(improveTotalRecievedLabel, m_compProcessor.totalRecieveTime() - m_processor.totalRecieveTime(), 0);
		}
		private void clearCompTotals()
		{
			setLabel(compareTotalBlockingLabel, -1, 0);
			setLabel(improveTotalBlockingLabel, -1, 0);
			setLabel(compareTotalWaitingLabel, -1, 0);
			setLabel(improveTotalWaitingLabel, -1, 0);
			setLabel(compareTotalConnectLabel, -1, -0);
			setLabel(improveTotalConnectLabel, -1, 0);
			setLabel(compareTotalDnsLabel, -1, 0);
			setLabel(improveTotalDnsLabel, -1, 0);
			setLabel(compareTotalSentLabel, -1, 0);
			setLabel(improveTotalSentLabel, -1, 0);
			setLabel(compareTotalRecievedLabel, -1, 0);
			setLabel(improveTotalRecievedLabel, -1, 0);

		}
		private void loadFromUrlButton_Click(object sender, EventArgs e)
		{
			
			m_compProcessor.loadFromURL(m_processor.getUrl());
			setupCompTotals();

		}
		//private void populateChart()
		//{
		//	mainChart.Series.Clear();
		//	Series series = new Series
		//	{
		//		Name = "Something",
		//		IsVisibleInLegend = true,
		//		Color = System.Drawing.Color.Green,
		//		ChartType = SeriesChartType.Pie
		//	};
		//	mainChart.Series.Add(series);
		//	series.Points.Add(100);
		//	series.Points.Add(300);
		//}
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
			viewBoxCompare.Text = m_compProcessor.getPageLoadTimes();
		}

		private void tempbtn_Click(object sender, EventArgs e)
		{
			viewBox.Text = m_processor.getAllByExecution();
			viewBoxCompare.Text = m_compProcessor.getAllByExecution();
		}

		private void totalBlockingLabel_Click(object sender, EventArgs e)
		{
			viewBox.Text = m_processor.getBlockTimes();
			viewBoxCompare.Text = m_compProcessor.getBlockTimes();
		}

		private void totalWaitingLabel_Click(object sender, EventArgs e)
		{
			viewBox.Text = m_processor.getWaitTimes();
			viewBoxCompare.Text = m_compProcessor.getWaitTimes();
		}

		private void totalConnectLabel_Click(object sender, EventArgs e)
		{
			viewBox.Text = m_processor.getConnectTimes();
			viewBoxCompare.Text = m_compProcessor.getConnectTimes();
		}

		private void totalDnsLabel_Click(object sender, EventArgs e)
		{
			viewBox.Text = m_processor.getDnsTimes();
			viewBoxCompare.Text = m_compProcessor.getDnsTimes();
		}

		private void totalSentLabel_Click(object sender, EventArgs e)
		{
			viewBox.Text = m_processor.getSendTimes();
			viewBoxCompare.Text = m_compProcessor.getSendTimes();
		}

		private void totalRecievedLabel_Click(object sender, EventArgs e)
		{
			viewBox.Text = m_processor.getRecievedTimes();
			viewBoxCompare.Text = m_compProcessor.getRecievedTimes();
		}

	}
}
