using Igris.OtakuWorld.Creation.ViewModels;
using MahApps.Metro.Controls;

namespace Igris.OtakuWorld
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            DataContext = new MainViewModel();

            InitializeComponent();
        }
    }
}
