using ListaTareasMAUI.Models;
using ListaTareasMAUI.Views;

namespace ListaTareasMAUI;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private async void OnEditTaskClicked(object sender, EventArgs e)
    {
        Button button = sender as Button;

        TaskItem task = button.CommandParameter as TaskItem;

        if (task != null)
        {
            await Navigation.PushModalAsync(
                new TaskDetailPage(task));
        }
    }
}