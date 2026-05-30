using ListaTareasMAUI.Models;

namespace ListaTareasMAUI.Views;

public partial class TaskDetailPage : ContentPage
{
    private TaskItem task;

    public TaskDetailPage(TaskItem selectedTask)
    {
        InitializeComponent();

        task = selectedTask;

        taskEntry.Text = task.Name;
        completedCheck.IsChecked = task.IsCompleted;
    }

    private async void OnSaveClicked(object sender, EventArgs e)
    {
        task.Name = taskEntry.Text;
        task.IsCompleted = completedCheck.IsChecked;

        await Navigation.PopModalAsync();
    }
}