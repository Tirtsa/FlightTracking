using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DP;
using BL;
using System.Windows.Threading;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace FlightTracking.ViewModel
{
    public class FlightsViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        static IBL bl = new BLIMP();
        public ObservableCollection<FlightSummarize> allFlights;
        DispatcherTimer timer = new DispatcherTimer();
        private MainWindow mainWindow;
        public FlightVisibleInfo selectedFlight = new FlightVisibleInfo();

        public FlightsViewModel()
        {
            allFlights = new ObservableCollection<FlightSummarize>(bl.getAllFlights());
            timer.Interval = new TimeSpan(0, 0, 2);
            timer.Tick += new EventHandler(Tick);
            Tick(this, null);
            timer.Start();
        }

        public FlightsViewModel(MainWindow mainWindow)
        {
            this.mainWindow = mainWindow;
            allFlights = new ObservableCollection<FlightSummarize>(bl.getAllFlights());
            timer.Interval = new TimeSpan(0, 0, 2);
            timer.Tick += new EventHandler(Tick);
            Tick(this, null);
            timer.Start();
        }

        private void Tick(Object sender, EventArgs e)
        {
            allFlights = new ObservableCollection<FlightSummarize>(bl.getAllFlights());
            mainWindow.pushpins.ItemsSource = allFlights;
        }
    }
}
