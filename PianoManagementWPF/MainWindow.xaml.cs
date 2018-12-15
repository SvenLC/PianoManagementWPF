using PianoManagementWPF.Interfaces;
using PianoManagementWPF.UserControls;
using System;
using System.Collections.Generic;
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

namespace PianoManagementWPF
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BoutonQuitter_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void BoutonAjouter_Click(object sender, RoutedEventArgs e)
        {
            VerificationPourActionICrud()?.Create();
        }

        private void BoutonModifier_Click(object sender, RoutedEventArgs e)
        {
            VerificationPourActionICrud()?.Update();
        }

        private void BoutonSupprimer_Click(object sender, RoutedEventArgs e)
        {
            VerificationPourActionICrud()?.Delete();
        }

        private ICrud VerificationPourActionICrud()
        {
            
            if (this.GridContenu.Children.Count != 0)
            {
                
                if (this.GridContenu.Children.OfType<ICrud>().Any())
                {
                    //On appelle la fonction associée sur ce module 
                    //(le premier et normalement le seul car les 
                    //chargements de modules réinitialisent la zone prévue 
                    //pour les modules)
                    return this.GridContenu.Children.OfType<ICrud>().First();
                }
            }
            return null;
        }

        private bool LoadModule<T>() where T : UIElement, new()
        {
            return MyLibrary.Helpers.Grid.LoadUniqueModule<T>(this.GridContenu);
        }

        private void BoutonGestionPiano_Click(object sender, RoutedEventArgs e)
        {
            LoadModule<PianoUserControl>();
        }

        private void BoutonGestionAccord_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BoutonParametresProfesseur_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BoutonParametresEntreprise_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BoutonParametresSite_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BoutonParametresPianoType_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
