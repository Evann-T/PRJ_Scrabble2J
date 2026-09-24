using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scrabble2Joueurs.Data
{
    public class Partie
    {
        public DateTime DatePartie { get; set; }

        public string NomJoueur1 { get; set; }

        public int ScoreJoueur1 { get; set; }

        public string NomJoueur2 { get; set; }

        public int ScoreJoueur2 { get; set; }
    }


}
