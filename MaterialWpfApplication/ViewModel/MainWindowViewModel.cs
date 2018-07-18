using MaterialWpfApplication.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MaterialWpfApplication.ViewModel
{
    public class MainWindowViewModel
    {
        MainWindow window = Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();

        public MainWindowViewModel()
        {
            OpenPaletteCommand = new DelegateCommand(o => OpenPalette());
        }

        #region Command

        public DelegateCommand OpenPaletteCommand { get; set; }

        #endregion

        #region Command implementation

        private void OpenPalette()
        {
            window.mainGrid.Children.Clear();
            window.mainGrid.Children.Add(new View.Palette());
        }

        #endregion
    }
}
