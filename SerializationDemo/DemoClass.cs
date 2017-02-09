using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SerializationDemo
{
    [Serializable]
    public class DemoClass: ISerializable
    {
        private double _salary;
        public DemoClass(int salary)
        {
            _salary = salary;
        }

        public DemoClass()
        {
            
        }

        public DemoClass(SerializationInfo info, StreamingContext context)
        {
            Id = info.GetInt32("Id");
            Age = info.GetByte("Age");
        }


        public int Id { get; set; }

        public byte Age { get; set; }

        public string Name { get; set; }

        public override string ToString()
        {
            return String.Format("Salary: {0} -- Id: {1} -- Age: {2} -- Name: {3}", _salary, Id, Age, Name);
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Id", Id);
            info.AddValue("Age", Age);
        }
    }
}
