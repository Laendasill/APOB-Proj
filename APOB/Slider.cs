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
    public partial class Slider : Form
    {
        WImage target;
        public Slider(WImage im)
        {
            InitializeComponent();
            target = im;
        }

        private void SliderBox_Scroll(object sender, EventArgs e)
        {
            ValueBox.Text = SliderBox.Value.ToString();
        }

        private void ActionButton_Click(object sender, EventArgs e)
        {
            int val;
            if (int.TryParse(ValueBox.Text, out val))
            {
                if (val < 0)
                {
                    val = 0;
                }
                if (val > 255)
                {
                    val = 255;
                }
                target.reductGrayScale(val);
                this.Close();
            }
            else
            {
                this.Close();
            }
        }
    }
}
