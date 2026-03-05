using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using ViewModels.Command;

namespace ViewModels
{
    public class OneTimeBindingViewModel : BaseViewModel
    {
        // Эти значения зафиксируются при первой привязке и не обновятся
        private string _initialMessage = "Это начальное сообщение (OneTime)";
        public string InitialMessage
        {
            get => _initialMessage;
            set => SetProperty(ref _initialMessage, value);
        }

        private string _timestamp = DateTime.Now.ToString("HH:mm:ss");
        public string Timestamp
        {
            get => _timestamp;
            set => SetProperty(ref _timestamp, value);
        }

        private int _counter;
        public int Counter
        {
            get => _counter;
            set => SetProperty(ref _counter, value);
        }

        // Это свойство привяжем как OneWay для сравнения
        private string _liveMessage = "Это живое сообщение (OneWay для сравнения)";
        public string LiveMessage
        {
            get => _liveMessage;
            set => SetProperty(ref _liveMessage, value);
        }

        public ICommand UpdateValuesCommand { get; }

        public OneTimeBindingViewModel()
        {
            UpdateValuesCommand = new RelayCommand(_ =>
            {
                Counter++;
                InitialMessage = $"Обновлено #{Counter} (OneTime не покажет)";
                Timestamp = DateTime.Now.ToString("HH:mm:ss");
                LiveMessage = $"Обновлено #{Counter} (OneWay покажет)";
            });
        }
    }
}
