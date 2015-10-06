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
		protected Processor m_processor = new Processor();
		protected Processor m_compProcessor = new Processor();
		protected HarComparer m_comparison;
		protected BindingSource m_datagridBinding = new BindingSource();
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
			comparedDataGrid.Columns.Add(createColumn("OBlock", "oldBlock"));
			comparedDataGrid.Columns.Add(createColumn("NBlock", "newBlock"));
			comparedDataGrid.Columns.Add(createColumn("OWait", "oldWait"));
			comparedDataGrid.Columns.Add(createColumn("NWait", "newWait"));
			comparedDataGrid.Columns.Add(createColumn("ODns", "oldDns"));
			comparedDataGrid.Columns.Add(createColumn("NDns", "newDns"));
			comparedDataGrid.Columns.Add(createColumn("OConnect", "oldConnect"));
			comparedDataGrid.Columns.Add(createColumn("NConnect", "newConnect"));
			comparedDataGrid.Columns.Add(createColumn("OSend", "oldSend"));
			comparedDataGrid.Columns.Add(createColumn("NSend", "newSend"));
			comparedDataGrid.Columns.Add(createColumn("ORecieve", "oldRecieve"));
			comparedDataGrid.Columns.Add(createColumn("NRecieve", "newRecieve"));

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
		private void populateDataGrid(IEnumerable<KeyValuePair<string, CombinedEntry>> entries)
		{
			m_datagridBinding.Clear();

			foreach (KeyValuePair<string, CombinedEntry> entry in entries)
			{
				m_datagridBinding.Add(entry.Value);
			}

			colorDataGrid();
		}
		private void populateDataGrid(IDictionary<string,CombinedEntry> entries)
		{
			populateDataGrid(entries.ToList());

		}
		private void colorDataGrid()
		{
			foreach (DataGridViewRow row in comparedDataGrid.Rows)
			{
				CombinedEntry entry = (CombinedEntry)row.DataBoundItem;
				Color defaultColor = getRowColor(entry);
				row.DefaultCellStyle.BackColor = defaultColor;
				row.Cells[m_columnMapping["newTime"].Index].Style.BackColor = getColor(entry.newTime, entry.oldTime, defaultColor);
				row.Cells[m_columnMapping["newBlock"].Index].Style.BackColor = getColor(entry.newBlock, entry.oldBlock, defaultColor);
				row.Cells[m_columnMapping["newRecieve"].Index].Style.BackColor = getColor(entry.newRecieve, entry.oldRecieve, defaultColor);
				row.Cells[m_columnMapping["newWait"].Index].Style.BackColor = getColor(entry.newWait, entry.oldWait, defaultColor);
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

		private Color getColor(double column, double other, Color defaultColor)
		{
			if(column < 0)
			{
				return Color.Gray;
			}else if(column > other && column > 0)
			{
				return Color.Red;
			} else if (column < other)
			{
				return Color.Green;
			} else
			{
				return defaultColor;
			}
		}
		private Dictionary<String, DataGridViewColumn> m_columnMapping = new Dictionary<string, DataGridViewColumn>();
		private DataGridViewColumn createColumn(string name, string propertyName)
		{
			DataGridViewColumn column = new DataGridViewTextBoxColumn();
			column.DataPropertyName = propertyName;
			column.Name = name;
			column.Width = 50;
			m_columnMapping.Add(propertyName, column);
			return column;
		}
		private void setupTotals()
		{
			setLabel(totalBlockingLabel, m_processor.totalBlockTime(), 20000);
			setLabel(totalWaitingLabel, m_processor.totalWaitTime(), 20000);
			setLabel(totalConnectLabel, m_processor.totalConnectTime(), 1000);
			setLabel(totalDnsLabel, m_processor.totalDnsTime(), 0);
			setLabel(totalSentLabel, m_processor.totalSentTime(), 0);
			setLabel(totalRecievedLabel, m_processor.totalRecieveTime(), 0);
			setLabel(totalTimeLabel, m_processor.totalTime(), 0);

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
			setLabel(compareTotalTimeLabel, m_compProcessor.totalTime(), 0);
			setLabel(improvedTotalTimeLabel, m_compProcessor.totalTime() - m_processor.totalTime(), 0);
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
			populateComparison();

		}
		private void populateComparison()
		{
			m_comparison = new HarComparer(m_processor, m_compProcessor);
			populateDataGrid(m_comparison.getList());
			setupCompTotals();
			totalGroupBox.Enabled = true;
			detailGroupBox.Enabled = true;

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
			viewBoxCompare.Text = m_compProcessor.getPageLoadTimes();
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



		private void simpleModeCheckbox_CheckedChanged(object sender, EventArgs e)
		{
			bool isChecked = simpleModeCheckbox.Checked;
			comparedDataGrid.Visible = !isChecked;
			multipleCallsBtn.Visible = !isChecked;
			simpleSplitContainer.Visible = isChecked;
			viewPageLoadBtn.Visible = isChecked;
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
	}
}
