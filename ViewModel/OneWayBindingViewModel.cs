using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace ViewModel;

public partial class OneWayBindingViewModel : ObservableObject
{
    [ObservableProperty]
    private int progressValue = 30;


    [ObservableProperty]
    private string inputText = string.Empty;


    [RelayCommand]
    private void Increase()
    {
        if (ProgressValue < 100)
            ProgressValue += 10;
    }
}