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
    public partial class AddBasketballPlayerForm : Form
    {
        public static BasketballPlayerStar player = new BasketballPlayerStar();

        public AddBasketballPlayerForm()
        {
            InitializeComponent();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if(IsTextBlank(nameTextBox.Text)
                || IsTextBlank(positionComboBox.Text)
                || IsTextBlank(teamTextBox.Text)
                || !heightMaskedTextBox.MaskCompleted)
            {
                MessageBox.Show("Ningun campo puede estar en blanco");
                return;
            }
            
            player.Name = nameTextBox.Text;
            player.Position = positionComboBox.Text;
            player.Team = teamTextBox.Text;
            player.Height = float.Parse(heightMaskedTextBox.Text);

            DialogResult = DialogResult.OK;
            Close();
        }

        private void HeightMaskedTextBox_Validated(object sender, EventArgs e)
        {
            if (heightMaskedTextBox.MaskCompleted)
                return;

            double height = float.Parse(heightMaskedTextBox.Text);

            if (height > 2.40d || height < 1.50d)
            {
                heightMaskedTextBox.BackColor = Color.Red;
                addButton.Enabled = false;
                MessageBox.Show("La altura del jugador deberia estar entre 1.50 metros y 2.40 metros");
                return;
            }

            heightMaskedTextBox.BackColor = Color.White;
            addButton.Enabled = true;
        }

        private bool IsTextBlank(string text) => text.Length == 0;
    }
}
