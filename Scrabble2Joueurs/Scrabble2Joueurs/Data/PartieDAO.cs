using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace Scrabble2Joueurs.Data
{
    internal class PartieDAO
    {
        public List<Partie> GetAllParties()
        {
            List<Partie> parties = new List<Partie>();

            try
            {
                MySqlConnection connexion = Connexion.Connect();
                connexion.Open();

                string requete = @"
                    SELECT date, nomJoueur1, scoreJoueur1, nomJoueur2, scoreJoueur2
                    FROM partie
                    ORDER BY date DESC";

                MySqlCommand cmdSelect = new MySqlCommand(requete, connexion);
                MySqlDataReader reader = cmdSelect.ExecuteReader();

                while (reader.Read())
                {
                    Partie partie = new Partie(
                        reader.GetDateTime("date"),
                        reader.GetString("nomJoueur1"),
                        reader.GetInt32("scoreJoueur1"),
                        reader.GetString("nomJoueur2"),
                        reader.GetInt32("scoreJoueur2")
                    );

                    parties.Add(partie);
                }

                reader.Close();
                cmdSelect.Dispose();
                connexion.Close();
            }
            catch (MySqlException e)
            {
                Console.WriteLine("Erreur MySQL : " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Erreur : " + e.Message);
            }

            return parties;
        }

        public void AddPartie(Partie partie)
        {
            try
            {
                MySqlConnection connexion = Connexion.Connect();
                connexion.Open();

                string requete = @"
                    INSERT INTO partie (nomJoueur1, scoreJoueur1, nomJoueur2, scoreJoueur2)
                    VALUES
                    (@nomJoueur1, @scoreJoueur1, @nomJoueur2, @scoreJoueur2)";

                MySqlCommand cmdInsert = new MySqlCommand(requete, connexion);

                cmdInsert.Parameters.AddWithValue("@nomJoueur1", partie.NomJoueur1);
                cmdInsert.Parameters.AddWithValue("@scoreJoueur1", partie.ScoreJoueur1);
                cmdInsert.Parameters.AddWithValue("@nomJoueur2", partie.NomJoueur2);
                cmdInsert.Parameters.AddWithValue("@scoreJoueur2", partie.ScoreJoueur2);

                cmdInsert.ExecuteNonQuery();

                cmdInsert.Dispose();
                connexion.Close();
            }
            catch (MySqlException e)
            {
                Console.WriteLine("Erreur MySQL : " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Erreur : " + e.Message);
            }
        }
    }
}
