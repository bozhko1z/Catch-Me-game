using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatchMeGame
{
    public partial class EndPage : Form
    {
        public EndPage()
        {
            InitializeComponent();
            endLabel.Text = GamePage.afterMessage;
            scoreLabel.Text = GamePage.scoreMessage;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new GamePage().ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
