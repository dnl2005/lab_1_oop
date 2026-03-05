using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Windows;

namespace UI
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            // Ошибки привязок будут видны в Output окне VS
            PresentationTraceSources.DataBindingSource.Listeners
                .Add(new ConsoleTraceListener());
            PresentationTraceSources.DataBindingSource.Switch.Level =
                SourceLevels.Warning;
        }
    }

}
