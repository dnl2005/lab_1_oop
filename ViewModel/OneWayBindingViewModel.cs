using System.Windows.Input;

namespace ViewModel;

public class OneWayBindingViewModel : ViewModelBase
{
    private int progressValue = 30;
    public int ProgressValue
    {
        get => progressValue;
        set { progressValue = value; OnPropertyChanged(); }
    }


    private string inputText = string.Empty;
    public string InputText
    {
        get => inputText;
        set { inputText = value; OnPropertyChanged(); }
    }


    public ICommand IncreaseCommand { get; }


    public OneWayBindingViewModel()
    {
        IncreaseCommand = new RelayCommand(_ =>
        {
            if (ProgressValue < 100)
                ProgressValue += 10;
        });
    }
}