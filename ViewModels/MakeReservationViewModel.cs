using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Tenniscourtreservation.Commands;
using Tenniscourtreservation.Stores;
using Tennisplatzreservierung.Models;

namespace Tenniscourtreservation.ViewModels
{
    public class MakeReservationViewModel : ViewModelBase
    {
        #region properties

        private string _playername;
        public string Playername
        {
            get
            {
                return _playername;
            }
            set
            {
                _playername = value;
                OnPropertyChanged(nameof(Playername));
            }

        }

        private int _courtNumber;
        public int CourtNumber
        {
            get
            {
                return _courtNumber;
            }
            set
            {
                _courtNumber = value;
                OnPropertyChanged(nameof(CourtNumber));
            }

        }

        private int _courtSide;
        public int CourtSide
        {
            get
            {
                return _courtSide;
            }
            set
            {
                _courtSide = value;
                OnPropertyChanged(nameof(CourtSide));
            }

        }

        private DateTime _startTime = DateTime.Now;
        public DateTime StartTime
        {
            get
            {
                return _startTime;
            }
            set
            {
                _startTime = value;
                OnPropertyChanged(nameof(StartTime));
            }

        }

        private DateTime _endTime = new DateTime(2023,DateTime.Now.Month + 1, 1);
        public DateTime EndTime
        {
            get
            {
                return _endTime;
            }
            set
            {
                _endTime = value;
                OnPropertyChanged(nameof(EndTime));
            }

        }

        #endregion

        #region commands

        public ICommand SumitCommand { get; }
        public ICommand CancelCommand { get; }

        #endregion

        public MakeReservationViewModel(Tenniscourt tenniscourt, NavigationStore navigationStore, Func<ReservationListingViewModel> createReservationListingViewModel)
        {
            SumitCommand = new MakeReservationCommand(this, tenniscourt);
            CancelCommand = new NavigateCommand(navigationStore, createReservationListingViewModel);
        }

    }
}
