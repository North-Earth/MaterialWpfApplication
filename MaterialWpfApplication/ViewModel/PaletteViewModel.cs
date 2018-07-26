using MaterialDesignColors;
using MaterialDesignThemes.Wpf;
using MaterialWpfApplication.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MaterialWpfApplication.ViewModel
{
    public class PaletteViewModel : ObservableObject
    {
        public IEnumerable<Swatch> Swatches { get; set; }

        public PaletteViewModel() => Swatches = new SwatchesProvider().Swatches;

        private ICommand SetThemeCommand
        {
            get
            {
                return new DelegateCommand(o => ChangeTheme((bool)o));
            }
        }

        private void ChangeTheme(bool IsDark) => new PaletteHelper().SetLightDark(IsDark);

        public ICommand ApplyPrimaryCommand { get; } = new DelegateCommand(o => ApplayPrimary((Swatch)o));

        public ICommand ApplyAccentCommand { get; } = new DelegateCommand(o => ApplayAccent((Swatch)o));

        private static void ApplayPrimary(Swatch swatch) => new PaletteHelper().ReplacePrimaryColor(swatch);

        private static void ApplayAccent(Swatch swatch) => new PaletteHelper().ReplaceAccentColor(swatch);
    }
}
