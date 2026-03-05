using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using System.Windows.Threading;
using ViewModels.Command;

namespace ViewModels
{
    public class OneWayBindingViewModel : BaseViewModel
    {
        // --- OneWay (Source → Target) ---
        private string _currentTime = DateTime.Now.ToString("HH:mm:ss");
        public string CurrentTime
        {
            get => _currentTime;
            set => SetProperty(ref _currentTime, value);
        }

        private int _tickCount;
        public int TickCount
        {
            get => _tickCount;
            set => SetProperty(ref _tickCount, value);
        }

        private double _progress;
        public double Progress
        {
            get => _progress;
            set => SetProperty(ref _progress, value);
        }

        // --- OneWayToSource (Target → Source): TextBox обновит VM, но VM не обновит TextBox ---
        private string _userInput = "";
        public string UserInput
        {
            get => _userInput;
            set => SetProperty(ref _userInput, value);
        }

        private int _userInputLength;
        public int UserInputLength
        {
            get => _userInputLength;
            set => SetProperty(ref _userInputLength, value);
        }

        private readonly DispatcherTimer _timer;
        private bool _isRunning;

        public ICommand ToggleTimerCommand { get; }
        public ICommand UpdateFromVmCommand { get; }

        public OneWayBindingViewModel()
        {
            _timer = new DispatcherTimer { Interval = TimeSpan.FromSeconds(1) };
            _timer.Tick += (_, _) =>
            {
                CurrentTime = DateTime.Now.ToString("HH:mm:ss");
                TickCount++;
                Progress = (TickCount % 100);
            };

            ToggleTimerCommand = new RelayCommand(_ =>
            {
                if (_isRunning) _timer.Stop(); else _timer.Start();
                _isRunning = !_isRunning;
            });

            UpdateFromVmCommand = new RelayCommand(_ =>
            {
                // Для OneWayToSource привязки это изменение НЕ дойдёт до TextBox
                UserInput = "Установлено из ViewModel (не отобразится при OneWayToSource)";
            });
        }
    }
}
