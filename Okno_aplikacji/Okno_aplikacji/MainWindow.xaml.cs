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
using Logic_Layer;
using System.Threading;
using System.Windows.Threading;
using Database_Layer;


namespace Okno_aplikacji
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Database _database = new Database();
        private Object _monitorS = new Object();
        private DispatcherTimer _timer;
        private float _time = 0;
        private QueueOfCars _queueOfCars;
        private Street _streetH;
        private Street _streetV;
        private Vehicle _sTrack;
        private Vehicle _car;
        private Vehicle _truck;

        public MainWindow()
        {
            InitializeComponent();
            CreateBindings();
            _timer = new DispatcherTimer();
            _timer.Interval = TimeSpan.FromMilliseconds(500);
            _timer.Tick += new EventHandler(_timer_Tick);
        }

        void _timer_Tick(object sender, EventArgs e)
        {
            V_down.Text = _queueOfCars.QueueLenght(2).ToString();
            V_up.Text = _queueOfCars.QueueLenght(1).ToString();
            H_left.Text = _queueOfCars.QueueLenght(3).ToString();
            H_right.Text = _queueOfCars.QueueLenght(4).ToString();
            _time++;
        }

        private void CreateBindings()
        {
            ColumnSNumber.Binding = new Binding("SessionNumber");
            ColumnSTime.Binding = new Binding("SessionTime");
            ColumnSTrack.Binding = new Binding("STrack");
            ColumnCar.Binding = new Binding("Car");
            ColumnTruck.Binding = new Binding("Truck");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            TablePopup.IsOpen = !TablePopup.IsOpen;
        }

        private void FillBase()
        {
            _database.FillDatabase((_time/2).ToString(), (_streetH._amountOfSTrack + _streetV._amountOfSTrack).ToString(), (_streetH._amountOfCar + _streetV._amountOfCar).ToString(), (_streetH._amountOfTruck + _streetV._amountOfTruck).ToString());
            _time = 0;
        }

        private void FillTable()
        {
            Statistics.Items.Clear();
            var data = _database.GetData();
            data.ForEach(e => Statistics.Items.Add(e));
        }

        private void Start_Button_Click(object sender, RoutedEventArgs e)
        {
            InitializingBuissnesObjects();
            PreparingGUI();
            var sTrackThread = new Thread(new ThreadStart(_sTrack.Arrive));
            var carThread = new Thread(new ThreadStart(_car.Arrive));
            var truckThread = new Thread(new ThreadStart(_truck.Arrive));
            var streetVThread = new Thread(new ThreadStart(_streetV.Leave));
            var streetHThread = new Thread(new ThreadStart(_streetH.Leave));
            sTrackThread.Start();
            carThread.Start();
            truckThread.Start();
            streetHThread.Start();
            streetVThread.Start();
            _timer.Start();
        }

        private void PreparingGUI()
        {
            Start_Button.IsEnabled = false;
            Stop_Button.IsEnabled = true;
            V_down.Visibility = Visibility.Visible;
            V_up.Visibility = Visibility.Visible;
            H_left.Visibility = Visibility.Visible;
            H_right.Visibility = Visibility.Visible;
            V_down.Text = _queueOfCars.QueueLenght(2).ToString();
            V_up.Text = _queueOfCars.QueueLenght(1).ToString();
            H_left.Text = _queueOfCars.QueueLenght(3).ToString();
            H_right.Text = _queueOfCars.QueueLenght(4).ToString();
        }

        private void InitializingBuissnesObjects()
        {
            _queueOfCars = new QueueOfCars();
            _sTrack = new Vehicle("jednoslad", _queueOfCars);
            _car = new Vehicle("osobowy", _queueOfCars);
            _truck = new Vehicle("ciezarowy", _queueOfCars);
            _streetV = new Street("Vertical", _queueOfCars, _monitorS);
            _streetH = new Street("Horizontal", _queueOfCars, _monitorS);
        }

        private void Stop_Button_Click(object sender, RoutedEventArgs e)
        {
            Start_Button.IsEnabled = true;
            Stop_Button.IsEnabled = false;
            _timer.Stop();
            _streetH.Stop();
            _streetV.Stop();
            _sTrack.Stop();
            _car.Stop();
            _truck.Stop();
            FillBase();
            FillTable();
        }
    }
}
