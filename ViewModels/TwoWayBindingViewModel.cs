using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using ViewModels.Command;

namespace ViewModels
{
    public class TwoWayBindingViewModel : BaseViewModel
    {
        // --- Привязка через ViewModel ---
        private string _firstName = "Иван";
        public string FirstName
        {
            get => _firstName;
            set
            {
                if (SetProperty(ref _firstName, value))
                    OnPropertyChanged(nameof(FullName));
            }
        }

        private string _lastName = "Иванов";
        public string LastName
        {
            get => _lastName;
            set
            {
                if (SetProperty(ref _lastName, value))
                    OnPropertyChanged(nameof(FullName));
            }
        }

        public string FullName => $"{FirstName} {LastName}";

        private double _red = 128;
        public double Red
        {
            get => _red;
            set
            {
                if (SetProperty(ref _red, value))
                    OnPropertyChanged(nameof(ColorPreview));
            }
        }

        private double _green = 128;
        public double Green
        {
            get => _green;
            set
            {
                if (SetProperty(ref _green, value))
                    OnPropertyChanged(nameof(ColorPreview));
            }
        }

        private double _blue = 128;
        public double Blue
        {
            get => _blue;
            set
            {
                if (SetProperty(ref _blue, value))
                    OnPropertyChanged(nameof(ColorPreview));
            }
        }

        public string ColorPreview => $"#{(int)Red:X2}{(int)Green:X2}{(int)Blue:X2}";

        private bool _isAgreed;
        public bool IsAgreed
        {
            get => _isAgreed;
            set => SetProperty(ref _isAgreed, value);
        }

        public ICommand SwapNamesCommand { get; }

        public TwoWayBindingViewModel()
        {
            SwapNamesCommand = new RelayCommand(_ =>
            {
                (FirstName, LastName) = (LastName, FirstName);
            });
        }
    }
}
