using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenWF_Tarde_30052023.models
{
    public abstract class BasketballPlayer
    {
        public string Name { get; set; }
        public string Position { get; set; }
        public float Height { get; set; }
        public abstract string Team { get; set; }
    }
}
