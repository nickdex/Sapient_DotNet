using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DIITester
{
    public partial class Form1 : Form
    {
        Type _selectedType = null;
        MethodInfo _selectedMethod = null;
        private Assembly assembly;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            FileDialog dialog = new OpenFileDialog();

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBoxPath.Text = dialog.FileName;
            }

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            assembly = Assembly.LoadFrom(textBoxPath.Text); 

            List<Type> typeList = assembly.GetTypes().ToList();

            listBoxTypes.Items.Clear();
            typeList.ForEach(item => listBoxTypes.Items.Add(item.FullName));
        }

        private void listBoxTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedType = assembly.GetType(listBoxTypes.SelectedItem.ToString());

            if (_selectedType == null) return;

            // Clear list
            ClearLists();
            // Methods
            ShowInListBox(listBoxMethod, _selectedType.GetMethods().Select(p => p.Name).ToList<string>());
            // Properties
            ShowInListBox(listBoxProperty, _selectedType.GetProperties().Select(p => p.Name).ToList<string>());
            ShowInListBox(listBoxField, _selectedType.GetFields().Select(p => p.Name).ToList<string>());
            ShowInListBox(listBoxEvent, _selectedType.GetEvents().Select(p => p.Name).ToList<string>());
            ShowInListBox(listBoxConstructor, _selectedType.GetConstructors().Select(p => p.Name).ToList<string>());
        }

        private void ShowInListBox(ListBox box, List<string> list) 
        {
            list.ForEach(item => box.Items.Add(item));
        }

        private void ClearLists()
        {
            listBoxMethod.Items.Clear();
            listBoxProperty.Items.Clear();
            listBoxField.Items.Clear();
            listBoxEvent.Items.Clear();
            listBoxConstructor.Items.Clear();
        }

        private void listBoxMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Clear Controls
            panel1.Controls.Clear();

            if (_selectedType == null) return;
            // Select from Methods listbox;
            _selectedMethod = _selectedType.GetMethod(listBoxMethod.SelectedItem.ToString());

            if (_selectedMethod == null) return;

            var paramList = _selectedMethod.GetParameters().ToList();
            int count = 1;
            paramList.ForEach(p => 
                {
                    var control = new ProgramControl(p.ParameterType.FullName, p.Name);
                    control.Location = new Point(1, count * 30);
                    count++;
                    panel1.Controls.Add(control);
                });

        }

        private void Invoke_Click(object sender, EventArgs e)
        {
            if (_selectedType == null && _selectedMethod == null) return;

            object instance = Activator.CreateInstance(_selectedType);

            List<object> parameters = new List<object>();

            foreach (var control in panel1.Controls)
            {
                if (control is ProgramControl)
                {
                    var pControl = control as ProgramControl;
                    object param = Convert.ChangeType(pControl.ParamValue, Type.GetType(pControl.ParamType));
                    parameters.Add(param);
                }
            }
            object result = _selectedMethod.Invoke(instance, parameters.ToArray());

            if (result != null)
            {
                MessageBox.Show(result.ToString());
            }
        }
        

    }

}
