using CommunityToolkit.Mvvm.ComponentModel;

namespace ViewModel;

public partial class TriggersViewModel : ObservableObject
{
    [ObservableProperty]
    private bool isActive;
}