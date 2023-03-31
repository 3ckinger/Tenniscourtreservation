using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Tenniscourtreservation.Exeptions;
using Tennisplatzreservierung.Models;

namespace Tenniscourtreservation
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            Tenniscourt tenniscourt = new Tenniscourt("Goldegg");

            try
            {
                tenniscourt.MakeReservation(new Reservation(
                courtID: new CourtID(1, 1),
                playername: "hias",
                startTime: new DateTime(2023, 1, 1),
                endTime: new DateTime(2023, 2, 1)));

                tenniscourt.MakeReservation(new Reservation(
                    courtID: new CourtID(1, 2),
                    playername: "hias",
                    startTime: new DateTime(2023, 1, 1),
                    endTime: new DateTime(2023, 2, 1)));
            }
            catch (ReservationConflictException ex)
            {

                
            }

            IEnumerable<Reservation> reservations = tenniscourt.GetAllReservations();

            base.OnStartup(e);
        }
    }
}
