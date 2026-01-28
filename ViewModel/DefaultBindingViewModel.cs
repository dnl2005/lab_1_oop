using CommunityToolkit.Mvvm.ComponentModel;

namespace ViewModel;

public partial class DefaultBindingViewModel : ObservableObject
{
    [ObservableProperty]
    private string userText = "";
}