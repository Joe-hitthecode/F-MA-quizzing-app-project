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
    
    public partial class ScoreBoard : Form

        
    {
        private int counter1;
        private int counter2;
        private int counter3;
        private int counter4;
        private int counter5;
        private int couter6;
        int EnglishLimitMax;
        int HistoryLimitMax;
        int ScienceLimitMax;
        int MathLimitMax;
        int totalCounter;
        public string subtext;
        public string playeroutputText;
        public string clone1;
        public string finalclone;
        public string clone2;
        public string clone2Output;
        public string clone3;
        public string clone3Ouput;
        public string CloneText;
        public string CloneTextOutput;
        public string CloneText2;
        public string CloneTextOuput1;
        public string cloneText3;
        public string CloneTextOput2;
        public string t2_clone1;
        public string t2_output;
        public string clone4;
        public string clone4Output;
        public string clone5;
        public string clone5output;
        public string t2_clone2;
        public string t2_output2;
        public string t2_clone3;
        public string t2_output3;
        public string t2_clone4;
        public string t2_output4;
        public static string[] statoutputs = { "ouput1", "output2", "output3", "output4", "outuput5", "output6", "output7", "output8", "output9", "output10",
                 "ouput11", "output12", "output13", "output14", "outuput15", "output16", "output17", "output18", "output19", "output20",
                 "ouput21", "output22", "output23", "output24", "outuput25", "output26", "output27", "output28", "output29", "output30",
                 "ouput31", "output32", "output33", "output334", "outuput35", "output36", "output37", "output38", "output39", "output40",
                  "ouput41", "output42", "output43", "output44", "outuput45", "output46", "output47", "output48",  
        };
        public static int total;
        public static int total2;
        public static  int total3;
        public static int total4;
        public static int total5;
        public static int total6;

            

        public ScoreBoard()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            GameSetting F4 = new GameSetting();
            F4.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            quizzing F5 = new quizzing();
            F5.Show();
        }

        private void Player1Ouput_Click(object sender, EventArgs e)
        {
            player1_window window = new player1_window();
      
     
            
           

        }

        private void ScoreBoard_Load(object sender, EventArgs e)
        {
            TeamA.Text = GameSetting.setvaluetext0;
            Player1Ouput.Text = GameSetting.setvaluetext1;
            Player2Output.Text = GameSetting.setvaluetext2;
            player3Output.Text = GameSetting.setvaluetext3;
            player4Output.Text = GameSetting.setvaluetext4;
            sub1Output.Text = GameSetting.setvaluetext5;
            sub2Output.Text = GameSetting.setvaluetext6;
            CoachNameOutput.Text = GameSetting.setvaluetext7;

            TeamB.Text = GameSetting.setvaluetext8;
            T2_Player1.Text = GameSetting.setvaluetext9;
            T2_Player2.Text = GameSetting.setvaluetext10;
            T2_Player3.Text = GameSetting.setvaluetext11;
            T2_Player4.Text = GameSetting.setvaluetext12;
            T2_Sub1.Text = GameSetting.setvaluetext13;
            T2_Sub2.Text = GameSetting.setvaluetext14;
            T2_CoachName.Text = GameSetting.setvaluetext15;

            PerformanceP1.Text = GameSetting.setvaluetext1;
            PerformanceP2.Text = GameSetting.setvaluetext2;
            PerformanceP3.Text = GameSetting.setvaluetext3;
            PerformanceP4.Text = GameSetting.setvaluetext4;
            PerformanceP5.Text = GameSetting.setvaluetext5;
            PerformanceP6.Text = GameSetting.setvaluetext6;

            PerformanceP7.Text = GameSetting.setvaluetext9;
            PerformanceP8.Text = GameSetting.setvaluetext10;
            PerformanceP9.Text = GameSetting.setvaluetext11;
            PerformanceP10.Text = GameSetting.setvaluetext12;
            PerformanceP11.Text = GameSetting.setvaluetext13;
            PerformanceP12.Text = GameSetting.setvaluetext14;


           







        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            counter1 += 10;
            ScoreA.Text = counter1.ToString();
            

            int  margin1 = Convert.ToInt32(ScoreA.Text);
            int margin2 = Convert.ToInt32(ScoreB.Text);
            if (margin1 >margin2)
            {
                int finalMargin1 = margin1 - margin2;
                Margin.Text = finalMargin1.ToString();
            }
            else if (margin1==margin2)
            {
                int MarginAll = 0;
                Margin.Text = MarginAll.ToString();


            }
            else if (margin2 > margin1)
            {
                int finalMargin2 = margin2 - margin1;
                Margin.Text = finalMargin2.ToString();

            }
            if (EnglishLimit.Text == "4" && HistoryLImit.Text == "4" && ScienceLimit.Text == "4" && MathLimit.Text == "4")

            {
                if (counter1 == 5 || counter1 == 10 || counter1 == 15|| counter1 == 20|| counter1 == 25||counter1==30||counter1==35||counter1==40||
                    counter1 == 45 || counter1 == 50 || counter1 == 55 || counter1 == 60 || counter1 == 65 || counter1 == 70 || counter1 == 75 || counter1 == 80||
                    counter1 == 85 || counter1 == 90 || counter1 == 95 || counter1 == 100 || counter1 == 105 || counter1 == 115|| counter1 == 120|| counter1 == 125||
                    counter1 == 130 || counter1 == 135 || counter1 == 140 || counter1 == 145|| counter1 == 150 || counter1 == 155 || counter1 == 160)
                {
                    halftimeWindow x = new halftimeWindow();
                    x.Show();
                }

            }
            if (EnglishLimit.Text == "8" && HistoryLImit.Text == "8" && ScienceLimit.Text == "8" && MathLimit.Text == "8")
            {
                if (counter1 == 5 || counter1 == 10 || counter1 == 15 || counter1 == 20 || counter1 == 25 || counter1 == 30 || counter1 == 35 || counter1 == 40 ||
                    counter1 == 45 || counter1 == 50 || counter1 == 55 || counter1 == 60 || counter1 == 65 || counter1 == 70 || counter1 == 75 || counter1 == 80 ||
                    counter1 == 85 || counter1 == 90 || counter1 == 95 || counter1 == 100 || counter1 == 105 || counter1 == 115 || counter1 == 120 || counter1 == 125 ||
                    counter1 == 130 || counter1 == 135 || counter1 == 140 || counter1 == 145 || counter1 == 150 || counter1 == 155 || counter1 == 160||counter1 == 165 || counter1 == 170 || counter1 == 175 || counter1 == 180 || counter1 == 190 || counter1 == 195 || counter1 == 200 || counter1 == 205 ||
                  counter1 == 210 || counter1 == 215 || counter1 == 220 || counter1 == 225 || counter1 == 230 || counter1 == 235 || counter1 == 240 || counter1 == 245 ||
                  counter1 == 250 || counter1 == 255 || counter1 == 260 || counter1 == 265 || counter1 == 270 || counter1 == 275 || counter1 == 280 || counter1 == 285 ||
                  counter1 == 290 || counter1 == 295 || counter1 == 300 || counter1 == 305 || counter1 == 310 || counter1 == 315 || counter1 == 320)
                {
                    GameOver x2 = new GameOver();
                    x2.Show();
                }
            }








        }

        private void button8_Click(object sender, EventArgs e)
        {
            counter2 += 10;
            ScoreB.Text = counter2.ToString();
        
            int margin1 = Convert.ToInt32(ScoreA.Text);
            int margin2 = Convert.ToInt32(ScoreB.Text);
            if (margin1 > margin2)
            {
                int finalMargin1 = margin1 - margin2;
                Margin.Text = finalMargin1.ToString();
            }
            else if (margin1 ==margin2 )
            {
                int MarginAll = 0;
                Margin.Text = MarginAll.ToString();


            }
            else if (margin2 > margin1)
            {
                int finalMargin2 = margin2 - margin1;
                Margin.Text = finalMargin2.ToString();

            }
            if (EnglishLimit.Text == "4" && HistoryLImit.Text == "4" && ScienceLimit.Text == "4" && MathLimit.Text == "4")
            {
                if (counter2 == 5 || counter2 == 10 || counter2 == 15 || counter2 == 20 || counter2 == 25 || counter2 == 30 || counter2 == 35 || counter2 == 40 ||
                  counter2 == 45 || counter2 == 50 || counter2 == 55 || counter2 == 60 || counter2 == 65 || counter2 == 70 || counter2 == 75 || counter2 == 80 ||
                  counter2 == 85 || counter2 == 90 || counter2 == 95 || counter2 == 100 || counter2 == 105 || counter2 == 115 || counter2 == 120 || counter2 == 125 ||
                  counter2 == 130 || counter2 == 135 || counter2 == 140 || counter2 == 145 || counter2 == 150 || counter2 == 155 || counter2 == 160)
                {
                    halftimeWindow x = new halftimeWindow();
                    x.Show();
                }
            }
            if (EnglishLimit.Text == "8" && HistoryLImit.Text == "8" && ScienceLimit.Text == "8" && MathLimit.Text == "8")
            {
                if (counter2 == 5 || counter2 == 10 || counter2 == 15 || counter2 == 20 || counter2 == 25 || counter2 == 30 || counter2 == 35 || counter2 == 40 ||
                  counter2 == 45 || counter2 == 50 || counter2 == 55 || counter2 == 60 || counter2 == 65 || counter2 == 70 || counter2 == 75 || counter2 == 80 ||
                  counter2 == 85 || counter2 == 90 || counter2 == 95 || counter2 == 100 || counter2 == 105 || counter2 == 115 || counter2 == 120 || counter2 == 125 ||
                  counter2 == 130 || counter2 == 135 || counter2 == 140 || counter2 == 145 || counter2 == 150 || counter2 == 155 || counter2 == 160||counter2 == 165 || counter2 == 170 || counter2 == 175 || counter2 == 180 || counter2 == 190 || counter2 == 195 || counter2 == 200 || counter2 == 205 ||
                  counter2 == 210 || counter2 == 215 || counter2 == 220 || counter2 == 225 || counter2 == 230 || counter2 == 235 || counter2 == 240 || counter2 == 245 ||
                  counter2 == 250 || counter2 == 255 || counter2 == 260 || counter2 == 265 || counter2 == 270 || counter2 == 275 || counter2 == 280 || counter2 == 285 ||
                  counter2 == 290 || counter2 == 295 || counter2 == 300 || counter2 == 305 || counter2 == 310 || counter2 == 315 || counter2 == 320)
                {
                    GameOver x2 = new GameOver();
                    x2.Show();
                }
            }






        }

        private void button7_Click(object sender, EventArgs e  )
        {

            counter2 += 5;
           
            ScoreB.Text = counter2.ToString();
            int margin1 = Convert.ToInt32(ScoreA.Text);
            int margin2 = Convert.ToInt32(ScoreB.Text);
            if (margin1 > margin2)
            {
                int finalMargin1 = margin1 - margin2;
                Margin.Text = finalMargin1.ToString();
            }
            else if (margin1 == margin2 )
            {
                int MarginAll = 0;
                Margin.Text = MarginAll.ToString();


            }
            else if (margin2 > margin1)
            {
                int finalMargin2 = margin2 - margin1;
                Margin.Text = finalMargin2.ToString();

            }
            if (EnglishLimit.Text == "4" && HistoryLImit.Text == "4" && ScienceLimit.Text == "4" && MathLimit.Text == "4")
            {
                if (counter2 == 5 || counter2 == 10 || counter2 == 15 || counter2 == 20 || counter2 == 25 || counter2 == 30 || counter2 == 35 || counter2 == 40 ||
                  counter2 == 45 || counter2 == 50 || counter2 == 55 || counter2 == 60 || counter2 == 65 || counter2 == 70 || counter2 == 75 || counter2 == 80 ||
                  counter2 == 85 || counter2 == 90 || counter2 == 95 || counter2 == 100 || counter2 == 105 || counter2 == 115 || counter2 == 120 || counter2 == 125 ||
                  counter2 == 130 || counter2 == 135 || counter2 == 140 || counter2 == 145 || counter2 == 150 || counter2 == 155 || counter2 == 160)
                {
                    halftimeWindow x = new halftimeWindow();
                    x.Show();
                }
            }
            if (EnglishLimit.Text == "8" && HistoryLImit.Text == "8" && ScienceLimit.Text == "8" && MathLimit.Text == "8")
            {
                if (counter2 == 165 || counter2 == 170 || counter2 == 175 || counter2 == 180 || counter2 == 190 || counter2 == 195 || counter2 == 200 || counter2 == 205 ||
                  counter2 == 210 || counter2 == 215 || counter2 == 220 || counter2 == 225 || counter2 == 230 || counter2 == 235 || counter2 == 240 || counter2 == 245 ||
                  counter2 == 250 || counter2 == 255 || counter2 == 260 || counter2 == 265 || counter2 == 270 || counter2 == 275 || counter2 == 280 || counter2 == 285 ||
                  counter2 == 290 || counter2 == 295 || counter2 == 300 || counter2 == 305 || counter2 == 310 || counter2 == 315 || counter2 == 320)
                {
                    GameOver x2 = new GameOver();
                    x2.Show();
                }
            }




        }


        private void button4_Click(object sender, EventArgs e)
        {
            counter1 += 5;
            
            ScoreA.Text = counter1.ToString();
            int margin1 = Convert.ToInt32(ScoreA.Text);
            int margin2 = Convert.ToInt32(ScoreB.Text);
            if (margin1 > margin2)
            {
                int finalMargin1 = margin1 - margin2;
                Margin.Text = finalMargin1.ToString();
            }
            else if (margin1==margin2 )
            {
                int MarginAll = 0;
                Margin.Text = MarginAll.ToString();


            }
            else if (margin2 > margin1)
            {
                int finalMargin2 = margin2 - margin1;
                Margin.Text = finalMargin2.ToString();

            }
            if (EnglishLimit.Text == "4" && HistoryLImit.Text == "4" && ScienceLimit.Text == "4" && MathLimit.Text == "4")

            {
                if (counter1 == 5 || counter1 == 10 || counter1 == 15 || counter1 == 20 || counter1 == 25 || counter1 == 30 || counter1 == 35 || counter1 == 40 ||
                    counter1 == 45 || counter1 == 50 || counter1 == 55 || counter1 == 60 || counter1 == 65 || counter1 == 70 || counter1 == 75 || counter1 == 80 ||
                    counter1 == 85 || counter1 == 90 || counter1 == 95 || counter1 == 100 || counter1 == 105 || counter1 == 115 || counter1 == 120 || counter1 == 125 ||
                    counter1 == 130 || counter1 == 135 || counter1 == 140 || counter1 == 145 || counter1 == 150 || counter1 == 155 || counter1 == 160)
                {
                    halftimeWindow x = new halftimeWindow();
                    x.Show();
                }

            }
            if (EnglishLimit.Text == "8" && HistoryLImit.Text == "8" && ScienceLimit.Text == "8" && MathLimit.Text == "8")
            {
                if (counter1 == 5 || counter1 == 10 || counter1 == 15 || counter1 == 20 || counter1 == 25 || counter1 == 30 || counter1 == 35 || counter1 == 40 ||
                    counter1 == 45 || counter1 == 50 || counter1 == 55 || counter1 == 60 || counter1 == 65 || counter1 == 70 || counter1 == 75 || counter1 == 80 ||
                    counter1 == 85 || counter1 == 90 || counter1 == 95 || counter1 == 100 || counter1 == 105 || counter1 == 115 || counter1 == 120 || counter1 == 125 ||
                    counter1 == 130 || counter1 == 135 || counter1 == 140 || counter1 == 145 || counter1 == 150 || counter1 == 155 || counter1 == 160||counter1 == 165 || counter1 == 170 || counter1 == 175 || counter1 == 180 || counter1 == 190 || counter1 == 195 || counter1 == 200 || counter1 == 205 ||
                  counter1 == 210 || counter1 == 215 || counter1 == 220 || counter1 == 225 || counter1 == 230 || counter1 == 235 || counter1 == 240 || counter1 == 245 ||
                  counter1 == 250 || counter1 == 255 || counter1 == 260 || counter1 == 265 || counter1 == 270 || counter1 == 275 || counter1 == 280 || counter1 == 285 ||
                  counter1 == 290 || counter1 == 295 || counter1 == 300 || counter1 == 305 || counter1 == 310 || counter1 == 315 || counter1 == 320)
                {
                    GameOver x2 = new GameOver();
                    x2.Show();
                }
            }


        }

        private void button6_Click(object sender, EventArgs e)
        {
            counter1 -= 10;
            totalCounter = counter3 + counter4 + counter5 + couter6;
            ScoreA.Text = counter1.ToString();
            int margin1 = Convert.ToInt32(ScoreA.Text);
            int margin2 = Convert.ToInt32(ScoreB.Text);
            if (margin1 > margin2)
            {
                int finalMargin1 = margin1 - margin2;
                Margin.Text = finalMargin1.ToString();
            }
            else if (margin1 == margin2)
            {
                int MarginAll = 0;
                Margin.Text = MarginAll.ToString();


            }
            else if (margin2 > margin1)
            {
                int finalMargin2 = margin2 - margin1;
                Margin.Text = finalMargin2.ToString();

            }
            if (EnglishLimit.Text == "4" && HistoryLImit.Text == "4" && ScienceLimit.Text == "4" && MathLimit.Text == "4")

            {
                if (counter1 == 5 || counter1 == 10 || counter1 == 15 || counter1 == 20 || counter1 == 25 || counter1 == 30 || counter1 == 35 || counter1 == 40 ||
                    counter1 == 45 || counter1 == 50 || counter1 == 55 || counter1 == 60 || counter1 == 65 || counter1 == 70 || counter1 == 75 || counter1 == 80 ||
                    counter1 == 85 || counter1 == 90 || counter1 == 95 || counter1 == 100 || counter1 == 105 || counter1 == 115 || counter1 == 120 || counter1 == 125 ||
                    counter1 == 130 || counter1 == 135 || counter1 == 140 || counter1 == 145 || counter1 == 150 || counter1 == 155 || counter1 == 160)
                {
                    halftimeWindow x = new halftimeWindow();
                    x.Show();
                }

            }
            if (EnglishLimit.Text == "8" && HistoryLImit.Text == "8" && ScienceLimit.Text == "8" && MathLimit.Text == "8")
            {
                if (counter1 == 5 || counter1 == 10 || counter1 == 15 || counter1 == 20 || counter1 == 25 || counter1 == 30 || counter1 == 35 || counter1 == 40 ||
                    counter1 == 45 || counter1 == 50 || counter1 == 55 || counter1 == 60 || counter1 == 65 || counter1 == 70 || counter1 == 75 || counter1 == 80 ||
                    counter1 == 85 || counter1 == 90 || counter1 == 95 || counter1 == 100 || counter1 == 105 || counter1 == 115 || counter1 == 120 || counter1 == 125 ||
                    counter1 == 130 || counter1 == 135 || counter1 == 140 || counter1 == 145 || counter1 == 150 || counter1 == 155 || counter1 == 160||counter1 == 165 || counter1 == 170 || counter1 == 175 || counter1 == 180 || counter1 == 190 || counter1 == 195 || counter1 == 200 || counter1 == 205 ||
                  counter1 == 210 || counter1 == 215 || counter1 == 220 || counter1 == 225 || counter1 == 230 || counter1 == 235 || counter1 == 240 || counter1 == 245 ||
                  counter1 == 250 || counter1 == 255 || counter1 == 260 || counter1 == 265 || counter1 == 270 || counter1 == 275 || counter1 == 280 || counter1 == 285 ||
                  counter1 == 290 || counter1 == 295 || counter1 == 300 || counter1 == 305 || counter1 == 310 || counter1 == 315 || counter1 == 320)
                {
                    GameOver x2 = new GameOver();
                    x2.Show();
                }
            }




        }

        private void button5_Click(object sender, EventArgs e)
        {
            counter1 -= 5;
            totalCounter = counter3 + counter4 + counter5 + couter6;
            ScoreA.Text = counter1.ToString();
            
            int margin1 = Convert.ToInt32(ScoreA.Text);
            int margin2 = Convert.ToInt32(ScoreB.Text);
            if (margin1 > margin2)
            {
                int finalMargin1 = margin1 - margin2;
                Margin.Text = finalMargin1.ToString();
            }
            else if (margin1==margin2)
            {
                int MarginAll = 0;
                Margin.Text = MarginAll.ToString();


            }
            if (EnglishLimit.Text == "4" && HistoryLImit.Text == "4" && ScienceLimit.Text == "4" && MathLimit.Text == "4")

            {
                if (counter1 == 5 || counter1 == 10 || counter1 == 15 || counter1 == 20 || counter1 == 25 || counter1 == 30 || counter1 == 35 || counter1 == 40 ||
                    counter1 == 45 || counter1 == 50 || counter1 == 55 || counter1 == 60 || counter1 == 65 || counter1 == 70 || counter1 == 75 || counter1 == 80 ||
                    counter1 == 85 || counter1 == 90 || counter1 == 95 || counter1 == 100 || counter1 == 105 || counter1 == 115 || counter1 == 120 || counter1 == 125 ||
                    counter1 == 130 || counter1 == 135 || counter1 == 140 || counter1 == 145 || counter1 == 150 || counter1 == 155 || counter1 == 160)
                {
                    halftimeWindow x = new halftimeWindow();
                    x.Show();
                }

            }
            if (EnglishLimit.Text == "8" && HistoryLImit.Text == "8" && ScienceLimit.Text == "8" && MathLimit.Text == "8")
            {
                if (counter1 == 5 || counter1 == 10 || counter1 == 15 || counter1 == 20 || counter1 == 25 || counter1 == 30 || counter1 == 35 || counter1 == 40 ||
                    counter1 == 45 || counter1 == 50 || counter1 == 55 || counter1 == 60 || counter1 == 65 || counter1 == 70 || counter1 == 75 || counter1 == 80 ||
                    counter1 == 85 || counter1 == 90 || counter1 == 95 || counter1 == 100 || counter1 == 105 || counter1 == 115 || counter1 == 120 || counter1 == 125 ||
                    counter1 == 130 || counter1 == 135 || counter1 == 140 || counter1 == 145 || counter1 == 150 || counter1 == 155 || counter1 == 160||counter1 == 165 || counter1 == 170 || counter1 == 175 || counter1 == 180 || counter1 == 190 || counter1 == 195 || counter1 == 200 || counter1 == 205 ||
                  counter1 == 210 || counter1 == 215 || counter1 == 220 || counter1 == 225 || counter1 == 230 || counter1 == 235 || counter1 == 240 || counter1 == 245 ||
                  counter1 == 250 || counter1 == 255 || counter1 == 260 || counter1 == 265 || counter1 == 270 || counter1 == 275 || counter1 == 280 || counter1 == 285 ||
                  counter1 == 290 || counter1 == 295 || counter1 == 300 || counter1 == 305 || counter1 == 310 || counter1 == 315 || counter1 == 320)
                {
                    GameOver x2 = new GameOver();
                    x2.Show();
                }
            }


        }

        private void button9_Click(object sender, EventArgs e)
        {
            counter2 -= 10;
            totalCounter = counter3 + counter4 + counter5 + couter6;
            ScoreB.Text = counter2.ToString();
            int margin1 = Convert.ToInt32(ScoreA.Text);
            int margin2 = Convert.ToInt32(ScoreB.Text);
            if (margin1 > margin2)
            {
                int finalMargin1 = margin1 - margin2;
                Margin.Text = finalMargin1.ToString();
            }
            else if (margin1 ==margin2 )
            {
                int MarginAll = 0;
                Margin.Text = MarginAll.ToString();


            }
            else if (margin2 > margin1)
            {
                int finalMargin2 = margin2 - margin1;
                Margin.Text = finalMargin2.ToString();

            }
            if (EnglishLimit.Text == "4" && HistoryLImit.Text == "4" && ScienceLimit.Text == "4" && MathLimit.Text == "4")

            {
                if (counter2 == 5 || counter2 == 10 || counter2 == 15 || counter2 == 20 || counter2 == 25 || counter2 == 30 || counter2 == 35 || counter2 == 40 ||
                    counter2 == 45 || counter2 == 50 || counter2 == 55 || counter2 == 60 || counter2 == 65 || counter2 == 70 || counter2 == 75 || counter2 == 80 ||
                    counter2 == 85 || counter2 == 90 || counter2 == 95 || counter2 == 100 || counter2 == 105 || counter2 == 115 || counter2 == 120 || counter2 == 125 ||
                    counter2 == 130 || counter2 == 135 || counter2 == 140 || counter2 == 145 || counter2 == 150 || counter2 == 155 || counter2 == 160)
                {
                    halftimeWindow x = new halftimeWindow();
                    x.Show();
                }

            }
            if (EnglishLimit.Text == "8" && HistoryLImit.Text == "8" && ScienceLimit.Text == "8" && MathLimit.Text == "8")
            {
                if (counter2 == 165 || counter2 == 170 || counter2 == 175 || counter2 == 180 || counter2 == 190 || counter2 == 195 || counter2 == 200 || counter2 == 205 ||
                  counter2 == 210 || counter2 == 215 || counter2 == 220 || counter2 == 225 || counter2 == 230 || counter2 == 235 || counter2 == 240 || counter2 == 245 ||
                  counter2 == 250 || counter2 == 255 || counter2 == 260 || counter2 == 265 || counter2 == 270 || counter2 == 275 || counter2 == 280 || counter2 == 285 ||
                  counter2 == 290 || counter2 == 295 || counter2 == 300 || counter2 == 305 || counter2 == 310 || counter2 == 315 || counter2 == 320)
                {
                    GameOver x2 = new GameOver();
                    x2.Show();
                }
            }



        }

        private void button10_Click(object sender, EventArgs e)
        {
            counter2 -= 5;
            totalCounter = counter3 + counter4 + counter5 + couter6;
            ScoreB.Text = counter2.ToString();
            int margin1 = Convert.ToInt32(ScoreA.Text);
            int margin2 = Convert.ToInt32(ScoreB.Text);
            if (margin1 > margin2)
            {
                int finalMargin1 = margin1 - margin2;
                Margin.Text = finalMargin1.ToString();
            }
            else if (margin1 == margin2)
            {
                int MarginAll = 0;
                Margin.Text = MarginAll.ToString();


            }
            else if (margin2 > margin1)
            {
                int finalMargin2 = margin2 - margin1;
                Margin.Text = finalMargin2.ToString();

            }
            if (EnglishLimit.Text == "4" && HistoryLImit.Text == "4" && ScienceLimit.Text == "4" && MathLimit.Text == "4")
            {
                if (counter2 == 5 || counter2 == 10 || counter2 == 15 || counter2 == 20 || counter2 == 25 || counter2 == 30 || counter2 == 35 || counter2 == 40 ||
                  counter2 == 45 || counter2 == 50 || counter2 == 55 || counter2 == 60 || counter2 == 65 || counter2 == 70 || counter2 == 75 || counter2 == 80 ||
                  counter2 == 85 || counter2 == 90 || counter2 == 95 || counter2 == 100 || counter2 == 105 || counter2 == 115 || counter2 == 120 || counter2 == 125 ||
                  counter2 == 130 || counter2 == 135 || counter2 == 140 || counter2 == 145 || counter2 == 150 || counter2 == 155 || counter2 == 160)
                {
                    halftimeWindow x = new halftimeWindow();
                    x.Show();
                }
            }
            if (EnglishLimit.Text == "8" && HistoryLImit.Text == "8" && ScienceLimit.Text == "8" && MathLimit.Text == "8")
            {
                if (counter2 == 165 || counter2 == 170 || counter2 == 175 || counter2 == 180 || counter2 == 190 || counter2 == 195 || counter2 == 200 || counter2 == 205 ||
                  counter2 == 210 || counter2 == 215 || counter2 == 220 || counter2 == 225 || counter2 == 230 || counter2 == 235 || counter2 == 240 || counter2 == 245 ||
                  counter2 == 250 || counter2 == 255 || counter2 == 260 || counter2 == 265 || counter2 == 270 || counter2 == 275 || counter2 == 280 || counter2 == 285 ||
                  counter2 == 290 || counter2 == 295 || counter2 == 300 || counter2 == 305 || counter2 == 310 || counter2 == 315 || counter2 == 320)
                {
                    GameOver x2 = new GameOver();
                    x2.Show();
                }
            }



        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            this.Hide();
            GameSetting F4 = new GameSetting();
            F4.Show();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            
        }

        private void ScoreA_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            counter1 += 10;
            totalCounter = counter3 + counter4 + counter5 + couter6;
            ScoreA.Text = counter1.ToString();

            int margin1 = Convert.ToInt32(ScoreA.Text);
            int margin2 = Convert.ToInt32(ScoreB.Text);
            if (margin1 > margin2)
            {
                int finalMargin1 = margin1 - margin2;
                Margin.Text = finalMargin1.ToString();
            }
            else if (margin1 == margin2)
            {
                int MarginAll = 0;
                Margin.Text = MarginAll.ToString();


            }
            else if (margin2 > margin1)
            {
                int finalMargin2 = margin2 - margin1;
                Margin.Text = finalMargin2.ToString();

            }
            if (EnglishLimit.Text == "4" && HistoryLImit.Text == "4" && ScienceLimit.Text == "4" && MathLimit.Text == "4")

            {
                if (counter1 == 0 || counter1 == 5 || counter1 == 10 || counter1 == 15 || counter1 == 20 || counter1 == 25 || counter1 == 30 || counter1 == 35 || counter1 == 40 ||
                    counter1 == 45 || counter1 == 50 || counter1 == 55 || counter1 == 60 || counter1 == 65 || counter1 == 70 || counter1 == 75 || counter1 == 80 ||
                    counter1 == 85 || counter1 == 90 || counter1 == 95 || counter1 == 100 || counter1 == 105 || counter1 == 115 || counter1 == 120 || counter1 == 125 ||
                    counter1 == 130 || counter1 == 135 || counter1 == 140 || counter1 == 145 || counter1 == 150 || counter1 == 155 || counter1 == 160 || counter1 == 0 || counter1 == -5 || counter1 == -10 || counter1 == -15 || counter1 == -20 || counter1 == -25 || counter1 == -30 || counter1 == -35 || counter1 == -40 ||
                    counter1 == -45 || counter1 == -50 || counter1 == -55 || counter1 == -60 || counter1 == -65 || counter1 == -70 || counter1 == -75 || counter1 == -80 ||
                    counter1 == -85 || counter1 == -90 || counter1 == -95 || counter1 == -100 || counter1 == -105 || counter1 == -115 || counter1 == -120 || counter1 == -125 ||
                    counter1 == -130 || counter1 == -135 || counter1 == -140 || counter1 == -145 || counter1 == -150 || counter1 == -155 || counter1 == -160)
                {
                    halftimeWindow x = new halftimeWindow();
                    x.Show();
                }

            }
            if (EnglishLimit.Text == "8" && HistoryLImit.Text == "8" && ScienceLimit.Text == "8" && MathLimit.Text == "8")
            {
                if (counter1 == 0 || counter1 == 5 || counter1 == 10 || counter1 == 15 || counter1 == 20 || counter1 == 25 || counter1 == 30 || counter1 == 35 || counter1 == 40 ||
                    counter1 == 45 || counter1 == 50 || counter1 == 55 || counter1 == 60 || counter1 == 65 || counter1 == 70 || counter1 == 75 || counter1 == 80 ||
                    counter1 == 85 || counter1 == 90 || counter1 == 95 || counter1 == 100 || counter1 == 105 || counter1 == 115 || counter1 == 120 || counter1 == 125 ||
                    counter1 == 130 || counter1 == 135 || counter1 == 140 || counter1 == 145 || counter1 == 150 || counter1 == 155 || counter1 == 160 || counter1 == 165 || counter1 == 170 || counter1 == 175 || counter1 == 180 || counter1 == 190 || counter1 == 195 || counter1 == 200 || counter1 == 205 ||
                  counter1 == 210 || counter1 == 215 || counter1 == 220 || counter1 == 225 || counter1 == 230 || counter1 == 235 || counter1 == 240 || counter1 == 245 ||
                  counter1 == 250 || counter1 == 255 || counter1 == 260 || counter1 == 265 || counter1 == 270 || counter1 == 275 || counter1 == 280 || counter1 == 285 ||
                  counter1 == 290 || counter1 == 295 || counter1 == 300 || counter1 == 305 || counter1 == 310 || counter1 == 315 || counter1 == 320 || counter1 == 0 || counter1 == -5 || counter1 == -10 || counter1 == -15 || counter1 == -20 || counter1 == -25 || counter1 == -30 || counter1 == -35 || counter1 == -40 ||
                    counter1 == -45 || counter1 == -50 || counter1 == -55 || counter1 == -60 || counter1 == -65 || counter1 == -70 || counter1 == -75 || counter1 == -80 ||
                    counter1 == -85 || counter1 == -90 || counter1 == -95 || counter1 == -100 || counter1 == -105 || counter1 == -115 || counter1 == -120 || counter1 == -125 ||
                    counter1 == -130 || counter1 == -135 || counter1 == -140 || counter1 == -145 || counter1 == -150 || counter1 == -155 || counter1 == -160 || counter1 == -165 || counter1 == -170 || counter1 == -175 || counter1 == -180 || counter1 == -190 || counter1 == -195 || counter1 == -200 || counter1 == -205 ||
                  counter1 == -210 || counter1 == -215 || counter1 == -220 || counter1 == -225 || counter1 == -230 || counter1 == -235 || counter1 == -240 || counter1 == -245 ||
                  counter1 == -250 || counter1 == -255 || counter1 == -260 || counter1 == -265 || counter1 == -270 || counter1 == -275 || counter1 == -280 || counter1 == -285 ||
                  counter1 == -290 || counter1 == -295 || counter1 == -300 || counter1 == -305 || counter1 == -310 || counter1 == -315 || counter1 == -320)
                {
                    GameOver x2 = new GameOver();
                    x2.Show();
                }
            }




        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            counter2 += 10;
            ScoreB.Text = counter2.ToString();
            totalCounter = counter3 + counter4 + counter5 + couter6;
            int margin1 = Convert.ToInt32(ScoreA.Text);
            int margin2 = Convert.ToInt32(ScoreB.Text);
            if (margin1 > margin2)
            {
                int finalMargin1 = margin1 - margin2;
                Margin.Text = finalMargin1.ToString();
            }
            else if (margin1 == margin2)
            {
                int MarginAll = 0;
                Margin.Text = MarginAll.ToString();


            }
            else if (margin2 > margin1)
            {
                int finalMargin2 = margin2 - margin1;
                Margin.Text = finalMargin2.ToString();

            }
            if (EnglishLimit.Text == "4" && HistoryLImit.Text == "4" && ScienceLimit.Text == "4" && MathLimit.Text == "4")
            {
                if (counter2 == 0 || counter2 == 5 || counter2 == 10 || counter2 == 15 || counter2 == 20 || counter2 == 25 || counter2 == 30 || counter2 == 35 || counter2 == 40 ||
                  counter2 == 45 || counter2 == 50 || counter2 == 55 || counter2 == 60 || counter2 == 65 || counter2 == 70 || counter2 == 75 || counter2 == 80 ||
                  counter2 == 85 || counter2 == 90 || counter2 == 95 || counter2 == 100 || counter2 == 105 || counter2 == 115 || counter2 == 120 || counter2 == 125 ||
                  counter2 == 130 || counter2 == 135 || counter2 == 140 || counter2 == 145 || counter2 == 150 || counter2 == 155 || counter2 == 160 || counter2 == 0 || counter2 == -5 || counter2 == -10 || counter2 == -15 || counter2 == -20 || counter2 == -25 || counter2 == -30 || counter2 == -35 || counter2 == -40 ||
                  counter2 == -45 || counter2 == -50 || counter2 == -55 || counter2 == -60 || counter2 == -65 || counter2 == -70 || counter2 == -75 || counter2 == -80 ||
                  counter2 == -85 || counter2 == -90 || counter2 == -95 || counter2 == -100 || counter2 == -105 || counter2 == -115 || counter2 == -120 || counter2 == -125 ||
                  counter2 == -130 || counter2 == -135 || counter2 == -140 || counter2 == -145 || counter2 == -150 || counter2 == -155 || counter2 == -160)
                {
                    halftimeWindow x = new halftimeWindow();
                    x.Show();
                }
            }
            if (EnglishLimit.Text == "8" && HistoryLImit.Text == "8" && ScienceLimit.Text == "8" && MathLimit.Text == "8")
            {
                if (counter2 == 0 || counter2 == 5 || counter2 == 10 || counter2 == 15 || counter2 == 20 || counter2 == 25 || counter2 == 30 || counter2 == 35 || counter2 == 40 ||
                  counter2 == 45 || counter2 == 50 || counter2 == 55 || counter2 == 60 || counter2 == 65 || counter2 == 70 || counter2 == 75 || counter2 == 80 ||
                  counter2 == 85 || counter2 == 90 || counter2 == 95 || counter2 == 100 || counter2 == 105 || counter2 == 115 || counter2 == 120 || counter2 == 125 ||
                  counter2 == 130 || counter2 == 135 || counter2 == 140 || counter2 == 145 || counter2 == 150 || counter2 == 155 || counter2 == 160 || counter2 == 165 || counter2 == 170 || counter2 == 175 || counter2 == 180 || counter2 == 190 || counter2 == 195 || counter2 == 200 || counter2 == 205 ||
                  counter2 == 210 || counter2 == 215 || counter2 == 220 || counter2 == 225 || counter2 == 230 || counter2 == 235 || counter2 == 240 || counter2 == 245 ||
                  counter2 == 250 || counter2 == 255 || counter2 == 260 || counter2 == 265 || counter2 == 270 || counter2 == 275 || counter2 == 280 || counter2 == 285 ||
                  counter2 == 290 || counter2 == 295 || counter2 == 300 || counter2 == 305 || counter2 == 310 || counter2 == 315 || counter2 == 320 ||
                  counter2 == 0 || counter2 == -5 || counter2 == -10 || counter2 == -15 || counter2 == -20 || counter2 == -25 || counter2 == -30 || counter2 == -35 || counter2 == -40 ||
                  counter2 == -45 || counter2 == -50 || counter2 == -55 || counter2 == -60 || counter2 == -65 || counter2 == -70 || counter2 == -75 || counter2 == -80 ||
                  counter2 == -85 || counter2 == -90 || counter2 == -95 || counter2 == -100 || counter2 == -105 || counter2 == -115 || counter2 == -120 || counter2 == -125 ||
                  counter2 == -130 || counter2 == -135 || counter2 == -140 || counter2 == -145 || counter2 == -150 || counter2 == -155 || counter2 == -160 || counter2 == -165 || counter2 == -170 || counter2 == -175 || counter2 == -180 || counter2 == -190 || counter2 == -195 || counter2 == -200 || counter2 == -205 ||
                  counter2 == -210 || counter2 == -215 || counter2 == -220 || counter2 == -225 || counter2 == -230 || counter2 == -235 || counter2 == -240 || counter2 == -245 ||
                  counter2 == -250 || counter2 == -255 || counter2 == -260 || counter2 == -265 || counter2 == -270 || counter2 == -275 || counter2 == -280 || counter2 == -285 ||
                  counter2 == -290 || counter2 == -295 || counter2 == -300 || counter2 == -305 || counter2 == -310 || counter2 == -315 || counter2 == -320)
                {
                    GameOver x2 = new GameOver();
                    x2.Show();
                }
            }




        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {

            counter1 += 5;
            totalCounter = counter3 + counter4 + counter5 + couter6;
            ScoreA.Text = counter1.ToString();
            int margin1 = Convert.ToInt32(ScoreA.Text);
            int margin2 = Convert.ToInt32(ScoreB.Text);
            if (margin1 > margin2)
            {
                int finalMargin1 = margin1 - margin2;
                Margin.Text = finalMargin1.ToString();
            }
            else if (margin1 == margin2)
            {
                int MarginAll = 0;
                Margin.Text = MarginAll.ToString();


            }
            else if (margin2 > margin1)
            {
                int finalMargin2 = margin2 - margin1;
                Margin.Text = finalMargin2.ToString();

            }
            if (EnglishLimit.Text == "4" && HistoryLImit.Text == "4" && ScienceLimit.Text == "4" && MathLimit.Text == "4")

            {
                if (counter1==0||counter1 == 5 || counter1 == 10 || counter1 == 15 || counter1 == 20 || counter1 == 25 || counter1 == 30 || counter1 == 35 || counter1 == 40 ||
                    counter1 == 45 || counter1 == 50 || counter1 == 55 || counter1 == 60 || counter1 == 65 || counter1 == 70 || counter1 == 75 || counter1 == 80 ||
                    counter1 == 85 || counter1 == 90 || counter1 == 95 || counter1 == 100 || counter1 == 105 || counter1 == 115 || counter1 == 120 || counter1 == 125 ||
                    counter1 == 130 || counter1 == 135 || counter1 == 140 || counter1 == 145 || counter1 == 150 || counter1 == 155 || counter1 == 160||counter1 == 0 || counter1 == -5 || counter1 == -10 || counter1 == -15 || counter1 == -20 || counter1 == -25 || counter1 == -30 || counter1 == -35 || counter1 == -40 ||
                    counter1 == -45 || counter1 == -50 || counter1 == -55 || counter1 == -60 || counter1 == -65 || counter1 == -70 || counter1 == -75 || counter1 == -80 ||
                    counter1 == -85 || counter1 == -90 || counter1 == -95 || counter1 == -100 || counter1 == -105 || counter1 == -115 || counter1 == -120 || counter1 == -125 ||
                    counter1 == -130 || counter1 == -135 || counter1 == -140 || counter1 == -145 || counter1 == -150 || counter1 == -155 || counter1 == -160)
                {
                    halftimeWindow x = new halftimeWindow();
                    x.Show();
                }

            }
            if (EnglishLimit.Text == "8" && HistoryLImit.Text == "8" && ScienceLimit.Text == "8" && MathLimit.Text == "8")
            {
                if (counter1==0||counter1 == 5 || counter1 == 10 || counter1 == 15 || counter1 == 20 || counter1 == 25 || counter1 == 30 || counter1 == 35 || counter1 == 40 ||
                    counter1 == 45 || counter1 == 50 || counter1 == 55 || counter1 == 60 || counter1 == 65 || counter1 == 70 || counter1 == 75 || counter1 == 80 ||
                    counter1 == 85 || counter1 == 90 || counter1 == 95 || counter1 == 100 || counter1 == 105 || counter1 == 115 || counter1 == 120 || counter1 == 125 ||
                    counter1 == 130 || counter1 == 135 || counter1 == 140 || counter1 == 145 || counter1 == 150 || counter1 == 155 || counter1 == 160||counter1 == 165 || counter1 == 170 || counter1 == 175 || counter1 == 180 || counter1 == 190 || counter1 == 195 || counter1 == 200 || counter1 == 205 ||
                  counter1 == 210 || counter1 == 215 || counter1 == 220 || counter1 == 225 || counter1 == 230 || counter1 == 235 || counter1 == 240 || counter1 == 245 ||
                  counter1 == 250 || counter1 == 255 || counter1 == 260 || counter1 == 265 || counter1 == 270 || counter1 == 275 || counter1 == 280 || counter1 == 285 ||
                  counter1 == 290 || counter1 == 295 || counter1 == 300 || counter1 == 305 || counter1 == 310 || counter1 == 315 || counter1 == 320||counter1 == 0 || counter1 == -5 || counter1 == -10 || counter1 == -15 || counter1 == -20 || counter1 == -25 || counter1 == -30 || counter1 == -35 || counter1 == -40 ||
                    counter1 == -45 || counter1 == -50 || counter1 == -55 || counter1 == -60 || counter1 == -65 || counter1 == -70 || counter1 == -75 || counter1 == -80 ||
                    counter1 == -85 || counter1 == -90 || counter1 == -95 || counter1 == -100 || counter1 == -105 || counter1 == -115 || counter1 == -120 || counter1 == -125 ||
                    counter1 == -130 || counter1 == -135 || counter1 == -140 || counter1 == -145 || counter1 == -150 || counter1 == -155 || counter1 == -160 || counter1 == -165 || counter1 == -170 || counter1 == -175 || counter1 == -180 || counter1 == -190 || counter1 == -195 || counter1 == -200 || counter1 == -205 ||
                  counter1 == -210 || counter1 == -215 || counter1 == -220 || counter1 == -225 || counter1 == -230 || counter1 == -235 || counter1 == -240 || counter1 == -245 ||
                  counter1 == -250 || counter1 == -255 || counter1 == -260 || counter1 == -265 || counter1 ==- 270 || counter1 == -275 || counter1 == -280 || counter1 == -285 ||
                  counter1 == -290 || counter1 == -295 || counter1 == -300 || counter1 == -305 || counter1 == -310 || counter1 == -315 || counter1 == -320)
                {
                    GameOver x2 = new GameOver();
                    x2.Show();
                }
            }


        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {

            counter2 += 5;
            totalCounter = counter3 + counter4 + counter5 + couter6;
            ScoreB.Text = counter2.ToString();
            int margin1 = Convert.ToInt32(ScoreA.Text);
            int margin2 = Convert.ToInt32(ScoreB.Text);
            if (margin1 > margin2)
            {
                int finalMargin1 = margin1 - margin2;
                Margin.Text = finalMargin1.ToString();
            }
            else if (margin1 == margin2)
            {
                int MarginAll = 0;
                Margin.Text = MarginAll.ToString();


            }
            else if (margin2 > margin1)
            {
                int finalMargin2 = margin2 - margin1;
                Margin.Text = finalMargin2.ToString();

            }
            if (EnglishLimit.Text == "4" && HistoryLImit.Text == "4" && ScienceLimit.Text == "4" && MathLimit.Text == "4")
            {
                if (counter2==0||counter2 == 5 || counter2 == 10 || counter2 == 15 || counter2 == 20 || counter2 == 25 || counter2 == 30 || counter2 == 35 || counter2 == 40 ||
                  counter2 == 45 || counter2 == 50 || counter2 == 55 || counter2 == 60 || counter2 == 65 || counter2 == 70 || counter2 == 75 || counter2 == 80 ||
                  counter2 == 85 || counter2 == 90 || counter2 == 95 || counter2 == 100 || counter2 == 105 || counter2 == 115 || counter2 == 120 || counter2 == 125 ||
                  counter2 == 130 || counter2 == 135 || counter2 == 140 || counter2 == 145 || counter2 == 150 || counter2 == 155 || counter2 == 160||counter2 == 0 || counter2 == -5 || counter2 == -10 || counter2 == -15 || counter2 == -20 || counter2 == -25 || counter2 == -30 || counter2 == -35 || counter2 == -40 ||
                  counter2 == -45 || counter2 == -50 || counter2 == -55 || counter2 == -60 || counter2 == -65 || counter2 == -70 || counter2 == -75 || counter2 == -80 ||
                  counter2 == -85 || counter2 == -90 || counter2 == -95 || counter2 == -100 || counter2 == -105 || counter2 == -115 || counter2 == -120 || counter2 == -125 ||
                  counter2 == -130 || counter2 == -135 || counter2 == -140 || counter2 == -145 || counter2 == -150 || counter2 == -155 || counter2 == -160)
                {
                    halftimeWindow x = new halftimeWindow();
                    x.Show();
                }
            }
            if (EnglishLimit.Text == "8" && HistoryLImit.Text == "8" && ScienceLimit.Text == "8" && MathLimit.Text == "8")
            {
                if (counter2==0||counter2 == 5 || counter2 == 10 || counter2 == 15 || counter2 == 20 || counter2 == 25 || counter2 == 30 || counter2 == 35 || counter2 == 40 ||
                  counter2 == 45 || counter2 == 50 || counter2 == 55 || counter2 == 60 || counter2 == 65 || counter2 == 70 || counter2 == 75 || counter2 == 80 ||
                  counter2 == 85 || counter2 == 90 || counter2 == 95 || counter2 == 100 || counter2 == 105 || counter2 == 115 || counter2 == 120 || counter2 == 125 ||
                  counter2 == 130 || counter2 == 135 || counter2 == 140 || counter2 == 145 || counter2 == 150 || counter2 == 155 || counter2 == 160||counter2 == 165 || counter2 == 170 || counter2 == 175 || counter2 == 180 || counter2 == 190 || counter2 == 195 || counter2 == 200 || counter2 == 205 ||
                  counter2 == 210 || counter2 == 215 || counter2 == 220 || counter2 == 225 || counter2 == 230 || counter2 == 235 || counter2 == 240 || counter2 == 245 ||
                  counter2 == 250 || counter2 == 255 || counter2 == 260 || counter2 == 265 || counter2 == 270 || counter2 == 275 || counter2 == 280 || counter2 == 285 ||
                  counter2 == 290 || counter2 == 295 || counter2 == 300 || counter2 == 305 || counter2 == 310 || counter2 == 315 || counter2 == 320||
                  counter2 == 0 || counter2 == -5 || counter2 == -10 || counter2 == -15 || counter2 == -20 || counter2 == -25 || counter2 == -30 || counter2 == -35 || counter2 == -40 ||
                  counter2 == -45 || counter2 == -50 || counter2 == -55 || counter2 == -60 || counter2 == -65 || counter2 == -70 || counter2 == -75 || counter2 == -80 ||
                  counter2 == -85 || counter2 == -90 || counter2 == -95 || counter2 == -100 || counter2 == -105 || counter2 == -115 || counter2 == -120 || counter2 == -125 ||
                  counter2 == -130 || counter2 == -135 || counter2 == -140 || counter2 == -145 || counter2 == -150 || counter2 == -155 || counter2 == -160 || counter2 == -165 || counter2 == -170 || counter2 == -175 || counter2 == -180 || counter2 == -190 || counter2 == -195 || counter2 == -200 || counter2 == -205 ||
                  counter2 == -210 || counter2 == -215 || counter2 == -220 || counter2 == -225 || counter2 == -230 || counter2 == -235 || counter2 == -240 || counter2 == -245 ||
                  counter2 == -250 || counter2 == -255 || counter2 == -260 || counter2 == -265 || counter2 == -270 || counter2 == -275 || counter2 == -280 || counter2 == -285 ||
                  counter2 == -290 || counter2 == -295 || counter2 == -300 || counter2 == -305 || counter2 == -310 || counter2 == -315 || counter2 == -320)
                {
                    GameOver x2 = new GameOver();
                    x2.Show();
                }
            }



        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            counter1 -= 10;
            totalCounter = counter3 + counter4 + counter5 + couter6;
            ScoreA.Text = counter1.ToString();
            int margin1 = Convert.ToInt32(ScoreA.Text);
            int margin2 = Convert.ToInt32(ScoreB.Text);
            if (margin1 > margin2)
            {
                int finalMargin1 = margin1 - margin2;
                Margin.Text = finalMargin1.ToString();
            }
            else if (margin1 == margin2)
            {
                int MarginAll = 0;
                Margin.Text = MarginAll.ToString();


            }
            else if (margin2 > margin1)
            {
                int finalMargin2 = margin2 - margin1;
                Margin.Text = finalMargin2.ToString();

            }
           

        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {
            counter1 -= 5;
            ScoreA.Text = counter1.ToString();
            totalCounter = counter3 + counter4 + counter5 + couter6;
            int margin1 = Convert.ToInt32(ScoreA.Text);
            int margin2 = Convert.ToInt32(ScoreB.Text);
            if (margin1 > margin2)
            {
                int finalMargin1 = margin1 - margin2;
                Margin.Text = finalMargin1.ToString();
            }
            else if (margin1 == margin2)
            {
                int MarginAll = 0;
                Margin.Text = MarginAll.ToString();


            }
            else if (margin2 > margin1)
            {
                int finalMargin2 = margin2 - margin1;
                Margin.Text = finalMargin2.ToString();

            }
           
            
           

            

            }

        private void pictureBox22_Click(object sender, EventArgs e)
        {
            counter2 -= 10;
            totalCounter = counter3 + counter4 + counter5 + couter6;
            ScoreB.Text = counter2.ToString();
            int margin1 = Convert.ToInt32(ScoreA.Text);
            int margin2 = Convert.ToInt32(ScoreB.Text);
            if (margin1 > margin2)
            {
                int finalMargin1 = margin1 - margin2;
                Margin.Text = finalMargin1.ToString();
            }
            else if (margin1 == margin2)
            {
                int MarginAll = 0;
                Margin.Text = MarginAll.ToString();


            }
            else if (margin2 > margin1)
            {
                int finalMargin2 = margin2 - margin1;
                Margin.Text = finalMargin2.ToString();

            }
          
           



        }

        private void pictureBox23_Click(object sender, EventArgs e)
        {
            counter2 -= 5;
            totalCounter = counter3 + counter4 + counter5 + couter6;
            ScoreB.Text = counter2.ToString();
            int margin1 = Convert.ToInt32(ScoreA.Text);
            int margin2 = Convert.ToInt32(ScoreB.Text);
            if (margin1 > margin2)
            {
                int finalMargin1 = margin1 - margin2;
                Margin.Text = finalMargin1.ToString();
            }
            else if (margin1 == margin2)
            {
                int MarginAll = 0;
                Margin.Text = MarginAll.ToString();


            }
            else if (margin2 > margin1)
            {
                int finalMargin2 = margin2 - margin1;
                Margin.Text = finalMargin2.ToString();

            }
            if (EnglishLimit.Text == "4" && HistoryLImit.Text == "4" && ScienceLimit.Text == "4" && MathLimit.Text == "4")
            {
                if (counter2==0||counter2 == 5 || counter2 == 10 || counter2 == 15 || counter2 == 20 || counter2 == 25 || counter2 == 30 || counter2 == 35 || counter2 == 40 ||
                  counter2 == 45 || counter2 == 50 || counter2 == 55 || counter2 == 60 || counter2 == 65 || counter2 == 70 || counter2 == 75 || counter2 == 80 ||
                  counter2 == 85 || counter2 == 90 || counter2 == 95 || counter2 == 100 || counter2 == 105 || counter2 == 115 || counter2 == 120 || counter2 == 125 ||
                  counter2 == 130 || counter2 == 135 || counter2 == 140 || counter2 == 145 || counter2 == 150 || counter2 == 155 || counter2 == 160)
                {
                    halftimeWindow x = new halftimeWindow();
                    x.Show();
                }
            }
            if (EnglishLimit.Text == "8" && HistoryLImit.Text == "8" && ScienceLimit.Text == "8" && MathLimit.Text == "8")
            {
                if (counter2 ==0||counter2 == 5 || counter2 == 10 || counter2 == 15 || counter2 == 20 || counter2 == 25 || counter2 == 30 || counter2 == 35 || counter2 == 40 ||
                  counter2 == 45 || counter2 == 50 || counter2 == 55 || counter2 == 60 || counter2 == 65 || counter2 == 70 || counter2 == 75 || counter2 == 80 ||
                  counter2 == 85 || counter2 == 90 || counter2 == 95 || counter2 == 100 || counter2 == 105 || counter2 == 115 || counter2 == 120 || counter2 == 125 ||
                  counter2 == 130 || counter2 == 135 || counter2 == 140 || counter2 == 145 || counter2 == 150 || counter2 == 155 || counter2 == 160||counter2 == 165 || counter2 == 170 || counter2 == 175 || counter2 == 180 || counter2 == 190 || counter2 == 195 || counter2 == 200 || counter2 == 205 ||
                  counter2 == 210 || counter2 == 215 || counter2 == 220 || counter2 == 225 || counter2 == 230 || counter2 == 235 || counter2 == 240 || counter2 == 245 ||
                  counter2 == 250 || counter2 == 255 || counter2 == 260 || counter2 == 265 || counter2 == 270 || counter2 == 275 || counter2 == 280 || counter2 == 285 ||
                  counter2 == 290 || counter2 == 295 || counter2 == 300 || counter2 == 305 || counter2 == 310 || counter2 == 315 || counter2 == 320)
                {
                    GameOver x2 = new GameOver();
                    x2.Show();
                }
            }



        }

        private void pictureBox24_Click(object sender, EventArgs e)

        {
           
            counter3 += 1;
            
            EnglishLimitMax += 1;
            EnglishLimit.Text = counter3.ToString();
            signalText1.Text = counter3.ToString();
            signalText2.Text = counter3.ToString();
            if (EnglishLimit.Text == "4" && HistoryLImit.Text == "4" && ScienceLimit.Text == "4" && MathLimit.Text == "4")

            {
                if(signalText1.Text == "Answer is incorect (X)" && signalText2.Text == "Answer is incorect (X)")
                {
                    halftimeWindow x = new halftimeWindow();
                    x.Show();
                }
               
            }
            if (EnglishLimit.Text == "8" && HistoryLImit.Text == "8" && ScienceLimit.Text == "8" && MathLimit.Text == "8")

            {
                if (signalText1.Text == "Answer is incorect (X)" && signalText2.Text == "Answer is incorect (X)")
                {
                    GameOver x2 = new GameOver();
                    x2.Show();
                }

            }










        }

        private void pictureBox28_Click(object sender, EventArgs e)
        {
            counter3 -= 1;
            EnglishLimit.Text = counter3.ToString();
        }

        private void pictureBox25_Click(object sender, EventArgs e)
        {
            
            counter4 += 1;
            HistoryLimitMax += 1;
            HistoryLImit.Text = counter4.ToString();
            signalText1.Text = counter4.ToString();
            signalText2.Text = counter4.ToString();
            if (EnglishLimit.Text == "4" && HistoryLImit.Text == "4" && ScienceLimit.Text == "4" && MathLimit.Text == "4" )
            {
                if (signalText1.Text == "Answer is incorect (X)"&&signalText2.Text == "Answer is incorect (X)")
                {
                    halftimeWindow x = new halftimeWindow();
                    x.Show();
                }
            }
            if (EnglishLimit.Text == "8" && HistoryLImit.Text == "8" && ScienceLimit.Text == "8" && MathLimit.Text == "8")

            {
                if (signalText1.Text == "Answer is incorect (X)" && signalText2.Text == "Answer is incorect (X)")
                {
                    GameOver x2 = new GameOver();
                    x2.Show();
                }

            }






        }

        private void pictureBox29_Click(object sender, EventArgs e)
        {
            counter4 -= 1;
            HistoryLImit.Text = counter4.ToString();
        }

        private void pictureBox26_Click(object sender, EventArgs e)
        {
            counter5 += 1;
            signalText1.Text = counter5.ToString();
            signalText2.Text = counter5.ToString();
            ScienceLimitMax += 1;
            ScienceLimit.Text = counter5.ToString();
            if (EnglishLimit.Text == "4" && HistoryLImit.Text == "4" && ScienceLimit.Text == "4" && MathLimit.Text == "4" )
            {
                if (signalText1.Text == "Answer is incorect (X)" && signalText2.Text == "Answer is incorect (X)")
                {
                    halftimeWindow x = new halftimeWindow();
                    x.Show();
                }
            }
            if (EnglishLimit.Text == "8" && HistoryLImit.Text == "8" && ScienceLimit.Text == "8" && MathLimit.Text == "8")

            {
                if (signalText1.Text == "Answer is incorect (X)" && signalText2.Text == "Answer is incorect (X)")
                {
                    GameOver x2 = new GameOver();
                    x2.Show();
                }

            }









        }

        private void pictureBox30_Click(object sender, EventArgs e)
        {
            counter5 -= 1;
            ScienceLimit.Text = counter5.ToString();
        }

        private void pictureBox27_Click(object sender, EventArgs e)
        {
            couter6 += 1;
            signalText1.Text = couter6.ToString();
            signalText2.Text = couter6.ToString();
            MathLimitMax += 1;
            MathLimit.Text = couter6.ToString();
            if (EnglishLimit.Text == "4" && HistoryLImit.Text == "4" && ScienceLimit.Text == "4" && MathLimit.Text == "4")
            {
                if (signalText1.Text == "Answer is incorect (X)" &&signalText2.Text == "Answer is incorect (X)")
                {
                    halftimeWindow x = new halftimeWindow();
                    x.Show();
                }
            }
            if (EnglishLimit.Text == "8" && HistoryLImit.Text == "8" && ScienceLimit.Text == "8" && MathLimit.Text == "8")

            {
                if (signalText1.Text == "Answer is incorect (X)" && signalText2.Text == "Answer is incorect (X)")
                {
                    GameOver x2 = new GameOver();
                    x2.Show();
                }

            }








        }

        private void pictureBox31_Click(object sender, EventArgs e)
        {
            couter6 -= 1;
            MathLimit.Text = couter6.ToString();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            signalText1.Text = "Answer is incorect (X)";
            if (EnglishLimit.Text == "4" && HistoryLImit.Text == "4" && ScienceLimit.Text == "4" && MathLimit.Text == "4")
            {
                if (signalText1.Text == "Answer is incorect (X)" && signalText2.Text == "Answer is incorect (X)")
                {
                    halftimeWindow x = new halftimeWindow();
                    x.Show();
                }
            }
            if (EnglishLimit.Text == "8" && HistoryLImit.Text == "8" && ScienceLimit.Text == "8" && MathLimit.Text == "8")

            {
                if (signalText1.Text == "Answer is incorect (X)" && signalText2.Text == "Answer is incorect (X)")
                {
                    GameOver x2 = new GameOver();
                    x2.Show();
                }

            }
            

        }

        private void WrongB_Click(object sender, EventArgs e)
        {
            signalText2.Text = "Answer is incorect (X)";
            if (EnglishLimit.Text == "4" && HistoryLImit.Text == "4" && ScienceLimit.Text == "4" && MathLimit.Text == "4")
            {
                if (signalText1.Text == "Answer is incorect (X)" && signalText2.Text == "Answer is incorect (X)")
                {
                    halftimeWindow x = new halftimeWindow();
                    x.Show();
                }
            }
            if (EnglishLimit.Text == "8" && HistoryLImit.Text == "8" && ScienceLimit.Text == "8" && MathLimit.Text == "8")

            {
                if (signalText1.Text == "Answer is incorect (X)" && signalText2.Text == "Answer is incorect (X)")
                {
                    GameOver x2 = new GameOver();
                    x2.Show();
                }

            }
           


        }

        private void pictureBox34_Click(object sender, EventArgs e)
        {

        }

        private void Player1Ouput_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            clone1 = (String)Player1Ouput.Text.Clone();
            finalclone = Convert.ToString(clone1);
            
            
            



        }

        private void ScoreBoard_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void sub1Output_Click(object sender, EventArgs e)

        {
            
            
            sub1Output.BackColor = Color.Red;
            if (Player1Ouput.Text == finalclone)
            {
                clone2 = (String)sub1Output.Text.Clone();
                clone2Output = Convert.ToString(clone2);
                sub1Output.Text = finalclone;
                Player1Ouput.Text = clone2Output;
                

            }
            if(Player2Output.Text== CloneTextOutput)
            {
                clone2 = (String)sub1Output.Text.Clone();
                clone2Output = Convert.ToString(clone2);
                sub1Output.Text = CloneTextOutput;
               Player2Output.Text = clone2Output;

            }
            if(player3Output.Text == CloneTextOuput1)
            {
                clone2 = (String)sub1Output.Text.Clone();
                clone2Output = Convert.ToString(clone2);
                sub1Output.Text = CloneTextOuput1;
                player3Output.Text = clone2Output;
            }
            if (player4Output.Text == CloneTextOput2)
            {
                clone2 = (String)sub1Output.Text.Clone();
                clone2Output = Convert.ToString(clone2);
                sub1Output.Text = CloneTextOput2;
                player4Output.Text = clone2Output;
            }


        }

        private void sub2Output_Click(object sender, EventArgs e)
        {
            sub2Output.BackColor = Color.Red;
            if (Player1Ouput.Text == finalclone)    
            {
                clone3 = (String)sub2Output.Text.Clone();
                clone3Ouput = Convert.ToString(clone3);
                sub2Output.Text = finalclone;
                Player1Ouput.Text = clone3Ouput;

            }
            if (Player2Output.Text == CloneTextOutput)
            {
                
                clone3 = (String)sub2Output.Text.Clone();
                clone3Ouput = Convert.ToString(clone3);
                sub2Output.Text = CloneTextOutput;
                Player2Output.Text = clone3Ouput;

            }
            if (player3Output.Text == CloneTextOuput1)
            {
                clone3 = (String)sub2Output.Text.Clone();
                clone3Ouput = Convert.ToString(clone3);
                sub2Output.Text = CloneTextOuput1;
                player3Output.Text = clone3Ouput;
            }
            if (player4Output.Text == CloneTextOput2)
            {
                clone3 = (String)sub2Output.Text.Clone();
                clone3Ouput = Convert.ToString(clone3);
                sub2Output.Text = CloneTextOput2;
                player4Output.Text = clone3Ouput;
            }

        }

        private void Player2Output_Click(object sender, EventArgs e)
        {
           
        }

        private void Player2Output_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            CloneText = (String)Player2Output.Text.Clone();
            CloneTextOutput = Convert.ToString(CloneText);
        }

        private void player3Output_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            CloneText2 = (String)player3Output.Text.Clone();
            CloneTextOuput1 = Convert.ToString(CloneText2);
        }

        private void player4Output_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            cloneText3 = (String)player4Output.Text.Clone();
            CloneTextOput2 = Convert.ToString(cloneText3);

        }

        private void T2_Player1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            t2_clone1 = (String)T2_Player1.Text.Clone();
            t2_output = Convert.ToString(t2_clone1);
        }

        private void T2_Sub1_Click(object sender, EventArgs e)  
        {
            T2_Sub1.BackColor = Color.Red;
            if (T2_Player1.Text == t2_output)
            {
                clone4 = (String)T2_Sub1.Text.Clone();
                clone4Output = Convert.ToString(clone4);
                T2_Sub1.Text = t2_output;
                T2_Player1.Text = clone4Output;

            }
            if(T2_Player2.Text == t2_output2)
            {
                clone4 = (String)T2_Sub1.Text.Clone();
                clone4Output = Convert.ToString(clone4);
                T2_Sub1.Text = t2_output2;
                T2_Player2.Text = clone4Output;


            }
            if(T2_Player3.Text == t2_output3)
            {
                clone4 = (String)T2_Sub1.Text.Clone();
                clone4Output = Convert.ToString(clone4);
                T2_Sub1.Text = t2_output3;
                T2_Player3.Text = clone4Output;
            }
            if (T2_Player4.Text == t2_output4)
            {
                clone4 = (String)T2_Sub1.Text.Clone();
                clone4Output = Convert.ToString(clone4);
                T2_Sub1.Text = t2_output4;
                T2_Player4.Text = clone4Output;
            }
        }

        private void T2_Sub2_Click(object sender, EventArgs e)
        {
            T2_Sub2.BackColor = Color.Red;
            if (T2_Player1.Text == t2_output)
            {
                clone5 = (String)T2_Sub2.Text.Clone();
                clone5output= Convert.ToString(clone5);
                T2_Sub2.Text = t2_output;
                T2_Player1.Text = clone5output;

            }
            if(T2_Player2.Text== t2_output2)
            {
                clone5 = (String)T2_Sub2.Text.Clone();
                clone5output = Convert.ToString(clone5);
                T2_Sub2.Text = t2_output2;
                T2_Player2.Text = clone5output;
            }
            if (T2_Player3.Text == t2_output3)
            {
                clone5 = (String)T2_Sub2.Text.Clone();
                clone5output = Convert.ToString(clone5);
                T2_Sub2.Text = t2_output3;
                T2_Player3.Text = clone5output;
            }
            if (T2_Player4.Text == t2_output4)
            {
                clone5 = (String)T2_Sub2.Text.Clone();
                clone5output = Convert.ToString(clone5);
                T2_Sub2.Text = t2_output4;
                T2_Player4.Text = clone5output;
            }
        }

        private void T2_Player2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            t2_clone2 = (String)T2_Player2.Text.Clone();
            t2_output2 = Convert.ToString(t2_clone2);


        }

        private void T2_Player3_DoubleClick(object sender, EventArgs e)
        {
            t2_clone3 = (String)T2_Player3.Text.Clone();
            t2_output3 = Convert.ToString(t2_clone3);
        }

        private void T2_Player4_DoubleClick(object sender, EventArgs e)
        {
            t2_clone4 = (String)T2_Player4.Text.Clone();
            t2_output4 = Convert.ToString(t2_clone4);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {

            
            
                statoutputs[0] = player1English.Text;
                statoutputs[1] = Player1History.Text;
                statoutputs[2] = Player1Science.Text;
                statoutputs[3] = Player1Math.Text;

                statoutputs[4] = player2English.Text;
                statoutputs[5] = player2History.Text;
                statoutputs[6] = player2Science.Text;
                statoutputs[7] = player2Math.Text;

                statoutputs[8] = player3English.Text;
                statoutputs[9] = player3History.Text;
                statoutputs[10] = player3Science.Text;
                statoutputs[11] = player3Math.Text;

                statoutputs[12] = player4English.Text;
                statoutputs[13] = player4History.Text;
                statoutputs[14] = player4Science.Text;
                statoutputs[15] = player4Math.Text;

                statoutputs[16] = player5English.Text;
                statoutputs[17] = player5History.Text;
                statoutputs[18] = player5Science.Text;
                statoutputs[19] = player5Math.Text;

                statoutputs[20] = player6English.Text;
                statoutputs[21] = player6History.Text;
                statoutputs[22] = player6Science.Text;
                statoutputs[23] = player6Math.Text;

                statoutputs[24] = player7English.Text;
                statoutputs[25] = player7History.Text;
                statoutputs[26] = player7Science.Text;
                statoutputs[27] = player7Math.Text;

                statoutputs[28] = player8English.Text;
                statoutputs[29] = player8History.Text;
                statoutputs[30] = player8Science.Text;
                statoutputs[31] = player8Math.Text;

                statoutputs[32] = player9English.Text;
                statoutputs[33] = player9History.Text;
                statoutputs[34] = player9Science.Text;
                statoutputs[35] = player9Math.Text;

                statoutputs[36] = player10English.Text;
                statoutputs[37] = player10History.Text;
                statoutputs[38] = player10Science.Text;
                statoutputs[39] = player10Math.Text;

                statoutputs[40] = player11English.Text;
                statoutputs[41] = player11History.Text;
                statoutputs[42] = player11Science.Text;
                statoutputs[43] = player11Math.Text;

                statoutputs[44] = player12English.Text;
                statoutputs[45] = player12History.Text;
                statoutputs[46] = player12Science.Text;
                statoutputs[47] = player12Math.Text;

                if (EnglishLimit.Text == "8" && HistoryLImit.Text == "8" && ScienceLimit.Text == "8" && MathLimit.Text == "8")
                {
                    this.Hide();    
                    GameSummary x = new GameSummary();
                    x.Show();

                }
                else
                {
                    this.Hide();
                    ScoreBoard newwindow = new ScoreBoard();
                    newwindow.Show();
                MessageBox.Show("Game summary cannot display without playing a full Match", "Game Summary", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            int finalScoreA = Convert.ToInt32(ScoreA.Text);
            int finalscoreB = Convert.ToInt32(ScoreB.Text);

           



            
            
               
            
           

        }

        private void player1English_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void player1English_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
                    

            
        }

        private void Player1History_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void Player1Science_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Player1Math_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void player2English_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void player2History_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void player2Science_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void player2Math_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void player2Science_TextChanged(object sender, EventArgs e)
        {

        }

        private void player3English_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void player3History_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void player3Science_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void player3Math_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void player4English_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void player4History_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void player4Science_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void player4Math_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void player5English_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void player5History_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void player5Science_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void player5Math_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void player6English_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void player6History_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void player6Science_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void player6Math_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void player7English_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void player7History_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void player7Science_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void player7Math_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void player8English_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void player8History_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void player8Science_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void player8Math_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void player9English_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void player9History_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void player9Science_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void player9Math_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void player10English_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void player10History_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void player10Science_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void player10Math_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void player11English_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void player11History_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void player11Science_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void player11Math_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void player12English_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void player12History_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void player12Science_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void player12Math_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }   
        }
    }
}
