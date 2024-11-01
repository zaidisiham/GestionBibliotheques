using System.Windows;

namespace GestionBibliotheque
{
    public partial class HomeWindow : Window
    {
        public HomeWindow(string userType)
        {
            InitializeComponent();

            // Charger AdminControl sans marges ni restrictions de positionnement
            if (userType == "admin")
            {
                AdminControl adminControl = new AdminControl();
                adminControl.HorizontalAlignment = HorizontalAlignment.Stretch;
                adminControl.VerticalAlignment = VerticalAlignment.Stretch;
                MainContent.Content = adminControl;
            }
            else if (userType == "client")
            {
                ClientControl clientControl = new ClientControl();
                clientControl.HorizontalAlignment = HorizontalAlignment.Stretch;
                clientControl.VerticalAlignment = VerticalAlignment.Stretch;
                MainContent.Content = clientControl;
            }
        }
    }
}
