using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace ViewModel;

public partial class OneTimeBindingViewModel : ObservableObject
{
    [ObservableProperty]
    private string timeStamp = DateTime.Now.ToLongTimeString();


    [RelayCommand]
    private void UpdateTime()
    {
        TimeStamp = DateTime.Now.ToLongTimeString();
    }
}