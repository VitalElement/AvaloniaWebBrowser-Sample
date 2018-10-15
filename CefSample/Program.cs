using System;
using Avalonia;
using Avalonia.Logging.Serilog;
using CefGlue.Avalonia;
using CefSample.ViewModels;
using CefSample.Views;

namespace CefSample
{
    class Program
    {
        static void Main(string[] args)
        {
            BuildAvaloniaApp().ConfigureCefGlue(args).Start<MainWindow>(() => new MainWindowViewModel());
        }

        public static AppBuilder BuildAvaloniaApp()
            => AppBuilder.Configure<App>()
                .UsePlatformDetect()
                .UseReactiveUI()
                .LogToDebug();
    }
}
