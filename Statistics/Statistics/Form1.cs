using HarProcessor;
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
		private Processor m_processor = new Processor();
		private Processor m_compProcessor = new Processor();
		private HarComparer m_comparison;
		private BindingSource m_datagridBinding = new BindingSource();
		private Dictionary<String, DataGridViewColumn> m_columnMapping = new Dictionary<string, DataGridViewColumn>();

		public Form1()
		{
			InitializeComponent();
			Initialize();
		}
		private void Initialize()
		{
			// Initialize the DataGridView.
			comparedDataGrid.AutoGenerateColumns = false;
			comparedDataGrid.AutoSize = true;
			comparedDataGrid.DataSource = m_datagridBinding;


			// Initialize and add a text box column.
			comparedDataGrid.Columns.Add(createColumn("OCount", "oldCount"));
			comparedDataGrid.Columns.Add(createColumn("NCount", "newCount"));
			comparedDataGrid.Columns.Add(createColumn("OldTime", "oldTime"));
			comparedDataGrid.Columns.Add(createColumn("NEWTime", "newTime"));
			comparedDataGrid.Columns.Add(createColumn("URL", "url"));
			comparedDataGrid.Columns.Add(createColumn("Method", "method"));
			comparedDataGrid.Columns.Add(createColumn("ORecieve", "oldRecieve"));
			comparedDataGrid.Columns.Add(createColumn("NRecieve", "newRecieve"));
			comparedDataGrid.Columns.Add(createColumn("OWait", "oldWait"));
			comparedDataGrid.Columns.Add(createColumn("NWait", "newWait"));
			comparedDataGrid.Columns.Add(createColumn("ODns", "oldDns"));
			comparedDataGrid.Columns.Add(createColumn("NDns", "newDns"));
			comparedDataGrid.Columns.Add(createColumn("OConnect", "oldConnect"));
			comparedDataGrid.Columns.Add(createColumn("NConnect", "newConnect"));
			comparedDataGrid.Columns.Add(createColumn("OSend", "oldSend"));
			comparedDataGrid.Columns.Add(createColumn("NSend", "newSend"));
			comparedDataGrid.Columns.Add(createColumn("OBlock", "oldBlock"));
			comparedDataGrid.Columns.Add(createColumn("NBlock", "newBlock"));

		}
		private DataGridViewColumn createColumn(string name, string propertyName)
		{
			DataGridViewColumn column = new DataGridViewTextBoxColumn();
			column.DataPropertyName = propertyName;
			column.Name = name;
			column.Width = 50;
			m_columnMapping.Add(propertyName, column);
			return column;
		}

		private void openHarButton_Click(object sender, EventArgs e)
		{
			totalGroupBox.Enabled = false;
			detailGroupBox.Enabled = false;
			loadComparisonFromFileButton.Enabled = false;
			loadFromUrlButton.Enabled = false;

			viewBox.Text = "";
			DialogResult result = openHarFile.ShowDialog();
            if ( result == DialogResult.OK)
			{
				m_processor.LoadFromFile(openHarFile.FileName);
				setupTotals();
				loadComparisonFromFileButton.Enabled = true;
				loadFromUrlButton.Enabled = true;
			}
		}
		private void loadFromUrlButton_Click(object sender, EventArgs e)
		{
			// Gets the URL from the already loaded HAR file and creates a
			// new HAR file based on that.
			m_compProcessor.loadFromURL(m_processor.getUrl());
			populateComparison();
		}
		private void loadComparisonFromFileButton_Click(object sender, EventArgs e)
		{
			viewBox.Text = "";
			DialogResult result = openHarFile.ShowDialog();
			if (result == DialogResult.OK)
			{
				m_compProcessor.LoadFromFile(openHarFile.FileName);
				populateComparison();
			}
		}
		private void simpleModeCheckbox_CheckedChanged(object sender, EventArgs e)
		{
			bool isChecked = simpleModeCheckbox.Checked;
			comparedDataGrid.Visible = !isChecked;
			multipleCallsBtn.Visible = !isChecked;
			legendGroupBox.Visible = !isChecked;
			simpleSplitContainer.Visible = isChecked;
			viewPageLoadBtn.Visible = isChecked;
		}

		private void populateDataGrid(IEnumerable<KeyValuePair<string, CombinedEntry>> entries)
		{
			m_datagridBinding.Clear();

			foreach (KeyValuePair<string, CombinedEntry> entry in entries)
			{
				m_datagridBinding.Add(entry.Value);
			}

			colorDataGrid();
		}
		private void colorDataGrid()
		{
			foreach (DataGridViewRow row in comparedDataGrid.Rows)
			{
				CombinedEntry entry = (CombinedEntry)row.DataBoundItem;
				Color defaultColor = getRowColor(entry);
				row.DefaultCellStyle.BackColor = defaultColor;
				row.Cells[m_columnMapping["newTime"].Index].Style.BackColor = getCellColor(entry, entry.newTime, entry.oldTime, defaultColor);
				row.Cells[m_columnMapping["newBlock"].Index].Style.BackColor = getCellColor(entry, entry.newBlock, entry.oldBlock, defaultColor);
				row.Cells[m_columnMapping["newRecieve"].Index].Style.BackColor = getCellColor(entry, entry.newRecieve, entry.oldRecieve, defaultColor);
				row.Cells[m_columnMapping["newWait"].Index].Style.BackColor = getCellColor(entry, entry.newWait, entry.oldWait, defaultColor);
			}

		}
		private Color getRowColor(CombinedEntry entry)
		{
			if(entry.oldCount == 0)
			{
				return Color.LightPink;
			} else if (entry.newCount == 0)
			{
				return Color.LightGreen;
			} else
			{
				return Color.White;
			}
		}
		private Color getCellColor(CombinedEntry entry, double column, double other, Color defaultColor)
		{
			// Only color the individual cells if it has an old and a new record.
			// Do not color if it is a added call or a removed call.
			if (entry.newCount > 0 && entry.oldCount > 0)
			{
				if (column > other && column > 0)
				{
					return Color.Red;
				}
				else if (column < other)
				{
					return Color.Green;
				}
			}

			return defaultColor;
		}


		private void setupTotals()
		{
			setLabelBackground(totalBlockingLabel, m_processor.totalBlockTime(), 20000, 0);
			setLabelBackground(totalWaitingLabel, m_processor.totalWaitTime(), 20000, 0);
			setLabelBackground(totalConnectLabel, m_processor.totalConnectTime(), 1000, 0);
			setLabelBackground(totalDnsLabel, m_processor.totalDnsTime(), 100, 0);
			setLabelBackground(totalSentLabel, m_processor.totalSentTime(), 20000, 0);
			setLabelBackground(totalRecievedLabel, m_processor.totalRecieveTime(), 20000, 0);
			setLabelBackground(totalTimeLabel, m_processor.totalTime(), 20000, 0);

		}
		private void setupCompTotals()
		{
			setLabelBackground(compareTotalBlockingLabel, m_compProcessor.totalBlockTime(), 20000, 0);
			setLabelBackground(improveTotalBlockingLabel, m_compProcessor.totalBlockTime() - m_processor.totalBlockTime(), 0, 0);
			setLabelBackground(compareTotalWaitingLabel, m_compProcessor.totalWaitTime(), 20000, 0);
			setLabelBackground(improveTotalWaitingLabel, m_compProcessor.totalWaitTime() - m_processor.totalWaitTime(), 0, 0);
			setLabelBackground(compareTotalConnectLabel, m_compProcessor.totalConnectTime(), 1000, 0);
			setLabelBackground(improveTotalConnectLabel, m_compProcessor.totalConnectTime() - m_processor.totalConnectTime(), 0, 0);
			setLabelBackground(compareTotalDnsLabel, m_compProcessor.totalDnsTime(), 100, 0);
			setLabelBackground(improveTotalDnsLabel, m_compProcessor.totalDnsTime() - m_processor.totalDnsTime(), 0, 0);
			setLabelBackground(compareTotalSentLabel, m_compProcessor.totalSentTime(), 20000, 0);
			setLabelBackground(improveTotalSentLabel, m_compProcessor.totalSentTime() - m_processor.totalSentTime(), 0, 0);
			setLabelBackground(compareTotalRecievedLabel, m_compProcessor.totalRecieveTime(), 20000, 0);
			setLabelBackground(improveTotalRecievedLabel, m_compProcessor.totalRecieveTime() - m_processor.totalRecieveTime(), 0, 0);
			setLabelBackground(compareTotalTimeLabel, m_compProcessor.totalTime(), 20000, 0);
			setLabelBackground(improvedTotalTimeLabel, m_compProcessor.totalTime() - m_processor.totalTime(), 0, 0);
		}
		private void clearCompTotals()
		{
			setLabelBackground(compareTotalBlockingLabel, -1, 0, 0);
			setLabelBackground(improveTotalBlockingLabel, -1, 0, 0);
			setLabelBackground(compareTotalWaitingLabel, -1, 0, 0);
			setLabelBackground(improveTotalWaitingLabel, -1, 0, 0);
			setLabelBackground(compareTotalConnectLabel, -1, -0, 0);
			setLabelBackground(improveTotalConnectLabel, -1, 0, 0);
			setLabelBackground(compareTotalDnsLabel, -1, 0, 0);
			setLabelBackground(improveTotalDnsLabel, -1, 0, 0);
			setLabelBackground(compareTotalSentLabel, -1, 0, 0);
			setLabelBackground(improveTotalSentLabel, -1, 0, 0);
			setLabelBackground(compareTotalRecievedLabel, -1, 0, 0);
			setLabelBackground(improveTotalRecievedLabel, -1, 0, 0);

		}
		private void populateComparison()
		{
			m_comparison = new HarComparer(m_processor, m_compProcessor);
			setupCompTotals();
			totalGroupBox.Enabled = true;
			detailGroupBox.Enabled = true;
			populateDataGrid(m_comparison.getList());

		}
		private void setLabelBackground(Label label, double value, int upperThreshold, int lowerThreshold)
		{
			label.Text = value.ToString();
			if (value > upperThreshold)
			{
				label.BackColor = Color.Red;
			}
			else if (value < lowerThreshold)
			{
				label.BackColor = Color.Green;
			}
			else
			{
				label.BackColor = SystemColors.Control;
			}
		}

		private void viewPageLoadBtn_Click(object sender, EventArgs e)
		{
			viewBox.Text = m_processor.getStringPageLoadTimes();
			viewBoxCompare.Text = m_compProcessor.getStringPageLoadTimes();
		}
		private void showAllBtn_Click(object sender, EventArgs e)
		{
			populateDataGrid(m_comparison.getList().OrderByDescending(x => x.Value.newTime));

			viewBox.Text = m_processor.getStringAllByExecution();
			viewBoxCompare.Text = m_compProcessor.getStringAllByExecution();

		}
		private void multipleCallsBtn_Click(object sender, EventArgs e)
		{
			populateDataGrid(m_comparison.getMultipleCalls());
		}

		private void totalBlockingLabel_Click(object sender, EventArgs e)
		{
			populateDataGrid(m_comparison.getBlock().OrderByDescending(x => x.Value.newBlock));
			viewBox.Text = m_processor.getStringBlockTimes();
			viewBoxCompare.Text = m_compProcessor.getStringBlockTimes();
		}
		private void totalWaitingLabel_Click(object sender, EventArgs e)
		{
			populateDataGrid(m_comparison.getWait().OrderByDescending(x => x.Value.newWait));
			viewBox.Text = m_processor.getStringWaitTimes();
			viewBoxCompare.Text = m_compProcessor.getStringWaitTimes();
		}
		private void totalConnectLabel_Click(object sender, EventArgs e)
		{
			populateDataGrid(m_comparison.getConnect().OrderByDescending(x => x.Value.newConnect));
			viewBox.Text = m_processor.getStringConnectTimes();
			viewBoxCompare.Text = m_compProcessor.getStringConnectTimes();
		}
		private void totalDnsLabel_Click(object sender, EventArgs e)
		{
			populateDataGrid(m_comparison.getDns().OrderByDescending(x => x.Value.newDns));
			viewBox.Text = m_processor.getStringDnsTimes();
			viewBoxCompare.Text = m_compProcessor.getStringDnsTimes();
		}
		private void totalSentLabel_Click(object sender, EventArgs e)
		{
			populateDataGrid(m_comparison.getSent().OrderByDescending(x => x.Value.newSend));
			viewBox.Text = m_processor.getStringSendTimes();
			viewBoxCompare.Text = m_compProcessor.getStringSendTimes();
		}
		private void totalRecievedLabel_Click(object sender, EventArgs e)
		{
			populateDataGrid(m_comparison.getRecieve().OrderByDescending(x => x.Value.newRecieve));
			viewBox.Text = m_processor.getStringRecievedTimes();
			viewBoxCompare.Text = m_compProcessor.getStringRecievedTimes();
		}

	}
}
