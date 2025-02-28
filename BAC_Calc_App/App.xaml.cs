using BAC_Calc_App.Veiws;

namespace BAC_Calc_App
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // Check if the user has set their weight before
            if (Preferences.Default.ContainsKey("UserWeight"))
            {
                MainPage = new NavigationPage(new MainPage())
                {
                    BarBackgroundColor = Color.FromArgb("#4d2b05"),
                    BarTextColor = Colors.Tan,
                    

                };
               // Enables navigation
            }
            else
            {
                MainPage = new NavigationPage(new SetupPage()); // Enables navigation
            }
        }
    }
}