using System;
namespace Assignment_Feb01
{
	public class CloneDemo: ICloneable
	{
		int _value;
		public CloneDemo(int value)
		{
			value = _value;
		}

		public int Value
		{
			get
			{
				return _value;
			}
		}

		public Object Clone()
		{
			var temp = new CloneDemo(_value);
			return temp;
		}
	}
}
