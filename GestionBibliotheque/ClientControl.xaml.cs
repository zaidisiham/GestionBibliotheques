using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;

namespace GestionBibliotheque
{
    public partial class ClientControl : UserControl
    {
        public ClientControl()
        {
            InitializeComponent();
        }

        // Méthode pour ouvrir le menu
        private void OpenMenu_Click(object sender, RoutedEventArgs e)
        {
            ClientSideMenu.Visibility = Visibility.Visible;
            MenuIcon.Visibility = Visibility.Collapsed;

            DoubleAnimation animation = new DoubleAnimation();
            animation.From = 0;
            animation.To = 250;
            animation.Duration = new Duration(TimeSpan.FromSeconds(0.3));
            ClientSideMenu.BeginAnimation(WidthProperty, animation);
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
                ClientSideMenu.Visibility = Visibility.Collapsed;
                MenuIcon.Visibility = Visibility.Visible;
            };
            ClientSideMenu.BeginAnimation(WidthProperty, animation);
        }
    }
}
