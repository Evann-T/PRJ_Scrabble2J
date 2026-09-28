using MySql.Data;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scrabble2Joueurs
{
    internal static class Connexion
    {
        public static MySqlConnection Connect()
        {
            MySqlConnection connex = null;
            string chaineConnex = "server=localhost; user id=root; password= ; database=bdd_scrabble";

            try
            {
                connex = new MySqlConnection(chaineConnex);
            }
            catch (Exception e)
            {
                Console.WriteLine("Erreur", e);
            }

            return connex;
        }

    }
}
