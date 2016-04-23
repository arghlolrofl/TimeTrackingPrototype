using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using TimeTrackingPrototype.Shared.DataAccess;
using TimeTrackingPrototype.Shell.Wpf.ViewModels;
using TimeTrackingPrototype.Shell.Wpf.Views;

namespace TimeTrackingPrototype.Shell.Wpf {
  /// <summary>
  /// Interaction logic for App.xaml
  /// </summary>
  public partial class App : Application {


    private void Application_Startup(object sender, StartupEventArgs e) {
      using (TimeTrackingContext ctx = new TimeTrackingContext()) {
        MessageBox.Show("USER COUNT: " + ctx.Users.Count());
      }


      // Create viewmodel
      MainViewModel vm = new MainViewModel();
      // Create window
      MainWindow window = new MainWindow(vm);

      window.Show();
    }


  }
}
