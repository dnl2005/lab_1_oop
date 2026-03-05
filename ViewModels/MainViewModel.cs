using System;
using System.Collections.Generic;
using System.Text;

namespace ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        // Обязательно public get — иначе Binding не найдёт!
        public DefaultBindingViewModel DefaultBindingVm { get; }
        public TwoWayBindingViewModel TwoWayBindingVm { get; }
        public OneTimeBindingViewModel OneTimeBindingVm { get; }
        public OneWayBindingViewModel OneWayBindingVm { get; }
        public TriggersViewModel TriggersVm { get; }

        public MainViewModel()
        {
            DefaultBindingVm = new DefaultBindingViewModel();
            TwoWayBindingVm = new TwoWayBindingViewModel();
            OneTimeBindingVm = new OneTimeBindingViewModel();
            OneWayBindingVm = new OneWayBindingViewModel();
            TriggersVm = new TriggersViewModel();
        }
    }
}
