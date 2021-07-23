using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quizzing

{
  
       
    public partial class GameSummary : Form
    {
        
        public static string GameSumA;
        public static string GameSumB;


        public GameSummary()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void GameSummary_Load(object sender, EventArgs e)
        {

            GameSumA = GamesumTeamA.Text;
            GameSumB = GamesumTeamA.Text;

            GamesumTeamA.Text = GameSetting.setvaluetext0;
            GamesumPlayer1.Text = GameSetting.setvaluetext1;
            GamesumPlayer2.Text = GameSetting.setvaluetext2;
            GamesumPlayer3.Text = GameSetting.setvaluetext3;
            GamesumPlayer4.Text = GameSetting.setvaluetext4;
            GamesumPlayer5.Text = GameSetting.setvaluetext5;
            GamesumPlayer6.Text = GameSetting.setvaluetext6;

            GamesumTeamB.Text = GameSetting.setvaluetext8;
            GamesumPlayer7.Text = GameSetting.setvaluetext9;
            GamesumPlayer8.Text = GameSetting.setvaluetext10;
            GamesumPlayer9.Text = GameSetting.setvaluetext11;
            GamesumPlayer10.Text = GameSetting.setvaluetext12;
            GamesumPlayer11.Text = GameSetting.setvaluetext13;
            GamesumPlayer12.Text = GameSetting.setvaluetext14;

            try
            {
                player1histOuput.Text = ScoreBoard.statoutputs[0];
                player1EngOutput.Text = ScoreBoard.statoutputs[1];
                player1ScienOutput.Text = ScoreBoard.statoutputs[2];
                player1mathOutput.Text = ScoreBoard.statoutputs[3];

                int totalcount1 = Convert.ToInt32(player1histOuput.Text);
                int totalcount2 = Convert.ToInt32(player1EngOutput.Text);
                int totalcount3 = Convert.ToInt32(player1ScienOutput.Text);
                int totalcoount4 = Convert.ToInt32(player1mathOutput.Text);

                int finaltotal = totalcount1 + totalcount2 + totalcount3 + totalcoount4;
                totaloutput1.Text = finaltotal.ToString();

                player2histoutput.Text = ScoreBoard.statoutputs[4];
                play2Engoutput.Text = ScoreBoard.statoutputs[5];
                player2scienoutput.Text = ScoreBoard.statoutputs[6];
                player2mathoutput.Text = ScoreBoard.statoutputs[7];

                int player2totalcount1 = Convert.ToInt32(player2histoutput.Text);
                int player2totalcount2 = Convert.ToInt32(play2Engoutput.Text);
                int player2totalcount3 = Convert.ToInt32(player2scienoutput.Text);
                int player2totalcount4 = Convert.ToInt32(player2mathoutput.Text);

                int finalplayer2Count = player2totalcount1 + player2totalcount2 + player2totalcount3 + player2totalcount4;
                Sumtotalcount2.Text = finalplayer2Count.ToString();

                player1hist.Text = ScoreBoard.statoutputs[8];
                player1Eng.Text = ScoreBoard.statoutputs[9];
                player1Scien.Text = ScoreBoard.statoutputs[10];
                player1Math.Text = ScoreBoard.statoutputs[11];

                int player3total1 = Convert.ToInt32(player1hist.Text);
                int player3total2 = Convert.ToInt32(player1Eng.Text);
                int player3total3 = Convert.ToInt32(player1Scien.Text);
                int player3total4 = Convert.ToInt32(player1Math.Text);

                int player3finaltotal = player3total1 + player3total2 + player3total3 + player3total4;
                GameSumtotal3.Text = player3finaltotal.ToString();

                player4Eng.Text = ScoreBoard.statoutputs[12];
                Player4History.Text = ScoreBoard.statoutputs[13];
                Player4Science.Text = ScoreBoard.statoutputs[14];
                Player4Math.Text = ScoreBoard.statoutputs[15];

                int player4total1 = Convert.ToInt32(player4Eng.Text);
                int player4total2 = Convert.ToInt32(Player4History.Text);
                int player4total3 = Convert.ToInt32(Player4Science.Text);
                int player4total4 = Convert.ToInt32(Player4Math.Text);

                int player4finaltotal = player4total1 + player4total2 + player4total3 + player4total4;
                player4totalcount.Text = player4finaltotal.ToString();

                Player5English.Text = ScoreBoard.statoutputs[16];
                Player5History.Text = ScoreBoard.statoutputs[17];
                Player5Science.Text = ScoreBoard.statoutputs[18];
                Player5Math.Text = ScoreBoard.statoutputs[19];

                int player5total1 = Convert.ToInt32(Player5English.Text);
                int player5total2 = Convert.ToInt32(Player5History.Text);
                int player5total3 = Convert.ToInt32(Player5Science.Text);
                int player5total4 = Convert.ToInt32(Player5Math.Text);

                int player5finaltotal = player5total1 + player5total2 + player5total3 + player5total4;
                player5totalCount.Text = player5finaltotal.ToString();

                Player6English.Text = ScoreBoard.statoutputs[20];
                player6hist.Text = ScoreBoard.statoutputs[21];
                player6Science.Text = ScoreBoard.statoutputs[22];
                player6Math.Text = ScoreBoard.statoutputs[23];

                int player6total1 = Convert.ToInt32(Player6English.Text);
                int player6total2 = Convert.ToInt32(player6hist.Text);
                int player6total3 = Convert.ToInt32(player6Science.Text);
                int player6total4 = Convert.ToInt32(player6Math.Text);

                int player6finaltotal = player6total1 + player6total2 + player6total3 + player6total4;
                player6totalcount.Text = player6finaltotal.ToString();

                player7English.Text = ScoreBoard.statoutputs[24];
                Player7History.Text = ScoreBoard.statoutputs[25];
                Player7Science.Text = ScoreBoard.statoutputs[26];
                Player7Math.Text = ScoreBoard.statoutputs[27];

                int Player7total1 = Convert.ToInt32(player7English.Text);
                int player7total2 = Convert.ToInt32(Player7History.Text);
                int player7total3 = Convert.ToInt32(Player7Science.Text);
                int player7total4 = Convert.ToInt32(Player7Math.Text);

                int player7finaltotal = Player7total1 + player7total2 + player7total3 + player7total4;
                Player7totalcount.Text = player7finaltotal.ToString();


                Player8English.Text = ScoreBoard.statoutputs[28];
                Player8History.Text = ScoreBoard.statoutputs[29];
                Player8Science.Text = ScoreBoard.statoutputs[30];
                Player8Math.Text = ScoreBoard.statoutputs[31];

                int Player8total1 = Convert.ToInt32(Player8English.Text);
                int player8total2 = Convert.ToInt32(Player8History.Text);
                int player8total3 = Convert.ToInt32(Player8Science.Text);
                int player8total4 = Convert.ToInt32(Player8Math.Text);

                int player8finaltotal = Player8total1 + player8total2 + player8total3 + player8total4;
                Player8totalcount.Text = player8finaltotal.ToString();


                player9English.Text = ScoreBoard.statoutputs[32];
                player9History.Text = ScoreBoard.statoutputs[33];
                player9Science.Text = ScoreBoard.statoutputs[34];
                player9Math.Text = ScoreBoard.statoutputs[35];

                int Player9total1 = Convert.ToInt32(player9English.Text);
                int player9total2 = Convert.ToInt32(player9History.Text);
                int player9total3 = Convert.ToInt32(player9Science.Text);
                int player9total4 = Convert.ToInt32(player9Math.Text);

                int player9finaltotal = Player9total1 + player9total2 + player9total3 + player9total4;
                Player9totalcount.Text = player9finaltotal.ToString();


                Player10English.Text = ScoreBoard.statoutputs[36];
                Player10History.Text = ScoreBoard.statoutputs[37];
                Player10Science.Text = ScoreBoard.statoutputs[38];
                Player10Math.Text = ScoreBoard.statoutputs[39];

                int Player10total1 = Convert.ToInt32(Player10English.Text);
                int player10total2 = Convert.ToInt32(Player10History.Text);
                int player10total3 = Convert.ToInt32(Player10Science.Text);
                int player10total4 = Convert.ToInt32(Player10Math.Text);

                int player10finaltotal = Player10total1 + player10total2 + player10total3 + player10total4;
                player10count.Text = player10finaltotal.ToString();

                player11English.Text = ScoreBoard.statoutputs[40];
                player11History.Text = ScoreBoard.statoutputs[41];
                player11Science.Text = ScoreBoard.statoutputs[42];
                Player11Math.Text = ScoreBoard.statoutputs[43];

                int Player11total1 = Convert.ToInt32(player11English.Text);
                int player11total2 = Convert.ToInt32(player11History.Text);
                int player11total3 = Convert.ToInt32(player11Science.Text);
                int player11total4 = Convert.ToInt32(Player11Math.Text);

                int player11finaltotal = Player11total1 + player11total2 + player11total3 + player11total4;
                player11totaloutput.Text = player11finaltotal.ToString();

                Player12English.Text = ScoreBoard.statoutputs[44];
                player12History.Text = ScoreBoard.statoutputs[45];
                player12Science.Text = ScoreBoard.statoutputs[46];
                player12Math.Text = ScoreBoard.statoutputs[47];

                int Player12total1 = Convert.ToInt32(Player12English.Text);
                int player12total2 = Convert.ToInt32(player12History.Text);
                int player12total3 = Convert.ToInt32(player12Science.Text);
                int player12total4 = Convert.ToInt32(player12Math.Text);

                int player12finaltotal = Player12total1 + player12total2 + player12total3 + player12total4;
                player12output.Text = player12finaltotal.ToString();
            }
            catch(FormatException)
            {
                 
                ScoreBoard reshow = new ScoreBoard();
                reshow.Show();
                MessageBox.Show("Please make sure you are inserting zero for players that didn't get any points for a particular category", "Players Performance", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
           














        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            GameSetting showWindow = new GameSetting();
            showWindow.Show();
        }

        private void player1Math_Click(object sender, EventArgs e)
        {

        }
    }
}
