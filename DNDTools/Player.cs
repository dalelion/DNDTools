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
        String playerRace = "";
        String playerFaction = "";

        int[] playerBaseStat = {15, 14, 13, 12, 10, 8};
        int[] playerVariableStat = {2, 2, 1, 1, 0, -1};

        //Deafult Constructor
        public Player()
        {
            name = "Adventurer";
            playerClass = "Paladin";
        }

        public Player(string myName)
        {
            name = myName;
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

        public void setBaseStat(int pos, int value)
        {
            playerBaseStat[pos] = value;
        }

        public int getVariableStat(int pos)
        {
            return playerVariableStat[pos];
        }

        public void setVariableStat(int pos, int value)
        {
            playerVariableStat[pos] = value;
        }

        public String getClass()
        {
            return playerClass;
        }

        public void setClass(String myClass)
        {
            playerClass = myClass;
        }

        public String getRace()
        {
            return playerRace;
        }

        public void setRace(String myRace)
        {
            playerRace = myRace;
        }

        public String getFaction()
        {
            return playerFaction;
        }

        public void setFaction(String myFaction)
        {
            playerFaction = myFaction;
        }
    }
}
