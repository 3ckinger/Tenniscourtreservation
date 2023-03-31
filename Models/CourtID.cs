using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace Tennisplatzreservierung.Models
{
    public class CourtID
    {
        
        #region properties

        public int Courtnumber { get; } // 1 bis 3
        public int CourtSideNumber { get; } // 1 oder 2

        #endregion

        #region constructors

        public CourtID(int courtnumber, int courtSideNumber)
        {
            Courtnumber = courtnumber;
            CourtSideNumber = courtSideNumber;
        }

        #endregion

        #region methodes

        public override string ToString()
        {
            return $"{Courtnumber} ({CourtSideNumber})";
        }

        public override bool Equals(object? obj)
        {
            return obj is CourtID court &&
                Courtnumber == court.Courtnumber &&
                CourtSideNumber == court.CourtSideNumber;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Courtnumber, CourtSideNumber);
        }

        public static bool operator == (CourtID courtId1 , CourtID courtId2)
        {
            if(courtId1 is null && courtId2 is null ) return true;

            return !(courtId1 is null) && courtId1.Equals( courtId2 );
        }

        public static bool operator != (CourtID courtId1, CourtID courtId2)
        {
            return !(courtId1 == courtId2);
        }

        #endregion
    }
}
