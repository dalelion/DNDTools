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
    public partial class characterInfo : Form
    {
        int temp = 0;

        public characterInfo()
        {
            InitializeComponent();
        }

        private void buttonStrUp_Click(object sender, EventArgs e)
        {
            temp++;
            if (temp > 0)
                lblStrVar.Text = "( +" + temp + " )";
            else
                lblStrVar.Text = "( " + temp + " )";
        }

        private void buttonStrDown_Click(object sender, EventArgs e)
        {
            temp--;
            if (temp > 0)
                lblStrVar.Text = "( +" + temp + " )";
            else
                lblStrVar.Text = "( " + temp + " )";
        }
    }
}
