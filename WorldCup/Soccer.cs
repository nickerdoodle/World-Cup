using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldCup
{
   public  class Soccer : Team
    {
        private string Group;
        private int Points;
        private int Goals;
        List<Game> myGames = new List<Game>();

        public Soccer(): base()
        {

        }

        public Soccer(string sName, int iWins, int iLosses, string sGroup, int iPoints, int iGoals, int iGames): base(sName, iWins, iLosses)
        {
            this.Group = sGroup;
            this.Points = iPoints;
            this.Goals = iGoals;
            
            for (int iCount=0; iCount<iGames; iCount++)
            {
                myGames.Add(new Game());
            }
        }

        public Soccer(string sName): base(sName)
        {
            
        }

        public void addPoints(int iAdd)
        {
            this.Points = this.Points + iAdd;
        }

        public void addGoals (int iGoals)
        {
            this.Goals = this.Goals + iGoals;
        }

        public int getGoals ()
        {
            return this.Goals;
        }

        public string getGroup()
        {
            return this.Group;
        }

        public void addWin()
        {
            this.Wins++;
        }

        public void addLoss()
        {
            this.Losses++;
        }

        public void addNewGame(string sOppName, int iGoalsFor, int iGoalsAgainst, string sStatus, int iOT, string sGameDesc)
        {
            this.myGames.Add(new Game(sOppName, iGoalsFor, iGoalsAgainst, sStatus, iOT, sGameDesc));
        }

        public int getPoints()
        {
            return this.Points;
        }

    }
}
