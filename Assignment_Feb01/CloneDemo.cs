using System;
namespace Assignment_Feb01
{
	public class CloneDemo: ICloneable
	{
		int _value;
		public CloneDemo(int value)
		{
			_value = value;
		}

		public int Value
		{
			get
			{
				return _value;
			}
		}

		/// <summary>
		/// Return a copy of the object of this class.
		/// According to MS Docs, it can be shallow copy, deep copy and something in between
		/// </summary>
		public Object Clone()
		{
			var temp = new CloneDemo(_value);
			return temp;
		}
	}
}
