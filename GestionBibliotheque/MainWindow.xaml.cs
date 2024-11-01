using System.Windows;

namespace GestionBibliotheque
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            string username = UsernameTextBox.Text;
            string password = PasswordBox.Password;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                ErrorMessage.Text = "Veuillez remplir tous les champs.";
                ErrorMessage.Visibility = Visibility.Visible;
            }
            else if (username == "admin" && password == "admin")
            {
                // Ouvre HomeWindow avec le User Control pour l'admin
                HomeWindow homeWindow = new HomeWindow("admin");
                homeWindow.Show();
                this.Close();
            }
            else if (username == "client" && password == "client")
            {
                // Ouvre HomeWindow avec le User Control pour le client
                HomeWindow homeWindow = new HomeWindow("client");
                homeWindow.Show();
                this.Close();
            }
            else
            {
                ErrorMessage.Text = "Nom d'utilisateur ou mot de passe incorrect.";
                ErrorMessage.Visibility = Visibility.Visible;
            }
        }



        // Méthode exécutée lors du clic sur "Inscrivez-vous ici"
        private void SignUp_Click(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            MessageBox.Show("Rediriger vers la page d'inscription...");
            // Logique pour rediriger l'utilisateur vers la page d'inscription
        }
    }
}
