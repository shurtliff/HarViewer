using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HarSharp;

namespace HarProcessor 
{
	public class CombinedEntry
	{
		protected IList<Entry> m_oldEntries = new List<Entry>();
		protected IList<Entry> m_newEntries = new List<Entry>();
		/// <summary>
		/// Either new or old entries can be null
		/// </summary>
		/// <param name="oldEntry"></param>
		/// <param name="newEntry"></param>
		public CombinedEntry(Entry oldEntry, Entry newEntry)
		{
			if(oldEntry != null)
			{
				m_oldEntries.Add(oldEntry);
			}
			if(newEntry != null)
			{
				m_newEntries.Add(newEntry);
			}
			if (newEntry == null && oldEntry == null)
			{
				throw new NullReferenceException("Both oldEntry and newEntry cannot be null");
			}
		}
		public void Combine(CombinedEntry combEntry)
		{
			foreach(Entry entry in combEntry.m_oldEntries)
			{
				m_oldEntries.Add(entry);
			}
			foreach (Entry entry in combEntry.m_newEntries)
			{
				m_newEntries.Add(entry);
			}
			if(combEntry.m_oldEntries.Count == 0 && combEntry.m_newEntries.Count == 0)
			{
				// If they are both null we cannot combine it.
				throw new InvalidOperationException("Cannot combine an entry that is already full");
			}
			string key = getKey();
			if (keysEqual(m_newEntries, key) != keysEqual(m_oldEntries,key))
			{
				throw new InvalidOperationException("Cannot combine entries with different keys");
			}
		}
		public string getKey()
		{
				return generateKey(getAnyEntry());
		}
		protected bool keysEqual(IList<Entry> entries, string key)
		{
			foreach(Entry entry in entries)
			{
				if(generateKey(entry) != key)
				{
					return false;
				}
			}
			return true;
		}
		protected string generateKey(Entry entry)
		{
			if (entry == null)
			{
				throw new NullReferenceException("Cannot generate a key for a Null Entry");
			}
			string key = entry.Request.Url.AbsoluteUri;
			foreach (QueryStringParameter queryString in entry.Request.QueryString)
			{
				key += "_" + queryString.Name + "_" + queryString.Value;
			}
			return key;
		}
		protected Entry getAnyEntry()
		{
			if (m_oldEntries.Count > 0)
			{
				return m_oldEntries[0];
			}
			else if (m_newEntries.Count > 0)
			{
				return m_newEntries[0];
			}
			else
			{
				throw new NullReferenceException("Both oldEntry and newEntry cannot be null");
			}
		}
		public double oldTime { get { return getTime(true); } }
		public double newTime { get { return getTime(false); } }
		public int newCount { get { return getCount(false); } }
		public int oldCount { get { return getCount(true); } }
		public string url { get { return getAnyEntry().Request.Url.AbsoluteUri; } }
		public string method { get { return getAnyEntry().Request.Method; } }
		public double oldBlock { get { return getBlock(true); } }
		public double newBlock { get { return getBlock(false); } }
		public double oldWait { get { return getWait(true); } }
		public double newWait { get { return getWait(false); } }
		public double oldDns { get { return getDns(true); } }
		public double newDns { get { return getDns(false); } }
		public double oldConnect { get { return getConnect(true); } }
		public double newConnect { get { return getConnect(false); } }
		public double oldSend { get { return getSend(true); } }
		public double newSend { get { return getSend(false); } }
		public double oldRecieve { get { return getRecieve(true); } }
		public double newRecieve { get { return getRecieve(false); } }

		protected double getTime(bool old)
		{
			double amount = 0;
			IList<Entry> entries = old ? m_oldEntries : m_newEntries;
			foreach (Entry entry in entries)
			{
					amount += entry.Time;
			}
			return amount;
		}
		protected int getCount(bool old)
		{
			if (old)
			{
				return m_oldEntries.Count;
			}
			else
			{
				return m_newEntries.Count;
			}
		}
		protected double getBlock(bool old)
		{
			double amount = 0;
			IList<Entry> entries = old ? m_oldEntries : m_newEntries;
			foreach(Entry entry in entries)
			{
				if (entry.Timings.Blocked > 0)
				{
					amount += entry.Timings.Blocked ?? 0;
				}
			}
			return amount;
		}
		protected double getWait(bool old)
		{
			double amount = 0;
			IList<Entry> entries = old ? m_oldEntries : m_newEntries;
			foreach (Entry entry in entries)
			{
				if (entry.Timings.Wait > 0)
				{
					amount += entry.Timings.Wait;
				}
			}
			return amount;
		}
		protected double getDns(bool old)
		{
			double amount = 0;
			IList<Entry> entries = old ? m_oldEntries : m_newEntries;
			foreach (Entry entry in entries)
			{
				if (entry.Timings.Dns > 0)
				{
					amount += entry.Timings.Dns ?? 0;
				}
			}
			return amount;
		}
		protected double getConnect(bool old)
		{
			double amount = 0;
			IList<Entry> entries = old ? m_oldEntries : m_newEntries;
			foreach (Entry entry in entries)
			{
				if (entry.Timings.Connect > 0)
				{
					amount += entry.Timings.Connect ?? 0;
				}
			}
			return amount;
		}
		protected double getSend(bool old)
		{
			double amount = 0;
			IList<Entry> entries = old ? m_oldEntries : m_newEntries;
			foreach (Entry entry in entries)
			{
				if (entry.Timings.Send > 0)
				{
					amount += entry.Timings.Send;
				}
			}
			return amount;
		}
		protected double getRecieve(bool old)
		{
			double amount = 0;
			IList<Entry> entries = old ? m_oldEntries : m_newEntries;
			foreach (Entry entry in entries)
			{
				if (entry.Timings.Receive > 0)
				{
					amount += entry.Timings.Receive;
				}
			}
			return amount;
		}

	}
}
