using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.NetworkInformation;
using System.Text;
using System.Windows.Input;
using ViewModels.Command;

namespace ViewModels
{
    public partial class TriggersViewModel : ObservableObject
    {
        [ObservableProperty]
        private bool _isActive;

        [ObservableProperty]
        private string _status = "Inactive";

        [ObservableProperty]
        private bool _hasUsername;

        [ObservableProperty]
        private bool _hasPassword;

        [ObservableProperty]
        private int _clickCount;

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

        public ObservableCollection<string> StatusOptions { get; } = new()
        {
            "Inactive", "Active", "Warning", "Error"
        };

        [RelayCommand]
        private void ToggleActive()
        {
            IsActive = !IsActive;
            Status = IsActive ? "Active" : "Inactive";
        }

        [RelayCommand]
        private void IncrementClick()
        {
            ClickCount++;
        }
    }
}
