using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HarSharp;

namespace HarProcessor
{
	public class HarComparer
	{
		protected Processor m_old;
		protected Processor m_new;
		protected IDictionary<string,CombinedEntry> m_combinedEntries = new SortedDictionary<string,CombinedEntry>();
		public HarComparer(Processor oldHar, Processor newHar)
		{
			m_old = oldHar;
			m_new = newHar;
			Initialize();
		}
		protected void Initialize()
		{

			populateDictionary(m_old.getEntries(), m_new.getEntries(), m_combinedEntries);
		}
		/// <summary>
		/// Fill the passed in dictionary with the passed in entries
		/// </summary>
		/// <param name="newEntries"></param>
		/// <param name="oldEntries"></param>
		/// <param name="dictionary"> the dictionary to add the entries to</param>
		protected void populateDictionary(IEnumerable<Entry> oldEntries, IEnumerable<Entry> newEntries, IDictionary<string,CombinedEntry> dictionary)
		{
			// Add each entry in the old list into the list of entrys
			foreach (Entry entry in oldEntries)
			{
				CombinedEntry combEntry = new CombinedEntry(entry, null);
				CombinedEntry existingEntry;
				bool found = dictionary.TryGetValue(combEntry.getKey(), out existingEntry);
				if (found)
				{
					existingEntry.Combine(combEntry);
				}
				else
				{
					dictionary.Add(new KeyValuePair<string, CombinedEntry>(combEntry.getKey(), combEntry));
				}

			}
			// Check each entry if they are in the old list.  If they are combine them if not create a new entry
			foreach (Entry entry in newEntries)
			{
				CombinedEntry combEntry = new CombinedEntry(null, entry);
				CombinedEntry oldEntry;
				bool found = dictionary.TryGetValue(combEntry.getKey(), out oldEntry);
				if (found)
				{
					oldEntry.Combine(combEntry);
				}
				else
				{
					dictionary.Add(combEntry.getKey(), combEntry);
				}
			}

		}

		public IDictionary<string,CombinedEntry> getList()
		{
			return m_combinedEntries;
		}
		public IDictionary<string, CombinedEntry> getBlock()
		{
			IDictionary<string, CombinedEntry> dictionary = new Dictionary<string, CombinedEntry>();
			populateDictionary(m_new.getBlockTimes(), m_old.getBlockTimes(), dictionary);
			return dictionary;
		}
		public IDictionary<string, CombinedEntry> getWait()
		{
			IDictionary<string, CombinedEntry> dictionary = new Dictionary<string, CombinedEntry>();
			populateDictionary(m_new.getWaitTimes(), m_old.getWaitTimes(), dictionary);
			return dictionary;
		}
		public IDictionary<string, CombinedEntry> getConnect()
		{
			IDictionary<string, CombinedEntry> dictionary = new Dictionary<string, CombinedEntry>();
			populateDictionary(m_new.getConnectTimes(), m_old.getConnectTimes(), dictionary);
			return dictionary;
		}
		public IDictionary<string, CombinedEntry> getSent()
		{
			IDictionary<string, CombinedEntry> dictionary = new Dictionary<string, CombinedEntry>();
			populateDictionary(m_new.getSendTimes(), m_old.getSendTimes(), dictionary);
			return dictionary;
		}
		public IDictionary<string, CombinedEntry> getRecieve()
		{
			IDictionary<string, CombinedEntry> dictionary = new Dictionary<string, CombinedEntry>();
			populateDictionary(m_new.getRecievedTimes(), m_old.getRecievedTimes(), dictionary);
			return dictionary;
		}
		public IDictionary<string, CombinedEntry> getDns()
		{
			IDictionary<string, CombinedEntry> dictionary = new Dictionary<string, CombinedEntry>();
			populateDictionary(m_new.getDnsTimes(), m_old.getDnsTimes(), dictionary);
			return dictionary;
		}
		public IEnumerable<KeyValuePair<string, CombinedEntry>> getMultipleCalls()
		{
			IDictionary<string, CombinedEntry> dictionary = new Dictionary<string, CombinedEntry>();
            foreach (KeyValuePair<string, CombinedEntry> entry in m_combinedEntries)
			{

			}
			//m_combinedEntries
			return m_combinedEntries.Where(p=>p.Value.newCount > 1 || p.Value.oldCount > 1);
		}
	}

}
