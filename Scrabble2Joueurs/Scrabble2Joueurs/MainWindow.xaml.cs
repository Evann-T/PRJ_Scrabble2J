using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Scrabble2Joueurs
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Joueur J1;
        Joueur J2;
        List<char> listeLettre = new List<char> 
        {'A','B','C','D','E','F','G','H','I','J','K','L','M',
        'N','O','P','Q','R','S','T','U','V','W','X','Y','Z'};
        List<char> listeLettreAff = new List<char> { };
        Random random = new Random();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnCommencer_Click(object sender, RoutedEventArgs e)
        {
            if (txtNomJ1.Text == txtNomJ2.Text)
            {
                MessageBox.Show("Erreur : Vous ne pouver pas avoir le même nom que votre adversaire");
            }
            else
            {
                if (txtNomJ1.Text == "" || txtNomJ2.Text == "")
                {
                    MessageBox.Show("Erreur : Veuiller entrer un nom pour les deux joueurs");
                }
                else
                {
                    txtInfosNomJ1.Text = txtNomJ1.Text;
                    txtInfosNomj2.Text = txtNomJ2.Text;
                    J1 = new Joueur(txtNomJ1.Text);
                    J2 = new Joueur(txtNomJ2.Text);
                    txtNomJ1.IsEnabled = false;
                    txtNomJ2.IsEnabled = false;
                    btnCommencer.IsEnabled = false;
                    //Gestion de l'ordre de départ
                    int quiCommence = random.Next(0, 1);
                    if (quiCommence == 0)
                    {
                        txtTourJ1.Text = "C\' est votre tour !";
                        txtTourJ2.Text = "";
                        txtMotJ2.IsEnabled = false;
                        btnValiderJ2.IsEnabled = false;

                    }
                    else
                    {
                        txtTourJ2.Text = "C\' est votre tour !";
                        txtTourJ1.Text = "";
                        txtMotJ1.IsEnabled = false;
                        btnValiderJ1.IsEnabled = false;
                    }
                    //Gestion des lettres
                    
                    Afficher();
                }
                    
            }
        }

        private void txtNomJ1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtNomJ2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtMotJ1_TextChanged(object sender, TextChangedEventArgs e)
        {


        }

        private void txtMotJ2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btnValiderJ1_Click(object sender, RoutedEventArgs e)
        {
            if (txtMotJ1.Text == "")
            {
                MessageBox.Show("Erreur : Veuiller entrer un mot");
            }
            else
            {
                J1.AjouterMot(txtMotJ1.Text);
                txtNbMotJ1.Text = $"{J1.GetNbMots()}";
                txtPointMotJ1.Text = $"{Utilitaire.PointsMot(txtMotJ1.Text)}";
                txtPointTotMotJ1.Text = $"{J1.GetTotalPoints()}";
                //Gestion du tour
                txtTourJ2.Text = "C\' est cotre tour !";
                txtTourJ1.Text = "";
                txtMotJ1.IsEnabled = false;
                btnValiderJ1.IsEnabled = false;
                txtMotJ2.IsEnabled = true;
                btnValiderJ2.IsEnabled = true;
                Afficher();

            }
        }

        private void btnValiderJ2_Click(object sender, RoutedEventArgs e)
        {
            if (txtMotJ2.Text == "")
            {
                MessageBox.Show("Erreur : Veuiller entrer un mot");
            }
            else
            {
                J2.AjouterMot(txtMotJ2.Text);
                txtNbMotJ2.Text = $"{J2.GetNbMots()}";
                txtPointMotJ2.Text = $"{Utilitaire.PointsMot(txtMotJ2.Text)}";
                txtPointTotMotJ2.Text = $"{J2.GetTotalPoints()}";
                //Gestion du tour
                txtTourJ1.Text = "C\' est cotre tour !";
                txtTourJ2.Text = "";
                txtMotJ2.IsEnabled = false;
                btnValiderJ2.IsEnabled = false;
                txtMotJ1.IsEnabled = true;
                btnValiderJ1.IsEnabled = true;
                //Gestion des lettres
                Afficher();
            }
        }

        private void Afficher()
        {
            listeLettreAff.Clear();
            int i = 0;
            for (i = 0; i < 7; i++)
            {
                listeLettreAff.Add(listeLettre[random.Next(0, 26)]);
            }
            txtLettre0.Text = listeLettreAff[0].ToString();
            txtLettre1.Text = listeLettreAff[1].ToString();
            txtLettre2.Text = listeLettreAff[2].ToString();
            txtLettre3.Text = listeLettreAff[3].ToString();
            txtLettre4.Text = listeLettreAff[4].ToString();
            txtLettre5.Text = listeLettreAff[5].ToString();
            txtLettre6.Text = listeLettreAff[6].ToString();
        }
    }
}
