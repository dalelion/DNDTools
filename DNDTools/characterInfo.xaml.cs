using System.Windows;
using System.Windows.Input;

namespace DNDTools
{
    /// <summary>
    /// Interaction logic for CharacterInfo.xaml
    /// </summary>
    public partial class CharacterInfo : Window
    {

        MainGame parent;
        Player player;

        public CharacterInfo(MainGame myParent, Player myPlayer)
        {
            InitializeComponent();

            parent = myParent;
            player = myPlayer;

            txtClass.Text = player.getClass();
            txtRace.Text = player.getRace();
            txtFaction.Text = player.getFaction();

            lblStrConst.Content = parent.StrLbl.Content;
            lblDexConst.Content = parent.DexLbl.Content;
            lblConConst.Content = parent.ConLbl.Content;
            lblIntConst.Content = parent.IntLbl.Content;
            lblWisConst.Content = parent.WisLbl.Content;
            lblChaConst.Content = parent.ChaLbl.Content;

            lblStrVar.Content = parent.StrVarLbl.Content;
            lblDexVar.Content = parent.DexVarLbl.Content;
            lblConVar.Content = parent.ConVarLbl.Content;
            lblIntVar.Content = parent.IntVarLbl.Content;
            lblWisVar.Content = parent.WisVarLbl.Content;
            lblChaVar.Content = parent.ChaVarLbl.Content;

            //Numbers in parenthesis increase/decrease every 2 values, the MAIN values should be controlled by the player

            lblArmorConst.Content = parent.lblArmor.Content;
            lblSpeedConst.Content = parent.lblSpeed.Content;

            if (player.getVariableStat(0) > 0)
            {
                lblAthleticsConst.Content = "+" + player.getVariableStat(0);
            }
            else 
            {
                lblAthleticsConst.Content = player.getVariableStat(0);
            }

            if (player.getVariableStat(1) > 0)
            {
                lblAcrobaticsConst.Content = "+" + player.getVariableStat(1);
                lblSleightConst.Content = "+" + player.getVariableStat(1);
                lblStealthConst.Content = "+" + player.getVariableStat(1);
                lblInitiativeConst.Content = "+" + player.getVariableStat(1);
            }
            else
            { 
                lblAcrobaticsConst.Content = player.getVariableStat(1);
                lblSleightConst.Content = player.getVariableStat(1);
                lblStealthConst.Content = player.getVariableStat(1);
                lblInitiativeConst.Content = player.getVariableStat(1);
            }

            if (player.getVariableStat(3) > 0)
            {
                lblArcanaConst.Content = "+" + player.getVariableStat(3);
                lblHistoryConst.Content = "+" + player.getVariableStat(3);
                lblInvestigationConst.Content = "+" + player.getVariableStat(3);
                lblNatureConst.Content = "+" + player.getVariableStat(3);
                lblReligionConst.Content = "+" + player.getVariableStat(3);
            }
            else
            {
                lblArcanaConst.Content = player.getVariableStat(3);
                lblHistoryConst.Content = player.getVariableStat(3);
                lblInvestigationConst.Content = player.getVariableStat(3);
                lblNatureConst.Content = player.getVariableStat(3);
                lblReligionConst.Content = player.getVariableStat(3);
            }

            if (player.getVariableStat(4) > 0)
            {
                lblAnimalConst.Content = "+" + player.getVariableStat(4);
                lblInsightConst.Content = "+" + player.getVariableStat(4);
                lblMedicineConst.Content = "+" + player.getVariableStat(4);
                lblPerceptionConst.Content = "+" + player.getVariableStat(4);
                lblSurvivalConst.Content = "+" + player.getVariableStat(4);
            }
            else
            { 
                lblAnimalConst.Content = player.getVariableStat(4);
                lblInsightConst.Content = player.getVariableStat(4);
                lblMedicineConst.Content = player.getVariableStat(4);
                lblPerceptionConst.Content = player.getVariableStat(4);
                lblSurvivalConst.Content = player.getVariableStat(4);
            }

            if (player.getVariableStat(5) > 0)
            {
                lblDeceptionConst.Content = "+" + player.getVariableStat(5);
                lblIntimidationConst.Content = "+" + player.getVariableStat(5);
                lblPerformanceConst.Content = "+" + player.getVariableStat(5);
                lblPersuasionConst.Content = "+" + player.getVariableStat(5);
            }
            else
            {
                lblDeceptionConst.Content = player.getVariableStat(5);
                lblIntimidationConst.Content = player.getVariableStat(5);
                lblPerformanceConst.Content = player.getVariableStat(5);
                lblPersuasionConst.Content = player.getVariableStat(5);
            }

            //Skills based on Base Stats
            //Skill values are based on the VAR stats of the player

            //Initiative is based on DEX

            //Speed is based on 5, start at 30
        }

