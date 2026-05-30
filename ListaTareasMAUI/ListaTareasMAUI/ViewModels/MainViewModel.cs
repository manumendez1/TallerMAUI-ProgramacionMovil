using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ListaTareasMAUI.Models;
using System.Collections.ObjectModel;

namespace ListaTareasMAUI.ViewModels;

public partial class MainViewModel : ObservableObject
{
    [ObservableProperty]
    private ObservableCollection<TaskItem> tasks;

    [ObservableProperty]
    private string newTaskName;

    public MainViewModel()
    {
        Tasks = new ObservableCollection<TaskItem>();
    }

    [RelayCommand]
    private void AddTask()
    {
        if (!string.IsNullOrWhiteSpace(NewTaskName))
        {
            Tasks.Add(new TaskItem
            {
                Id = Tasks.Count + 1,
                Name = NewTaskName,
                IsCompleted = false,
                CreatedAt = DateTime.Now
            });

            NewTaskName = string.Empty;
        }
    }

    [RelayCommand]
    private void DeleteTask(TaskItem task)
    {
        if (task != null)
        {
            Tasks.Remove(task);
        }
    }
}