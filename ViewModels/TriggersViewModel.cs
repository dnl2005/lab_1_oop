using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using ViewModels.Command;

namespace ViewModels
{
    public class TriggersViewModel : BaseViewModel
    {
        // Для DataTrigger
        private bool _isActive;
        public bool IsActive
        {
            get => _isActive;
            set => SetProperty(ref _isActive, value);
        }

        private string _status = "Inactive";
        public string Status
        {
            get => _status;
            set => SetProperty(ref _status, value);
        }

        // Для MultiDataTrigger
        private bool _hasUsername;
        public bool HasUsername
        {
            get => _hasUsername;
            set => SetProperty(ref _hasUsername, value);
        }

        private bool _hasPassword;
        public bool HasPassword
        {
            get => _hasPassword;
            set => SetProperty(ref _hasPassword, value);
        }

        private string _username = "";
        public string Username
        {
            get => _username;
            set
            {
                if (SetProperty(ref _username, value))
                    HasUsername = !string.IsNullOrWhiteSpace(value);
            }
        }

        private string _password = "";
        public string Password
        {
            get => _password;
            set
            {
                if (SetProperty(ref _password, value))
                    HasPassword = !string.IsNullOrWhiteSpace(value);
            }
        }

        // Для EventTrigger — счётчик кликов
        private int _clickCount;
        public int ClickCount
        {
            get => _clickCount;
            set => SetProperty(ref _clickCount, value);
        }

        public ObservableCollection<string> StatusOptions { get; } = new()
        {
            "Inactive", "Active", "Warning", "Error"
        };

        public ICommand ToggleActiveCommand { get; }
        public ICommand IncrementClickCommand { get; }

        public TriggersViewModel()
        {
            ToggleActiveCommand = new RelayCommand(_ =>
            {
                IsActive = !IsActive;
                Status = IsActive ? "Active" : "Inactive";
            });

            IncrementClickCommand = new RelayCommand(_ =>
            {
                ClickCount++;
            });
        }
    }
}
