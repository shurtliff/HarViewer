using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HarSharp;

namespace HarProcessor
{
	class Comparer
	{
		protected Har m_old;
		protected Har m_new;
		protected IDictionary<string,CombinedEntry> m_combinedEntries = new Dictionary<string,CombinedEntry>();
		public Comparer(Har oldHar, Har newHar)
		{
			m_old = oldHar;
			m_new = newHar;
			Initialize();
		}
		protected void Initialize()
		{
			foreach(Entry entry in m_old.Log.Entries)
			{
				CombinedEntry combEntry = new CombinedEntry(entry, null);
                m_combinedEntries.Add(new KeyValuePair<string,CombinedEntry>(combEntry.getKey(),combEntry));
			}

		}
	}
	class CombinedEntry
	{
		protected Entry m_oldEntry;
		protected Entry m_newEntry;
		/// <summary>
		/// Either new or old entries can be null
		/// </summary>
		/// <param name="oldEntry"></param>
		/// <param name="newEntry"></param>
		public CombinedEntry(Entry oldEntry, Entry newEntry)
		{
			m_oldEntry = oldEntry;
			m_newEntry = newEntry;
			if(m_newEntry == null && m_oldEntry == null)
			{
				throw new NullReferenceException("Both oldEntry and newEntry cannot be null");
			}
		}
		public string getKey()
		{
			if(m_oldEntry != null)
			{
				return generateKey(m_oldEntry);
			} else if (m_newEntry != null)
			{
				return generateKey(m_newEntry);
			} else
			{
				throw new NullReferenceException("Both oldEntry and newEntry cannot be null");
			}
		}
		protected string generateKey(Entry entry)
		{
			if(entry == null)
			{
				throw new NullReferenceException("Cannot generate a key for a Null Entry");
			}
			string key = entry.Request.Url.AbsoluteUri;
			foreach(QueryStringParameter queryString in entry.Request.QueryString)
			{
				key += "_" + queryString.Name + "_" + queryString.Value;
			}
			return key;
		}
	}
}
