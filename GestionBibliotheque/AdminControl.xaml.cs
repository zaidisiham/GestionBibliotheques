using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;

namespace GestionBibliotheque
{
    public partial class AdminControl : UserControl
    {
        public AdminControl()
        {
            InitializeComponent();
        }

        // Méthode pour ouvrir le menu
        private void OpenMenu_Click(object sender, RoutedEventArgs e)
        {
            AdminSideMenu.Visibility = Visibility.Visible;
            MenuIcon.Visibility = Visibility.Collapsed; // Masquer l'icône de menu

            DoubleAnimation animation = new DoubleAnimation();
            animation.From = 0;
            animation.To = 250;
            animation.Duration = new Duration(TimeSpan.FromSeconds(0.3));
            AdminSideMenu.BeginAnimation(WidthProperty, animation);
        }

        // Méthode pour fermer le menu
        private void CloseMenu_Click(object sender, RoutedEventArgs e)
        {
            DoubleAnimation animation = new DoubleAnimation();
            animation.From = 250;
            animation.To = 0;
            animation.Duration = new Duration(TimeSpan.FromSeconds(0.3));
            animation.Completed += (s, a) =>
            {
                AdminSideMenu.Visibility = Visibility.Collapsed;
                MenuIcon.Visibility = Visibility.Visible; // Afficher l'icône de menu
            };
            AdminSideMenu.BeginAnimation(WidthProperty, animation);
        }
    }
}
