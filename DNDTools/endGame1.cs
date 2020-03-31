using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DNDTools
{
    public partial class endGame1 : Form
    {
        private MainWindow parent;
        public endGame1(MainWindow window)
        {
            parent = window;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            parent.Close();
        }
    }
}
