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
    public partial class Posterize : Form
    {
        WImage target;
        public Posterize(WImage im)
        {
            InitializeComponent();
            target = im;
        }

        private void Action_Click(object sender, EventArgs e)
        {
            int val;
            if(int.TryParse(ValueBox.Text, out val))
            {
                if (val > 255 || val < 0)
                {
                    MessageBox.Show("Incorrect value!");

                }
                else
                {
                    target.reductGrayScale(val);
                }
            }
            else
            {
                MessageBox.Show("Incorrect value!");
            }
        }
    }
}
