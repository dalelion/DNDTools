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
    public partial class characterInfo1 : Form
    {
        private MainWindow parent;
        private Player player;

        public characterInfo1(MainWindow myParent, Player myPlayer)
        {
            InitializeComponent();

            parent = myParent;
            player = myPlayer;

            lblStrConst.Text = "" + parent.StrLbl.Content;
            lblDexConst.Text = "" + parent.DexLbl.Content;
            lblConConst.Text = "" + parent.ConLbl.Content;
            lblIntConst.Text = "" + parent.IntLbl.Content;
            lblWisConst.Text = "" + parent.WisLbl.Content;
            lblChaConst.Text = "" + parent.ChaLbl.Content;

            lblStrVar.Text = "" + parent.StrVarLbl.Content;
            lblDexVar.Text = "" + parent.DexVarLbl.Content;
            lblConVar.Text = "" + parent.ConVarLbl.Content;
            lblIntVar.Text = "" + parent.IntVarLbl.Content;
            lblWisVar.Text = "" + parent.WisVarLbl.Content;
            lblChaVar.Text = "" + parent.ChaVarLbl.Content;
        }

        private void buttonStrUp_Click(object sender, EventArgs e)
        {
            int temp = player.getVariableStat(0) + 1;
            player.setVariableStat(0, temp);

            if (temp > 0)
            {
                lblStrVar.Text = "(+" + temp + ")";
                parent.StrVarLbl.Content = lblStrVar.Text;
            }
            else
            {
                lblStrVar.Text = "(" + temp + ")";
                parent.StrVarLbl.Content = lblStrVar.Text;
            }
        }

        private void buttonStrDown_Click(object sender, EventArgs e)
        {
            int temp = player.getVariableStat(0) - 1;
            player.setVariableStat(0, temp);

            if (temp > 0)
            {
                lblStrVar.Text = "(+" + temp + ")";
                parent.StrVarLbl.Content = lblStrVar.Text;
            }
            else
            {
                lblStrVar.Text = "(" + temp + ")";
                parent.StrVarLbl.Content = lblStrVar.Text;
            }
        }

        private void buttonDexUp_Click(object sender, EventArgs e)
        {
            int temp = player.getVariableStat(1) + 1;
            player.setVariableStat(1, temp);

            if (temp > 0)
            {
                lblDexVar.Text = "(+" + temp + ")";
                parent.DexVarLbl.Content = lblDexVar.Text;
            }
            else
            {
                lblDexVar.Text = "(" + temp + ")";
                parent.DexVarLbl.Content = lblDexVar.Text;
            }
        }

        private void buttonDexDown_Click(object sender, EventArgs e)
        {
            int temp = player.getVariableStat(1) - 1;
            player.setVariableStat(1, temp);

            if (temp > 0)
            {
                lblDexVar.Text = "(+" + temp + ")";
                parent.DexVarLbl.Content = lblDexVar.Text;
            }
            else
            {
                lblDexVar.Text = "(" + temp + ")";
                parent.DexVarLbl.Content = lblDexVar.Text;
            }
        }

        private void buttonConUp_Click(object sender, EventArgs e)
        {
            int temp = player.getVariableStat(2) + 1;
            player.setVariableStat(2, temp);

            if (temp > 0)
            {
                lblConVar.Text = "(+" + temp + ")";
                parent.ConVarLbl.Content = lblConVar.Text;
            }
            else
            {
                lblConVar.Text = "(" + temp + ")";
                parent.ConVarLbl.Content = lblConVar.Text;
            }
        }

        private void buttonConDown_Click(object sender, EventArgs e)
        {
            int temp = player.getVariableStat(2) - 1;
            player.setVariableStat(2, temp);

            if (temp > 0)
            {
                lblConVar.Text = "(+" + temp + ")";
                parent.ConVarLbl.Content = lblConVar.Text;
            }
            else
            {
                lblConVar.Text = "(" + temp + ")";
                parent.ConVarLbl.Content = lblConVar.Text;
            }
        }

        private void buttonIntUp_Click(object sender, EventArgs e)
        {
            int temp = player.getVariableStat(3) + 1;
            player.setVariableStat(3, temp);

            if (temp > 0)
            {
                lblIntVar.Text = "(+" + temp + ")";
                parent.IntVarLbl.Content = lblIntVar.Text;
            }
            else
            {
                lblIntVar.Text = "(" + temp + ")";
                parent.IntVarLbl.Content = lblIntVar.Text;
            }
        }

        private void buttonIntDown_Click(object sender, EventArgs e)
        {
            int temp = player.getVariableStat(3) - 1;
            player.setVariableStat(3, temp);

            if (temp > 0)
            {
                lblIntVar.Text = "(+" + temp + ")";
                parent.IntVarLbl.Content = lblIntVar.Text;
            }
            else
            {
                lblIntVar.Text = "(" + temp + ")";
                parent.IntVarLbl.Content = lblIntVar.Text;
            }
        }

        private void buttonWisUp_Click(object sender, EventArgs e)
        {
            int temp = player.getVariableStat(4) + 1;
            player.setVariableStat(4, temp);

            if (temp > 0)
            {
                lblWisVar.Text = "(+" + temp + ")";
                parent.WisVarLbl.Content = lblWisVar.Text;
            }
            else
            {
                lblWisVar.Text = "(" + temp + ")";
                parent.WisVarLbl.Content = lblWisVar.Text;
            }
        }

        private void buttonWisDown_Click(object sender, EventArgs e)
        {
            int temp = player.getVariableStat(4) - 1;
            player.setVariableStat(4, temp);

            if (temp > 0)
            {
                lblWisVar.Text = "(+" + temp + ")";
                parent.WisVarLbl.Content = lblWisVar.Text;
            }
            else
            {
                lblWisVar.Text = "(" + temp + ")";
                parent.WisVarLbl.Content = lblWisVar.Text;
            }
        }

        private void buttonChaUp_Click(object sender, EventArgs e)
        {
            int temp = player.getVariableStat(5) + 1;
            player.setVariableStat(5, temp);

            if (temp > 0)
            {
                lblChaVar.Text = "(+" + temp + ")";
                parent.ChaVarLbl.Content = lblChaVar.Text;
            }
            else
            {
                lblChaVar.Text = "(" + temp + ")";
                parent.ChaVarLbl.Content = lblChaVar.Text;
            }
        }

        private void buttonChaDown_Click(object sender, EventArgs e)
        {
            int temp = player.getVariableStat(5) - 1;
            player.setVariableStat(5, temp);

            if (temp > 0)
            {
                lblChaVar.Text = "(+" + temp + ")";
                parent.ChaVarLbl.Content = lblChaVar.Text;
            }
            else
            {
                lblChaVar.Text = "(" + temp + ")";
                parent.ChaVarLbl.Content = lblChaVar.Text;
            }
        }
    }
}
