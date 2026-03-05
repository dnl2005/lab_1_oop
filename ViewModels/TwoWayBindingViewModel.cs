using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using ViewModels.Command;

namespace ViewModels
{
    public partial class TwoWayBindingViewModel : ObservableObject
    {
        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(FullName))]
        private string _firstName = "Иван";

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(FullName))]
        private string _lastName = "Иванов";

        public string FullName => $"{FirstName} {LastName}";

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(ColorPreview))]
        private double _red = 128;

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(ColorPreview))]
        private double _green = 128;

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(ColorPreview))]
        private double _blue = 128;

        public string ColorPreview => $"#{(int)Red:X2}{(int)Green:X2}{(int)Blue:X2}";

        [ObservableProperty]
        private bool _isAgreed;

        [RelayCommand]
        private void SwapNames()
        {
            (FirstName, LastName) = (LastName, FirstName);
        }
    }
}
