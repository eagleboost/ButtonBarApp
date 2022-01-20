namespace ButtonBarApp
{
  using ViewModels;

  /// <summary>
  /// MainWindow.xaml 的交互逻辑
  /// </summary>
  public partial class MainWindow
  {
    public MainWindow()
    {
      InitializeComponent();

      DataContext = new ModulesViewModel();
    }
  }
}
