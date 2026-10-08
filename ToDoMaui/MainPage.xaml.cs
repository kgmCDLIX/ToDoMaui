using ToDoMaui.ViewModels;

namespace ToDoMaui;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();

        BindingContext = new MainViewModel();
    }
}


