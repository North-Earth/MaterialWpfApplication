using MaterialWpfApplication.ViewModel;
using System.Windows.Controls;

namespace MaterialWpfApplication.View
{
    /// <summary>
    /// Логика взаимодействия для Palette.xaml
    /// </summary>
    public partial class Palette : UserControl
    {
        public Palette()
        {
            InitializeComponent();
            DataContext = new PaletteViewModel();
        }
    }
}
