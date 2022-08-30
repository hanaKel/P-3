using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_časovnik
{
    
    public partial class Form1 : Form
    {
        public int cas = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            cas++;
            casovnik.Text = (cas / 10.0).ToString();
        }

        private void StartStop_Click(object sender, EventArgs e)
        {
            timer.Enabled = ! timer.Enabled;
        }
    }
}