        private void btStrUp_Click(object sender, RoutedEventArgs e)
        {
            int tempBase = player.getBaseStat(0) + 1;

            if (tempBase <= 20)
            {
                player.setBaseStat(0, tempBase);

                int tempVar = tempBase - 10;

                if (tempVar < 0)
                    tempVar--;

                tempVar /= 2;

                player.setVariableStat(0, tempVar);

                if (tempVar > 0)
                {
                    lblStrConst.Content = "" + tempBase;
                    lblStrVar.Content = "(+" + tempVar + ")";
                    lblAthleticsConst.Content = "+" + tempVar;

                    parent.StrLbl.Content = "" + tempBase;
                    parent.StrVarLbl.Content = lblStrVar.Content;
                }
                else
                {
                    lblStrConst.Content = "" + tempBase;
                    lblStrVar.Content = "(" + tempVar + ")";
                    lblAthleticsConst.Content = tempVar;

                    parent.StrLbl.Content = "" + tempBase;
                    parent.StrVarLbl.Content = lblStrVar.Content;
                }
            }
        }

        private void btStrDown_Click(object sender, RoutedEventArgs e)
        {
            int tempBase = player.getBaseStat(0) - 1;

            if (tempBase >= 0)
            {
                player.setBaseStat(0, tempBase);

                int tempVar = tempBase - 10;

                if (tempVar < 0)
                    tempVar--;

                tempVar /= 2;

                player.setVariableStat(0, tempVar);

                if (tempVar > 0)
                {
                    lblStrConst.Content = "" + tempBase;
                    lblStrVar.Content = "(+" + tempVar + ")";

                    lblAthleticsConst.Content = "+" + tempVar;

                    parent.StrLbl.Content = "" + tempBase;
                    parent.StrVarLbl.Content = lblStrVar.Content;
                }
                else
                {
                    lblStrConst.Content = "" + tempBase;
                    lblStrVar.Content = "(" + tempVar + ")";

                    lblAthleticsConst.Content = tempVar;

                    parent.StrLbl.Content = "" + tempBase;
                    parent.StrVarLbl.Content = lblStrVar.Content;
                }
            }
        }

        private void btDexUp_Click(object sender, RoutedEventArgs e)
        {
            int tempBase = player.getBaseStat(1) + 1;

            if (tempBase <= 20)
            {
                player.setBaseStat(1, tempBase);

                int tempVar = tempBase - 10;

                if (tempVar < 0)
                    tempVar--;

                tempVar /= 2;

                player.setVariableStat(1, tempVar);

                if (tempVar > 0)
                {
                    lblDexConst.Content = "" + tempBase;
                    lblDexVar.Content = "(+" + tempVar + ")";

                    lblAcrobaticsConst.Content = "+" + tempVar;
                    lblSleightConst.Content = "+" + tempVar;
                    lblStealthConst.Content = "+" + tempVar;
                    lblInitiativeConst.Content = "+" + tempVar;

                    parent.DexLbl.Content = "" + tempBase;
                    parent.DexVarLbl.Content = lblDexVar.Content;
                    parent.lblInitiative.Content = lblInitiativeConst.Content;
                }
                else
                {
                    lblDexConst.Content = "" + tempBase;
                    lblDexVar.Content = "(" + tempVar + ")";

                    lblAcrobaticsConst.Content = tempVar;
                    lblSleightConst.Content = tempVar;
                    lblStealthConst.Content = tempVar;
                    lblInitiativeConst.Content = tempVar;

                    parent.DexLbl.Content = "" + tempBase;
                    parent.DexVarLbl.Content = lblDexVar.Content;
                    parent.lblInitiative.Content = lblInitiativeConst.Content;
                }
            }
        }

