using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Pikazovalnik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void prikaziSliko(object sender, EventArgs e)
        {
            slika.Visible = true;
            timer_SkrjSliko.Enabled = true;
        }

        private void skrijSliko(object sender, EventArgs e)
        {
            slika.Visible = false;
            timer_SkrjSliko.Stop();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void slika_Click(object sender, EventArgs e)
        {

        }
    }
}
