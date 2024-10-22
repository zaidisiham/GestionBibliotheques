using System.Windows;

namespace GestionBibliotheque
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // Méthode exécutée lors du clic sur "Se Connecter"
        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            string username = UsernameTextBox.Text;
            string password = PasswordBox.Password;

            // Vérifier si les champs sont vides
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                ErrorMessage.Text = "Veuillez remplir tous les champs.";
                ErrorMessage.Visibility = Visibility.Visible;
            }
            // Vérification simple des informations de connexion
            else if (username == "admin" && password == "admin")
            {
                ErrorMessage.Visibility = Visibility.Collapsed;  // Cacher le message d'erreur

                // Ouvrir la fenêtre d'accueil et fermer la fenêtre de connexion
                HomeWindow homeWindow = new HomeWindow();
                homeWindow.Show();
                this.Close();  // Fermer la fenêtre de connexion
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
