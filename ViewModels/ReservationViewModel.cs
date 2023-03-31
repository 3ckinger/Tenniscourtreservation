using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tennisplatzreservierung.Models;

namespace Tenniscourtreservation.ViewModels
{
    public class ReservationViewModel : ViewModelBase
    {
        #region fields

        private readonly Reservation _reservation;

        #endregion

        #region properties

        public string CourtID => _reservation.CourtID.ToString();
        public string Playername => _reservation.Playername;
        public string StartTime => _reservation.StartTime.ToString("g");
        public string EndTime => _reservation.EndTime.ToString("g");

        #endregion

        public ReservationViewModel(Reservation reservation)
        {
            _reservation = reservation;
        }

    }
}
