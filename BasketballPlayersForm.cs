using ExamenWF_Tarde_30052023.models;

namespace ExamenWF_Tarde_30052023
{
    public partial class BasketballPlayersForm : Form
    {
        private List<BasketballPlayerStar> _players;

        public BasketballPlayersForm()
        {
            InitializeComponent();
            basketballPlayersListView.View = View.Details;

            basketballPlayersListView.Columns.Add("Nombre", 230);
            basketballPlayersListView.Columns.Add("Posición", 100);
            basketballPlayersListView.Columns.Add("Altura", 70);

            _players = new List<BasketballPlayerStar>();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddBasketballPlayerForm form = new AddBasketballPlayerForm();
            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK)
            {
                _players.Add(AddBasketballPlayerForm.player);

                ListViewItem item = new ListViewItem(_players.Last().Name);
                item.SubItems.AddRange(
                    new string[]
                    {
                        _players.Last().Position,
                        _players.Last().Height.ToString()
                    }
                );

                basketballPlayersListView.Items.Add(item);
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BasketballPlayersListView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (basketballPlayersListView.SelectedIndices.Count <= 0)
                return;

            ShowBasketballPlayerForm form = 
                new ShowBasketballPlayerForm(_players[basketballPlayersListView.SelectedIndices[0]]);
            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK)
            {
                _players[basketballPlayersListView
                    .SelectedIndices[0]]
                    .PointsForGame = ShowBasketballPlayerForm.pointsForGame;
            }
        }

    }
}