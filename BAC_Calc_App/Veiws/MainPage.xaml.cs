namespace BAC_Calc_App.Veiws
{
    public partial class MainPage : ContentPage
    {
        

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnAddDrinkClicked(object sender, EventArgs e)
        {
            double BAC = 0.02;
            
        }

        private async void onSettingsClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SetupPage());
        }



    }

}
