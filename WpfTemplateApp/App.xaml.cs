using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using WpfTemplateApp.Model;
using WpfTemplateApp.ViewModel;

namespace WpfTemplateApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            //The other way would be to override the OnStartup routine in the Application class 
            //(John Smith does it this way in his The MVVM-Design Pattern MSDN Article) and 
            //start by creating the model, 
            //passing it to the ViewModel Contructor and 
            //assign the newly created ViewModel to the DataContext of a separately created View / Window.
            MainViewModel mainViewModel = new MainViewModel(new User());
            MainWindow mainWindow = new MainWindow();
            mainWindow.DataContext = mainViewModel;
            
            mainWindow.Show();
        }
    }


}
