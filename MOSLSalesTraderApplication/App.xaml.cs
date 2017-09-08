using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Telerik.Windows.Controls;

namespace MOSLSalesTraderApplication
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {            
            try
            {
                RadWindow radWindow = new RadWindow();
                radWindow.Width = 400;
                radWindow.Height = 300;
                radWindow.Content = new MainWindow();
                radWindow.Header = "Login";
                radWindow.Owner = Application.Current.MainWindow;
                radWindow.WindowStartupLocation = WindowStartupLocation.CenterScreen;
                radWindow.ResizeMode = ResizeMode.NoResize;
                radWindow.ShowDialog();
            }
            catch (Exception ex)
            {
                throw;
            }
        }      
    }
}
