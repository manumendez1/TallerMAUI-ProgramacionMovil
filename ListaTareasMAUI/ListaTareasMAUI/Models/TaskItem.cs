using CommunityToolkit.Mvvm.ComponentModel;

namespace ListaTareasMAUI.Models;

public partial class TaskItem : ObservableObject
{
    public int Id { get; set; }

    [ObservableProperty]
    private string name;

    [ObservableProperty]
    private bool isCompleted;

    public DateTime CreatedAt { get; set; }
}