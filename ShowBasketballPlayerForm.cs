using ExamenWF_Tarde_30052023.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenWF_Tarde_30052023
{
    public partial class ShowBasketballPlayerForm : Form
    {
        public static double pointsForGame = 0.0d;

        public ShowBasketballPlayerForm(BasketballPlayerStar player)
        {
            InitializeComponent();
            pointsNumericUpDown.Increment = 0.25m;


            nameLabel.Text = player.Name;
            positionLabel.Text = player.Position;
            heightLabel.Text = player.Height.ToString();
            teamLabel.Text = player.Team;
            pointsNumericUpDown.Text = player.PointsForGame.ToString();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            pointsForGame = double.Parse(pointsNumericUpDown.Text);

            DialogResult = DialogResult.OK;
            Close();
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
