using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tennisplatzreservierung.Models
{
    public class Reservation
    {
        #region properties

        public CourtID CourtID { get; }
        public string Playername { get; }
        public DateTime StartTime { get; }
        public DateTime EndTime { get; }
        public TimeSpan Length => EndTime.Subtract(StartTime);

        #endregion

        #region constructors

        public Reservation(CourtID courtID, string playername, DateTime startTime, DateTime endTime)
        {
            CourtID = courtID;
            Playername = playername;
            StartTime = startTime;
            EndTime = endTime;
        }

        #endregion

        #region methodes

        internal bool Conflicts(Reservation reservation)
        {
            if (!reservation.CourtID.Equals(CourtID)) return false;

            return reservation.StartTime <= EndTime && reservation.EndTime >= StartTime;
        }

        #endregion
    }
}
