using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tenniscourtreservation.Exeptions;

namespace Tennisplatzreservierung.Models
{
    public class ReservationBook
    {
        #region fields

        private readonly List<Reservation> _reservations;

        #endregion

        #region constructors

        public ReservationBook()
        {
            _reservations = new List<Reservation>();
        }

        #endregion

        #region methodes

        public IEnumerable<Reservation> GetAllReservations()
        {
            return _reservations;
        }

        public void AddReservation(Reservation reservation)
        {
            foreach (Reservation existingReservation in _reservations)
            {
                if (existingReservation.Conflicts(reservation))
                {
                    throw new ReservationConflictException(existingReservation, reservation);
                }
            }
            _reservations.Add(reservation);
        }

        #endregion
    }
}
