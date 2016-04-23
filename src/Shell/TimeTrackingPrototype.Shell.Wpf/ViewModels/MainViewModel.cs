using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TimeTrackingPrototype.Shell.Wpf.ViewModels
{
  public class MainViewModel : INotifyPropertyChanged
  {
    public event PropertyChangedEventHandler PropertyChanged;
    protected void RaisePropertyChanged([CallerMemberName]string propertyName = "")
      => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

    private string _windowTitle;

    public string WindowTitle
    {
      get { return _windowTitle; }
      set { _windowTitle = value; RaisePropertyChanged(); }
    }


    public MainViewModel()
    {
      WindowTitle = "Hello WPF!";
    }

    internal void DoSomething()
    {
      WindowTitle = "Hello there!";
    }
  }
}
