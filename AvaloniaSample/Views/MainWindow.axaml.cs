using Avalonia.Controls;
using Avalonia.Interactivity;

using AvaloniaSample.ViewModels;

namespace AvaloniaSample.Views;

public partial class MainWindow : Window
{
    // This constructor is used when the view is created by the XAML Previewer
    public MainWindow()
    {
        InitializeComponent();
    }

    // This constructor is used when the view is created via dependency injection
    public MainWindow(MainView mainView)
        : this()
    {
        Content = mainView;
    }

    protected override async void OnLoaded(RoutedEventArgs e)
    {
        base.OnLoaded(e);

        CustomDialogViewModel viewModel = new();
        var dialog = new CustomDialog()
        {
            DataContext = viewModel
        };
        bool dialogResult = await dialog.ShowDialog<bool>(this);
        //TODO: Check the dialog result
        //TODO: Use viewModel.Name
    }
}
