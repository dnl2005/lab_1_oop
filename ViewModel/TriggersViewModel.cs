namespace ViewModel;

public class TriggersViewModel : ViewModelBase
{
    private bool isActive;
    public bool IsActive
    {
        get => isActive;
        set { isActive = value; OnPropertyChanged(); }
    }
}