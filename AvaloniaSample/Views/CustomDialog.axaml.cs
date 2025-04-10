using Avalonia.Controls;

using AvaloniaSample.ViewModels;

namespace AvaloniaSample.Views;

public partial class CustomDialog : Window
{
    public CustomDialog()
    {
        InitializeComponent();
    }

    private CustomDialogViewModel? ViewModel => DataContext as CustomDialogViewModel;

    protected override void OnDataContextChanged(EventArgs e)
    {
        if (ViewModel is { } viewModel)
        {
            viewModel.Close += (s, e) => Close(GetDialogResult());
        }

        base.OnDataContextChanged(e);
    }

    protected override void OnClosing(WindowClosingEventArgs e)
    {
        if (e.CloseReason is WindowCloseReason.WindowClosing)
        {
            e.Cancel = !CanClose();
        }
        base.OnClosing(e);
    }

    private bool CanClose()
    {
        //TODO: Arbitrary rules for when to allow closing
        return !string.IsNullOrWhiteSpace(ViewModel?.Name);
    }

    private bool GetDialogResult()
    {
        //I made the return of this method a bool, but this could be any type

        //Arbitrarily setting up the return to only be true for strings that start with K
        return ViewModel?.Name?.StartsWith('K') == true;
    }
}