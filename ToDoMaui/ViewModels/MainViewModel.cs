using System;
using System.Collections.Generic;
using System.Text;

using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ToDoMaui.Models;

namespace ToDoMaui.ViewModels;

public partial class MainViewModel : ObservableObject
{
    public ObservableCollection<TodoItem> Tasks { get; } = new();

    [ObservableProperty]
    public partial string? NewTaskTitle { get; set; }

    public MainViewModel()
    {
        Tasks.Add(new TodoItem
        {
            TaskName = "Купить нового хомяка",
            IsCompleted = true
        });

        Tasks.Add(new TodoItem
        {
            TaskName = "закончить лабораторную",
            IsCompleted = false
        });
    }

    [RelayCommand]
    private void AddTask()
    {
        if (string.IsNullOrWhiteSpace(NewTaskTitle))
            return;

        Tasks.Insert(0,new TodoItem
        {
            TaskName = NewTaskTitle.Trim(),
            IsCompleted = false
        });

        NewTaskTitle = string.Empty;
    }

    [RelayCommand]
    private void DeleteTask(TodoItem task)
    {
        if (task is null)
            return;

        Tasks.Remove(task);
    }
}
