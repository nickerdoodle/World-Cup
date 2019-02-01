using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldCup
{
   public class Game
    {
        public string OpponentName;
        public int GoalsFor;
        public int GoalsAgainst;
        public string Status;
        public int OTnum;
        public string GameDescription;

        public Game()
        {

        }

        public Game(string sOppName, int iGoalsFor, int iGoalsAgainst, string sStatus, int iOT, string sGameDesc)
        {
            this.OpponentName = sOppName;
            this.GoalsFor = iGoalsFor;
            this.GoalsAgainst = iGoalsAgainst;
            this.Status = sStatus;
            this.OTnum = iOT;
            this.GameDescription = sGameDesc;
        }

        public void setOppName(string sOppName)
        {
            this.OpponentName = sOppName;
        }

        public string getOppName()
        {
            return this.OpponentName;
        }

        public void setGoalsFor(int iSetGoals)
        {
            this.GoalsFor = iSetGoals;
        }

        public int getGoalsFor()
        {
            return this.GoalsFor;
        }

        public void setGoalsAgainst(int iGoalAgainst)
        {
            this.GoalsAgainst = iGoalAgainst;
        }

        public int getGoalsAgainst()
        {
            return this.GoalsAgainst;
        }

        public int addResult(string sResult)
        {
            if (sResult=="W")
            {
                return 3;
            }

            else if (sResult=="L")
            {
                return 0;
            }

            else 
            {
                return 1;
            }
        }

        public void setGameDesc(int iGamesPlayed)
        {
            if (iGamesPlayed<4)
            {
                this.GameDescription = "Group";
            }

            else if (iGamesPlayed==4)
            {
                this.GameDescription = "Round 16";
            }

            else if (iGamesPlayed==5)
            {
                this.GameDescription = "Quarter";
            }

            else if (iGamesPlayed==6)
            {
                this.GameDescription = "Semi";

            }
            else
            {
                this.GameDescription = "Final";
            }
        }

        public void addOT()
        {
            this.OTnum++;
        }



    }
}
