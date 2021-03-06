﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using TimeTrackingPrototype.Shell.Wpf.ViewModels;

namespace TimeTrackingPrototype.Shell.Wpf.Views
{
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window
  {
    private MainViewModel _viewModel;

    public MainWindow(MainViewModel viewmodel)
    {
      InitializeComponent();

      DataContext = _viewModel = viewmodel;
    }

    private void Button_Click(object sender, RoutedEventArgs e)
    {
      _viewModel.DoSomething();
    }
  }
}
