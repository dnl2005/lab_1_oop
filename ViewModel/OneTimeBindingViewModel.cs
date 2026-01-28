using System.Windows.Input;

namespace ViewModel;

public class OneTimeBindingViewModel : ViewModelBase
{
    private string timeStamp;
    public string TimeStamp
    {
        get => timeStamp;
        set { timeStamp = value; OnPropertyChanged(); }
    }


    public ICommand UpdateTimeCommand { get; }


    public OneTimeBindingViewModel()
    {
        TimeStamp = DateTime.Now.ToLongTimeString();
        UpdateTimeCommand = new RelayCommand(_ =>
        {
            TimeStamp = DateTime.Now.ToLongTimeString();
        });
    }
}