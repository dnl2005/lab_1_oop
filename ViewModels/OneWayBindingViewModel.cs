using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Windows.Input;
using System.Windows.Threading;
using ViewModels.Command;

namespace ViewModels
{
    public partial class OneWayBindingViewModel : ObservableObject
    {
        [ObservableProperty]
        private string _currentTime = DateTime.Now.ToString("HH:mm:ss");

        [ObservableProperty]
        private int _tickCount;

        [ObservableProperty]
        private double _progress;

        [ObservableProperty]
        private string _userInput = "";

        [ObservableProperty]
        private int _userInputLength;

        private readonly DispatcherTimer _timer;
        private bool _isRunning;

        public OneWayBindingViewModel()
        {
            _timer = new DispatcherTimer { Interval = TimeSpan.FromSeconds(1) };
            _timer.Tick += (_, _) =>
            {
                CurrentTime = DateTime.Now.ToString("HH:mm:ss");
                TickCount++;
                Progress = TickCount % 100;
            };
        }

        [RelayCommand]
        private void ToggleTimer()
        {
            if (_isRunning) _timer.Stop(); else _timer.Start();
            _isRunning = !_isRunning;
        }

        [RelayCommand]
        private void UpdateFromVm()
        {
            UserInput = "Установлено из ViewModel (не отобразится при OneWayToSource)";
        }
    }
}
