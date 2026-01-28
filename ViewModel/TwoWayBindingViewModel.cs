using CommunityToolkit.Mvvm.ComponentModel;

namespace ViewModel;

public partial class TwoWayBindingViewModel : ObservableObject
{
    [ObservableProperty]
    private double userValue = 50;


    [ObservableProperty]
    private bool isEnabledFlag;
}