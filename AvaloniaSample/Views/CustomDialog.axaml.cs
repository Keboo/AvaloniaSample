using Avalonia.Controls;

using AvaloniaSample.ViewModels;

namespace AvaloniaSample.Views;

public partial class CustomDialog : Window
{
    public CustomDialog()
    {
        InitializeComponent();
    }

    protected override void OnDataContextChanged(EventArgs e)
    {
        if (DataContext is CustomDialogViewModel viewModel)
        {
            viewModel.Close += (s, e) => Close();
        }

        base.OnDataContextChanged(e);
    }
}