namespace MauiApp1;

public partial class MainPage : ContentPage
{
    List<string> list1 = new List<string>() { "1" };
    List<string> list2 = new List<string>() { "2" };

    public MainPage()
    {
        InitializeComponent();
        Picker1.ItemsSource = list1;
        Picker1.SelectedIndex = 0;
    }

    private void OnButtonClicked(object sender, EventArgs e)
    {
        Picker1.ItemsSource = list2;
        Picker1.SelectedIndex = 0;
    }
}

