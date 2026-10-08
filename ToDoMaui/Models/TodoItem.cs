using System;
using System.Collections.Generic;
using System.Text;
using CommunityToolkit.Mvvm.ComponentModel;

namespace ToDoMaui.Models;

public partial class TodoItem : ObservableObject
{
    [ObservableProperty]
    public partial string TaskName { get; set; }

    [ObservableProperty]
    public partial bool IsCompleted { get; set; }
}
