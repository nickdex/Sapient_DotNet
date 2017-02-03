using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DIITester
{
    public partial class ProgramControl : UserControl
    {
        private string _paramType, _paramName;
        public ProgramControl(string paramType, string paramName)
        {
            InitializeComponent();
            _paramType = paramType;
            _paramName = paramName;

            SetLabel();
        }

        private void SetLabel()
        {
            labelType.Text = _paramType;
            labelName.Text = _paramName;
        }

        public string ParamType
        { 
            get 
            {
                return _paramType;
            }
        }

        public string ParamValue 
        { 
            get
            {
                return textBoxValue.Text;
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnInvoke_Click(object sender, EventArgs e)
        {

        }
    }
}
