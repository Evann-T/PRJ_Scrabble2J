using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scrabble2Joueurs
{
    internal class Partie
    {
        private DateTime datePartie;
        private string nomJoueur1;
        private int scoreJoueur1;
        private string nomJoueur2;
        private int scoreJoueur2;

        public Partie(DateTime datePartie, string nomJoueur1, int scoreJoueur1, string nomJoueur2, int scoreJoueur2)
        {
            this.datePartie = datePartie;
            this.nomJoueur1 = nomJoueur1;
            this.scoreJoueur1 = scoreJoueur1;
            this.nomJoueur2 = nomJoueur2;
            this.scoreJoueur2 = scoreJoueur2;
        }

        public DateTime DatePartie => datePartie;
        public string NomJoueur1 => nomJoueur1;
        public int ScoreJoueur1 => scoreJoueur1;
        public string NomJoueur2 => nomJoueur2;
        public int ScoreJoueur2 => scoreJoueur2;
    }
}
