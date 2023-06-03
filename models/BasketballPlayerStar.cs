using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenWF_Tarde_30052023.models
{
    public class BasketballPlayerStar : BasketballPlayer
    {
        private string _team = "";

        public double PointsForGame { get; set; }
        public override string Team { get => _team; set => _team = value; }
    }
}
