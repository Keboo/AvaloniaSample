using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace AvaloniaSample.ViewModels;

public partial class CustomDialogViewModel : ObservableObject
{
    public event EventHandler? Close;

    [ObservableProperty]
    private string? _name;

    [RelayCommand]
    public void Ok()
    {
        // Logic for OK button
        Close?.Invoke(this, EventArgs.Empty);
    }
}
