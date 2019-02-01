using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorldCup
{
    public partial class frmMain : Form
    {
        //Author: Nicholas Mahe
        //Description: This project simulates the world cup to determine a champ
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {//create lists for each lbox
            List<Soccer> lstSoccerA = new List<Soccer>();
            List<Soccer> lstSoccerB = new List<Soccer>();
            List<Soccer> lstSoccerC = new List<Soccer>();
            List<Soccer> lstSoccerD = new List<Soccer>();
            List<Soccer> lstSoccerE = new List<Soccer>();
            List<Soccer> lstSoccerF = new List<Soccer>();
            List<Soccer> lstSoccerG = new List<Soccer>();
            List<Soccer> lstSoccerH = new List<Soccer>();
            Random oRand = new Random();
            int iScore1;
            int iScore2;


            //create objects with the name
            for (int iCount = 0; iCount < lstGroupA.Items.Count; iCount++)
            {
                lstSoccerA.Add(new Soccer(lstGroupA.Items[iCount].ToString()));
                lstSoccerB.Add(new Soccer(lstGroupB.Items[iCount].ToString()));
                lstSoccerC.Add(new Soccer(lstGroupB.Items[iCount].ToString()));
                lstSoccerD.Add(new Soccer(lstGroupB.Items[iCount].ToString()));
                lstSoccerE.Add(new Soccer(lstGroupB.Items[iCount].ToString()));
                lstSoccerF.Add(new Soccer(lstGroupB.Items[iCount].ToString()));
                lstSoccerG.Add(new Soccer(lstGroupB.Items[iCount].ToString()));
                lstSoccerH.Add(new Soccer(lstGroupB.Items[iCount].ToString()));
            }

            //simulate the games for group play... for A-H. Just change the letters for each list
            for (int iCount = 0; iCount < lstGroupA.Items.Count - 1; iCount++)
            {
                for (int iOppCount = iCount + 1; iOppCount < lstGroupA.Items.Count; iOppCount++)
                {

                    iScore1 = oRand.Next(11);
                    iScore2 = oRand.Next(11);
                    string sStatus;
                    string sOther;

                    if (iScore1 > iScore2)
                    {
                        lstSoccerA[iCount].addWin();
                        //lstSoccerA[iCount].addPoints();
                        lstSoccerA[iOppCount].addLoss();
                        sStatus = "W";
                        sOther = "L"; //sOther should be in the other games played as well
                    }

                    else if (iScore1 < iScore2)
                    {
                        lstSoccerA[iCount].addLoss();
                        lstSoccerA[iOppCount].addWin();
                        sStatus = "L";
                        sOther = "W";
                    }

                    else
                    {
                        sStatus = "T";
                        sOther = "T";
                    }

                    lstSoccerA[iCount].addNewGame(lstSoccerA[iOppCount].getName(), iScore1, iScore2, sStatus, 0, "Group");
                    lstSoccerA[iOppCount].addNewGame(lstSoccerA[iCount].getName(), iScore2, iScore1, sOther, 0, "Group");
                    //the add games for the opponent should be in the other games as well...




                }


            }

            for (int iCount = 0; iCount < lstGroupB.Items.Count - 1; iCount++)
            {
                for (int iOppCount = iCount + 1; iOppCount < lstGroupB.Items.Count; iOppCount++)
                {

                    iScore1 = oRand.Next(11);
                    iScore2 = oRand.Next(11);
                    string sStatus;
                    string sOther;

                    if (iScore1 > iScore2)
                    {
                        lstSoccerB[iCount].addWin();
                        //lstSoccerA[iCount].addPoints();
                        lstSoccerB[iOppCount].addLoss();
                        sStatus = "W";
                        sOther = "L";
                    }

                    else if (iScore1 < iScore2)
                    {
                        lstSoccerB[iCount].addLoss();
                        lstSoccerB[iOppCount].addWin();
                        sStatus = "L";
                        sOther = "W";
                    }

                    else
                    {
                        sStatus = "T";
                        sOther = "T";
                    }

                    lstSoccerB[iCount].addNewGame(lstSoccerB[iOppCount].getName(), iScore1, iScore2, sStatus, 0, "Group");
                    lstSoccerB[iOppCount].addNewGame(lstSoccerB[iCount].getName(), iScore2, iScore1, sOther, 0, "Group");



                }


            }

            for (int iCount = 0; iCount < lstGroupC.Items.Count - 1; iCount++)
            {
                for (int iOppCount = iCount + 1; iOppCount < lstGroupC.Items.Count; iOppCount++)
                {

                    iScore1 = oRand.Next(11);
                    iScore2 = oRand.Next(11);
                    string sStatus;
                    string sOther;

                    if (iScore1 > iScore2)
                    {
                        lstSoccerC[iCount].addWin();
                        //lstSoccerA[iCount].addPoints();
                        lstSoccerC[iOppCount].addLoss();
                        sStatus = "W";
                        sOther = "L";
                    }

                    else if (iScore1 < iScore2)
                    {
                        lstSoccerC[iCount].addLoss();
                        lstSoccerC[iOppCount].addWin();
                        sStatus = "L";
                        sOther = "W";
                    }

                    else
                    {
                        sStatus = "T";
                        sOther = "T";
                    }

                    lstSoccerC[iCount].addNewGame(lstSoccerC[iOppCount].getName(), iScore1, iScore2, sStatus, 0, "Group");
                    lstSoccerC[iOppCount].addNewGame(lstSoccerC[iCount].getName(), iScore2, iScore1, sOther, 0, "Group");




                }


            }

            for (int iCount = 0; iCount < lstGroupD.Items.Count - 1; iCount++)
            {
                for (int iOppCount = iCount + 1; iOppCount < lstGroupD.Items.Count; iOppCount++)
                {

                    iScore1 = oRand.Next(11);
                    iScore2 = oRand.Next(11);
                    string sStatus;
                    string sOther;

                    if (iScore1 > iScore2)
                    {
                        lstSoccerD[iCount].addWin();
                        //lstSoccerA[iCount].addPoints();
                        lstSoccerD[iOppCount].addLoss();
                        sStatus = "W";
                        sOther = "L";
                    }

                    else if (iScore1 < iScore2)
                    {
                        lstSoccerD[iCount].addLoss();
                        lstSoccerD[iOppCount].addWin();
                        sStatus = "L";
                        sOther = "W";
                    }

                    else
                    {
                        sStatus = "T";
                        sOther = "T";
                    }

                    lstSoccerD[iCount].addNewGame(lstSoccerD[iOppCount].getName(), iScore1, iScore2, sStatus, 0, "Group");
                    lstSoccerD[iOppCount].addNewGame(lstSoccerD[iCount].getName(), iScore2, iScore1, sOther, 0, "Group");




                }


            }

            for (int iCount = 0; iCount < lstGroupE.Items.Count - 1; iCount++)
            {
                for (int iOppCount = iCount + 1; iOppCount < lstGroupE.Items.Count; iOppCount++)
                {

                    iScore1 = oRand.Next(11);
                    iScore2 = oRand.Next(11);
                    string sStatus;
                    string sOther;

                    if (iScore1 > iScore2)
                    {
                        lstSoccerE[iCount].addWin();
                        //lstSoccerA[iCount].addPoints();
                        lstSoccerE[iOppCount].addLoss();
                        sStatus = "W";
                        sOther = "L";
                    }

                    else if (iScore1 < iScore2)
                    {
                        lstSoccerE[iCount].addLoss();
                        lstSoccerE[iOppCount].addWin();
                        sStatus = "L";
                        sOther = "W";
                    }

                    else
                    {
                        sStatus = "T";
                        sOther = "T";
                    }

                    lstSoccerE[iCount].addNewGame(lstSoccerE[iOppCount].getName(), iScore1, iScore2, sStatus, 0, "Group");
                    lstSoccerE[iOppCount].addNewGame(lstSoccerE[iCount].getName(), iScore2, iScore1, sOther, 0, "Group");




                }


            }

            for (int iCount = 0; iCount < lstGroupF.Items.Count - 1; iCount++)
            {
                for (int iOppCount = iCount + 1; iOppCount < lstGroupF.Items.Count; iOppCount++)
                {

                    iScore1 = oRand.Next(11);
                    iScore2 = oRand.Next(11);
                    string sStatus;
                    string sOther;

                    if (iScore1 > iScore2)
                    {
                        lstSoccerF[iCount].addWin();
                        //lstSoccerA[iCount].addPoints();
                        lstSoccerF[iOppCount].addLoss();
                        sStatus = "W";
                        sOther = "L";
                    }

                    else if (iScore1 < iScore2)
                    {
                        lstSoccerF[iCount].addLoss();
                        lstSoccerF[iOppCount].addWin();
                        sStatus = "L";
                        sOther = "W";
                    }

                    else
                    {
                        sStatus = "T";
                        sOther = "T";
                    }

                    lstSoccerF[iCount].addNewGame(lstSoccerF[iOppCount].getName(), iScore1, iScore2, sStatus, 0, "Group");
                    lstSoccerF[iOppCount].addNewGame(lstSoccerF[iCount].getName(), iScore2, iScore1, sOther, 0, "Group");




                }


            }

            for (int iCount = 0; iCount < lstGroupG.Items.Count - 1; iCount++)
            {
                for (int iOppCount = iCount + 1; iOppCount < lstGroupG.Items.Count; iOppCount++)
                {

                    iScore1 = oRand.Next(11);
                    iScore2 = oRand.Next(11);
                    string sStatus;
                    string sOther;

                    if (iScore1 > iScore2)
                    {
                        lstSoccerG[iCount].addWin();
                        //lstSoccerA[iCount].addPoints();
                        lstSoccerG[iOppCount].addLoss();
                        sStatus = "W";
                        sOther = "L";
                    }

                    else if (iScore1 < iScore2)
                    {
                        lstSoccerG[iCount].addLoss();
                        lstSoccerG[iOppCount].addWin();
                        sStatus = "L";
                        sOther = "W";
                    }

                    else
                    {
                        sStatus = "T";
                        sOther = "T";
                    }

                    lstSoccerG[iCount].addNewGame(lstSoccerG[iOppCount].getName(), iScore1, iScore2, sStatus, 0, "Group");
                    lstSoccerG[iOppCount].addNewGame(lstSoccerG[iCount].getName(), iScore2, iScore1, sOther, 0, "Group");




                }


            }

            for (int iCount = 0; iCount < lstGroupH.Items.Count - 1; iCount++)
            {
                for (int iOppCount = iCount + 1; iOppCount < lstGroupH.Items.Count; iOppCount++)
                {

                    iScore1 = oRand.Next(11);
                    iScore2 = oRand.Next(11);
                    string sStatus;
                    string sOther;

                    if (iScore1 > iScore2)
                    {
                        lstSoccerH[iCount].addWin();
                        //lstSoccerA[iCount].addPoints();
                        lstSoccerH[iOppCount].addLoss();
                        sStatus = "W";
                        sOther = "L";
                    }

                    else if (iScore1 < iScore2)
                    {
                        lstSoccerH[iCount].addLoss();
                        lstSoccerH[iOppCount].addWin();
                        sStatus = "L";
                        sOther = "W";
                    }

                    else
                    {
                        sStatus = "T";
                        sOther = "T";
                    }

                    lstSoccerH[iCount].addNewGame(lstSoccerH[iOppCount].getName(), iScore1, iScore2, sStatus, 0, "Group");
                    lstSoccerH[iOppCount].addNewGame(lstSoccerH[iCount].getName(), iScore2, iScore1, sOther, 0, "Group");




                }


            }
            //Sort for the most wins
            lstSoccerA.Sort((x, y) => y.getWins().CompareTo(x.getWins()));
            lstSoccerB.Sort((x, y) => y.getWins().CompareTo(x.getWins()));
            lstSoccerC.Sort((x, y) => y.getWins().CompareTo(x.getWins()));
            lstSoccerD.Sort((x, y) => y.getWins().CompareTo(x.getWins()));
            lstSoccerE.Sort((x, y) => y.getWins().CompareTo(x.getWins()));
            lstSoccerF.Sort((x, y) => y.getWins().CompareTo(x.getWins()));
            lstSoccerG.Sort((x, y) => y.getWins().CompareTo(x.getWins()));
            lstSoccerH.Sort((x, y) => y.getWins().CompareTo(x.getWins()));

            //account for ties... Do each list
            //
            while (lstSoccerA[0].getWins() == lstSoccerA[1].getWins())
            {
                if (lstSoccerA[0].getPoints() < lstSoccerA[1].getPoints())
                {
                    lstSoccerA[0] = lstSoccerA[1];
                }
                //if first team has more points or is tied, then just keep the same

            }
            //Do this for all groups

            //Display names in bracket
            this.lblGroupA1.Text = lstSoccerA[0].getName();
            this.lblGroupA2.Text = lstSoccerA[1].getName();
            this.lblGroupB1.Text = lstSoccerB[0].getName();
            this.lblGroupB2.Text = lstSoccerB[1].getName();
            this.lblGroupC1.Text = lstSoccerC[0].getName();
            this.lblGroupC2.Text = lstSoccerC[1].getName();
            this.lblGroupD1.Text = lstSoccerD[0].getName();
            this.lblGroupD2.Text = lstSoccerD[1].getName();
            this.lblGroupE1.Text = lstSoccerE[0].getName();
            this.lblGroupE2.Text = lstSoccerE[1].getName();
            this.lblGroupF1.Text = lstSoccerF[0].getName();
            this.lblGroupF2.Text = lstSoccerF[1].getName();
            this.lblGroupG1.Text = lstSoccerG[0].getName();
            this.lblGroupG2.Text = lstSoccerG[1].getName();
            this.lblGroupH1.Text = lstSoccerH[0].getName();
            this.lblGroupH2.Text = lstSoccerH[1].getName();


            //Play round 16... do this for the 8 matches

            iScore1 = oRand.Next(11);
            iScore2 = oRand.Next(11);
            int iOT = 0;

            while (iScore1 == iScore2)
            {
                iScore1 = oRand.Next(20);
                iScore2 = oRand.Next(20);
                iOT++;
            }

            if (iScore1 > iScore2)
            {

                lstSoccerA[0].addNewGame(lstSoccerB[1].getName(), iScore1, iScore2, "W", iOT, "Round 16");
                lstSoccerB[1].addNewGame(lstSoccerA[0].getName(), iScore2, iScore1, "L", iOT, "Round 16");
                //advance the winner to the next round and label
                this.lblWinnerA1B2.Text = lstSoccerA[0].getName();
                Team qFinal1 = lstSoccerA[0];
            }

            else
            {
                lstSoccerB[1].addNewGame(lstSoccerA[0].getName(), iScore1, iScore2, "W", iOT, "Round 16");
                lstSoccerA[0].addNewGame(lstSoccerB[1].getName(), iScore2, iScore1, "L", iOT, "Round 16");

                this.lblWinnerA1B2.Text = lstSoccerB[1].getName();
                Team qFinal1 = lstSoccerB[1];
            }

            iScore1 = oRand.Next(11);
            iScore2 = oRand.Next(11);
            iOT = 0;//Reset the overtime periods to 0 in each sequence... no time to make the changes

            while (iScore1 == iScore2)
            {
                iScore1 = oRand.Next(20);
                iScore2 = oRand.Next(20);
                iOT++;
            }

            if (iScore1 > iScore2)
            {

                lstSoccerC[0].addNewGame(lstSoccerD[1].getName(), iScore1, iScore2, "W", iOT, "Round 16");
                lstSoccerD[1].addNewGame(lstSoccerC[0].getName(), iScore2, iScore1, "L", iOT, "Round 16");
                this.lblWinnerC1D2.Text = lstSoccerC[0].getName();
                Team qFinal2 = lstSoccerC[0];
            }

            else
            {
                lstSoccerD[1].addNewGame(lstSoccerC[0].getName(), iScore1, iScore2, "W", iOT, "Round 16");
                lstSoccerC[0].addNewGame(lstSoccerD[1].getName(), iScore2, iScore1, "L", iOT, "Round 16");
                this.lblWinnerC1D2.Text = lstSoccerD[1].getName();
                Team qFinal2 = lstSoccerD[1];
            }

            iScore1 = oRand.Next(11);
            iScore2 = oRand.Next(11);
            iOT = 0;//Reset the overtime periods to 0 in each sequence... no time to make the changes

            while (iScore1 == iScore2)
            {
                iScore1 = oRand.Next(20);
                iScore2 = oRand.Next(20);
                iOT++;
            }

            if (iScore1 > iScore2)
            {

                lstSoccerE[0].addNewGame(lstSoccerF[1].getName(), iScore1, iScore2, "W", iOT, "Round 16");
                lstSoccerF[1].addNewGame(lstSoccerE[0].getName(), iScore2, iScore1, "L", iOT, "Round 16");
                this.lblWinnerE1F2.Text = lstSoccerE[0].getName();
                Team qFinal3 = lstSoccerE[0];
            }

            else
            {
                lstSoccerF[1].addNewGame(lstSoccerE[0].getName(), iScore1, iScore2, "W", iOT, "Round 16");
                lstSoccerE[0].addNewGame(lstSoccerF[1].getName(), iScore2, iScore1, "L", iOT, "Round 16");
                this.lblWinnerE1F2.Text = lstSoccerF[1].getName();
                Team qFinal3 = lstSoccerF[1];
            }

            iScore1 = oRand.Next(11);
            iScore2 = oRand.Next(11);
            iOT = 0;//Reset the overtime periods to 0 in each sequence... no time to make the changes

            while (iScore1 == iScore2)
            {
                iScore1 = oRand.Next(20);
                iScore2 = oRand.Next(20);
                iOT++;
            }

            if (iScore1 > iScore2)
            {

                lstSoccerG[0].addNewGame(lstSoccerH[1].getName(), iScore1, iScore2, "W", iOT, "Round 16");
                lstSoccerH[1].addNewGame(lstSoccerG[0].getName(), iScore2, iScore1, "L", iOT, "Round 16");
                this.lblWinnerG1H2.Text = lstSoccerG[0].getName();
                Team qFinal4 = lstSoccerG[0];
            }

            else
            {
                lstSoccerH[1].addNewGame(lstSoccerG[0].getName(), iScore1, iScore2, "W", iOT, "Round 16");
                lstSoccerG[0].addNewGame(lstSoccerH[1].getName(), iScore2, iScore1, "L", iOT, "Round 16");
                this.lblWinnerG1H2.Text = lstSoccerH[1].getName();
                Team qFinal4 = lstSoccerH[1];
            }

            iScore1 = oRand.Next(11);
            iScore2 = oRand.Next(11);
            iOT = 0;//Reset the overtime periods to 0 in each sequence... no time to make the changes

            while (iScore1 == iScore2)
            {
                iScore1 = oRand.Next(20);
                iScore2 = oRand.Next(20);
                iOT++;
            }

            if (iScore1 > iScore2)
            {

                lstSoccerA[1].addNewGame(lstSoccerA[0].getName(), iScore1, iScore2, "W", iOT, "Round 16");
                lstSoccerB[0].addNewGame(lstSoccerB[1].getName(), iScore2, iScore1, "L", iOT, "Round 16");
                this.lblWinnerB1A2.Text = lstSoccerA[1].getName();
                Team qFinal5 = lstSoccerA[1];
            }

            else
            {
                lstSoccerB[0].addNewGame(lstSoccerA[1].getName(), iScore1, iScore2, "W", iOT, "Round 16");
                lstSoccerA[1].addNewGame(lstSoccerB[0].getName(), iScore2, iScore1, "L", iOT, "Round 16");
                this.lblWinnerB1A2.Text = lstSoccerB[0].getName();
                Team qFinal5 = lstSoccerB[0];
            }

            iScore1 = oRand.Next(11);
            iScore2 = oRand.Next(11);
            iOT = 0;//Reset the overtime periods to 0 in each sequence... no time to make the changes

            while (iScore1 == iScore2)
            {
                iScore1 = oRand.Next(20);
                iScore2 = oRand.Next(20);
                iOT++;
            }

            if (iScore1 > iScore2)
            {

                lstSoccerC[1].addNewGame(lstSoccerD[0].getName(), iScore1, iScore2, "W", iOT, "Round 16");
                lstSoccerD[0].addNewGame(lstSoccerC[1].getName(), iScore2, iScore1, "L", iOT, "Round 16");
                this.lblWinnerC1D2.Text = lstSoccerC[1].getName();
                Team qFinal6 = lstSoccerC[1];
            }

            else
            {
                lstSoccerD[0].addNewGame(lstSoccerC[1].getName(), iScore1, iScore2, "W", iOT, "Round 16");
                lstSoccerC[1].addNewGame(lstSoccerD[0].getName(), iScore2, iScore1, "L", iOT, "Round 16");
                this.lblWinnerD1C2.Text = lstSoccerD[0].getName();
                Team qFinal6 = lstSoccerD[0];
            }

            iScore1 = oRand.Next(11);
            iScore2 = oRand.Next(11);
            iOT = 0;//Reset the overtime periods to 0 in each sequence... no time to make the changes

            while (iScore1 == iScore2)
            {
                iScore1 = oRand.Next(20);
                iScore2 = oRand.Next(20);
                iOT++;
            }

            if (iScore1 > iScore2)
            {

                lstSoccerE[1].addNewGame(lstSoccerF[0].getName(), iScore1, iScore2, "W", iOT, "Round 16");
                lstSoccerF[0].addNewGame(lstSoccerE[1].getName(), iScore2, iScore1, "L", iOT, "Round 16");
                this.lblWinnerF1E2.Text = lstSoccerF[0].getName();
                Team qFinal7 = lstSoccerE[1];
            }

            else
            {
                lstSoccerF[0].addNewGame(lstSoccerE[1].getName(), iScore1, iScore2, "W", iOT, "Round 16");
                lstSoccerE[1].addNewGame(lstSoccerF[0].getName(), iScore2, iScore1, "L", iOT, "Round 16");
                this.lblWinnerF1E2.Text = lstSoccerD[0].getName();
                Team qFinal7 = lstSoccerF[0];
            }

            iScore1 = oRand.Next(11);
            iScore2 = oRand.Next(11);
            iOT = 0;//Reset the overtime periods to 0 in each sequence... no time to make the changes

            while (iScore1 == iScore2)
            {
                iScore1 = oRand.Next(20);
                iScore2 = oRand.Next(20);
                iOT++;
            }

            if (iScore1 > iScore2)
            {

                lstSoccerG[1].addNewGame(lstSoccerE[0].getName(), iScore1, iScore2, "W", iOT, "Round 16");
                lstSoccerH[0].addNewGame(lstSoccerF[1].getName(), iScore2, iScore1, "L", iOT, "Round 16");
                this.lblWinnerH1G2.Text = lstSoccerD[0].getName();
                Team qFinal8 = lstSoccerH[1];
            }

            else
            {
                lstSoccerH[0].addNewGame(lstSoccerG[1].getName(), iScore1, iScore2, "W", iOT, "Round 16");
                lstSoccerG[1].addNewGame(lstSoccerH[0].getName(), iScore2, iScore1, "L", iOT, "Round 16");
                this.lblWinnerH1G2.Text = lstSoccerD[0].getName();
                Team qFinal8 = lstSoccerG[0];
            }


            //simulate the quarter finals

            iScore1 = oRand.Next(11);
            iScore2 = oRand.Next(11);
            iOT = 0;

            while (iScore1 == iScore2)
            {
                iScore1 = oRand.Next(20);
                iScore2 = oRand.Next(20);
                iOT++;
            }

            if (iScore1 > iScore2)
            {

                lstSoccerA[0].addNewGame(lstSoccerB[1].getName(), iScore1, iScore2, "W", iOT, "Semi Finals");
                lstSoccerB[1].addNewGame(lstSoccerA[0].getName(), iScore2, iScore1, "L", iOT, "Semi Finals");

                this.lblQtr1.Text = this.lblWinnerA1B2.Text;
            }

            else
            {
                lstSoccerB[1].addNewGame(lstSoccerA[0].getName(), iScore1, iScore2, "W", iOT, "Semi Finals");
                lstSoccerB[0].addNewGame(lstSoccerB[1].getName(), iScore2, iScore1, "L", iOT, "Semi Finals");
                this.lblQtr1.Text = this.lblWinnerC1D2.Text;
            }
            //Do this for whole bracket, changing the label for each corresponding spot

            iScore1 = oRand.Next(11);
            iScore2 = oRand.Next(11);
            iOT = 0;

            while (iScore1 == iScore2)
            {
                iScore1 = oRand.Next(20);
                iScore2 = oRand.Next(20);
                iOT++;
            }

            if (iScore1 > iScore2)
            {

                lstSoccerA[0].addNewGame(lstSoccerB[1].getName(), iScore1, iScore2, "W", iOT, "Semi Finals");
                lstSoccerB[1].addNewGame(lstSoccerA[0].getName(), iScore2, iScore1, "L", iOT, "Semi Finals");

                this.lblQtr1.Text = this.lblWinnerA1B2.Text;
            }


            lstSoccerB[1].addNewGame(lstSoccerA[0].getName(), iScore1, iScore2, "W", iOT, "Semi Finals");
            lstSoccerB[0].addNewGame(lstSoccerB[1].getName(), iScore2, iScore1, "L", iOT, "Semi Finals");
            this.lblQtr1.Text = this.lblWinnerC1D2.Text;

            iScore1 = oRand.Next(11);
            iScore2 = oRand.Next(11);
            iOT = 0;

            while (iScore1 == iScore2)
            {
                iScore1 = oRand.Next(20);
                iScore2 = oRand.Next(20);
                iOT++;
            }

            if (iScore1 > iScore2)
            {

                lstSoccerA[0].addNewGame(lstSoccerB[1].getName(), iScore1, iScore2, "W", iOT, "Semi Finals");
                lstSoccerB[1].addNewGame(lstSoccerA[0].getName(), iScore2, iScore1, "L", iOT, "Semi Finals");

                this.lblQtr1.Text = this.lblWinnerA1B2.Text;
            }

            else
            {
                lstSoccerB[1].addNewGame(lstSoccerA[0].getName(), iScore1, iScore2, "W", iOT, "Semi Finals");
                lstSoccerB[0].addNewGame(lstSoccerB[1].getName(), iScore2, iScore1, "L", iOT, "Semi Finals");
                this.lblQtr1.Text = this.lblWinnerC1D2.Text;
            }

            iScore1 = oRand.Next(11);
            iScore2 = oRand.Next(11);
            iOT = 0;


            while (iScore1 == iScore2)
            {
                iScore1 = oRand.Next(20);
                iScore2 = oRand.Next(20);
                iOT++;
            }

            if (iScore1 > iScore2)
            {

                lstSoccerA[0].addNewGame(lstSoccerB[1].getName(), iScore1, iScore2, "W", iOT, "Semi Finals");
                lstSoccerB[1].addNewGame(lstSoccerA[0].getName(), iScore2, iScore1, "L", iOT, "Semi Finals");

                this.lblQtr1.Text = this.lblWinnerA1B2.Text;
            }

            else
            {
                lstSoccerB[1].addNewGame(lstSoccerA[0].getName(), iScore1, iScore2, "W", iOT, "Semi Finals");
                lstSoccerB[0].addNewGame(lstSoccerB[1].getName(), iScore2, iScore1, "L", iOT, "Semi Finals");
                this.lblQtr1.Text = this.lblWinnerC1D2.Text;




            }


            //Simulate semis

            iScore1 = oRand.Next(11);
            iScore2 = oRand.Next(11);
            iOT = 0;

            while (iScore1 == iScore2)
            {
                iScore1 = oRand.Next(20);
                iScore2 = oRand.Next(20);
                iOT++;
            }

            if (iScore1 > iScore2)
            {

                lstSoccerA[0].addNewGame(lstSoccerB[1].getName(), iScore1, iScore2, "W", iOT, "Quarter Finals");
                lstSoccerB[1].addNewGame(lstSoccerA[0].getName(), iScore2, iScore1, "L", iOT, "Quarter Finals");

                this.lblSemi1.Text = this.lblQtr1.Text;
            }

            else
            {
                lstSoccerB[1].addNewGame(lstSoccerA[0].getName(), iScore1, iScore2, "W", iOT, "Quarter Finals");
                lstSoccerB[0].addNewGame(lstSoccerB[1].getName(), iScore2, iScore1, "L", iOT, "Quarter Finals");
                this.lblSemi1.Text = this.lblQtr2.Text;

                //Do this for whole bracket, changing the label for each corresponding spot
            }

            iScore1 = oRand.Next(11);
            iScore2 = oRand.Next(11);
            iOT = 0;

            while (iScore1 == iScore2)
            {
                iScore1 = oRand.Next(20);
                iScore2 = oRand.Next(20);
                iOT++;
            }

            if (iScore1 > iScore2)
            {

                lstSoccerA[0].addNewGame(lstSoccerB[1].getName(), iScore1, iScore2, "W", iOT, "Quarter Finals");
                lstSoccerB[1].addNewGame(lstSoccerA[0].getName(), iScore2, iScore1, "L", iOT, "Quarter Finals");

                this.lblSemi1.Text = this.lblQtr1.Text;
            }

            else
            {
                lstSoccerB[1].addNewGame(lstSoccerA[0].getName(), iScore1, iScore2, "W", iOT, "Quarter Finals");
                lstSoccerB[0].addNewGame(lstSoccerB[1].getName(), iScore2, iScore1, "L", iOT, "Quarter Finals");
                this.lblSemi1.Text = this.lblQtr2.Text;

                //Simulate the finals

                iScore1 = oRand.Next(11);
                iScore2 = oRand.Next(11);
                iOT = 0;

                while (iScore1 == iScore2)
                {
                    iScore1 = oRand.Next(20);
                    iScore2 = oRand.Next(20);
                    iOT++;
                }

                if (iScore1 > iScore2)
                {

                    lstSoccerA[0].addNewGame(lstSoccerB[1].getName(), iScore1, iScore2, "W", iOT, "Finals");
                    lstSoccerB[1].addNewGame(lstSoccerA[0].getName(), iScore2, iScore1, "L", iOT, "Finals");

                    this.lblChampion.Text = this.lblSemi1.Text;
                }

                else
                {
                    lstSoccerB[1].addNewGame(lstSoccerA[0].getName(), iScore1, iScore2, "W", iOT, "Finals");
                    lstSoccerB[0].addNewGame(lstSoccerB[1].getName(), iScore2, iScore1, "L", iOT, "Finals");
                    //Display the champion
                    this.lblChampion.Text = this.lblSemi2.Text;


                }
            }
        }


        private void btnReset_Click(object sender, EventArgs e)
        {
            this.lblGroupA1.Text = "";
            this.lblGroupA2.Text = "";
            this.lblGroupB1.Text = "";
            this.lblGroupB2.Text = "";
            this.lblGroupC1.Text = "";
            this.lblGroupC2.Text = "";
            this.lblGroupD1.Text = "";
            this.lblGroupD2.Text = "";
            this.lblGroupE1.Text = "";
            this.lblGroupE2.Text = "";
            this.lblGroupF1.Text = "";
            this.lblGroupF2.Text = "";
            this.lblGroupG1.Text = "";
            this.lblGroupG2.Text = "";
            this.lblGroupH1.Text = "";
            this.lblGroupH2.Text = "";

            this.lblWinnerA1B2.Text = "";
            this.lblWinnerB1A2.Text = "";
            this.lblWinnerC1D2.Text = "";
            this.lblWinnerD1C2.Text = "";
            this.lblWinnerE1F2.Text = "";
            this.lblWinnerF1E2.Text = "";
            this.lblWinnerG1H2.Text = "";
            this.lblWinnerH1G2.Text = "";

            this.lblQtr1.Text = "";
            this.lblQtr2.Text = "";
            this.lblQtr3.Text = "";
            this.lblQtr4.Text = "";

            this.lblSemi1.Text = "";
            this.lblSemi2.Text = "";
        }

    }
} 
    