        private void btDexDown_Click(object sender, RoutedEventArgs e)
        {
            int tempBase = player.getBaseStat(1) - 1;

            if (tempBase >= 0)
            {
                player.setBaseStat(1, tempBase);

                int tempVar = tempBase - 10;

                if (tempVar < 0)
                    tempVar--;

                tempVar /= 2;

                player.setVariableStat(1, tempVar);

                if (tempVar > 0)
                {
                    lblDexConst.Content = "" + tempBase;
                    lblDexVar.Content = "(+" + tempVar + ")";

                    lblAcrobaticsConst.Content = "+" + tempVar;
                    lblSleightConst.Content = "+" + tempVar;
                    lblStealthConst.Content = "+" + tempVar;
                    lblInitiativeConst.Content = "+" + tempVar;

                    parent.DexLbl.Content = "" + tempBase;
                    parent.DexVarLbl.Content = lblDexVar.Content;
                    parent.lblInitiative.Content = lblInitiativeConst.Content;
                }
                else
                {
                    lblDexConst.Content = "" + tempBase;
                    lblDexVar.Content = "(" + tempVar + ")";

                    lblAcrobaticsConst.Content = tempVar;
                    lblSleightConst.Content = tempVar;
                    lblStealthConst.Content = tempVar;
                    lblInitiativeConst.Content = tempVar;

                    parent.DexLbl.Content = "" + tempBase;
                    parent.DexVarLbl.Content = lblDexVar.Content;
                    parent.lblInitiative.Content = lblInitiativeConst.Content;
                }
            }
        }

        private void btConUp_Click(object sender, RoutedEventArgs e)
        {
            int tempBase = player.getBaseStat(2) + 1;

            if (tempBase <= 20)
            {
                player.setBaseStat(2, tempBase);

                int tempVar = tempBase - 10;

                if (tempVar < 0)
                    tempVar--;

                tempVar /= 2;

                player.setVariableStat(2, tempVar);

                if (tempVar > 0)
                {
                    lblConConst.Content = "" + tempBase;
                    lblConVar.Content = "(+" + tempVar + ")";

                    parent.ConLbl.Content = "" + tempBase;
                    parent.ConVarLbl.Content = lblConVar.Content;
                }
                else
                {
                    lblConConst.Content = "" + tempBase;
                    lblConVar.Content = "(" + tempVar + ")";

                    parent.ConLbl.Content = "" + tempBase;
                    parent.ConVarLbl.Content = lblConVar.Content;
                }
            }
        }

        private void btConDown_Click(object sender, RoutedEventArgs e)
        {
            int tempBase = player.getBaseStat(2) - 1;

            if (tempBase >= 0)
            {
                player.setBaseStat(2, tempBase);

                int tempVar = tempBase - 10;

                if (tempVar < 0)
                    tempVar--;

                tempVar /= 2;

                player.setVariableStat(2, tempVar);

                if (tempVar > 0)
                {
                    lblConConst.Content = "" + tempBase;
                    lblConVar.Content = "(+" + tempVar + ")";

                    parent.ConLbl.Content = "" + tempBase;
                    parent.ConVarLbl.Content = lblConVar.Content;
                }
                else
                {
                    lblConConst.Content = "" + tempBase;
                    lblConVar.Content = "(" + tempVar + ")";

                    parent.ConLbl.Content = "" + tempBase;
                    parent.ConVarLbl.Content = lblConVar.Content;
                }
            }
        }

        private void btIntUp_Click(object sender, RoutedEventArgs e)
        {
            int tempBase = player.getBaseStat(3) + 1;

            if (tempBase <= 20)
            {
                player.setBaseStat(3, tempBase);

                int tempVar = tempBase - 10;

                if (tempVar < 0)
                    tempVar--;

                tempVar /= 2;

                player.setVariableStat(3, tempVar);

                if (tempVar > 0)
                {
                    lblIntConst.Content = "" + tempBase;
                    lblIntVar.Content = "(+" + tempVar + ")";

                    lblArcanaConst.Content = "+" + tempVar;
                    lblHistoryConst.Content = "+" + tempVar;
                    lblInvestigationConst.Content = "+" + tempVar;
                    lblNatureConst.Content = "+" + tempVar;
                    lblReligionConst.Content = "+" + tempVar;

                    parent.IntLbl.Content = "" + tempBase;
                    parent.IntVarLbl.Content = lblIntVar.Content;
                }
                else
                {
                    lblIntConst.Content = "" + tempBase;
                    lblIntVar.Content = "(" + tempVar + ")";

                    lblArcanaConst.Content = tempVar;
                    lblHistoryConst.Content = tempVar;
                    lblInvestigationConst.Content = tempVar;
                    lblNatureConst.Content = tempVar;
                    lblReligionConst.Content = tempVar;

                    parent.IntLbl.Content = "" + tempBase;
                    parent.IntVarLbl.Content = lblIntVar.Content;
                }
            }
        }

