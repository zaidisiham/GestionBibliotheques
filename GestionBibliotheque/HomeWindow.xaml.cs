using System.Windows;
using System.Windows.Media.Animation;

namespace GestionBibliotheque
{
    public partial class HomeWindow : Window
    {
        public HomeWindow()
        {
            InitializeComponent();
        }

        private void MenuButton_Click(object sender, RoutedEventArgs e)
        {
            DoubleAnimation animation = new DoubleAnimation();
            if (SideMenu.Width == 0)
            {
                animation.From = 0;
                animation.To = 250;
                animation.Duration = new Duration(TimeSpan.FromSeconds(0.3));
                SideMenu.BeginAnimation(WidthProperty, animation);
            }
            else
            {
                animation.From = 250;
                animation.To = 0;
                animation.Duration = new Duration(TimeSpan.FromSeconds(0.3));
                SideMenu.BeginAnimation(WidthProperty, animation);
            }
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            DoubleAnimation animation = new DoubleAnimation();
            animation.From = 250;
            animation.To = 0;
            animation.Duration = new Duration(TimeSpan.FromSeconds(0.3));
            SideMenu.BeginAnimation(WidthProperty, animation);
        }

        private void HomeButton_Click(object sender, RoutedEventArgs e)
        {
            HomeWindow homeWindow = new HomeWindow();
            homeWindow.Show();
            this.Close();
        }

        private void BooksButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Ouverture de la gestion des livres.");
        }

        private void BorrowersButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Ouverture de la gestion des emprunteurs.");
        }

        private void ReturnsButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Ouverture de la gestion des retours.");
        }

        private void StatisticsButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Ouverture des statistiques.");
        }
    }
}
