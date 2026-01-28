namespace ViewModel;

public class DefaultBindingViewModel: ViewModelBase
{
    private string userText = string.Empty;
    public string UserText
    {
        get => userText;
        set { userText = value; OnPropertyChanged(); }
    }
}