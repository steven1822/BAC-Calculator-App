namespace BAC_Calc_App.Veiws;

public partial class SetupPage : ContentPage
{
    public SetupPage()
    {
        InitializeComponent();
    }
    private async void OnSaveClicked(object sender, EventArgs e)
    {
        if (double.TryParse(WeightEntry.Text, out double weight) && weight > 0)
        {
            Preferences.Default.Set("UserWeight", weight);
            await DisplayAlert("Success", "Your weight has been saved!", "OK");

            // Navigate to the main page
            Application.Current.MainPage = new MainPage();
        }
        else
        {
            await DisplayAlert("Error", "Please enter a valid weight.", "OK");
        }
    }
}

