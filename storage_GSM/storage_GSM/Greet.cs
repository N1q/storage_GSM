using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace storage_GSM
{
    public partial class Greet : Form
    {
        public Greet()
        {
            InitializeComponent();
        }

        private void Greet_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();

            Auth f = new Auth();
            Hide();
            f.Show();
        }
    }
}
