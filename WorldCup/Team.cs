using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldCup
{
    public class Team
    {
        protected string Name;
        protected int Wins;
        protected int Losses;

        public Team()
        {
        }

        public Team(string sName)
        {
            this.Name = sName;
        }

        public Team(string sName, int iWins, int iLosses)
        {
            this.Name = sName;
            this.Wins = iWins;
            this.Losses = iLosses;
        }

        public void setName(string sName)
        {
            this.Name = sName;
        }

        public string getName()
        {
            return this.Name;
        }

        public void setWins(int iWins)
        {
            this.Wins = iWins;
        }

        public int getWins()
        {
            return this.Wins;
        }

        public void setLosses(int iLosses)
        {
            this.Losses = iLosses;
        }

        public int getLosses()
        {
            return this.Losses;
        }






    }
}
