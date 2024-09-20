using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winforms_digitalClock
{
    public partial class clock : Form
    {
        Timer t = new Timer();
        public clock()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            t.Interval = 1000;

            t.Tick += new EventHandler(this.t_Tick);

            t.Start();
        }

        private void t_Tick(object sender, EventArgs e)
        {

        }
    }
}
