using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Text;
using System.Windows.Input;
using ViewModels.Command;

namespace ViewModels
{
    public partial class OneTimeBindingViewModel : ObservableObject
    {
        [ObservableProperty]
        private string _initialMessage = "Это начальное сообщение (OneTime)";

        [ObservableProperty]
        private string _timestamp = DateTime.Now.ToString("HH:mm:ss");

        [ObservableProperty]
        private int _counter;

        [ObservableProperty]
        private string _liveMessage = "Это живое сообщение (OneWay для сравнения)";

        [RelayCommand]
        private void UpdateValues()
        {
            Counter++;
            InitialMessage = $"Обновлено #{Counter} (OneTime не покажет)";
            Timestamp = DateTime.Now.ToString("HH:mm:ss");
            LiveMessage = $"Обновлено #{Counter} (OneWay покажет)";
        }
    }
}