        private void btIntDown_Click(object sender, RoutedEventArgs e)
        {
            int tempBase = player.getBaseStat(3) - 1;

            if (tempBase >= 0)
            {
                player.setBaseStat(3, tempBase);

                int tempVar = tempBase - 10;

                if (tempVar < 0)
                    tempVar--;

                tempVar /= 2;

                player.setVariableStat(3, tempVar);

                if (tempVar > 0)
                {
                    lblIntConst.Content = "" + tempBase;
                    lblIntVar.Content = "(+" + tempVar + ")";

                    lblArcanaConst.Content = "+" + tempVar;
                    lblHistoryConst.Content = "+" + tempVar;
                    lblInvestigationConst.Content = "+" + tempVar;
                    lblNatureConst.Content = "+" + tempVar;
                    lblReligionConst.Content = "+" + tempVar;

                    parent.IntLbl.Content = "" + tempBase;
                    parent.IntVarLbl.Content = lblIntVar.Content;
                }
                else
                {
                    lblIntConst.Content = "" + tempBase;
                    lblIntVar.Content = "(" + tempVar + ")";

                    lblArcanaConst.Content = tempVar;
                    lblHistoryConst.Content = tempVar;
                    lblInvestigationConst.Content = tempVar;
                    lblNatureConst.Content = tempVar;
                    lblReligionConst.Content = tempVar;

                    parent.IntLbl.Content = "" + tempBase;
                    parent.IntVarLbl.Content = lblIntVar.Content;
                }
            }
        }

        private void btWisUp_Click(object sender, RoutedEventArgs e)
        {
            int tempBase = player.getBaseStat(4) + 1;

            if (tempBase <= 20)
            {
                player.setBaseStat(4, tempBase);

                int tempVar = tempBase - 10;

                if (tempVar < 0)
                    tempVar--;

                tempVar /= 2;

                player.setVariableStat(4, tempVar);

                if (tempVar > 0)
                {
                    lblWisConst.Content = "" + tempBase;
                    lblWisVar.Content = "(+" + tempVar + ")";

                    lblAnimalConst.Content = "+" + tempVar;
                    lblInsightConst.Content = "+" + tempVar;
                    lblMedicineConst.Content = "+" + tempVar;
                    lblPerceptionConst.Content = "+" + tempVar;
                    lblSurvivalConst.Content = "+" + tempVar;

                    parent.WisLbl.Content = "" + tempBase;
                    parent.WisVarLbl.Content = lblWisVar.Content;
                }
                else
                {
                    lblWisConst.Content = "" + tempBase;
                    lblWisVar.Content = "(" + tempVar + ")";

                    lblAnimalConst.Content = tempVar;
                    lblInsightConst.Content = tempVar;
                    lblMedicineConst.Content = tempVar;
                    lblPerceptionConst.Content = tempVar;
                    lblSurvivalConst.Content = tempVar;

                    parent.WisLbl.Content = "" + tempBase;
                    parent.WisVarLbl.Content = lblWisVar.Content;
                }
            }
        }

        private void btWisDown_Click(object sender, RoutedEventArgs e)
        {
            int tempBase = player.getBaseStat(4) - 1;

            if (tempBase >= 0)
            {
                player.setBaseStat(4, tempBase);

                int tempVar = tempBase - 10;

                if (tempVar < 0)
                    tempVar--;

                tempVar /= 2;

                player.setVariableStat(4, tempVar);

                if (tempVar > 0)
                {
                    lblWisConst.Content = "" + tempBase;
                    lblWisVar.Content = "(+" + tempVar + ")";

                    lblAnimalConst.Content = "+" + tempVar;
                    lblInsightConst.Content = "+" + tempVar;
                    lblMedicineConst.Content = "+" + tempVar;
                    lblPerceptionConst.Content = "+" + tempVar;
                    lblSurvivalConst.Content = "+" + tempVar;

                    parent.WisLbl.Content = "" + tempBase;
                    parent.WisVarLbl.Content = lblWisVar.Content;
                }
                else
                {
                    lblWisConst.Content = "" + tempBase;
                    lblWisVar.Content = "(" + tempVar + ")";

                    lblAnimalConst.Content = tempVar;
                    lblInsightConst.Content = tempVar;
                    lblMedicineConst.Content = tempVar;
                    lblPerceptionConst.Content = tempVar;
                    lblSurvivalConst.Content = tempVar;

                    parent.WisLbl.Content = "" + tempBase;
                    parent.WisVarLbl.Content = lblWisVar.Content;
                }
            }
        }

