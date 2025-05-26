// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;
// using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls; // WPF Window
// using System.Windows.Controls; // Nicht nötig, wenn Basisklasse Window ist
// using Xamarin.Forms; // Entfernt
// using Xamarin.Forms.Xaml; // Entfernt

namespace ErweiterterDateiOrganisator.Wpf.Views
{
    // [XamlCompilation(XamlCompilationOptions.Compile)] // Entfernt
    public partial class MainView : UserControl // Geändert zu Window
    {
        public MainView()
        {
            InitializeComponent();
        }
    }
}