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

            // Navigate back to MainPage
            await Navigation.PopAsync();
        }
        else
        {
            await DisplayAlert("Error", "Please enter a valid weight.", "OK");
        }
    }
}

