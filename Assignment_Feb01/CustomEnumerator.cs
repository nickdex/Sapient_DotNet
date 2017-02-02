using System;
using System.Collections;

namespace Assignment_Feb01
{
	public class CustomEnumerator: IEnumerator
	{
		object[] _contents;
		private int _currentIndex = -1;
		public CustomEnumerator(object[] _contents)
		{
			this._contents = _contents;
		}

		public object Current
		{
			get
			{
				return _contents[_currentIndex];
			}
		}

		public bool MoveNext()
		{
            if (_currentIndex < _contents.Length - 1 )
            {
			    _currentIndex++;
			    return true;
            }
            return false;
		}

		public void Reset()
		{
			_currentIndex = -1;
		}
	}
}
