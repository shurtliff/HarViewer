using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HarSharp;

namespace HarProcessor
{
    public class Processor
    {
		protected Har m_har;
		protected double m_totalTime;
		protected double? m_totalBlockTime;
		protected double? m_totalWaitTime;
		protected double? m_totalConnectTime;
		protected double? m_totalDnsTime;
		protected double? m_totalSentTime;
		protected double? m_totalRecieveTime;

		protected List<Entry> m_fullList = new List<Entry>();
		protected List<Entry> m_blockedEntries = new List<Entry>();
		protected List<Entry> m_waitedEntries = new List<Entry>();
		protected List<Entry> m_connectedEntries = new List<Entry>();
		protected List<Entry> m_dnsEntries = new List<Entry>();
		protected List<Entry> m_sentEntries = new List<Entry>();
		protected List<Entry> m_recievedEntries = new List<Entry>();

		public double totalTime()
		{
			return m_totalTime;
		}
		public double totalBlockTime()
		{
			return m_totalBlockTime??0;
		}
		public double totalWaitTime()
		{
			return m_totalWaitTime ?? 0;
		}
		public double totalConnectTime()
		{
			return m_totalConnectTime ?? 0;
		}
		public double totalDnsTime()
		{
			return m_totalDnsTime ?? 0;
		}
		public double totalSentTime()
		{
			return m_totalSentTime ?? 0;
		}
		public double totalRecieveTime()
		{
			return m_totalRecieveTime ?? 0;
		}

		public void LoadFromFile(string fileName)
		{
			m_har = HarConvert.DeserializeFromFile(fileName);
			initialize();
		}
		/// <summary>
		/// Save the data to a file then load from the file.
		/// There is a flaw in this in that it doesn't split out the block, connect, dns or reieve time
		/// It is all placed in the wait and recieve times.
		/// </summary>
		/// <param name="url"></param>
		public void loadFromURL(string url)
		{
			string name = MakeValidFileName(url) + ".har";
			using (System.IO.StreamWriter file = new System.IO.StreamWriter(name, false))
			{
				NReco.PhantomJS.PhantomJS test = new NReco.PhantomJS.PhantomJS();
				test.OutputReceived += (sender, e) =>
				{
					file.Write(e.Data);
				};
				string[] args = { url };
				test.Run("netsniff.js", args);
			}
			LoadFromFile(name);
		}

		public string getUrl()
		{
			// It will throw an exception if the processor has not been initialized.
			return m_har.Log.Entries[0].Request.Url.AbsoluteUri;
		}
		protected void initialize()
		{
			m_totalBlockTime = 0;
			m_totalWaitTime = 0;
			m_totalDnsTime = 0;
			m_totalConnectTime = 0;
			m_totalSentTime = 0;
			m_totalRecieveTime = 0;
			m_totalTime = 0;
			m_blockedEntries.Clear();
			m_waitedEntries.Clear();
			m_connectedEntries.Clear();
			m_dnsEntries.Clear();
			m_sentEntries.Clear();
			m_recievedEntries.Clear();
			m_fullList.Clear();
			foreach (var entry in m_har.Log.Entries)
			{
				m_totalTime += entry.Time;
				m_fullList.Add(entry);
				if (entry.Timings.Blocked > 0)
				{
					m_blockedEntries.Add(entry);
					m_totalBlockTime += entry.Timings.Blocked;
				}
				if(entry.Timings.Wait > 0)
				{
					m_waitedEntries.Add(entry);
					m_totalWaitTime += entry.Timings.Wait;
				}
				if (entry.Timings.Connect > 0)
				{
					m_connectedEntries.Add(entry);
					m_totalConnectTime += entry.Timings.Wait;
				}
				if (entry.Timings.Dns > 0)
				{
					m_dnsEntries.Add(entry);
					m_totalDnsTime += entry.Timings.Dns;
				}
				if (entry.Timings.Send > 0)
				{
					m_sentEntries.Add(entry);
					m_totalSentTime += entry.Timings.Send;
				}
				if (entry.Timings.Receive > 0)
				{
					m_recievedEntries.Add(entry);
					m_totalRecieveTime += entry.Timings.Receive;
				}
			}
		}
		public IList<Entry> getEntries()
		{
			return m_har.Log.Entries;
		}
		public IList<Entry> getAllByExecution()
		{
			return getEntries();
		}
		public IList<Entry> getBlockTimes()
		{
			return m_blockedEntries;
		}
		public IList<Entry> getWaitTimes()
		{
			return m_waitedEntries;
		}
		public IList<Entry> getConnectTimes()
		{
			return m_connectedEntries;
		}
		public IList<Entry> getDnsTimes()
		{
			return m_dnsEntries;
		}
		public IList<Entry> getSendTimes()
		{
			return m_sentEntries;
		}
		public IList<Entry> getRecievedTimes()
		{
			return m_recievedEntries;
		}
		/*
		String representation for simple view
		*/
		public string getStringPageLoadTimes()
		{
			string returnMe = "";
			foreach (var page in m_har.Log.Pages)
			{
				returnMe += string.Format("Page: {0} loaded in {1} milliseconds", page.Title, page.PageTimings.OnLoad);
				returnMe += Environment.NewLine;
			}

			return returnMe;
		}
		public string getStringAllByExecution()
		{
			return getEntryTimes(m_har.Log.Entries);
		}
		public string getStringAllByTime()
		{
			return getEntryTimes(m_fullList.OrderByDescending(x => x.Time));
		}
		public string getStringBlockTimes()
		{
			return getEntryTimes(m_blockedEntries.OrderByDescending(x => x.Timings.Blocked));
		}
		public string getStringWaitTimes()
		{
			return getEntryTimes(m_waitedEntries.OrderByDescending(x => x.Timings.Wait));
		}
		public string getStringConnectTimes()
		{
			return getEntryTimes(m_connectedEntries.OrderByDescending(x => x.Timings.Connect));
		}
		public string getStringDnsTimes()
		{
			return getEntryTimes(m_dnsEntries.OrderByDescending(x => x.Timings.Dns));
		}
		public string getStringSendTimes()
		{
			return getEntryTimes(m_sentEntries.OrderByDescending(x => x.Timings.Send));
		}
		public string getStringRecievedTimes()
		{
			return getEntryTimes(m_recievedEntries.OrderByDescending(x => x.Timings.Receive));
		} 
		public string getEntryTimes(IEnumerable<Entry> entries)
		{
			string returnMe = "";
			foreach (var entry in entries)
			{
				returnMe += string.Format("TotalTime:{0}\tBlock:{1}    \twait:{2}\t\tconnect:{3}\tDNS:{4}\tSent:{5}\tRecieved:{6}\tEntry: {7}{8}", Math.Ceiling(entry.Time), Math.Ceiling(entry.Timings.Blocked??-2), Math.Ceiling(entry.Timings.Wait), Math.Ceiling(entry.Timings.Connect??-2), Math.Ceiling(entry.Timings.Dns??-2), Math.Ceiling(entry.Timings.Send), Math.Ceiling(entry.Timings.Receive), entry.Request.Url.Host, entry.Request.Url.AbsolutePath);
				returnMe += Environment.NewLine;
			}

			return returnMe;

		}

		private static string MakeValidFileName(string name)
		{
			string invalidChars = System.Text.RegularExpressions.Regex.Escape(new string(System.IO.Path.GetInvalidFileNameChars()));
			string invalidRegStr = string.Format(@"([{0}]*\.+$)|([{0}]+)", invalidChars);

			return System.Text.RegularExpressions.Regex.Replace(name, invalidRegStr, "_");
		}

	}
}
