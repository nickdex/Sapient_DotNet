using System;
using System.Collections;

namespace Assignment_Feb01
{
	public class IEnumerableDemo: IEnumerable
	{
		private CustomList _list;
		public IEnumerableDemo(CustomList list)
		{
			_list = list;
		}

		public IEnumerator GetEnumerator()
		{
			return _list.GetEnumerator();
		}
	}
}
