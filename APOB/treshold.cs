using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APOB
{
    public partial class treshold : Form
    {
        WImage target;
        public treshold(WImage im)
        {
            InitializeComponent();
            target = im;
        }

        private void ActionButton_Click(object sender, EventArgs e)
        {
            int v1, v2, min, max;
            v1 = int.Parse(ValueBox.Text);
            v2 = int.Parse(Value2.Text);
            if (v1 > v2)
            {
                max = v1;
                min = v2;
            }
            else if (v1 < v2)
            {
                max = v2;
                min = v1;
            }
            else
            {
                max = v1;
                min= v1;
            }
            target.progowanie(min,max);
            this.Close();
        }
    }
}
