using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HarSharp;

namespace HarProcessor
{
	class EntryComparor : IComparer<Entry>
	{
		protected EntryEnum m_type;
		protected bool m_asc;
		public EntryComparor(EntryEnum type, bool ascending)
		{
			m_type = type;
			m_asc = ascending;

		}
		public int Compare(Entry x, Entry y)
		{
			switch(m_type)
			{
				case EntryEnum.BLOCK:
					return Comparing(x.Timings.Blocked, y.Timings.Blocked);
				case EntryEnum.WAIT:
					return Comparing(x.Timings.Wait, y.Timings.Wait);
				case EntryEnum.CONNECT:
					return Comparing(x.Timings.Connect, y.Timings.Connect);
				case EntryEnum.DNS:
					return Comparing(x.Timings.Dns, y.Timings.Dns);
				case EntryEnum.SEND:
					return Comparing(x.Timings.Send, y.Timings.Send);
				case EntryEnum.RECIEVE:
					return Comparing(x.Timings.Receive, y.Timings.Receive);
				case EntryEnum.URL:
					return Comparing(x.Request.Url.AbsoluteUri, y.Request.Url.AbsoluteUri);
				case EntryEnum.TIME:
				default:
					return Comparing(x.Time, y.Time);
			}
		}
		protected int Comparing(double? x, double? y)
		{
			x = x ?? 0;
			y = y ?? 0;
			if(m_asc)
			{
				var val = 0;
				if (x < y) {
					val = -1;
				} else if (x > y)
				{
					val = 1;
				}
				return val;
			} else
			{
				var val = 0;
				if (x < y)
				{
					val = 1;
				}
				else if (x > y)
				{
					val = -1;
				}
				return val;
			}
		}
		protected int Comparing(string x, string y)
		{
			if(m_asc)
			{
				return string.Compare(x, y);
			} else
			{
				return string.Compare(y, x);
			}
		}
	}
}