        private void btChaUp_Click(object sender, RoutedEventArgs e)
        {
            int tempBase = player.getBaseStat(5) + 1;

            if (tempBase <= 20)
            {
                player.setBaseStat(5, tempBase);

                int tempVar = tempBase - 10;

                if (tempVar < 0)
                    tempVar--;

                tempVar /= 2;

                player.setVariableStat(5, tempVar);

                if (tempVar > 0)
                {
                    lblChaConst.Content = "" + tempBase;
                    lblChaVar.Content = "(+" + tempVar + ")";

                    lblDeceptionConst.Content = "+" + tempVar;
                    lblIntimidationConst.Content = "+" + tempVar;
                    lblPerformanceConst.Content = "+" + tempVar;
                    lblPersuasionConst.Content = "+" + tempVar;

                    parent.ChaLbl.Content = "" + tempBase;
                    parent.ChaVarLbl.Content = lblChaVar.Content;
                }
                else
                {
                    lblChaConst.Content = "" + tempBase;
                    lblChaVar.Content = "(" + tempVar + ")";

                    lblDeceptionConst.Content = tempVar;
                    lblIntimidationConst.Content = tempVar;
                    lblPerformanceConst.Content = tempVar;
                    lblPersuasionConst.Content = tempVar;

                    parent.ChaLbl.Content = "" + tempBase;
                    parent.ChaVarLbl.Content = lblChaVar.Content;
                }
            }
        }

        private void btChaDown_Click(object sender, RoutedEventArgs e)
        {
            int tempBase = player.getBaseStat(5) - 1;

            if (tempBase >= 0)
            {
                player.setBaseStat(5, tempBase);

                int tempVar = tempBase - 10;

                if (tempVar < 0)
                    tempVar--;

                tempVar /= 2;

                player.setVariableStat(5, tempVar);

                if (tempVar > 0)
                {
                    lblChaConst.Content = "" + tempBase;
                    lblChaVar.Content = "(+" + tempVar + ")";

                    lblDeceptionConst.Content = "+" + tempVar;
                    lblIntimidationConst.Content = "+" + tempVar;
                    lblPerformanceConst.Content = "+" + tempVar;
                    lblPersuasionConst.Content = "+" + tempVar;

                    parent.ChaLbl.Content = "" + tempBase;
                    parent.ChaVarLbl.Content = lblChaVar.Content;
                }
                else
                {
                    lblChaConst.Content = "" + tempBase;
                    lblChaVar.Content = "(" + tempVar + ")";

                    lblDeceptionConst.Content = tempVar;
                    lblIntimidationConst.Content = tempVar;
                    lblPerformanceConst.Content = tempVar;
                    lblPersuasionConst.Content = tempVar;

                    parent.ChaLbl.Content = "" + tempBase;
                    parent.ChaVarLbl.Content = lblChaVar.Content;
                }
            }
        }

        private void btArmorUp_Click(object sender, RoutedEventArgs e)
        {
            int tempStat = player.getArmor() + 1;

            //if (tempStat <= 20) Limit is removed, find true max later
            //{
                player.setArmor(tempStat);

                lblArmorConst.Content = "" + tempStat;
                parent.lblArmor.Content = "" + tempStat;
            //}
        }

        private void btArmorDown_Click(object sender, RoutedEventArgs e)
        {
            int tempStat = player.getArmor() - 1;

            if (tempStat >= 0)
            {
                player.setArmor(tempStat);

                lblArmorConst.Content = "" + tempStat;
                parent.lblArmor.Content = "" + tempStat;
            }
        }

        private void btSpeedUp_Click(object sender, RoutedEventArgs e)
        {
            int tempStat = player.getSpeed() + 5;

            player.setSpeed(tempStat);

            lblSpeedConst.Content = "" + tempStat;
            parent.lblSpeed.Content = "" + tempStat;
        }

        private void btSpeedDown_Click(object sender, RoutedEventArgs e)
        {
            int tempStat = player.getSpeed() - 5;

            if (tempStat >= 0)
            {
                player.setSpeed(tempStat);

                lblSpeedConst.Content = "" + tempStat;
                parent.lblSpeed.Content = "" + tempStat;
            }
        }

        private void Keyboard_KeyPress(object sender, KeyEventArgs e)
        {
           player.setClass(txtClass.Text);
           player.setRace(txtRace.Text);
           player.setFaction(txtFaction.Text);
        }
    }
}
