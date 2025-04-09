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

    protected override void OnLoaded(RoutedEventArgs e)
    {
        base.OnLoaded(e);

        var dialog = new CustomDialog()
        {
            DataContext = new CustomDialogViewModel
            {
                Message = "Welcome to the demo"
            }
        };
        dialog.ShowDialog(this);
    }
}
