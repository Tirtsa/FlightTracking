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
using BL;
using Microsoft.Maps.MapControl.WPF;
using DP;
using System.Windows.Threading;

namespace FlightTracking
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static IBL bl = new BLIMP();
        MapPolyline polyline;
        static List<FlightSummarize> allFlights = bl.getAllFlights();
        FlightVisibleInfo SelectedFlight = new FlightVisibleInfo();
        DispatcherTimer timer = new DispatcherTimer();

        public ViewModel.FlightsViewModel currentVM;

        public MainWindow()
        {
            InitializeComponent();
            currentVM = new ViewModel.FlightsViewModel(this);
            this.DataContext = currentVM;
        }

        private void addPolyline(string key)
        {
            Flight myFlight = bl.GetFlightByKey(key);
            var Route = myFlight.trail.OrderByDescending(trail => trail.ts);

            polyline = new MapPolyline
            {
                Stroke = new SolidColorBrush(Colors.Green),
                StrokeThickness = 1,
                Opacity = 0.7,
                Locations = new LocationCollection()
            };

            foreach (var item in Route)
            {
                polyline.Locations.Add(new Location(item.lat, item.lng));
            }
            myMap.Children.Add(polyline);
        }

        private void Pushpin_MouseDoubleClick_1(object sender, MouseButtonEventArgs e)
        {
            FlightSummarize SummarizeSelectedFlight = (FlightSummarize)((Pushpin)sender).DataContext;
            Flight CompleteSelectedFlight = bl.GetFlightByKey(SummarizeSelectedFlight.Id);
            SelectedFlight = bl.getVisibleFromFlight(CompleteSelectedFlight);
            MyAirportUC.DataContext = SelectedFlight;
            addPolyline(SelectedFlight.Id);
        }

        private void Pushpin_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {

        }
    }
}
