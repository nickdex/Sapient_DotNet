using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace SerializationDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSerialize_Click(object sender, EventArgs e)
        {
            BinaryFormatterWriter();
            //XmlFormatterWriter();
        }

        private void btnDeserialize_Click(object sender, EventArgs e)
        {
            BinaryFormatterReader();
           // XmlFormatterReader();
        }

        private void XmlFormatterWriter()
        {
            XmlSerializer formatter = new XmlSerializer(typeof(DemoClass));
            FileStream stream = new FileStream("nikhil.txt", FileMode.Create);

            DemoClass demo = new DemoClass(2);
            demo.Id = 2134;
            demo.Age = 12;
            demo.Name = "Nikhil";

            formatter.Serialize(stream, demo);
            stream.Close();
            stream.Dispose();
        }

        private void XmlFormatterReader()
        {
            XmlSerializer formatter = new XmlSerializer(typeof(DemoClass));
            FileStream stream = new FileStream("nikhil.txt", FileMode.Open);
            var obj = formatter.Deserialize(stream);

            DemoClass demo = obj as DemoClass;
            txtContents.Text = demo.ToString();
            stream.Close();
            stream.Dispose();
        }

        private static void BinaryFormatterWriter()
        {
            BinaryFormatter formater = new BinaryFormatter();

            FileStream stream = new FileStream("nikhil.bak", FileMode.Create);

            DemoClass demo = new DemoClass(2);
            demo.Id = 2134;
            demo.Age = 12;
            demo.Name = "Nikhil";

            formater.Serialize(stream, demo);
            stream.Close();
            stream.Dispose();
        }


        private void btnBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                txtPath.Text = dialog.SelectedPath;
            }
        }

        private void BinaryFormatterReader()
        {
            BinaryFormatter formater = new BinaryFormatter();
            FileStream stream = new FileStream("nikhil.bak", FileMode.Open);
            var obj = formater.Deserialize(stream);

            DemoClass demo = obj as DemoClass;
            txtContents.Text = demo.ToString();
            stream.Close();
            stream.Dispose();
        }
    }
}
