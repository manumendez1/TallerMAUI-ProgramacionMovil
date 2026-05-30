namespace AgendaSQLiteMAUI;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    public MainPage(ViewModels.ContactsViewModel vm)
    {
        InitializeComponent();

        BindingContext = vm;
    }
}