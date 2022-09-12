using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using FlightTracking.ViewModel;
using DP;
using BL;

namespace FlightTracking.Commands
{
    public class DisplayFlight : ICommand
    {
        public FlightsViewModel flightsViewModel;
        public IBL bl;
        public DisplayFlight(FlightsViewModel flightsViewModel)
        {
            this.flightsViewModel = flightsViewModel;
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            Flight flight = new Flight();
            var sumFlight = parameter as FlightSummarize;
            if (sumFlight != null)
                flight = bl.GetFlightByKey(sumFlight.Id);
            if (flight != null)
                flightsViewModel.selectedFlight = bl.getVisibleFromFlight(flight);
        }
    }
}
