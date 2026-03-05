using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using ViewModels.Command;

namespace ViewModels
{
    /// <summary>
    /// Привязка по умолчанию: для TextBox — TwoWay, для TextBlock — OneWay.
    /// Демонстрирует разницу поведения по умолчанию для разных контролов.
    /// </summary>
    public class DefaultBindingViewModel : BaseViewModel
    {
        private string _textValue = "Введите текст";
        public string TextValue
        {
            get => _textValue;
            set => SetProperty(ref _textValue, value);
        }

        private int _sliderValue = 50;
        public int SliderValue
        {
            get => _sliderValue;
            set => SetProperty(ref _sliderValue, value);
        }

        private bool _isChecked = true;
        public bool IsChecked
        {
            get => _isChecked;
            set => SetProperty(ref _isChecked, value);
        }

        public ICommand ResetCommand { get; }

        public DefaultBindingViewModel()
        {
            ResetCommand = new RelayCommand(_ =>
            {
                TextValue = "Сброшено из ViewModel";
                SliderValue = 25;
                IsChecked = false;
            });
        }
    }
}
