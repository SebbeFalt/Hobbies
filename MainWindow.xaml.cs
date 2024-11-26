using Hobbies.ViewModels;
using System.Windows;

namespace Hobbies
{
  public partial class MainWindow : Window
  {
    public MainWindow()
    {
      InitializeComponent();
      MainWindowViewModel vm = new MainWindowViewModel();
      DataContext = vm;
    }
  }
}