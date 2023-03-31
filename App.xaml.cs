using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Tenniscourtreservation.Exeptions;
using Tenniscourtreservation.Stores;
using Tenniscourtreservation.ViewModels;
using Tennisplatzreservierung.Models;

namespace Tenniscourtreservation
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly Tenniscourt _tenniscourt;
        private readonly NavigationStore _navigationStore;


        public App()
        {
            _tenniscourt = new Tenniscourt("Tennisplatz Goldegg");
            _navigationStore = new NavigationStore();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            _navigationStore.CurrentViewModel = CreateReservationViewModel();

            MainWindow = new MainWindow()
            {
                DataContext = new MainViewModel(_navigationStore)
            };

            MainWindow.Show();

            base.OnStartup(e);
        }

        private MakeReservationViewModel CreateMakeReservationViewModel()
        {
            return new MakeReservationViewModel(_tenniscourt, _navigationStore, CreateReservationViewModel);
        }

        private ReservationListingViewModel CreateReservationViewModel()
        {
            return new ReservationListingViewModel(_navigationStore, CreateMakeReservationViewModel);
        }
    }
}
