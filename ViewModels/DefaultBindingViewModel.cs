using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
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
    public partial class DefaultBindingViewModel : ObservableObject
    {
        [ObservableProperty]
        private string _textValue = "Введите текст";

        [ObservableProperty]
        private int _sliderValue = 50;

        [ObservableProperty]
        private bool _isChecked = true;

        [RelayCommand]
        private void Reset()
        {
            TextValue = "Сброшено из ViewModel";
            SliderValue = 25;
            IsChecked = false;
        }
    }
}
