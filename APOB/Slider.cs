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
            this.target = im;
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            ValueBox.Text = SlideBar.Value.ToString();
        }

        private void Action_Click(object sender, EventArgs e)
        {
            //this should be more generic 
            target.progowanie(int.Parse(ValueBox.Text));
            this.Close();
        }
    }
}
