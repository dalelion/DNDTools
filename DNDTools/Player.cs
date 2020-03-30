using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDTools
{
    public class Player
    {
        String name = "";
        String playerClass = "";
        int[] playerBaseStat = {15, 14, 13, 12, 10, 8};
        int[] playerVariableStat = {0, 0, 0, 0, 0, 0};

        //Deafult Constructor
        public Player()
        {
            name = "Adventurer";
            playerClass = "Paladin";
        }

        //Constructor for customized character
        public Player(String myName, String myClass, int[] myStats)
        {
            name = myName;
            playerClass = myClass;
            playerBaseStat = myStats;
        }

        public String getName()
        {
            return name;
        }
        public int getBaseStat(int pos)
        {
            return playerBaseStat[pos];
        }

        public int getVariableStat(int pos)
        {
            return playerVariableStat[pos];
        }

        public void setVariableStat(int pos, int value)
        {
            playerVariableStat[pos] = value;
        }
    }
}
