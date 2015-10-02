using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HarSharp;

namespace HarProcessor
{
	class EntryComparor : IComparer<HarSharp.Entry>
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
				case EntryEnum.TIME:
				default:
					return Comparing(x.Time, y.Time);
			}
		}
		protected int Comparing(double? x, double? y)
		{
			x = x ?? -1;
			y = y ?? -1;
			if(m_asc)
			{
				return (int)(x - y);
			} else
			{
				return (int)(y - x);
			}
		}
	}
}
