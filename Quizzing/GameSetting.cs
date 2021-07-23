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
    public partial class GameSetting : Form

    {
        public static string setvaluetext0;
        
        public static string setvaluetext1;
        public static string setvaluetext2;
        public static string setvaluetext3;
        public static string setvaluetext4;
        public static string setvaluetext5;
        public static string setvaluetext6;
        public static string setvaluetext7;

        public static string setvaluetext8;
        public static string setvaluetext9;
        public static string setvaluetext10;
        public static string setvaluetext11;
        public static string setvaluetext12;
        public static string setvaluetext13;
        public static string setvaluetext14;
        public static string setvaluetext15;
        public GameSetting()
        {
            InitializeComponent();
        }

        private void GameSetting_Load(object sender, EventArgs e)
        {
            Text = Properties.Settings.Default.TextBox;
            

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void backbutton_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)

        {
            

           








        }

        private void Team1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
          
        }

        private void pictureBox2_Click(object sender, EventArgs e)

        {
            
            








        }

        private void TeamKeypress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsLetter(e.KeyChar) && (!char.IsControl(e.KeyChar)) && (!char.IsWhiteSpace(e.KeyChar)))
            {
                e.Handled = true; 
            }

            
                

            

        }

        private void player1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && (!char.IsControl(e.KeyChar)) && (!char.IsWhiteSpace(e.KeyChar)))
            {
                e.Handled = true;
            }

        }

        private void player2(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && (!char.IsControl(e.KeyChar)) && (!char.IsWhiteSpace(e.KeyChar)))
            {
                e.Handled = true;
            }

        }

        private void player3(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && (!char.IsControl(e.KeyChar)) && (!char.IsWhiteSpace(e.KeyChar)))
            {
                e.Handled = true;
            }

        }

        private void player4(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && (!char.IsControl(e.KeyChar)) && (!char.IsWhiteSpace(e.KeyChar)))
            {
                e.Handled = true;
            }

        }

        private void sub1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && (!char.IsControl(e.KeyChar)) && (!char.IsWhiteSpace(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void sub2(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && (!char.IsControl(e.KeyChar)) && (!char.IsWhiteSpace(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void coach(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && (!char.IsControl(e.KeyChar)) && (!char.IsWhiteSpace(e.KeyChar)))
            {
                e.Handled = true;
            }

        }

        private void TeamB(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && (!char.IsControl(e.KeyChar)) && (!char.IsWhiteSpace(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void player5(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && (!char.IsControl(e.KeyChar)) && (!char.IsWhiteSpace(e.KeyChar)))
            {
                e.Handled = true;
            }

        }

        private void player6(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && (!char.IsControl(e.KeyChar)) && (!char.IsWhiteSpace(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void player7(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && (!char.IsControl(e.KeyChar)) && (!char.IsWhiteSpace(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void player8(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && (!char.IsControl(e.KeyChar)) && (!char.IsWhiteSpace(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void sub3(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && (!char.IsControl(e.KeyChar)) && (!char.IsWhiteSpace(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void sub4(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && (!char.IsControl(e.KeyChar)) && (!char.IsWhiteSpace(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void coach2(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && (!char.IsControl(e.KeyChar)) && (!char.IsWhiteSpace(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            setvaluetext0 = Team1.Text;
            setvaluetext1 = Player1.Text + "(C)";
            setvaluetext2 = Player2.Text;
            setvaluetext3 = Player3.Text;
            setvaluetext4 = Player4.Text;
            setvaluetext5 = Sub1.Text;
            setvaluetext6 = Sub2.Text;
            setvaluetext7 = Coach1.Text;

            setvaluetext8 = Team2.Text;
            setvaluetext9 = T2_Player1.Text + "(C)";
            setvaluetext10 = T2_Player2.Text;
            setvaluetext11 = T2_Player3.Text;
            setvaluetext12 = T2_Player4.Text;
            setvaluetext13 = T2_Substitute1.Text;
            setvaluetext14 = T2_Substitute2.Text;
            setvaluetext15 = Coach2.Text;

            if (setvaluetext0 != "" && setvaluetext1 != "" && setvaluetext2 != "" && setvaluetext3 != "" && setvaluetext4 != "" &&
                setvaluetext5 != "" && setvaluetext6 != "" && setvaluetext7 != "" && setvaluetext8 != "" && setvaluetext9 != "" && setvaluetext10 != ""
                && setvaluetext11 != "" && setvaluetext12 != "" && setvaluetext3 != "" && setvaluetext14 != "" && setvaluetext15 != "")
            {
                this.Hide();
                ScoreBoard f3 = new ScoreBoard();
                f3.Show();

            }
            else
            {
                this.Hide();
                GameSetting redirect = new GameSetting();
                redirect.Show();
                MessageBox.Show("Please complete all the information needed for the textboxes", "Incomplete Form", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            
        }
    }
}
