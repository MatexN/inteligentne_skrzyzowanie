using System;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Okno_aplikacji
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ColumnSNumber.Binding = new Binding("SessionNumber");
            ColumnSTime.Binding = new Binding("SessionTime");
            ColumnSTrack.Binding = new Binding("STrack");
            ColumnCar.Binding = new Binding("Car");
            ColumnTruck.Binding = new Binding("Truck");
            FillTable();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            TablePopup.IsOpen = !TablePopup.IsOpen;
        }

        private void FillTable()
        {
        }
    }
}
