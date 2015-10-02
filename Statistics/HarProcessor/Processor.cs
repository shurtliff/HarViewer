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
		protected double? m_totalBlockTime;
		protected double? m_totalWaitTime;
		protected double? m_totalConnectTime;
		protected double? m_totalDnsTime;
		protected double? m_totalSentTime;
		protected double? m_totalRecieveTime;
		protected SortedSet<Entry> m_blockedEntries = new SortedSet<Entry>(new EntryComparor(EntryEnum.BLOCK, false));
		protected SortedSet<Entry> m_waitedEntries = new SortedSet<Entry>(new EntryComparor(EntryEnum.WAIT, false));
		protected SortedSet<Entry> m_connectedEntries = new SortedSet<Entry>(new EntryComparor(EntryEnum.CONNECT, false));
		protected SortedSet<Entry> m_dnsEntries = new SortedSet<Entry>(new EntryComparor(EntryEnum.DNS, false));
		protected SortedSet<Entry> m_sentEntries = new SortedSet<Entry>(new EntryComparor(EntryEnum.SEND, false));
		protected SortedSet<Entry> m_recievedEntries = new SortedSet<Entry>(new EntryComparor(EntryEnum.RECIEVE, false));
		//protected IList<Entry> m_blockedEntries;
		//protected IList<Entry> m_waitedEntries;
		//protected IList<Entry> m_connectedEntries;
		//protected IList<Entry> m_dnsEntries;
		//protected IList<Entry> m_sentEntries;
		//protected IList<Entry> m_recievedEntries;

		protected SortedSet<Entry> m_fullList = new SortedSet<Entry>(new EntryComparor(EntryEnum.TIME, false));

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
		protected Har m_har;
		public void LoadFromFile(string fileName)
		{
			m_har = HarConvert.DeserializeFromFile(fileName);
			initialize();
		}
		public string getPageLoadTimes()
		{
			string returnMe = "";
			foreach(var page in m_har.Log.Pages)
			{
				returnMe += string.Format("Page: {0} loaded in {1} milliseconds", page.Title, page.PageTimings.OnLoad);
				returnMe += Environment.NewLine;
			}

			return returnMe;
		}
		protected void initialize()
		{
			SortedSet<Entry> test = new SortedSet<Entry>(new EntryComparor(EntryEnum.TIME, false));
			m_totalBlockTime = 0;
			m_totalWaitTime = 0;
			m_totalDnsTime = 0;
			m_totalConnectTime = 0;
			m_totalSentTime = 0;
			m_totalRecieveTime = 0;
			m_blockedEntries.Clear();
			m_waitedEntries.Clear();
			m_connectedEntries.Clear();
			m_dnsEntries.Clear();
			m_sentEntries.Clear();
			m_recievedEntries.Clear();
			//m_blockedEntries = new List<Entry>();
			//m_waitedEntries = new List<Entry>();
			//m_connectedEntries = new List<Entry>();
			//m_dnsEntries = new List<Entry>();
			//m_sentEntries = new List<Entry>();
			//m_recievedEntries = new List<Entry>();

			//m_orderedList = m_har.Log.Entries.OrderByDescending(o => o.Time).ToList();

			foreach (var entry in m_har.Log.Entries)
			{
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
			//m_orderedList = test.ToList();
		}
		public string getAllByTime()
		{
			return getEntryTimes(m_fullList);
		}
		public string getBlockTimes()
		{
			return getEntryTimes(m_blockedEntries);
		}
		public string getWaitTimes()
		{
			return getEntryTimes(m_waitedEntries);
			//string returnMe = "";
			//foreach (var entry in m_waitedEntries)
			//{
			//		double? waitTime = entry.Timings.Wait;
			//		returnMe += string.Format("waited for {2} milliseconds Entry: {0}{1}", entry.Request.Url.Host, entry.Request.Url.AbsolutePath, waitTime);
			//		returnMe += Environment.NewLine;
			//}

			//returnMe += string.Format("waited for {0} milliseconds", m_totalWaitTime);

			//return returnMe;

		}
		public string getConnectTimes()
		{
			return getEntryTimes(m_connectedEntries);
		}
		public string getDnsTimes()
		{
			return getEntryTimes(m_dnsEntries);
		}
		public string getSendTimes()
		{
			return getEntryTimes(m_sentEntries);
		}
		public string getRecievedTimes()
		{
			return getEntryTimes(m_recievedEntries);
		}

		public string getEntryTimes(IEnumerable<Entry> entries)
		{
			string returnMe = "";
			foreach (var entry in entries)
			{
				returnMe += string.Format("TotalTime:{0}\tBlock:{1}    \twait:{2}\t\tconnect:{3}\tDNS:{4}\tSent:{5}\tRecieved:{6}\tEntry: {7}{8}", entry.Time, entry.Timings.Blocked, entry.Timings.Wait, entry.Timings.Connect, entry.Timings.Dns, entry.Timings.Send, entry.Timings.Receive, entry.Request.Url.Host, entry.Request.Url.AbsolutePath);
				returnMe += Environment.NewLine;
			}

			return returnMe;

		}
	}
}
