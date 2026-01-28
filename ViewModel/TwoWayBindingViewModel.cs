namespace ViewModel;

public class TwoWayBindingViewModel : ViewModelBase
{
    private double userValue = 50;
    public double UserValue
    {
        get => userValue;
        set { userValue = value; OnPropertyChanged(); }
    }


    private bool isEnabledFlag;
    public bool IsEnabledFlag
    {
        get => isEnabledFlag;
        set { isEnabledFlag = value; OnPropertyChanged(); }
    }
}