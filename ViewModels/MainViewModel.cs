using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        public DefaultBindingViewModel DefaultBindingVm { get; } = new();
        public TwoWayBindingViewModel TwoWayBindingVm { get; } = new();
        public OneTimeBindingViewModel OneTimeBindingVm { get; } = new();
        public OneWayBindingViewModel OneWayBindingVm { get; } = new();
        public TriggersViewModel TriggersVm { get; } = new();
    }
}
