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
    public partial class halftimeWindow : Form
    {
        public halftimeWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void pictureBox32_Click(object sender, EventArgs e)
        {

        }

        private void halftimeWindow_Load(object sender, EventArgs e)
        {
            this.MinimumSize = new Size(825, 279);
            this.MaximumSize = new Size(825, 279);
        }
    }
}
