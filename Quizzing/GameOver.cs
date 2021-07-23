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
    public partial class GameOver : Form
    {
        public GameOver()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            this.Hide();
        

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.MinimumSize = new Size(801, 237);
            this.MaximumSize = new Size(801, 237);
        }
    }
}
