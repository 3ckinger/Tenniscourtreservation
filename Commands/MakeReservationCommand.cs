using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Tenniscourtreservation.Exeptions;
using Tenniscourtreservation.ViewModels;
using Tennisplatzreservierung.Models;

namespace Tenniscourtreservation.Commands
{
    public class MakeReservationCommand : CommandBase
    {
        private readonly MakeReservationViewModel _makeReservationViewModel;
        private readonly Tenniscourt _tenniscourt;

        public MakeReservationCommand(MakeReservationViewModel makeReservationViewModel, Tenniscourt tenniscourt)
        {
            _makeReservationViewModel = makeReservationViewModel;
            _tenniscourt = tenniscourt;
            _makeReservationViewModel.PropertyChanged += OnViewModelPropertyChanged;
        }


        public override bool CanExecute(object? parameter)
        {
            return !string.IsNullOrEmpty(_makeReservationViewModel.Playername) && 
                _makeReservationViewModel.EndTime >= _makeReservationViewModel.StartTime 
                && base.CanExecute(parameter);
        }

        public override void Execute(object? parameter)
        {
            Reservation reservation = new Reservation(
                new CourtID(_makeReservationViewModel.CourtNumber, _makeReservationViewModel.CourtSide), 
                _makeReservationViewModel.Playername, 
                _makeReservationViewModel.StartTime, 
                _makeReservationViewModel.EndTime);

            try
            {
                _tenniscourt.MakeReservation(reservation);
                MessageBox.Show("Erfolgreich gebucht!", "Erfolgreich", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (ReservationConflictException)
            {
                MessageBox.Show("Platz wird schon verwendet!","Fehlgeschlagen", MessageBoxButton.OK,MessageBoxImage.Error);
            }

        }
        private void OnViewModelPropertyChanged(object? sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(MakeReservationViewModel.Playername) || 
                e.PropertyName == nameof(MakeReservationViewModel.EndTime) || 
                e.PropertyName == nameof(MakeReservationViewModel.StartTime)) 
            {
                OnCanExecuteChanged();
            }
        }
    }
}
