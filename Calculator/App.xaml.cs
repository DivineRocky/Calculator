using Interfces;
using Services.Factories;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Unity;

namespace Calculator
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            IUnityContainer container = new UnityContainer();
            container.RegisterSingleton<ICalculateOperationFactory, CalculateOperationFactory>();

            var c = container.Resolve<ICalculateOperationFactory>();
            //MainWindow mainWindow = container.Resolve<MainWindow>(c);
            //mainWindow.Show();
        }
    }
}
