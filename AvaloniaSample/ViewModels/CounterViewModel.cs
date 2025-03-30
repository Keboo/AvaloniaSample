﻿using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace AvaloniaSample.ViewModels;

public partial class CounterViewModel : ObservableObject
{
    [ObservableProperty]
    private int _counter;

    [RelayCommand]
    public void Increment() => Counter++;
}
