using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tennisplatzreservierung.Models
{
    public class Tenniscourt
    {
        #region fields

        private readonly ReservationBook _reservationBook;

        #endregion

        #region properties

        public string Name { get; }

        #endregion

        #region constructors

        public Tenniscourt(string name)
        {
            _reservationBook = new ReservationBook();
            Name = name;
        }

        #endregion

        #region methodes
        public IEnumerable<Reservation> GetAllReservations()
        {
            return _reservationBook.GetAllReservations();
        }

        public void MakeReservation(Reservation reservation)
        {
            _reservationBook.AddReservation(reservation);
        }

        #endregion
    }
}
